using Api.Repository;

using Domain.Enums;
using Domain.Models;

using Repository;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Queries.Search
{
	public static class IPlanetsSearchQueryExtensions
	{
		public static int GetMatchCount(this IPlanetsSearchQuery query, IPlanet planet, IRepository repository)
		{
			Func<IEnumerable<ICharacter>>? residentsfunc = null;

			if (query.ShouldSearchResidents() && (planet.ResidentIds?.Any() ?? false))
				residentsfunc = () => repository.Characters.AsQueryable()
					.Where(character => planet.ResidentIds.Contains(character.Id));

			int matchcount = query
				.AsPlanetSearch(query.SearchString)
				.GetMatchCount(
					planet: planet,
					residentsFunc: residentsfunc);

			return matchcount;
		}
		public static IEnumerable<IQuerySearchResult> GetQuerySearchResults(this IPlanetsSearchQuery query, IEnumerable<IPlanet> planets, IRepository repository)
		{
			IEnumerable<IQuerySearchResult> querysearchresults = planets
				.Select(planet =>
				{
					int matchcount = query.GetMatchCount(planet, repository);

					if (matchcount > 0)
					{
						return new IQuerySearchResult.Default
						{
							StarWarsType = StarWarsTypes.Planet,
							Id = planet.Id,
							MatchCount = matchcount,
						};
					}

					return null;

				}).OfType<IQuerySearchResult>();

			return querysearchresults;
		}
	}
}