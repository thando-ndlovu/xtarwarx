using Domain.Models;

namespace Localisation.Utils.Characters
{
	public class CharacterSortKeysTitles
	{
		public const string ResourceName = "Characters.CharacterSortKeysTitles";

		public static readonly ICharacter.ISortKeys<string> Keys = new ICharacter.ISortKeys.Default<string>(string.Empty)
		{
			BirthYear = "CharacterSortKeysTitles_BirthYear",
			Created = "CharacterSortKeysTitles_Created",
			Edited = "CharacterSortKeysTitles_Edited",
			EyeColorsCount = "CharacterSortKeysTitles_EyeColorsCount",
			HairColorsCount = "CharacterSortKeysTitles_HairColorsCount",
			Height = "CharacterSortKeysTitles_Height",
			Id = "CharacterSortKeysTitles_Id",
			Mass = "CharacterSortKeysTitles_Mass",
			Name = "CharacterSortKeysTitles_Name",
			Sex = "CharacterSortKeysTitles_Sex",
			SkinColorsCount = "CharacterSortKeysTitles_SkinColorsCount",
		};
	}

	public static class CharacterSortKeysTitlesExtensions
	{
		public static ICharacter.ISortKeys? GetCharacterSortKeysTitles(this LocalisationResourceManager? localisationResourceManager, ICharacter.ISortKeys<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new ICharacter.ISortKeys.Default
				{
					BirthYear = retriever?.BirthYear ?? true ? localisationResourceManager.GetString(CharacterSortKeysTitles.Keys.BirthYear) : null,
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(CharacterSortKeysTitles.Keys.Created) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(CharacterSortKeysTitles.Keys.Edited) : null,
					EyeColorsCount = retriever?.EyeColorsCount ?? true ? localisationResourceManager.GetString(CharacterSortKeysTitles.Keys.EyeColorsCount) : null,
					HairColorsCount = retriever?.HairColorsCount ?? true ? localisationResourceManager.GetString(CharacterSortKeysTitles.Keys.HairColorsCount) : null,
					Height = retriever?.Height ?? true ? localisationResourceManager.GetString(CharacterSortKeysTitles.Keys.Height) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(CharacterSortKeysTitles.Keys.Id) : null,
					Mass = retriever?.Mass ?? true ? localisationResourceManager.GetString(CharacterSortKeysTitles.Keys.Mass) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(CharacterSortKeysTitles.Keys.Name) : null,
					Sex = retriever?.Sex ?? true ? localisationResourceManager.GetString(CharacterSortKeysTitles.Keys.Sex) : null,
					SkinColorsCount = retriever?.SkinColorsCount ?? true ? localisationResourceManager.GetString(CharacterSortKeysTitles.Keys.SkinColorsCount) : null,
				};
	}
}
