using Api.GraphQL.Types;

using System;

namespace Api.GraphQL.Queries
{
	public partial class StarshipsQuery
	{
		public class Result : StarWarsModelQuery.Result<IStarshipGraphType>
		{
			public Result(IServiceProvider serviceprovider) : base(serviceprovider)
			{
				Name = "StarshipsQueryResult";
			}
		}
	}
}
