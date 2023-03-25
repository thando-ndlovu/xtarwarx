using Domain.Models;

using Repository.Entities;

using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Repository
{
	public partial interface IRepository
	{
		ISet<CharacterEntity> Characters { get; }
		ISet<FactionEntity> Factions { get; }
		ISet<FilmEntity> Films { get; }
		ISet<ManufacturerEntity> Manufacturers { get; }
		ISet<PlanetEntity> Planets { get; }
		ISet<SpecieEntity> Species { get; }
		ISet<StarshipEntity> Starships { get; }
		ISet<VehicleEntity> Vehicles { get; }
		ISet<WeaponEntity> Weapons { get; }
	}
}
