using Api.GraphQL.Types;
using Api.Queries;

namespace Api.GraphQL.Queries
{
	public partial class SearchQuery
	{
		public class Result : StarWarsModelQuery.Result<IQuerySearchResultGraphType, IQuerySearchResult>
		{
			public Result() : base()
			{
				Name = "SearchQueryResult";
			}
		}
	}
}
