using Domain.Models;

namespace Localisation.Utils.Weapons
{
	public class WeaponSortKeysDescriptions
	{
		public const string ResourceName = "Weapons.WeaponSortKeysDescriptions";

		public static readonly IWeapon.ISortKeys<string> Keys = new IWeapon.ISortKeys.Default<string>(string.Empty)
		{
			Created = "WeaponSortKeysDescriptions_Created",
			Edited = "WeaponSortKeysDescriptions_Edited",
			Id = "WeaponSortKeysDescriptions_Id",
			ManufacturerCount = "WeaponSortKeysDescriptions_ManufacturerCount",
			Model = "WeaponSortKeysDescriptions_Model",
			Name = "WeaponSortKeysDescriptions_Name",
			WeaponClass = "WeaponSortKeysDescriptions_WeaponClass",
			WeaponClassFlagsCount = "WeaponSortKeysDescriptions_WeaponClassFlagsCount",
		};
	}

	public static class WeaponSortKeysDescriptionsExtensions
	{
		public static IWeapon.ISortKeys? GetWeaponSortKeysDescriptions(this LocalisationResourceManager? localisationResourceManager, IWeapon.ISortKeys<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IWeapon.ISortKeys.Default
				{
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(WeaponSortKeysDescriptions.Keys.Created) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(WeaponSortKeysDescriptions.Keys.Edited) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(WeaponSortKeysDescriptions.Keys.Id) : null,
					ManufacturerCount = retriever?.ManufacturerCount ?? true ? localisationResourceManager.GetString(WeaponSortKeysDescriptions.Keys.ManufacturerCount) : null,
					Model = retriever?.Model ?? true ? localisationResourceManager.GetString(WeaponSortKeysDescriptions.Keys.Model) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(WeaponSortKeysDescriptions.Keys.Name) : null,
					WeaponClass = retriever?.WeaponClass ?? true ? localisationResourceManager.GetString(WeaponSortKeysDescriptions.Keys.WeaponClass) : null,
					WeaponClassFlagsCount = retriever?.WeaponClassFlagsCount ?? true ? localisationResourceManager.GetString(WeaponSortKeysDescriptions.Keys.WeaponClassFlagsCount) : null,
				};
	}
}
