using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
	public partial interface ICharacter
	{
		public static class Sexes
		{
			public const string Asexual = "Asexual";
			public const string Female = "Female";
			public const string Hermaphrodite = "Hermaphrodite";
			public const string Male = "Male";

			public static IEnumerable<string> AsEnumerable()
			{
				return Enumerable.Empty<string>()
					.Append(Asexual)
					.Append(Female)
					.Append(Hermaphrodite)
					.Append(Male);
			}
		}
	}
}
