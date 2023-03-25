using Domain.Models;

using Localisation.Abstractions.Species;

using System;
using System.Globalization;

namespace Localisation.Abstractions
{
	public interface ISpecieLocalisations : IDisposable
	{
		ISpecie<string?>? SpecieTitles(CultureInfo? cultureInfo = null, ISpecie<bool>? retriever = null);
		ISpecie<string?>? SpecieDescriptions(CultureInfo? cultureInfo = null, ISpecie<bool>? retriever = null);
		ISpecie.ISortKeys? SpecieSortKeysTitles(CultureInfo? cultureInfo = null, ISpecie.ISortKeys<bool>? retriever = null);
		ISpecie.ISortKeys? SpecieSortKeysDescriptions(CultureInfo? cultureInfo = null, ISpecie.ISortKeys<bool>? retriever = null);
		ISpecieSingleLocalisation? SpecieSingle(CultureInfo? cultureInfo = null, ISpecieSingleLocalisation<bool>? retriever = null);
		ISpecieMultipleLocalisation? SpecieMultiple(CultureInfo? cultureInfo = null, ISpecieMultipleLocalisation<bool>? retriever = null);
		ISpecieSearchLocalisation? SpecieSearch(CultureInfo? cultureInfo = null, ISpecieSearchLocalisationTyped<bool>? retriever = null);
		ISpecie.ISearchContainables<string?>? SpecieSearchContainablesTitles(CultureInfo? cultureInfo = null, ISpecie.ISearchContainables<bool>? retriever = null);
		ISpecie.ISearchContainables<string?>? SpecieSearchContainablesDescriptions(CultureInfo? cultureInfo = null, ISpecie.ISearchContainables<bool>? retriever = null);
	}
}
