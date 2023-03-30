using Api.Queries;
using Api.GraphQL.Types;

using Domain.Models;

using GraphQL;

using Microsoft.Extensions.DependencyInjection;

using Repository;

using System;

namespace Api.GraphQL.Queries
{
	public partial class PlanetsQuery : StarWarsModelQuery<IPlanetGraphType>
	{
		public new class Arguments : StarWarsModelQuery<IPlanetGraphType>.Arguments
		{
			public new static IQuery DefaultQuery
			{
				get
				{
					IQuery defaultquery = StarWarsModelQuery<IPlanetGraphType>.Arguments.DefaultQuery;

					defaultquery.OrderBy = IPlanet.ISortKeys.Keys.Name;

					return defaultquery;
				}
			}
		}

		public PlanetsQuery(IServiceProvider serviceprovider) : base(serviceprovider) { }

		public static Func<IResolveFieldContext, object> Resolve(IServiceProvider serviceprovider, IQuery? defaultquery = null)
		{
			return resolvefieldcontext =>
			{
				IRepository repository = serviceprovider.GetRequiredService<IRepository>();
				IQuery query = Arguments.GenerateQuery(resolvefieldcontext, defaultquery);
				IQuery.IResult<IPlanet> result = query.ProcessPlanets(repository.Planets.AsQueryable());

				return result;
			};
		}
		public static Func<IResolveFieldContext, object> Resolve(IServiceProvider serviceprovider, Func<IResolveFieldContext, IQuery>? defaultquery = null)
		{
			return resolvefieldcontext =>
			{
				IRepository repository = serviceprovider.GetRequiredService<IRepository>();
				IQuery query = Arguments.GenerateQuery(resolvefieldcontext, defaultquery?.Invoke(resolvefieldcontext));
				IQuery.IResult<IPlanet> result = query.ProcessPlanets(repository.Planets.AsQueryable());

				return result;
			};
		}
	}
}
