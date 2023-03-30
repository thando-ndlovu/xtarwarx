using Api.Queries;
using Api.GraphQL.Types;

using Domain.Models;

using GraphQL;

using Microsoft.Extensions.DependencyInjection;

using Repository;

using System;

namespace Api.GraphQL.Queries
{
	public partial class StarshipsQuery : StarWarsModelQuery<IStarshipGraphType>
	{
		public new class Arguments : StarWarsModelQuery<IStarshipGraphType>.Arguments
		{
			public new static IQuery DefaultQuery
			{
				get
				{
					IQuery defaultquery = StarWarsModelQuery<IStarshipGraphType>.Arguments.DefaultQuery;

					defaultquery.OrderBy = IStarship.ISortKeys.Keys.Name;

					return defaultquery;
				}
			}
		}

		public StarshipsQuery(IServiceProvider serviceprovider) : base(serviceprovider) { }

		public static Func<IResolveFieldContext, object> Resolve(IServiceProvider serviceprovider, IQuery? defaultquery = null)
		{
			return resolvefieldcontext =>
			{
				IRepository repository = serviceprovider.GetRequiredService<IRepository>();
				IQuery query = Arguments.GenerateQuery(resolvefieldcontext, defaultquery);
				IQuery.IResult<IStarship> result = query.ProcessStarships(repository.Starships.AsQueryable());

				return result;
			};
		}
		public static Func<IResolveFieldContext, object> Resolve(IServiceProvider serviceprovider, Func<IResolveFieldContext, IQuery>? defaultquery = null)
		{
			return resolvefieldcontext =>
			{
				IRepository repository = serviceprovider.GetRequiredService<IRepository>();
				IQuery query = Arguments.GenerateQuery(resolvefieldcontext, defaultquery?.Invoke(resolvefieldcontext));
				IQuery.IResult<IStarship> result = query.ProcessStarships(repository.Starships.AsQueryable());

				return result;
			};
		}
	}
}
