using Localisation.Abstractions.Planets;

namespace Localisation.Utils.Planets
{
	public class PlanetMultiple 
	{
		public const string ResourceName = "Planets.PlanetMultiple";

		public static readonly IPlanetMultipleLocalisation<string> Keys = new IPlanetMultipleLocalisation.Default<string>(string.Empty)
		{
			PlanetsEmptyText = "PlanetMultiple_PlanetsEmptyText",
			PlanetsTitle = "PlanetMultiple_PlanetsTitle",
			PlanetsSearchbarPlaceholder = "PlanetMultiple_PlanetsSearchbarPlaceholder",
		};
	}

	public static class PlanetMultipleExtensions
	{
		public static IPlanetMultipleLocalisation? GetPlanetMultiple(this LocalisationResourceManager? localisationResourceManager, IPlanetMultipleLocalisation<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IPlanetMultipleLocalisation.Default
				{
					PlanetsEmptyText = retriever?.PlanetsEmptyText ?? true ? localisationResourceManager.GetString(PlanetMultiple.Keys.PlanetsEmptyText) : null,
					PlanetsTitle = retriever?.PlanetsTitle ?? true ? localisationResourceManager.GetString(PlanetMultiple.Keys.PlanetsTitle) : null,
					PlanetsSearchbarPlaceholder = retriever?.PlanetsSearchbarPlaceholder ?? true ? localisationResourceManager.GetString(PlanetMultiple.Keys.PlanetsSearchbarPlaceholder) : null,
				};
	}
}
