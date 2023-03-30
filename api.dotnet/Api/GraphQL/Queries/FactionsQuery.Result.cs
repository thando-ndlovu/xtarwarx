using Api.GraphQL.Types;

using Domain.Models;

namespace Api.GraphQL.Queries
{
	public partial class FactionsQuery
	{
		public class Result : StarWarsModelQuery.Result<IFactionGraphType, IFaction>
		{
			public Result() : base()
			{
				Name = "FactionsQueryResult";
			}
		}
	}
}
