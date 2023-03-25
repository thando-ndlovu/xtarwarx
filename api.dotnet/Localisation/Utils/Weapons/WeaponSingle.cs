using Domain.Models;

using Localisation.Abstractions.Weapons;

namespace Localisation.Utils.Weapons
{
	public class WeaponSingle 
	{
		public const string ResourceName = "Weapons.WeaponSingle";

		public static readonly IWeaponSingleLocalisation<string> Keys = new IWeaponSingleLocalisation.Default<string>(string.Empty)
		{
			ImagesTitle = "WeaponSingle_ImagesTitle",
			ImagesEmptyText = "WeaponSingle_ImagesEmptyText",
			ManufacturersTitle = "WeaponSingle_ManufacturersTitle",
			ManufacturersEmptyText = "WeaponSingle_ManufacturersEmptyText",
		};
	}

	public static class WeaponSingleExtensions
	{
		public static IWeaponSingleLocalisation? GetWeaponSingle(this LocalisationResourceManager? localisationResourceManager, IWeaponSingleLocalisation<bool>? retriever = null, IWeapon<string?>? weaponTitles = null)
		{
			if (localisationResourceManager == null)
				return weaponTitles as IWeaponSingleLocalisation;

			IWeaponSingleLocalisation weaponsingle = IWeaponSingleLocalisation.FromWeapon(weaponTitles) ?? new IWeaponSingleLocalisation.Default { };

			weaponsingle.ImagesTitle = retriever?.ImagesTitle ?? true ? localisationResourceManager.GetString(WeaponSingle.Keys.ImagesTitle) : null;
			weaponsingle.ImagesEmptyText = retriever?.ImagesEmptyText ?? true ? localisationResourceManager.GetString(WeaponSingle.Keys.ImagesEmptyText) : null;
			weaponsingle.ManufacturersTitle = retriever?.ManufacturersTitle ?? true ? localisationResourceManager.GetString(WeaponSingle.Keys.ManufacturersTitle) : null;
			weaponsingle.ManufacturersEmptyText = retriever?.ManufacturersEmptyText ?? true ? localisationResourceManager.GetString(WeaponSingle.Keys.ManufacturersEmptyText) : null;

			return weaponsingle;
		}
		public static IWeaponSingleLocalisation? GetWeaponSingle(this LocalisationResourceManager? localisationResourceManager, IWeaponSingleLocalisation<bool>? retriever = null, LocalisationResourceManager? weaponTitlesLocalisationResourceManager = null)
			=> localisationResourceManager.GetWeaponSingle(
				retriever: retriever,
				weaponTitles: weaponTitlesLocalisationResourceManager.GetWeaponTitles());
	}
}
