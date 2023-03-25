using System.Collections.Generic;
using System.Text;

namespace Api.Queries.GraphQL
{
	public interface IGraphQLQuery<T> : IQuery<T>
	{
		T OperationName { get; set; }
		T Query { get; set; }
		T Variables { get; set; }
	}
	public interface IGraphQLQuery : IQuery
	{
		public new interface IResult<T> : IQuery.IResult<T> { }
		public new interface IResult : IQuery.IResult
		{
			public new class Default<T> : IQuery.IResult.Default<T>, IResult { }
		}

		string? OperationName { get; set; }
		string? Query { get; set; }
		IDictionary<string, object>? Variables { get; set; }

		string AsQueryString();

		public new class Default : IQuery.Default, IGraphQLQuery
		{
			public string? OperationName { get; set; }
			public string? Query { get; set; }
			public IDictionary<string, object>? Variables { get; set; }

			public string AsQueryString()
			{
				StringBuilder stringbuilder = new();

				if (OperationName is not null) stringbuilder
						.AppendFormat("{0}: \"{1}\"", nameof(OperationName), OperationName);

				if (Query is not null) stringbuilder
						.AppendFormat("{0}: \"{1}\"", nameof(Query), Query);

				if (Variables is not null) stringbuilder
						.AppendFormat("{0}: \"{1}\"", nameof(Variables), Variables);

				return stringbuilder.ToString();
			}
		}
		public new class Default<T> : IQuery.Default<T>, IGraphQLQuery<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				OperationName = defaultvalue;
				Query = defaultvalue;
				Variables = defaultvalue;
			}

			public T OperationName { get; set; }
			public T Query { get; set; }
			public T Variables { get; set; }
		}
	}
}
