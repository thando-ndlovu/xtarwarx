using Api.Queries.SortKeys;

using System.Collections.Generic;
using System.Linq;

namespace Api.Queries
{
	public static class IQuerySearchExtensions
	{
		public static IQuerySearch.IResult ProcessQuerySearch(this IQuerySearch querysearch, IEnumerable<IQuerySearchResult> searchresults)
		{
			searchresults = querysearch.ProcessQuerySearch(searchresults, out int? page, out int? pages);

			return new IQuerySearch.IResult.Default
			{
				Page = page,
				Pages = pages,
				Items = searchresults,
			};
		}
		public static IEnumerable<IQuerySearchResult> ProcessQuerySearch(this IQuerySearch querysearch, IEnumerable<IQuerySearchResult> searchresults, out int? page, out int? pages)
		{
			querysearch.GetPaginationValues(
				itemscount: searchresults.Count(),
				page: out int? outpage,
				pages: out int? outpages,
				skipcount: out int? outskipcount,
				itemsperpage: out int? outitemsperpage);

			searchresults = QuerySearchSortKeys.FromString(querysearch.OrderBy) is string sortkey
				? QuerySearchSortKeys.Sort(searchresults, sortkey)
				: QuerySearchSortKeys.Sort(searchresults, QuerySearchSortKeys.MatchCount);

			if (outskipcount.HasValue) searchresults = searchresults.Skip(outskipcount.Value);
			if (outitemsperpage.HasValue) searchresults = searchresults.Take(outitemsperpage.Value);

			page = outpage;
			pages = outpages;

			return searchresults;
		}
	}
}