using Domain.Models;

namespace Localisation.Utils.Starships
{
	public class StarshipSearchContainablesDescriptions
	{
		public const string ResourceName = "Starships.StarshipSearchContainablesDescriptions";

		public static readonly IStarship.ISearchContainables<string> Keys = new IStarship.ISearchContainables.Default<string>(string.Empty)
		{
			Description = "StarshipSearchContainablesDescriptions_Description",
			Model = "StarshipSearchContainablesDescriptions_Model",
			Name = "StarshipSearchContainablesDescriptions_Name",
			StarshipClass = "StarshipSearchContainablesDescriptions_StarshipClass",
			StarshipClassFlags = "StarshipSearchContainablesDescriptions_StarshipClassFlags",
		};
	}

	public static class StarshipSearchContainablesDescriptionsExtensions
	{
		public static IStarship.ISearchContainables<string?>? GetStarshipSearchContainablesDescriptions(this LocalisationResourceManager? localisationResourceManager, IStarship.ISearchContainables<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IStarship.ISearchContainables.Default<string?>(null)
				{
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(StarshipSearchContainablesDescriptions.Keys.Description) : null,
					Model = retriever?.Model ?? true ? localisationResourceManager.GetString(StarshipSearchContainablesDescriptions.Keys.Model) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(StarshipSearchContainablesDescriptions.Keys.Name) : null,
					StarshipClass = retriever?.StarshipClass ?? true ? localisationResourceManager.GetString(StarshipSearchContainablesDescriptions.Keys.StarshipClass) : null,
					StarshipClassFlags = retriever?.StarshipClassFlags ?? true ? localisationResourceManager.GetString(StarshipSearchContainablesDescriptions.Keys.StarshipClassFlags) : null,
				};
	}
}
