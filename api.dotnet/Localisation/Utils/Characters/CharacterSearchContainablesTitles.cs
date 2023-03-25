using Domain.Models;

namespace Localisation.Utils.Characters
{
	public class CharacterSearchContainablesTitles
	{
		public const string ResourceName = "Characters.CharacterSearchContainablesTitles";

		public static readonly ICharacter.ISearchContainables<string> Keys = new ICharacter.ISearchContainables.Default<string>(string.Empty)
		{
			Description = "CharacterSearchContainablesTitles_Description",
			Name = "CharacterSearchContainablesTitles_Name",
		};
	}

	public static class CharacterSearchContainablesTitlesExtensions
	{
		public static ICharacter.ISearchContainables<string?>? GetCharacterSearchContainablesTitles(this LocalisationResourceManager? localisationResourceManager, ICharacter.ISearchContainables<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new ICharacter.ISearchContainables.Default<string?>(null)
				{
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(CharacterSearchContainablesTitles.Keys.Description) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(CharacterSearchContainablesTitles.Keys.Name) : null,
				};
	}
}
