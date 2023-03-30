using Api.Queries;
using Api.GraphQL.Types;

using Domain.Models;

using GraphQL;
using GraphQL.Resolvers;

using Microsoft.Extensions.DependencyInjection;

using Repository;

using System;
using System.Threading.Tasks;

namespace Api.GraphQL.Queries
{
	public partial class WeaponsQuery : StarWarsModelQuery<IWeaponGraphType>
	{
		public new class Arguments : StarWarsModelQuery<IWeaponGraphType>.Arguments
		{
			public new static IQuery DefaultQuery
			{
				get
				{
					IQuery defaultquery = StarWarsModelQuery<IWeaponGraphType>.Arguments.DefaultQuery;

					defaultquery.OrderBy = IWeapon.ISortKeys.Keys.Name;

					return defaultquery;
				}
			}
		}

		public WeaponsQuery(IServiceProvider serviceprovider) : base(serviceprovider) { }

		public static Func<IResolveFieldContext, object> Resolve(IServiceProvider serviceprovider, IQuery? defaultquery = null)
		{
			return resolvefieldcontext =>
			{
				IRepository repository = serviceprovider.GetRequiredService<IRepository>();
				IQuery query = Arguments.GenerateQuery(resolvefieldcontext, defaultquery);
				IQuery.IResult<IWeapon> result = query.ProcessWeapons(repository.Weapons.AsQueryable());

				return result;
			};
		}
		public static Func<IResolveFieldContext, object> Resolve(IServiceProvider serviceprovider, Func<IResolveFieldContext, IQuery>? defaultquery = null)
		{
			return resolvefieldcontext =>
			{
				IRepository repository = serviceprovider.GetRequiredService<IRepository>();
				IQuery query = Arguments.GenerateQuery(resolvefieldcontext, defaultquery?.Invoke(resolvefieldcontext));
				IQuery.IResult<IWeapon> result = query.ProcessWeapons(repository.Weapons.AsQueryable());

				return result;
			};
		}
	}
}
