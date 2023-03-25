using Domain.Enums;
using Domain.Models;

using Repository;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Queries.Search
{
	public static class ICharactersSearchQueryExtensions
	{
		public static int GetMatchCount(this ICharactersSearchQuery query, ICharacter character, IRepository repository)
		{
			Func<IPlanet?>? homeworldfunc = null;

			if (query.ShouldSearchHomeworld() && character.HomeworldId.HasValue)
				homeworldfunc = () => repository.Planets.AsQueryable()
					.FirstOrDefault(planet => planet.Id == character.HomeworldId.Value);

			int matchcount = query
				.AsCharacterSearch(query.SearchString)
				.GetMatchCount(
					character: character,
					homeworldFunc: homeworldfunc);

			return matchcount;
		}
		public static IEnumerable<IQuerySearchResult> GetQuerySearchResults(this ICharactersSearchQuery query, IEnumerable<ICharacter> characters, IRepository repository)
		{
			IEnumerable<IQuerySearchResult> querysearchresults = characters
				.Select(character =>
				{
					int matchcount = query.GetMatchCount(character, repository);

					if (matchcount > 0)
					{
						return new IQuerySearchResult.Default
						{
							StarWarsType = StarWarsTypes.Character,
							Id = character.Id,
							MatchCount = matchcount,
						};
					}

					return null;

				}).OfType<IQuerySearchResult>();

			return querysearchresults;
		}
	}
}