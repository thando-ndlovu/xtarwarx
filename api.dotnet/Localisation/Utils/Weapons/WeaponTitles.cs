using Domain.Models;

namespace Localisation.Utils.Weapons
{
	public class WeaponTitles 
	{
		public const string ResourceName = "Weapons.WeaponTitles";

		public static readonly IWeapon<string> Keys = new IWeapon.Default<string>(string.Empty)
		{
			Description = "WeaponTitles_Description",
			Id = "WeaponTitles_Id",
			ManufacturerIds = "WeaponTitles_ManufacturerIds",
			Model = "WeaponTitles_Model",
			Name = "WeaponTitles_Name",
			WeaponClass = "WeaponTitles_WeaponClass",
			Uris = "WeaponTitles_Uris",
			Created = "WeaponTitles_Created",
			Edited = "WeaponTitles_Edited",
		};
	}

	public static class WeaponTitlesExtensions
	{
		public static IWeapon<string?>? GetWeaponTitles(this LocalisationResourceManager? localisationResourceManager, IWeapon<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IWeapon.Default<string?>(null)
				{
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(WeaponTitles.Keys.Created) : null,
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(WeaponTitles.Keys.Description) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(WeaponTitles.Keys.Edited) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(WeaponTitles.Keys.Id) : null,
					ManufacturerIds = retriever?.ManufacturerIds ?? true ? localisationResourceManager.GetString(WeaponTitles.Keys.ManufacturerIds) : null,
					Model = retriever?.Model ?? true ? localisationResourceManager.GetString(WeaponTitles.Keys.Model) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(WeaponTitles.Keys.Name) : null,
					Uris = retriever?.Uris ?? true ? localisationResourceManager.GetString(WeaponTitles.Keys.Uris) : null,
					WeaponClass = retriever?.WeaponClass ?? true ? localisationResourceManager.GetString(WeaponTitles.Keys.WeaponClass) : null,
				};
	}
}
