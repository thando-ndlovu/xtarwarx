using Api.Queries;
using Api.GraphQL.Types;

using Domain.Models;

using GraphQL;

using Microsoft.Extensions.DependencyInjection;

using Repository;

using System;

namespace Api.GraphQL.Queries
{
	public partial class FactionsQuery : StarWarsModelQuery<IFactionGraphType>
	{
		public new class Arguments : StarWarsModelQuery<IFactionGraphType>.Arguments
		{
			public new static IQuery DefaultQuery
			{
				get
				{
					IQuery defaultquery = StarWarsModelQuery<IFactionGraphType>.Arguments.DefaultQuery;

					defaultquery.OrderBy = IFaction.ISortKeys.Keys.Name;

					return defaultquery;
				}
			}
		}

		public FactionsQuery(IServiceProvider serviceprovider) : base(serviceprovider) { }

		public static Func<IResolveFieldContext, object> Resolve(IServiceProvider serviceprovider, IQuery? defaultquery = null)
		{
			return resolvefieldcontext =>
			{
				IRepository repository = serviceprovider.GetRequiredService<IRepository>();
				IQuery query = Arguments.GenerateQuery(resolvefieldcontext, defaultquery);
				IQuery.IResult<object> result = query.ProcessFactions(repository.Factions.AsQueryable());

				return result;
			};
		}
		public static Func<IResolveFieldContext, object> Resolve(IServiceProvider serviceprovider, Func<IResolveFieldContext, IQuery>? defaultquery = null)
		{
			return resolvefieldcontext =>
			{
				IRepository repository = serviceprovider.GetRequiredService<IRepository>();
				IQuery query = Arguments.GenerateQuery(resolvefieldcontext, defaultquery?.Invoke(resolvefieldcontext));
				IQuery.IResult<object> result = query.ProcessFactions(repository.Factions.AsQueryable());

				return result;
			};
		}
	}
}
