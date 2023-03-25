using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
	public partial interface IPlanet
    {
		public partial interface IClimate
		{
			public class Comparer : IComparer<IClimate?>, IEqualityComparer<IClimate?>
			{
				public int Compare(IClimate? x, IClimate? y)
				{
					int @class = System.Collections.Generic.Comparer<string?>.Default.Compare(x?.Type, x?.Type);

					return @class != 0
						? @class
						: System.Collections.Generic.Comparer<IEnumerable<string>?>.Default.Compare(x?.Flags, y?.Flags);
				}
				public bool Equals(IClimate? x, IClimate? y)
				{
					if (x is null || y is null)
						return false;

					bool typeequals = Equals(x.Type, y.Type);
					bool flagsequals = (x.Flags is null && y.Flags is null) || (x.Flags != null && y.Flags != null && x.Flags.SequenceEqual(y.Flags));

					return typeequals && flagsequals;
				}
				public int GetHashCode(IClimate? obj)
				{
					return obj?.GetHashCode() ?? 0;
				}
			}
		}
    }
}
