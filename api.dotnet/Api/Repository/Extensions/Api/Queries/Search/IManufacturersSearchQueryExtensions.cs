using Domain.Enums;
using Domain.Models;

using Repository;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Queries.Search
{
	public static class IManufacturersSearchQueryExtensions
	{
		public static int GetMatchCount(this IManufacturersSearchQuery query, IManufacturer manufacturer, IRepository repository)
		{
			Func<IPlanet?>? headquatersplanetfunc = null;
			Func<IEnumerable<IStarship>>? starshipsfunc = null;
			Func<IEnumerable<IVehicle>>? vehiclesfunc = null;
			Func<IEnumerable<IWeapon>>? weaponsfunc = null;

			if (query.ShouldSearchHeadquatersPlanet() && manufacturer.HeadquatersPlanetId.HasValue)
				headquatersplanetfunc = () => repository.Planets.AsQueryable()
					.FirstOrDefault(planet => planet.Id == manufacturer.HeadquatersPlanetId.Value);

			if (query.ShouldSearchStarships() && (manufacturer.StarshipIds?.Any() ?? false))
				starshipsfunc = () => repository.Starships.AsQueryable()
					.Where(starship => manufacturer.StarshipIds.Contains(starship.Id));

			if (query.ShouldSearchVehicles() && (manufacturer.VehicleIds?.Any() ?? false))
				vehiclesfunc = () => repository.Vehicles.AsQueryable()
					.Where(vehicle => manufacturer.VehicleIds.Contains(vehicle.Id));

			if (query.ShouldSearchWeapons() && (manufacturer.WeaponIds?.Any() ?? false))
				weaponsfunc = () => repository.Weapons.AsQueryable()
					.Where(weapon => manufacturer.WeaponIds.Contains(weapon.Id));

			int matchcount = query
				.AsManufacturerSearch(query.SearchString)
				.GetMatchCount(
					manufacturer: manufacturer,
					headquatersPlanetFunc: headquatersplanetfunc,
					starshipsFunc: starshipsfunc,
					vehiclesFunc: vehiclesfunc,
					weaponsFunc: weaponsfunc);

			return matchcount;
		}
		public static IEnumerable<IQuerySearchResult> GetQuerySearchResults(this IManufacturersSearchQuery query, IEnumerable<IManufacturer> manufacturers, IRepository repository)
		{
			IEnumerable<IQuerySearchResult> querysearchresults = manufacturers
				.Select(manufacturer =>
				{
					int matchcount = query.GetMatchCount(manufacturer, repository);

					if (matchcount > 0)
					{
						return new IQuerySearchResult.Default
						{
							StarWarsType = StarWarsTypes.Manufacturer,
							Id = manufacturer.Id,
							MatchCount = matchcount,
						};
					}

					return null;

				}).OfType<IQuerySearchResult>();

			return querysearchresults;
		}
	}
}