using Api.Queries.Search;
using Api.Swagger.Options;

namespace Api.Swagger.Schemas
{
	public class PlanetsSearchQuerySchemas : StarWarsModelSearchQuerySchemas
	{
		public const string Id_ClimateTypes = nameof(IPlanetsSearchQuery.ClimateTypes); 
		public const string Id_ClimateFlags = nameof(IPlanetsSearchQuery.ClimateFlags); 
		public const string Id_Description = nameof(IPlanetsSearchQuery.Description); 
		public const string Id_Diameters = nameof(IPlanetsSearchQuery.Diameters); 
		public const string Id_DiameterRangeLower = nameof(IPlanetsSearchQuery.DiameterRangeLower); 
		public const string Id_DiameterRangeUpper = nameof(IPlanetsSearchQuery.DiameterRangeUpper); 
		public const string Id_Gravities = nameof(IPlanetsSearchQuery.Gravities); 
		public const string Id_GravityRangeLower = nameof(IPlanetsSearchQuery.GravityRangeLower); 
		public const string Id_GravityRangeUpper = nameof(IPlanetsSearchQuery.GravityRangeUpper); 
		public const string Id_Name = nameof(IPlanetsSearchQuery.Name); 
		public const string Id_OrbitalPeriods = nameof(IPlanetsSearchQuery.OrbitalPeriods); 
		public const string Id_OrbitalPeriodRangeLower = nameof(IPlanetsSearchQuery.OrbitalPeriodRangeLower); 
		public const string Id_OrbitalPeriodRangeUpper = nameof(IPlanetsSearchQuery.OrbitalPeriodRangeUpper); 
		public const string Id_Populations = nameof(IPlanetsSearchQuery.Populations); 
		public const string Id_PopulationRangeLower = nameof(IPlanetsSearchQuery.PopulationRangeLower); 
		public const string Id_PopulationRangeUpper = nameof(IPlanetsSearchQuery.PopulationRangeUpper); 
		public const string Id_ResidentsDescription = nameof(IPlanetsSearchQuery.ResidentsDescription); 
		public const string Id_ResidentsName = nameof(IPlanetsSearchQuery.ResidentsName); 
		public const string Id_RotationalPeriods = nameof(IPlanetsSearchQuery.RotationalPeriods); 
		public const string Id_RotationalPeriodRangeLower = nameof(IPlanetsSearchQuery.RotationalPeriodRangeLower); 
		public const string Id_RotationalPeriodRangeUpper = nameof(IPlanetsSearchQuery.RotationalPeriodRangeUpper); 
		public const string Id_SurfaceWaters = nameof(IPlanetsSearchQuery.SurfaceWaters); 
		public const string Id_SurfaceWaterRangeLower = nameof(IPlanetsSearchQuery.SurfaceWaterRangeLower); 
		public const string Id_SurfaceWaterRangeUpper = nameof(IPlanetsSearchQuery.SurfaceWaterRangeUpper); 
		public const string Id_TerrainTypes = nameof(IPlanetsSearchQuery.TerrainTypes); 
		public const string Id_TerrainFlags = nameof(IPlanetsSearchQuery.TerrainFlags); 

		public new static IPlanetsSearchQuery<SwaggerSchema?> Default()
		{
			IStarWarsModelSearchQuery<SwaggerSchema?> starwarsmodelsearchquery = StarWarsModelSearchQuerySchemas.Default();

			return new IPlanetsSearchQuery.Default<SwaggerSchema?>(null)
			{
				SearchString = starwarsmodelsearchquery.SearchString,

				ClimateTypes = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_ClimateTypes;
					swaggerschema.Name = "ClimateTypes";
				}),
				ClimateFlags = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_ClimateFlags;
					swaggerschema.Name = "ClimateFlags";
				}),
				Description = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_Description;
					swaggerschema.Name = "Description";
				}),
				Diameters = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_Diameters;
					swaggerschema.Name = "Diameters";
				}),
				DiameterRangeLower = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_DiameterRangeLower;
					swaggerschema.Name = "DiameterRangeLower";
				}),
				DiameterRangeUpper = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_DiameterRangeUpper;
					swaggerschema.Name = "DiameterRangeUpper";
				}),
				Gravities = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_Gravities;
					swaggerschema.Name = "Gravities";
				}),
				GravityRangeLower = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_GravityRangeLower;
					swaggerschema.Name = "GravityRangeLower";
				}),
				GravityRangeUpper = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_GravityRangeUpper;
					swaggerschema.Name = "GravityRangeUpper";
				}),
				Name = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_Name;
					swaggerschema.Name = "Name";
				}),
				OrbitalPeriods = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_OrbitalPeriods;
					swaggerschema.Name = "OrbitalPeriods";
				}),
				OrbitalPeriodRangeLower = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_OrbitalPeriodRangeLower;
					swaggerschema.Name = "OrbitalPeriodRangeLower";
				}),
				OrbitalPeriodRangeUpper = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_OrbitalPeriodRangeUpper;
					swaggerschema.Name = "OrbitalPeriodRangeUpper";
				}),
				Populations = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_Populations;
					swaggerschema.Name = "Populations";
				}),
				PopulationRangeLower = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_PopulationRangeLower;
					swaggerschema.Name = "PopulationRangeLower";
				}),
				PopulationRangeUpper = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_PopulationRangeUpper;
					swaggerschema.Name = "PopulationRangeUpper";
				}),
				ResidentsDescription = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_ResidentsDescription;
					swaggerschema.Name = "ResidentsDescription";
				}),
				ResidentsName = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_ResidentsName;
					swaggerschema.Name = "ResidentsName";
				}),
				RotationalPeriods = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_RotationalPeriods;
					swaggerschema.Name = "RotationalPeriods";
				}),
				RotationalPeriodRangeLower = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_RotationalPeriodRangeLower;
					swaggerschema.Name = "RotationalPeriodRangeLower";
				}),
				RotationalPeriodRangeUpper = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_RotationalPeriodRangeUpper;
					swaggerschema.Name = "RotationalPeriodRangeUpper";
				}),
				SurfaceWaters = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_SurfaceWaters;
					swaggerschema.Name = "SurfaceWaters";
				}),
				SurfaceWaterRangeLower = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_SurfaceWaterRangeLower;
					swaggerschema.Name = "SurfaceWaterRangeLower";
				}),
				SurfaceWaterRangeUpper = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_SurfaceWaterRangeUpper;
					swaggerschema.Name = "SurfaceWaterRangeUpper";
				}),
				TerrainTypes = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_TerrainTypes;
					swaggerschema.Name = "TerrainTypes";
				}),
				TerrainFlags = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_TerrainFlags;
					swaggerschema.Name = "TerrainFlags";
				}),
			};
		} 
	}
}
