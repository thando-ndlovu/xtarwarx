using Localisation.Abstractions;

using System;
using System.Collections.Generic;
using System.Globalization;

using LocalisationUtils = Localisation.Utils;

using GeneralLocalisations = Localisation.Implementation.GeneralLocalisations;
using SwaggerLocalisations = Localisation.Implementation.SwaggerLocalisations;
using GraphQLLocalisations = Localisation.Implementation.GraphQLLocalisations;

using CharacterLocalisations = Localisation.Implementation.CharacterLocalisations;
using FactionLocalisations = Localisation.Implementation.FactionLocalisations;
using FilmLocalisations = Localisation.Implementation.FilmLocalisations;
using ManufacturerLocalisations = Localisation.Implementation.ManufacturerLocalisations;
using PlanetLocalisations = Localisation.Implementation.PlanetLocalisations;
using SpecieLocalisations = Localisation.Implementation.SpecieLocalisations;
using StarshipLocalisations = Localisation.Implementation.StarshipLocalisations;
using VehicleLocalisations = Localisation.Implementation.VehicleLocalisations;
using WeaponLocalisations = Localisation.Implementation.WeaponLocalisations;

namespace Localisation
{
	public partial interface ILocalisation : IDisposable
	{
		CultureInfo DefaultCultureInfo { get; set; }
		string? GetString(string key, string resourcename, CultureInfo? cultureInfo = null);

		IGeneralLocalisations GeneralLocalisations { get; }
		ISwaggerLocalisations SwaggerLocalisations { get; }
		IGraphQLLocalisations GraphQLLocalisations { get; }

		ICharacterLocalisations CharacterLocalisations { get; }
		IFactionLocalisations FactionLocalisations { get; }
		IFilmLocalisations FilmLocalisations { get; }
		IManufacturerLocalisations ManufacturerLocalisations { get; }
		IPlanetLocalisations PlanetLocalisations { get; }
		ISpecieLocalisations SpecieLocalisations { get; }
		IStarshipLocalisations StarshipLocalisations { get; }
		IVehicleLocalisations VehicleLocalisations { get; }
		IWeaponLocalisations WeaponLocalisations { get; }

		public class Default : ILocalisation
		{
			public Default()
			{
				DefaultCultureInfo = CultureInfo.CurrentCulture;
			}

			public CultureInfo DefaultCultureInfo { get; set; }
			public CultureInfo? CurrentCultureInfo { get; set; }
			public IList<LocalisationResourceManager>? ResourceManagers { get; set; }

			private GeneralLocalisations? _GeneralLocalisations;
			private SwaggerLocalisations? _SwaggerLocalisations;
			private GraphQLLocalisations? _GraphQLLocalisations;

			private CharacterLocalisations? _CharacterLocalisations;
			private FactionLocalisations? _FactionLocalisations;
			private FilmLocalisations? _FilmLocalisations;
			private ManufacturerLocalisations? _ManufacturerLocalisations;
			private PlanetLocalisations? _PlanetLocalisations;
			private SpecieLocalisations? _SpecieLocalisations;
			private StarshipLocalisations? _StarshipLocalisations;
			private VehicleLocalisations? _VehicleLocalisations;
			private WeaponLocalisations? _WeaponLocalisations;

