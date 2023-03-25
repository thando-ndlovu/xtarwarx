using Domain.Models;

namespace Localisation.Utils.Manufacturers
{
	public class ManufacturerSearchContainablesDescriptions
	{
		public const string ResourceName = "Manufacturers.ManufacturerSearchContainablesDescriptions";

		public static readonly IManufacturer.ISearchContainables<string> Keys = new IManufacturer.ISearchContainables.Default<string>(string.Empty)
		{
			Description = "ManufacturerSearchContainablesDescriptions_Description",
			Name = "ManufacturerSearchContainablesDescriptions_Name",
		};
	}

	public static class ManufacturerSearchContainablesDescriptionsExtensions
	{
		public static IManufacturer.ISearchContainables<string?>? GetManufacturerSearchContainablesDescriptions(this LocalisationResourceManager? localisationResourceManager, IManufacturer.ISearchContainables<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IManufacturer.ISearchContainables.Default<string?>(null)
				{
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(ManufacturerSearchContainablesDescriptions.Keys.Description) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(ManufacturerSearchContainablesDescriptions.Keys.Name) : null,
				};
	}
}
