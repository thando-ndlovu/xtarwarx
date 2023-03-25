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

			AddField(new FieldType
			{
				Name = FieldNames.Introspection,
				Type = typeof(IntrospectionQuery.Result),
				Arguments = IntrospectionQuery.Arguments.QueryArguments(),
				Resolver = new FuncFieldResolver<object?>(resolvefieldcontext => resolvefieldcontext.Schema),
			});

			AddField(new FieldType
			{
				Name = FieldNames.Meta,
				Type = typeof(MetaQuery.Result),
				Arguments = MetaQuery.Arguments.QueryArguments(MetaQuery.Arguments.DefaultQuery),
				Resolver = new FuncFieldResolver<object?>(MetaQuery.Resolve(serviceprovider, MetaQuery.Arguments.DefaultQuery)),
			});

			AddField(new FieldType
			{
				Name = FieldNames.Search,
				Type = typeof(SearchQuery.Result),
				Arguments = SearchQuery.Arguments.QueryArguments(SearchQuery.Arguments.DefaultQuery),
				Resolver = new FuncFieldResolver<object?>(SearchQuery.Resolve(serviceprovider, SearchQuery.Arguments.DefaultQuery)),
			});

			AddField(new FieldType
			{
				Name = FieldNames.Characters,
				Description = localisation?.CharactersDescription,
				Type = typeof(CharactersQuery.Result),
				Arguments = CharactersQuery.Arguments.QueryArguments(CharactersQuery.Arguments.DefaultQuery),
				Resolver = new FuncFieldResolver<object?>(CharactersQuery.Resolve(serviceprovider, CharactersQuery.Arguments.DefaultQuery)),
			});

			AddField(new FieldType
			{
				Name = FieldNames.Factions,
				Description = localisation?.FactionsDescription,
				Type = typeof(FactionsQuery.Result),
				Arguments = FactionsQuery.Arguments.QueryArguments(FactionsQuery.Arguments.DefaultQuery),
				Resolver = new FuncFieldResolver<object?>(FactionsQuery.Resolve(serviceprovider, FactionsQuery.Arguments.DefaultQuery)),
			});

			AddField(new FieldType
			{
				Name = FieldNames.Films,
				Description = localisation?.FilmsDescription,
				Type = typeof(FilmsQuery.Result),
				Arguments = FilmsQuery.Arguments.QueryArguments(FilmsQuery.Arguments.DefaultQuery),
				Resolver = new FuncFieldResolver<object?>(FilmsQuery.Resolve(serviceprovider, FilmsQuery.Arguments.DefaultQuery)),
			});

			AddField(new FieldType
			{
				Name = FieldNames.Manufacturers,
				Description = localisation?.ManufacturersDescription,
				Type = typeof(ManufacturersQuery.Result),
				Arguments = ManufacturersQuery.Arguments.QueryArguments(ManufacturersQuery.Arguments.DefaultQuery),
				Resolver = new FuncFieldResolver<object?>(ManufacturersQuery.Resolve(serviceprovider, ManufacturersQuery.Arguments.DefaultQuery)),
			});

			AddField(new FieldType
			{
				Name = FieldNames.Planets,
				Description = localisation?.PlanetsDescription,
				Type = typeof(PlanetsQuery.Result),
				Arguments = PlanetsQuery.Arguments.QueryArguments(PlanetsQuery.Arguments.DefaultQuery),
				Resolver = new FuncFieldResolver<object?>(PlanetsQuery.Resolve(serviceprovider, PlanetsQuery.Arguments.DefaultQuery)),
			});

			AddField(new FieldType
			{
				Name = FieldNames.Species,
				Description = localisation?.SpeciesDescription,
				Type = typeof(SpeciesQuery.Result),
				Arguments = SpeciesQuery.Arguments.QueryArguments(SpeciesQuery.Arguments.DefaultQuery),
				Resolver = new FuncFieldResolver<object?>(SpeciesQuery.Resolve(serviceprovider, SpeciesQuery.Arguments.DefaultQuery)),
			});

			AddField(new FieldType
			{
				Name = FieldNames.Starships,
				Description = localisation?.StarshipsDescription,
				Type = typeof(StarshipsQuery.Result),
				Arguments = StarshipsQuery.Arguments.QueryArguments(StarshipsQuery.Arguments.DefaultQuery),
				Resolver = new FuncFieldResolver<object?>(StarshipsQuery.Resolve(serviceprovider, StarshipsQuery.Arguments.DefaultQuery)),
			});

			AddField(new FieldType
			{
				Name = FieldNames.Vehicles,
				Description = localisation?.VehiclesDescription,
				Type = typeof(VehiclesQuery.Result),
				Arguments = VehiclesQuery.Arguments.QueryArguments(VehiclesQuery.Arguments.DefaultQuery),
				Resolver = new FuncFieldResolver<object?>(VehiclesQuery.Resolve(serviceprovider, VehiclesQuery.Arguments.DefaultQuery)),
			});

			AddField(new FieldType
			{
				Name = FieldNames.Weapons,
				Description = localisation?.WeaponsDescription,
				Type = typeof(WeaponsQuery.Result),
				Arguments = WeaponsQuery.Arguments.QueryArguments(WeaponsQuery.Arguments.DefaultQuery),
				Resolver = new FuncFieldResolver<object?>(WeaponsQuery.Resolve(serviceprovider, WeaponsQuery.Arguments.DefaultQuery)),
			});
		}
	}
}
