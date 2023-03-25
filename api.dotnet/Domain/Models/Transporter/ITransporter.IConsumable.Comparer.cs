using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
	public partial interface ITransporter
    {
		public partial interface IConsumable
		{
			public class Comparer : IComparer<IConsumable?>, IEqualityComparer<IConsumable?>
			{
				protected static double? ConsumableToDouble(IConsumable? consumable)
				{
					if (consumable?.Value is null)
						return null;

					return consumable.TimeUnit switch
					{
						IConsumable.TimeUnits.Hour => consumable.Value.Value / 24,
						IConsumable.TimeUnits.Day => consumable.Value.Value,
						IConsumable.TimeUnits.Week => consumable.Value.Value * 7,
						IConsumable.TimeUnits.Month => consumable.Value.Value * 30,
						IConsumable.TimeUnits.Year => consumable.Value.Value * 365,

						_ => consumable.Value.Value
					};
				}

				public int Compare(IConsumable? x, IConsumable? y)
				{
					double? X = ConsumableToDouble(x);
					double? Y = ConsumableToDouble(y);

					return System.Collections.Generic.Comparer<double?>.Default.Compare(X, Y);
				}
				public bool Equals(IConsumable? x, IConsumable? y)
				{
					double? X = ConsumableToDouble(x);
					double? Y = ConsumableToDouble(y);

					if (X is null || Y is null)
						return false;

					return Equals(X, Y);
				}
				public int GetHashCode(IConsumable? obj)
				{
					return obj?.GetHashCode() ?? 0;
				}
			}
		}
    }
}
