using Api.GraphQL.Types;

using Domain.Models;

namespace Api.GraphQL.Queries
{
	public partial class ManufacturersQuery
	{
		public class Result : StarWarsModelQuery.Result<IManufacturerGraphType, IManufacturer>
		{
			public Result() : base()
			{
				Name = "ManufacturersQueryResult";
			}
		}
	}
}
