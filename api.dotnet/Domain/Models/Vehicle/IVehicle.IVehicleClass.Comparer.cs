using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
    public partial interface IVehicle
    {
		public partial interface IVehicleClass
		{
			public class Comparer : IComparer<IVehicleClass?>, IEqualityComparer<IVehicleClass?>
			{
				public int Compare(IVehicleClass? x, IVehicleClass? y)
				{
					int @class = System.Collections.Generic.Comparer<string?>.Default.Compare(x?.Class, x?.Class);

					return @class != 0
						? @class
						: System.Collections.Generic.Comparer<IEnumerable<string>?>.Default.Compare(x?.Flags, y?.Flags);
				}
				public bool Equals(IVehicleClass? x, IVehicleClass? y)
				{
					if (x is null || y is null)
						return false;

					bool classequals = Equals(x.Class, y.Class);
					bool flagsequals = (x.Flags is null && y.Flags is null) || (x.Flags != null && y.Flags != null && x.Flags.SequenceEqual(y.Flags));

					return classequals && flagsequals;
				}
				public int GetHashCode(IVehicleClass? obj)
				{
					return obj?.GetHashCode() ?? 0;
				}
			}
		}
    }
}
