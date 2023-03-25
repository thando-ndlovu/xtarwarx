using Api.GraphQL.Types;

using System;

namespace Api.GraphQL.Queries
{
	public partial class SpeciesQuery
	{
		public class Result : StarWarsModelQuery.Result<ISpecieGraphType>
		{
			public Result(IServiceProvider serviceprovider) : base(serviceprovider)
			{
				Name = "SpeciesQueryResult";
			}
		}
	}
}
