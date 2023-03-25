using Domain.Models;

namespace Localisation.Utils.Planets
{
	public class PlanetSortKeysDescriptions
	{
		public const string ResourceName = "Planets.PlanetSortKeysDescriptions";

		public static readonly IPlanet.ISortKeys<string> Keys = new IPlanet.ISortKeys.Default<string>(string.Empty)
		{
			ClimatesCount = "PlanetSortKeysDescriptions_ClimatesCount",
			Created = "PlanetSortKeysDescriptions_Created",
			Diameter = "PlanetSortKeysDescriptions_Diameter",
			Edited = "PlanetSortKeysDescriptions_Edited",
			Gravity = "PlanetSortKeysDescriptions_Gravity",
			Id = "PlanetSortKeysDescriptions_Id",
			Name = "PlanetSortKeysDescriptions_Name",
			OrbitalPeriod = "PlanetSortKeysDescriptions_OrbitalPeriod",
			Population = "PlanetSortKeysDescriptions_Population",
			ResidentsCount = "PlanetSortKeysDescriptions_ResidentsCount",
			RotationalPeriod = "PlanetSortKeysDescriptions_RotationalPeriod",
			SurfaceWater = "PlanetSortKeysDescriptions_SurfaceWater",
			TerrainsCount = "PlanetSortKeysDescriptions_TerrainsCount",
		};
	}

	public static class PlanetSortKeysDescriptionsExtensions
	{
		public static IPlanet.ISortKeys? GetPlanetSortKeysDescriptions(this LocalisationResourceManager? localisationResourceManager, IPlanet.ISortKeys<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IPlanet.ISortKeys.Default
				{
					ClimatesCount = retriever?.ClimatesCount ?? true ? localisationResourceManager.GetString(PlanetSortKeysDescriptions.Keys.ClimatesCount) : null,
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(PlanetSortKeysDescriptions.Keys.Created) : null,
					Diameter = retriever?.Diameter ?? true ? localisationResourceManager.GetString(PlanetSortKeysDescriptions.Keys.Diameter) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(PlanetSortKeysDescriptions.Keys.Edited) : null,
					Gravity = retriever?.Gravity ?? true ? localisationResourceManager.GetString(PlanetSortKeysDescriptions.Keys.Gravity) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(PlanetSortKeysDescriptions.Keys.Id) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(PlanetSortKeysDescriptions.Keys.Name) : null,
					OrbitalPeriod = retriever?.OrbitalPeriod ?? true ? localisationResourceManager.GetString(PlanetSortKeysDescriptions.Keys.OrbitalPeriod) : null,
					Population = retriever?.Population ?? true ? localisationResourceManager.GetString(PlanetSortKeysDescriptions.Keys.Population) : null,
					ResidentsCount = retriever?.ResidentsCount ?? true ? localisationResourceManager.GetString(PlanetSortKeysDescriptions.Keys.ResidentsCount) : null,
					RotationalPeriod = retriever?.RotationalPeriod ?? true ? localisationResourceManager.GetString(PlanetSortKeysDescriptions.Keys.RotationalPeriod) : null,
					SurfaceWater = retriever?.SurfaceWater ?? true ? localisationResourceManager.GetString(PlanetSortKeysDescriptions.Keys.SurfaceWater) : null,
					TerrainsCount = retriever?.TerrainsCount ?? true ? localisationResourceManager.GetString(PlanetSortKeysDescriptions.Keys.TerrainsCount) : null,
				};
	}
}
