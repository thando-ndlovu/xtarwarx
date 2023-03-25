﻿
namespace System
{
	public static class IntExtensions
	{
		// TODO: AsRomanNumeral (Properly)

		public static string AsRomanNumeral(this int i)
		{
			return i switch
			{
				1 => "I",
				2 => "II",
				3 => "III",
				4 => "IV",
				5 => "V",
				6 => "VI",
				7 => "VII",
				8 => "VIII",
				9 => "IX",
				10 => "X",
				11 => "XI",
				12 => "XII",

				_ => i.ToString()
			};
		}
	}
}
