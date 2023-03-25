using Domain.Models;

namespace Repository.Entities
{
	public class StarshipEntity : IStarship.Default
	{
		public StarshipEntity(int id) : base(id) { }
		public StarshipEntity(IStarship vehicle) : base(vehicle.Id)
		{
			CargoCapacity = vehicle.CargoCapacity;
			Consumables = vehicle.Consumables;
			CostInCredits = vehicle.CostInCredits;
			Created = vehicle.Created;
			Description = vehicle.Description;
			Edited = vehicle.Edited;
			Length = vehicle.Length;
			HyperdriveRating = vehicle.HyperdriveRating;
			ManufacturerIds = vehicle.ManufacturerIds;
			MaxAtmospheringSpeed = vehicle.MaxAtmospheringSpeed;
			MaxCrew = vehicle.MaxCrew;
			MinCrew = vehicle.MinCrew;
			MGLT = vehicle.MGLT;
			Model = vehicle.Model;
			Name = vehicle.Name;
			Passengers = vehicle.Passengers;
			PilotIds = vehicle.PilotIds;
			Uris = vehicle.Uris;
			StarshipClass = vehicle.StarshipClass;
		}
	}
}
