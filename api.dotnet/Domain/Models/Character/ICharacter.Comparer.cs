using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
    public partial interface ICharacter
    {
        public class Comparer : Comparer<ICharacter>
        {
			public new class Keys : Comparer<ICharacter>.Keys
			{
				public const string BirthYear = "BirthYear";
				public const string EyeColors = "EyeColors";
				public const string EyeColorCount = "EyeColorCount";
				public const string HairColors = "HairColors";
				public const string HairColorCount = "HairColorCount";
				public const string Height = "Height";
				public const string Mass = "Mass";
				public const string Name = "Name";
				public const string Sex = "Sex";
				public const string SkinColors = "SkinColors";
				public const string SkinColorCount = "SkinColorCount";

				public new static IEnumerable<string> AsEnumerable()
				{
					return Comparer<ICharacter>.Keys.AsEnumerable()
						.Append(BirthYear)
						.Append(EyeColors)
						.Append(EyeColorCount)
						.Append(HairColors)
						.Append(HairColorCount)
						.Append(Height)
						.Append(Mass)
						.Append(Name)
						.Append(Sex)
						.Append(SkinColors)
						.Append(SkinColorCount);
				}
			}

			public override int Compare(ICharacter? x, ICharacter? y)
			{
				return ComparerKey switch
				{
					Keys.BirthYear => ((IComparer<double?>)(KeyComparer ??= System.Collections.Generic.Comparer<double?>.Default))
						.Compare(x?.BirthYear, y?.BirthYear),

					Keys.EyeColorCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.EyeColors?.Count(), y?.EyeColors?.Count()),

					Keys.HairColorCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.HairColors?.Count(), y?.HairColors?.Count()),

					Keys.Height => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.Height, y?.Height),

					Keys.Mass => ((IComparer<double?>)(KeyComparer ??= System.Collections.Generic.Comparer<double?>.Default))
						.Compare(x?.Mass, y?.Mass),

					Keys.Name => ((IComparer<string?>)(KeyComparer ??= System.Collections.Generic.Comparer<string?>.Default))
						.Compare(x?.Name, y?.Name),

					Keys.Sex => ((IComparer<string?>)(KeyComparer ??= System.Collections.Generic.Comparer<string?>.Default))
						.Compare(x?.Sex, y?.Sex),

					Keys.SkinColorCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.SkinColors?.Count(), y?.SkinColors?.Count()),

					_ => base.Compare(x, y),
				};
			}
			public override bool Equals(ICharacter? x, ICharacter? y)
			{
				if (x is null || y is null)
					return false;

				foreach (string key in EqualityComparerKeys ?? Keys.AsEnumerable())
				{
					bool equals = key switch
					{
						Keys.BirthYear => (x.BirthYear is null && y.BirthYear is null) || Equals(x.BirthYear, y.BirthYear),
						Keys.EyeColors => x.EyeColors != null && y.EyeColors != null && x.EyeColors.SequenceEqual(y.EyeColors),
						Keys.EyeColorCount => (x.EyeColors is null && y.EyeColors is null) || Equals(x.EyeColors?.Count(), y.EyeColors?.Count()),
						Keys.HairColors => x.HairColors != null && y.HairColors != null && x.HairColors.SequenceEqual(y.HairColors),
						Keys.HairColorCount => (x.HairColors is null && y.HairColors is null) || Equals(x.HairColors?.Count(), y.HairColors?.Count()),
						Keys.Height => (x.Height is null && y.Height is null) || Equals(x.Height, y.Height),
						Keys.Mass => (x.Mass is null && y.Mass is null) || Equals(x.Mass, y.Mass),
						Keys.Name => (x.Name is null && y.Name is null) || Equals(x.Name, y.Name),
						Keys.Sex => (x.Sex is null && y.Sex is null) || Equals(x.Sex, y.Sex),
						Keys.SkinColors => x.SkinColors != null && y.SkinColors != null && x.SkinColors.SequenceEqual(y.SkinColors),
						Keys.SkinColorCount => (x.SkinColors is null && y.SkinColors is null) || Equals(x.SkinColors?.Count(), y.SkinColors?.Count()),

						_ => base.Equals(x, y),
					};

					if (equals is false)
						return false;
				}

				return true;
			}
			public override int GetHashCode(ICharacter obj)
			{
				return base.GetHashCode(obj);
			}
		}
    }
}
