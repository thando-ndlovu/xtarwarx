using Domain.Models;

namespace Localisation.Utils.Factions
{
	public class FactionSearchContainablesTitles
	{
		public const string ResourceName = "Factions.FactionSearchContainablesTitles";

		public static readonly IFaction.ISearchContainables<string> Keys = new IFaction.ISearchContainables.Default<string>(string.Empty)
		{
			Description = "FactionSearchContainablesTitles_Description",
			Name = "FactionSearchContainablesTitles_Name",
		};
	}

	public static class FactionSearchContainablesTitlesExtensions
	{
		public static IFaction.ISearchContainables<string?>? GetFactionSearchContainablesTitles(this LocalisationResourceManager? localisationResourceManager, IFaction.ISearchContainables<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IFaction.ISearchContainables.Default<string?>(null)
				{
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(FactionSearchContainablesTitles.Keys.Description) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(FactionSearchContainablesTitles.Keys.Name) : null,
				};
	}
}
