using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
    public partial interface IWeapon
    {
        public class Comparer : Comparer<IWeapon>
        {
			public new class Keys : Comparer<IWeapon>.Keys
			{
				public const string Manufacturers = "Manufacturers";
				public const string ManufacturerCount = "ManufacturerCount";
				public const string Model = "Model";
				public const string Name = "Name";
				public const string WeaponClass = "WeaponClass";

				public new static IEnumerable<string> AsEnumerable()
				{
					return Comparer<IWeapon>.Keys.AsEnumerable()
						.Append(Manufacturers)
						.Append(ManufacturerCount)
						.Append(Model)
						.Append(Name)
						.Append(WeaponClass);
				}
			}

			public override int Compare(IWeapon? x, IWeapon? y)
			{
				return ComparerKey switch
				{
					Keys.ManufacturerCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.ManufacturerIds?.Count(), y?.ManufacturerIds?.Count()),

					Keys.Model => ((IComparer<string?>)(KeyComparer ??= System.Collections.Generic.Comparer<string?>.Default))
						.Compare(x?.Model, y?.Model),

					Keys.Name => ((IComparer<string?>)(KeyComparer ??= System.Collections.Generic.Comparer<string?>.Default))
						.Compare(x?.Name, y?.Name),

					Keys.WeaponClass => ((IComparer<string?>)(KeyComparer ??= System.Collections.Generic.Comparer<string?>.Default))
						.Compare(x?.WeaponClass?.Class, y?.WeaponClass?.Class),

					_ => base.Compare(x, y)
				};
			}
			public override bool Equals(IWeapon? x, IWeapon? y)
			{
				if (x is null || y is null)
					return false;

				foreach (string key in EqualityComparerKeys ?? Keys.AsEnumerable())
				{
					bool equals = key switch
					{
						Keys.Manufacturers => x.ManufacturerIds != null && y.ManufacturerIds != null && x.ManufacturerIds.SequenceEqual(y.ManufacturerIds),
						Keys.ManufacturerCount => (x.ManufacturerIds is null && y.ManufacturerIds is null) || Equals(x.ManufacturerIds?.Count(), y.ManufacturerIds?.Count()),
						Keys.Model => (x.Model is null && y.Model is null) || Equals(x.Model, y.Model),
						Keys.Name => (x.Name is null && y.Name is null) || Equals(x.Name, y.Name),
						Keys.WeaponClass => new IWeaponClass.Comparer().Equals(x.WeaponClass, y.WeaponClass),

						_ => base.Equals(x, y),
					};

					if (equals is false)
						return false;
				}

				return true;
			}
			public override int GetHashCode(IWeapon obj)
			{
				return base.GetHashCode(obj);
			}
		}
    }
}
