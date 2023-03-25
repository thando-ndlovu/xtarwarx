using Domain.Models;

using Localisation.Abstractions.Planets;

using System;
using System.Globalization;

namespace Localisation.Abstractions
{
	public interface IPlanetLocalisations : IDisposable
	{
		IPlanet<string?>? PlanetTitles(CultureInfo? cultureInfo = null, IPlanet<bool>? retriever = null);
		IPlanet<string?>? PlanetDescriptions(CultureInfo? cultureInfo = null, IPlanet<bool>? retriever = null);
		IPlanet.ISortKeys? PlanetSortKeysTitles(CultureInfo? cultureInfo = null, IPlanet.ISortKeys<bool>? retriever = null);
		IPlanet.ISortKeys? PlanetSortKeysDescriptions(CultureInfo? cultureInfo = null, IPlanet.ISortKeys<bool>? retriever = null);
		IPlanetSingleLocalisation? PlanetSingle(CultureInfo? cultureInfo = null, IPlanetSingleLocalisation<bool>? retriever = null);
		IPlanetMultipleLocalisation? PlanetMultiple(CultureInfo? cultureInfo = null, IPlanetMultipleLocalisation<bool>? retriever = null);
		IPlanetSearchLocalisation? PlanetSearch(CultureInfo? cultureInfo = null, IPlanetSearchLocalisationTyped<bool>? retriever = null);
		IPlanet.ISearchContainables<string?>? PlanetSearchContainablesTitles(CultureInfo? cultureInfo = null, IPlanet.ISearchContainables<bool>? retriever = null);
		IPlanet.ISearchContainables<string?>? PlanetSearchContainablesDescriptions(CultureInfo? cultureInfo = null, IPlanet.ISearchContainables<bool>? retriever = null);
	}
}
