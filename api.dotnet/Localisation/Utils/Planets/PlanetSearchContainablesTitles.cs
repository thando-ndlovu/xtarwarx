using Domain.Models;

namespace Localisation.Utils.Planets
{
	public class PlanetSearchContainablesTitles
	{
		public const string ResourceName = "Planets.PlanetSearchContainablesTitles";

		public static readonly IPlanet.ISearchContainables<string> Keys = new IPlanet.ISearchContainables.Default<string>(string.Empty)
		{
			Description = "PlanetSearchContainablesTitles_Description",
			Name = "PlanetSearchContainablesTitles_Name",
		};
	}

	public static class PlanetSearchContainablesTitlesExtensions
	{
		public static IPlanet.ISearchContainables<string?>? GetPlanetSearchContainablesTitles(this LocalisationResourceManager? localisationResourceManager, IPlanet.ISearchContainables<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IPlanet.ISearchContainables.Default<string?>(null)
				{
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(PlanetSearchContainablesTitles.Keys.Description) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(PlanetSearchContainablesTitles.Keys.Name) : null,
				};
	}
}
