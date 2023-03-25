using GraphQLParser.AST;

namespace GraphQL.Types
{
	public class DoubleGraphType : ScalarGraphType
	{
		public override object? ParseLiteral(GraphQLValue value)
		{
			if (value is GraphQLStringValue stringvalue && double.TryParse(stringvalue.Value, out double outstringvalue))
				return outstringvalue;

			return null;
		}
		public override object? ParseValue(object? value)
		{
			if (value is string stringvalue && double.TryParse(stringvalue, out double outstringvalue))
				return outstringvalue;	

			if (value is int intvalue)
				return (double)intvalue;

			if (value is decimal decimalvalue)
				return (double)decimalvalue;

			if (value is double doublevalue)
				return doublevalue;

			return null;
		}
	}
}
