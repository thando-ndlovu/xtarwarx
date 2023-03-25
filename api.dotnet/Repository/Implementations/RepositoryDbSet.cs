using Domain.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Repository.Implementations
{
	public class RepositoryDbSet<TEntity> : IRepository.ISet<TEntity> where TEntity : class, IStarWarsModel
	{
		public RepositoryDbSet(DbSet<TEntity> dbset, DbContext dbcontext)
		{
			_DbSet = dbset;
			_DbContext = dbcontext;
		}

		protected readonly DbContext _DbContext;
		protected readonly DbSet<TEntity> _DbSet;

		public IQueryable<TEntity> AsQueryable()
		{
			return _DbSet.AsQueryable<TEntity>().AsNoTracking();
		}

		public TEntity? Create(TEntity entity) 
		{
			entity.Created = DateTime.Now;

			EntityEntry<TEntity> entry = _DbSet.Add(entity);

			int? savecount;

			try
			{
				savecount = _DbContext.SaveChanges();
			}
			catch(Exception)
			{
				return null;
			}

			if (savecount == 1 && entry.State == EntityState.Added)
				return entry.Entity;

			return null;
		}
		public async Task<TEntity?> Create(TEntity entity, CancellationToken cancellationToken = default)
		{
			entity.Created = DateTime.Now;

			EntityEntry<TEntity> entry = await _DbSet.AddAsync(entity, cancellationToken);

			int? savecount;

			try
			{
				savecount = await _DbContext.SaveChangesAsync(cancellationToken);
			}
			catch (Exception)
			{
				return null;
			}

			if (savecount == 1 && entry.State == EntityState.Added)
				return entry.Entity;

			return null;
		}
		public IEnumerable<TEntity> Create(params TEntity[] entities)
		{
			IEnumerable<TEntity> entries = Enumerable.Empty<TEntity>();

			foreach(TEntity entity in entities)
			{
				entity.Created = DateTime.Now;

				EntityEntry<TEntity> entry = _DbSet.Add(entity);

				if (entry.State == EntityState.Added)
					entries = entries.Append(entry.Entity);
			}

			try
			{
				_DbContext.SaveChanges();
			}
			catch (Exception)
			{
				return Enumerable.Empty<TEntity>();
			}

			return entries;
		}
		public async IAsyncEnumerable<TEntity> Create([EnumeratorCancellation]CancellationToken cancellationToken = default, params TEntity[] entities)
		{
			IEnumerable<Task<TEntity?>> entrytasks = entities.Select(async entity =>
			{
				entity.Created = DateTime.Now;

				EntityEntry<TEntity> entry = await _DbSet.AddAsync(entity);

				if (entry.State == EntityState.Added)
					return entry.Entity;

				return null;
			});

			IEnumerable<TEntity?> entries = await Task.WhenAll(entrytasks);

			try
			{
				await _DbContext.SaveChangesAsync(cancellationToken);
			}
			catch (Exception)
			{
				entries = Enumerable.Empty<TEntity?>();
			}

			foreach (TEntity? entity in entries)
				if (entity != null)
					yield return entity;
		}

		public TEntity? Delete(TEntity entity)
		{
			EntityEntry<TEntity> entry = _DbSet.Remove(entity);

			int? savecount;

			try
			{
				savecount = _DbContext.SaveChanges();
			}
			catch (Exception)
			{
				return null;
			}

			if (savecount == 1 && entry.State == EntityState.Deleted)
				return entry.Entity;

			return null;
		}
		public async Task<TEntity?> Delete(TEntity entity, CancellationToken cancellationToken = default)
		{
			EntityEntry<TEntity> entry = _DbSet.Remove(entity);

			int? savecount;

			try
			{
				savecount = await _DbContext.SaveChangesAsync(cancellationToken);
			}
			catch (Exception)
			{
				return null;
			}

			if (savecount == 1 && entry.State == EntityState.Deleted)
				return entry.Entity;

			return null;
		}
		public IEnumerable<TEntity> Delete(params TEntity[] entities)
		{
			IEnumerable<TEntity> entries = Enumerable.Empty<TEntity>();

			foreach (TEntity entity in entities)
			{
				EntityEntry<TEntity> entry = _DbSet.Remove(entity);

				if (entry.State == EntityState.Deleted)
					entries = entries.Append(entry.Entity);
			}

			try
			{
				_DbContext.SaveChanges();
			}
			catch (Exception)
			{
				return Enumerable.Empty<TEntity>();
			}

			return entries.OfType<TEntity>();
		}
		public async IAsyncEnumerable<TEntity> Delete([EnumeratorCancellation]CancellationToken cancellationToken = default, params TEntity[] entities)
		{
			IEnumerable<TEntity?> entries = entities.Select(_ =>
			{
				EntityEntry<TEntity> entry = _DbSet.Remove(_);

				if (entry.State == EntityState.Deleted)
					return entry.Entity;

				return null;
			});

			try
			{
				await _DbContext.SaveChangesAsync(cancellationToken);
			}
			catch (Exception)
			{
				entries = Enumerable.Empty<TEntity>();
			}

			foreach (TEntity? entity in entries)
				if (entity != null)
					yield return entity;
		}

		public TEntity? Update(TEntity entity)
		{
			entity.Edited = DateTime.Now;

			EntityEntry<TEntity> entry = _DbSet.Update(entity);

			int? savecount;

			try
			{
				savecount = _DbContext.SaveChanges();
			}
			catch (Exception)
			{
				return null;
			}

			if (savecount == 1 && entry.State == EntityState.Modified)
				return entry.Entity;

			return null;
		}
		public async Task<TEntity?> Update(TEntity entity, CancellationToken cancellationToken = default)
		{
			entity.Edited = DateTime.Now;

			EntityEntry<TEntity> entry = _DbSet.Update(entity);

			int? savecount; 

			try
			{
				savecount = await _DbContext.SaveChangesAsync(cancellationToken);
			}
			catch (Exception)
			{
				return null;
			}

			if (savecount == 1 && entry.State == EntityState.Modified)
				return entry.Entity;

			return null;
		}
		public IEnumerable<TEntity> Update(params TEntity[] entities)
		{
			IEnumerable<TEntity> entries = Enumerable.Empty<TEntity>();

			foreach (TEntity entity in entities)
			{
				entity.Edited = DateTime.Now;

				EntityEntry<TEntity> entry = _DbSet.Update(entity);

				if (entry.State == EntityState.Modified)
					entries = entries.Append(entry.Entity);
			}

			try
			{
				_DbContext.SaveChanges();
			}
			catch (Exception)
			{
				return Enumerable.Empty<TEntity>();
			}

			return entries.OfType<TEntity>();
		}
		public async IAsyncEnumerable<TEntity> Update([EnumeratorCancellation]CancellationToken cancellationToken = default, params TEntity[] entities)
		{
			IEnumerable<TEntity?> entries = entities.Select(entity =>
			{
				entity.Edited = DateTime.Now;

				EntityEntry<TEntity> entry = _DbSet.Update(entity);

				if (entry.State == EntityState.Modified)
					return entry.Entity;

				return null;
			});

			try
			{
				await _DbContext.SaveChangesAsync(cancellationToken);
			}
			catch (Exception)
			{
				entries = Enumerable.Empty<TEntity>();
			}

			foreach (TEntity? entity in entries)
				if (entity != null)
					yield return entity;
		}
	}
}
