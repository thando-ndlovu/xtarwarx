using Domain.Models;

namespace Repository.Entities
{
	public class ManufacturerEntity : IManufacturer.Default
	{
		public ManufacturerEntity(int id) : base(id) { }
		public ManufacturerEntity(IManufacturer manufacturer) : base(manufacturer.Id)
		{
			Created = manufacturer.Created;
			Description = manufacturer.Description;
			Edited = manufacturer.Edited;
			HeadquatersPlanetId = manufacturer.HeadquatersPlanetId;
			Name = manufacturer.Name;
			StarshipIds = manufacturer.StarshipIds;
			Uris = manufacturer.Uris;
			VehicleIds = manufacturer.VehicleIds;
			WeaponIds = manufacturer.WeaponIds;
		}
	}
}