			public string? GetString(string key, string resourcename, CultureInfo? cultureInfo = null)
			{
				LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo
					.FromCultureInfo(cultureInfo ?? CurrentCultureInfo ?? DefaultCultureInfo);

				LocalisationResourceManager? localisationresourcemanager = resourcename switch
				{
					#region General

					LocalisationUtils.General.GeneralPhrases.ResourceName or
					LocalisationUtils.General.GeneralWords.ResourceName => 
						(_GeneralLocalisations ??= new GeneralLocalisations())
							.GetResourceManager(resourcename, localisationcultureinfo),

					#endregion

					#region GraphQL

					LocalisationUtils.GraphQL.StarWarsQuery.ResourceName =>
						(_GeneralLocalisations ??= new GeneralLocalisations())
							.GetResourceManager(resourcename, localisationcultureinfo),

					#endregion

					#region Swagger

					LocalisationUtils.Swagger.SwaggerEndpoints.ResourceName or
					LocalisationUtils.Swagger.SwaggerGeneral.ResourceName or
					LocalisationUtils.Swagger.SwaggerParameters.ResourceName or
					LocalisationUtils.Swagger.SwaggerResponses.ResourceName =>
						(_SwaggerLocalisations ??= new SwaggerLocalisations())
							.GetResourceManager(resourcename, localisationcultureinfo),

					#endregion
							  		  
					#region Characters

					LocalisationUtils.Characters.CharacterDescriptions.ResourceName or
					LocalisationUtils.Characters.CharacterMultiple.ResourceName or
					LocalisationUtils.Characters.CharacterSearch.ResourceName or
					LocalisationUtils.Characters.CharacterSearchContainablesDescriptions.ResourceName or
					LocalisationUtils.Characters.CharacterSearchContainablesTitles.ResourceName or
					LocalisationUtils.Characters.CharacterSingle.ResourceName or
					LocalisationUtils.Characters.CharacterSortKeysDescriptions.ResourceName or
					LocalisationUtils.Characters.CharacterSortKeysTitles.ResourceName or
					LocalisationUtils.Characters.CharacterTitles.ResourceName =>
						(_CharacterLocalisations ??= new CharacterLocalisations())
							.GetResourceManager(resourcename, localisationcultureinfo),

					#endregion
							  
					#region Factions

					LocalisationUtils.Factions.FactionDescriptions.ResourceName or
					LocalisationUtils.Factions.FactionMultiple.ResourceName or
					LocalisationUtils.Factions.FactionSearch.ResourceName or
					LocalisationUtils.Factions.FactionSearchContainablesDescriptions.ResourceName or
					LocalisationUtils.Factions.FactionSearchContainablesTitles.ResourceName or
					LocalisationUtils.Factions.FactionSingle.ResourceName or
					LocalisationUtils.Factions.FactionSortKeysDescriptions.ResourceName or
					LocalisationUtils.Factions.FactionSortKeysTitles.ResourceName or
					LocalisationUtils.Factions.FactionTitles.ResourceName =>
						(_FactionLocalisations ??= new FactionLocalisations())
							.GetResourceManager(resourcename, localisationcultureinfo),

					#endregion
							  
					#region Films

					LocalisationUtils.Films.FilmDescriptions.ResourceName or
					LocalisationUtils.Films.FilmMultiple.ResourceName or
					LocalisationUtils.Films.FilmSearch.ResourceName or
					LocalisationUtils.Films.FilmSearchContainablesDescriptions.ResourceName or
					LocalisationUtils.Films.FilmSearchContainablesTitles.ResourceName or
					LocalisationUtils.Films.FilmSingle.ResourceName or
					LocalisationUtils.Films.FilmSortKeysDescriptions.ResourceName or
					LocalisationUtils.Films.FilmSortKeysTitles.ResourceName or
					LocalisationUtils.Films.FilmTitles.ResourceName =>
						(_FilmLocalisations ??= new FilmLocalisations())
							.GetResourceManager(resourcename, localisationcultureinfo),

					#endregion
							  
					#region Manufacturers

					LocalisationUtils.Manufacturers.ManufacturerDescriptions.ResourceName or
					LocalisationUtils.Manufacturers.ManufacturerMultiple.ResourceName or
					LocalisationUtils.Manufacturers.ManufacturerSearch.ResourceName or
					LocalisationUtils.Manufacturers.ManufacturerSearchContainablesDescriptions.ResourceName or
					LocalisationUtils.Manufacturers.ManufacturerSearchContainablesTitles.ResourceName or
					LocalisationUtils.Manufacturers.ManufacturerSingle.ResourceName or
					LocalisationUtils.Manufacturers.ManufacturerSortKeysDescriptions.ResourceName or
					LocalisationUtils.Manufacturers.ManufacturerSortKeysTitles.ResourceName or
					LocalisationUtils.Manufacturers.ManufacturerTitles.ResourceName =>
						(_ManufacturerLocalisations ??= new ManufacturerLocalisations())
							.GetResourceManager(resourcename, localisationcultureinfo),

					#endregion
							  
					#region Planets

					LocalisationUtils.Planets.PlanetDescriptions.ResourceName or
					LocalisationUtils.Planets.PlanetMultiple.ResourceName or
					LocalisationUtils.Planets.PlanetSearch.ResourceName or
					LocalisationUtils.Planets.PlanetSearchContainablesDescriptions.ResourceName or
					LocalisationUtils.Planets.PlanetSearchContainablesTitles.ResourceName or
					LocalisationUtils.Planets.PlanetSingle.ResourceName or
					LocalisationUtils.Planets.PlanetSortKeysDescriptions.ResourceName or
					LocalisationUtils.Planets.PlanetSortKeysTitles.ResourceName or
					LocalisationUtils.Planets.PlanetTitles.ResourceName =>
						(_PlanetLocalisations ??= new PlanetLocalisations())
							.GetResourceManager(resourcename, localisationcultureinfo),

					#endregion
							  
					#region Species

					LocalisationUtils.Species.SpecieDescriptions.ResourceName or
					LocalisationUtils.Species.SpecieMultiple.ResourceName or
					LocalisationUtils.Species.SpecieSearch.ResourceName or
					LocalisationUtils.Species.SpecieSearchContainablesDescriptions.ResourceName or
					LocalisationUtils.Species.SpecieSearchContainablesTitles.ResourceName or
					LocalisationUtils.Species.SpecieSingle.ResourceName or
					LocalisationUtils.Species.SpecieSortKeysDescriptions.ResourceName or
					LocalisationUtils.Species.SpecieSortKeysTitles.ResourceName or
					LocalisationUtils.Species.SpecieTitles.ResourceName =>
						(_SpecieLocalisations ??= new SpecieLocalisations())
							.GetResourceManager(resourcename, localisationcultureinfo),

					#endregion
							  
					#region Starships

					LocalisationUtils.Starships.StarshipDescriptions.ResourceName or
					LocalisationUtils.Starships.StarshipMultiple.ResourceName or
					LocalisationUtils.Starships.StarshipSearch.ResourceName or
					LocalisationUtils.Starships.StarshipSearchContainablesDescriptions.ResourceName or
					LocalisationUtils.Starships.StarshipSearchContainablesTitles.ResourceName or
					LocalisationUtils.Starships.StarshipSingle.ResourceName or
					LocalisationUtils.Starships.StarshipSortKeysDescriptions.ResourceName or
					LocalisationUtils.Starships.StarshipSortKeysTitles.ResourceName or
					LocalisationUtils.Starships.StarshipTitles.ResourceName =>
						(_StarshipLocalisations ??= new StarshipLocalisations())
							.GetResourceManager(resourcename, localisationcultureinfo),

					#endregion
							  
					#region Vehicles

					LocalisationUtils.Vehicles.VehicleDescriptions.ResourceName or
					LocalisationUtils.Vehicles.VehicleMultiple.ResourceName or
					LocalisationUtils.Vehicles.VehicleSearch.ResourceName or
					LocalisationUtils.Vehicles.VehicleSearchContainablesDescriptions.ResourceName or
					LocalisationUtils.Vehicles.VehicleSearchContainablesTitles.ResourceName or
					LocalisationUtils.Vehicles.VehicleSingle.ResourceName or
					LocalisationUtils.Vehicles.VehicleSortKeysDescriptions.ResourceName or
					LocalisationUtils.Vehicles.VehicleSortKeysTitles.ResourceName or
					LocalisationUtils.Vehicles.VehicleTitles.ResourceName =>
						(_VehicleLocalisations ??= new VehicleLocalisations())
							.GetResourceManager(resourcename, localisationcultureinfo),

					#endregion

					#region Weapons

					LocalisationUtils.Weapons.WeaponDescriptions.ResourceName or
					LocalisationUtils.Weapons.WeaponMultiple.ResourceName or
					LocalisationUtils.Weapons.WeaponSearch.ResourceName or
					LocalisationUtils.Weapons.WeaponSearchContainablesDescriptions.ResourceName or
					LocalisationUtils.Weapons.WeaponSearchContainablesTitles.ResourceName or
					LocalisationUtils.Weapons.WeaponSingle.ResourceName or
					LocalisationUtils.Weapons.WeaponSortKeysDescriptions.ResourceName or
					LocalisationUtils.Weapons.WeaponSortKeysTitles.ResourceName or
					LocalisationUtils.Weapons.WeaponTitles.ResourceName =>
						(_WeaponLocalisations ??= new WeaponLocalisations())
							.GetResourceManager(resourcename, localisationcultureinfo),

					#endregion

					_ => null,
				};

				return localisationresourcemanager?.GetString(key);
			}

