using Domain.Models;

using System;
using System.Linq;

namespace Api.Queries
{
	public static class IQueryExtensions
	{
		private static string? DateTimeToString(DateTime? dateTime)
		{
			if (dateTime is null)
				return null;

			return string.Format(
				"{0}/{1}/{2}",
				dateTime.Value.Day.ToString("00"),
				dateTime.Value.Month.ToString("00"),
				dateTime.Value.Year.ToString("0000"));
		}

		public static object ToObject(this ICharacter character)
		{
			return new
			{
				character.Id,
				Created = DateTimeToString(character.Created),
				Edited = DateTimeToString(character.Edited),
				character.BirthYear,
				character.Description,
				EyeColors = character.EyeColors?.Select(knowncolor => knowncolor.ToString()),
				HairColors = character.HairColors?.Select(knowncolor => knowncolor.ToString()),
				character.Height,
				character.Mass,
				character.Name,
				character.Sex,
				SkinColors = character.SkinColors?.Select(knowncolor => knowncolor.ToString()),
				character.Uris,
			};
		}
		public static object ToObject(this IFaction faction)
		{
			return new
			{
				faction.Id,
				Created = DateTimeToString(faction.Created),
				Edited = DateTimeToString(faction.Edited),
				faction.AlliedCharacterIds,
				faction.AlliedFactionIds,
				faction.Description,
				faction.LeaderIds,
				faction.MemberCharacterIds,
				faction.MemberFactionIds,
				faction.Name,
				faction.OrganizationTypes,
				faction.Uris,
			};
		}
		public static object ToObject(this IFilm film)
		{
			return new
			{
				film.Id,
				Created = DateTimeToString(film.Created),
				Edited = DateTimeToString(film.Edited),
				film.CastMembers,
				film.CharacterIds,
				film.Description,
				film.Director,
				Duration = film.Duration?.TotalMinutes,
				film.EpisodeId,
				film.FactionIds,
				film.ManufacturerIds,
				film.OpeningCrawl,
				film.PlanetIds,
				film.Producers,
				ReleaseDate = DateTimeToString(film.ReleaseDate),
				film.SpecieIds,
				film.StarshipIds,
				film.Title,
				film.Uris,
			};
		}
		public static object ToObject(this IManufacturer manufacturer)
		{
			return new
			{
				manufacturer.Id,
				Created = DateTimeToString(manufacturer.Created),
				Edited = DateTimeToString(manufacturer.Edited),
				manufacturer.Description,
				manufacturer.HeadquatersPlanetId,
				manufacturer.Name,
				manufacturer.StarshipIds,
				manufacturer.VehicleIds,
				manufacturer.WeaponIds,
				manufacturer.Uris,
			};
		}
		public static object ToObject(this IPlanet planet)
		{
			return new
			{
				planet.Id,
				Created = DateTimeToString(planet.Created),
				Edited = DateTimeToString(planet.Edited),
				planet.Climates,
				planet.Description,
				planet.Diameter,
				planet.Gravity,
				planet.Name,
				OrbitalPeriod = planet.OrbitalPeriod?.TotalDays,
				planet.Population,
				planet.ResidentIds,
				RotationalPeriod = planet.RotationalPeriod?.TotalHours,
				planet.SurfaceWater,
				planet.Terrains,
				planet.Uris,
			};
		}
		public static object ToObject(this ISpecie specie)
		{
			return new
			{
				specie.Id,
				Created = DateTimeToString(specie.Created),
				Edited = DateTimeToString(specie.Edited),
				specie.AverageHeight,
				specie.AverageLifespan,
				specie.CharacterIds,
				specie.Classification,
				specie.Description,
				specie.Designation,
				EyeColors = specie.EyeColors?.Select(knowncolor => knowncolor.ToString()),
				HairColors = specie.HairColors?.Select(knowncolor => knowncolor.ToString()),
				specie.HomeworldId,
				specie.Language,
				specie.Name,
				SkinColors = specie.SkinColors?.Select(knowncolor => knowncolor.ToString()),
				specie.Uris,
			};
		}
		public static object ToObject(this IStarship starship)
		{
			return new
			{
				starship.Id,
				Created = DateTimeToString(starship.Created),
				Edited = DateTimeToString(starship.Edited),
				starship.CargoCapacity,
				starship.Consumables,
				starship.CostInCredits,
				starship.Description,
				starship.HyperdriveRating,
				starship.Length,
				starship.ManufacturerIds,
				starship.MaxAtmospheringSpeed,
				starship.MaxCrew,
				starship.MinCrew,
				starship.MGLT,
				starship.Model,
				starship.Name,
				starship.Passengers,
				starship.PilotIds,
				starship.StarshipClass,
				starship.Uris,
			};
		}
		public static object ToObject(this IVehicle vehicle)
		{
			return new
			{
				vehicle.Id,
				Created = DateTimeToString(vehicle.Created),
				Edited = DateTimeToString(vehicle.Edited),
				vehicle.CargoCapacity,
				vehicle.Consumables,
				vehicle.CostInCredits,
				vehicle.Description,
				vehicle.Length,
				vehicle.ManufacturerIds,
				vehicle.MaxAtmospheringSpeed,
				vehicle.MaxCrew,
				vehicle.MinCrew,
				vehicle.Model,
				vehicle.Name,
				vehicle.Passengers,
				vehicle.PilotIds,
				vehicle.VehicleClass,
				vehicle.Uris,
			};
		}
		public static object ToObject(this IWeapon weapon)
		{
			return new
			{
				weapon.Id,
				Created = DateTimeToString(weapon.Created),
				Edited = DateTimeToString(weapon.Edited),
				weapon.Description,
				weapon.ManufacturerIds,
				weapon.Model,
				weapon.Name,
				weapon.WeaponClass,
				weapon.Uris,
			};
		}

