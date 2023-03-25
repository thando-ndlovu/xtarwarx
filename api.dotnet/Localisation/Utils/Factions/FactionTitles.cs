using Domain.Models;

namespace Localisation.Utils.Factions
{
	public class FactionTitles 
	{
		public const string ResourceName = "Factions.FactionTitles";

		public static readonly IFaction<string> Keys = new IFaction.Default<string>(string.Empty)
		{
			AlliedCharacterIds = "FactionTitles_AlliedCharacterIds",
			AlliedFactionIds = "FactionTitles_AlliedFactionIds",
			Created = "FactionTitles_Created",
			Description = "FactionTitles_Description",
			Edited = "FactionTitles_Edited",
			Id = "FactionTitles_Id",
			LeaderIds = "FactionTitles_LeaderIds",
			MemberCharacterIds = "FactionTitles_MemberCharacterIds",
			MemberFactionIds = "FactionTitles_MemberFactionIds",
			Name = "FactionTitles_Name",
			OrganizationTypes = "FactionTitles_OrganizationTypes",
			Uris = "FactionTitles_Uris",
		};
	}

	public static class FactionTitlesExtensions
	{
		public static IFaction<string?>? GetFactionTitles(this LocalisationResourceManager? localisationResourceManager, IFaction<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IFaction.Default<string?>(null)
				{
					AlliedCharacterIds = retriever?.AlliedCharacterIds ?? true ? localisationResourceManager.GetString(FactionTitles.Keys.AlliedCharacterIds) : null,
					AlliedFactionIds = retriever?.AlliedFactionIds ?? true ? localisationResourceManager.GetString(FactionTitles.Keys.AlliedFactionIds) : null,
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(FactionTitles.Keys.Created) : null,
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(FactionTitles.Keys.Description) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(FactionTitles.Keys.Edited) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(FactionTitles.Keys.Id) : null,
					LeaderIds = retriever?.LeaderIds ?? true ? localisationResourceManager.GetString(FactionTitles.Keys.LeaderIds) : null,
					MemberCharacterIds = retriever?.MemberCharacterIds ?? true ? localisationResourceManager.GetString(FactionTitles.Keys.MemberCharacterIds) : null,
					MemberFactionIds = retriever?.MemberFactionIds ?? true ? localisationResourceManager.GetString(FactionTitles.Keys.MemberFactionIds) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(FactionTitles.Keys.Name) : null,
					OrganizationTypes = retriever?.OrganizationTypes ?? true ? localisationResourceManager.GetString(FactionTitles.Keys.OrganizationTypes) : null,
					Uris = retriever?.Uris ?? true ? localisationResourceManager.GetString(FactionTitles.Keys.Uris) : null,
				};
	}
}
