using Domain.Models;

namespace Localisation.Utils.Planets
{
	public class PlanetDescriptions
	{
		public const string ResourceName = "Planets.PlanetDescriptions";

		public static readonly IPlanet<string> Keys = new IPlanet.Default<string>(string.Empty)
		{
			Climates = "PlanetDescriptions_Climates",
			Description = "PlanetDescriptions_Description",
			Diameter = "PlanetDescriptions_Diameter",
			Gravity = "PlanetDescriptions_Gravity",
			Id = "PlanetDescriptions_Id",
			Name = "PlanetDescriptions_Name",
			OrbitalPeriod = "PlanetDescriptions_OrbitalPeriod",
			Population = "PlanetDescriptions_Population",
			ResidentIds = "PlanetDescriptions_ResidentIds",
			RotationalPeriod = "PlanetDescriptions_RotationalPeriod",
			SurfaceWater = "PlanetDescriptions_SurfaceWater",
			Terrains = "PlanetDescriptions_Terrains",
			Uris = "PlanetDescriptions_Uris",
			Created = "PlanetDescriptions_Created",
			Edited = "PlanetDescriptions_Edited",
		};
	}

	public static class PlanetDescriptionsExtensions
	{
		public static IPlanet<string?>? GetPlanetDescriptions(this LocalisationResourceManager? localisationResourceManager, IPlanet<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IPlanet.Default<string?>(null)
				{
					Climates = retriever?.Climates ?? true ? localisationResourceManager.GetString(PlanetDescriptions.Keys.Climates) : null,
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(PlanetDescriptions.Keys.Created) : null,
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(PlanetDescriptions.Keys.Description) : null,
					Diameter = retriever?.Diameter ?? true ? localisationResourceManager.GetString(PlanetDescriptions.Keys.Diameter) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(PlanetDescriptions.Keys.Edited) : null,
					Gravity = retriever?.Gravity ?? true ? localisationResourceManager.GetString(PlanetDescriptions.Keys.Gravity) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(PlanetDescriptions.Keys.Id) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(PlanetDescriptions.Keys.Name) : null,
					OrbitalPeriod = retriever?.OrbitalPeriod ?? true ? localisationResourceManager.GetString(PlanetDescriptions.Keys.OrbitalPeriod) : null,
					Population = retriever?.Population ?? true ? localisationResourceManager.GetString(PlanetDescriptions.Keys.Population) : null,
					ResidentIds = retriever?.ResidentIds ?? true ? localisationResourceManager.GetString(PlanetDescriptions.Keys.ResidentIds) : null,
					RotationalPeriod = retriever?.RotationalPeriod ?? true ? localisationResourceManager.GetString(PlanetDescriptions.Keys.RotationalPeriod) : null,
					SurfaceWater = retriever?.SurfaceWater ?? true ? localisationResourceManager.GetString(PlanetDescriptions.Keys.SurfaceWater) : null,
					Terrains = retriever?.Terrains ?? true ? localisationResourceManager.GetString(PlanetDescriptions.Keys.Terrains) : null,
					Uris = retriever?.Uris ?? true ? localisationResourceManager.GetString(PlanetDescriptions.Keys.Uris) : null,
				};
	}
}
