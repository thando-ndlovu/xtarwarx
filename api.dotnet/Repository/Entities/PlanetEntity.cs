using Domain.Models;

namespace Repository.Entities
{
	public class PlanetEntity : IPlanet.Default
	{
		public PlanetEntity(int id) : base(id) { }
		public PlanetEntity(IPlanet planet) : base(planet.Id) 
		{
			Climates = planet.Climates;
			Created = planet.Created;
			Description = planet.Description;
			Diameter = planet.Diameter;
			Edited = planet.Edited;
			Gravity = planet.Gravity;
			Name = planet.Name;
			OrbitalPeriod = planet.OrbitalPeriod;
			Population = planet.Population;
			ResidentIds = planet.ResidentIds;
			RotationalPeriod = planet.RotationalPeriod;
			SurfaceWater = planet.SurfaceWater;
			Terrains = planet.Terrains;
			Uris = planet.Uris;
		}
	}
}
