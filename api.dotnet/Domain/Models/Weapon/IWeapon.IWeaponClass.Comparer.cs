using System;
using System.Collections.Generic;
using System.Linq;
						   
namespace Domain.Models
{
    public partial interface IWeapon
    {
		public partial interface IWeaponClass
		{
			public class Comparer : IComparer<IWeaponClass?>, IEqualityComparer<IWeaponClass?>
			{
				public int Compare(IWeaponClass? x, IWeaponClass? y)
				{
					int @class = System.Collections.Generic.Comparer<string?>.Default.Compare(x?.Class, x?.Class);

					return @class != 0
						? @class
						: System.Collections.Generic.Comparer<IEnumerable<string>?>.Default.Compare(x?.Flags, y?.Flags);
				}
				public bool Equals(IWeaponClass? x, IWeaponClass? y)
				{
					if (x is null || y is null)
						return false;

					bool classequals = Equals(x.Class, y.Class);
					bool flagsequals = (x.Flags is null && y.Flags is null) || (x.Flags != null && y.Flags != null && x.Flags.SequenceEqual(y.Flags));

					return classequals && flagsequals;
				}
				public int GetHashCode(IWeaponClass? obj)
				{
					return obj?.GetHashCode() ?? 0;
				}
			}
		}
    }
}