		public static IQuery.IResult<ICharacter> ProcessCharacters(this IQuery query, IQueryable<ICharacter> characters)
		{
			characters = query.ProcessCharacters(characters, out int? page, out int? pages);

			return new IQuery.IResult.Default<ICharacter>
			{
				Page = page,
				Pages = pages,
				Items = characters,
			};
		}
		public static IQuery.IResult<object> ProcessCharactersAsObject(this IQuery query, IQueryable<ICharacter> characters)
		{
			characters = query.ProcessCharacters(characters, out int? page, out int? pages);

			return new IQuery.IResult.Default<object>
			{
				Page = page,
				Pages = pages,
				Items = characters.Select(_ => _.ToObject()),
			};
		}
		public static IQueryable<ICharacter> ProcessCharacters(this IQuery query, IQueryable<ICharacter> characters, out int? page, out int? pages)
		{
			if (query.Ids != null)
				characters = characters.Where(character => query.Ids.Contains(character.Id));

			query.GetPaginationValues(characters.Count(), out int? outpage, out int? outpages, out int? outskipcount, out int? outitemsperpage);

			characters = ICharacter.ISortKeys.Keys.AsEnumerable()
				.FirstOrDefault(key => string.Equals(key, query.OrderBy, StringComparison.OrdinalIgnoreCase)) is string sortkey
					? ICharacter.ISortKeys.Keys.Sort(characters, sortkey)
					: ICharacter.ISortKeys.Keys.Sort(characters, IStarWarsModel.ISortKeys.Keys.Id);

			if (outskipcount.HasValue) characters = characters.Skip(outskipcount.Value);
			if (outitemsperpage.HasValue) characters = characters.Take(outitemsperpage.Value);

			page = outpage;
			pages = outpages;

			if (query.IdsToSkip?.Any() ?? false)
				characters = characters.Select(_ => query.IdsToSkip.Contains(_.Id) ? new ICharacter.Default(_.Id) : _);

			return characters;
		}

