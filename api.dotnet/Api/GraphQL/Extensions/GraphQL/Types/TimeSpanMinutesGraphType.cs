using GraphQLParser.AST;

using System;

namespace GraphQL.Types
{
	public class TimeSpanMinutesGraphType : ScalarGraphType
	{
		public override object? ParseLiteral(GraphQLValue value)
		{
			if (value is GraphQLStringValue stringvalue && int.TryParse(stringvalue.Value, out int outintvalue))
				return TimeSpan.FromMinutes(outintvalue);

			return null;
		}
		public override object? ParseValue(object? value)
		{
			if (value is int intvalue)
				return TimeSpan.FromMinutes(intvalue);

			if (value is decimal decimalvalue)
				return TimeSpan.FromMinutes((int)decimalvalue);

			if (value is double doublevalue)
				return TimeSpan.FromMinutes((int)doublevalue);

			if (value is string stringvalue && int.TryParse(stringvalue, out int outintvalue))
				return TimeSpan.FromMinutes(outintvalue);

			return null;
		}
	}
}
