using Domain.Models;

namespace Localisation.Utils.Weapons
{
	public class WeaponDescriptions
	{
		public const string ResourceName = "Weapons.WeaponDescriptions";

		public static readonly IWeapon<string> Keys = new IWeapon.Default<string>(string.Empty)
		{
			Description = "WeaponDescriptions_Description",
			Id = "WeaponDescriptions_Id",
			ManufacturerIds = "WeaponDescriptions_ManufacturerIds",
			Model = "WeaponDescriptions_Model",
			Name = "WeaponDescriptions_Name",
			WeaponClass = "WeaponDescriptions_WeaponClass",
			Uris = "WeaponDescriptions_Uris",
			Created = "WeaponDescriptions_Created",
			Edited = "WeaponDescriptions_Edited",
		};
	}

	public static class WeaponDescriptionsExtensions
	{
		public static IWeapon<string?>? GetWeaponDescriptions(this LocalisationResourceManager? localisationResourceManager, IWeapon<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IWeapon.Default<string?>(null)
				{
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(WeaponDescriptions.Keys.Created) : null,
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(WeaponDescriptions.Keys.Description) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(WeaponDescriptions.Keys.Edited) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(WeaponDescriptions.Keys.Id) : null,
					ManufacturerIds = retriever?.ManufacturerIds ?? true ? localisationResourceManager.GetString(WeaponDescriptions.Keys.ManufacturerIds) : null,
					Model = retriever?.Model ?? true ? localisationResourceManager.GetString(WeaponDescriptions.Keys.Model) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(WeaponDescriptions.Keys.Name) : null,
					Uris = retriever?.Uris ?? true ? localisationResourceManager.GetString(WeaponDescriptions.Keys.Uris) : null,
					WeaponClass = retriever?.WeaponClass ?? true ? localisationResourceManager.GetString(WeaponDescriptions.Keys.WeaponClass) : null,
				};
	}
}
