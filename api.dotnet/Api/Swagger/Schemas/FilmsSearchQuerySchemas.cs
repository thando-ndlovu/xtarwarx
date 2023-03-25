using Api.Queries.Search;
using Api.Swagger.Options;

namespace Api.Swagger.Schemas
{
	public class FilmsSearchQuerySchemas : StarWarsModelSearchQuerySchemas
	{
		public const string Id_CastMembers = nameof(IFilmsSearchQuery.CastMembers);
		public const string Id_CharactersDescription = nameof(IFilmsSearchQuery.CharactersDescription);
		public const string Id_CharactersName = nameof(IFilmsSearchQuery.CharactersName);
		public const string Id_Description = nameof(IFilmsSearchQuery.Description);
		public const string Id_Director = nameof(IFilmsSearchQuery.Director);
		public const string Id_Durations = nameof(IFilmsSearchQuery.Durations);
		public const string Id_DurationRangeLower = nameof(IFilmsSearchQuery.DurationRangeLower);
		public const string Id_DurationRangeUpper = nameof(IFilmsSearchQuery.DurationRangeUpper);
		public const string Id_EpisodeIds = nameof(IFilmsSearchQuery.EpisodeIds);
		public const string Id_EpisodeIdRangeLower = nameof(IFilmsSearchQuery.EpisodeIdRangeLower);
		public const string Id_EpisodeIdRangeUpper = nameof(IFilmsSearchQuery.EpisodeIdRangeUpper);
		public const string Id_FactionsDescription = nameof(IFilmsSearchQuery.FactionsDescription);
		public const string Id_FactionsName = nameof(IFilmsSearchQuery.FactionsName);
		public const string Id_ManufacturersDescription = nameof(IFilmsSearchQuery.ManufacturersDescription);
		public const string Id_ManufacturersName = nameof(IFilmsSearchQuery.ManufacturersName);
		public const string Id_OpeningCrawl = nameof(IFilmsSearchQuery.OpeningCrawl);
		public const string Id_PlanetsDescription = nameof(IFilmsSearchQuery.PlanetsDescription);
		public const string Id_PlanetsName = nameof(IFilmsSearchQuery.PlanetsName);
		public const string Id_Producers = nameof(IFilmsSearchQuery.Producers);
		public const string Id_ReleaseDates = nameof(IFilmsSearchQuery.ReleaseDates);
		public const string Id_ReleaseDateRangeLower = nameof(IFilmsSearchQuery.ReleaseDateRangeLower);
		public const string Id_ReleaseDateRangeUpper = nameof(IFilmsSearchQuery.ReleaseDateRangeUpper);
		public const string Id_SpeciesDescription = nameof(IFilmsSearchQuery.SpeciesDescription);
		public const string Id_SpeciesName = nameof(IFilmsSearchQuery.SpeciesName);
		public const string Id_StarshipsDescription = nameof(IFilmsSearchQuery.StarshipsDescription);
		public const string Id_StarshipsModel = nameof(IFilmsSearchQuery.StarshipsModel);
		public const string Id_StarshipsName = nameof(IFilmsSearchQuery.StarshipsName);
		public const string Id_StarshipsStarshipClass = nameof(IFilmsSearchQuery.StarshipsStarshipClass);
		public const string Id_StarshipsStarshipClassFlags = nameof(IFilmsSearchQuery.StarshipsStarshipClassFlags);
		public const string Id_Title = nameof(IFilmsSearchQuery.Title);
		public const string Id_VehiclesDescription = nameof(IFilmsSearchQuery.VehiclesDescription);
		public const string Id_VehiclesModel = nameof(IFilmsSearchQuery.VehiclesModel);
		public const string Id_VehiclesName = nameof(IFilmsSearchQuery.VehiclesName);
		public const string Id_VehiclesVehicleClass = nameof(IFilmsSearchQuery.VehiclesVehicleClass);
		public const string Id_VehiclesVehicleClassFlags = nameof(IFilmsSearchQuery.VehiclesVehicleClassFlags);
		public const string Id_WeaponsDescription = nameof(IFilmsSearchQuery.WeaponsDescription);
		public const string Id_WeaponsModel = nameof(IFilmsSearchQuery.WeaponsModel);
		public const string Id_WeaponsName = nameof(IFilmsSearchQuery.WeaponsName);
		public const string Id_WeaponsWeaponClass = nameof(IFilmsSearchQuery.WeaponsWeaponClass);
		public const string Id_WeaponsWeaponClassFlags = nameof(IFilmsSearchQuery.WeaponsWeaponClassFlags);

