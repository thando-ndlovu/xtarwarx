using Domain.Models;

using Localisation.Abstractions;
using Localisation.Utils.Species;

using System.Globalization;

using Localisation.Abstractions.Species;

using SpecieUtils = Localisation.Utils.Species;

namespace Localisation.Implementation
{
	public class SpecieLocalisations : Base.BaseLocalisations, ISpecieLocalisations
	{
		public ISpecie<string?>? SpecieTitles(CultureInfo? cultureInfo = null, ISpecie<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(SpecieUtils.SpecieTitles.ResourceName, localisationcultureinfo)?
				.GetSpecieTitles(retriever);
		}
		public ISpecie<string?>? SpecieDescriptions(CultureInfo? cultureInfo = null, ISpecie<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(SpecieUtils.SpecieDescriptions.ResourceName, localisationcultureinfo)?
				.GetSpecieDescriptions(retriever);
		}
		public ISpecie.ISortKeys? SpecieSortKeysTitles(CultureInfo? cultureInfo = null, ISpecie.ISortKeys<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(SpecieUtils.SpecieSortKeysTitles.ResourceName, localisationcultureinfo)?
				.GetSpecieSortKeysTitles(retriever);
		}
		public ISpecie.ISortKeys? SpecieSortKeysDescriptions(CultureInfo? cultureInfo = null, ISpecie.ISortKeys<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(SpecieUtils.SpecieSortKeysDescriptions.ResourceName, localisationcultureinfo)?
				.GetSpecieSortKeysDescriptions(retriever);
		}
		public ISpecieSingleLocalisation? SpecieSingle(CultureInfo? cultureInfo = null, ISpecieSingleLocalisation<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			ISpecie<string?>? titles = SpecieTitles(cultureInfo, retriever);

			return GetResourceManager(SpecieUtils.SpecieSingle.ResourceName, localisationcultureinfo)?
				.GetSpecieSingle(retriever, titles);
		}
		public ISpecieMultipleLocalisation? SpecieMultiple(CultureInfo? cultureInfo = null, ISpecieMultipleLocalisation<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(SpecieUtils.SpecieMultiple.ResourceName, localisationcultureinfo)?
				.GetSpecieMultiple(retriever);
		}
		public ISpecieSearchLocalisation? SpecieSearch(CultureInfo? cultureInfo = null, ISpecieSearchLocalisationTyped<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(SpecieUtils.SpecieSearch.ResourceName, localisationcultureinfo)?
				.GetSpecieSearch(retriever);
		}
		public ISpecie.ISearchContainables<string?>? SpecieSearchContainablesTitles(CultureInfo? cultureInfo = null, ISpecie.ISearchContainables<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(SpecieUtils.SpecieSearchContainablesTitles.ResourceName, localisationcultureinfo)?
				.GetSpecieSearchContainablesTitles(retriever);
		}
		public ISpecie.ISearchContainables<string?>? SpecieSearchContainablesDescriptions(CultureInfo? cultureInfo = null, ISpecie.ISearchContainables<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(SpecieUtils.SpecieSearchContainablesDescriptions.ResourceName, localisationcultureinfo)?
				.GetSpecieSearchContainablesDescriptions(retriever);
		}
	}
}
