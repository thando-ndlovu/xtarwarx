using Domain.Models;

using Repository.Entities;

using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Repository
{
	public partial interface IRepository
	{
		public interface ISet<TEntity> where TEntity : class, IStarWarsModel
		{
			IQueryable<TEntity> AsQueryable();

			TEntity? Create(TEntity entity);
			Task<TEntity?> Create(TEntity entity, CancellationToken cancellationToken = default);
			IEnumerable<TEntity> Create(params TEntity[] entities);
			IAsyncEnumerable<TEntity> Create(CancellationToken cancellationToken = default, params TEntity[] entities);

			TEntity? Delete(TEntity entity);
			Task<TEntity?> Delete(TEntity entity, CancellationToken cancellationToken = default);
			IEnumerable<TEntity> Delete(params TEntity[] entities);
			IAsyncEnumerable<TEntity> Delete(CancellationToken cancellationToken = default, params TEntity[] entities);

			TEntity? Update(TEntity entity);
			Task<TEntity?> Update(TEntity entity, CancellationToken cancellationToken = default);
			IEnumerable<TEntity> Update(params TEntity[] entities);
			IAsyncEnumerable<TEntity> Update(CancellationToken cancellationToken = default, params TEntity[] entities);
		}
	}
}