		public static IQuery.IResult<IFaction> ProcessFactions(this IQuery query, IQueryable<IFaction> factions)
		{
			factions = query.ProcessFactions(factions, out int? page, out int? pages);

			return new IQuery.IResult.Default<IFaction>
			{
				Page = page,
				Pages = pages,
				Items = factions,
			};
		}
		public static IQuery.IResult<object> ProcessFactionsAsObject(this IQuery query, IQueryable<IFaction> factions)
		{
			factions = query.ProcessFactions(factions, out int? page, out int? pages);

			return new IQuery.IResult.Default<object>
			{
				Page = page,
				Pages = pages,
				Items = factions.Select(_ => _.ToObject()),
			};
		}
		public static IQueryable<IFaction> ProcessFactions(this IQuery query, IQueryable<IFaction> factions, out int? page, out int? pages)
		{
			if (query.Ids != null)
				factions = factions.Where(faction => query.Ids.Contains(faction.Id));

			query.GetPaginationValues(factions.Count(), out int? outpage, out int? outpages, out int? outskipcount, out int? outitemsperpage);

			factions = IFaction.ISortKeys.Keys.AsEnumerable()
				.FirstOrDefault(key => string.Equals(key, query.OrderBy, StringComparison.OrdinalIgnoreCase)) is string sortkey
					? IFaction.ISortKeys.Keys.Sort(factions, sortkey)
					: IFaction.ISortKeys.Keys.Sort(factions, IStarWarsModel.ISortKeys.Keys.Id);

			if (outskipcount.HasValue) factions = factions.Skip(outskipcount.Value);
			if (outitemsperpage.HasValue) factions = factions.Take(outitemsperpage.Value);

			page = outpage;
			pages = outpages;

			if (query.IdsToSkip?.Any() ?? false)
				factions = factions.Select(_ => query.IdsToSkip.Contains(_.Id) ? new IFaction.Default(_.Id) : _);

			return factions;
		}

		public static IQuery.IResult<IFilm> ProcessFilms(this IQuery query, IQueryable<IFilm> films)
		{
			films = query.ProcessFilms(films, out int? page, out int? pages);

			return new IQuery.IResult.Default<IFilm>
			{
				Page = page,
				Pages = pages,
				Items = films,
			};
		}
		public static IQuery.IResult<object> ProcessFilmsAsObject(this IQuery query, IQueryable<IFilm> films)
		{
			films = query.ProcessFilms(films, out int? page, out int? pages);

			return new IQuery.IResult.Default<object>
			{
				Page = page,
				Pages = pages,
				Items = films.Select(_ => _.ToObject()),
			};
		}
		public static IQueryable<IFilm> ProcessFilms(this IQuery query, IQueryable<IFilm> films, out int? page, out int? pages)
		{
			if (query.Ids != null)
				films = films.Where(film => query.Ids.Contains(film.Id));

			query.GetPaginationValues(films.Count(), out int? outpage, out int? outpages, out int? outskipcount, out int? outitemsperpage);

			films = IFilm.ISortKeys.Keys.AsEnumerable()
				.FirstOrDefault(key => string.Equals(key, query.OrderBy, StringComparison.OrdinalIgnoreCase)) is string sortkey
					? IFilm.ISortKeys.Keys.Sort(films, sortkey)
					: IFilm.ISortKeys.Keys.Sort(films, IStarWarsModel.ISortKeys.Keys.Id);

			if (outskipcount.HasValue) films = films.Skip(outskipcount.Value);
			if (outitemsperpage.HasValue) films = films.Take(outitemsperpage.Value);

			page = outpage;
			pages = outpages;

			if (query.IdsToSkip?.Any() ?? false)
				films = films.Select(_ => query.IdsToSkip.Contains(_.Id) ? new IFilm.Default(_.Id) : _);

			return films;
		}

