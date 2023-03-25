using Domain.Models;

namespace Localisation.Utils.Factions
{
	public class FactionSearchContainablesDescriptions
	{
		public const string ResourceName = "Factions.FactionSearchContainablesDescriptions";

		public static readonly IFaction.ISearchContainables<string> Keys = new IFaction.ISearchContainables.Default<string>(string.Empty)
		{
			Description = "FactionSearchContainablesDescriptions_Description",
			Name = "FactionSearchContainablesDescriptions_Name",
			OrganizationTypes = "FactionSearchContainablesDescriptions_OrganizationTypes",
		};
	}

	public static class FactionSearchContainablesDescriptionsExtensions
	{
		public static IFaction.ISearchContainables<string?>? GetFactionSearchContainablesDescriptions(this LocalisationResourceManager? localisationResourceManager, IFaction.ISearchContainables<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IFaction.ISearchContainables.Default<string?>(null)
				{
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(FactionSearchContainablesDescriptions.Keys.Description) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(FactionSearchContainablesDescriptions.Keys.Name) : null,
					OrganizationTypes = retriever?.OrganizationTypes ?? true ? localisationResourceManager.GetString(FactionSearchContainablesDescriptions.Keys.OrganizationTypes) : null,
				};
	}
}
