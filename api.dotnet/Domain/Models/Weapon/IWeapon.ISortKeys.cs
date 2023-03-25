using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Models
{
	public partial interface IWeapon 
	{
		public new interface ISortKeys<T> : IStarWarsModel.ISortKeys<T> 
		{
			T ManufacturerCount { get; set; }
			T Model { get; set; }
			T Name { get; set; }
			T WeaponClass { get; set; }
			T WeaponClassFlagsCount { get; set; }

			public new T GetValue(string sortkey)
			{
				return sortkey switch
				{
					ISortKeys.Keys.ManufacturerCount => ManufacturerCount,
					ISortKeys.Keys.Model => Model,
					ISortKeys.Keys.Name => Name,
					ISortKeys.Keys.WeaponClass => WeaponClass,
					ISortKeys.Keys.WeaponClassFlagsCount => WeaponClassFlagsCount,

					_ => (this as IStarWarsModel.ISortKeys<T>).GetValue(sortkey),
				};
			}
			public new string ToString(StringBuilder? stringBuilder = null)
			{
				return (this as IStarWarsModel.ISortKeys<T>).ToString(
					(stringBuilder ?? new StringBuilder())
						.AppendFormat("{0}: {1}", nameof(ManufacturerCount), ManufacturerCount).AppendLine()
						.AppendFormat("{0}: {1}", nameof(Model), Model).AppendLine()
						.AppendFormat("{0}: {1}", nameof(Name), Name).AppendLine()
						.AppendFormat("{0}: {1}", nameof(WeaponClass), WeaponClass).AppendLine()
						.AppendFormat("{0}: {1}", nameof(WeaponClassFlagsCount), WeaponClassFlagsCount).AppendLine());
			}
		}
		public new interface ISortKeys : ISortKeys<string?>, IStarWarsModel.ISortKeys
		{
			public new class Keys : IStarWarsModel.ISortKeys.Keys
			{
				public const string ManufacturerCount = "ManufacturerCount";
				public const string Model = "Model";
				public const string Name = "Name";
				public const string WeaponClass = "WeaponClass";
				public const string WeaponClassFlagsCount = "WeaponClassFlagsCount";

				public new static IEnumerable<string> AsEnumerable()
				{
					return IStarWarsModel.ISortKeys.Keys
						.AsEnumerable()
						.Append(ManufacturerCount)
						.Append(Model)
						.Append(Name)
						.Append(WeaponClass)
						.Append(WeaponClassFlagsCount);
				}
				public static IOrderedEnumerable<IWeapon> Sort(IEnumerable<IWeapon> weapons, params Sorter[] sorters)
				{
					IOrderedEnumerable<IWeapon>? ordered = null;

					foreach (Sorter sorter in sorters)
						ordered = (sorter.SortKey, sorter.Descending) switch
						{
							(ManufacturerCount, false) => 
								ordered?.ThenBy(weapon => weapon.ManufacturerIds?.Count()) ??
								weapons.OrderBy(weapon => weapon.ManufacturerIds?.Count()),
							(ManufacturerCount, true) => 
								ordered?.ThenByDescending(weapon => weapon.ManufacturerIds?.Count()) ??
								weapons.OrderByDescending(weapon => weapon.ManufacturerIds?.Count()),

							(Model, false) => 
								ordered?.ThenBy(weapon => weapon.Model) ??
								weapons.OrderBy(weapon => weapon.Model),
							(Model, true) => 
								ordered?.ThenByDescending(weapon => weapon.Model) ??
								weapons.OrderByDescending(weapon => weapon.Model),

							(Name, false) => 
								ordered?.ThenBy(weapon => weapon.Name) ??
								weapons.OrderBy(weapon => weapon.Name),
							(Name, true) => 
								ordered?.ThenByDescending(weapon => weapon.Name) ??
								weapons.OrderByDescending(weapon => weapon.Name),

							(WeaponClass, false) => 
								ordered?.ThenBy(weapon => weapon.WeaponClass?.Class) ??
								weapons.OrderBy(weapon => weapon.WeaponClass?.Class),
							(WeaponClass, true) => 
								ordered?.ThenByDescending(weapon => weapon.WeaponClass?.Class) ??
								weapons.OrderByDescending(weapon => weapon.WeaponClass?.Class),

							(WeaponClassFlagsCount, false) => 
								ordered?.ThenBy(weapon => weapon.WeaponClass?.Flags?.Count()) ??
								weapons.OrderBy(weapon => weapon.WeaponClass?.Flags?.Count()),
							(WeaponClassFlagsCount, true) => 
								ordered?.ThenByDescending(weapon => weapon.WeaponClass?.Flags?.Count()) ??
								weapons.OrderByDescending(weapon => weapon.WeaponClass?.Flags?.Count()),

							(_, _) => IStarWarsModel.ISortKeys.Keys.Sort(ordered ?? weapons, sorters),
						};

					return ordered ?? weapons.OrderBy(weapon => weapon);
				}
				public static IOrderedQueryable<IWeapon> Sort(IQueryable<IWeapon> weapons, params Sorter[] sorters)
				{
					IOrderedQueryable<IWeapon>? ordered = null;

					foreach (Sorter sorter in sorters)
						ordered = (sorter.SortKey, sorter.Descending) switch
						{
							(ManufacturerCount, false) => 
								ordered?.ThenBy(weapon => weapon.ManufacturerIds != null ? weapon.ManufacturerIds.Count() : 0) ??
								weapons.OrderBy(weapon => weapon.ManufacturerIds != null ? weapon.ManufacturerIds.Count() : 0),
							(ManufacturerCount, true) => 
								ordered?.ThenByDescending(weapon => weapon.ManufacturerIds != null ? weapon.ManufacturerIds.Count() : 0) ??
								weapons.OrderByDescending(weapon => weapon.ManufacturerIds != null ? weapon.ManufacturerIds.Count() : 0),

							(Model, false) => 
								ordered?.ThenBy(weapon => weapon.Model) ??
								weapons.OrderBy(weapon => weapon.Model),
							(Model, true) => 
								ordered?.ThenByDescending(weapon => weapon.Model) ??
								weapons.OrderByDescending(weapon => weapon.Model),

							(Name, false) => 
								ordered?.ThenBy(weapon => weapon.Name) ??
								weapons.OrderBy(weapon => weapon.Name),
							(Name, true) => 
								ordered?.ThenByDescending(weapon => weapon.Name) ??
								weapons.OrderByDescending(weapon => weapon.Name),

							(WeaponClass, false) => 
								ordered?.ThenBy(weapon => weapon.WeaponClass != null ? weapon.WeaponClass.Class : string.Empty) ??
								weapons.OrderBy(weapon => weapon.WeaponClass != null ? weapon.WeaponClass.Class : string.Empty),
							(WeaponClass, true) => 
								ordered?.ThenByDescending(weapon => weapon.WeaponClass != null ? weapon.WeaponClass.Class : string.Empty) ??
								weapons.OrderByDescending(weapon => weapon.WeaponClass != null ? weapon.WeaponClass.Class : string.Empty),

							(WeaponClassFlagsCount, false) => 
								ordered?.ThenBy(weapon => weapon.WeaponClass != null && weapon.WeaponClass.Flags != null ? weapon.WeaponClass.Flags.Count() : 0) ??
								weapons.OrderBy(weapon => weapon.WeaponClass != null && weapon.WeaponClass.Flags != null ? weapon.WeaponClass.Flags.Count() : 0),
							(WeaponClassFlagsCount, true) => 
								ordered?.ThenByDescending(weapon => weapon.WeaponClass != null && weapon.WeaponClass.Flags != null ? weapon.WeaponClass.Flags.Count() : 0) ??
								weapons.OrderByDescending(weapon => weapon.WeaponClass != null && weapon.WeaponClass.Flags != null ? weapon.WeaponClass.Flags.Count() : 0),

							(_, _) => IStarWarsModel.ISortKeys.Keys.Sort(ordered ?? weapons, sorters),
						};

					return ordered ?? weapons.OrderBy(weapon => weapon);
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
					ManufacturerCount = defaultvalue;
					Model = defaultvalue;
					Name = defaultvalue;
					WeaponClass = defaultvalue;
					WeaponClassFlagsCount = defaultvalue;
				}

				public T ManufacturerCount { get; set; }
				public T Model { get; set; }
				public T Name { get; set; }
				public T WeaponClass { get; set; }
				public T WeaponClassFlagsCount { get; set; }
			}
		}
	}
}
