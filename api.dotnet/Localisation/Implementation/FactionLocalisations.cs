using Domain.Models;

using Localisation.Abstractions;
using Localisation.Utils.Factions;

using System.Globalization;

using Localisation.Abstractions.Factions;

using FactionUtils = Localisation.Utils.Factions;

namespace Localisation.Implementation
{
	public class FactionLocalisations : Base.BaseLocalisations, IFactionLocalisations
	{
		public IFaction<string?>? FactionTitles(CultureInfo? cultureInfo = null, IFaction<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(FactionUtils.FactionTitles.ResourceName, localisationcultureinfo)?
				.GetFactionTitles(retriever);
		}
		public IFaction<string?>? FactionDescriptions(CultureInfo? cultureInfo = null, IFaction<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(FactionUtils.FactionDescriptions.ResourceName, localisationcultureinfo)?
				.GetFactionDescriptions(retriever);
		}
		public IFaction.ISortKeys? FactionSortKeysTitles(CultureInfo? cultureInfo = null, IFaction.ISortKeys<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(FactionUtils.FactionSortKeysTitles.ResourceName, localisationcultureinfo)?
				.GetFactionSortKeysTitles(retriever);
		}
		public IFaction.ISortKeys? FactionSortKeysDescriptions(CultureInfo? cultureInfo = null, IFaction.ISortKeys<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(FactionUtils.FactionSortKeysDescriptions.ResourceName, localisationcultureinfo)?
				.GetFactionSortKeysDescriptions(retriever);
		}
		public IFactionSingleLocalisation? FactionSingle(CultureInfo? cultureInfo = null, IFactionSingleLocalisation<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			IFaction<string?>? titles = FactionTitles(cultureInfo, retriever);

			return GetResourceManager(FactionUtils.FactionSingle.ResourceName, localisationcultureinfo)?
				.GetFactionSingle(retriever, titles);
		}
		public IFactionMultipleLocalisation? FactionMultiple(CultureInfo? cultureInfo = null, IFactionMultipleLocalisation<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(FactionUtils.FactionMultiple.ResourceName, localisationcultureinfo)?
				.GetFactionMultiple(retriever);
		}
		public IFactionSearchLocalisation? FactionSearch(CultureInfo? cultureInfo = null, IFactionSearchLocalisationTyped<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(FactionUtils.FactionSearch.ResourceName, localisationcultureinfo)?
				.GetFactionSearch(retriever);
		}
		public IFaction.ISearchContainables<string?>? FactionSearchContainablesTitles(CultureInfo? cultureInfo = null, IFaction.ISearchContainables<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(FactionUtils.FactionSearchContainablesTitles.ResourceName, localisationcultureinfo)?
				.GetFactionSearchContainablesTitles(retriever);
		}
		public IFaction.ISearchContainables<string?>? FactionSearchContainablesDescriptions(CultureInfo? cultureInfo = null, IFaction.ISearchContainables<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(FactionUtils.FactionSearchContainablesDescriptions.ResourceName, localisationcultureinfo)?
				.GetFactionSearchContainablesDescriptions(retriever);
		}
	}
}
