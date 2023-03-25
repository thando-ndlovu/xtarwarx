using GraphQLParser.AST;

using System;

namespace GraphQL.Types
{
	public class TimeSpanHoursGraphType : ScalarGraphType
	{
		public override object? ParseLiteral(GraphQLValue value)
		{
			if (value is GraphQLStringValue stringvalue && int.TryParse(stringvalue.Value, out int outintvalue))
				return TimeSpan.FromHours(outintvalue);

			return null;
		}
		public override object? ParseValue(object? value)
		{
			if (value is string stringvalue && int.TryParse(stringvalue, out int outintvalue))
				return TimeSpan.FromHours(outintvalue);

			if (value is int intvalue)
				return TimeSpan.FromHours(intvalue);

			if (value is decimal decimalvalue)
				return TimeSpan.FromHours((int)decimalvalue);

			if (value is double doublevalue)
				return TimeSpan.FromHours((int)doublevalue);

			return null;
		}
	}
}
