using Domain.Models;

using Localisation.Abstractions.Factions;

namespace Localisation.Utils.Factions
{
	public class FactionSingle 
	{
		public const string ResourceName = "Factions.FactionSingle";

		public static readonly IFactionSingleLocalisation<string> Keys = new IFactionSingleLocalisation.Default<string>(string.Empty)
		{
			AlliedCharactersTitle = "FactionSingle_AlliedCharactersTitle",
			AlliedCharactersEmptyText = "FactionSingle_AlliedCharactersEmptyText",
			AlliedFactionsTitle = "FactionSingle_AlliedFactionsTitle",
			AlliedFactionsEmptyText = "FactionSingle_AlliedFactionsEmptyText",
			ImagesTitle = "FactionSingle_ImagesTitle",
			ImagesEmptyText = "FactionSingle_ImagesEmptyText",
			LeadersTitle = "FactionSingle_LeadersTitle",
			LeadersEmptyText = "FactionSingle_LeadersEmptyText",
			MemberCharactersTitle = "FactionSingle_MemberCharactersTitle",
			MemberCharactersEmptyText = "FactionSingle_MemberCharactersEmptyText",
			MemberFactionsTitle = "FactionSingle_MemberFactionsTitle",
			MemberFactionsEmptyText = "FactionSingle_MemberFactionsEmptyText",
		};
	}

	public static class FactionSingleExtensions
	{
		public static IFactionSingleLocalisation? GetFactionSingle(this LocalisationResourceManager? localisationResourceManager, IFactionSingleLocalisation<bool>? retriever = null, IFaction<string?>? factionTitles = null)
		{
			if (localisationResourceManager == null)
				return factionTitles as IFactionSingleLocalisation;

			IFactionSingleLocalisation factionsingle = IFactionSingleLocalisation.FromFaction(factionTitles) ?? new IFactionSingleLocalisation.Default { };

			factionsingle.AlliedCharactersTitle = retriever?.AlliedCharactersTitle ?? true ? localisationResourceManager.GetString(FactionSingle.Keys.AlliedCharactersTitle) : null;
			factionsingle.AlliedCharactersEmptyText = retriever?.AlliedCharactersEmptyText ?? true ? localisationResourceManager.GetString(FactionSingle.Keys.AlliedCharactersEmptyText) : null;
			factionsingle.AlliedFactionsTitle = retriever?.AlliedFactionsTitle ?? true ? localisationResourceManager.GetString(FactionSingle.Keys.AlliedFactionsTitle) : null;
			factionsingle.AlliedFactionsEmptyText = retriever?.AlliedFactionsEmptyText ?? true ? localisationResourceManager.GetString(FactionSingle.Keys.AlliedFactionsEmptyText) : null;
			factionsingle.ImagesTitle = retriever?.ImagesTitle ?? true ? localisationResourceManager.GetString(FactionSingle.Keys.ImagesTitle) : null;
			factionsingle.ImagesEmptyText = retriever?.ImagesEmptyText ?? true ? localisationResourceManager.GetString(FactionSingle.Keys.ImagesEmptyText) : null;
			factionsingle.LeadersTitle = retriever?.LeadersTitle ?? true ? localisationResourceManager.GetString(FactionSingle.Keys.LeadersTitle) : null;
			factionsingle.LeadersEmptyText = retriever?.LeadersEmptyText ?? true ? localisationResourceManager.GetString(FactionSingle.Keys.LeadersEmptyText) : null;
			factionsingle.MemberCharactersTitle = retriever?.MemberCharactersTitle ?? true ? localisationResourceManager.GetString(FactionSingle.Keys.MemberCharactersTitle) : null;
			factionsingle.MemberCharactersEmptyText = retriever?.MemberCharactersEmptyText ?? true ? localisationResourceManager.GetString(FactionSingle.Keys.MemberCharactersEmptyText) : null;
			factionsingle.MemberFactionsTitle = retriever?.MemberFactionsTitle ?? true ? localisationResourceManager.GetString(FactionSingle.Keys.MemberFactionsTitle) : null;
			factionsingle.MemberFactionsEmptyText = retriever?.MemberFactionsEmptyText ?? true ? localisationResourceManager.GetString(FactionSingle.Keys.MemberFactionsEmptyText) : null;

			return factionsingle;

		}
		public static IFactionSingleLocalisation? GetFactionSingle(this LocalisationResourceManager? localisationResourceManager, IFactionSingleLocalisation<bool>? retriever = null, LocalisationResourceManager? factionTitlesLocalisationResourceManager = null)
			=> localisationResourceManager.GetFactionSingle(
				retriever: retriever,
				factionTitles: factionTitlesLocalisationResourceManager.GetFactionTitles());
	}
}
