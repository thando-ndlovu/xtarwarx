using Api.Queries.Search;
using Api.Swagger.Options;

namespace Api.Swagger.Schemas
{
	public class WeaponsSearchQuerySchemas : StarWarsModelSearchQuerySchemas
	{
		public const string Id_Description = nameof(IWeaponsSearchQuery.Description);
		public const string Id_ManufacturersDescription = nameof(IWeaponsSearchQuery.ManufacturersDescription);
		public const string Id_ManufacturersName = nameof(IWeaponsSearchQuery.ManufacturersName);
		public const string Id_Model = nameof(IWeaponsSearchQuery.Model);
		public const string Id_Name = nameof(IWeaponsSearchQuery.Name);
		public const string Id_WeaponClass = nameof(IWeaponsSearchQuery.WeaponClass);
		public const string Id_WeaponClassFlags = nameof(IWeaponsSearchQuery.WeaponClassFlags);

		public new static IWeaponsSearchQuery<SwaggerSchema?> Default()
		{
			IStarWarsModelSearchQuery<SwaggerSchema?> starwarsmodelsearchquery = StarWarsModelSearchQuerySchemas.Default();

			return new IWeaponsSearchQuery.Default<SwaggerSchema?>(null)
			{
				SearchString = starwarsmodelsearchquery.SearchString,

				Description = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_Description;
					swaggerschema.Name = "Description";
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
				Model = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_Model;
					swaggerschema.Name = "Model";
				}),
				Name = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_Name;
					swaggerschema.Name = "Name";
				}),
				WeaponClass = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_WeaponClass;
					swaggerschema.Name = "WeaponClass";
				}),
				WeaponClassFlags = DefaultSchema(swaggerschema => 
				{
					swaggerschema.Id = Id_WeaponClassFlags;
					swaggerschema.Name = "WeaponClassFlags";
				}),
			};
		} 
	}
}
