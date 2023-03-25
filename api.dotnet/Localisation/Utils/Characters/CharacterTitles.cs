using Domain.Models;

namespace Localisation.Utils.Characters
{
	public class CharacterTitles 
	{
		public const string ResourceName = "Characters.CharacterTitles";

		public static readonly ICharacter<string> Keys = new ICharacter.Default<string>(string.Empty)
		{
			BirthYear = "CharacterTitles_BirthYear",
			Description = "CharacterTitles_Description",
			EyeColors = "CharacterTitles_EyeColors",
			HairColors = "CharacterTitles_HairColors",
			Height = "CharacterTitles_Height",
			HomeworldId = "CharacterTitles_HomeworldId",
			Id = "CharacterTitles_Id",
			Mass = "CharacterTitles_Mass",
			Name = "CharacterTitles_Name",
			Sex = "CharacterTitles_Sex",
			SkinColors = "CharacterTitles_SkinColors",
			Uris = "CharacterTitles_Uris",
			Created = "CharacterTitles_Created",
			Edited = "CharacterTitles_Edited",
		};
	}

	public static class CharacterTitlesExtensions
	{
		public static ICharacter<string?>? GetCharacterTitles(this LocalisationResourceManager? localisationResourceManager, ICharacter<bool>? retriever = null) 
			=> localisationResourceManager == null
				? null
				: new ICharacter.Default<string?>(null)
				{
					BirthYear = retriever?.BirthYear ?? true ? localisationResourceManager.GetString(CharacterTitles.Keys.BirthYear) : null,
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(CharacterTitles.Keys.Created) : null,
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(CharacterTitles.Keys.Description) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(CharacterTitles.Keys.Edited) : null,
					EyeColors = retriever?.EyeColors ?? true ? localisationResourceManager.GetString(CharacterTitles.Keys.EyeColors) : null,
					HairColors = retriever?.HairColors ?? true ? localisationResourceManager.GetString(CharacterTitles.Keys.HairColors) : null,
					Height = retriever?.Height ?? true ? localisationResourceManager.GetString(CharacterTitles.Keys.Height) : null,
					HomeworldId = retriever?.HomeworldId ?? true ? localisationResourceManager.GetString(CharacterTitles.Keys.HomeworldId) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(CharacterTitles.Keys.Id) : null,
					Mass = retriever?.Mass ?? true ? localisationResourceManager.GetString(CharacterTitles.Keys.Mass) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(CharacterTitles.Keys.Name) : null,
					Sex = retriever?.Sex ?? true ? localisationResourceManager.GetString(CharacterTitles.Keys.Sex) : null,
					SkinColors = retriever?.SkinColors ?? true ? localisationResourceManager.GetString(CharacterTitles.Keys.SkinColors) : null,
					Uris = retriever?.Uris ?? true ? localisationResourceManager.GetString(CharacterTitles.Keys.Uris) : null,
				};
	}
}
