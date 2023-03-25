using Domain.Models;

namespace Localisation.Utils.Manufacturers
{
	public class ManufacturerSearchContainablesTitles
	{
		public const string ResourceName = "Manufacturers.ManufacturerSearchContainablesTitles";

		public static readonly IManufacturer.ISearchContainables<string> Keys = new IManufacturer.ISearchContainables.Default<string>(string.Empty)
		{
			Description = "ManufacturerSearchContainablesTitles_Description",
			Name = "ManufacturerSearchContainablesTitles_Name",
		};
	}

	public static class ManufacturerSearchContainablesTitlesExtensions
	{
		public static IManufacturer.ISearchContainables<string?>? GetManufacturerSearchContainablesTitles(this LocalisationResourceManager? localisationResourceManager, IManufacturer.ISearchContainables<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IManufacturer.ISearchContainables.Default<string?>(null)
				{
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(ManufacturerSearchContainablesTitles.Keys.Description) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(ManufacturerSearchContainablesTitles.Keys.Name) : null,
				};
	}
}
