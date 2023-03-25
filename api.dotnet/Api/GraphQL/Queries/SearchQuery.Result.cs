using Api.GraphQL.Types;

using System;

namespace Api.GraphQL.Queries
{
	public partial class SearchQuery
	{
		public class Result : StarWarsModelQuery.Result<IQuerySearchResultGraphType>
		{
			public Result(IServiceProvider serviceprovider) : base(serviceprovider) 
			{
				Name = "SearchQueryResult";
			}
		}
	}
}
