using GraphQLParser.AST;

using System.Linq;

namespace GraphQL.Types
{
	public class ArrayGraphType<T> : ScalarGraphType
	{
		public override object? ParseLiteral(GraphQLValue value)
		{
			// TODO: type 'double won't accept doubles that have 0 as decimal figure. eg 200.0 == failure but 200.1 == success'
			if (value is GraphQLListValue listvalue)
				return listvalue.Values?
					.Select(value => value)
					.OfType<T>()
					.ToArray();

			return null;
		}
		public override object? ParseValue(object? value)
		{
			if (value is T[] arrayvalue)
				return arrayvalue;

			return null;
		}
	}
}
