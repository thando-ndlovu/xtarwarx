using Domain.Models;

namespace Repository.Entities
{
	public class WeaponEntity : IWeapon.Default
	{
		public WeaponEntity(int id) : base(id) { }
		public WeaponEntity(IWeapon weapon) : base(weapon.Id)
		{
			Created = weapon.Created;
			Description = weapon.Description;
			Edited = weapon.Edited;
			ManufacturerIds = weapon.ManufacturerIds;
			Model = weapon.Model;
			Name = weapon.Name;
			Uris = weapon.Uris;
		}
	}
}
