﻿using Repository.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using System;

namespace Repository.Implementations.MySQL
{
	public class MySQLRepository : IRepository
	{
		public MySQLRepository(IServiceProvider servicesrovider)
		{
			ServiceProvider = servicesrovider;
		}

		protected IServiceProvider ServiceProvider { get; }
		protected MySQLRepositoryDbContext DB => ServiceProvider.GetRequiredService<MySQLRepositoryDbContext>();

		IRepository.ISet<CharacterEntity>? _Characters;
		IRepository.ISet<FactionEntity>? _Factions;
		IRepository.ISet<FilmEntity>? _Films;
		IRepository.ISet<ManufacturerEntity>? _Manufacturers;
		IRepository.ISet<PlanetEntity>? _Planets;
		IRepository.ISet<SpecieEntity>? _Species;
		IRepository.ISet<StarshipEntity>? _Starships;
		IRepository.ISet<VehicleEntity>? _Vehicles;
		IRepository.ISet<WeaponEntity>? _Weapons;

		public IRepository.ISet<CharacterEntity> Characters => _Characters ??= new RepositoryDbSet<CharacterEntity>(DB.Characters, DB);
		public IRepository.ISet<FactionEntity> Factions => _Factions ??= new RepositoryDbSet<FactionEntity>(DB.Factions, DB);
		public IRepository.ISet<FilmEntity> Films => _Films ??= new RepositoryDbSet<FilmEntity>(DB.Films, DB);
		public IRepository.ISet<ManufacturerEntity> Manufacturers => _Manufacturers ??= new RepositoryDbSet<ManufacturerEntity>(DB.Manufacturers, DB);
		public IRepository.ISet<PlanetEntity> Planets => _Planets ??= new RepositoryDbSet<PlanetEntity>(DB.Planets, DB);
		public IRepository.ISet<SpecieEntity> Species => _Species ??= new RepositoryDbSet<SpecieEntity>(DB.Species, DB);
		public IRepository.ISet<StarshipEntity> Starships => _Starships ??= new RepositoryDbSet<StarshipEntity>(DB.Starships, DB);
		public IRepository.ISet<VehicleEntity> Vehicles => _Vehicles ??= new RepositoryDbSet<VehicleEntity>(DB.Vehicles, DB);
		public IRepository.ISet<WeaponEntity> Weapons => _Weapons ??= new RepositoryDbSet<WeaponEntity>(DB.Weapons, DB);

		public static void Configure(IServiceCollection services, MySQLRepositoryOptions options)
		{
			if (options.ConnectionString is null)
				throw new ArgumentException("MySQLRepository requires a connection string in the 'MySQLRepositoryOptions' options");

			services.AddDbContext<MySQLRepositoryDbContext>(
				optionsLifetime: ServiceLifetime.Singleton,
				contextLifetime: ServiceLifetime.Singleton,
				optionsAction: dbcontextoptionsbuilder =>
				{
					dbcontextoptionsbuilder.EnableSensitiveDataLogging();
					dbcontextoptionsbuilder.UseLoggerFactory(LoggerFactory.Create(loggingBuilder =>
					{
						loggingBuilder.AddConsole();
						loggingBuilder.SetMinimumLevel(LogLevel.Trace);
					}));
					dbcontextoptionsbuilder.UseMySQL(
						connectionString: options.ConnectionString,
						mySqlOptionsAction: options.DbContextOptions);
				});

			services.AddSingleton<IRepository, MySQLRepository>();
		}
	}
}
