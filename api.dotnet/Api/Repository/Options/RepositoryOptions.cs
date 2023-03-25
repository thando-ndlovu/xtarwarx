using Domain.Models;

using System.Collections.Generic;

namespace Api.Repository.Options
{
	public class RepositoryOptions 
	{
		#region SeedData

		public IList<ICharacter>? SeedCharacters { get; set; }
		public IList<IFaction>? SeedFactions { get; set; }
		public IList<IFilm>? SeedFilms { get; set; }
		public IList<IManufacturer>? SeedManufacturers { get; set; }
		public IList<IPlanet>? SeedPlanets { get; set; }
		public IList<ISpecie>? SeedSpecies { get; set; }
		public IList<IStarship>? SeedStarships { get; set; }
		public IList<IVehicle>? SeedVehicles { get; set; }
		public IList<IWeapon>? SeedWeapons { get; set; }

		#endregion
	}
}