using Domain.Models;

namespace Localisation.Utils.Planets
{
	public class PlanetSearchContainablesDescriptions
	{
		public const string ResourceName = "Planets.PlanetSearchContainablesDescriptions";

		public static readonly IPlanet.ISearchContainables<string> Keys = new IPlanet.ISearchContainables.Default<string>(string.Empty)
		{
			Description = "PlanetSearchContainablesDescriptions_Description",
			Name = "PlanetSearchContainablesDescriptions_Name",
		};
	}

	public static class PlanetSearchContainablesDescriptionsExtensions
	{
		public static IPlanet.ISearchContainables<string?>? GetPlanetSearchContainablesDescriptions(this LocalisationResourceManager? localisationResourceManager, IPlanet.ISearchContainables<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IPlanet.ISearchContainables.Default<string?>(null)
				{
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(PlanetSearchContainablesDescriptions.Keys.Description) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(PlanetSearchContainablesDescriptions.Keys.Name) : null,
				};
	}
}
