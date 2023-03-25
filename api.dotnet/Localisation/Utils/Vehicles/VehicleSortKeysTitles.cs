using Domain.Models;

namespace Localisation.Utils.Vehicles
{
	public class VehicleSortKeysTitles
	{
		public const string ResourceName = "Vehicles.VehicleSortKeysTitles";

		public static readonly IVehicle.ISortKeys<string> Keys = new IVehicle.ISortKeys.Default<string>(string.Empty)
		{
			CargoCapacity = "VehicleSortKeysTitles_CargoCapacity",	
			Consumables = "VehicleSortKeysTitles_Consumables",	
			CostInCredits = "VehicleSortKeysTitles_CostInCredits",	
			Created = "VehicleSortKeysTitles_Created",	
			Edited = "VehicleSortKeysTitles_Edited",	
			Id = "VehicleSortKeysTitles_Id",
			Length = "VehicleSortKeysTitles_Length",
			ManufacturerCount = "VehicleSortKeysTitles_ManufacturerCount",
			MaxAtmospheringSpeed = "VehicleSortKeysTitles_MaxAtmospheringSpeed",
			MaxCrew = "VehicleSortKeysTitles_MaxCrew",
			MinCrew = "VehicleSortKeysTitles_MinCrew",
			Model = "VehicleSortKeysTitles_Model",
			Name = "VehicleSortKeysTitles_Name",
			Passengers = "VehicleSortKeysTitles_Passengers",
			PilotCount = "VehicleSortKeysTitles_PilotCount",
			VehicleClass = "VehicleSortKeysTitles_VehicleClass",
			VehicleClassFlagsCount = "VehicleSortKeysTitles_VehicleClassFlagsCount",
		};
	}

	public static class VehicleSortKeysTitlesExtensions
	{
		public static IVehicle.ISortKeys? GetVehicleSortKeysTitles(this LocalisationResourceManager? localisationResourceManager, IVehicle.ISortKeys<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IVehicle.ISortKeys.Default
				{
					CargoCapacity = retriever?.CargoCapacity ?? true ? localisationResourceManager.GetString(VehicleSortKeysTitles.Keys.CargoCapacity) : null,
					Consumables = retriever?.Consumables ?? true ? localisationResourceManager.GetString(VehicleSortKeysTitles.Keys.Consumables) : null,
					CostInCredits = retriever?.CostInCredits ?? true ? localisationResourceManager.GetString(VehicleSortKeysTitles.Keys.CostInCredits) : null,
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(VehicleSortKeysTitles.Keys.Created) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(VehicleSortKeysTitles.Keys.Edited) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(VehicleSortKeysTitles.Keys.Id) : null,
					Length = retriever?.Length ?? true ? localisationResourceManager.GetString(VehicleSortKeysTitles.Keys.Length) : null,
					ManufacturerCount = retriever?.ManufacturerCount ?? true ? localisationResourceManager.GetString(VehicleSortKeysTitles.Keys.ManufacturerCount) : null,
					MaxAtmospheringSpeed = retriever?.MaxAtmospheringSpeed ?? true ? localisationResourceManager.GetString(VehicleSortKeysTitles.Keys.MaxAtmospheringSpeed) : null,
					MaxCrew = retriever?.MaxCrew ?? true ? localisationResourceManager.GetString(VehicleSortKeysTitles.Keys.MaxCrew) : null,
					MinCrew = retriever?.MinCrew ?? true ? localisationResourceManager.GetString(VehicleSortKeysTitles.Keys.MinCrew) : null,
					Model = retriever?.Model ?? true ? localisationResourceManager.GetString(VehicleSortKeysTitles.Keys.Model) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(VehicleSortKeysTitles.Keys.Name) : null,
					Passengers = retriever?.Passengers ?? true ? localisationResourceManager.GetString(VehicleSortKeysTitles.Keys.Passengers) : null,
					PilotCount = retriever?.PilotCount ?? true ? localisationResourceManager.GetString(VehicleSortKeysTitles.Keys.PilotCount) : null,
					VehicleClass = retriever?.VehicleClass ?? true ? localisationResourceManager.GetString(VehicleSortKeysTitles.Keys.VehicleClass) : null,
					VehicleClassFlagsCount = retriever?.VehicleClassFlagsCount ?? true ? localisationResourceManager.GetString(VehicleSortKeysTitles.Keys.VehicleClassFlagsCount) : null,
				};
	}
}
