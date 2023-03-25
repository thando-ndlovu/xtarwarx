using Domain.Models;

namespace Localisation.Utils.Weapons
{
	public class WeaponSortKeysTitles
	{
		public const string ResourceName = "Weapons.WeaponSortKeysTitles";

		public static readonly IWeapon.ISortKeys<string> Keys = new IWeapon.ISortKeys.Default<string>(string.Empty)
		{
			Created = "WeaponSortKeysTitles_Created",
			Edited = "WeaponSortKeysTitles_Edited",
			Id = "WeaponSortKeysTitles_Id",
			ManufacturerCount = "WeaponSortKeysTitles_ManufacturerCount",
			Model = "WeaponSortKeysTitles_Model",
			Name = "WeaponSortKeysTitles_Name",
			WeaponClass = "WeaponSortKeysTitles_WeaponClass",
			WeaponClassFlagsCount = "WeaponSortKeysTitles_WeaponClassFlagsCount",
		};
	}

	public static class WeaponSortKeysTitlesExtensions
	{
		public static IWeapon.ISortKeys? GetWeaponSortKeysTitles(this LocalisationResourceManager? localisationResourceManager, IWeapon.ISortKeys<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IWeapon.ISortKeys.Default
				{
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(WeaponSortKeysTitles.Keys.Created) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(WeaponSortKeysTitles.Keys.Edited) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(WeaponSortKeysTitles.Keys.Id) : null,
					ManufacturerCount = retriever?.ManufacturerCount ?? true ? localisationResourceManager.GetString(WeaponSortKeysTitles.Keys.ManufacturerCount) : null,
					Model = retriever?.Model ?? true ? localisationResourceManager.GetString(WeaponSortKeysTitles.Keys.Model) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(WeaponSortKeysTitles.Keys.Name) : null,
					WeaponClass = retriever?.WeaponClass ?? true ? localisationResourceManager.GetString(WeaponSortKeysTitles.Keys.WeaponClass) : null,
					WeaponClassFlagsCount = retriever?.WeaponClassFlagsCount ?? true ? localisationResourceManager.GetString(WeaponSortKeysTitles.Keys.WeaponClassFlagsCount) : null,
				};
	}
}
