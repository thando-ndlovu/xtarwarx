using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
    public partial interface ISpecie
    {
        public class Comparer : Comparer<ISpecie>
        {
			public new class Keys : Comparer<ISpecie>.Keys
			{
				public const string AverageHeight = "AverageHeight";
				public const string AverageLifespan = "AverageLifespan";
				public const string Characters = "Characters";
				public const string CharacterCount = "CharacterCount";
				public const string Classification = "Classification";
				public const string Designation = "Designation";
				public const string EyeColors = "EyeColors";
				public const string EyeColorCount = "EyeColorCount";
				public const string HairColors = "HairColors";
				public const string HairColorCount = "HairColorCount";
				public const string Language = "Language";
				public const string Name = "Name";
				public const string SkinColors = "SkinColors";
				public const string SkinColorCount = "SkinColorCount";

				public new static IEnumerable<string> AsEnumerable()
				{
					return Comparer<ISpecie>.Keys.AsEnumerable()
						.Append(AverageHeight)
						.Append(AverageLifespan)
						.Append(Characters)
						.Append(CharacterCount)
						.Append(Classification)
						.Append(Designation)
						.Append(EyeColors)
						.Append(EyeColorCount)
						.Append(HairColors)
						.Append(HairColorCount)
						.Append(Language)
						.Append(Name)
						.Append(SkinColors)
						.Append(SkinColorCount);
				}
			}

			public override int Compare(ISpecie? x, ISpecie? y)
			{
				return ComparerKey switch
				{
					Keys.AverageHeight => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.AverageHeight, y?.AverageHeight),

					Keys.AverageLifespan => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.AverageLifespan, y?.AverageLifespan),

					Keys.CharacterCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.CharacterIds?.Count(), y?.CharacterIds?.Count()),

					Keys.Classification => ((IComparer<string?>)(KeyComparer ??= System.Collections.Generic.Comparer<string?>.Default))
						.Compare(x?.Classification, y?.Classification),

					Keys.Designation => ((IComparer<string?>)(KeyComparer ??= System.Collections.Generic.Comparer<string?>.Default))
						.Compare(x?.Designation, y?.Designation),

					Keys.EyeColorCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.EyeColors?.Count(), y?.EyeColors?.Count()),

					Keys.HairColorCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.HairColors?.Count(), y?.HairColors?.Count()),

					Keys.Language => ((IComparer<string?>)(KeyComparer ??= System.Collections.Generic.Comparer<string?>.Default))
						.Compare(x?.Language, y?.Language),

					Keys.Name => ((IComparer<string?>)(KeyComparer ??= System.Collections.Generic.Comparer<string?>.Default))
						.Compare(x?.Name, y?.Name),

					Keys.SkinColorCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.SkinColors?.Count(), y?.SkinColors?.Count()),

					_ => base.Compare(x, y)
				};
			}
			public override bool Equals(ISpecie? x, ISpecie? y)
			{
				if (x is null || y is null)
					return false;

				foreach (string key in EqualityComparerKeys ?? Keys.AsEnumerable())
				{
					bool equals = key switch
					{
						Keys.AverageHeight => (x.AverageHeight is null && y.AverageHeight is null) || Equals(x.AverageHeight, y.AverageHeight),
						Keys.AverageLifespan => (x.AverageLifespan is null && y.AverageLifespan is null) || Equals(x.AverageLifespan, y.AverageLifespan),
						Keys.Characters => x.CharacterIds != null && y.CharacterIds != null && x.CharacterIds.SequenceEqual(y.CharacterIds),
						Keys.CharacterCount => (x.CharacterIds is null && y.CharacterIds is null) || Equals(x.CharacterIds?.Count(), y.CharacterIds?.Count()),
						Keys.Classification => (x.Classification is null && y.Classification is null) || Equals(x.Classification, y.Classification),
						Keys.Designation => (x.Designation is null && y.Designation is null) || Equals(x.Designation, y.Designation),
						Keys.EyeColors => x.EyeColors != null && y.EyeColors != null && x.EyeColors.SequenceEqual(y.EyeColors),
						Keys.EyeColorCount => (x.EyeColors is null && y.EyeColors is null) || Equals(x.EyeColors?.Count(), y.EyeColors?.Count()),
						Keys.HairColors => x.HairColors != null && y.HairColors != null && x.HairColors.SequenceEqual(y.HairColors),
						Keys.HairColorCount => (x.HairColors is null && y.HairColors is null) || Equals(x.HairColors?.Count(), y.HairColors?.Count()),
						Keys.Language => (x.Language is null && y.Language is null) || Equals(x.Language, y.Language),
						Keys.Name => (x.Name is null && y.Name is null) || Equals(x.Name, y.Name),
						Keys.SkinColors => x.SkinColors != null && y.SkinColors != null && x.SkinColors.SequenceEqual(y.SkinColors),
						Keys.SkinColorCount => (x.SkinColors is null && y.SkinColors is null) || Equals(x.SkinColors?.Count(), y.SkinColors?.Count()),

						_ => base.Equals(x, y),
					};

					if (equals is false)
						return false;
				}

				return true;
			}
			public override int GetHashCode(ISpecie obj)
			{
				return base.GetHashCode(obj);
			}
		}
    }
}
