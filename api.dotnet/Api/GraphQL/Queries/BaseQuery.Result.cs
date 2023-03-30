using GraphQL.Types;

using System;

namespace Api.GraphQL.Queries
{
	public partial class BaseQuery 
	{
		public class Result<TObject> : ObjectGraphType 
		{
			public class FieldNames { }
		}
	}
}
