using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
	public partial interface ISpecie
	{
		public static class Classifications
		{
			public const string Amphibian = "Amphibian";
			public const string Artificial = "Artificial";
			public const string Insectoid = "Insectoid";
			public const string Gastropod = "Gastropod";
			public const string Mammal = "Mammal";
			public const string Reptile = "Reptile";

			public static IEnumerable<string> AsEnumerable()
			{
				return Enumerable.Empty<string>()
					.Append(Amphibian)
					.Append(Artificial)
					.Append(Insectoid)
					.Append(Gastropod)
					.Append(Mammal)
					.Append(Reptile);
			}
		}
	}
}