			public IGeneralLocalisations GeneralLocalisations => _GeneralLocalisations ??= new GeneralLocalisations
			{
				DefaultCultureInfo = DefaultCultureInfo,
				ResourceManagers = ResourceManagers,
			};				  
			public ISwaggerLocalisations SwaggerLocalisations => _SwaggerLocalisations ??= new SwaggerLocalisations
			{
				DefaultCultureInfo = DefaultCultureInfo,
				ResourceManagers = ResourceManagers,
			};	   		  
			public IGraphQLLocalisations GraphQLLocalisations => _GraphQLLocalisations ??= new GraphQLLocalisations
			{
				DefaultCultureInfo = DefaultCultureInfo,
				ResourceManagers = ResourceManagers,
			};

			public ICharacterLocalisations CharacterLocalisations => _CharacterLocalisations ??= new CharacterLocalisations
			{
				DefaultCultureInfo = DefaultCultureInfo,
				ResourceManagers = ResourceManagers,
			};
			public IFactionLocalisations FactionLocalisations => _FactionLocalisations ??= new FactionLocalisations
			{
				DefaultCultureInfo = DefaultCultureInfo,
				ResourceManagers = ResourceManagers,
			};
			public IFilmLocalisations FilmLocalisations => _FilmLocalisations ??= new FilmLocalisations
			{
				DefaultCultureInfo = DefaultCultureInfo,
				ResourceManagers = ResourceManagers,
			};
			public IManufacturerLocalisations ManufacturerLocalisations => _ManufacturerLocalisations ??= new ManufacturerLocalisations
			{
				DefaultCultureInfo = DefaultCultureInfo,
				ResourceManagers = ResourceManagers,
			};
			public IPlanetLocalisations PlanetLocalisations => _PlanetLocalisations ??= new PlanetLocalisations
			{
				DefaultCultureInfo = DefaultCultureInfo,
				ResourceManagers = ResourceManagers,
			};
			public ISpecieLocalisations SpecieLocalisations => _SpecieLocalisations ??= new SpecieLocalisations
			{
				DefaultCultureInfo = DefaultCultureInfo,
				ResourceManagers = ResourceManagers,
			};
			public IStarshipLocalisations StarshipLocalisations => _StarshipLocalisations ??= new StarshipLocalisations
			{
				DefaultCultureInfo = DefaultCultureInfo,
				ResourceManagers = ResourceManagers,
			};
			public IVehicleLocalisations VehicleLocalisations => _VehicleLocalisations ??= new VehicleLocalisations
			{
				DefaultCultureInfo = DefaultCultureInfo,
				ResourceManagers = ResourceManagers,
			};
			public IWeaponLocalisations WeaponLocalisations => _WeaponLocalisations ??= new WeaponLocalisations
			{
				DefaultCultureInfo = DefaultCultureInfo,
				ResourceManagers = ResourceManagers,
			};

			public void Dispose()
			{
				if (ResourceManagers != null)
					foreach (LocalisationResourceManager resourcemanager in ResourceManagers)
						resourcemanager.ReleaseAllResources();

				ResourceManagers?.Clear();
				ResourceManagers = null;
			}
		}
	}
}
