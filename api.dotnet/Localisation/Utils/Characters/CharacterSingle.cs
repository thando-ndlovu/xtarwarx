using Domain.Models;

using Localisation.Abstractions.Characters;

namespace Localisation.Utils.Characters
{
	public class CharacterSingle 
	{
		public const string ResourceName = "Characters.CharacterSingle";

		public static readonly ICharacterSingleLocalisation<string> Keys = new ICharacterSingleLocalisation.Default<string>(string.Empty)
		{
			HomeworldTitle = "CharacterSingle_HomeworldTitle",
			HomeworldAbsentText = "CharacterSingle_HomeworldAbsentText",
			ImagesTitle = "CharacterSingle_ImagesTitle",
			ImagesEmptyText = "CharacterSingle_ImagesEmptyText",
		};
	}

	public static class CharacterSingleExtensions
	{
		public static ICharacterSingleLocalisation? GetCharacterSingle(this LocalisationResourceManager? localisationResourceManager, ICharacterSingleLocalisation<bool>? retriever = null, ICharacter<string?>? characterTitles = null) 
		{
			if (localisationResourceManager == null)
				return characterTitles as ICharacterSingleLocalisation;

			ICharacterSingleLocalisation charactersingle = ICharacterSingleLocalisation.FromCharacter(characterTitles) ?? new ICharacterSingleLocalisation.Default { };

			charactersingle.HomeworldTitle = retriever?.HomeworldTitle ?? true ? localisationResourceManager.GetString(CharacterSingle.Keys.HomeworldTitle) : null;
			charactersingle.HomeworldAbsentText = retriever?.HomeworldAbsentText ?? true ? localisationResourceManager.GetString(CharacterSingle.Keys.HomeworldAbsentText) : null;
			charactersingle.ImagesTitle = retriever?.ImagesTitle ?? true ? localisationResourceManager.GetString(CharacterSingle.Keys.ImagesTitle) : null;
			charactersingle.ImagesEmptyText = retriever?.ImagesEmptyText ?? true ? localisationResourceManager.GetString(CharacterSingle.Keys.ImagesEmptyText) : null;

			return charactersingle;

		}
		public static ICharacterSingleLocalisation? GetCharacterSingle(this LocalisationResourceManager? localisationResourceManager, ICharacterSingleLocalisation<bool>? retriever = null, LocalisationResourceManager? characterTitlesLocalisationResourceManager = null)
			=> localisationResourceManager.GetCharacterSingle(
				retriever: retriever,
				characterTitles: characterTitlesLocalisationResourceManager.GetCharacterTitles());
	}
}
