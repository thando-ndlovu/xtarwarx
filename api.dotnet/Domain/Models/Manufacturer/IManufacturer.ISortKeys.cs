using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Models
{
	public partial interface IManufacturer : IStarWarsModel
	{
		public new interface ISortKeys<T> : IStarWarsModel.ISortKeys<T> 
		{
			T Name { get; set; }
			T StarshipsCount { get; set; }
			T VehiclesCount { get; set; }
			T WeaponsCount { get; set; }

			public new T GetValue(string sortkey)
			{
				return sortkey switch
				{
					ISortKeys.Keys.Name => Name,
					ISortKeys.Keys.StarshipsCount => StarshipsCount,
					ISortKeys.Keys.VehiclesCount => VehiclesCount,
					ISortKeys.Keys.WeaponsCount => WeaponsCount,

					_ => (this as IStarWarsModel.ISortKeys<T>).GetValue(sortkey),
				};
			}
			public new string ToString(StringBuilder? stringBuilder = null)
			{
				(stringBuilder ?? new StringBuilder())
					.AppendFormat("{0}: {1}", nameof(Name), Name).AppendLine()
					.AppendFormat("{0}: {1}", nameof(StarshipsCount), StarshipsCount).AppendLine()
					.AppendFormat("{0}: {1}", nameof(VehiclesCount), VehiclesCount).AppendLine()
					.AppendFormat("{0}: {1}", nameof(WeaponsCount), WeaponsCount).AppendLine();

				return (this as IStarWarsModel.ISortKeys<T>).ToString(stringBuilder);
			}
		}
		public new interface ISortKeys : ISortKeys<string?>, IStarWarsModel.ISortKeys
		{
			public new class Keys : IStarWarsModel.ISortKeys.Keys
			{
				public const string Name = "Name";
				public const string StarshipsCount = "StarshipsCount";
				public const string VehiclesCount = "VehiclesCount";
				public const string WeaponsCount = "WeaponsCount";

				public new static IEnumerable<string> AsEnumerable()
				{
					return IStarWarsModel.ISortKeys.Keys
						.AsEnumerable()
						.Append(Name)
						.Append(StarshipsCount)
						.Append(VehiclesCount)
						.Append(WeaponsCount);
				}
				public static IOrderedEnumerable<IManufacturer> Sort(IEnumerable<IManufacturer> manufacturers, params Sorter[] sorters)
				{
					IOrderedEnumerable<IManufacturer>? ordered = null;

					foreach (Sorter sorter in sorters)
						ordered = (sorter.SortKey, sorter.Descending) switch
						{
							(Name, false) => 
								ordered?.ThenBy(manufacturer => manufacturer.Name) ??
								manufacturers.OrderBy(manufacturer => manufacturer.Name),
							(Name, true) => 
								ordered?.ThenByDescending(manufacturer => manufacturer.Name) ??
								manufacturers.OrderByDescending(manufacturer => manufacturer.Name),

							(StarshipsCount, false) => 
								ordered?.ThenBy(manufacturer => manufacturer.StarshipIds?.Count()) ??
								manufacturers.OrderBy(manufacturer => manufacturer.StarshipIds?.Count()),
							(StarshipsCount, true) => 
								ordered?.ThenByDescending(manufacturer => manufacturer.StarshipIds?.Count()) ??
								manufacturers.OrderByDescending(manufacturer => manufacturer.StarshipIds?.Count()),

							(VehiclesCount, false) => 
								ordered?.ThenBy(manufacturer => manufacturer.VehicleIds?.Count()) ??
								manufacturers.OrderBy(manufacturer => manufacturer.VehicleIds?.Count()),
							(VehiclesCount, true) => 
								ordered?.ThenByDescending(manufacturer => manufacturer.VehicleIds?.Count()) ??
								manufacturers.OrderByDescending(manufacturer => manufacturer.VehicleIds?.Count()),

							(WeaponsCount, false) => 
								ordered?.ThenBy(manufacturer => manufacturer.WeaponIds?.Count()) ??
								manufacturers.OrderBy(manufacturer => manufacturer.WeaponIds?.Count()),
							(WeaponsCount, true) => 
								ordered?.ThenByDescending(manufacturer => manufacturer.WeaponIds?.Count()) ??
								manufacturers.OrderByDescending(manufacturer => manufacturer.WeaponIds?.Count()),

							(_, _) => IStarWarsModel.ISortKeys.Keys.Sort(ordered ?? manufacturers, sorters),
						};

					return ordered ?? manufacturers.OrderBy(manufacturer => manufacturer);
				}
				public static IOrderedQueryable<IManufacturer> Sort(IQueryable<IManufacturer> manufacturers, params Sorter[] sorters)
				{
					IOrderedQueryable<IManufacturer>? ordered = null;

					foreach (Sorter sorter in sorters)
						ordered = (sorter.SortKey, sorter.Descending) switch
						{
							(Name, false) => 
								ordered?.ThenBy(manufacturer => manufacturer.Name) ??
								manufacturers.OrderBy(manufacturer => manufacturer.Name),
							(Name, true) => 
								ordered?.ThenByDescending(manufacturer => manufacturer.Name) ??
								manufacturers.OrderByDescending(manufacturer => manufacturer.Name),

							(StarshipsCount, false) => 
								ordered?.ThenBy(manufacturer => manufacturer.StarshipIds != null ? manufacturer.StarshipIds.Count() : 0) ??
								manufacturers.OrderBy(manufacturer => manufacturer.StarshipIds != null ? manufacturer.StarshipIds.Count() : 0),
							(StarshipsCount, true) => 
								ordered?.ThenByDescending(manufacturer => manufacturer.StarshipIds != null ? manufacturer.StarshipIds.Count() : 0) ??
								manufacturers.OrderByDescending(manufacturer => manufacturer.StarshipIds != null ? manufacturer.StarshipIds.Count() : 0),

							(VehiclesCount, false) => 
								ordered?.ThenBy(manufacturer => manufacturer.VehicleIds != null ? manufacturer.VehicleIds.Count() : 0) ??
								manufacturers.OrderBy(manufacturer => manufacturer.VehicleIds != null ? manufacturer.VehicleIds.Count() : 0),
							(VehiclesCount, true) => 
								ordered?.ThenByDescending(manufacturer => manufacturer.VehicleIds != null ? manufacturer.VehicleIds.Count() : 0) ??
								manufacturers.OrderByDescending(manufacturer => manufacturer.VehicleIds != null ? manufacturer.VehicleIds.Count() : 0),

							(WeaponsCount, false) => 
								ordered?.ThenBy(manufacturer => manufacturer.WeaponIds != null ? manufacturer.WeaponIds.Count() : 0) ??
								manufacturers.OrderBy(manufacturer => manufacturer.WeaponIds != null ? manufacturer.WeaponIds.Count() : 0),
							(WeaponsCount, true) => 
								ordered?.ThenByDescending(manufacturer => manufacturer.WeaponIds != null ? manufacturer.WeaponIds.Count() : 0) ??
								manufacturers.OrderByDescending(manufacturer => manufacturer.WeaponIds != null ? manufacturer.WeaponIds.Count() : 0),

							(_, _) => IStarWarsModel.ISortKeys.Keys.Sort(ordered ?? manufacturers, sorters),
						};

					return ordered ?? manufacturers.OrderBy(manufacturer => manufacturer);
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
					Name = defaultvalue;
					StarshipsCount = defaultvalue;
					VehiclesCount = defaultvalue;
					WeaponsCount = defaultvalue;
				}

				public T Name { get; set; }
				public T StarshipsCount { get; set; }
				public T VehiclesCount { get; set; }
				public T WeaponsCount { get; set; }
			}
		}
	}
}
