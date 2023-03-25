using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
    public partial interface IPlanet
    {
        public class Comparer : Comparer<IPlanet>
        {
			public new class Keys : Comparer<IPlanet>.Keys
			{
				public const string Climates = "Climates";
				public const string ClimateCount = "ClimateCount";
				public const string Diameter = "Diameter";
				public const string Gravity = "Gravity";
				public const string Name = "Name";
				public const string OrbitalPeriod = "OrbitalPeriod";
				public const string Population = "Population";
				public const string Residents = "Residents";
				public const string ResidentCount = "ResidentCount";
				public const string RotationalPeriod = "RotationalPeriod";
				public const string SurfaceWater = "SurfaceWater";
				public const string Terrains = "Terrains";
				public const string TerrainCount = "TerrainCount";

				public new static IEnumerable<string> AsEnumerable()
				{
					return Comparer<IPlanet>.Keys.AsEnumerable()
						.Append(Climates)
						.Append(ClimateCount)
						.Append(Diameter)
						.Append(Gravity)
						.Append(Name)
						.Append(OrbitalPeriod)
						.Append(Population)
						.Append(Residents)
						.Append(ResidentCount)
						.Append(RotationalPeriod)
						.Append(SurfaceWater)
						.Append(Terrains)
						.Append(TerrainCount);
				}
			}

			public override int Compare(IPlanet? x, IPlanet? y)
			{
				return ComparerKey switch
				{
					Keys.ClimateCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.Climates?.Count(), y?.Climates?.Count()),

					Keys.Diameter => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.Diameter, y?.Diameter),

					Keys.Gravity => ((IComparer<double?>)(KeyComparer ??= System.Collections.Generic.Comparer<double?>.Default))
						.Compare(x?.Gravity, y?.Gravity),

					Keys.Name => ((IComparer<string?>)(KeyComparer ??= System.Collections.Generic.Comparer<string?>.Default))
						.Compare(x?.Name, y?.Name),

					Keys.OrbitalPeriod => ((IComparer<TimeSpan?>)(KeyComparer ??= System.Collections.Generic.Comparer<TimeSpan?>.Default))
						.Compare(x?.OrbitalPeriod, y?.OrbitalPeriod),

					Keys.Population => ((IComparer<long?>)(KeyComparer ??= System.Collections.Generic.Comparer<long?>.Default))
						.Compare(x?.Population, y?.Population),

					Keys.ResidentCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.ResidentIds?.Count(), y?.ResidentIds?.Count()),

					Keys.RotationalPeriod => ((IComparer<TimeSpan?>)(KeyComparer ??= System.Collections.Generic.Comparer<TimeSpan?>.Default))
						.Compare(x?.RotationalPeriod, y?.RotationalPeriod),

					Keys.SurfaceWater => ((IComparer<double?>)(KeyComparer ??= System.Collections.Generic.Comparer<double?>.Default))
						.Compare(x?.SurfaceWater, y?.SurfaceWater),

					Keys.TerrainCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.Terrains?.Count(), y?.Terrains?.Count()),

					_ => base.Compare(x, y)
				};
			}
			public override bool Equals(IPlanet? x, IPlanet? y)
			{
				if (x is null || y is null)
					return false;

				foreach (string key in EqualityComparerKeys ?? Keys.AsEnumerable())
				{
					bool equals = key switch
					{
						Keys.Climates => x.Climates != null && y.Climates != null && x.Climates.SequenceEqual(y.Climates, new IClimate.Comparer()),
						Keys.ClimateCount => (x.Climates is null && y.Climates is null) || Equals(x.Climates?.Count(), y.Climates?.Count()),
						Keys.Diameter => (x.Diameter is null && y.Diameter is null) || Equals(x.Diameter, y.Diameter),
						Keys.Gravity => (x.Gravity is null && y.Gravity is null) || Equals(x.Gravity, y.Gravity),
						Keys.Name => (x.Name is null && y.Name is null) || Equals(x.Name, y.Name),
						Keys.OrbitalPeriod => (x.OrbitalPeriod is null && y.OrbitalPeriod is null) || Equals(x.OrbitalPeriod, y.OrbitalPeriod),
						Keys.Population => (x.Population is null && y.Population is null) || Equals(x.Population, y.Population),
						Keys.Residents => x.ResidentIds != null && y.ResidentIds != null && x.ResidentIds.SequenceEqual(y.ResidentIds),
						Keys.ResidentCount => (x.ResidentIds is null && y.ResidentIds is null) || Equals(x.ResidentIds?.Count(), y.ResidentIds?.Count()),
						Keys.RotationalPeriod => (x.RotationalPeriod is null && y.RotationalPeriod is null) || Equals(x.RotationalPeriod, y.RotationalPeriod),
						Keys.SurfaceWater => (x.SurfaceWater is null && y.SurfaceWater is null) || Equals(x.SurfaceWater, y.SurfaceWater),
						Keys.Terrains => x.Terrains != null && y.Terrains != null && x.Terrains.SequenceEqual(y.Terrains, new ITerrain.Comparer()),
						Keys.TerrainCount => (x.Terrains is null && y.Terrains is null) || Equals(x.Terrains?.Count(), y.Terrains?.Count()),

						_ => base.Equals(x, y),
					};

					if (equals is false)
						return false;
				}

				return true;
			}
			public override int GetHashCode(IPlanet obj)
			{
				return base.GetHashCode(obj);
			}
		}
    }
}
