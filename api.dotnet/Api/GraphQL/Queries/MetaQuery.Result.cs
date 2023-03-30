using Api.GraphQL.Types;

using System;

namespace Api.GraphQL.Queries
{
	public partial class MetaQuery
	{
		public class Result : IQueryMetaResultGraphType
		{
			public Result() : base()
			{
				Name = "QueryMetaResult";
			}
		}
	}
}
