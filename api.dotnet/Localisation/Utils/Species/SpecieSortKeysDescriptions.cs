using Domain.Models;

namespace Localisation.Utils.Species
{
	public class SpecieSortKeysDescriptions
	{
		public const string ResourceName = "Species.SpecieSortKeysDescriptions";

		public static readonly ISpecie.ISortKeys<string> Keys = new ISpecie.ISortKeys.Default<string>(string.Empty)
		{
			AverageHeight = "SpecieSortKeysDescriptions_AverageHeight",
			AverageLifespan = "SpecieSortKeysDescriptions_AverageLifespan",
			Designation = "SpecieSortKeysDescriptions_Designation",
			CharacterCount = "SpecieSortKeysDescriptions_CharacterCount",
			Classification = "SpecieSortKeysDescriptions_Classification",
			Created = "SpecieSortKeysDescriptions_Created",
			Edited = "SpecieSortKeysDescriptions_Edited",
			EyeColorsCount = "SpecieSortKeysDescriptions_EyeColorsCount",
			HairColorsCount = "SpecieSortKeysDescriptions_HairColorsCount",
			Id = "SpecieSortKeysDescriptions_Id",
			Language = "SpecieSortKeysDescriptions_Language",
			Name = "SpecieSortKeysDescriptions_Name",
			SkinColorsCount = "SpecieSortKeysDescriptions_SkinColorsCount",
		};
	}

	public static class SpecieSortKeysDescriptionsExtensions
	{
		public static ISpecie.ISortKeys? GetSpecieSortKeysDescriptions(this LocalisationResourceManager? localisationResourceManager, ISpecie.ISortKeys<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new ISpecie.ISortKeys.Default
				{
					AverageHeight = retriever?.AverageHeight ?? true ? localisationResourceManager.GetString(SpecieSortKeysDescriptions.Keys.AverageHeight) : null,
					AverageLifespan = retriever?.AverageLifespan ?? true ? localisationResourceManager.GetString(SpecieSortKeysDescriptions.Keys.AverageLifespan) : null,
					Designation = retriever?.Designation ?? true ? localisationResourceManager.GetString(SpecieSortKeysDescriptions.Keys.Designation) : null,
					CharacterCount = retriever?.CharacterCount ?? true ? localisationResourceManager.GetString(SpecieSortKeysDescriptions.Keys.CharacterCount) : null,
					Classification = retriever?.Classification ?? true ? localisationResourceManager.GetString(SpecieSortKeysDescriptions.Keys.Classification) : null,
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(SpecieSortKeysDescriptions.Keys.Created) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(SpecieSortKeysDescriptions.Keys.Edited) : null,
					EyeColorsCount = retriever?.EyeColorsCount ?? true ? localisationResourceManager.GetString(SpecieSortKeysDescriptions.Keys.EyeColorsCount) : null,
					HairColorsCount = retriever?.HairColorsCount ?? true ? localisationResourceManager.GetString(SpecieSortKeysDescriptions.Keys.HairColorsCount) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(SpecieSortKeysDescriptions.Keys.Id) : null,
					Language = retriever?.Language ?? true ? localisationResourceManager.GetString(SpecieSortKeysDescriptions.Keys.Language) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(SpecieSortKeysDescriptions.Keys.Name) : null,
					SkinColorsCount = retriever?.SkinColorsCount ?? true ? localisationResourceManager.GetString(SpecieSortKeysDescriptions.Keys.SkinColorsCount) : null,
				};
	}
}
