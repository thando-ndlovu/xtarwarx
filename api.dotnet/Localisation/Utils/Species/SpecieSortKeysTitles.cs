using Domain.Models;

namespace Localisation.Utils.Species
{
	public class SpecieSortKeysTitles
	{
		public const string ResourceName = "Species.SpecieSortKeysTitles";

		public static readonly ISpecie.ISortKeys<string> Keys = new ISpecie.ISortKeys.Default<string>(string.Empty)
		{
			AverageHeight = "SpecieSortKeysTitles_AverageHeight",
			AverageLifespan = "SpecieSortKeysTitles_AverageLifespan",
			Designation = "SpecieSortKeysTitles_Designation",
			CharacterCount = "SpecieSortKeysTitles_CharacterCount",
			Classification = "SpecieSortKeysTitles_Classification",
			Created = "SpecieSortKeysTitles_Created",
			Edited = "SpecieSortKeysTitles_Edited",
			EyeColorsCount = "SpecieSortKeysTitles_EyeColorsCount",
			HairColorsCount = "SpecieSortKeysTitles_HairColorsCount",
			Id = "SpecieSortKeysTitles_Id",
			Language = "SpecieSortKeysTitles_Language",
			Name = "SpecieSortKeysTitles_Name",
			SkinColorsCount = "SpecieSortKeysTitles_SkinColorsCount",
		};
	}

	public static class SpecieSortKeysTitlesExtensions
	{
		public static ISpecie.ISortKeys? GetSpecieSortKeysTitles(this LocalisationResourceManager? localisationResourceManager, ISpecie.ISortKeys<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new ISpecie.ISortKeys.Default
				{
					AverageHeight = retriever?.AverageHeight ?? true ? localisationResourceManager.GetString(SpecieSortKeysTitles.Keys.AverageHeight) : null,
					AverageLifespan = retriever?.AverageLifespan ?? true ? localisationResourceManager.GetString(SpecieSortKeysTitles.Keys.AverageLifespan) : null,
					Designation = retriever?.Designation ?? true ? localisationResourceManager.GetString(SpecieSortKeysTitles.Keys.Designation) : null,
					CharacterCount = retriever?.CharacterCount ?? true ? localisationResourceManager.GetString(SpecieSortKeysTitles.Keys.CharacterCount) : null,
					Classification = retriever?.Classification ?? true ? localisationResourceManager.GetString(SpecieSortKeysTitles.Keys.Classification) : null,
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(SpecieSortKeysTitles.Keys.Created) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(SpecieSortKeysTitles.Keys.Edited) : null,
					EyeColorsCount = retriever?.EyeColorsCount ?? true ? localisationResourceManager.GetString(SpecieSortKeysTitles.Keys.EyeColorsCount) : null,
					HairColorsCount = retriever?.HairColorsCount ?? true ? localisationResourceManager.GetString(SpecieSortKeysTitles.Keys.HairColorsCount) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(SpecieSortKeysTitles.Keys.Id) : null,
					Language = retriever?.Language ?? true ? localisationResourceManager.GetString(SpecieSortKeysTitles.Keys.Language) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(SpecieSortKeysTitles.Keys.Name) : null,
					SkinColorsCount = retriever?.SkinColorsCount ?? true ? localisationResourceManager.GetString(SpecieSortKeysTitles.Keys.SkinColorsCount) : null,
				};
	}
}
