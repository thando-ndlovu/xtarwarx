using Domain.Models;

using Localisation.Abstractions.Vehicles;

namespace Localisation.Utils.Vehicles
{
	public class VehicleSingle 
	{
		public const string ResourceName = "Vehicles.VehicleSingle";

		public static readonly IVehicleSingleLocalisation<string> Keys = new IVehicleSingleLocalisation.Default<string>(string.Empty)
		{
			ImagesTitle = "VehicleSingle_ImagesTitle",
			ImagesEmptyText = "VehicleSingle_ImagesEmptyText",
			ManufacturersTitle = "VehicleSingle_ManufacturersTitle",
			ManufacturersEmptyText = "VehicleSingle_ManufacturersEmptyText",
			PilotsTitle = "VehicleSingle_PilotsTitle",
			PilotsEmptyText = "VehicleSingle_PilotsEmptyText",
		};
	}

	public static class VehicleSingleExtensions
	{
		public static IVehicleSingleLocalisation? GetVehicleSingle(this LocalisationResourceManager? localisationResourceManager, IVehicleSingleLocalisation<bool>? retriever = null, IVehicle<string?>? vehicleTitles = null)
		{
			if (localisationResourceManager == null)
				return vehicleTitles as IVehicleSingleLocalisation;

			IVehicleSingleLocalisation vehicleSingle = IVehicleSingleLocalisation.FromVehicle(vehicleTitles) ?? new IVehicleSingleLocalisation.Default { };
										
			vehicleSingle.ImagesTitle = retriever?.ImagesTitle ?? true ? localisationResourceManager.GetString(VehicleSingle.Keys.ImagesTitle) : null;
			vehicleSingle.ImagesEmptyText = retriever?.ImagesEmptyText ?? true ? localisationResourceManager.GetString(VehicleSingle.Keys.ImagesEmptyText) : null;
			vehicleSingle.ManufacturersTitle = retriever?.ManufacturersTitle ?? true ? localisationResourceManager.GetString(VehicleSingle.Keys.ManufacturersTitle) : null;
			vehicleSingle.ManufacturersEmptyText = retriever?.ManufacturersEmptyText ?? true ? localisationResourceManager.GetString(VehicleSingle.Keys.ManufacturersEmptyText) : null;
			vehicleSingle.PilotsTitle = retriever?.PilotsTitle ?? true ? localisationResourceManager.GetString(VehicleSingle.Keys.PilotsTitle) : null;
			vehicleSingle.PilotsEmptyText = retriever?.PilotsEmptyText ?? true ? localisationResourceManager.GetString(VehicleSingle.Keys.PilotsEmptyText) : null;

			return vehicleSingle;

		}
		public static IVehicleSingleLocalisation? GetVehicleSingle(this LocalisationResourceManager? localisationResourceManager, IVehicleSingleLocalisation<bool>? retriever = null, LocalisationResourceManager? vehicleTitlesLocalisationResourceManager = null)
			=> localisationResourceManager.GetVehicleSingle(
				retriever: retriever,
				vehicleTitles: vehicleTitlesLocalisationResourceManager.GetVehicleTitles());
	}
}
