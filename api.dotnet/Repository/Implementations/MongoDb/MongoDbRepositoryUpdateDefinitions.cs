using Domain.Models;

using MongoDB.Bson;
using MongoDB.Driver;

using System;

namespace Repository.Implementations.MongoDb
{
	public class MongoDbRepositoryUpdateDefinitions
	{				
		public static UpdateDefinition<TEntity> UpdateDefinition<TEntity>(TEntity entity) where TEntity : IStarWarsModel
		{
			UpdateDefinition<TEntity>? updatedefinition = null;

			if (entity is ICharacter character)
				updatedefinition = CharacterUpdateDefinition(character) as UpdateDefinition<TEntity>;

			else if (entity is IFaction faction)
				updatedefinition = FactionUpdateDefinition(faction) as UpdateDefinition<TEntity>;

			else if (entity is IFilm film)
				updatedefinition = FilmUpdateDefinition(film) as UpdateDefinition<TEntity>;

			else if (entity is IManufacturer manufacturer)
				updatedefinition = ManufacturerUpdateDefinition(manufacturer) as UpdateDefinition<TEntity>;

			else if (entity is IPlanet planet)
				updatedefinition = PlanetUpdateDefinition(planet) as UpdateDefinition<TEntity>;

			else if (entity is ISpecie specie)
				updatedefinition = SpecieUpdateDefinition(specie) as UpdateDefinition<TEntity>;

			else if (entity is IStarship starship)
				updatedefinition = StarshipUpdateDefinition(starship) as UpdateDefinition<TEntity>;

			else if (entity is IVehicle vehicle)
				updatedefinition = VehicleUpdateDefinition(vehicle) as UpdateDefinition<TEntity>;

			else if (entity is IWeapon weapon)
				updatedefinition = WeaponUpdateDefinition(weapon) as UpdateDefinition<TEntity>;

			return updatedefinition ?? throw new NotImplementedException(string.Format("Star Wars Type '{0}' is not supported", typeof(TEntity)));
		}
		public static UpdateDefinition<ICharacter> CharacterUpdateDefinition(ICharacter character)
		{
			UpdateDefinition<ICharacter> updatedefinitionbuilder = StarWarsModelUpdateDefinition(character).ToBsonDocument();

			updatedefinitionbuilder
				.Set(entity => entity.BirthYear, character.BirthYear)
				.Set(entity => entity.Description, character.Description)
				.Set(entity => entity.EyeColors, character.EyeColors)
				.Set(entity => entity.HairColors, character.HairColors)
				.Set(entity => entity.Height, character.Height)
				.Set(entity => entity.HomeworldId, character.HomeworldId)
				.Set(entity => entity.Mass, character.Mass)
				.Set(entity => entity.Name, character.Name)
				.Set(entity => entity.Sex, character.Sex)
				.Set(entity => entity.SkinColors, character.SkinColors);

			return updatedefinitionbuilder;
		}
		public static UpdateDefinition<IFaction> FactionUpdateDefinition(IFaction faction)
		{
			UpdateDefinition<IFaction> updatedefinitionbuilder = StarWarsModelUpdateDefinition(faction).ToBsonDocument();

			updatedefinitionbuilder
				.Set(entity => entity.AlliedCharacterIds, faction.AlliedCharacterIds)
				.Set(entity => entity.AlliedFactionIds, faction.AlliedFactionIds)
				.Set(entity => entity.Description, faction.Description)
				.Set(entity => entity.LeaderIds, faction.LeaderIds)
				.Set(entity => entity.MemberCharacterIds, faction.MemberCharacterIds)
				.Set(entity => entity.MemberFactionIds, faction.MemberFactionIds)
				.Set(entity => entity.Name, faction.Name)
				.Set(entity => entity.OrganizationTypes, faction.OrganizationTypes);

			return updatedefinitionbuilder;
		}
		public static UpdateDefinition<IFilm> FilmUpdateDefinition(IFilm film)
		{
			UpdateDefinition<IFilm> updatedefinitionbuilder = StarWarsModelUpdateDefinition(film).ToBsonDocument();

			updatedefinitionbuilder
				.Set(entity => entity.CastMembers, film.CastMembers)
				.Set(entity => entity.CharacterIds, film.CharacterIds)
				.Set(entity => entity.Description, film.Description)
				.Set(entity => entity.Director, film.Director)
				.Set(entity => entity.Duration, film.Duration)
				.Set(entity => entity.EpisodeId, film.EpisodeId)
				.Set(entity => entity.FactionIds, film.FactionIds)
				.Set(entity => entity.ManufacturerIds, film.ManufacturerIds)
				.Set(entity => entity.OpeningCrawl, film.OpeningCrawl)
				.Set(entity => entity.PlanetIds, film.PlanetIds)
				.Set(entity => entity.Producers, film.Producers)
				.Set(entity => entity.ReleaseDate, film.ReleaseDate)
				.Set(entity => entity.SpecieIds, film.SpecieIds)
				.Set(entity => entity.StarshipIds, film.StarshipIds)
				.Set(entity => entity.Title, film.Title)
				.Set(entity => entity.VehicleIds, film.VehicleIds)
				.Set(entity => entity.WeaponIds, film.WeaponIds);

			return updatedefinitionbuilder;
		}
		public static UpdateDefinition<IManufacturer> ManufacturerUpdateDefinition(IManufacturer manufacturer)
		{
			UpdateDefinition<IManufacturer> updatedefinitionbuilder = StarWarsModelUpdateDefinition(manufacturer).ToBsonDocument();

			updatedefinitionbuilder
				.Set(entity => entity.Description, manufacturer.Description)
				.Set(entity => entity.HeadquatersPlanetId, manufacturer.HeadquatersPlanetId)
				.Set(entity => entity.Name, manufacturer.Name)
				.Set(entity => entity.StarshipIds, manufacturer.StarshipIds)
				.Set(entity => entity.VehicleIds, manufacturer.VehicleIds)
				.Set(entity => entity.WeaponIds, manufacturer.WeaponIds);

			return updatedefinitionbuilder;
		}
		public static UpdateDefinition<IPlanet> PlanetUpdateDefinition(IPlanet planet)
		{
			UpdateDefinition<IPlanet> updatedefinitionbuilder = StarWarsModelUpdateDefinition(planet).ToBsonDocument();

			updatedefinitionbuilder
				.Set(entity => entity.Climates, planet.Climates)
				.Set(entity => entity.Description, planet.Description)
				.Set(entity => entity.Diameter, planet.Diameter)
				.Set(entity => entity.Gravity, planet.Gravity)
				.Set(entity => entity.Name, planet.Name)
				.Set(entity => entity.OrbitalPeriod, planet.OrbitalPeriod)
				.Set(entity => entity.Population, planet.Population)
				.Set(entity => entity.ResidentIds, planet.ResidentIds)
				.Set(entity => entity.RotationalPeriod, planet.RotationalPeriod)
				.Set(entity => entity.SurfaceWater, planet.SurfaceWater)
				.Set(entity => entity.Terrains, planet.Terrains);

			return updatedefinitionbuilder;
		}
		public static UpdateDefinition<ISpecie> SpecieUpdateDefinition(ISpecie specie)
		{
			UpdateDefinition<ISpecie> updatedefinitionbuilder = StarWarsModelUpdateDefinition(specie).ToBsonDocument();

			updatedefinitionbuilder
				.Set(entity => entity.AverageHeight, specie.AverageHeight)
				.Set(entity => entity.AverageLifespan, specie.AverageLifespan)
				.Set(entity => entity.CharacterIds, specie.CharacterIds)
				.Set(entity => entity.Classification, specie.Classification)
				.Set(entity => entity.Description, specie.Description)
				.Set(entity => entity.Designation, specie.Designation)
				.Set(entity => entity.EyeColors, specie.EyeColors)
				.Set(entity => entity.HairColors, specie.HairColors)
				.Set(entity => entity.HomeworldId, specie.HomeworldId)
				.Set(entity => entity.Language, specie.Language)
				.Set(entity => entity.Name, specie.Name)
				.Set(entity => entity.SkinColors, specie.SkinColors);

			return updatedefinitionbuilder;
		}
		public static UpdateDefinition<IStarship> StarshipUpdateDefinition(IStarship starship)
		{
			UpdateDefinition<IStarship> updatedefinitionbuilder = TransporterUpdateDefinition(starship).ToBsonDocument();

			updatedefinitionbuilder
				.Set(entity => entity.HyperdriveRating, starship.HyperdriveRating)
				.Set(entity => entity.MGLT, starship.MGLT)
				.Set(entity => entity.StarshipClass, starship.StarshipClass);

			return updatedefinitionbuilder;
		}
		public static UpdateDefinition<IStarWarsModel> StarWarsModelUpdateDefinition(IStarWarsModel starwarsmodel)
		{
			UpdateDefinition<IStarWarsModel> updatedefinitionbuilder = new UpdateDefinitionBuilder<IStarWarsModel>()
				.Set(entity => entity.Created, starwarsmodel.Created)
				.Set(entity => entity.Edited, DateTime.Now)
				.Set(entity => entity.Id, starwarsmodel.Id)
				.Set(entity => entity.Uris, starwarsmodel.Uris);

			return updatedefinitionbuilder;
		}
		public static UpdateDefinition<ITransporter> TransporterUpdateDefinition(ITransporter transporter)
		{
			UpdateDefinition<ITransporter> updatedefinitionbuilder = StarWarsModelUpdateDefinition(transporter).ToBsonDocument();

			updatedefinitionbuilder
				.Set(entity => entity.CargoCapacity, transporter.CargoCapacity)
				.Set(entity => entity.Consumables, transporter.Consumables)
				.Set(entity => entity.CostInCredits, transporter.CostInCredits)
				.Set(entity => entity.Description, transporter.Description)
				.Set(entity => entity.Length, transporter.Length)
				.Set(entity => entity.ManufacturerIds, transporter.ManufacturerIds)
				.Set(entity => entity.MaxAtmospheringSpeed, transporter.MaxAtmospheringSpeed)
				.Set(entity => entity.MaxCrew, transporter.MaxCrew)
				.Set(entity => entity.MinCrew, transporter.MinCrew)
				.Set(entity => entity.Model, transporter.Model)
				.Set(entity => entity.Name, transporter.Name)
				.Set(entity => entity.Passengers, transporter.Passengers)
				.Set(entity => entity.PilotIds, transporter.PilotIds);

			return updatedefinitionbuilder;
		}
		public static UpdateDefinition<IVehicle> VehicleUpdateDefinition(IVehicle vehicle)
		{
			UpdateDefinition<IVehicle> updatedefinitionbuilder = TransporterUpdateDefinition(vehicle).ToBsonDocument();

			updatedefinitionbuilder
				.Set(entity => entity.VehicleClass, vehicle.VehicleClass);

			return updatedefinitionbuilder;
		}
		public static UpdateDefinition<IWeapon> WeaponUpdateDefinition(IWeapon weapon)
		{
			UpdateDefinition<IWeapon> updatedefinitionbuilder = StarWarsModelUpdateDefinition(weapon).ToBsonDocument();

			updatedefinitionbuilder
				.Set(entity => entity.Description, weapon.Description)
				.Set(entity => entity.ManufacturerIds, weapon.ManufacturerIds)
				.Set(entity => entity.Model, weapon.Model)
				.Set(entity => entity.Name, weapon.Name)
				.Set(entity => entity.WeaponClass, weapon.WeaponClass);

			return updatedefinitionbuilder;
		}
	}
}
