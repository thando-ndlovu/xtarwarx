using Domain.Models;

using Localisation.Abstractions.Factions;

using System;
using System.Globalization;

namespace Localisation.Abstractions
{
	public interface IFactionLocalisations : IDisposable
	{
		IFaction<string?>? FactionTitles(CultureInfo? cultureInfo = null, IFaction<bool>? retriever = null);
		IFaction<string?>? FactionDescriptions(CultureInfo? cultureInfo = null, IFaction<bool>? retriever = null);
		IFaction.ISortKeys? FactionSortKeysTitles(CultureInfo? cultureInfo = null, IFaction.ISortKeys<bool>? retriever = null);
		IFaction.ISortKeys? FactionSortKeysDescriptions(CultureInfo? cultureInfo = null, IFaction.ISortKeys<bool>? retriever = null);
		IFactionSingleLocalisation? FactionSingle(CultureInfo? cultureInfo = null, IFactionSingleLocalisation<bool>? retriever = null);
		IFactionMultipleLocalisation? FactionMultiple(CultureInfo? cultureInfo = null, IFactionMultipleLocalisation<bool>? retriever = null);
		IFactionSearchLocalisation? FactionSearch(CultureInfo? cultureInfo = null, IFactionSearchLocalisationTyped<bool>? retriever = null);
		IFaction.ISearchContainables<string?>? FactionSearchContainablesTitles(CultureInfo? cultureInfo = null, IFaction.ISearchContainables<bool>? retriever = null);
		IFaction.ISearchContainables<string?>? FactionSearchContainablesDescriptions(CultureInfo? cultureInfo = null, IFaction.ISearchContainables<bool>? retriever = null);
	}
}