		public static IQuery.IResult<IManufacturer> ProcessManufacturers(this IQuery query, IQueryable<IManufacturer> manufacturers)
		{
			manufacturers = query.ProcessManufacturers(manufacturers, out int? page, out int? pages);

			return new IQuery.IResult.Default<IManufacturer>
			{
				Page = page,
				Pages = pages,
				Items = manufacturers,
			};
		}
		public static IQuery.IResult<object> ProcessManufacturersAsObject(this IQuery query, IQueryable<IManufacturer> manufacturers)
		{
			manufacturers = query.ProcessManufacturers(manufacturers, out int? page, out int? pages);

			return new IQuery.IResult.Default<object>
			{
				Page = page,
				Pages = pages,
				Items = manufacturers.Select(_ => _.ToObject()),
			};
		}
		public static IQueryable<IManufacturer> ProcessManufacturers(this IQuery query, IQueryable<IManufacturer> manufacturers, out int? page, out int? pages)
		{
			if (query.Ids != null)
				manufacturers = manufacturers.Where(manufacturer => query.Ids.Contains(manufacturer.Id));

			query.GetPaginationValues(manufacturers.Count(), out int? outpage, out int? outpages, out int? outskipcount, out int? outitemsperpage);

			manufacturers = IManufacturer.ISortKeys.Keys.AsEnumerable()
				.FirstOrDefault(key => string.Equals(key, query.OrderBy, StringComparison.OrdinalIgnoreCase)) is string sortkey
					? IManufacturer.ISortKeys.Keys.Sort(manufacturers, sortkey)
					: IManufacturer.ISortKeys.Keys.Sort(manufacturers, IStarWarsModel.ISortKeys.Keys.Id);

			if (outskipcount.HasValue) manufacturers = manufacturers.Skip(outskipcount.Value);
			if (outitemsperpage.HasValue) manufacturers = manufacturers.Take(outitemsperpage.Value);

			page = outpage;
			pages = outpages;

			if (query.IdsToSkip?.Any() ?? false)
				manufacturers = manufacturers.Select(_ => query.IdsToSkip.Contains(_.Id) ? new IManufacturer.Default(_.Id) : _);

			return manufacturers;
		}

		public static IQuery.IResult<IPlanet> ProcessPlanets(this IQuery query, IQueryable<IPlanet> planets)
		{
			planets = query.ProcessPlanets(planets, out int? page, out int? pages);
			return new IQuery.IResult.Default<IPlanet> { Page = page, Pages = pages, Items = planets };
		}
		public static IQuery.IResult<object> ProcessPlanetsAsObject(this IQuery query, IQueryable<IPlanet> planets)
		{
			planets = query.ProcessPlanets(planets, out int? page, out int? pages);

			return new IQuery.IResult.Default<object>
			{
				Page = page,
				Pages = pages,
				Items = planets.Select(_ => _.ToObject()),
			};
		}
		public static IQueryable<IPlanet> ProcessPlanets(this IQuery query, IQueryable<IPlanet> planets, out int? page, out int? pages)
		{
			if (query.Ids != null)
				planets = planets.Where(planet => query.Ids.Contains(planet.Id));

			query.GetPaginationValues(planets.Count(), out int? outpage, out int? outpages, out int? outskipcount, out int? outitemsperpage);

			planets = IPlanet.ISortKeys.Keys.AsEnumerable()
				.FirstOrDefault(key => string.Equals(key, query.OrderBy, StringComparison.OrdinalIgnoreCase)) is string sortkey
					? IPlanet.ISortKeys.Keys.Sort(planets, sortkey)
					: IPlanet.ISortKeys.Keys.Sort(planets, IStarWarsModel.ISortKeys.Keys.Id);

			if (outskipcount.HasValue) planets = planets.Skip(outskipcount.Value);
			if (outitemsperpage.HasValue) planets = planets.Take(outitemsperpage.Value);

			page = outpage;
			pages = outpages;

			if (query.IdsToSkip?.Any() ?? false)
				planets = planets.Select(_ => query.IdsToSkip.Contains(_.Id) ? new IPlanet.Default(_.Id) : _);

			return planets;
		}

