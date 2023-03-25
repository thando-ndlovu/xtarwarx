using Repository.Entities;

using Microsoft.EntityFrameworkCore;

namespace Repository.Implementations
{
	public class RepositoryDbContext : DbContext
	{
		public RepositoryDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
		{
			Characters = Set<CharacterEntity>();
			Factions = Set<FactionEntity>();
			Films = Set<FilmEntity>();
			Manufacturers = Set<ManufacturerEntity>();
			Planets = Set<PlanetEntity>();
			Species = Set<SpecieEntity>();
			Starships = Set<StarshipEntity>();
			Vehicles = Set<VehicleEntity>();
			Weapons = Set<WeaponEntity>();
		}

		public virtual DbSet<CharacterEntity> Characters { get; }
		public virtual DbSet<FactionEntity> Factions { get; }
		public virtual DbSet<FilmEntity> Films { get; }
		public virtual DbSet<ManufacturerEntity> Manufacturers { get; }
		public virtual DbSet<PlanetEntity> Planets { get; }
		public virtual DbSet<SpecieEntity> Species { get; }
		public virtual DbSet<StarshipEntity> Starships { get; }
		public virtual DbSet<VehicleEntity> Vehicles { get; }
		public virtual DbSet<WeaponEntity> Weapons { get; }

		protected override void OnModelCreating(ModelBuilder modelbuilder)
		{
			base.OnModelCreating(modelbuilder);

			modelbuilder.BuildCharacter<CharacterEntity>();
			modelbuilder.BuildFaction<FactionEntity>();
			modelbuilder.BuildFilm<FilmEntity>();
			modelbuilder.BuildManufacturer<ManufacturerEntity>();
			modelbuilder.BuildPlanet<PlanetEntity>();
			modelbuilder.BuildSpecie<SpecieEntity>();
			modelbuilder.BuildStarship<StarshipEntity>();
			modelbuilder.BuildVehicle<VehicleEntity>();
			modelbuilder.BuildWeapon<WeaponEntity>();
		}
	}
}
