using Api.GraphQL.Types;

using GraphQL.Types;

using System;

namespace Api.GraphQL.Queries
{
	public partial class IntrospectionQuery
	{
		public class Result : BaseQuery.Result<ISchema>
		{
			public Result() : base()
			{
				Name = "IntrospectionQueryResult";
			}
		}
	}
}
