using Api.GraphQL.Types;

using Domain.Models;

namespace Api.GraphQL.Queries
{
	public partial class SpeciesQuery
	{
		public class Result : StarWarsModelQuery.Result<ISpecieGraphType, ISpecie>
		{
			public Result() : base()
			{
				Name = "SpeciesQueryResult";
			}
		}
	}
}
