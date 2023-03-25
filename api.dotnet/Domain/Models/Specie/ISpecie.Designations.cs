using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
	public partial interface ISpecie
	{
		public static class Designations
		{
			public const string Sentient = "Sentient";

			public static IEnumerable<string> AsEnumerable()
			{
				return Enumerable.Empty<string>()
					.Append(Sentient);
			}
		}
	}
}
