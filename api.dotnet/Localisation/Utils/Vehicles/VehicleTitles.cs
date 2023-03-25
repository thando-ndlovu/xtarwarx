using Domain.Models;

namespace Localisation.Utils.Vehicles
{
	public class VehicleTitles 
	{
		public const string ResourceName = "Vehicles.VehicleTitles";

		public static readonly IVehicle<string> Keys = new IVehicle.Default<string>(string.Empty)
		{
			CargoCapacity = "VehicleTitles_CargoCapacity",
			Consumables = "VehicleTitles_Consumables",
			CostInCredits = "VehicleTitles_CostInCredits",
			Description = "VehicleTitles_Description",
			Id = "VehicleTitles_Id",
			Length = "VehicleTitles_Length",
			ManufacturerIds = "VehicleTitles_ManufacturerIds",
			MaxAtmospheringSpeed = "VehicleTitles_MaxAtmospheringSpeed",
			MaxCrew = "VehicleTitles_MaxCrew",
			MinCrew = "VehicleTitles_MinCrew",
			Model = "VehicleTitles_Model",
			Name = "VehicleTitles_Name",
			Passengers = "VehicleTitles_Passengers",
			PilotIds = "VehicleTitles_PilotIds",
			VehicleClass = "VehicleTitles_VehicleClass",
			Uris = "VehicleTitles_Uris",
			Created = "VehicleTitles_Created",
			Edited = "VehicleTitles_Edited",
		};
	}

	public static class VehicleTitlesExtensions
	{
		public static IVehicle<string?>? GetVehicleTitles(this LocalisationResourceManager? localisationResourceManager, IVehicle<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IVehicle.Default<string?>(null)
				{
					CargoCapacity = retriever?.CargoCapacity ?? true ? localisationResourceManager.GetString(VehicleTitles.Keys.CargoCapacity) : null,
					Consumables = retriever?.Consumables ?? true ? localisationResourceManager.GetString(VehicleTitles.Keys.Consumables) : null,
					CostInCredits = retriever?.CostInCredits ?? true ? localisationResourceManager.GetString(VehicleTitles.Keys.CostInCredits) : null,
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(VehicleTitles.Keys.Created) : null,
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(VehicleTitles.Keys.Description) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(VehicleTitles.Keys.Edited) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(VehicleTitles.Keys.Id) : null,
					Length = retriever?.Length ?? true ? localisationResourceManager.GetString(VehicleTitles.Keys.Length) : null,
					ManufacturerIds = retriever?.ManufacturerIds ?? true ? localisationResourceManager.GetString(VehicleTitles.Keys.ManufacturerIds) : null,
					MaxAtmospheringSpeed = retriever?.MaxAtmospheringSpeed ?? true ? localisationResourceManager.GetString(VehicleTitles.Keys.MaxAtmospheringSpeed) : null,
					MaxCrew = retriever?.MaxCrew ?? true ? localisationResourceManager.GetString(VehicleTitles.Keys.MaxCrew) : null,
					MinCrew = retriever?.MinCrew ?? true ? localisationResourceManager.GetString(VehicleTitles.Keys.MinCrew) : null,
					Model = retriever?.Model ?? true ? localisationResourceManager.GetString(VehicleTitles.Keys.Model) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(VehicleTitles.Keys.Name) : null,
					Passengers = retriever?.Passengers ?? true ? localisationResourceManager.GetString(VehicleTitles.Keys.Passengers) : null,
					PilotIds = retriever?.PilotIds ?? true ? localisationResourceManager.GetString(VehicleTitles.Keys.PilotIds) : null,
					Uris = retriever?.Uris ?? true ? localisationResourceManager.GetString(VehicleTitles.Keys.Uris) : null,
					VehicleClass = retriever?.VehicleClass ?? true ? localisationResourceManager.GetString(VehicleTitles.Keys.VehicleClass) : null,
				};
	}
}
