using Domain.Models;

using Localisation.Abstractions.Characters;

using System;
using System.Globalization;

namespace Localisation.Abstractions
{
	public interface ICharacterLocalisations : IDisposable
	{
		ICharacter<string?>? CharacterTitles(CultureInfo? cultureInfo = null, ICharacter<bool>? retriever = null);
		ICharacter<string?>? CharacterDescriptions(CultureInfo? cultureInfo = null, ICharacter<bool>? retriever = null);
		ICharacter.ISortKeys? CharacterSortKeysTitles(CultureInfo? cultureInfo = null, ICharacter.ISortKeys<bool>? retriever = null);
		ICharacter.ISortKeys? CharacterSortKeysDescriptions(CultureInfo? cultureInfo = null, ICharacter.ISortKeys<bool>? retriever = null);
		ICharacterSingleLocalisation? CharacterSingle(CultureInfo? cultureInfo = null, ICharacterSingleLocalisation<bool>? retriever = null);
		ICharacterMultipleLocalisation? CharacterMultiple(CultureInfo? cultureInfo = null, ICharacterMultipleLocalisation<bool>? retriever = null);
		ICharacterSearchLocalisation? CharacterSearch(CultureInfo? cultureInfo = null, ICharacterSearchLocalisationTyped<bool>? retriever = null);
		ICharacter.ISearchContainables<string?>? CharacterSearchContainablesTitles(CultureInfo? cultureInfo = null, ICharacter.ISearchContainables<bool>? retriever = null);
		ICharacter.ISearchContainables<string?>? CharacterSearchContainablesDescriptions(CultureInfo? cultureInfo = null, ICharacter.ISearchContainables<bool>? retriever = null);
	}
}
