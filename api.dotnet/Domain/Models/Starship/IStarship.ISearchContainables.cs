using System;
using System.Text;

namespace Domain.Models
{
	public partial interface IStarship
	{
		public new interface ISearchContainables<T> : ITransporter.ISearchContainables<T>
		{
			T StarshipClass { get; set; }
			T StarshipClassFlags { get; set; }

			public new string? ToString()
			{
				return new StringBuilder()
					.Append(this)
					.ToString();
			}
		}
		public new interface ISearchContainables : ISearchContainables<bool>, ITransporter.ISearchContainables
		{
			public new class Default : Default<bool>, ISearchContainables
			{
				public Default() : base(false) { }
			}
			public new class Default<T> : ITransporter.ISearchContainables.Default<T>, ISearchContainables<T>
			{
				public Default(T defaultvalue) : base(defaultvalue)
				{
					StarshipClass = defaultvalue;
					StarshipClassFlags = defaultvalue;
				}

				public T StarshipClass { get; set; }
				public T StarshipClassFlags { get; set; }
			}

			public bool ShouldReturnStarship(IStarship starship, string? searchString)
			{
				if (StarshipClass && StarshipClassContainsSearchString(starship, searchString, out int _)) return true;
				if (StarshipClassFlags && StarshipClassFlagsContainsSearchString(starship, searchString, out int _)) return true;

				return ShouldReturnTransporter(starship, searchString);
			}
			public bool ShouldReturnStarship(IStarship starship, string? searchString, out int matchCount)
			{
				matchCount = 0;

				bool shouldreturn = ShouldReturnTransporter(starship, searchString, out int transportermatchcount);

				if (shouldreturn)
					matchCount += transportermatchcount;

				if (StarshipClass && StarshipClassContainsSearchString(starship, searchString, out int starshipClassMatchCount))
				{
					matchCount += starshipClassMatchCount;

					shouldreturn = true;
				}
				if (StarshipClassFlags && StarshipClassFlagsContainsSearchString(starship, searchString, out int starshipClassFlagsMatchCount))
				{
					matchCount += starshipClassFlagsMatchCount;

					shouldreturn = true;
				}

				return shouldreturn;
			}

			private bool StarshipClassContainsSearchString(IStarship starship, string? searchString, out int matchCount)
			{
				matchCount = 0;

				if (string.IsNullOrWhiteSpace(searchString))
					return true;

				if (string.IsNullOrWhiteSpace(starship.StarshipClass?.Class)) return false;

				if (starship.StarshipClass.Class.ToLower().Contains(searchString.ToLower(), StringComparison.OrdinalIgnoreCase))
					matchCount++;

				return matchCount > 0;
			}
			private bool StarshipClassFlagsContainsSearchString(IStarship starship, string? searchString, out int matchCount)
			{
				matchCount = 0;

				if (string.IsNullOrWhiteSpace(searchString))
					return true;

				if (starship.StarshipClass?.Flags == null) return false;

				foreach (string starshipclassflag in starship.StarshipClass.Flags)
					if (starshipclassflag.ToLower().Contains(searchString.ToLower(), StringComparison.OrdinalIgnoreCase))
						matchCount++;

				return matchCount > 0;
			}
		}
	}

	public static class IStarshipExtensions
	{
		public static StringBuilder Append<T>(this StringBuilder stringbuilder, IStarship.ISearchContainables<T>? searchcontainables)
		{
			if (searchcontainables is null)
				return stringbuilder;

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(IStarship.ISearchContainables<T>.StarshipClass), searchcontainables.StarshipClass).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IStarship.ISearchContainables<T>.StarshipClassFlags), searchcontainables.StarshipClassFlags).AppendLine();

			return stringbuilder.Append<T>(searchcontainables as ITransporter.ISearchContainables<T>);
		}
	}
}
