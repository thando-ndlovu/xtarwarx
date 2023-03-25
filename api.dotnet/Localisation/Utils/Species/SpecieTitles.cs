using Domain.Models;

namespace Localisation.Utils.Species
{
	public class SpecieTitles 
	{
		public const string ResourceName = "Species.SpecieTitles";

		public static readonly ISpecie<string> Keys = new ISpecie.Default<string>(string.Empty)
		{
			AverageHeight = "SpecieTitles_AverageHeight",
			AverageLifespan = "SpecieTitles_AverageLifespan",
			CharacterIds = "SpecieTitles_CharacterIds",
			Classification = "SpecieTitles_Classification",
			Description = "SpecieTitles_Description",
			Designation = "SpecieTitles_Designation",
			EyeColors = "SpecieTitles_EyeColors",
			HairColors = "SpecieTitles_HairColors",
			HomeworldId = "SpecieTitles_HomeworldId",
			Id = "SpecieTitles_Id",
			Language = "SpecieTitles_Language",
			Name = "SpecieTitles_Name",
			SkinColors = "SpecieTitles_SkinColors",
			Uris = "SpecieTitles_Uris",
			Created = "SpecieTitles_Created",
			Edited = "SpecieTitles_Edited",
		};
	}

	public static class SpecieTitlesExtensions
	{
		public static ISpecie<string?>? GetSpecieTitles(this LocalisationResourceManager? localisationResourceManager, ISpecie<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new ISpecie.Default<string?>(null)
				{
					AverageHeight = retriever?.AverageHeight ?? true ? localisationResourceManager.GetString(SpecieTitles.Keys.AverageHeight) : null,
					AverageLifespan = retriever?.AverageLifespan ?? true ? localisationResourceManager.GetString(SpecieTitles.Keys.AverageLifespan) : null,
					CharacterIds = retriever?.CharacterIds ?? true ? localisationResourceManager.GetString(SpecieTitles.Keys.CharacterIds) : null,
					Classification = retriever?.Classification ?? true ? localisationResourceManager.GetString(SpecieTitles.Keys.Classification) : null,
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(SpecieTitles.Keys.Created) : null,
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(SpecieTitles.Keys.Description) : null,
					Designation = retriever?.Designation ?? true ? localisationResourceManager.GetString(SpecieTitles.Keys.Designation) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(SpecieTitles.Keys.Edited) : null,
					EyeColors = retriever?.EyeColors ?? true ? localisationResourceManager.GetString(SpecieTitles.Keys.EyeColors) : null,
					HairColors = retriever?.HairColors ?? true ? localisationResourceManager.GetString(SpecieTitles.Keys.HairColors) : null,
					HomeworldId = retriever?.HomeworldId ?? true ? localisationResourceManager.GetString(SpecieTitles.Keys.HomeworldId) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(SpecieTitles.Keys.Id) : null,
					Language = retriever?.Language ?? true ? localisationResourceManager.GetString(SpecieTitles.Keys.Language) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(SpecieTitles.Keys.Name) : null,
					SkinColors = retriever?.SkinColors ?? true ? localisationResourceManager.GetString(SpecieTitles.Keys.SkinColors) : null,
					Uris = retriever?.Uris ?? true ? localisationResourceManager.GetString(SpecieTitles.Keys.Uris) : null,
				};
	}
}
