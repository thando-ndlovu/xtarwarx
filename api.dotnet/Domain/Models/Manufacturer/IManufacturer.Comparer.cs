using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
    public partial interface IManufacturer
    {
        public class Comparer : Comparer<IManufacturer>
        {
			public new class Keys : Comparer<IManufacturer>.Keys
			{
				public const string Name = "Name";
				public const string Starships = "Starships";
				public const string StarshipCount = "StarshipCount";
				public const string Vehicles = "Vehicles";
				public const string VehicleCount = "VehicleCount";
				public const string Weapons = "Weapons";
				public const string WeaponCount = "WeaponCount";

				public new static IEnumerable<string> AsEnumerable()
				{
					return Comparer<IManufacturer>.Keys.AsEnumerable()
						.Append(Name)
						.Append(Starships)
						.Append(StarshipCount)
						.Append(Vehicles)
						.Append(VehicleCount)
						.Append(Weapons)
						.Append(WeaponCount);
				}
			}

			public override int Compare(IManufacturer? x, IManufacturer? y)
			{
				return ComparerKey switch
				{
					Keys.Name => ((IComparer<string?>)(KeyComparer ??= System.Collections.Generic.Comparer<string?>.Default))
						.Compare(x?.Name, y?.Name),

					Keys.StarshipCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.StarshipIds?.Count(), y?.StarshipIds?.Count()),

					Keys.VehicleCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.VehicleIds?.Count(), y?.VehicleIds?.Count()),

					Keys.WeaponCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.WeaponIds?.Count(), y?.WeaponIds?.Count()),

					_ => base.Compare(x, y)
				};
			}
			public override bool Equals(IManufacturer? x, IManufacturer? y)
			{
				if (x is null || y is null)
					return false;

				foreach (string key in EqualityComparerKeys ?? Keys.AsEnumerable())
				{
					bool equals = key switch
					{
						Keys.Name => (x.Name is null && y.Name is null) || Equals(x.Name, y.Name),
						Keys.Starships => x.StarshipIds != null && y.StarshipIds != null && x.StarshipIds.SequenceEqual(y.StarshipIds),
						Keys.StarshipCount => (x.StarshipIds is null && y.StarshipIds is null) || Equals(x.StarshipIds?.Count(), y.StarshipIds?.Count()),
						Keys.Vehicles => x.VehicleIds != null && y.VehicleIds != null && x.VehicleIds.SequenceEqual(y.VehicleIds),
						Keys.VehicleCount => (x.VehicleIds is null && y.VehicleIds is null) || Equals(x.VehicleIds?.Count(), y.VehicleIds?.Count()),
						Keys.Weapons => x.WeaponIds != null && y.WeaponIds != null && x.WeaponIds.SequenceEqual(y.WeaponIds),
						Keys.WeaponCount => (x.WeaponIds is null && y.WeaponIds is null) || Equals(x.WeaponIds?.Count(), y.WeaponIds?.Count()),

						_ => base.Equals(x, y),
					};

					if (equals is false)
						return false;
				}

				return true;
			}
			public override int GetHashCode(IManufacturer obj)
			{
				return base.GetHashCode(obj);
			}
		}
    }
}
