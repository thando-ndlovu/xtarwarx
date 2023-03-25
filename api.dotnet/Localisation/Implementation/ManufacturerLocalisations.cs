using Domain.Models;

using Localisation.Abstractions;
using Localisation.Utils.Manufacturers;

using System.Globalization;

using Localisation.Abstractions.Manufacturers;

using ManufacturerUtils = Localisation.Utils.Manufacturers;

namespace Localisation.Implementation
{
	public class ManufacturerLocalisations : Base.BaseLocalisations, IManufacturerLocalisations
	{
		public IManufacturer<string?>? ManufacturerTitles(CultureInfo? cultureInfo = null, IManufacturer<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(ManufacturerUtils.ManufacturerTitles.ResourceName, localisationcultureinfo)?
				.GetManufacturerTitles(retriever);
		}
		public IManufacturer<string?>? ManufacturerDescriptions(CultureInfo? cultureInfo = null, IManufacturer<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(ManufacturerUtils.ManufacturerDescriptions.ResourceName, localisationcultureinfo)?
				.GetManufacturerDescriptions(retriever);
		}
		public IManufacturer.ISortKeys? ManufacturerSortKeysTitles(CultureInfo? cultureInfo = null, IManufacturer.ISortKeys<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(ManufacturerUtils.ManufacturerSortKeysTitles.ResourceName, localisationcultureinfo)?
				.GetManufacturerSortKeysTitles(retriever);
		}
		public IManufacturer.ISortKeys? ManufacturerSortKeysDescriptions(CultureInfo? cultureInfo = null, IManufacturer.ISortKeys<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(ManufacturerUtils.ManufacturerSortKeysDescriptions.ResourceName, localisationcultureinfo)?
				.GetManufacturerSortKeysDescriptions(retriever);
		}
		public IManufacturerSingleLocalisation? ManufacturerSingle(CultureInfo? cultureInfo = null, IManufacturerSingleLocalisation<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			IManufacturer<string?>? titles = ManufacturerTitles(cultureInfo, retriever);

			return GetResourceManager(ManufacturerUtils.ManufacturerSingle.ResourceName, localisationcultureinfo)?
				.GetManufacturerSingle(retriever, titles);
		}
		public IManufacturerMultipleLocalisation? ManufacturerMultiple(CultureInfo? cultureInfo = null, IManufacturerMultipleLocalisation<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(ManufacturerUtils.ManufacturerMultiple.ResourceName, localisationcultureinfo)?
				.GetManufacturerMultiple(retriever);
		}
		public IManufacturerSearchLocalisation? ManufacturerSearch(CultureInfo? cultureInfo = null, IManufacturerSearchLocalisationTyped<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(ManufacturerUtils.ManufacturerSearch.ResourceName, localisationcultureinfo)?
				.GetManufacturerSearch(retriever);
		}
		public IManufacturer.ISearchContainables<string?>? ManufacturerSearchContainablesTitles(CultureInfo? cultureInfo = null, IManufacturer.ISearchContainables<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(ManufacturerUtils.ManufacturerSearchContainablesTitles.ResourceName, localisationcultureinfo)?
				.GetManufacturerSearchContainablesTitles(retriever);
		}
		public IManufacturer.ISearchContainables<string?>? ManufacturerSearchContainablesDescriptions(CultureInfo? cultureInfo = null, IManufacturer.ISearchContainables<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(ManufacturerUtils.ManufacturerSearchContainablesDescriptions.ResourceName, localisationcultureinfo)?
				.GetManufacturerSearchContainablesDescriptions(retriever);
		}
	}
}
