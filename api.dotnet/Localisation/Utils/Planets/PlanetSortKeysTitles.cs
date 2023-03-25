using Domain.Models;

namespace Localisation.Utils.Planets
{
	public class PlanetSortKeysTitles
	{
		public const string ResourceName = "Planets.PlanetSortKeysTitles";

		public static readonly IPlanet.ISortKeys<string> Keys = new IPlanet.ISortKeys.Default<string>(string.Empty)
		{
			ClimatesCount = "PlanetSortKeysTitles_ClimatesCount",
			Created = "PlanetSortKeysTitles_Created",
			Diameter = "PlanetSortKeysTitles_Diameter",
			Edited = "PlanetSortKeysTitles_Edited",
			Gravity = "PlanetSortKeysTitles_Gravity",
			Id = "PlanetSortKeysTitles_Id",
			Name = "PlanetSortKeysTitles_Name",
			OrbitalPeriod = "PlanetSortKeysTitles_OrbitalPeriod",
			Population = "PlanetSortKeysTitles_Population",
			ResidentsCount = "PlanetSortKeysTitles_ResidentsCount",
			RotationalPeriod = "PlanetSortKeysTitles_RotationalPeriod",
			SurfaceWater = "PlanetSortKeysTitles_SurfaceWater",
			TerrainsCount = "PlanetSortKeysTitles_TerrainsCount",
		};
	}

	public static class PlanetSortKeysTitlesExtensions
	{
		public static IPlanet.ISortKeys? GetPlanetSortKeysTitles(this LocalisationResourceManager? localisationResourceManager, IPlanet.ISortKeys<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IPlanet.ISortKeys.Default
				{
					ClimatesCount = retriever?.ClimatesCount ?? true ? localisationResourceManager.GetString(PlanetSortKeysTitles.Keys.ClimatesCount) : null,
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(PlanetSortKeysTitles.Keys.Created) : null,
					Diameter = retriever?.Diameter ?? true ? localisationResourceManager.GetString(PlanetSortKeysTitles.Keys.Diameter) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(PlanetSortKeysTitles.Keys.Edited) : null,
					Gravity = retriever?.Gravity ?? true ? localisationResourceManager.GetString(PlanetSortKeysTitles.Keys.Gravity) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(PlanetSortKeysTitles.Keys.Id) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(PlanetSortKeysTitles.Keys.Name) : null,
					OrbitalPeriod = retriever?.OrbitalPeriod ?? true ? localisationResourceManager.GetString(PlanetSortKeysTitles.Keys.OrbitalPeriod) : null,
					Population = retriever?.Population ?? true ? localisationResourceManager.GetString(PlanetSortKeysTitles.Keys.Population) : null,
					ResidentsCount = retriever?.ResidentsCount ?? true ? localisationResourceManager.GetString(PlanetSortKeysTitles.Keys.ResidentsCount) : null,
					RotationalPeriod = retriever?.RotationalPeriod ?? true ? localisationResourceManager.GetString(PlanetSortKeysTitles.Keys.RotationalPeriod) : null,
					SurfaceWater = retriever?.SurfaceWater ?? true ? localisationResourceManager.GetString(PlanetSortKeysTitles.Keys.SurfaceWater) : null,
					TerrainsCount = retriever?.TerrainsCount ?? true ? localisationResourceManager.GetString(PlanetSortKeysTitles.Keys.TerrainsCount) : null,
				};
	}
}
