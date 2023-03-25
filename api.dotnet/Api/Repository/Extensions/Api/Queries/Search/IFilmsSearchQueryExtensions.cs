using Domain.Enums;
using Domain.Models;

using Repository;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Queries.Search
{
	public static class IFilmsSearchQueryExtensions
	{
		public static int GetMatchCount(this IFilmsSearchQuery query, IFilm film, IRepository repository)
		{
			Func<IEnumerable<ICharacter>>? charactersfunc = null;
			Func<IEnumerable<IFaction>>? factionsfunc = null;
			Func<IEnumerable<IManufacturer>>? manufacturersfunc = null;
			Func<IEnumerable<IPlanet>>? planetsfunc = null;
			Func<IEnumerable<ISpecie>>? speciesfunc = null;
			Func<IEnumerable<IStarship>>? starshipsfunc = null;
			Func<IEnumerable<IVehicle>>? vehiclesfunc = null;
			Func<IEnumerable<IWeapon>>? weaponsfunc = null;

			if (query.ShouldSearchCharacters() && (film.CharacterIds?.Any() ?? false))
				charactersfunc = () => repository.Characters.AsQueryable()
					.Where(character => film.CharacterIds.Contains(character.Id));

			if (query.ShouldSearchFactions() && (film.FactionIds?.Any() ?? false))
				factionsfunc = () => repository.Factions.AsQueryable()
					.Where(faction => film.FactionIds.Contains(faction.Id));

			if (query.ShouldSearchManufacturers() && (film.ManufacturerIds?.Any() ?? false))
				manufacturersfunc = () => repository.Manufacturers.AsQueryable()
					.Where(manufacturer => film.ManufacturerIds.Contains(manufacturer.Id));

			if (query.ShouldSearchPlanets() && (film.PlanetIds?.Any() ?? false))
				planetsfunc = () => repository.Planets.AsQueryable()
					.Where(planet => film.PlanetIds.Contains(planet.Id));

			if (query.ShouldSearchSpecies() && (film.SpecieIds?.Any() ?? false))
				speciesfunc = () => repository.Species.AsQueryable()
					.Where(specie => film.SpecieIds.Contains(specie.Id));

			if (query.ShouldSearchStarships() && (film.StarshipIds?.Any() ?? false))
				starshipsfunc = () => repository.Starships.AsQueryable()
					.Where(starship => film.StarshipIds.Contains(starship.Id));

			if (query.ShouldSearchVehicles() && (film.VehicleIds?.Any() ?? false))
				vehiclesfunc = () => repository.Vehicles.AsQueryable()
					.Where(vehicle => film.VehicleIds.Contains(vehicle.Id));

			if (query.ShouldSearchWeapons() && (film.WeaponIds?.Any() ?? false))
				weaponsfunc = () => repository.Weapons.AsQueryable()
					.Where(weapon => film.WeaponIds.Contains(weapon.Id));

			int matchcount = query
				.AsFilmSearch(query.SearchString)
				.GetMatchCount(
					film: film,
					charactersFunc: charactersfunc,
					factionsFunc: factionsfunc,
					manufacturersFunc: manufacturersfunc,
					planetsFunc: planetsfunc,
					speciesFunc: speciesfunc,
					starshipsFunc: starshipsfunc,
					vehiclesFunc: vehiclesfunc,
					weaponsFunc: weaponsfunc);

			return matchcount;
		}
		public static IEnumerable<IQuerySearchResult> GetQuerySearchResults(this IFilmsSearchQuery query, IEnumerable<IFilm> films, IRepository repository)
		{
			IEnumerable<IQuerySearchResult> querysearchresults = films
				.Select(film =>
				{
					int matchcount = query.GetMatchCount(film, repository);

					if (matchcount > 0)
					{
						return new IQuerySearchResult.Default
						{
							StarWarsType = StarWarsTypes.Film,
							Id = film.Id,
							MatchCount = matchcount,
						};
					}

					return null;

				}).OfType<IQuerySearchResult>();

			return querysearchresults;
		}
	}
}