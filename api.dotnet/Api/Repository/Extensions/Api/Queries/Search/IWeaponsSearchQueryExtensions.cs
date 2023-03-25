using Domain.Enums;
using Domain.Models;

using Repository;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Queries.Search
{
	public static class IWeaponsSearchQueryExtensions
	{
		public static int GetMatchCount(this IWeaponsSearchQuery query, IWeapon weapon, IRepository repository)
		{
			Func<IEnumerable<IManufacturer>>? manufacturersfunc = null;

			if (query.ShouldSearchManufacturers() && (weapon.ManufacturerIds?.Any() ?? false))
				manufacturersfunc = () => repository.Manufacturers.AsQueryable()
					.Where(manufacturer => weapon.ManufacturerIds.Contains(manufacturer.Id));

			int matchcount = query
				.AsWeaponSearch(query.SearchString)
				.GetMatchCount(
					weapon: weapon,
					manufacturersFunc: manufacturersfunc);

			return matchcount;
		}
		public static IEnumerable<IQuerySearchResult> GetQuerySearchResults(this IWeaponsSearchQuery query, IEnumerable<IWeapon> weapons, IRepository repository)
		{
			IEnumerable<IQuerySearchResult> querysearchresults = weapons
				.Select(weapon =>
				{
					int matchcount = query.GetMatchCount(weapon, repository);

					if (matchcount > 0)
					{
						return new IQuerySearchResult.Default
						{
							StarWarsType = StarWarsTypes.Weapon,
							Id = weapon.Id,
							MatchCount = matchcount,
						};
					}

					return null;

				}).OfType<IQuerySearchResult>();

			return querysearchresults;
		}
	}
}