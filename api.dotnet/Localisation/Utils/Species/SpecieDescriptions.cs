using Domain.Models;

namespace Localisation.Utils.Species
{
	public class SpecieDescriptions
	{
		public const string ResourceName = "Species.SpecieDescriptions";

		public static readonly ISpecie<string> Keys = new ISpecie.Default<string>(string.Empty)
		{
			AverageHeight = "SpecieDescriptions_AverageHeight",
			AverageLifespan = "SpecieDescriptions_AverageLifespan",
			CharacterIds = "SpecieDescriptions_CharacterIds",
			Classification = "SpecieDescriptions_Classification",
			Description = "SpecieDescriptions_Description",
			Designation = "SpecieDescriptions_Designation",
			EyeColors = "SpecieDescriptions_EyeColors",
			HairColors = "SpecieDescriptions_HairColors",
			HomeworldId = "SpecieDescriptions_HomeworldId",
			Id = "SpecieDescriptions_Id",
			Language = "SpecieDescriptions_Language",
			Name = "SpecieDescriptions_Name",
			SkinColors = "SpecieDescriptions_SkinColors",
			Uris = "SpecieDescriptions_Uris",
			Created = "SpecieDescriptions_Created",
			Edited = "SpecieDescriptions_Edited",
		};
	}

	public static class SpecieDescriptionsExtensions
	{
		public static ISpecie<string?>? GetSpecieDescriptions(this LocalisationResourceManager? localisationResourceManager, ISpecie<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new ISpecie.Default<string?>(null)
				{
					AverageHeight = retriever?.AverageHeight ?? true ? localisationResourceManager.GetString(SpecieDescriptions.Keys.AverageHeight) : null,
					AverageLifespan = retriever?.AverageLifespan ?? true ? localisationResourceManager.GetString(SpecieDescriptions.Keys.AverageLifespan) : null,
					CharacterIds = retriever?.CharacterIds ?? true ? localisationResourceManager.GetString(SpecieDescriptions.Keys.CharacterIds) : null,
					Classification = retriever?.Classification ?? true ? localisationResourceManager.GetString(SpecieDescriptions.Keys.Classification) : null,
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(SpecieDescriptions.Keys.Created) : null,
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(SpecieDescriptions.Keys.Description) : null,
					Designation = retriever?.Designation ?? true ? localisationResourceManager.GetString(SpecieDescriptions.Keys.Designation) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(SpecieDescriptions.Keys.Edited) : null,
					EyeColors = retriever?.EyeColors ?? true ? localisationResourceManager.GetString(SpecieDescriptions.Keys.EyeColors) : null,
					HairColors = retriever?.HairColors ?? true ? localisationResourceManager.GetString(SpecieDescriptions.Keys.HairColors) : null,
					HomeworldId = retriever?.HomeworldId ?? true ? localisationResourceManager.GetString(SpecieDescriptions.Keys.HomeworldId) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(SpecieDescriptions.Keys.Id) : null,
					Language = retriever?.Language ?? true ? localisationResourceManager.GetString(SpecieDescriptions.Keys.Language) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(SpecieDescriptions.Keys.Name) : null,
					SkinColors = retriever?.SkinColors ?? true ? localisationResourceManager.GetString(SpecieDescriptions.Keys.SkinColors) : null,
					Uris = retriever?.Uris ?? true ? localisationResourceManager.GetString(SpecieDescriptions.Keys.Uris) : null,
				};
	}
}
