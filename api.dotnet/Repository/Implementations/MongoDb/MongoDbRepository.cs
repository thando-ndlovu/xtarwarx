using Repository.Entities;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

using MongoDB;
using MongoDB.Driver;

using System;

namespace Repository.Implementations.MongoDb
{
	public class MongoDbRepository : IRepository
	{
		public MongoDbRepository(IServiceProvider serviceprovider) 
		{
			ServiceProvider = serviceprovider;
		}

		protected IServiceProvider ServiceProvider { get; }

		private IMongoDatabase? _Database;
		protected IMongoDatabase Database
		{
			get 
			{
				if (_Database == null)
				{
					MongoDbRepositoryOptions options = ServiceProvider
						.GetRequiredService<IOptions<MongoDbRepositoryOptions>>()
						.Value;

					MongoClientSettings clientsettings = MongoClientSettings.FromConnectionString(options.ConnectionString);

					MongoClient client = new (clientsettings);

					_Database = client.GetDatabase(options.DatabaseName ?? nameof(MongoDbRepository));
				}

				return _Database;
			}
		}

		IMongoCollection<CharacterEntity> CharactersCollection => Database.GetCollection<CharacterEntity>(
			name: "Characters",
			//name: MongoDbRepositoryCollectionNames.Characters,
			settings: new MongoCollectionSettings { });
		IMongoCollection<FactionEntity> FactionsCollection => Database.GetCollection<FactionEntity>(
			name: "Factions",
			//name: MongoDbRepositoryCollectionNames.Factions,
			settings: new MongoCollectionSettings { });
		IMongoCollection<FilmEntity> FilmsCollection => Database.GetCollection<FilmEntity>(
			name: "Films",
			//name: MongoDbRepositoryCollectionNames.Films,
			settings: new MongoCollectionSettings { });
		IMongoCollection<ManufacturerEntity> ManufacturersCollection => Database.GetCollection<ManufacturerEntity>(
			name: "Manufacturers",
			//name: MongoDbRepositoryCollectionNames.Manufacturers,
			settings: new MongoCollectionSettings { });
		IMongoCollection<PlanetEntity> PlanetsCollection => Database.GetCollection<PlanetEntity>(
			name: "Planets",
			//name: MongoDbRepositoryCollectionNames.Planets,
			settings: new MongoCollectionSettings { });
		IMongoCollection<SpecieEntity> SpeciesCollection => Database.GetCollection<SpecieEntity>(
			name: "Species",
			//name: MongoDbRepositoryCollectionNames.Species,
			settings: new MongoCollectionSettings { });
		IMongoCollection<StarshipEntity> StarshipsCollection => Database.GetCollection<StarshipEntity>(
			name: "Starships",
			//name: MongoDbRepositoryCollectionNames.Starships,
			settings: new MongoCollectionSettings { });
		IMongoCollection<VehicleEntity> VehiclesCollection => Database.GetCollection<VehicleEntity>(
			name: "Vehicles",
			//name: MongoDbRepositoryCollectionNames.Vehicles,
			settings: new MongoCollectionSettings { });
		IMongoCollection<WeaponEntity> WeaponsCollection => Database.GetCollection<WeaponEntity>(
			name: "Weapons",
			//name: MongoDbRepositoryCollectionNames.Weapons,
			settings: new MongoCollectionSettings { });

		IRepository.ISet<CharacterEntity>? _Characters;
		IRepository.ISet<FactionEntity>? _Factions;
		IRepository.ISet<FilmEntity>? _Films;
		IRepository.ISet<ManufacturerEntity>? _Manufacturers;
		IRepository.ISet<PlanetEntity>? _Planets;
		IRepository.ISet<SpecieEntity>? _Species;
		IRepository.ISet<StarshipEntity>? _Starships;
		IRepository.ISet<VehicleEntity>? _Vehicles;
		IRepository.ISet<WeaponEntity>? _Weapons;

		public IRepository.ISet<CharacterEntity> Characters => _Characters ??= new MongoDbRepositoryCollection<CharacterEntity>(CharactersCollection);
		public IRepository.ISet<FactionEntity> Factions => _Factions ??= new MongoDbRepositoryCollection<FactionEntity>(FactionsCollection);
		public IRepository.ISet<FilmEntity> Films => _Films ??= new MongoDbRepositoryCollection<FilmEntity>(FilmsCollection);
		public IRepository.ISet<ManufacturerEntity> Manufacturers => _Manufacturers ??= new MongoDbRepositoryCollection<ManufacturerEntity>(ManufacturersCollection);
		public IRepository.ISet<PlanetEntity> Planets => _Planets ??= new MongoDbRepositoryCollection<PlanetEntity>(PlanetsCollection);
		public IRepository.ISet<SpecieEntity> Species => _Species ??= new MongoDbRepositoryCollection<SpecieEntity>(SpeciesCollection);
		public IRepository.ISet<StarshipEntity> Starships => _Starships ??= new MongoDbRepositoryCollection<StarshipEntity>(StarshipsCollection);
		public IRepository.ISet<VehicleEntity> Vehicles => _Vehicles ??= new MongoDbRepositoryCollection<VehicleEntity>(VehiclesCollection);
		public IRepository.ISet<WeaponEntity> Weapons => _Weapons ??= new MongoDbRepositoryCollection<WeaponEntity>(WeaponsCollection);

		public static void Configure(IServiceCollection services, MongoDbRepositoryOptions options)
		{
			MongoClientSettings clientsettings = MongoClientSettings.FromConnectionString(options.ConnectionString);	  

			MongoClient client = new (clientsettings);

			IMongoDatabase mongodatabase = client.GetDatabase(options.DatabaseName ?? nameof(MongoDbRepository));

			services.AddSingleton<IRepository, MongoDbRepository>();
		}
	}
}
