using Domain.Models;

namespace Localisation.Utils.Weapons
{
	public class WeaponSearchContainablesDescriptions
	{
		public const string ResourceName = "Weapons.WeaponSearchContainablesDescriptions";

		public static readonly IWeapon.ISearchContainables<string> Keys = new IWeapon.ISearchContainables.Default<string>(string.Empty)
		{
			Description = "WeaponSearchContainablesDescriptions_Description",
			Model = "WeaponSearchContainablesDescriptions_Model",
			Name = "WeaponSearchContainablesDescriptions_Name",
			WeaponClass = "WeaponSearchContainablesDescriptions_WeaponClass",
			WeaponClassFlags = "WeaponSearchContainablesDescriptions_WeaponClassFlags",
		};
	}

	public static class WeaponSearchContainablesDescriptionsExtensions
	{
		public static IWeapon.ISearchContainables<string?>? GetWeaponSearchContainablesDescriptions(this LocalisationResourceManager? localisationResourceManager, IWeapon.ISearchContainables<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IWeapon.ISearchContainables.Default<string?>(null)
				{
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(WeaponSearchContainablesDescriptions.Keys.Description) : null,
					Model = retriever?.Model ?? true ? localisationResourceManager.GetString(WeaponSearchContainablesDescriptions.Keys.Model) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(WeaponSearchContainablesDescriptions.Keys.Name) : null,
					WeaponClass = retriever?.WeaponClass ?? true ? localisationResourceManager.GetString(WeaponSearchContainablesDescriptions.Keys.WeaponClass) : null,
					WeaponClassFlags = retriever?.WeaponClassFlags ?? true ? localisationResourceManager.GetString(WeaponSearchContainablesDescriptions.Keys.WeaponClassFlags) : null,
				};
	}
}
