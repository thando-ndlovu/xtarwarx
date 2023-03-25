using Api.GraphQL.Types;

using System;

namespace Api.GraphQL.Queries
{
	public partial class PlanetsQuery 
	{
		public class Result : StarWarsModelQuery.Result<IPlanetGraphType> 
		{
			public Result(IServiceProvider serviceprovider) : base(serviceprovider)
			{
				Name = "PlanetsQueryResult";
			}
		}
	}
}
