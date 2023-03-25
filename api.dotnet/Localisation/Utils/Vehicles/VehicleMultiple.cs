using Localisation.Abstractions.Vehicles;

namespace Localisation.Utils.Vehicles
{
	public class VehicleMultiple 
	{
		public const string ResourceName = "Vehicles.VehicleMultiple";

		public static readonly IVehicleMultipleLocalisation<string> Keys = new IVehicleMultipleLocalisation.Default<string>(string.Empty)
		{
			VehiclesEmptyText = "VehicleMultiple_VehiclesEmptyText",
			VehiclesTitle = "VehicleMultiple_VehiclesTitle",
			VehiclesSearchbarPlaceholder = "VehicleMultiple_VehiclesSearchbarPlaceholder",
		};
	}

	public static class VehicleMultipleExtensions
	{
		public static IVehicleMultipleLocalisation? GetVehicleMultiple(this LocalisationResourceManager? localisationResourceManager, IVehicleMultipleLocalisation<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IVehicleMultipleLocalisation.Default
				{
					VehiclesEmptyText = retriever?.VehiclesEmptyText ?? true ? localisationResourceManager.GetString(VehicleMultiple.Keys.VehiclesEmptyText) : null,
					VehiclesTitle = retriever?.VehiclesTitle ?? true ? localisationResourceManager.GetString(VehicleMultiple.Keys.VehiclesTitle) : null,
					VehiclesSearchbarPlaceholder = retriever?.VehiclesSearchbarPlaceholder ?? true ? localisationResourceManager.GetString(VehicleMultiple.Keys.VehiclesSearchbarPlaceholder) : null,
				};
	}
}
