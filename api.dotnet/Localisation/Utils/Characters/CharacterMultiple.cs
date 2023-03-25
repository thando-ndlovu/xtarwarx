using Localisation.Abstractions.Characters;

namespace Localisation.Utils.Characters
{
	public class CharacterMultiple 
	{
		public const string ResourceName = "Characters.CharacterMultiple";

		public static readonly ICharacterMultipleLocalisation<string> Keys = new ICharacterMultipleLocalisation.Default<string>(string.Empty)
		{
			CharactersTitle = "CharacterMultiple_CharactersTitle",
			CharactersEmptyText = "CharacterMultiple_CharactersEmptyText",
			CharactersSearchbarPlaceholder = "CharacterMultiple_CharactersSearchbarPlaceholder",
		};
	}

	public static class CharacterMultipleExtensions
	{
		public static ICharacterMultipleLocalisation? GetCharacterMultiple(this LocalisationResourceManager? localisationResourceManager, ICharacterMultipleLocalisation<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new ICharacterMultipleLocalisation.Default
				{
					CharactersEmptyText = retriever?.CharactersEmptyText ?? true ? localisationResourceManager.GetString(CharacterMultiple.Keys.CharactersEmptyText) : null,
					CharactersTitle = retriever?.CharactersTitle ?? true ? localisationResourceManager.GetString(CharacterMultiple.Keys.CharactersTitle) : null,
					CharactersSearchbarPlaceholder = retriever?.CharactersSearchbarPlaceholder ?? true ? localisationResourceManager.GetString(CharacterMultiple.Keys.CharactersSearchbarPlaceholder) : null,
				};
	}
}
