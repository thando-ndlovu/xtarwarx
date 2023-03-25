using Domain.Models;

namespace Localisation.Utils.Factions
{
	public class FactionSortKeysTitles
	{
		public const string ResourceName = "Factions.FactionSortKeysTitles";

		public static readonly IFaction.ISortKeys<string> Keys = new IFaction.ISortKeys.Default<string>(string.Empty)
		{
			AlliedCharacterCount  = "FactionSortKeysTitles_AlliedCharacterCount",
			AlliedFactionCount  = "FactionSortKeysTitles_AlliedFactionCount",
			Created  = "FactionSortKeysTitles_Created",
			Edited  = "FactionSortKeysTitles_Edited",
			Id  = "FactionSortKeysTitles_Id",
			LeaderCount  = "FactionSortKeysTitles_LeaderCount",
			MemberCharacterCount  = "FactionSortKeysTitles_MemberCharacterCount",
			MemberFactionCount  = "FactionSortKeysTitles_MemberFactionCount",
			Name  = "FactionSortKeysTitles_Name",
			OrganizationTypes  = "FactionSortKeysTitles_OrganizationTypes",
		};
	}

	public static class FactionSortKeysTitlesExtensions
	{
		public static IFaction.ISortKeys? GetFactionSortKeysTitles(this LocalisationResourceManager? localisationResourceManager, IFaction.ISortKeys<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IFaction.ISortKeys.Default
				{
					AlliedCharacterCount = retriever?.AlliedCharacterCount ?? true ? localisationResourceManager.GetString(FactionSortKeysTitles.Keys.AlliedCharacterCount) : null,
					AlliedFactionCount = retriever?.AlliedFactionCount ?? true ? localisationResourceManager.GetString(FactionSortKeysTitles.Keys.AlliedFactionCount) : null,
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(FactionSortKeysTitles.Keys.Created) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(FactionSortKeysTitles.Keys.Edited) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(FactionSortKeysTitles.Keys.Id) : null,
					LeaderCount = retriever?.LeaderCount ?? true ? localisationResourceManager.GetString(FactionSortKeysTitles.Keys.LeaderCount) : null,
					MemberCharacterCount = retriever?.MemberCharacterCount ?? true ? localisationResourceManager.GetString(FactionSortKeysTitles.Keys.MemberCharacterCount) : null,
					MemberFactionCount = retriever?.MemberFactionCount ?? true ? localisationResourceManager.GetString(FactionSortKeysTitles.Keys.MemberFactionCount) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(FactionSortKeysTitles.Keys.Name) : null,
					OrganizationTypes = retriever?.OrganizationTypes ?? true ? localisationResourceManager.GetString(FactionSortKeysTitles.Keys.OrganizationTypes) : null,
				};
	}
}