		public new static IFilmsSearchQuery<SwaggerSchema?> Default()
		{
			IStarWarsModelSearchQuery<SwaggerSchema?> starwarsmodelsearchquery = StarWarsModelSearchQuerySchemas.Default();

			return new IFilmsSearchQuery.Default<SwaggerSchema?>(null)
			{
				SearchString = starwarsmodelsearchquery.SearchString,

				CastMembers = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_CastMembers;
					swaggerschema.Name = "CastMembers";
				}),
				CharactersDescription = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_CharactersDescription;
					swaggerschema.Name = "CharactersDescription";
				}),
				CharactersName = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_CharactersName;
					swaggerschema.Name = "CharactersName";
				}),
				Description = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_Description;
					swaggerschema.Name = "Description";
				}),
				Director = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_Director;
					swaggerschema.Name = "Director";
				}),
				Durations = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_Durations;
					swaggerschema.Name = "Durations";
				}),
				DurationRangeLower = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_DurationRangeLower;
					swaggerschema.Name = "DurationRangeLower";
				}),
				DurationRangeUpper = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_DurationRangeUpper;
					swaggerschema.Name = "DurationRangeUpper";
				}),
				EpisodeIds = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_EpisodeIds;
					swaggerschema.Name = "EpisodeIds";
				}),
				EpisodeIdRangeLower = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_EpisodeIdRangeLower;
					swaggerschema.Name = "EpisodeIdRangeLower";
				}),
				EpisodeIdRangeUpper = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_EpisodeIdRangeUpper;
					swaggerschema.Name = "EpisodeIdRangeUpper";
				}),
				FactionsDescription = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_FactionsDescription;
					swaggerschema.Name = "FactionsDescription";
				}),
				FactionsName = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_FactionsName;
					swaggerschema.Name = "FactionsName";
				}),
				ManufacturersDescription = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_ManufacturersDescription;
					swaggerschema.Name = "ManufacturersDescription";
				}),
				ManufacturersName = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_ManufacturersName;
					swaggerschema.Name = "ManufacturersName";
				}),
				OpeningCrawl = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_OpeningCrawl;
					swaggerschema.Name = "OpeningCrawl";
				}),
				PlanetsDescription = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_PlanetsDescription;
					swaggerschema.Name = "PlanetsDescription";
				}),
				PlanetsName = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_PlanetsName;
					swaggerschema.Name = "PlanetsName";
				}),
				Producers = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_Producers;
					swaggerschema.Name = "Producers";
				}),
				ReleaseDates = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_ReleaseDates;
					swaggerschema.Name = "ReleaseDates";
				}),
				ReleaseDateRangeLower = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_ReleaseDateRangeLower;
					swaggerschema.Name = "ReleaseDateRangeLower";
				}),
				ReleaseDateRangeUpper = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_ReleaseDateRangeUpper;
					swaggerschema.Name = "ReleaseDateRangeUpper";
				}),
				SpeciesDescription = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_SpeciesDescription;
					swaggerschema.Name = "SpeciesDescription";
				}),
				SpeciesName = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_SpeciesName;
					swaggerschema.Name = "SpeciesName";
				}),
				StarshipsDescription = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_StarshipsDescription;
					swaggerschema.Name = "StarshipsDescription";
				}),
				StarshipsModel = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_StarshipsModel;
					swaggerschema.Name = "StarshipsModel";
				}),
				StarshipsName = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_StarshipsName;
					swaggerschema.Name = "StarshipsName";
				}),
				StarshipsStarshipClass = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_StarshipsStarshipClass;
					swaggerschema.Name = "StarshipsStarshipClass";
				}),
				StarshipsStarshipClassFlags = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_StarshipsStarshipClassFlags;
					swaggerschema.Name = "StarshipsStarshipClassFlags";
				}),
				Title = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_Title;
					swaggerschema.Name = "Title";
				}),
				VehiclesDescription = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_VehiclesDescription;
					swaggerschema.Name = "VehiclesDescription";
				}),
				VehiclesModel = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_VehiclesModel;
					swaggerschema.Name = "VehiclesModel";
				}),
				VehiclesName = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_VehiclesName;
					swaggerschema.Name = "VehiclesName";
				}),
				VehiclesVehicleClass = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_VehiclesVehicleClass;
					swaggerschema.Name = "VehiclesVehicleClass";
				}),
				VehiclesVehicleClassFlags = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_VehiclesVehicleClassFlags;
					swaggerschema.Name = "VehiclesVehicleClassFlags";
				}),
				WeaponsDescription = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_WeaponsDescription;
					swaggerschema.Name = "WeaponsDescription";
				}),
				WeaponsModel = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_WeaponsModel;
					swaggerschema.Name = "WeaponsModel";
				}),
				WeaponsName = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_WeaponsName;
					swaggerschema.Name = "WeaponsName";
				}),
				WeaponsWeaponClass = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_WeaponsWeaponClass;
					swaggerschema.Name = "WeaponsWeaponClass";
				}),
				WeaponsWeaponClassFlags = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_WeaponsWeaponClassFlags;
					swaggerschema.Name = "WeaponsWeaponClassFlags";
				}),
			};
		} 
	}
}
