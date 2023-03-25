using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
	public partial interface IPlanet
    {
		public partial interface ITerrain
		{
			public class Comparer : IComparer<ITerrain?>, IEqualityComparer<ITerrain?>
			{
				public int Compare(ITerrain? x, ITerrain? y)
				{
					int @class = System.Collections.Generic.Comparer<string?>.Default.Compare(x?.Type, x?.Type);

					return @class != 0
						? @class
						: System.Collections.Generic.Comparer<IEnumerable<string>?>.Default.Compare(x?.Flags, y?.Flags);
				}
				public bool Equals(ITerrain? x, ITerrain? y)
				{
					if (x is null || y is null)
						return false;

					bool typeequals = Equals(x.Type, y.Type);
					bool flagsequals = (x.Flags is null && y.Flags is null) || (x.Flags != null && y.Flags != null && x.Flags.SequenceEqual(y.Flags));

					return typeequals && flagsequals;
				}
				public int GetHashCode(ITerrain? obj)
				{
					return obj?.GetHashCode() ?? 0;
				}
			}
		}
    }
}
