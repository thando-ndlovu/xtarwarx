using Domain.Models;

using Localisation.Abstractions;
using Localisation.Abstractions.Characters;
using Localisation.Utils.Characters;

using System.Globalization;

using CharacterUtils = Localisation.Utils.Characters;

namespace Localisation.Implementation
{
	public class CharacterLocalisations : Base.BaseLocalisations, ICharacterLocalisations
	{
		public ICharacter<string?>? CharacterTitles(CultureInfo? cultureInfo = null, ICharacter<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(CharacterUtils.CharacterTitles.ResourceName, localisationcultureinfo)?
				.GetCharacterTitles(retriever);
		}
		public ICharacter<string?>? CharacterDescriptions(CultureInfo? cultureInfo = null, ICharacter<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(CharacterUtils.CharacterDescriptions.ResourceName, localisationcultureinfo)?
				.GetCharacterDescriptions(retriever);
		}
		public ICharacter.ISortKeys? CharacterSortKeysTitles(CultureInfo? cultureInfo = null, ICharacter.ISortKeys<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(CharacterUtils.CharacterSortKeysTitles.ResourceName, localisationcultureinfo)?
				.GetCharacterSortKeysTitles(retriever);
		}
		public ICharacter.ISortKeys? CharacterSortKeysDescriptions(CultureInfo? cultureInfo = null, ICharacter.ISortKeys<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(CharacterUtils.CharacterSortKeysDescriptions.ResourceName, localisationcultureinfo)?
				.GetCharacterSortKeysDescriptions(retriever);
		}
		public ICharacterSingleLocalisation? CharacterSingle(CultureInfo? cultureInfo = null, ICharacterSingleLocalisation<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			ICharacter<string?>? titles = CharacterTitles(cultureInfo, retriever);

			return GetResourceManager(CharacterUtils.CharacterSingle.ResourceName, localisationcultureinfo)?
				.GetCharacterSingle(retriever, titles);
		}
		public ICharacterMultipleLocalisation? CharacterMultiple(CultureInfo? cultureInfo = null, ICharacterMultipleLocalisation<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(CharacterUtils.CharacterMultiple.ResourceName, localisationcultureinfo)?
				.GetCharacterMultiple(retriever);
		}
		public ICharacterSearchLocalisation? CharacterSearch(CultureInfo? cultureInfo = null, ICharacterSearchLocalisationTyped<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(CharacterUtils.CharacterSearch.ResourceName, localisationcultureinfo)?
				.GetCharacterSearch(retriever);
		}
		public ICharacter.ISearchContainables<string?>? CharacterSearchContainablesTitles(CultureInfo? cultureInfo = null, ICharacter.ISearchContainables<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(CharacterUtils.CharacterSearchContainablesTitles.ResourceName, localisationcultureinfo)?
				.GetCharacterSearchContainablesTitles(retriever);
		}
		public ICharacter.ISearchContainables<string?>? CharacterSearchContainablesDescriptions(CultureInfo? cultureInfo = null, ICharacter.ISearchContainables<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(CharacterUtils.CharacterSearchContainablesDescriptions.ResourceName, localisationcultureinfo)?
				.GetCharacterSearchContainablesDescriptions(retriever);
		}
	}
}
