using Domain.Models;

namespace Localisation.Utils.Weapons
{
	public class WeaponSearchContainablesTitles
	{
		public const string ResourceName = "Weapons.WeaponSearchContainablesTitles";

		public static readonly IWeapon.ISearchContainables<string> Keys = new IWeapon.ISearchContainables.Default<string>(string.Empty)
		{
			Description = "WeaponSearchContainablesTitles_Description",
			Model = "WeaponSearchContainablesTitles_Model",
			Name = "WeaponSearchContainablesTitles_Name",
			WeaponClass = "WeaponSearchContainablesTitles_WeaponClass",
			WeaponClassFlags = "WeaponSearchContainablesTitles_WeaponClassFlags",
		};
	}

	public static class WeaponSearchContainablesTitlesExtensions
	{
		public static IWeapon.ISearchContainables<string?>? GetWeaponSearchContainablesTitles(this LocalisationResourceManager? localisationResourceManager, IWeapon.ISearchContainables<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IWeapon.ISearchContainables.Default<string?>(null)
				{
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(WeaponSearchContainablesTitles.Keys.Description) : null,
					Model = retriever?.Model ?? true ? localisationResourceManager.GetString(WeaponSearchContainablesTitles.Keys.Model) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(WeaponSearchContainablesTitles.Keys.Name) : null,
					WeaponClass = retriever?.WeaponClass ?? true ? localisationResourceManager.GetString(WeaponSearchContainablesTitles.Keys.WeaponClass) : null,
					WeaponClassFlags = retriever?.WeaponClassFlags ?? true ? localisationResourceManager.GetString(WeaponSearchContainablesTitles.Keys.WeaponClassFlags) : null,
				};
	}
}
