using Localisation.Abstractions.Manufacturers;

namespace Localisation.Utils.Manufacturers
{
	public class ManufacturerMultiple 
	{
		public const string ResourceName = "Manufacturers.ManufacturerMultiple";

		public static readonly IManufacturerMultipleLocalisation<string> Keys = new IManufacturerMultipleLocalisation.Default<string>(string.Empty)
		{
			ManufacturersEmptyText = "ManufacturerMultiple_ManufacturersEmptyText",
			ManufacturersTitle = "ManufacturerMultiple_ManufacturersTitle",
			ManufacturersSearchbarPlaceholder = "ManufacturerMultiple_ManufacturersSearchbarPlaceholder",
		};
	}

	public static class ManufacturerMultipleExtensions
	{
		public static IManufacturerMultipleLocalisation? GetManufacturerMultiple(this LocalisationResourceManager? localisationResourceManager, IManufacturerMultipleLocalisation<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IManufacturerMultipleLocalisation.Default
				{
					ManufacturersEmptyText = retriever?.ManufacturersEmptyText ?? true ? localisationResourceManager.GetString(ManufacturerMultiple.Keys.ManufacturersEmptyText) : null,
					ManufacturersTitle = retriever?.ManufacturersTitle ?? true ? localisationResourceManager.GetString(ManufacturerMultiple.Keys.ManufacturersTitle) : null,
					ManufacturersSearchbarPlaceholder = retriever?.ManufacturersSearchbarPlaceholder ?? true ? localisationResourceManager.GetString(ManufacturerMultiple.Keys.ManufacturersSearchbarPlaceholder) : null,
				};
	}
}
