using Domain.Models;

namespace Localisation.Utils.Vehicles
{
	public class VehicleSortKeysDescriptions
	{
		public const string ResourceName = "Vehicles.VehicleSortKeysDescriptions";

		public static readonly IVehicle.ISortKeys<string> Keys = new IVehicle.ISortKeys.Default<string>(string.Empty)
		{
			CargoCapacity = "VehicleSortKeysDescriptions_CargoCapacity",	
			Consumables = "VehicleSortKeysDescriptions_Consumables",	
			CostInCredits = "VehicleSortKeysDescriptions_CostInCredits",	
			Created = "VehicleSortKeysDescriptions_Created",	
			Edited = "VehicleSortKeysDescriptions_Edited",	
			Id = "VehicleSortKeysDescriptions_Id",
			Length = "VehicleSortKeysDescriptions_Length",
			ManufacturerCount = "VehicleSortKeysDescriptions_ManufacturerCount",
			MaxAtmospheringSpeed = "VehicleSortKeysDescriptions_MaxAtmospheringSpeed",
			MaxCrew = "VehicleSortKeysDescriptions_MaxCrew",
			MinCrew = "VehicleSortKeysDescriptions_MinCrew",
			Model = "VehicleSortKeysDescriptions_Model",
			Name = "VehicleSortKeysDescriptions_Name",
			Passengers = "VehicleSortKeysDescriptions_Passengers",
			PilotCount = "VehicleSortKeysDescriptions_PilotCount",
			VehicleClass = "VehicleSortKeysDescriptions_VehicleClass",
			VehicleClassFlagsCount = "VehicleSortKeysDescriptions_VehicleClassFlagsCount",
		};
	}

	public static class VehicleSortKeysDescriptionsExtensions
	{
		public static IVehicle.ISortKeys? GetVehicleSortKeysDescriptions(this LocalisationResourceManager? localisationResourceManager, IVehicle.ISortKeys<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IVehicle.ISortKeys.Default
				{
					CargoCapacity = retriever?.CargoCapacity ?? true ? localisationResourceManager.GetString(VehicleSortKeysDescriptions.Keys.CargoCapacity) : null,
					Consumables = retriever?.Consumables ?? true ? localisationResourceManager.GetString(VehicleSortKeysDescriptions.Keys.Consumables) : null,
					CostInCredits = retriever?.CostInCredits ?? true ? localisationResourceManager.GetString(VehicleSortKeysDescriptions.Keys.CostInCredits) : null,
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(VehicleSortKeysDescriptions.Keys.Created) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(VehicleSortKeysDescriptions.Keys.Edited) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(VehicleSortKeysDescriptions.Keys.Id) : null,
					Length = retriever?.Length ?? true ? localisationResourceManager.GetString(VehicleSortKeysDescriptions.Keys.Length) : null,
					ManufacturerCount = retriever?.ManufacturerCount ?? true ? localisationResourceManager.GetString(VehicleSortKeysDescriptions.Keys.ManufacturerCount) : null,
					MaxAtmospheringSpeed = retriever?.MaxAtmospheringSpeed ?? true ? localisationResourceManager.GetString(VehicleSortKeysDescriptions.Keys.MaxAtmospheringSpeed) : null,
					MaxCrew = retriever?.MaxCrew ?? true ? localisationResourceManager.GetString(VehicleSortKeysDescriptions.Keys.MaxCrew) : null,
					MinCrew = retriever?.MinCrew ?? true ? localisationResourceManager.GetString(VehicleSortKeysDescriptions.Keys.MinCrew) : null,
					Model = retriever?.Model ?? true ? localisationResourceManager.GetString(VehicleSortKeysDescriptions.Keys.Model) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(VehicleSortKeysDescriptions.Keys.Name) : null,
					Passengers = retriever?.Passengers ?? true ? localisationResourceManager.GetString(VehicleSortKeysDescriptions.Keys.Passengers) : null,
					PilotCount = retriever?.PilotCount ?? true ? localisationResourceManager.GetString(VehicleSortKeysDescriptions.Keys.PilotCount) : null,
					VehicleClass = retriever?.VehicleClass ?? true ? localisationResourceManager.GetString(VehicleSortKeysDescriptions.Keys.VehicleClass) : null,
					VehicleClassFlagsCount = retriever?.VehicleClassFlagsCount ?? true ? localisationResourceManager.GetString(VehicleSortKeysDescriptions.Keys.VehicleClassFlagsCount) : null,
				};
	}
}
