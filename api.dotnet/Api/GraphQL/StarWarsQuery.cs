using Api.GraphQL.Queries;

using GraphQL.Types;
using GraphQL.Resolvers;

using Localisation;
using Localisation.Abstractions.GraphQL;

using Microsoft.Extensions.DependencyInjection;

using System;

namespace Api.GraphQL
{
	public partial class StarWarsQuery : ObjectGraphType<object>
	{			 
		public class FieldNames 
		{
			public const string Root = "StarWarsQuery";

			public const string Introspection = "IntrospectionQuery";

			public const string Meta = "Meta";
			public const string Search = "Search";

			public const string Characters = "Characters";
			public const string Factions = "Factions";
			public const string Films = "Films";
			public const string Manufacturers = "Manufacturers";
			public const string Planets = "Planets";
			public const string Species = "Species";
			public const string Starships = "Starships";
			public const string Vehicles = "Vehicles";
			public const string Weapons = "Weapons";
		}

		public StarWarsQuery(IServiceProvider serviceprovider) : base()
		{
			IStarWarsQueryLocalisation? localisation = serviceprovider.GetService<ILocalisation>()?
				.GraphQLLocalisations
				.StarWarsQuery();

			Name = FieldNames.Root;
			Description = localisation?.Description;

			Field<StringGraphType>(FieldNames.Introspection)
				.Arguments(IntrospectionQuery.Arguments.QueryArguments())
				.Resolve(new FuncFieldResolver<object?>(resolvefieldcontext => resolvefieldcontext.Schema.ToString()));

			Field<MetaQuery.Result>(FieldNames.Meta)
				//.Description(localisation?)
				.Arguments(MetaQuery.Arguments.QueryArguments(MetaQuery.Arguments.DefaultQuery))
				.Resolve(new FuncFieldResolver<object?>(MetaQuery.Resolve(serviceprovider, MetaQuery.Arguments.DefaultQuery)));

			Field<SearchQuery.Result>(FieldNames.Search)
				//.Description(localisation?)
				.Arguments(SearchQuery.Arguments.QueryArguments(SearchQuery.Arguments.DefaultQuery))
				.Resolve(new FuncFieldResolver<object?>(SearchQuery.Resolve(serviceprovider, SearchQuery.Arguments.DefaultQuery)));

			Field<CharactersQuery.Result>(FieldNames.Characters)
				.Description(localisation?.CharactersDescription)
				.Arguments(CharactersQuery.Arguments.QueryArguments(CharactersQuery.Arguments.DefaultQuery))
				.Resolve(new FuncFieldResolver<object?>(CharactersQuery.Resolve(serviceprovider, CharactersQuery.Arguments.DefaultQuery)));

			Field<FactionsQuery.Result>(FieldNames.Factions)
				.Description(localisation?.FactionsDescription)
				.Arguments(FactionsQuery.Arguments.QueryArguments(FactionsQuery.Arguments.DefaultQuery))
				.Resolve(new FuncFieldResolver<object?>(FactionsQuery.Resolve(serviceprovider, FactionsQuery.Arguments.DefaultQuery)));

			Field<FilmsQuery.Result>(FieldNames.Films)
				.Description(localisation?.FilmsDescription)
				.Arguments(FilmsQuery.Arguments.QueryArguments(FilmsQuery.Arguments.DefaultQuery))
				.Resolve(new FuncFieldResolver<object?>(FilmsQuery.Resolve(serviceprovider, FilmsQuery.Arguments.DefaultQuery)));

			Field<ManufacturersQuery.Result>(FieldNames.Manufacturers)
				.Description(localisation?.ManufacturersDescription)
				.Arguments(ManufacturersQuery.Arguments.QueryArguments(ManufacturersQuery.Arguments.DefaultQuery))
				.Resolve(new FuncFieldResolver<object?>(ManufacturersQuery.Resolve(serviceprovider, ManufacturersQuery.Arguments.DefaultQuery)));

			Field<PlanetsQuery.Result>(FieldNames.Planets)
				.Description(localisation?.PlanetsDescription)
				.Arguments(PlanetsQuery.Arguments.QueryArguments(PlanetsQuery.Arguments.DefaultQuery))
				.Resolve(new FuncFieldResolver<object?>(PlanetsQuery.Resolve(serviceprovider, PlanetsQuery.Arguments.DefaultQuery)));

			Field<SpeciesQuery.Result>(FieldNames.Species)
				.Description(localisation?.SpeciesDescription)
				.Arguments(SpeciesQuery.Arguments.QueryArguments(SpeciesQuery.Arguments.DefaultQuery))
				.Resolve(new FuncFieldResolver<object?>(SpeciesQuery.Resolve(serviceprovider, SpeciesQuery.Arguments.DefaultQuery)));

			Field<StarshipsQuery.Result>(FieldNames.Starships)
				.Description(localisation?.StarshipsDescription)
				.Arguments(StarshipsQuery.Arguments.QueryArguments(StarshipsQuery.Arguments.DefaultQuery))
				.Resolve(new FuncFieldResolver<object?>(StarshipsQuery.Resolve(serviceprovider, StarshipsQuery.Arguments.DefaultQuery)));

			Field<VehiclesQuery.Result>(FieldNames.Vehicles)
				.Description(localisation?.VehiclesDescription)
				.Arguments(VehiclesQuery.Arguments.QueryArguments(VehiclesQuery.Arguments.DefaultQuery))
				.Resolve(new FuncFieldResolver<object?>(VehiclesQuery.Resolve(serviceprovider, VehiclesQuery.Arguments.DefaultQuery)));

			Field<WeaponsQuery.Result>(FieldNames.Weapons)
				.Description(localisation?.WeaponsDescription)
				.Arguments(WeaponsQuery.Arguments.QueryArguments(WeaponsQuery.Arguments.DefaultQuery))
				.Resolve(new FuncFieldResolver<object?>(WeaponsQuery.Resolve(serviceprovider, WeaponsQuery.Arguments.DefaultQuery)));
		}
	}
}
