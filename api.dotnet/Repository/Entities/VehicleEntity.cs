using Domain.Models;

namespace Repository.Entities
{
	public class VehicleEntity : IVehicle.Default
	{
		public VehicleEntity(int id) : base(id) { }
		public VehicleEntity(IVehicle vehicle) : base(vehicle.Id)
		{
			CargoCapacity = vehicle.CargoCapacity;
			Consumables = vehicle.Consumables;
			CostInCredits = vehicle.CostInCredits;
			Created = vehicle.Created;
			Description = vehicle.Description;
			Edited = vehicle.Edited;
			Length = vehicle.Length;
			ManufacturerIds = vehicle.ManufacturerIds;
			MaxAtmospheringSpeed = vehicle.MaxAtmospheringSpeed;
			MaxCrew = vehicle.MaxCrew;
			MinCrew = vehicle.MinCrew;
			Model = vehicle.Model;
			Name = vehicle.Name;
			Passengers = vehicle.Passengers;
			PilotIds = vehicle.PilotIds;
			Uris = vehicle.Uris;
			VehicleClass = vehicle.VehicleClass;
		}
	}
}
