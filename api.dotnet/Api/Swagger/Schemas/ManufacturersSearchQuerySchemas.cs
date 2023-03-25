using Api.Queries.Search;
using Api.Swagger.Options;

namespace Api.Swagger.Schemas
{
	public class ManufacturersSearchQuerySchemas : StarWarsModelSearchQuerySchemas
	{
		public const string Id_Description = nameof(IManufacturersSearchQuery.Description);
		public const string Id_HeadquatersPlanetDescription = nameof(IManufacturersSearchQuery.HeadquatersPlanetDescription);
		public const string Id_HeadquatersPlanetName = nameof(IManufacturersSearchQuery.HeadquatersPlanetName);
		public const string Id_Name = nameof(IManufacturersSearchQuery.Name);
		public const string Id_StarshipsDescription = nameof(IManufacturersSearchQuery.StarshipsDescription);
		public const string Id_StarshipsModel = nameof(IManufacturersSearchQuery.StarshipsModel);
		public const string Id_StarshipsName = nameof(IManufacturersSearchQuery.StarshipsName);
		public const string Id_StarshipsStarshipClass = nameof(IManufacturersSearchQuery.StarshipsStarshipClass);
		public const string Id_StarshipsStarshipClassFlags = nameof(IManufacturersSearchQuery.StarshipsStarshipClassFlags);
		public const string Id_VehiclesDescription = nameof(IManufacturersSearchQuery.VehiclesDescription);
		public const string Id_VehiclesModel = nameof(IManufacturersSearchQuery.VehiclesModel);
		public const string Id_VehiclesName = nameof(IManufacturersSearchQuery.VehiclesName);
		public const string Id_VehiclesVehicleClass = nameof(IManufacturersSearchQuery.VehiclesVehicleClass);
		public const string Id_VehiclesVehicleClassFlags = nameof(IManufacturersSearchQuery.VehiclesVehicleClassFlags);
		public const string Id_WeaponsDescription = nameof(IManufacturersSearchQuery.WeaponsDescription);
		public const string Id_WeaponsModel = nameof(IManufacturersSearchQuery.WeaponsModel);
		public const string Id_WeaponsName = nameof(IManufacturersSearchQuery.WeaponsName);
		public const string Id_WeaponsWeaponClass = nameof(IManufacturersSearchQuery.WeaponsWeaponClass);
		public const string Id_WeaponsWeaponClassFlags = nameof(IManufacturersSearchQuery.WeaponsWeaponClassFlags);

		public new static IManufacturersSearchQuery<SwaggerSchema?> Default()
		{
			IStarWarsModelSearchQuery<SwaggerSchema?> starwarsmodelsearchquery = StarWarsModelSearchQuerySchemas.Default();

			return new IManufacturersSearchQuery.Default<SwaggerSchema?>(null)
			{
				SearchString = starwarsmodelsearchquery.SearchString,

				Description = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_Description; 
					swaggerschema.Name = "Description";
				}),
				HeadquatersPlanetDescription = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_HeadquatersPlanetDescription; 
					swaggerschema.Name = "HeadquatersPlanetDescription";
				}),
				HeadquatersPlanetName = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_HeadquatersPlanetName; 
					swaggerschema.Name = "HeadquatersPlanetName";
				}),
				Name = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_Name; 
					swaggerschema.Name = "Name";
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
