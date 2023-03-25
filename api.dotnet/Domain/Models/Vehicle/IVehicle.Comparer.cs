using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
    public partial interface IVehicle
    {
        public class Comparer : Comparer<IVehicle>
        {
			public new class Keys : Comparer<IVehicle>.Keys
			{
				public const string VehicleClass = "VehicleClass";

				public new static IEnumerable<string> AsEnumerable()
				{
					return Comparer<IVehicle>.Keys.AsEnumerable()
						.Append(VehicleClass);
				}
			}

			public override int Compare(IVehicle? x, IVehicle? y)
			{
				return ComparerKey switch
				{
					Keys.VehicleClass => ((IComparer<string?>)(KeyComparer ??= System.Collections.Generic.Comparer<string?>.Default))
						.Compare(x?.VehicleClass?.Class, y?.VehicleClass?.Class),

					_ => base.Compare(x, y)
				};
			}
			public override bool Equals(IVehicle? x, IVehicle? y)
			{
				if (x is null || y is null)
					return false;

				foreach (string key in EqualityComparerKeys ?? Keys.AsEnumerable())
				{
					bool equals = key switch
					{
						Keys.VehicleClass => (x.VehicleClass is null && y.VehicleClass is null) || new IVehicleClass.Comparer().Equals(x.VehicleClass, y.VehicleClass),

						_ => base.Equals(x, y),
					};

					if (equals is false)
						return false;
				}

				return true;
			}
			public override int GetHashCode(IVehicle obj)
			{
				return base.GetHashCode(obj);
			}
		}
    }
}
