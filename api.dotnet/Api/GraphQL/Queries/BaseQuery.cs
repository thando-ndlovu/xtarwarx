using GraphQL.Types;

using System;

namespace Api.GraphQL.Queries
{
	public partial class BaseQuery<TGraphType> : ObjectGraphType<TGraphType> where TGraphType : IGraphType
	{
		public class Arguments
		{
			public class ArgumentNames { }
		}

		public BaseQuery(IServiceProvider serviceprovider) { }
	}
}
