using Domain.Models;

namespace Localisation.Utils.Factions
{
	public class FactionSortKeysDescriptions
	{
		public const string ResourceName = "Factions.FactionSortKeysDescriptions";

		public static readonly IFaction.ISortKeys<string> Keys = new IFaction.ISortKeys.Default<string>(string.Empty)
		{
			AlliedCharacterCount  = "FactionSortKeysDescriptions_AlliedCharacterCount",
			AlliedFactionCount  = "FactionSortKeysDescriptions_AlliedFactionCount",
			Created  = "FactionSortKeysDescriptions_Created",
			Edited  = "FactionSortKeysDescriptions_Edited",
			Id  = "FactionSortKeysDescriptions_Id",
			LeaderCount  = "FactionSortKeysDescriptions_LeaderCount",
			MemberCharacterCount  = "FactionSortKeysDescriptions_MemberCharacterCount",
			MemberFactionCount  = "FactionSortKeysDescriptions_MemberFactionCount",
			Name  = "FactionSortKeysDescriptions_Name",
			OrganizationTypes  = "FactionSortKeysDescriptions_OrganizationTypes",
		};
	}

	public static class FactionSortKeysDescriptionsExtensions
	{
		public static IFaction.ISortKeys? GetFactionSortKeysDescriptions(this LocalisationResourceManager? localisationResourceManager, IFaction.ISortKeys<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IFaction.ISortKeys.Default
				{
					AlliedCharacterCount = retriever?.AlliedCharacterCount ?? true ? localisationResourceManager.GetString(FactionSortKeysDescriptions.Keys.AlliedCharacterCount) : null,
					AlliedFactionCount = retriever?.AlliedFactionCount ?? true ? localisationResourceManager.GetString(FactionSortKeysDescriptions.Keys.AlliedFactionCount) : null,
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(FactionSortKeysDescriptions.Keys.Created) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(FactionSortKeysDescriptions.Keys.Edited) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(FactionSortKeysDescriptions.Keys.Id) : null,
					LeaderCount = retriever?.LeaderCount ?? true ? localisationResourceManager.GetString(FactionSortKeysDescriptions.Keys.LeaderCount) : null,
					MemberCharacterCount = retriever?.MemberCharacterCount ?? true ? localisationResourceManager.GetString(FactionSortKeysDescriptions.Keys.MemberCharacterCount) : null,
					MemberFactionCount = retriever?.MemberFactionCount ?? true ? localisationResourceManager.GetString(FactionSortKeysDescriptions.Keys.MemberFactionCount) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(FactionSortKeysDescriptions.Keys.Name) : null,
					OrganizationTypes = retriever?.OrganizationTypes ?? true ? localisationResourceManager.GetString(FactionSortKeysDescriptions.Keys.OrganizationTypes) : null,
				};
	}
}
