using Localisation.Abstractions.Species;

namespace Localisation.Utils.Species
{
	public class SpecieMultiple 
	{
		public const string ResourceName = "Species.SpecieMultiple";

		public static readonly ISpecieMultipleLocalisation<string> Keys = new ISpecieMultipleLocalisation.Default<string>(string.Empty)
		{
			SpeciesEmptyText = "SpecieMultiple_SpeciesEmptyText",
			SpeciesTitle = "SpecieMultiple_SpeciesTitle",
			SpeciesSearchbarPlaceholder = "SpecieMultiple_SpeciesSearchbarPlaceholder",
		};
	}

	public static class SpecieMultipleExtensions
	{
		public static ISpecieMultipleLocalisation? GetSpecieMultiple(this LocalisationResourceManager? localisationResourceManager, ISpecieMultipleLocalisation<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new ISpecieMultipleLocalisation.Default
				{
					SpeciesEmptyText = retriever?.SpeciesEmptyText ?? true ? localisationResourceManager.GetString(SpecieMultiple.Keys.SpeciesEmptyText) : null,
					SpeciesTitle = retriever?.SpeciesTitle ?? true ? localisationResourceManager.GetString(SpecieMultiple.Keys.SpeciesTitle) : null,
					SpeciesSearchbarPlaceholder = retriever?.SpeciesSearchbarPlaceholder ?? true ? localisationResourceManager.GetString(SpecieMultiple.Keys.SpeciesSearchbarPlaceholder) : null,
				};
	}
}
