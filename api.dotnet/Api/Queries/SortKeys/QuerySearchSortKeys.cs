using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Queries.SortKeys
{
	public class QuerySearchSortKeys
	{
		public const string Id = "Id";
		public const string MatchCount = "MatchCount";
		public const string StarWarsType = "StarWarsType";

		public static IEnumerable<string> AsEnumerable()
			=> Enumerable.Empty<string>()
				.Append(Id)
				.Append(MatchCount)
				.Append(StarWarsType);
		public static string? FromString(string? sortkey)
		{
			return AsEnumerable()
				.FirstOrDefault(_ =>
				{
					if (string.Equals(sortkey, _, StringComparison.OrdinalIgnoreCase))
						return true;

					return false;
				});
		}

		public static IOrderedEnumerable<IQuerySearchResult> Sort(IEnumerable<IQuerySearchResult> querysearchresults, params string[] sortkeys)
		{
			return Sort(querysearchresults, sortkeys.Select(sortkey => KeyValuePair.Create(sortkey, false)).ToArray());
		}
		public static IOrderedQueryable<IQuerySearchResult> Sort(IQueryable<IQuerySearchResult> querysearchresults, params string[] sortkeys)
		{
			return Sort(querysearchresults, sortkeys.Select(sortkey => KeyValuePair.Create(sortkey, false)).ToArray());
		}

		public static IOrderedEnumerable<IQuerySearchResult> Sort(IEnumerable<IQuerySearchResult> querysearchresults, params KeyValuePair<string, bool>[] sortkeys)
		{
			IOrderedEnumerable<IQuerySearchResult>? ordered = null;

			foreach (KeyValuePair<string, bool> sortkey in sortkeys)
				ordered = (sortkey.Key, sortkey.Value, ordered == null) switch
				{
					(Id, false, true) => querysearchresults.OrderBy(querysearchresult => querysearchresult.Id),
					(Id, false, false) => ordered!.ThenBy(querysearchresult => querysearchresult.Id),
					(Id, true, true) => querysearchresults.OrderByDescending(querysearchresult => querysearchresult.Id),
					(Id, true, false) => ordered!.ThenByDescending(querysearchresult => querysearchresult.Id),

					(MatchCount, false, true) => querysearchresults.OrderBy(querysearchresult => querysearchresult.MatchCount),
					(MatchCount, false, false) => ordered!.ThenBy(querysearchresult => querysearchresult.MatchCount),
					(MatchCount, true, true) => querysearchresults.OrderByDescending(querysearchresult => querysearchresult.MatchCount),
					(MatchCount, true, false) => ordered!.ThenByDescending(querysearchresult => querysearchresult.MatchCount),

					(StarWarsType, false, true) => querysearchresults.OrderBy(querysearchresult => querysearchresult.StarWarsType.ToString()),
					(StarWarsType, false, false) => ordered!.ThenBy(querysearchresult => querysearchresult.StarWarsType.ToString()),
					(StarWarsType, true, true) => querysearchresults.OrderByDescending(querysearchresult => querysearchresult.StarWarsType.ToString()),
					(StarWarsType, true, false) => ordered!.ThenByDescending(querysearchresult => querysearchresult.StarWarsType.ToString()),

					(_, _, _) => ordered,
				};

			return ordered ?? querysearchresults.OrderBy(starwarsmodel => starwarsmodel);
		}
		public static IOrderedQueryable<IQuerySearchResult> Sort(IQueryable<IQuerySearchResult> querysearchresults, params KeyValuePair<string, bool>[] sortkeys)
		{
			IOrderedQueryable<IQuerySearchResult>? ordered = null;

			foreach (KeyValuePair<string, bool> sortkey in sortkeys)
				ordered = (sortkey.Key, sortkey.Value, ordered == null) switch
				{
					(Id, false, true) => querysearchresults.OrderBy(querysearchresult => querysearchresult.Id),
					(Id, false, false) => ordered!.ThenBy(querysearchresult => querysearchresult.Id),
					(Id, true, true) => querysearchresults.OrderByDescending(querysearchresult => querysearchresult.Id),
					(Id, true, false) => ordered!.ThenByDescending(querysearchresult => querysearchresult.Id),

					(MatchCount, false, true) => querysearchresults.OrderBy(querysearchresult => querysearchresult.MatchCount),
					(MatchCount, false, false) => ordered!.ThenBy(querysearchresult => querysearchresult.MatchCount),
					(MatchCount, true, true) => querysearchresults.OrderByDescending(querysearchresult => querysearchresult.MatchCount),
					(MatchCount, true, false) => ordered!.ThenByDescending(querysearchresult => querysearchresult.MatchCount),

					(StarWarsType, false, true) => querysearchresults.OrderBy(querysearchresult => querysearchresult.StarWarsType.ToString()),
					(StarWarsType, false, false) => ordered!.ThenBy(querysearchresult => querysearchresult.StarWarsType.ToString()),
					(StarWarsType, true, true) => querysearchresults.OrderByDescending(querysearchresult => querysearchresult.StarWarsType.ToString()),
					(StarWarsType, true, false) => ordered!.ThenByDescending(querysearchresult => querysearchresult.StarWarsType.ToString()),

					(_, _, _) => ordered,
				};

			return ordered ?? querysearchresults.OrderBy(starwarsmodel => starwarsmodel);
		}
	}
}
