using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Models
{
	public partial interface IStarWarsModel
	{
		public interface ISearchValues<T>
		{
			T Lower { get; set; }
			T Upper { get; set; }
			IEnumerable<T>? Values { get; set; }

			public bool Search(T value, out int matchCount)
			{
				bool result = Search(value, System.Collections.Generic.Comparer<T>.Default, out int outmatchcount);

				matchCount = outmatchcount;

				return result;
			}
			public bool Search(T value, IComparer<T> comparer, out int matchCount)
			{
				matchCount = 0;

				if (Values?.Contains(value) ?? false)
					matchCount++;

				bool withinrange = Lower is null && Upper is null ? false : 
					(Lower is null || comparer.Compare(value, Lower) >= 0)
						&&
					(Upper is null || comparer.Compare(value, Upper) <= 0);

				if (withinrange)
					matchCount++;

				return matchCount > 0;
			}

			public string? ToString()
			{
				return new StringBuilder()
					.Append(this)
					.ToString();
			}
		}
		public interface ISearchValues
		{
			public class Default<T> : ISearchValues<T>
			{
				public Default(T defaultvalue)
				{
					Lower = defaultvalue;
					Upper = defaultvalue;
				}

				public T Lower { get; set; }
				public T Upper { get; set; }
				public IEnumerable<T>? Values { get; set; }
			}
		}
	}

	public static class StarWarsModelSearchValuesExtensions
	{
		public static StringBuilder Append<T>(this StringBuilder stringbuilder, IStarWarsModel.ISearchValues<T>? searchvalues)
		{
			if (searchvalues is null)
				return stringbuilder;

			return stringbuilder
				.AppendFormat("{0}: {1}", nameof(IStarWarsModel.ISearchValues<T>.Lower), searchvalues.Lower).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IStarWarsModel.ISearchValues<T>.Upper), searchvalues.Upper).AppendLine()
				.AppendFormat("{0}: ", nameof(IStarWarsModel.ISearchValues<T>.Values)).AppendJoin(", ", searchvalues.Values ?? Enumerable.Empty<T>()).AppendLine();
		}
	}
}
