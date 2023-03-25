using Localisation.Abstractions.Manufacturers;
using Localisation.Abstractions.StarWarsModels;

namespace Localisation.Utils.Manufacturers
{
	public class ManufacturerSearch
	{
		public const string ResourceName = "Manufacturers.ManufacturerSearch";

		public static readonly IManufacturerSearchLocalisationTyped<string> Keys = new IManufacturerSearchLocalisation.DefaultTyped<string>(string.Empty)
		{
			Title = "ManufacturerSearch_Title",

			HeadquatersPlanetSearchContainables = new ISearchItemLocalisation.Default<string>(string.Empty)
			{
				Title = "ManufacturerSearch_HeadquatersPlanetSearchContainables_Title",
				Description = "ManufacturerSearch_HeadquatersPlanetSearchContainables_Description",
			},
			StarshipsSearchContainables = new ISearchItemLocalisation.Default<string>(string.Empty)
			{
				Title = "ManufacturerSearch_StarshipsSearchContainables_Title",
				Description = "ManufacturerSearch_StarshipsSearchContainables_Description",
			},
			VehiclesSearchContainables = new ISearchItemLocalisation.Default<string>(string.Empty)
			{
				Title = "ManufacturerSearch_VehiclesSearchContainables_Title",
				Description = "ManufacturerSearch_VehiclesSearchContainables_Description",
			},
			WeaponsSearchContainables = new ISearchItemLocalisation.Default<string>(string.Empty)
			{
				Title = "ManufacturerSearch_WeaponsSearchContainables_Title",
				Description = "ManufacturerSearch_WeaponsSearchContainables_Description",
			},
		};
	}

	public static class ManufacturerSearchExtensions
	{
		public static IManufacturerSearchLocalisation? GetManufacturerSearch(this LocalisationResourceManager? localisationResourceManager, IManufacturerSearchLocalisationTyped<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IManufacturerSearchLocalisation.Default
				{
					Title = retriever?.Title ?? true ? localisationResourceManager.GetString(ManufacturerSearch.Keys.Title) : null,

					HeadquatersPlanetSearchContainables = new ISearchItemLocalisation.Default
					{
						Title = retriever?.HeadquatersPlanetSearchContainables?.Title ?? true ? localisationResourceManager.GetString(ManufacturerSearch.Keys.HeadquatersPlanetSearchContainables.Title) : null,
						Description = retriever?.HeadquatersPlanetSearchContainables?.Description ?? true ? localisationResourceManager.GetString(ManufacturerSearch.Keys.HeadquatersPlanetSearchContainables.Description) : null,
					},
					StarshipsSearchContainables = new ISearchItemLocalisation.Default
					{
						Title = retriever?.StarshipsSearchContainables?.Title ?? true ? localisationResourceManager.GetString(ManufacturerSearch.Keys.StarshipsSearchContainables.Title) : null,
						Description = retriever?.StarshipsSearchContainables?.Description ?? true ? localisationResourceManager.GetString(ManufacturerSearch.Keys.StarshipsSearchContainables.Description) : null,
					},
					VehiclesSearchContainables = new ISearchItemLocalisation.Default
					{
						Title = retriever?.VehiclesSearchContainables?.Title ?? true ? localisationResourceManager.GetString(ManufacturerSearch.Keys.VehiclesSearchContainables.Title) : null,
						Description = retriever?.VehiclesSearchContainables?.Description ?? true ? localisationResourceManager.GetString(ManufacturerSearch.Keys.VehiclesSearchContainables.Description) : null,
					},
					WeaponsSearchContainables = new ISearchItemLocalisation.Default
					{
						Title = retriever?.WeaponsSearchContainables?.Title ?? true ? localisationResourceManager.GetString(ManufacturerSearch.Keys.WeaponsSearchContainables.Title) : null,
						Description = retriever?.WeaponsSearchContainables?.Description ?? true ? localisationResourceManager.GetString(ManufacturerSearch.Keys.WeaponsSearchContainables.Description) : null,
					},
				};
	}
}