		public static IQuery.IResult<ISpecie> ProcessSpecies(this IQuery query, IQueryable<ISpecie> species)
		{
			species = query.ProcessSpecies(species, out int? page, out int? pages);
			return new IQuery.IResult.Default<ISpecie> { Page = page, Pages = pages, Items = species };
		}
		public static IQuery.IResult<object> ProcessSpeciesAsObject(this IQuery query, IQueryable<ISpecie> species)
		{
			species = query.ProcessSpecies(species, out int? page, out int? pages);

			return new IQuery.IResult.Default<object>
			{
				Page = page,
				Pages = pages,
				Items = species.Select(_ => _.ToObject()),
			};
		}
		public static IQueryable<ISpecie> ProcessSpecies(this IQuery query, IQueryable<ISpecie> species, out int? page, out int? pages)
		{
			if (query.Ids != null)
				species = species.Where(specie => query.Ids.Contains(specie.Id));

			query.GetPaginationValues(species.Count(), out int? outpage, out int? outpages, out int? outskipcount, out int? outitemsperpage);

			species = ISpecie.ISortKeys.Keys.AsEnumerable()
				.FirstOrDefault(key => string.Equals(key, query.OrderBy, StringComparison.OrdinalIgnoreCase)) is string sortkey
					? ISpecie.ISortKeys.Keys.Sort(species, sortkey)
					: ISpecie.ISortKeys.Keys.Sort(species, IStarWarsModel.ISortKeys.Keys.Id);

			if (outskipcount.HasValue) species = species.Skip(outskipcount.Value);
			if (outitemsperpage.HasValue) species = species.Take(outitemsperpage.Value);

			page = outpage;
			pages = outpages;

			if (query.IdsToSkip?.Any() ?? false)
				species = species.Select(_ => query.IdsToSkip.Contains(_.Id) ? new ISpecie.Default(_.Id) : _);

			return species;
		}

		public static IQuery.IResult<IStarship> ProcessStarships(this IQuery query, IQueryable<IStarship> starships)
		{
			starships = query.ProcessStarships(starships, out int? page, out int? pages);
			return new IQuery.IResult.Default<IStarship> { Page = page, Pages = pages, Items = starships };
		}
		public static IQuery.IResult<object> ProcessStarshipsAsObject(this IQuery query, IQueryable<IStarship> starships)
		{
			starships = query.ProcessStarships(starships, out int? page, out int? pages);

			return new IQuery.IResult.Default<object>
			{
				Page = page,
				Pages = pages,
				Items = starships.Select(_ => _.ToObject()),
			};
		}
		public static IQueryable<IStarship> ProcessStarships(this IQuery query, IQueryable<IStarship> starships, out int? page, out int? pages)
		{
			if (query.Ids != null)
				starships = starships.Where(starship => query.Ids.Contains(starship.Id));

			query.GetPaginationValues(starships.Count(), out int? outpage, out int? outpages, out int? outskipcount, out int? outitemsperpage);

			starships = IStarship.ISortKeys.Keys.AsEnumerable()
				.FirstOrDefault(key => string.Equals(key, query.OrderBy, StringComparison.OrdinalIgnoreCase)) is string sortkey
					? IStarship.ISortKeys.Keys.Sort(starships, sortkey)
					: IStarship.ISortKeys.Keys.Sort(starships, IStarWarsModel.ISortKeys.Keys.Id);

			if (outskipcount.HasValue) starships = starships.Skip(outskipcount.Value);
			if (outitemsperpage.HasValue) starships = starships.Take(outitemsperpage.Value);

			page = outpage;
			pages = outpages;

			if (query.IdsToSkip?.Any() ?? false)
				starships = starships.Select(_ => query.IdsToSkip.Contains(_.Id) ? new IStarship.Default(_.Id) : _);

			return starships;
		}

