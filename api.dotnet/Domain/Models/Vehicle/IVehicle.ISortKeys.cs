using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Models
{
	public partial interface IVehicle : ITransporter
	{
		public new interface ISortKeys<T> : ITransporter.ISortKeys<T> 
		{
			T VehicleClass { get; set; }
			T VehicleClassFlagsCount { get; set; }

			public new T GetValue(string sortkey)
			{
				return sortkey switch
				{
					ISortKeys.Keys.VehicleClass => VehicleClass,
					ISortKeys.Keys.VehicleClassFlagsCount => VehicleClassFlagsCount,

					_ => (this as ITransporter.ISortKeys<T>).GetValue(sortkey),
				};
			}
			public new string ToString(StringBuilder? stringBuilder = null)
			{
				return (this as ITransporter.ISortKeys<T>).ToString(
					(stringBuilder ?? new StringBuilder())
						.AppendFormat("{0}: {1}", nameof(VehicleClass), VehicleClass).AppendLine()
						.AppendFormat("{0}: {1}", nameof(VehicleClassFlagsCount), VehicleClassFlagsCount).AppendLine());
			}
		}
		public new interface ISortKeys : ISortKeys<string?>, ITransporter.ISortKeys
		{
			public new class Keys : ITransporter.ISortKeys.Keys
			{
				public const string VehicleClass = "VehicleClass";
				public const string VehicleClassFlagsCount = "VehicleClassFlagsCount";

				public new static IEnumerable<string> AsEnumerable()
				{
					return ITransporter.ISortKeys.Keys
						.AsEnumerable()
						.Append(VehicleClass)
						.Append(VehicleClassFlagsCount);
				}
				public static IOrderedEnumerable<IVehicle> Sort(IEnumerable<IVehicle> vehicles, params Sorter[] sorters)
				{
					IOrderedEnumerable<IVehicle>? ordered = null;

					foreach (Sorter sorter in sorters)
						ordered = (sorter.SortKey, sorter.Descending) switch
						{
							(VehicleClass, false) => 
								ordered?.ThenBy(vehicle => vehicle.VehicleClass?.Class) ??
								vehicles.OrderBy(vehicle => vehicle.VehicleClass?.Class),
							(VehicleClass, true) => 
								ordered?.ThenByDescending(vehicle => vehicle.VehicleClass?.Class) ??
								vehicles.OrderByDescending(vehicle => vehicle.VehicleClass?.Class),

							(VehicleClassFlagsCount, false) => 
								ordered?.ThenBy(vehicle => vehicle.VehicleClass?.Flags?.Count()) ??
								vehicles.OrderBy(vehicle => vehicle.VehicleClass?.Flags?.Count()),
							(VehicleClassFlagsCount, true) => 
								ordered?.ThenByDescending(vehicle => vehicle.VehicleClass?.Flags?.Count()) ??
								vehicles.OrderByDescending(vehicle => vehicle.VehicleClass?.Flags?.Count()),

							(_, _) => ITransporter.ISortKeys.Keys.Sort(ordered ?? vehicles, sorters),
						};

					return ordered ?? vehicles.OrderBy(vehicle => vehicle);
				}
				public static IOrderedQueryable<IVehicle> Sort(IQueryable<IVehicle> vehicles, params Sorter[] sorters)
				{
					IOrderedQueryable<IVehicle>? ordered = null;

					foreach (Sorter sorter in sorters)
						ordered = (sorter.SortKey, sorter.Descending) switch
						{
							(VehicleClass, false) => 
								ordered?.ThenBy(vehicle => vehicle.VehicleClass != null ? vehicle.VehicleClass.Class : string.Empty) ??
								vehicles.OrderBy(vehicle => vehicle.VehicleClass != null ? vehicle.VehicleClass.Class : string.Empty),
							(VehicleClass, true) => 
								ordered?.ThenByDescending(vehicle => vehicle.VehicleClass != null ? vehicle.VehicleClass.Class : string.Empty) ??
								vehicles.OrderByDescending(vehicle => vehicle.VehicleClass != null ? vehicle.VehicleClass.Class : string.Empty),

							(VehicleClassFlagsCount, false) => 
								ordered?.ThenBy(vehicle => vehicle.VehicleClass != null && vehicle.VehicleClass.Flags != null ? vehicle.VehicleClass.Flags.Count() : 0) ??
								vehicles.OrderBy(vehicle => vehicle.VehicleClass != null && vehicle.VehicleClass.Flags != null ? vehicle.VehicleClass.Flags.Count() : 0),
							(VehicleClassFlagsCount, true) => 
								ordered?.ThenByDescending(vehicle => vehicle.VehicleClass != null && vehicle.VehicleClass.Flags != null ? vehicle.VehicleClass.Flags.Count() : 0) ??
								vehicles.OrderByDescending(vehicle => vehicle.VehicleClass != null && vehicle.VehicleClass.Flags != null ? vehicle.VehicleClass.Flags.Count() : 0),

							(_, _) => ITransporter.ISortKeys.Keys.Sort(ordered ?? vehicles, sorter),
						};

					return ordered ?? vehicles.OrderBy(vehicle => vehicle);
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
					VehicleClass = defaultvalue;
					VehicleClassFlagsCount = defaultvalue;
				}

				public T VehicleClass { get; set; }
				public T VehicleClassFlagsCount { get; set; }
			}
		}
	}
}
