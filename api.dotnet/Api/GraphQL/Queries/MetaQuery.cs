using Api.Queries;
using Api.GraphQL.Types;

using GraphQL;

using Microsoft.Extensions.DependencyInjection;

using Repository;

using System;

namespace Api.GraphQL.Queries
{
	public partial class MetaQuery : BaseQuery<IQueryMetaResultGraphType>
	{
		public MetaQuery(IServiceProvider serviceprovider) : base(serviceprovider) { }

		public static Func<IResolveFieldContext, object> Resolve(IServiceProvider serviceprovider, IQueryMeta? defaultquery = null)
		{
			return resolvefieldcontext =>
			{
				IRepository repository = serviceprovider.GetRequiredService<IRepository>();
				IQueryMeta query = Arguments.GenerateQuery(resolvefieldcontext, defaultquery);
				IQueryMeta.IResult result = query.ProcessMetaQuery(
					characters: repository.Characters.AsQueryable(),
					factions: repository.Factions.AsQueryable(),
					films: repository.Films.AsQueryable(),
					manufacturers: repository.Manufacturers.AsQueryable(),
					planets: repository.Planets.AsQueryable(),
					species: repository.Species.AsQueryable(),
					starships: repository.Starships.AsQueryable(),
					vehicles: repository.Vehicles.AsQueryable(),
					weapons: repository.Weapons.AsQueryable());

				return result;
			};
		}
		public static Func<IResolveFieldContext, object> Resolve(IServiceProvider serviceprovider, Func<IResolveFieldContext, IQueryMeta>? defaultquery = null)
		{
			return resolvefieldcontext =>
			{
				IRepository repository = serviceprovider.GetRequiredService<IRepository>();
				IQueryMeta query = Arguments.GenerateQuery(resolvefieldcontext, defaultquery?.Invoke(resolvefieldcontext));
				IQueryMeta.IResult result = query.ProcessMetaQuery(
					characters: repository.Characters.AsQueryable(),
					factions: repository.Factions.AsQueryable(),
					films: repository.Films.AsQueryable(),
					manufacturers: repository.Manufacturers.AsQueryable(),
					planets: repository.Planets.AsQueryable(),
					species: repository.Species.AsQueryable(),
					starships: repository.Starships.AsQueryable(),
					vehicles: repository.Vehicles.AsQueryable(),
					weapons: repository.Weapons.AsQueryable());

				return result;
			};
		}
	}
}
