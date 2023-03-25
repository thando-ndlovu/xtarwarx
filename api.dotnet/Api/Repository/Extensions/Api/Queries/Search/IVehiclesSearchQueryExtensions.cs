using Domain.Enums;
using Domain.Models;

using Repository;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Queries.Search
{
	public static class IVehiclesSearchQueryExtensions
	{
		public static int GetMatchCount(this IVehiclesSearchQuery query, IVehicle vehicle, IRepository repository)
		{
			Func<IEnumerable<IManufacturer>>? manufacturersfunc = null;
			Func<IEnumerable<ICharacter>>? pilotsfunc = null;

			if (query.ShouldSearchManufacturers() && (vehicle.ManufacturerIds?.Any() ?? false))
				manufacturersfunc = () => repository.Manufacturers.AsQueryable()
					.Where(manufacturer => vehicle.ManufacturerIds.Contains(manufacturer.Id));

			if (query.ShouldSearchPilots() && (vehicle.PilotIds?.Any() ?? false))
				pilotsfunc = () => repository.Characters.AsQueryable()
					.Where(character => vehicle.PilotIds.Contains(character.Id));

			int matchcount = query
				.AsVehicleSearch(query.SearchString)
				.GetMatchCount(
					vehicle: vehicle,
					manufacturersFunc: manufacturersfunc,
					pilotsFunc: pilotsfunc);

			return matchcount;
		}
		public static IEnumerable<IQuerySearchResult> GetQuerySearchResults(this IVehiclesSearchQuery query, IEnumerable<IVehicle> vehicles, IRepository repository)
		{
			IEnumerable<IQuerySearchResult> querysearchresults = vehicles
				.Select(vehicle =>
				{
					int matchcount = query.GetMatchCount(vehicle, repository);

					if (matchcount > 0)
					{
						return new IQuerySearchResult.Default
						{
							StarWarsType = StarWarsTypes.Vehicle,
							Id = vehicle.Id,
							MatchCount = matchcount,
						};
					}

					return null;

				}).OfType<IQuerySearchResult>();

			return querysearchresults;
		}
	}
}