using Api.GraphQL.Types;

using System;

namespace Api.GraphQL.Queries
{
	public partial class VehiclesQuery
	{
		public class Result : StarWarsModelQuery.Result<IVehicleGraphType>
		{
			public Result(IServiceProvider serviceprovider) : base(serviceprovider)
			{
				Name = "VehiclesQueryResult";
			}
		}
	}
}
