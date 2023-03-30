using Api.GraphQL.Types;

using Domain.Models;

namespace Api.GraphQL.Queries
{
	public partial class VehiclesQuery
	{
		public class Result : StarWarsModelQuery.Result<IVehicleGraphType, IVehicle>
		{
			public Result() : base()
			{
				Name = "VehiclesQueryResult";
			}
		}
	}
}
