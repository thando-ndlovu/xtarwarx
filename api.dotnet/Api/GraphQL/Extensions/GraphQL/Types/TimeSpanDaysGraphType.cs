using GraphQLParser.AST;

using System;

namespace GraphQL.Types
{
	public class TimeSpanDaysGraphType : ScalarGraphType
	{
		public override object? ParseLiteral(GraphQLValue value)
		{
			if (value is GraphQLStringValue stringvalue && int.TryParse(stringvalue.Value, out int outintvalue))
				return TimeSpan.FromDays(outintvalue);

			return null;
		}
		public override object? ParseValue(object? value)
		{
			if (value is string stringvalue && int.TryParse(stringvalue, out int outintvalue))
				return TimeSpan.FromDays(outintvalue);

			if (value is int intvalue)
				return TimeSpan.FromDays(intvalue);

			if (value is decimal decimalvalue)
				return TimeSpan.FromDays((int)decimalvalue);

			if (value is double doublevalue)
				return TimeSpan.FromDays((int)doublevalue);

			return null;
		}
	}
}
