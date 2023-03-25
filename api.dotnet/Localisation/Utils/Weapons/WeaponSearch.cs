using Localisation.Abstractions.StarWarsModels;
using Localisation.Abstractions.Weapons;

namespace Localisation.Utils.Weapons
{
	public class WeaponSearch
	{
		public const string ResourceName = "Weapons.WeaponSearch";

		public static readonly IWeaponSearchLocalisationTyped<string> Keys = new IWeaponSearchLocalisation.DefaultTyped<string>(string.Empty)
		{
			Title = "WeaponSearch_Title",

			ManufacturersSearchContainables = new ISearchItemLocalisation.Default<string>(string.Empty)
			{
				Title = "WeaponSearch_ManufacturersSearchContainables_Title",
				Description = "WeaponSearch_ManufacturersSearchContainables_Description",
			},
		};
	}

	public static class WeaponSearchExtensions
	{
		public static IWeaponSearchLocalisation? GetWeaponSearch(this LocalisationResourceManager? localisationResourceManager, IWeaponSearchLocalisationTyped<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IWeaponSearchLocalisation.Default
				{ 
					Title = retriever?.Title ?? true ? localisationResourceManager.GetString(WeaponSearch.Keys.Title) : null,

					ManufacturersSearchContainables = new ISearchItemLocalisation.Default
					{
						Title = retriever?.ManufacturersSearchContainables.Title ?? true ? localisationResourceManager.GetString(WeaponSearch.Keys.ManufacturersSearchContainables.Title) : null,
						Description = retriever?.ManufacturersSearchContainables.Description ?? true ? localisationResourceManager.GetString(WeaponSearch.Keys.ManufacturersSearchContainables.Description) : null,
					},
				};
	}
}
