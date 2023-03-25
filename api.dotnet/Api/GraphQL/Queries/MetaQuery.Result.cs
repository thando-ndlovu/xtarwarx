using Api.GraphQL.Types;

using System;

namespace Api.GraphQL.Queries
{
	public partial class MetaQuery
	{
		public class Result : BaseQuery.Result<IQueryMetaResultGraphType>
		{
			public Result(IServiceProvider serviceprovider) : base(serviceprovider) 
			{
				Name = "QueryMetaResult";
			}
		}
	}
}
