using Domain.Models;

namespace Localisation.Utils.Starships
{
	public class StarshipSearchContainablesTitles
	{
		public const string ResourceName = "Starships.StarshipSearchContainablesTitles";

		public static readonly IStarship.ISearchContainables<string> Keys = new IStarship.ISearchContainables.Default<string>(string.Empty)
		{
			Description = "StarshipSearchContainablesTitles_Description",
			Model = "StarshipSearchContainablesTitles_Model",
			Name = "StarshipSearchContainablesTitles_Name",
			StarshipClass = "StarshipSearchContainablesTitles_StarshipClass",
			StarshipClassFlags = "StarshipSearchContainablesTitles_StarshipClassFlags",
		};
	}

	public static class StarshipSearchContainablesTitlesExtensions
	{
		public static IStarship.ISearchContainables<string?>? GetStarshipSearchContainablesTitles(this LocalisationResourceManager? localisationResourceManager, IStarship.ISearchContainables<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IStarship.ISearchContainables.Default<string?>(null)
				{
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(StarshipSearchContainablesTitles.Keys.Description) : null,
					Model = retriever?.Model ?? true ? localisationResourceManager.GetString(StarshipSearchContainablesTitles.Keys.Model) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(StarshipSearchContainablesTitles.Keys.Name) : null,
					StarshipClass = retriever?.StarshipClass ?? true ? localisationResourceManager.GetString(StarshipSearchContainablesTitles.Keys.StarshipClass) : null,
					StarshipClassFlags = retriever?.StarshipClassFlags ?? true ? localisationResourceManager.GetString(StarshipSearchContainablesTitles.Keys.StarshipClassFlags) : null,
				};
	}
}
