using Domain.Enums;
using Domain.Models;

using Repository;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Queries.Search
{
	public static class IFactionsSearchQueryExtensions
	{
		public static int GetMatchCount(this IFactionsSearchQuery query, IFaction faction, IRepository repository)
		{
			Func<IEnumerable<ICharacter>>? alliedcharactersfunc = null;
			Func<IEnumerable<IFaction>>? alliedfactionsfunc = null;
			Func<IEnumerable<ICharacter>>? leadersfunc = null;
			Func<IEnumerable<ICharacter>>? membercharactersfunc = null;
			Func<IEnumerable<IFaction>>? memberfactionsfunc = null;

			if (query.ShouldSearchAlliedCharacters() && (faction.AlliedCharacterIds?.Any() ?? false))
				alliedcharactersfunc = () => repository.Characters.AsQueryable()
					.Where(character => faction.AlliedCharacterIds.Contains(character.Id));

			if (query.ShouldSearchAlliedFactions() && (faction.AlliedFactionIds?.Any() ?? false))
				alliedfactionsfunc = () => repository.Factions.AsQueryable()
					.Where(faction => faction.AlliedFactionIds.Contains(faction.Id));

			if (query.ShouldSearchLeaders() && (faction.LeaderIds?.Any() ?? false))
				leadersfunc = () => repository.Characters.AsQueryable()
					.Where(character => faction.LeaderIds.Contains(character.Id));

			if (query.ShouldSearchMemberCharacters() && (faction.MemberCharacterIds?.Any() ?? false))
				membercharactersfunc = () => repository.Characters.AsQueryable()
					.Where(character => faction.MemberCharacterIds.Contains(character.Id));

			if (query.ShouldSearchMemberFactions() && faction.MemberFactionIds != null && faction.MemberFactionIds.Any())
				memberfactionsfunc = () => repository.Factions.AsQueryable()
					.Where(faction => faction.MemberFactionIds.Contains(faction.Id));

			int matchcount = query
				.AsFactionSearch(query.SearchString)
				.GetMatchCount(
					faction: faction,
					alliedCharactersFunc: alliedcharactersfunc,
					alliedFactionsFunc: alliedfactionsfunc,
					leadersFunc: leadersfunc,
					memberCharactersFunc: membercharactersfunc,
					memberFactionsFunc: memberfactionsfunc);

			return matchcount;
		}
		public static IEnumerable<IQuerySearchResult> GetQuerySearchResults(this IFactionsSearchQuery query, IEnumerable<IFaction> factions, IRepository repository)
		{
			IEnumerable<IQuerySearchResult> querysearchresults = factions
				.Select(faction =>
				{
					int matchcount = query.GetMatchCount(faction, repository);

					if (matchcount > 0)
					{
						return new IQuerySearchResult.Default
						{
							StarWarsType = StarWarsTypes.Faction,
							Id = faction.Id,
							MatchCount = matchcount,
						};
					}

					return null;

				}).OfType<IQuerySearchResult>();

			return querysearchresults;
		}
	}
}