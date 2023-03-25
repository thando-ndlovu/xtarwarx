using Domain.Models;

using MongoDB.Driver;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Repository.Implementations.MongoDb
{
	public class MongoDbRepositoryCollection<TEntity> : IRepository.ISet<TEntity> where TEntity : class, IStarWarsModel
	{
		public MongoDbRepositoryCollection(IMongoCollection<TEntity> mongocollection)
		{
			_MongoCollection = mongocollection;
		}

		protected readonly IMongoCollection<TEntity> _MongoCollection;

		public IQueryable<TEntity> AsQueryable()
		{
			return _MongoCollection.AsQueryable();
		}

		public TEntity? Create(TEntity entity)
		{
			bool idpresent = _MongoCollection
				.Find(_ => _.Id == entity.Id)
				.Any();

			if (idpresent is true)
				return null;

			entity.Created = DateTime.Now;

			_MongoCollection.InsertOne(entity);

			return entity;
		}
		public async Task<TEntity?> Create(TEntity entity, CancellationToken cancellationToken = default)
		{
			IAsyncCursor<TEntity> idpresentcursor = await _MongoCollection
				.FindAsync(
					filter: _ => _.Id == entity.Id,
					cancellationToken: cancellationToken);

			bool idpresent = await idpresentcursor.AnyAsync();

			if (idpresent is true)
				return null;

			entity.Created = DateTime.Now;

			_MongoCollection.InsertOne(entity);

			return entity;
		}
		public IEnumerable<TEntity> Create(params TEntity[] entities)
		{
			IEnumerable<int> presentids = _MongoCollection
				.Find(_ => entities.Any(__ => __.Id == _.Id))
				.Project(_ => _.Id)
				.ToEnumerable();

			IEnumerable<TEntity> documents = entities
				.Where(entity => !presentids.Contains(entity.Id))
				.Select(entity =>
				{
					entity.Created = DateTime.Now;

					return entity;
				});

			_MongoCollection.InsertMany(
				documents: documents,
				options: new InsertManyOptions { });

			return documents;
		}
		public async IAsyncEnumerable<TEntity> Create([EnumeratorCancellation]CancellationToken cancellationToken = default, params TEntity[] entities)
		{
			IAsyncCursor<TEntity> presententitiescursor = await _MongoCollection.FindAsync(
				cancellationToken: cancellationToken,
				filter: _ => entities.Any(entity => entity.Id == _.Id));

			IEnumerable<int> presententityids = presententitiescursor
				.ToEnumerable(cancellationToken)
				.Select(entity => entity.Id);

			IEnumerable<TEntity> entitiestocreate = entities
				.Where(entity => !presententityids.Contains(entity.Id))
				.Select(entity =>
				{
					entity.Created = DateTime.Now;

					return entity;
				});

			await _MongoCollection.InsertManyAsync(
				documents: entitiestocreate,
				cancellationToken: cancellationToken);

			foreach (TEntity entity in entitiestocreate)
			{
				yield return entity;
			}
		}

		public TEntity? Delete(TEntity entity)
		{
			return _MongoCollection.FindOneAndDelete(
				filter: _ => _.Id == entity.Id);
		}
		public async Task<TEntity?> Delete(TEntity entity, CancellationToken cancellationToken = default)
		{
			return await _MongoCollection.FindOneAndDeleteAsync(
				filter: _ => _.Id == entity.Id,
				cancellationToken: cancellationToken);
		}
		public IEnumerable<TEntity> Delete(params TEntity[] entities)
		{
			return entities.Select(_ =>
			{
				return _MongoCollection.FindOneAndDelete(
					filter: __ => __.Id == _.Id);
			});
		}
		public async IAsyncEnumerable<TEntity> Delete([EnumeratorCancellation] CancellationToken cancellationToken = default, params TEntity[] entities)
		{
			foreach (TEntity _ in entities)
			{
				yield return await _MongoCollection.FindOneAndDeleteAsync(
					filter: __ => __.Id == _.Id,
					cancellationToken: cancellationToken);
			}
		}

		public TEntity? Update(TEntity entity)
		{
			return _MongoCollection.FindOneAndUpdate(
				filter: _ => _.Id == entity.Id,
				update: MongoDbRepositoryUpdateDefinitions.UpdateDefinition(entity));
		}
		public async Task<TEntity?> Update(TEntity entity, CancellationToken cancellationToken = default)
		{
			return await _MongoCollection.FindOneAndUpdateAsync(
				filter: _ => _.Id == entity.Id,
				update: MongoDbRepositoryUpdateDefinitions.UpdateDefinition(entity));
		}
		public IEnumerable<TEntity> Update(params TEntity[] entities)
		{
			return entities.Select(_ =>
			{
				return _MongoCollection.FindOneAndUpdate(
					filter: __ => __.Id == _.Id,
					update: MongoDbRepositoryUpdateDefinitions.UpdateDefinition(_));
			});
		}
		public async IAsyncEnumerable<TEntity> Update([EnumeratorCancellation] CancellationToken cancellationToken = default, params TEntity[] entities)
		{
			foreach(TEntity _ in entities)
			{
				yield return await _MongoCollection.FindOneAndUpdateAsync(
					filter: __ => __.Id == _.Id,
					cancellationToken: cancellationToken,
					update: MongoDbRepositoryUpdateDefinitions.UpdateDefinition(_));
			}
		}
	}
}