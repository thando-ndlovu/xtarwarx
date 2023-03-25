using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Models
{
	public partial interface IStarship 
	{
		public new interface ISortKeys<T> : ITransporter.ISortKeys<T>
		{
			T HyperdriveRating { get; set; }
			T MGLT { get; set; }
			T StarshipClass { get; set; }
			T StarshipClassFlagsCount { get; set; }

			public new T GetValue(string sortkey)
			{
				return sortkey switch
				{
					ISortKeys.Keys.HyperdriveRating => HyperdriveRating,
					ISortKeys.Keys.MGLT => MGLT,
					ISortKeys.Keys.StarshipClass => StarshipClass,
					ISortKeys.Keys.StarshipClassFlagsCount => StarshipClassFlagsCount,

					_ => (this as ITransporter.ISortKeys<T>).GetValue(sortkey),
				};
			}
			public new string ToString(StringBuilder? stringBuilder = null)
			{
				return (this as ITransporter.ISortKeys<T>).ToString(
					(stringBuilder ?? new StringBuilder())
						.AppendFormat("{0}: {1}", nameof(HyperdriveRating), HyperdriveRating).AppendLine()
						.AppendFormat("{0}: {1}", nameof(MGLT), MGLT).AppendLine()
						.AppendFormat("{0}: {1}", nameof(StarshipClass), StarshipClass).AppendLine()
						.AppendFormat("{0}: {1}", nameof(StarshipClassFlagsCount), StarshipClassFlagsCount).AppendLine());
			}
		}
		public new interface ISortKeys : ISortKeys<string?>, ITransporter.ISortKeys
		{
			public new class Keys : ITransporter.ISortKeys.Keys
			{
				public const string HyperdriveRating = "HyperdriveRating";
				public const string MGLT = "MGLT";
				public const string StarshipClass = "StarshipClass";
				public const string StarshipClassFlagsCount = "StarshipClassFlagsCount";

				public new static IEnumerable<string> AsEnumerable()
				{
					return ITransporter.ISortKeys.Keys
						.AsEnumerable()
						.Append(HyperdriveRating)
						.Append(MGLT)
						.Append(StarshipClass)
						.Append(StarshipClassFlagsCount);
				}

				public static IOrderedEnumerable<IStarship> Sort(IEnumerable<IStarship> starships, params Sorter[] sorters)
				{
					IOrderedEnumerable<IStarship>? ordered = null;

					foreach (Sorter sorter in sorters)
						ordered = (sorter.SortKey, sorter.Descending) switch
						{
							(HyperdriveRating, false) => 
								ordered?.ThenBy(starship => starship.HyperdriveRating) ?? 
								starships.OrderBy(starship => starship.HyperdriveRating),
							(HyperdriveRating, true) => 
								ordered?.ThenByDescending(starship => starship.HyperdriveRating) ?? 
								starships.OrderByDescending(starship => starship.HyperdriveRating),

							(MGLT, false) => 
								ordered?.ThenBy(starship => starship.MGLT) ?? 
								starships.OrderBy(starship => starship.MGLT),
							(MGLT, true) => 
								ordered?.ThenByDescending(starship => starship.MGLT) ?? 
								starships.OrderByDescending(starship => starship.MGLT),

							(StarshipClass, false) => 
								ordered?.ThenBy(starship => starship.StarshipClass?.Class) ?? 
								starships.OrderBy(starship => starship.StarshipClass?.Class),
							(StarshipClass, true) => 
								ordered?.ThenByDescending(starship => starship.StarshipClass?.Class) ?? 
								starships.OrderByDescending(starship => starship.StarshipClass?.Class),

							(StarshipClassFlagsCount, false) => 
								ordered?.ThenBy(starship => starship.StarshipClass?.Flags?.Count()) ?? 
								starships.OrderBy(starship => starship.StarshipClass?.Flags?.Count()),
							(StarshipClassFlagsCount, true) => 
								ordered?.ThenByDescending(starship => starship.StarshipClass?.Flags?.Count()) ?? 
								starships.OrderByDescending(starship => starship.StarshipClass?.Flags?.Count()),

							(_, _) => ITransporter.ISortKeys.Keys.Sort(ordered ?? starships, sorters),
						};

					return ordered ?? starships.OrderBy(starship => starship);
				}
				public static IOrderedQueryable<IStarship> Sort(IQueryable<IStarship> starships, params Sorter[] sorters)
				{
					IOrderedQueryable<IStarship>? ordered = null;

					foreach (Sorter sorter in sorters)
						ordered = (sorter.SortKey, sorter.Descending) switch
						{
							(HyperdriveRating, false) => 
								ordered?.ThenBy(starship => starship.HyperdriveRating) ?? 
								starships.OrderBy(starship => starship.HyperdriveRating),
							(HyperdriveRating, true) => 
								ordered?.ThenByDescending(starship => starship.HyperdriveRating) ?? 
								starships.OrderByDescending(starship => starship.HyperdriveRating),

							(MGLT, false) => 
								ordered?.ThenBy(starship => starship.MGLT) ?? 
								starships.OrderBy(starship => starship.MGLT),
							(MGLT, true) => 
								ordered?.ThenByDescending(starship => starship.MGLT) ?? 
								starships.OrderByDescending(starship => starship.MGLT),

							(StarshipClass, false) => 
								ordered?.ThenBy(starship => starship.StarshipClass != null ? starship.StarshipClass.Class : string.Empty) ?? 
								starships.OrderBy(starship => starship.StarshipClass != null ? starship.StarshipClass.Class : string.Empty),
							(StarshipClass, true) => 
								ordered?.ThenByDescending(starship => starship.StarshipClass != null ? starship.StarshipClass.Class : string.Empty) ?? 
								starships.OrderByDescending(starship => starship.StarshipClass != null ? starship.StarshipClass.Class : string.Empty),

							(StarshipClassFlagsCount, false) => 
								ordered?.ThenBy(starship => starship.StarshipClass != null && starship.StarshipClass.Flags != null ? starship.StarshipClass.Flags.Count() : 0) ?? 
								starships.OrderBy(starship => starship.StarshipClass != null && starship.StarshipClass.Flags != null ? starship.StarshipClass.Flags.Count() : 0),
							(StarshipClassFlagsCount, true) => 
								ordered?.ThenByDescending(starship => starship.StarshipClass != null && starship.StarshipClass.Flags != null ? starship.StarshipClass.Flags.Count() : 0) ?? 
								starships.OrderByDescending(starship => starship.StarshipClass != null && starship.StarshipClass.Flags != null ? starship.StarshipClass.Flags.Count() : 0),

							(_, _) => ITransporter.ISortKeys.Keys.Sort(ordered ?? starships, sorters),
						};

					return ordered ?? starships.OrderBy(starship => starship);
				}
			}

			public new class Default : Default<string?>, ISortKeys
			{
				public Default() : base(null) { }
			}
			public new class Default<T> : ITransporter.ISortKeys.Default<T>, ISortKeys<T>
			{
				public Default(T defaultvalue) : base(defaultvalue) 
				{
					HyperdriveRating = defaultvalue;
					MGLT = defaultvalue;
					StarshipClass = defaultvalue;
					StarshipClassFlagsCount = defaultvalue;
				}

				public T HyperdriveRating { get; set; }
				public T MGLT { get; set; }
				public T StarshipClass { get; set; }
				public T StarshipClassFlagsCount { get; set; }
			}
		}
	}
}
