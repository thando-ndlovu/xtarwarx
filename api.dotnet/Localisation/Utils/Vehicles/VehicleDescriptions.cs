using Domain.Models;

namespace Localisation.Utils.Vehicles
{
	public class VehicleDescriptions
	{
		public const string ResourceName = "Vehicles.VehicleDescriptions";

		public static readonly IVehicle<string> Keys = new IVehicle.Default<string>(string.Empty)
		{
			CargoCapacity = "VehicleDescriptions_CargoCapacity",
			Consumables = "VehicleDescriptions_Consumables",
			CostInCredits = "VehicleDescriptions_CostInCredits",
			Description = "VehicleDescriptions_Description",
			Id = "VehicleDescriptions_Id",
			Length = "VehicleDescriptions_Length",
			ManufacturerIds = "VehicleDescriptions_ManufacturerIds",
			MaxAtmospheringSpeed = "VehicleDescriptions_MaxAtmospheringSpeed",
			MaxCrew = "VehicleDescriptions_MaxCrew",
			MinCrew = "VehicleDescriptions_MinCrew",
			Model = "VehicleDescriptions_Model",
			Name = "VehicleDescriptions_Name",
			Passengers = "VehicleDescriptions_Passengers",
			PilotIds = "VehicleDescriptions_PilotIds",
			VehicleClass = "VehicleDescriptions_VehicleClass",
			Uris = "VehicleDescriptions_Uris",
			Created = "VehicleDescriptions_Created",
			Edited = "VehicleDescriptions_Edited",
		};
	}

	public static class VehicleDescriptionsExtensions
	{
		public static IVehicle<string?>? GetVehicleDescriptions(this LocalisationResourceManager? localisationResourceManager, IVehicle<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IVehicle.Default<string?>(null)
				{
					CargoCapacity = retriever?.CargoCapacity ?? true ? localisationResourceManager.GetString(VehicleDescriptions.Keys.CargoCapacity) : null,
					Consumables = retriever?.Consumables ?? true ? localisationResourceManager.GetString(VehicleDescriptions.Keys.Consumables) : null,
					CostInCredits = retriever?.CostInCredits ?? true ? localisationResourceManager.GetString(VehicleDescriptions.Keys.CostInCredits) : null,
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(VehicleDescriptions.Keys.Created) : null,
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(VehicleDescriptions.Keys.Description) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(VehicleDescriptions.Keys.Edited) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(VehicleDescriptions.Keys.Id) : null,
					Length = retriever?.Length ?? true ? localisationResourceManager.GetString(VehicleDescriptions.Keys.Length) : null,
					ManufacturerIds = retriever?.ManufacturerIds ?? true ? localisationResourceManager.GetString(VehicleDescriptions.Keys.ManufacturerIds) : null,
					MaxAtmospheringSpeed = retriever?.MaxAtmospheringSpeed ?? true ? localisationResourceManager.GetString(VehicleDescriptions.Keys.MaxAtmospheringSpeed) : null,
					MaxCrew = retriever?.MaxCrew ?? true ? localisationResourceManager.GetString(VehicleDescriptions.Keys.MaxCrew) : null,
					MinCrew = retriever?.MinCrew ?? true ? localisationResourceManager.GetString(VehicleDescriptions.Keys.MinCrew) : null,
					Model = retriever?.Model ?? true ? localisationResourceManager.GetString(VehicleDescriptions.Keys.Model) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(VehicleDescriptions.Keys.Name) : null,
					Passengers = retriever?.Passengers ?? true ? localisationResourceManager.GetString(VehicleDescriptions.Keys.Passengers) : null,
					PilotIds = retriever?.PilotIds ?? true ? localisationResourceManager.GetString(VehicleDescriptions.Keys.PilotIds) : null,
					Uris = retriever?.Uris ?? true ? localisationResourceManager.GetString(VehicleDescriptions.Keys.Uris) : null,
					VehicleClass = retriever?.VehicleClass ?? true ? localisationResourceManager.GetString(VehicleDescriptions.Keys.VehicleClass) : null,
				};
	}
}
