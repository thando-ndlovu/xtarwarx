using Api.Repository.Options;

using Domain.Models;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

using Repository;
using Repository.Entities;
using Repository.Data.Json.Utils;

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Repository.Services
{
	public class RepositoryStartup : IHostedService
	{
		public RepositoryStartup(IServiceProvider serviceProvider)
		{
			ServiceProvider = serviceProvider;
		}

		public IServiceProvider ServiceProvider { get; }

		public virtual async Task StartAsync(CancellationToken cancellationToken)
		{
			using IServiceScope ServiceScope = ServiceProvider.CreateScope();

			IRepository Repository = ServiceProvider
				.GetRequiredService<IRepository>();

			RepositoryOptions Options = ServiceScope.ServiceProvider
				.GetRequiredService<IOptions<RepositoryOptions>>()
				.Value;

			#region Character

			CharacterEntity[] characterentities = CharacterUtils
				.Data()
				.Concat(Options.SeedCharacters ?? Enumerable.Empty<ICharacter>())
				.Select(_ => new CharacterEntity(_))
				.ToArray();

			await foreach (CharacterEntity _ in Repository.Characters.Create(cancellationToken, characterentities)) { }

			#endregion

			#region Factions

			FactionEntity[] factionentities = FactionUtils
				.Data()
				.Concat(Options.SeedFactions ?? Enumerable.Empty<IFaction>())
				.Select(_ => new FactionEntity(_))
				.ToArray();

			await foreach (FactionEntity _ in Repository.Factions.Create(cancellationToken, factionentities)) { }

			#endregion

			#region Films

			FilmEntity[] filmentities = FilmUtils
				.Data()
				.Concat(Options.SeedFilms ?? Enumerable.Empty<IFilm>())
				.Select(_ => new FilmEntity(_))
				.ToArray();

			await foreach (FilmEntity _ in Repository.Films.Create(cancellationToken, filmentities)) { }

			#endregion								

			#region Manufacturers

			ManufacturerEntity[] manufacturerentities = ManufacturerUtils
				.Data()
				.Concat(Options.SeedManufacturers ?? Enumerable.Empty<IManufacturer>())
				.Select(_ => new ManufacturerEntity(_))
				.ToArray();

			await foreach (ManufacturerEntity _ in Repository.Manufacturers.Create(cancellationToken, manufacturerentities)) { }

			#endregion

			#region Planets

			PlanetEntity[] planetentities = PlanetUtils
				.Data()
				.Concat(Options.SeedPlanets ?? Enumerable.Empty<IPlanet>())
				.Select(_ => new PlanetEntity(_))
				.ToArray();

			await foreach (PlanetEntity _ in Repository.Planets.Create(cancellationToken, planetentities)) { }

			#endregion

			#region Species

			SpecieEntity[] specieentities = SpecieUtils
				.Data()
				.Concat(Options.SeedSpecies ?? Enumerable.Empty<ISpecie>())
				.Select(_ => new SpecieEntity(_))
				.ToArray();

			await foreach (SpecieEntity _ in Repository.Species.Create(cancellationToken, specieentities)) { }

			#endregion

			#region Starships

			StarshipEntity[] starshipentities = StarshipUtils
				.Data()
				.Concat(Options.SeedStarships ?? Enumerable.Empty<IStarship>())
				.Select(_ => new StarshipEntity(_))
				.ToArray();

			await foreach (StarshipEntity _ in Repository.Starships.Create(cancellationToken, starshipentities)) { }

			#endregion

			#region Vehicles

			VehicleEntity[] vehicleentities = VehicleUtils
				.Data()
				.Concat(Options.SeedVehicles ?? Enumerable.Empty<IVehicle>())
				.Select(_ => new VehicleEntity(_))
				.ToArray();

			await foreach (VehicleEntity _ in Repository.Vehicles.Create(cancellationToken, vehicleentities)) { }

			#endregion

			#region Weapons

			WeaponEntity[] weaponentities = WeaponUtils
				.Data()
				.Concat(Options.SeedWeapons ?? Enumerable.Empty<IWeapon>())
				.Select(_ => new WeaponEntity(_))
				.ToArray();

			await foreach (WeaponEntity _ in Repository.Weapons.Create(cancellationToken, weaponentities)) { }

			#endregion
		}
		public virtual async Task StopAsync(CancellationToken cancellationToken)
		{
			await Task.CompletedTask;
		}
	}
}
