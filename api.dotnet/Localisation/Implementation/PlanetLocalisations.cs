using Domain.Models;

using Localisation.Abstractions;
using Localisation.Utils.Planets;

using System.Globalization;

using Localisation.Abstractions.Planets;

using PlanetUtils = Localisation.Utils.Planets;

namespace Localisation.Implementation
{
	public class PlanetLocalisations : Base.BaseLocalisations, IPlanetLocalisations
	{
		public IPlanet<string?>? PlanetTitles(CultureInfo? cultureInfo = null, IPlanet<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(PlanetUtils.PlanetTitles.ResourceName, localisationcultureinfo)?
				.GetPlanetTitles(retriever);
		}
		public IPlanet<string?>? PlanetDescriptions(CultureInfo? cultureInfo = null, IPlanet<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(PlanetUtils.PlanetDescriptions.ResourceName, localisationcultureinfo)?
				.GetPlanetDescriptions(retriever);
		}
		public IPlanet.ISortKeys? PlanetSortKeysTitles(CultureInfo? cultureInfo = null, IPlanet.ISortKeys<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(PlanetUtils.PlanetSortKeysTitles.ResourceName, localisationcultureinfo)?
				.GetPlanetSortKeysTitles(retriever);
		}
		public IPlanet.ISortKeys? PlanetSortKeysDescriptions(CultureInfo? cultureInfo = null, IPlanet.ISortKeys<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(PlanetUtils.PlanetSortKeysDescriptions.ResourceName, localisationcultureinfo)?
				.GetPlanetSortKeysDescriptions(retriever);
		}
		public IPlanetSingleLocalisation? PlanetSingle(CultureInfo? cultureInfo = null, IPlanetSingleLocalisation<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			IPlanet<string?>? titles = PlanetTitles(cultureInfo, retriever);

			return GetResourceManager(PlanetUtils.PlanetSingle.ResourceName, localisationcultureinfo)?
				.GetPlanetSingle(retriever, titles);
		}
		public IPlanetMultipleLocalisation? PlanetMultiple(CultureInfo? cultureInfo = null, IPlanetMultipleLocalisation<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(PlanetUtils.PlanetMultiple.ResourceName, localisationcultureinfo)?
				.GetPlanetMultiple(retriever);
		}
		public IPlanetSearchLocalisation? PlanetSearch(CultureInfo? cultureInfo = null, IPlanetSearchLocalisationTyped<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(PlanetUtils.PlanetSearch.ResourceName, localisationcultureinfo)?
				.GetPlanetSearch(retriever);
		}
		public IPlanet.ISearchContainables<string?>? PlanetSearchContainablesTitles(CultureInfo? cultureInfo = null, IPlanet.ISearchContainables<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(PlanetUtils.PlanetSearchContainablesTitles.ResourceName, localisationcultureinfo)?
				.GetPlanetSearchContainablesTitles(retriever);
		}
		public IPlanet.ISearchContainables<string?>? PlanetSearchContainablesDescriptions(CultureInfo? cultureInfo = null, IPlanet.ISearchContainables<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(PlanetUtils.PlanetSearchContainablesDescriptions.ResourceName, localisationcultureinfo)?
				.GetPlanetSearchContainablesDescriptions(retriever);
		}
	}
}
