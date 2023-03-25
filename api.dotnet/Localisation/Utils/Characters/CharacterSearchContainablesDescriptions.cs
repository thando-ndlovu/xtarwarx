using Domain.Models;

namespace Localisation.Utils.Characters
{
	public class CharacterSearchContainablesDescriptions
	{
		public const string ResourceName = "Characters.CharacterSearchContainablesDescriptions";

		public static readonly ICharacter.ISearchContainables<string> Keys = new ICharacter.ISearchContainables.Default<string>(string.Empty)
		{
			Description = "CharacterSearchContainablesDescriptions_Description",
			Name = "CharacterSearchContainablesDescriptions_Name",
		};
	}

	public static class CharacterSearchContainablesDescriptionsExtensions
	{
		public static ICharacter.ISearchContainables<string?>? GetCharacterSearchContainablesDescriptions(this LocalisationResourceManager? localisationResourceManager, ICharacter.ISearchContainables<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new ICharacter.ISearchContainables.Default<string?>(null)
				{
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(CharacterSearchContainablesDescriptions.Keys.Description) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(CharacterSearchContainablesDescriptions.Keys.Name) : null,
				};
	}
}
