using Domain.Enums;
using Domain.Models;

using Repository;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Queries.Search
{
	public static class ISpeciesSearchQueryExtensions
	{
		public static int GetMatchCount(this ISpeciesSearchQuery query, ISpecie specie, IRepository repository)
		{
			Func<IEnumerable<ICharacter>>? charactersfunc = null;
			Func<IPlanet?>? homeworldfunc = null;

			if (query.ShouldSearchCharacters() && (specie.CharacterIds?.Any() ?? false))
				charactersfunc = () => repository.Characters.AsQueryable()
					.Where(character => specie.CharacterIds.Contains(character.Id));

			if (query.ShouldSearchHomeworld() && specie.HomeworldId.HasValue)
				homeworldfunc = () => repository.Planets.AsQueryable()
					.FirstOrDefault(planet => planet.Id == specie.HomeworldId.Value);

			int matchcount = query
				.AsSpecieSearch(query.SearchString)
				.GetMatchCount(
					specie: specie,
					charactersFunc: charactersfunc,
					homeworldFunc: homeworldfunc);

			return matchcount;
		}
		public static IEnumerable<IQuerySearchResult> GetQuerySearchResults(this ISpeciesSearchQuery query, IEnumerable<ISpecie> species, IRepository repository)
		{
			IEnumerable<IQuerySearchResult> querysearchresults = species
				.Select(specie =>
				{
					int matchcount = query.GetMatchCount(specie, repository);

					if (matchcount > 0)
					{
						return new IQuerySearchResult.Default
						{
							StarWarsType = StarWarsTypes.Specie,
							Id = specie.Id,
							MatchCount = matchcount,
						};
					}

					return null;

				}).OfType<IQuerySearchResult>();

			return querysearchresults;
		}
	}
}