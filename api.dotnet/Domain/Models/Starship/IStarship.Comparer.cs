using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
    public partial interface IStarship
    {
        public class Comparer : Comparer<IStarship>
        {
			public new class Keys : Comparer<IStarship>.Keys
			{
				public const string HyperdriveRating = "HyperdriveRating";
				public const string MGLT = "MGLT";
				public const string StarshipClass = "StarshipClass";

				public new static IEnumerable<string> AsEnumerable()
				{
					return Comparer<IStarship>.Keys.AsEnumerable()
						.Append(HyperdriveRating)
						.Append(MGLT)
						.Append(StarshipClass);
				}
			}

			public override int Compare(IStarship? x, IStarship? y)
			{
				return ComparerKey switch
				{
					Keys.HyperdriveRating => ((IComparer<double?>)(KeyComparer ??= System.Collections.Generic.Comparer<double?>.Default))
						.Compare(x?.HyperdriveRating, y?.HyperdriveRating),

					Keys.MGLT => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.MGLT, y?.MGLT),

					Keys.StarshipClass => ((IComparer<string?>)(KeyComparer ??= System.Collections.Generic.Comparer<string?>.Default))
						.Compare(x?.StarshipClass?.Class, y?.StarshipClass?.Class),

					_ => base.Compare(x, y)
				};
			}
			public override bool Equals(IStarship? x, IStarship? y)
			{
				if (x is null || y is null)
					return false;

				foreach (string key in EqualityComparerKeys ?? Keys.AsEnumerable())
				{
					bool equals = key switch
					{
						Keys.HyperdriveRating => (x.HyperdriveRating is null && y.HyperdriveRating is null) || Equals(x.HyperdriveRating, y.HyperdriveRating),
						Keys.MGLT => (x.MGLT is null && y.MGLT is null) || Equals(x.MGLT, y.MGLT),
						Keys.StarshipClass => (x.StarshipClass is null && y.StarshipClass is null) || new IStarshipClass.Comparer().Equals(x.StarshipClass, y.StarshipClass),

						_ => base.Equals(x, y),
					};

					if (equals is false)
						return false;
				}

				return true;
			}
			public override int GetHashCode(IStarship obj)
			{
				return base.GetHashCode(obj);
			}
		}
    }
}
