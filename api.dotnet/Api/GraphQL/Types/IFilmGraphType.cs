using Api.Queries;
using Api.Queries.Retrievers;
using Api.GraphQL.Queries;

using Domain.Models;

using GraphQL.Resolvers;
using GraphQL.Types;

using System;
using System.Linq;
using System.Text;

namespace Api.GraphQL.Types
{
	public class IFilmGraphType : IStarWarsModelGraphType<IFilm>
	{
		public static void AsQueryString(StringBuilder stringbuilder, IFilmRetrieverTyped<bool> retriever, bool hasprevious, out bool containsprevious)
		{
			IStarWarsModelGraphType<IFilm>.AsQueryString(stringbuilder, retriever, hasprevious, out bool containsprevious1);

			if (hasprevious is false) hasprevious = containsprevious1;

			if (retriever.CastMembers)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.CastMembers);

				hasprevious = true;
			}
			if (retriever.CharacterIds)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.CharacterIds);

				hasprevious = true;
			}
			if (retriever.Characters is not null)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Characters);

				stringbuilder.Append('{');
				ICharacterGraphType.AsQueryString(stringbuilder, retriever.Characters, false, out bool _);
				stringbuilder.Append('}');

				hasprevious = true;
			}
			if (retriever.Description)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Description);

				hasprevious = true;
			}
			if (retriever.Director)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Director);

				hasprevious = true;
			}
			if (retriever.Duration)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Duration);

				hasprevious = true;
			}
			if (retriever.EpisodeId)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.EpisodeId);

				hasprevious = true;
			}
			if (retriever.FactionIds)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.FactionIds);

				hasprevious = true;
			}
			if (retriever.Factions is not null)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Factions);

				stringbuilder.Append('{');
				IFactionGraphType.AsQueryString(stringbuilder, retriever.Factions, false, out bool _);
				stringbuilder.Append('}');

				hasprevious = true;
			}
			if (retriever.ManufacturerIds)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.ManufacturerIds);

				hasprevious = true;
			}
			if (retriever.Manufacturers is not null)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Manufacturers);

				stringbuilder.Append('{');
				IManufacturerGraphType.AsQueryString(stringbuilder, retriever.Manufacturers, false, out bool _);
				stringbuilder.Append('}');

				hasprevious = true;
			}
			if (retriever.OpeningCrawl)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.OpeningCrawl);

				hasprevious = true;
			}
			if (retriever.PlanetIds)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.SpecieIds);

				hasprevious = true;
			}
			if (retriever.Planets is not null)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Planets);

				stringbuilder.Append('{');
				IPlanetGraphType.AsQueryString(stringbuilder, retriever.Planets, false, out bool _);
				stringbuilder.Append('}');

				hasprevious = true;
			}
			if (retriever.Producers)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Producers);

				hasprevious = true;
			}
			if (retriever.ReleaseDate)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.ReleaseDate);

				hasprevious = true;
			}
			if (retriever.SpecieIds)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.SpecieIds);

				hasprevious = true;
			}
			if (retriever.Species is not null)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Species);

				stringbuilder.Append('{');
				ISpecieGraphType.AsQueryString(stringbuilder, retriever.Species, false, out bool _);
				stringbuilder.Append('}');

				hasprevious = true;
			}
			if (retriever.StarshipIds)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.StarshipIds);

				hasprevious = true;
			}
			if (retriever.Starships is not null)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Starships);

				stringbuilder.Append('{');
				IStarshipGraphType.AsQueryString(stringbuilder, retriever.Starships, false, out bool _);
				stringbuilder.Append('}');

				hasprevious = true;
			}
			if (retriever.Title)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Title);

				hasprevious = true;
			}
			if (retriever.VehicleIds)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.VehicleIds);

				hasprevious = true;
			}
			if (retriever.Vehicles is not null)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Vehicles);

				stringbuilder.Append('{');
				IVehicleGraphType.AsQueryString(stringbuilder, retriever.Vehicles, false, out bool _);
				stringbuilder.Append('}');

				hasprevious = true;
			}
			if (retriever.WeaponIds)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.WeaponIds);

				hasprevious = true;
			}
			if (retriever.Weapons is not null)
			{
				stringbuilder
					.AppendFormat("{0}{1}", hasprevious ? "," : string.Empty, FieldNames.Weapons);

				stringbuilder.Append('{');
				IWeaponGraphType.AsQueryString(stringbuilder, retriever.Weapons, false, out bool _);
				stringbuilder.Append('}');

				hasprevious = true;
			}

			containsprevious = hasprevious;
		}
		public new class FieldNames : IStarWarsModelGraphType<IFilm>.FieldNames
		{
			public const string CastMembers = nameof(IFilm.CastMembers);
			public const string CharacterIds = nameof(IFilm.CharacterIds);
			public const string Description = nameof(IFilm.Description);
			public const string Director = nameof(IFilm.Director);
			public const string Duration = nameof(IFilm.Duration);
			public const string EpisodeId = nameof(IFilm.EpisodeId);
			public const string FactionIds = nameof(IFilm.FactionIds);
			public const string ManufacturerIds = nameof(IFilm.ManufacturerIds);
			public const string OpeningCrawl = nameof(IFilm.OpeningCrawl);
			public const string PlanetIds = nameof(IFilm.PlanetIds);
			public const string Producers = nameof(IFilm.Producers);
			public const string ReleaseDate = nameof(IFilm.ReleaseDate);
			public const string SpecieIds = nameof(IFilm.SpecieIds);
			public const string StarshipIds = nameof(IFilm.StarshipIds);
			public const string Title = nameof(IFilm.Title);
			public const string VehicleIds = nameof(IFilm.VehicleIds);
			public const string WeaponIds = nameof(IFilm.WeaponIds);

			public const string Characters = "Characters";
			public const string Factions = "Factions";
			public const string Manufacturers = "Manufacturers";
			public const string Planets = "Planets";
			public const string Species = "Species";
			public const string Starships = "Starships";
			public const string Vehicles = "Vehicles";
			public const string Weapons = "Weapons";
		}

		public IFilmGraphType() : base()
		{
			Field<ListGraphType<StringGraphType>>(FieldNames.CastMembers).Resolve(resolvefieldcontext => resolvefieldcontext.Source.CastMembers);
			Field<ListGraphType<IntGraphType>>(FieldNames.CharacterIds).Resolve(resolvefieldcontext => resolvefieldcontext.Source.CharacterIds);
			Field<StringGraphType>(FieldNames.Description).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Description);
			Field<StringGraphType>(FieldNames.Director).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Director);
			Field<TimeSpanMinutesGraphType>(FieldNames.Duration).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Duration);
			Field<IntGraphType>(FieldNames.EpisodeId).Resolve(resolvefieldcontext => resolvefieldcontext.Source.EpisodeId);
			Field<ListGraphType<IntGraphType>>(FieldNames.FactionIds).Resolve(resolvefieldcontext => resolvefieldcontext.Source.FactionIds);
			Field<ListGraphType<IntGraphType>>(FieldNames.ManufacturerIds).Resolve(resolvefieldcontext => resolvefieldcontext.Source.ManufacturerIds);
			Field<StringGraphType>(FieldNames.OpeningCrawl).Resolve(resolvefieldcontext => resolvefieldcontext.Source.OpeningCrawl);
			Field<ListGraphType<IntGraphType>>(FieldNames.PlanetIds).Resolve(resolvefieldcontext => resolvefieldcontext.Source.PlanetIds);
			Field<ListGraphType<StringGraphType>>(FieldNames.Producers).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Producers);
			Field<DateTimeGraphType>(FieldNames.ReleaseDate).Resolve(resolvefieldcontext => resolvefieldcontext.Source.ReleaseDate);
			Field<ListGraphType<IntGraphType>>(FieldNames.SpecieIds).Resolve(resolvefieldcontext => resolvefieldcontext.Source.SpecieIds);
			Field<ListGraphType<IntGraphType>>(FieldNames.StarshipIds).Resolve(resolvefieldcontext => resolvefieldcontext.Source.StarshipIds);
			Field<StringGraphType>(FieldNames.Title).Resolve(resolvefieldcontext => resolvefieldcontext.Source.Title);
			Field<ListGraphType<IntGraphType>>(FieldNames.VehicleIds).Resolve(resolvefieldcontext => resolvefieldcontext.Source.VehicleIds);
			Field<ListGraphType<IntGraphType>>(FieldNames.WeaponIds).Resolve(resolvefieldcontext => resolvefieldcontext.Source.WeaponIds);

			Field<CharactersQuery.Result>(FieldNames.Characters)
				.Arguments(CharactersQuery.Arguments.QueryArguments())
				.Resolve(new FieldResolver
				{
					ResolveAsyncFunc = resolvefieldcontext =>
					{
						object? result = CharactersQuery.Resolve(resolvefieldcontext.RequestServices, resolvefieldcontext =>
						{
							IQuery charactersquery = CharactersQuery.Arguments.DefaultQuery;

							charactersquery.Ids = (resolvefieldcontext.Source as IFilm)?.CharacterIds?.ToArray();

							return charactersquery;

						}).Invoke(resolvefieldcontext);

						return System.Threading.Tasks.ValueTask.FromResult<object?>(result);
					}
				});
			Field<FactionsQuery.Result>(FieldNames.Factions)
				.Arguments(FactionsQuery.Arguments.QueryArguments())
				.Resolve(new FieldResolver
				{
					ResolveAsyncFunc = resolvefieldcontext =>
					{
						object? result = FactionsQuery.Resolve(resolvefieldcontext.RequestServices, resolvefieldcontext =>
						{
							IQuery factionsquery = FactionsQuery.Arguments.DefaultQuery;

							factionsquery.Ids = (resolvefieldcontext.Source as IFilm)?.FactionIds?.ToArray();

							return factionsquery;

						}).Invoke(resolvefieldcontext);

						return System.Threading.Tasks.ValueTask.FromResult<object?>(result);
					}
				});
			Field<ManufacturersQuery.Result>(FieldNames.Manufacturers)
				.Arguments(ManufacturersQuery.Arguments.QueryArguments())
				.Resolve(new FieldResolver
				{
					ResolveAsyncFunc = resolvefieldcontext =>
					{
						object? result = ManufacturersQuery.Resolve(resolvefieldcontext.RequestServices, resolvefieldcontext =>
						{
							IQuery factionsquery = ManufacturersQuery.Arguments.DefaultQuery;

							factionsquery.Ids = (resolvefieldcontext.Source as IFilm)?.ManufacturerIds?.ToArray();

							return factionsquery;

						}).Invoke(resolvefieldcontext);

						return System.Threading.Tasks.ValueTask.FromResult<object?>(result);
					}
				});
			Field<PlanetsQuery.Result>(FieldNames.Planets)
				.Arguments(PlanetsQuery.Arguments.QueryArguments())
				.Resolve(new FieldResolver
				{
					ResolveAsyncFunc = resolvefieldcontext =>
					{
						object? result = PlanetsQuery.Resolve(resolvefieldcontext.RequestServices, resolvefieldcontext =>
						{
							IQuery factionsquery = PlanetsQuery.Arguments.DefaultQuery;

							factionsquery.Ids = (resolvefieldcontext.Source as IFilm)?.PlanetIds?.ToArray();

							return factionsquery;

						}).Invoke(resolvefieldcontext);

						return System.Threading.Tasks.ValueTask.FromResult<object?>(result);
					}
				});
			Field<SpeciesQuery.Result>(FieldNames.Species)
				.Arguments(SpeciesQuery.Arguments.QueryArguments())
				.Resolve(new FieldResolver
				{
					ResolveAsyncFunc = resolvefieldcontext =>
					{
						object? result = SpeciesQuery.Resolve(resolvefieldcontext.RequestServices, resolvefieldcontext =>
						{
							IQuery factionsquery = SpeciesQuery.Arguments.DefaultQuery;

							factionsquery.Ids = (resolvefieldcontext.Source as IFilm)?.SpecieIds?.ToArray();

							return factionsquery;

						}).Invoke(resolvefieldcontext);

						return System.Threading.Tasks.ValueTask.FromResult<object?>(result);
					}
				});
			Field<StarshipsQuery.Result>(FieldNames.Starships)
				.Arguments(StarshipsQuery.Arguments.QueryArguments())
				.Resolve(new FieldResolver
				{
					ResolveAsyncFunc = resolvefieldcontext =>
					{
						object? result = StarshipsQuery.Resolve(resolvefieldcontext.RequestServices, resolvefieldcontext =>
						{
							IQuery factionsquery = StarshipsQuery.Arguments.DefaultQuery;

							factionsquery.Ids = (resolvefieldcontext.Source as IFilm)?.StarshipIds?.ToArray();

							return factionsquery;

						}).Invoke(resolvefieldcontext);

						return System.Threading.Tasks.ValueTask.FromResult<object?>(result);
					}
				});
			Field<VehiclesQuery.Result>(FieldNames.Vehicles)
				.Arguments(VehiclesQuery.Arguments.QueryArguments())
				.Resolve(new FieldResolver
				{
					ResolveAsyncFunc = resolvefieldcontext =>
					{
						object? result = VehiclesQuery.Resolve(resolvefieldcontext.RequestServices, resolvefieldcontext =>
						{
							IQuery factionsquery = VehiclesQuery.Arguments.DefaultQuery;

							factionsquery.Ids = (resolvefieldcontext.Source as IFilm)?.VehicleIds?.ToArray();

							return factionsquery;

						}).Invoke(resolvefieldcontext);

						return System.Threading.Tasks.ValueTask.FromResult<object?>(result);
					}
				});
			Field<WeaponsQuery.Result>(FieldNames.Weapons)
				.Arguments(WeaponsQuery.Arguments.QueryArguments())
				.Resolve(new FieldResolver
				{
					ResolveAsyncFunc = resolvefieldcontext =>
					{
						object? result = WeaponsQuery.Resolve(resolvefieldcontext.RequestServices, resolvefieldcontext =>
						{
							IQuery factionsquery = WeaponsQuery.Arguments.DefaultQuery;

							factionsquery.Ids = (resolvefieldcontext.Source as IFilm)?.WeaponIds?.ToArray();

							return factionsquery;

						}).Invoke(resolvefieldcontext);

						return System.Threading.Tasks.ValueTask.FromResult<object?>(result);
					}
				});
		}
	}
}
