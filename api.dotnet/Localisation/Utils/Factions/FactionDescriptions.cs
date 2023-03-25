using Domain.Models;

namespace Localisation.Utils.Factions
{
	public class FactionDescriptions
	{
		public const string ResourceName = "Factions.FactionDescriptions";

		public static readonly IFaction<string> Keys = new IFaction.Default<string>(string.Empty)
		{
			AlliedCharacterIds = "FactionDescriptions_AlliedCharacterIds",
			AlliedFactionIds = "FactionDescriptions_AlliedFactionIds",
			Created = "FactionDescriptions_Created",
			Description = "FactionDescriptions_Description",
			Edited = "FactionDescriptions_Edited",
			Id = "FactionDescriptions_Id",
			LeaderIds = "FactionDescriptions_LeaderIds",
			MemberCharacterIds = "FactionDescriptions_MemberCharacterIds",
			MemberFactionIds = "FactionDescriptions_MemberFactionIds",
			Name = "FactionDescriptions_Name",
			OrganizationTypes = "FactionDescriptions_OrganizationTypes",
			Uris = "FactionDescriptions_Uris",
		};
	}

	public static class FactionDescriptionsExtensions
	{
		public static IFaction<string?>? GetFactionDescriptions(this LocalisationResourceManager? localisationResourceManager, IFaction<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IFaction.Default<string?>(null)
				{
					AlliedCharacterIds = retriever?.AlliedCharacterIds ?? true ? localisationResourceManager.GetString(FactionDescriptions.Keys.AlliedCharacterIds) : null,
					AlliedFactionIds = retriever?.AlliedFactionIds ?? true ? localisationResourceManager.GetString(FactionDescriptions.Keys.AlliedFactionIds) : null,
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(FactionDescriptions.Keys.Created) : null,
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(FactionDescriptions.Keys.Description) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(FactionDescriptions.Keys.Edited) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(FactionDescriptions.Keys.Id) : null,
					LeaderIds = retriever?.LeaderIds ?? true ? localisationResourceManager.GetString(FactionDescriptions.Keys.LeaderIds) : null,
					MemberCharacterIds = retriever?.MemberCharacterIds ?? true ? localisationResourceManager.GetString(FactionDescriptions.Keys.MemberCharacterIds) : null,
					MemberFactionIds = retriever?.MemberFactionIds ?? true ? localisationResourceManager.GetString(FactionDescriptions.Keys.MemberFactionIds) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(FactionDescriptions.Keys.Name) : null,
					OrganizationTypes = retriever?.OrganizationTypes ?? true ? localisationResourceManager.GetString(FactionDescriptions.Keys.OrganizationTypes) : null,
					Uris = retriever?.Uris ?? true ? localisationResourceManager.GetString(FactionDescriptions.Keys.Uris) : null,
				};
	}
}
