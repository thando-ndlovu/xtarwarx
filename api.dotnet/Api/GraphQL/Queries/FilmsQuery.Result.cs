using Api.GraphQL.Types;

using System;

namespace Api.GraphQL.Queries
{
	public partial class FilmsQuery
	{
		public class Result : StarWarsModelQuery.Result<IFilmGraphType>
		{
			public Result(IServiceProvider serviceprovider) : base(serviceprovider)
			{
				Name = "FilmsQueryResult";
			}
		}
	}
}
