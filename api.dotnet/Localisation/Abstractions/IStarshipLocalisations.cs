using Domain.Models;

using Localisation.Abstractions.Starships;

using System;
using System.Globalization;

namespace Localisation.Abstractions
{
	public interface IStarshipLocalisations : IDisposable
	{
		IStarship<string?>? StarshipTitles(CultureInfo? cultureInfo = null, IStarship<bool>? retriever = null);
		IStarship<string?>? StarshipDescriptions(CultureInfo? cultureInfo = null, IStarship<bool>? retriever = null);
		IStarship.ISortKeys? StarshipSortKeysTitles(CultureInfo? cultureInfo = null, IStarship.ISortKeys<bool>? retriever = null);
		IStarship.ISortKeys? StarshipSortKeysDescriptions(CultureInfo? cultureInfo = null, IStarship.ISortKeys<bool>? retriever = null);
		IStarshipSingleLocalisation? StarshipSingle(CultureInfo? cultureInfo = null, IStarshipSingleLocalisation<bool>? retriever = null);
		IStarshipMultipleLocalisation? StarshipMultiple(CultureInfo? cultureInfo = null, IStarshipMultipleLocalisation<bool>? retriever = null);
		IStarshipSearchLocalisation? StarshipSearch(CultureInfo? cultureInfo = null, IStarshipSearchLocalisationTyped<bool>? retriever = null);
		IStarship.ISearchContainables<string?>? StarshipSearchContainablesTitles(CultureInfo? cultureInfo = null, IStarship.ISearchContainables<bool>? retriever = null);
		IStarship.ISearchContainables<string?>? StarshipSearchContainablesDescriptions(CultureInfo? cultureInfo = null, IStarship.ISearchContainables<bool>? retriever = null);
	}
}
