using Api.GraphQL.Types;

using System;

namespace Api.GraphQL.Queries
{
	public partial class ManufacturersQuery
	{
		public class Result : StarWarsModelQuery.Result<IManufacturerGraphType>
		{
			public Result(IServiceProvider serviceprovider) : base(serviceprovider)
			{
				Name = "ManufacturersQueryResult";
			}
		}
	}
}
