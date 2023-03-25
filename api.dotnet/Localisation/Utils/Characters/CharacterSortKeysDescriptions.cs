using Domain.Models;

namespace Localisation.Utils.Characters
{
	public class CharacterSortKeysDescriptions
	{
		public const string ResourceName = "Characters.CharacterSortKeysDescriptions";

		public static readonly ICharacter.ISortKeys<string> Keys = new ICharacter.ISortKeys.Default<string>(string.Empty)
		{
			BirthYear = "CharacterSortKeysDescriptions_BirthYear",
			Created = "CharacterSortKeysDescriptions_Created",
			Edited = "CharacterSortKeysDescriptions_Edited",
			EyeColorsCount = "CharacterSortKeysDescriptions_EyeColorsCount",
			HairColorsCount = "CharacterSortKeysDescriptions_HairColorsCount",
			Height = "CharacterSortKeysDescriptions_Height",
			Id = "CharacterSortKeysDescriptions_Id",
			Mass = "CharacterSortKeysDescriptions_Mass",
			Name = "CharacterSortKeysDescriptions_Name",
			Sex = "CharacterSortKeysDescriptions_Sex",
			SkinColorsCount = "CharacterSortKeysDescriptions_SkinColorsCount",
		};
	}

	public static class CharacterSortKeysDescriptionsExtensions
	{
		public static ICharacter.ISortKeys? GetCharacterSortKeysDescriptions(this LocalisationResourceManager? localisationResourceManager, ICharacter.ISortKeys<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new ICharacter.ISortKeys.Default
				{
					BirthYear = retriever?.BirthYear ?? true ? localisationResourceManager.GetString(CharacterSortKeysDescriptions.Keys.BirthYear) : null,
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(CharacterSortKeysDescriptions.Keys.Created) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(CharacterSortKeysDescriptions.Keys.Edited) : null,
					EyeColorsCount = retriever?.EyeColorsCount ?? true ? localisationResourceManager.GetString(CharacterSortKeysDescriptions.Keys.EyeColorsCount) : null,
					HairColorsCount = retriever?.HairColorsCount ?? true ? localisationResourceManager.GetString(CharacterSortKeysDescriptions.Keys.HairColorsCount) : null,
					Height = retriever?.Height ?? true ? localisationResourceManager.GetString(CharacterSortKeysDescriptions.Keys.Height) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(CharacterSortKeysDescriptions.Keys.Id) : null,
					Mass = retriever?.Mass ?? true ? localisationResourceManager.GetString(CharacterSortKeysDescriptions.Keys.Mass) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(CharacterSortKeysDescriptions.Keys.Name) : null,
					Sex = retriever?.Sex ?? true ? localisationResourceManager.GetString(CharacterSortKeysDescriptions.Keys.Sex) : null,
					SkinColorsCount = retriever?.SkinColorsCount ?? true ? localisationResourceManager.GetString(CharacterSortKeysDescriptions.Keys.SkinColorsCount) : null,
				};
	}
}
