using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Models
{
	public partial interface IFaction 
	{
		public new interface ISortKeys<T> : IStarWarsModel.ISortKeys<T> 
		{
			T AlliedCharacterCount { get; set; }
			T AlliedFactionCount { get; set; }
			T LeaderCount { get; set; }
			T MemberCharacterCount { get; set; }
			T MemberFactionCount { get; set; }
			T Name { get; set; }
			T OrganizationTypes { get; set; }

			public new T GetValue(string sortkey)
			{
				return sortkey switch
				{
					ISortKeys.Keys.AlliedCharacterCount => AlliedCharacterCount,
					ISortKeys.Keys.AlliedFactionCount => AlliedFactionCount,
					ISortKeys.Keys.LeaderCount => LeaderCount,
					ISortKeys.Keys.MemberCharacterCount => MemberCharacterCount,
					ISortKeys.Keys.MemberFactionCount => MemberFactionCount,
					ISortKeys.Keys.Name => Name,
					ISortKeys.Keys.OrganizationTypes => OrganizationTypes,

					_ => (this as IStarWarsModel.ISortKeys<T>).GetValue(sortkey),
				};
			}
			public new string ToString(StringBuilder? stringBuilder = null)
			{
				return (this as IStarWarsModel.ISortKeys<T>).ToString(
					(stringBuilder ?? new StringBuilder())
						.AppendFormat("{0}: {1}", nameof(AlliedCharacterCount), AlliedCharacterCount).AppendLine()
						.AppendFormat("{0}: {1}", nameof(AlliedFactionCount), AlliedFactionCount).AppendLine()
						.AppendFormat("{0}: {1}", nameof(LeaderCount), LeaderCount).AppendLine()
						.AppendFormat("{0}: {1}", nameof(MemberCharacterCount), MemberCharacterCount).AppendLine()
						.AppendFormat("{0}: {1}", nameof(MemberFactionCount), MemberFactionCount).AppendLine()
						.AppendFormat("{0}: {1}", nameof(Name), Name).AppendLine()
						.AppendFormat("{0}: {1}", nameof(OrganizationTypes), OrganizationTypes).AppendLine());
			}
		}
		public new interface ISortKeys : ISortKeys<string?>, IStarWarsModel.ISortKeys
		{
			public new class Keys : IStarWarsModel.ISortKeys.Keys
			{
				public const string AlliedCharacterCount = "AlliedCharacterCount";
				public const string AlliedFactionCount = "AlliedFactionCount";
				public const string LeaderCount = "LeaderCount";
				public const string MemberCharacterCount = "MemberCharacterCount";
				public const string MemberFactionCount = "MemberFactionCount";
				public const string Name = "Name";
				public const string OrganizationTypes = "OrganizationTypes";

				public new static IEnumerable<string> AsEnumerable()
				{
					return IStarWarsModel.ISortKeys.Keys
						.AsEnumerable()
						.Append(AlliedCharacterCount)
						.Append(AlliedFactionCount)
						.Append(LeaderCount)
						.Append(MemberCharacterCount)
						.Append(MemberFactionCount)
						.Append(Name)
						.Append(OrganizationTypes);
				}

				public static IOrderedEnumerable<IFaction> Sort(IEnumerable<IFaction> factions, params Sorter[] sorters)
				{
					IOrderedEnumerable<IFaction>? ordered = null;

					foreach (Sorter sorter in sorters)
						ordered = (sorter.SortKey, sorter.Descending) switch
						{
							(AlliedCharacterCount, false) => 
								ordered?.ThenBy(faction => faction.AlliedCharacterIds?.Count()) ??
								factions.OrderBy(faction => faction.AlliedCharacterIds?.Count()),
							(AlliedCharacterCount, true) => 
								ordered?.ThenByDescending(faction => faction.AlliedCharacterIds?.Count()) ??
								factions.OrderByDescending(faction => faction.AlliedCharacterIds?.Count()),

							(AlliedFactionCount, false) => 
								ordered?.ThenBy(faction => faction.AlliedFactionIds?.Count()) ??
								factions.OrderBy(faction => faction.AlliedFactionIds?.Count()),
							(AlliedFactionCount, true) => 
								ordered?.ThenByDescending(faction => faction.AlliedFactionIds?.Count()) ??
								factions.OrderByDescending(faction => faction.AlliedFactionIds?.Count()),

							(LeaderCount, false) => 
								ordered?.ThenBy(faction => faction.LeaderIds?.Count()) ??
								factions.OrderBy(faction => faction.LeaderIds?.Count()),
							(LeaderCount, true) => 
								ordered?.ThenByDescending(faction => faction.LeaderIds?.Count()) ??
								factions.OrderByDescending(faction => faction.LeaderIds?.Count()),

							(MemberCharacterCount, false) => 
								ordered?.ThenBy(faction => faction.MemberCharacterIds?.Count()) ??
								factions.OrderBy(faction => faction.MemberCharacterIds?.Count()),
							(MemberCharacterCount, true) => 
								ordered?.ThenByDescending(faction => faction.MemberCharacterIds?.Count()) ??
								factions.OrderByDescending(faction => faction.MemberCharacterIds?.Count()),

							(MemberFactionCount, false) => 
								ordered?.ThenBy(faction => faction.MemberFactionIds?.Count()) ??
								factions.OrderBy(faction => faction.MemberFactionIds?.Count()),
							(MemberFactionCount, true) => 
								ordered?.ThenByDescending(faction => faction.MemberFactionIds?.Count()) ??
								factions.OrderByDescending(faction => faction.MemberFactionIds?.Count()),

							(Name, false) => 
								ordered?.ThenBy(faction => faction.Name) ??
								factions.OrderBy(faction => faction.Name),
							(Name, true) => 
								ordered?.ThenByDescending(faction => faction.Name) ??
								factions.OrderByDescending(faction => faction.Name),

							(OrganizationTypes, false) => 
								ordered?.ThenBy(faction => faction.OrganizationTypes?.OrderBy(organizationtype => organizationtype).FirstOrDefault()) ??
								factions.OrderBy(faction => faction.OrganizationTypes?.OrderBy(organizationtype => organizationtype).FirstOrDefault()),
							(OrganizationTypes, true) => 
								ordered?.ThenByDescending(faction => faction.OrganizationTypes?.OrderBy(organizationtype => organizationtype).FirstOrDefault()) ??
								factions.OrderByDescending(faction => faction.OrganizationTypes?.OrderBy(organizationtype => organizationtype).FirstOrDefault()),

							(_, _) => IStarWarsModel.ISortKeys.Keys.Sort(ordered ?? factions, sorters),
						};

					return ordered ?? factions.OrderBy(faction => faction);
				}
				public static IOrderedQueryable<IFaction> Sort(IQueryable<IFaction> factions, params Sorter[] sorters)
				{
					IOrderedQueryable<IFaction>? ordered = null;

					foreach (Sorter sorter in sorters)
						ordered = (sorter.SortKey, sorter.Descending) switch
						{
							(AlliedCharacterCount, false) => 
								ordered?.ThenBy(faction => faction.AlliedCharacterIds != null ? faction.AlliedCharacterIds.Count() : 0) ??
								factions.OrderBy(faction => faction.AlliedCharacterIds != null ? faction.AlliedCharacterIds.Count() : 0),
							(AlliedCharacterCount, true) => 
								ordered?.ThenByDescending(faction => faction.AlliedCharacterIds != null ? faction.AlliedCharacterIds.Count() : 0) ??
								factions.OrderByDescending(faction => faction.AlliedCharacterIds != null ? faction.AlliedCharacterIds.Count() : 0),

							(AlliedFactionCount, false) => 
								ordered?.ThenBy(faction => faction.AlliedFactionIds != null ? faction.AlliedFactionIds.Count() : 0) ??
								factions.OrderBy(faction => faction.AlliedFactionIds != null ? faction.AlliedFactionIds.Count() : 0),
							(AlliedFactionCount, true) => 
								ordered?.ThenByDescending(faction => faction.AlliedFactionIds != null ? faction.AlliedFactionIds.Count() : 0) ??
								factions.OrderByDescending(faction => faction.AlliedFactionIds != null ? faction.AlliedFactionIds.Count() : 0),

							(LeaderCount, false) => 
								ordered?.ThenBy(faction => faction.LeaderIds != null ? faction.LeaderIds.Count() : 0) ??
								factions.OrderBy(faction => faction.LeaderIds != null ? faction.LeaderIds.Count() : 0),
							(LeaderCount, true) => 
								ordered?.ThenByDescending(faction => faction.LeaderIds != null ? faction.LeaderIds.Count() : 0) ??
								factions.OrderByDescending(faction => faction.LeaderIds != null ? faction.LeaderIds.Count() : 0),

							(MemberCharacterCount, false) => 
								ordered?.ThenBy(faction => faction.MemberCharacterIds != null ? faction.MemberCharacterIds.Count() : 0) ??
								factions.OrderBy(faction => faction.MemberCharacterIds != null ? faction.MemberCharacterIds.Count() : 0),
							(MemberCharacterCount, true) => 
								ordered?.ThenByDescending(faction => faction.MemberCharacterIds != null ? faction.MemberCharacterIds.Count() : 0) ??
								factions.OrderByDescending(faction => faction.MemberCharacterIds != null ? faction.MemberCharacterIds.Count() : 0),

							(MemberFactionCount, false) => 
								ordered?.ThenBy(faction => faction.MemberFactionIds != null ? faction.MemberFactionIds.Count() : 0) ??
								factions.OrderBy(faction => faction.MemberFactionIds != null ? faction.MemberFactionIds.Count() : 0),
							(MemberFactionCount, true) => 
								ordered?.ThenByDescending(faction => faction.MemberFactionIds != null ? faction.MemberFactionIds.Count() : 0) ??
								factions.OrderByDescending(faction => faction.MemberFactionIds != null ? faction.MemberFactionIds.Count() : 0),

							(Name, false) => 
								ordered?.ThenBy(faction => faction.Name) ??
								factions.OrderBy(faction => faction.Name),
							(Name, true) => 
								ordered?.ThenByDescending(faction => faction.Name) ??
								factions.OrderByDescending(faction => faction.Name),

							(OrganizationTypes, false) => 
								ordered?.ThenBy(faction => faction.OrganizationTypes != null ? faction.OrganizationTypes.OrderBy(organizationtype => organizationtype).FirstOrDefault() : string.Empty) ??
								factions.OrderBy(faction => faction.OrganizationTypes != null ? faction.OrganizationTypes.OrderBy(organizationtype => organizationtype).FirstOrDefault() : string.Empty),
							(OrganizationTypes, true) => 
								ordered?.ThenByDescending(faction => faction.OrganizationTypes != null ? faction.OrganizationTypes.OrderBy(organizationtype => organizationtype).FirstOrDefault() : string.Empty) ??
								factions.OrderByDescending(faction => faction.OrganizationTypes != null ? faction.OrganizationTypes.OrderBy(organizationtype => organizationtype).FirstOrDefault() : string.Empty),

							(_, _) => IStarWarsModel.ISortKeys.Keys.Sort(ordered ?? factions, sorters),
						};

					return ordered ?? factions.OrderBy(faction => faction);
				}
			}

			public new class Default : Default<string?>, ISortKeys
			{
				public Default() : base(null) { }
			}
			public new class Default<T> : IStarWarsModel.ISortKeys.Default<T>, ISortKeys<T>
			{
				public Default(T defaultvalue) : base(defaultvalue)
				{
					AlliedCharacterCount = defaultvalue;
					AlliedFactionCount = defaultvalue;
					LeaderCount = defaultvalue;
					MemberCharacterCount = defaultvalue;
					MemberFactionCount = defaultvalue;
					Name = defaultvalue;
					OrganizationTypes = defaultvalue;
				}

				public T AlliedCharacterCount { get; set; }
				public T AlliedFactionCount { get; set; }
				public T LeaderCount { get; set; }
				public T MemberCharacterCount { get; set; }
				public T MemberFactionCount { get; set; }
				public T Name { get; set; }
				public T OrganizationTypes { get; set; }
			}
		}
	}
}
