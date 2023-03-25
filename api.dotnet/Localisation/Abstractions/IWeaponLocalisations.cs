using Domain.Models;

using Localisation.Abstractions.Weapons;

using System;
using System.Globalization;

namespace Localisation.Abstractions
{
	public interface IWeaponLocalisations : IDisposable
	{
		IWeapon<string?>? WeaponTitles(CultureInfo? cultureInfo = null, IWeapon<bool>? retriever = null);
		IWeapon<string?>? WeaponDescriptions(CultureInfo? cultureInfo = null, IWeapon<bool>? retriever = null);
		IWeapon.ISortKeys? WeaponSortKeysTitles(CultureInfo? cultureInfo = null, IWeapon.ISortKeys<bool>? retriever = null);
		IWeapon.ISortKeys? WeaponSortKeysDescriptions(CultureInfo? cultureInfo = null, IWeapon.ISortKeys<bool>? retriever = null);
		IWeaponSingleLocalisation? WeaponSingle(CultureInfo? cultureInfo = null, IWeaponSingleLocalisation<bool>? retriever = null);
		IWeaponMultipleLocalisation? WeaponMultiple(CultureInfo? cultureInfo = null, IWeaponMultipleLocalisation<bool>? retriever = null);
		IWeaponSearchLocalisation? WeaponSearch(CultureInfo? cultureInfo = null, IWeaponSearchLocalisationTyped<bool>? retriever = null);
		IWeapon.ISearchContainables<string?>? WeaponSearchContainablesTitles(CultureInfo? cultureInfo = null, IWeapon.ISearchContainables<bool>? retriever = null);
		IWeapon.ISearchContainables<string?>? WeaponSearchContainablesDescriptions(CultureInfo? cultureInfo = null, IWeapon.ISearchContainables<bool>? retriever = null);
	}
}
