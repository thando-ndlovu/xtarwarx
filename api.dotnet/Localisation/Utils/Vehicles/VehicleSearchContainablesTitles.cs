using Domain.Models;

namespace Localisation.Utils.Vehicles
{
	public class VehicleSearchContainablesTitles
	{
		public const string ResourceName = "Vehicles.VehicleSearchContainablesTitles";

		public static readonly IVehicle.ISearchContainables<string> Keys = new IVehicle.ISearchContainables.Default<string>(string.Empty)
		{
			Description = "VehicleSearchContainablesTitles_Description",
			Model = "VehicleSearchContainablesTitles_Model",
			Name = "VehicleSearchContainablesTitles_Name",
			VehicleClass = "VehicleSearchContainablesTitles_VehicleClass",
			VehicleClassFlags = "VehicleSearchContainablesTitles_VehicleClassFlags",
		};
	}

	public static class VehicleSearchContainablesTitlesExtensions
	{
		public static IVehicle.ISearchContainables<string?>? GetVehicleSearchContainablesTitles(this LocalisationResourceManager? localisationResourceManager, IVehicle.ISearchContainables<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IVehicle.ISearchContainables.Default<string?>(null)
				{
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(VehicleSearchContainablesTitles.Keys.Description) : null,
					Model = retriever?.Model ?? true ? localisationResourceManager.GetString(VehicleSearchContainablesTitles.Keys.Model) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(VehicleSearchContainablesTitles.Keys.Name) : null,
					VehicleClass = retriever?.VehicleClass ?? true ? localisationResourceManager.GetString(VehicleSearchContainablesTitles.Keys.VehicleClass) : null,
					VehicleClassFlags = retriever?.VehicleClassFlags ?? true ? localisationResourceManager.GetString(VehicleSearchContainablesTitles.Keys.VehicleClassFlags) : null,
				};
	}
}
