using Domain.Enums;
using Domain.Models;

using Repository;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Queries.Search
{
	public static class IStarshipsSearchQueryExtensions
	{
		public static int GetMatchCount(this IStarshipsSearchQuery query, IStarship starship, IRepository repository)
		{
			Func<IEnumerable<IManufacturer>>? manufacturersfunc = null;
			Func<IEnumerable<ICharacter>>? pilotsfunc = null;

			if (query.ShouldSearchManufacturers() && (starship.ManufacturerIds?.Any() ?? false))
				manufacturersfunc = () => repository.Manufacturers.AsQueryable()
					.Where(manufacturer => starship.ManufacturerIds.Contains(manufacturer.Id));

			if (query.ShouldSearchPilots() && (starship.PilotIds?.Any() ?? false))
				pilotsfunc = () => repository.Characters.AsQueryable()
					.Where(character => starship.PilotIds.Contains(character.Id));

			int matchcount = query
				.AsStarshipSearch(query.SearchString)
				.GetMatchCount(
					starship: starship,
					manufacturersFunc: manufacturersfunc,
					pilotsFunc: pilotsfunc);

			return matchcount;
		}
		public static IEnumerable<IQuerySearchResult> GetQuerySearchResults(this IStarshipsSearchQuery query, IEnumerable<IStarship> starships, IRepository repository)
		{
			IEnumerable<IQuerySearchResult> querysearchresults = starships
				.Select(starship =>
				{
					int matchcount = query.GetMatchCount(starship, repository);

					if (matchcount > 0)
					{
						return new IQuerySearchResult.Default
						{
							StarWarsType = StarWarsTypes.Starship,
							Id = starship.Id,
							MatchCount = matchcount,
						};
					}

					return null;

				}).OfType<IQuerySearchResult>();

			return querysearchresults;
		}
	}
}