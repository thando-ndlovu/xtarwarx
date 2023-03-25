using System.Text;

namespace System
{
	public static class StringExtensions
	{
		public static string SeperateByCase(this string str, string seperator = " ")
		{
			StringBuilder stringBuilder = new ();

			for (int index = 0; index < str.Length; index++)
			{
				if (index != 0)
				{
					if (char.IsUpper(str[index]) && char.IsLower(str[index - 1]))
						stringBuilder.Append(seperator);
				}

				stringBuilder.Append(str[index]);
			}

			return stringBuilder.ToString();
		}
	}
}
