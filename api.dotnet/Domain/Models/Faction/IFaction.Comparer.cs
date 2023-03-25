using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
    public partial interface IFaction
    {
        public class Comparer : Comparer<IFaction>
        {
			public new class Keys : Comparer<IFaction>.Keys
			{
				public const string AlliedCharacters = "AlliedCharacters";
				public const string AlliedCharacterCount = "AlliedCharacterCount";
				public const string AlliedFactions = "AlliedFactions";
				public const string AlliedFactionCount = "AlliedFactionCount";
				public const string Leaders = "Leaders";
				public const string LeaderCount = "LeaderCount";
				public const string MemberCharacters = "MemberCharacters";
				public const string MemberCharacterCount = "MemberCharacterCount";
				public const string MemberFactions = "MemberFactions";
				public const string MemberFactionCount = "MemberFactionCount";
				public const string Name = "Name";

				public new static IEnumerable<string> AsEnumerable()
				{
					return Comparer<IFaction>.Keys.AsEnumerable()
						.Append(AlliedCharacters)
						.Append(AlliedCharacterCount)
						.Append(AlliedFactions)
						.Append(AlliedFactionCount)
						.Append(Leaders)
						.Append(LeaderCount)
						.Append(MemberCharacters)
						.Append(MemberCharacterCount)
						.Append(MemberFactions)
						.Append(MemberFactionCount)
						.Append(Name);
				}
			}

			public override int Compare(IFaction? x, IFaction? y)
			{
				return ComparerKey switch
				{
					Keys.AlliedCharacterCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.AlliedCharacterIds?.Count(), y?.AlliedCharacterIds?.Count()),

					Keys.AlliedFactionCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.AlliedFactionIds?.Count(), y?.AlliedFactionIds?.Count()),

					Keys.LeaderCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.LeaderIds?.Count(), y?.LeaderIds?.Count()),

					Keys.MemberCharacterCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.MemberCharacterIds?.Count(), y?.MemberCharacterIds?.Count()),

					Keys.MemberFactionCount => ((IComparer<int?>)(KeyComparer ??= System.Collections.Generic.Comparer<int?>.Default))
						.Compare(x?.MemberFactionIds?.Count(), y?.MemberFactionIds?.Count()),

					Keys.Name => ((IComparer<string?>)(KeyComparer ??= System.Collections.Generic.Comparer<string?>.Default))
						.Compare(x?.Name, y?.Name),

					_ => base.Compare(x, y)
				};
			}
			public override bool Equals(IFaction? x, IFaction? y)
			{
				if (x is null || y is null)
					return false;

				foreach (string key in EqualityComparerKeys ?? Keys.AsEnumerable())
				{
					bool equals = key switch
					{
						Keys.AlliedCharacters => x.AlliedCharacterIds != null && y.AlliedCharacterIds != null && x.AlliedCharacterIds.SequenceEqual(y.AlliedCharacterIds),
						Keys.AlliedCharacterCount => (x.AlliedCharacterIds is null && y.AlliedCharacterIds is null) || Equals(x.AlliedCharacterIds?.Count(), y.AlliedCharacterIds?.Count()),
						Keys.AlliedFactions => x.AlliedFactionIds != null && y.AlliedFactionIds != null && x.AlliedFactionIds.SequenceEqual(y.AlliedFactionIds),
						Keys.AlliedFactionCount => (x.AlliedFactionIds is null && y.AlliedFactionIds is null) || Equals(x.AlliedFactionIds?.Count(), y.AlliedFactionIds?.Count()),
						Keys.Leaders => x.LeaderIds != null && y.LeaderIds != null && x.LeaderIds.SequenceEqual(y.LeaderIds),
						Keys.LeaderCount => (x.LeaderIds is null && y.LeaderIds is null) || Equals(x.LeaderIds?.Count(), y.LeaderIds?.Count()),
						Keys.MemberCharacters => x.MemberCharacterIds != null && y.MemberCharacterIds != null && x.MemberCharacterIds.SequenceEqual(y.MemberCharacterIds),
						Keys.MemberCharacterCount => (x.MemberCharacterIds is null && y.MemberCharacterIds is null) || Equals(x.MemberCharacterIds?.Count(), y.MemberCharacterIds?.Count()),
						Keys.MemberFactions => x.MemberFactionIds != null && y.MemberFactionIds != null && x.MemberFactionIds.SequenceEqual(y.MemberFactionIds),
						Keys.MemberFactionCount => (x.MemberFactionIds is null && y.MemberFactionIds is null) || Equals(x.MemberFactionIds?.Count(), y.MemberFactionIds?.Count()),
						Keys.Name => (x.Name is null && y.Name is null) || Equals(x.Name, y.Name),

						_ => base.Equals(x, y),
					};

					if (equals is false)
						return false;
				}

				return true;
			}
			public override int GetHashCode(IFaction obj)
			{
				return base.GetHashCode(obj);
			}
		}
    }
}
