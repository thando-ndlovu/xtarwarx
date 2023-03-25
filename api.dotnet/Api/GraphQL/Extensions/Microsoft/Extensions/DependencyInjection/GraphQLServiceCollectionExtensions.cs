using Api.GraphQL;
using Api.GraphQL.Queries;
using Api.GraphQL.Types;

using Domain.Enums;
using Domain.Models;

using GraphQL;
using GraphQL.Types;

using System;
using System.Drawing;

namespace Microsoft.Extensions.DependencyInjection
{
	public static class GraphQLServiceCollectionExtensions
	{
		public static IServiceCollection AddGraphQLRepository(this IServiceCollection services)
		{
			services.AddSingleton<StarWarsQuery>();

			services.AddSingleton<IntrospectionQuery>();
			services.AddSingleton<IntrospectionQuery.Result>();

			services.AddSingleton<CharactersQuery>();
			services.AddSingleton<FactionsQuery>();
			services.AddSingleton<FilmsQuery>();
			services.AddSingleton<ManufacturersQuery>();
			services.AddSingleton<PlanetsQuery>();
			services.AddSingleton<SpeciesQuery>();
			services.AddSingleton<StarshipsQuery>();
			services.AddSingleton<VehiclesQuery>();
			services.AddSingleton<WeaponsQuery>();
			services.AddSingleton<SearchQuery>();

			services.AddSingleton<CharactersQuery.Result>();
			services.AddSingleton<FactionsQuery.Result>();
			services.AddSingleton<FilmsQuery.Result>();
			services.AddSingleton<ManufacturersQuery.Result>();
			services.AddSingleton<PlanetsQuery.Result>();
			services.AddSingleton<SpeciesQuery.Result>();
			services.AddSingleton<StarshipsQuery.Result>();
			services.AddSingleton<VehiclesQuery.Result>();
			services.AddSingleton<WeaponsQuery.Result>();
			services.AddSingleton<SearchQuery.Result>();

			services.AddSingleton<ICharacterGraphType>();
			services.AddSingleton<IFactionGraphType>();
			services.AddSingleton<IFilmGraphType>();
			services.AddSingleton<IManufacturerGraphType>();
			services.AddSingleton<IPlanetGraphType>();
			services.AddSingleton<IPlanetGraphType.IClimateGraphType>();
			services.AddSingleton<IPlanetGraphType.ITerrainGraphType>();
			services.AddSingleton<ISpecieGraphType>();
			services.AddSingleton<IStarWarsModelGraphType<IStarWarsModel>>();
			services.AddSingleton<IStarWarsModelGraphType<IStarWarsModel>.IURIGraphType>();
			services.AddSingleton<IStarshipGraphType>();
			services.AddSingleton<IStarshipGraphType.IStarshipClassGraphType>();
			services.AddSingleton<IVehicleGraphType>();
			services.AddSingleton<IVehicleGraphType.IVehicleClassGraphType>();
			services.AddSingleton<IWeaponGraphType>();
			services.AddSingleton<IWeaponGraphType.IWeaponClassGraphType>();

			services.AddSingleton<IQueryMetaResultGraphType>();
			services.AddSingleton<IQuerySearchResultGraphType>();

			services.AddSingleton<ArrayGraphType<bool>>();
			services.AddSingleton<ArrayGraphType<bool?>>();
			services.AddSingleton<ArrayGraphType<byte>>();
			services.AddSingleton<ArrayGraphType<byte?>>();
			services.AddSingleton<ArrayGraphType<char>>();
			services.AddSingleton<ArrayGraphType<char?>>();
			services.AddSingleton<ArrayGraphType<double>>();
			services.AddSingleton<ArrayGraphType<double?>>();
			services.AddSingleton<ArrayGraphType<float>>();
			services.AddSingleton<ArrayGraphType<float?>>();
			services.AddSingleton<ArrayGraphType<int>>();
			services.AddSingleton<ArrayGraphType<int?>>();
			services.AddSingleton<ArrayGraphType<long>>();
			services.AddSingleton<ArrayGraphType<long?>>();
			services.AddSingleton<ArrayGraphType<string>>();
			services.AddSingleton<ArrayGraphType<string?>>();
			services.AddSingleton<ArrayGraphType<DateTime>>();
			services.AddSingleton<ArrayGraphType<DateTime?>>();
			services.AddSingleton<ArrayGraphType<DateTimeOffset>>();
			services.AddSingleton<ArrayGraphType<DateTimeOffset?>>();
			services.AddSingleton<ArrayGraphType<Guid>>();
			services.AddSingleton<ArrayGraphType<Guid?>>();
			services.AddSingleton<ArrayGraphType<TimeSpan>>();
			services.AddSingleton<ArrayGraphType<TimeSpan?>>();	   
			services.AddSingleton<ArrayGraphType<Uri>>();
			services.AddSingleton<ArrayGraphType<Uri?>>();

			services.AddSingleton<DoubleGraphType>();
			services.AddSingleton<TimeSpanDaysGraphType>();
			services.AddSingleton<TimeSpanHoursGraphType>();
			services.AddSingleton<TimeSpanMinutesGraphType>();

			services.AddSingleton<EnumerationGraphType<KnownColor>>();
			services.AddSingleton<EnumerationGraphType<StarWarsTypes>>();

			services.AddSingleton<ISchema, StarWarsSchema>();

			return services;
		}
	}
}
