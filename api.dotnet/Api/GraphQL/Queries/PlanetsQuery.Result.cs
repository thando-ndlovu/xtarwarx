using Api.GraphQL.Types;

using Domain.Models;

namespace Api.GraphQL.Queries
{
	public partial class PlanetsQuery 
	{
		public class Result : StarWarsModelQuery.Result<IPlanetGraphType, IPlanet> 
		{
			public Result() : base()
			{
				Name = "PlanetsQueryResult";
			}
		}
	}
}
