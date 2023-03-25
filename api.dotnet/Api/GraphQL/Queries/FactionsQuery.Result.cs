using Api.GraphQL.Types;

using System;

namespace Api.GraphQL.Queries
{
	public partial class FactionsQuery
	{
		public class Result : StarWarsModelQuery.Result<IFactionGraphType>
		{
			public Result(IServiceProvider serviceprovider) : base(serviceprovider)
			{
				Name = "FactionsQueryResult";
			}
		}
	}
}
