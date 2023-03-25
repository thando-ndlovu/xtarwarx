using Domain.Models;

namespace Localisation.Utils.Vehicles
{
	public class VehicleSearchContainablesDescriptions
	{
		public const string ResourceName = "Vehicles.VehicleSearchContainablesDescriptions";

		public static readonly IVehicle.ISearchContainables<string> Keys = new IVehicle.ISearchContainables.Default<string>(string.Empty)
		{
			Description = "VehicleSearchContainablesDescriptions_Description",
			Model = "VehicleSearchContainablesDescriptions_Model",
			Name = "VehicleSearchContainablesDescriptions_Name",
			VehicleClass = "VehicleSearchContainablesDescriptions_VehicleClass",
			VehicleClassFlags = "VehicleSearchContainablesDescriptions_VehicleClassFlags",
		};
	}

	public static class VehicleSearchContainablesDescriptionsExtensions
	{
		public static IVehicle.ISearchContainables<string?>? GetVehicleSearchContainablesDescriptions(this LocalisationResourceManager? localisationResourceManager, IVehicle.ISearchContainables<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IVehicle.ISearchContainables.Default<string?>(null)
				{
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(VehicleSearchContainablesDescriptions.Keys.Description) : null,
					Model = retriever?.Model ?? true ? localisationResourceManager.GetString(VehicleSearchContainablesDescriptions.Keys.Model) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(VehicleSearchContainablesDescriptions.Keys.Name) : null,
					VehicleClass = retriever?.VehicleClass ?? true ? localisationResourceManager.GetString(VehicleSearchContainablesDescriptions.Keys.VehicleClass) : null,
					VehicleClassFlags = retriever?.VehicleClassFlags ?? true ? localisationResourceManager.GetString(VehicleSearchContainablesDescriptions.Keys.VehicleClassFlags) : null,
				};
	}
}
