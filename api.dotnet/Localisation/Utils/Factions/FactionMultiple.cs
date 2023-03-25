using Localisation.Abstractions.Factions;

namespace Localisation.Utils.Factions
{
	public class FactionMultiple 
	{
		public const string ResourceName = "Factions.FactionMultiple";

		public static readonly IFactionMultipleLocalisation<string> Keys = new IFactionMultipleLocalisation.Default<string>(string.Empty)
		{
			FactionsEmptyText = "FactionMultiple_FactionsEmptyText",
			FactionsTitle = "FactionMultiple_FactionsTitle", 
			FactionsSearchbarPlaceholder = "FactionMultiple_FactionsSearchbarPlaceholder", 
		};
	}

	public static class FactionMultipleExtensions
	{
		public static IFactionMultipleLocalisation? GetFactionMultiple(this LocalisationResourceManager? localisationResourceManager, IFactionMultipleLocalisation<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IFactionMultipleLocalisation.Default
				{
					FactionsEmptyText = retriever?.FactionsEmptyText ?? true ? localisationResourceManager.GetString(FactionMultiple.Keys.FactionsEmptyText) : null,
					FactionsTitle = retriever?.FactionsTitle ?? true ? localisationResourceManager.GetString(FactionMultiple.Keys.FactionsTitle) : null,
					FactionsSearchbarPlaceholder = retriever?.FactionsSearchbarPlaceholder ?? true ? localisationResourceManager.GetString(FactionMultiple.Keys.FactionsSearchbarPlaceholder) : null,
				};
	}
}
