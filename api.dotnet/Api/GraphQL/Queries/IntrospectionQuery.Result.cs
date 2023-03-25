using Api.GraphQL.Types;

using GraphQL.Types;

using System;

namespace Api.GraphQL.Queries
{
	public partial class IntrospectionQuery
	{
		public class Result : BaseQuery.Result<ObjectGraphType>
		{
			public Result(IServiceProvider serviceprovider) : base(serviceprovider) 
			{
				Name = "IntrospectionQueryResult";
			}
		}
	}
}
