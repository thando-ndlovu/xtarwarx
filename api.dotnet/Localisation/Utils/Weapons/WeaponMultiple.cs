using Localisation.Abstractions.Weapons;

namespace Localisation.Utils.Weapons
{
	public class WeaponMultiple 
	{
		public const string ResourceName = "Weapons.WeaponMultiple";
		public static readonly IWeaponMultipleLocalisation<string> Keys = new IWeaponMultipleLocalisation.Default<string>(string.Empty)
		{
			WeaponsEmptyText = "WeaponMultiple_WeaponsEmptyText",
			WeaponsTitle = "WeaponMultiple_WeaponsTitle",
			WeaponsSearchbarPlaceholder = "WeaponMultiple_WeaponsSearchbarPlaceholder", 
		};
	}

	public static class WeaponMultipleExtensions
	{
		public static IWeaponMultipleLocalisation? GetWeaponMultiple(this LocalisationResourceManager? localisationResourceManager, IWeaponMultipleLocalisation<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IWeaponMultipleLocalisation.Default
				{
					WeaponsEmptyText = retriever?.WeaponsEmptyText ?? true ? localisationResourceManager.GetString(WeaponMultiple.Keys.WeaponsEmptyText) : null,
					WeaponsTitle = retriever?.WeaponsTitle ?? true ? localisationResourceManager.GetString(WeaponMultiple.Keys.WeaponsTitle) : null,
					WeaponsSearchbarPlaceholder = retriever?.WeaponsSearchbarPlaceholder ?? true ? localisationResourceManager.GetString(WeaponMultiple.Keys.WeaponsSearchbarPlaceholder) : null,
				};
	}
}
