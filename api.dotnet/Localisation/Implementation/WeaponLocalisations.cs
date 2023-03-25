using Domain.Models;

using Localisation.Abstractions;
using Localisation.Utils.Weapons;

using System.Globalization;

using Localisation.Abstractions.Weapons;

using WeaponUtils = Localisation.Utils.Weapons;

namespace Localisation.Implementation
{
	public class WeaponLocalisations : Base.BaseLocalisations, IWeaponLocalisations
	{
		public IWeapon<string?>? WeaponTitles(CultureInfo? cultureInfo = null, IWeapon<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(WeaponUtils.WeaponTitles.ResourceName, localisationcultureinfo)?
				.GetWeaponTitles(retriever);
		}
		public IWeapon<string?>? WeaponDescriptions(CultureInfo? cultureInfo = null, IWeapon<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(WeaponUtils.WeaponDescriptions.ResourceName, localisationcultureinfo)?
				.GetWeaponDescriptions(retriever);
		}
		public IWeapon.ISortKeys? WeaponSortKeysTitles(CultureInfo? cultureInfo = null, IWeapon.ISortKeys<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(WeaponUtils.WeaponSortKeysTitles.ResourceName, localisationcultureinfo)?
				.GetWeaponSortKeysTitles(retriever);
		}
		public IWeapon.ISortKeys? WeaponSortKeysDescriptions(CultureInfo? cultureInfo = null, IWeapon.ISortKeys<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(WeaponUtils.WeaponSortKeysDescriptions.ResourceName, localisationcultureinfo)?
				.GetWeaponSortKeysDescriptions(retriever);
		}
		public IWeaponSingleLocalisation? WeaponSingle(CultureInfo? cultureInfo = null, IWeaponSingleLocalisation<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			IWeapon<string?>? titles = WeaponTitles(cultureInfo, retriever);

			return GetResourceManager(WeaponUtils.WeaponSingle.ResourceName, localisationcultureinfo)?
				.GetWeaponSingle(retriever, titles);
		}
		public IWeaponMultipleLocalisation? WeaponMultiple(CultureInfo? cultureInfo = null, IWeaponMultipleLocalisation<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(WeaponUtils.WeaponMultiple.ResourceName, localisationcultureinfo)?
				.GetWeaponMultiple(retriever);
		}
		public IWeaponSearchLocalisation? WeaponSearch(CultureInfo? cultureInfo = null, IWeaponSearchLocalisationTyped<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(WeaponUtils.WeaponSearch.ResourceName, localisationcultureinfo)?
				.GetWeaponSearch(retriever);
		}
		public IWeapon.ISearchContainables<string?>? WeaponSearchContainablesTitles(CultureInfo? cultureInfo = null, IWeapon.ISearchContainables<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(WeaponUtils.WeaponSearchContainablesTitles.ResourceName, localisationcultureinfo)?
				.GetWeaponSearchContainablesTitles(retriever);
		}
		public IWeapon.ISearchContainables<string?>? WeaponSearchContainablesDescriptions(CultureInfo? cultureInfo = null, IWeapon.ISearchContainables<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(WeaponUtils.WeaponSearchContainablesDescriptions.ResourceName, localisationcultureinfo)?
				.GetWeaponSearchContainablesDescriptions(retriever);
		}
	}
}