		public static IQuery.IResult<IVehicle> ProcessVehicles(this IQuery query, IQueryable<IVehicle> vehicles)
		{
			vehicles = query.ProcessVehicles(vehicles, out int? page, out int? pages);
			return new IQuery.IResult.Default<IVehicle> { Page = page, Pages = pages, Items = vehicles };
		}
		public static IQuery.IResult<object> ProcessVehiclesAsObject(this IQuery query, IQueryable<IVehicle> vehicles)
		{
			vehicles = query.ProcessVehicles(vehicles, out int? page, out int? pages);

			return new IQuery.IResult.Default<object>
			{
				Page = page,
				Pages = pages,
				Items = vehicles.Select(_ => _.ToObject())
			};
		}
		public static IQueryable<IVehicle> ProcessVehicles(this IQuery query, IQueryable<IVehicle> vehicles, out int? page, out int? pages)
		{
			if (query.Ids != null)
				vehicles = vehicles.Where(vehicle => query.Ids.Contains(vehicle.Id));

			query.GetPaginationValues(vehicles.Count(), out int? outpage, out int? outpages, out int? outskipcount, out int? outitemsperpage);

			vehicles = IVehicle.ISortKeys.Keys.AsEnumerable()
				.FirstOrDefault(key => string.Equals(key, query.OrderBy, StringComparison.OrdinalIgnoreCase)) is string sortkey
					? IVehicle.ISortKeys.Keys.Sort(vehicles, sortkey)
					: IVehicle.ISortKeys.Keys.Sort(vehicles, IStarWarsModel.ISortKeys.Keys.Id);

			if (outskipcount.HasValue) vehicles = vehicles.Skip(outskipcount.Value);
			if (outitemsperpage.HasValue) vehicles = vehicles.Take(outitemsperpage.Value);

			page = outpage;
			pages = outpages;

			if (query.IdsToSkip?.Any() ?? false)
				vehicles = vehicles.Select(_ => query.IdsToSkip.Contains(_.Id) ? new IVehicle.Default(_.Id) : _);

			return vehicles;
		}

		public static IQuery.IResult<IWeapon> ProcessWeapons(this IQuery query, IQueryable<IWeapon> weapons)
		{
			weapons = query.ProcessWeapons(weapons, out int? page, out int? pages);
			return new IQuery.IResult.Default<IWeapon> { Page = page, Pages = pages, Items = weapons };
		}
		public static IQuery.IResult<object> ProcessWeaponsAsObject(this IQuery query, IQueryable<IWeapon> weapons)
		{
			weapons = query.ProcessWeapons(weapons, out int? page, out int? pages);

			return new IQuery.IResult.Default<object>
			{
				Page = page,
				Pages = pages,
				Items = weapons.Select(_ => _.ToObject())
			};
		}
		public static IQueryable<IWeapon> ProcessWeapons(this IQuery query, IQueryable<IWeapon> weapons, out int? page, out int? pages)
		{
			if (query.Ids != null)
				weapons = weapons.Where(weapon => query.Ids.Contains(weapon.Id));

			query.GetPaginationValues(weapons.Count(), out int? outpage, out int? outpages, out int? outskipcount, out int? outitemsperpage);

			weapons = IWeapon.ISortKeys.Keys.AsEnumerable()
				.FirstOrDefault(key => string.Equals(key, query.OrderBy, StringComparison.OrdinalIgnoreCase)) is string sortkey
					? IWeapon.ISortKeys.Keys.Sort(weapons, sortkey)
					: IWeapon.ISortKeys.Keys.Sort(weapons, IStarWarsModel.ISortKeys.Keys.Id);

			if (outskipcount.HasValue) weapons = weapons.Skip(outskipcount.Value);
			if (outitemsperpage.HasValue) weapons = weapons.Take(outitemsperpage.Value);

			page = outpage;
			pages = outpages;

			if (query.IdsToSkip?.Any() ?? false)
				weapons = weapons.Select(_ => query.IdsToSkip.Contains(_.Id) ? new IWeapon.Default(_.Id) : _);

			return weapons;
		}

		public static void GetPaginationValues(this IQuery query, int itemscount, out int? page, out int? pages, out int? skipcount, out int? itemsperpage)
		{
			page = null;
			pages = null;
			skipcount = null;
			itemsperpage = null;

			if (query.Page.HasValue || query.ItemsPerPage.HasValue)
			{
				query.Page ??= 1;
				query.ItemsPerPage ??= 10;

				page = query.Page < 1 ? 1 : query.Page;
				pages = (int)decimal.Ceiling(itemscount / query.ItemsPerPage.Value);
				itemsperpage = query.ItemsPerPage < 1 ? 10 : query.ItemsPerPage.Value;
				skipcount = query.Page.Value == 1 ? 0 : (query.Page.Value - 1) * query.ItemsPerPage.Value;

				if (pages == 0) pages = 1;
			}
		}
	}
}