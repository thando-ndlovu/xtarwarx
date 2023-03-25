using Localisation.Abstractions.Swagger;

namespace Localisation.Utils.Swagger
{
	public class SwaggerEndpoints
	{
		public const string ResourceName = "Swagger.SwaggerEndpoints";

		public static readonly ISwaggerEndpointsLocalisation<ISwaggerEndpointLocalisation<string>> Keys = new ISwaggerEndpointsLocalisation.Default<ISwaggerEndpointLocalisation<string>>(new ISwaggerEndpointLocalisation.Default<string>(string.Empty))
		{
			Characters = new ISwaggerEndpointLocalisation.Default<string>(string.Empty)
			{
				Description = "SwaggerEndpoints_Characters_Description",
				OperationId = "SwaggerEndpoints_Characters_OperationId",
				Summary = "SwaggerEndpoints_Characters_Summary",
			},
			Factions = new ISwaggerEndpointLocalisation.Default<string>(string.Empty)
			{
				Description = "SwaggerEndpoints_Factions_Description",
				OperationId = "SwaggerEndpoints_Factions_OperationId",
				Summary = "SwaggerEndpoints_Factions_Summary",
			},
			Films = new ISwaggerEndpointLocalisation.Default<string>(string.Empty)
			{
				Description = "SwaggerEndpoints_Films_Description",
				OperationId = "SwaggerEndpoints_Films_OperationId",
				Summary = "SwaggerEndpoints_Films_Summary",
			},
			Manufacturers = new ISwaggerEndpointLocalisation.Default<string>(string.Empty)
			{
				Description = "SwaggerEndpoints_Manufacturers_Description",
				OperationId = "SwaggerEndpoints_Manufacturers_OperationId",
				Summary = "SwaggerEndpoints_Manufacturers_Summary",
			},
			Planets = new ISwaggerEndpointLocalisation.Default<string>(string.Empty)
			{
				Description = "SwaggerEndpoints_Planets_Description",
				OperationId = "SwaggerEndpoints_Planets_OperationId",
				Summary = "SwaggerEndpoints_Planets_Summary",
			},
			Search = new ISwaggerEndpointLocalisation.Default<string>(string.Empty)
			{
				Description = "SwaggerEndpoints_Search_Description",
				OperationId = "SwaggerEndpoints_Search_OperationId",
				Summary = "SwaggerEndpoints_Search_Summary",
			},																		  
			Species = new ISwaggerEndpointLocalisation.Default<string>(string.Empty)
			{
				Description = "SwaggerEndpoints_Species_Description",
				OperationId = "SwaggerEndpoints_Species_OperationId",
				Summary = "SwaggerEndpoints_Species_Summary",
			},
			Starships = new ISwaggerEndpointLocalisation.Default<string>(string.Empty)
			{
				Description = "SwaggerEndpoints_Starships_Description",
				OperationId = "SwaggerEndpoints_Starships_OperationId",
				Summary = "SwaggerEndpoints_Starships_Summary",
			},
			Vehicles = new ISwaggerEndpointLocalisation.Default<string>(string.Empty)
			{
				Description = "SwaggerEndpoints_Vehicles_Description",
				OperationId = "SwaggerEndpoints_Vehicles_OperationId",
				Summary = "SwaggerEndpoints_Vehicles_Summary",
			},
			Weapons = new ISwaggerEndpointLocalisation.Default<string>(string.Empty)
			{
				Description = "SwaggerEndpoints_Weapons_Description",
				OperationId = "SwaggerEndpoints_Weapons_OperationId",
				Summary = "SwaggerEndpoints_Weapons_Summary",
			},		
			Meta = new ISwaggerEndpointLocalisation.Default<string>(string.Empty)
			{
				Description = "SwaggerEndpoints_Meta_Description",
				OperationId = "SwaggerEndpoints_Meta_OperationId",
				Summary = "SwaggerEndpoints_Meta_Summary",
			},
		};
	}

	public static class SwaggerEndpointsExtensions
	{
		public static ISwaggerEndpointsLocalisation? GetSwaggerEndpoints(this LocalisationResourceManager? localisationResourceManager, ISwaggerEndpointsLocalisation<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new ISwaggerEndpointsLocalisation.Default
				{
					Characters = retriever?.Characters ?? true ? new ISwaggerEndpointLocalisation.Default
					{
						Description = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Characters.Description),
						OperationId = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Characters.OperationId),
						Summary = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Characters.Summary),

					} : null,
					Factions = retriever?.Factions ?? true ? new ISwaggerEndpointLocalisation.Default
					{
						Description = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Factions.Description),
						OperationId = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Factions.OperationId),
						Summary = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Factions.Summary),

					} : null,
					Films = retriever?.Films ?? true ? new ISwaggerEndpointLocalisation.Default
					{
						Description = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Films.Description),
						OperationId = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Films.OperationId),
						Summary = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Films.Summary),

					} : null,
					Manufacturers = retriever?.Manufacturers ?? true ? new ISwaggerEndpointLocalisation.Default
					{
						Description = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Manufacturers.Description),
						OperationId = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Manufacturers.OperationId),
						Summary = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Manufacturers.Summary),

					} : null,
					Planets = retriever?.Planets ?? true ? new ISwaggerEndpointLocalisation.Default
					{
						Description = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Planets.Description),
						OperationId = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Planets.OperationId),
						Summary = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Planets.Summary),

					} : null,
					Search = retriever?.Search ?? true ? new ISwaggerEndpointLocalisation.Default
					{
						Description = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Search.Description),
						OperationId = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Search.OperationId),
						Summary = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Search.Summary),

					} : null,			
					Species = retriever?.Species ?? true ? new ISwaggerEndpointLocalisation.Default
					{
						Description = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Species.Description),
						OperationId = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Species.OperationId),
						Summary = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Species.Summary),

					} : null,
					Starships = retriever?.Starships ?? true ? new ISwaggerEndpointLocalisation.Default
					{
						Description = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Starships.Description),
						OperationId = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Starships.OperationId),
						Summary = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Starships.Summary),

					} : null,
					Vehicles = retriever?.Vehicles ?? true ? new ISwaggerEndpointLocalisation.Default
					{
						Description = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Vehicles.Description),
						OperationId = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Vehicles.OperationId),
						Summary = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Vehicles.Summary),

					} : null,
					Weapons = retriever?.Weapons ?? true ? new ISwaggerEndpointLocalisation.Default
					{
						Description = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Weapons.Description),
						OperationId = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Weapons.OperationId),
						Summary = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Weapons.Summary),

					} : null,
					Meta = retriever?.Meta ?? true ? new ISwaggerEndpointLocalisation.Default
					{
						Description = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Meta.Description),
						OperationId = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Meta.OperationId),
						Summary = localisationResourceManager.GetString(SwaggerEndpoints.Keys.Meta.Summary),

					} : null,
				};
	}
}
