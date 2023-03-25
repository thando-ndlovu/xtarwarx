using Domain.Models;

using Localisation.Abstractions;
using Localisation.Utils.Starships;

using System.Globalization;

using Localisation.Abstractions.Starships;

using StarshipUtils = Localisation.Utils.Starships;

namespace Localisation.Implementation
{
	public class StarshipLocalisations : Base.BaseLocalisations, IStarshipLocalisations
	{
		public IStarship<string?>? StarshipTitles(CultureInfo? cultureInfo = null, IStarship<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(StarshipUtils.StarshipTitles.ResourceName, localisationcultureinfo)?
				.GetStarshipTitles(retriever);
		}
		public IStarship<string?>? StarshipDescriptions(CultureInfo? cultureInfo = null, IStarship<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(StarshipUtils.StarshipDescriptions.ResourceName, localisationcultureinfo)?
				.GetStarshipDescriptions(retriever);
		}
		public IStarship.ISortKeys? StarshipSortKeysTitles(CultureInfo? cultureInfo = null, IStarship.ISortKeys<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(StarshipUtils.StarshipSortKeysTitles.ResourceName, localisationcultureinfo)?
				.GetStarshipSortKeysTitles(retriever);
		}
		public IStarship.ISortKeys? StarshipSortKeysDescriptions(CultureInfo? cultureInfo = null, IStarship.ISortKeys<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(StarshipUtils.StarshipSortKeysDescriptions.ResourceName, localisationcultureinfo)?
				.GetStarshipSortKeysDescriptions(retriever);
		}
		public IStarshipSingleLocalisation? StarshipSingle(CultureInfo? cultureInfo = null, IStarshipSingleLocalisation<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			IStarship<string?>? titles = StarshipTitles(cultureInfo, retriever);

			return GetResourceManager(StarshipUtils.StarshipSingle.ResourceName, localisationcultureinfo)?
				.GetStarshipSingle(retriever, titles);
		}
		public IStarshipMultipleLocalisation? StarshipMultiple(CultureInfo? cultureInfo = null, IStarshipMultipleLocalisation<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(StarshipUtils.StarshipMultiple.ResourceName, localisationcultureinfo)?
				.GetStarshipMultiple(retriever);
		}
		public IStarshipSearchLocalisation? StarshipSearch(CultureInfo? cultureInfo = null, IStarshipSearchLocalisationTyped<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(StarshipUtils.StarshipSearch.ResourceName, localisationcultureinfo)?
				.GetStarshipSearch(retriever);
		}
		public IStarship.ISearchContainables<string?>? StarshipSearchContainablesTitles(CultureInfo? cultureInfo = null, IStarship.ISearchContainables<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(StarshipUtils.StarshipSearchContainablesTitles.ResourceName, localisationcultureinfo)?
				.GetStarshipSearchContainablesTitles(retriever);
		}
		public IStarship.ISearchContainables<string?>? StarshipSearchContainablesDescriptions(CultureInfo? cultureInfo = null, IStarship.ISearchContainables<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(StarshipUtils.StarshipSearchContainablesDescriptions.ResourceName, localisationcultureinfo)?
				.GetStarshipSearchContainablesDescriptions(retriever);
		}
	}
}
