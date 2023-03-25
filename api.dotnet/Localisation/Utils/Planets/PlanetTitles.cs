using Domain.Models;

namespace Localisation.Utils.Planets
{
	public class PlanetTitles 
	{
		public const string ResourceName = "Planets.PlanetTitles";

		public static readonly IPlanet<string> Keys = new IPlanet.Default<string>(string.Empty)
		{
			Climates = "PlanetTitles_Climates",
			Description = "PlanetTitles_Description",
			Diameter = "PlanetTitles_Diameter",
			Gravity = "PlanetTitles_Gravity",
			Id = "PlanetTitles_Id",
			Name = "PlanetTitles_Name",
			OrbitalPeriod = "PlanetTitles_OrbitalPeriod",
			Population = "PlanetTitles_Population",
			ResidentIds = "PlanetTitles_ResidentIds",
			RotationalPeriod = "PlanetTitles_RotationalPeriod",
			SurfaceWater = "PlanetTitles_SurfaceWater",
			Terrains = "PlanetTitles_Terrains",
			Uris = "PlanetTitles_Uris",
			Created = "PlanetTitles_Created",
			Edited = "PlanetTitles_Edited",
		};
	}

	public static class PlanetTitlesExtensions
	{
		public static IPlanet<string?>? GetPlanetTitles(this LocalisationResourceManager? localisationResourceManager, IPlanet<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IPlanet.Default<string?>(null)
				{
					Climates = retriever?.Climates ?? true ? localisationResourceManager.GetString(PlanetTitles.Keys.Climates) : null,
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(PlanetTitles.Keys.Created) : null,
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(PlanetTitles.Keys.Description) : null,
					Diameter = retriever?.Diameter ?? true ? localisationResourceManager.GetString(PlanetTitles.Keys.Diameter) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(PlanetTitles.Keys.Edited) : null,
					Gravity = retriever?.Gravity ?? true ? localisationResourceManager.GetString(PlanetTitles.Keys.Gravity) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(PlanetTitles.Keys.Id) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(PlanetTitles.Keys.Name) : null,
					OrbitalPeriod = retriever?.OrbitalPeriod ?? true ? localisationResourceManager.GetString(PlanetTitles.Keys.OrbitalPeriod) : null,
					Population = retriever?.Population ?? true ? localisationResourceManager.GetString(PlanetTitles.Keys.Population) : null,
					ResidentIds = retriever?.ResidentIds ?? true ? localisationResourceManager.GetString(PlanetTitles.Keys.ResidentIds) : null,
					RotationalPeriod = retriever?.RotationalPeriod ?? true ? localisationResourceManager.GetString(PlanetTitles.Keys.RotationalPeriod) : null,
					SurfaceWater = retriever?.SurfaceWater ?? true ? localisationResourceManager.GetString(PlanetTitles.Keys.SurfaceWater) : null,
					Terrains = localisationResourceManager.GetString(PlanetTitles.Keys.Terrains),
					Uris = retriever?.Uris ?? true ? localisationResourceManager.GetString(PlanetTitles.Keys.Uris) : null,
				};
	}
}
