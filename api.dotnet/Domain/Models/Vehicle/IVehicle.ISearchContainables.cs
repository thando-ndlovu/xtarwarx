using System;
using System.Text;

namespace Domain.Models
{
	public partial interface IVehicle
	{
		public new interface ISearchContainables<T> : ITransporter.ISearchContainables<T>
		{
			T VehicleClass { get; set; }
			T VehicleClassFlags { get; set; }

			public new string? ToString()
			{
				return new StringBuilder()
					.Append(this)
					.ToString();
			}
		}
		public new interface ISearchContainables : ISearchContainables<bool>, ITransporter.ISearchContainables
		{
			public new class Default : Default<bool>, ISearchContainables
			{
				public Default() : base(false) { }
			}
			public new class Default<T> : ITransporter.ISearchContainables.Default<T>, ISearchContainables<T>
			{
				public Default(T defaultvalue) : base(defaultvalue)
				{
					VehicleClass = defaultvalue;
					VehicleClassFlags = defaultvalue;
				}

				public T VehicleClass { get; set; }
				public T VehicleClassFlags { get; set; }
			}

			public bool ShouldReturnVehicle(IVehicle vehicle, string? searchString)
			{
				if (VehicleClass && VehicleClassContainsSearchString(vehicle, searchString, out int _)) return true;
				if (VehicleClassFlags && VehicleClassFlagsContainsSearchString(vehicle, searchString, out int _)) return true;

				return ShouldReturnTransporter(vehicle, searchString);
			}
			public bool ShouldReturnVehicle(IVehicle vehicle, string? searchString, out int matchCount)
			{
				matchCount = 0;

				bool shouldreturn = ShouldReturnTransporter(vehicle, searchString, out int transportermatchcount);

				if (shouldreturn)
					matchCount += transportermatchcount;

				if (VehicleClass && VehicleClassContainsSearchString(vehicle, searchString, out int vehicleClassMatchCount))
				{
					matchCount += vehicleClassMatchCount;

					shouldreturn = true;
				}
				if (VehicleClassFlags && VehicleClassFlagsContainsSearchString(vehicle, searchString, out int vehicleClassFlagsMatchCount))
				{
					matchCount += vehicleClassFlagsMatchCount;

					shouldreturn = true;
				}

				return shouldreturn;
			}

			private bool VehicleClassContainsSearchString(IVehicle vehicle, string? searchString, out int matchCount)
			{
				matchCount = 0;

				if (string.IsNullOrWhiteSpace(searchString))
					return true;

				if (string.IsNullOrWhiteSpace(vehicle.VehicleClass?.Class)) return false;

				if (vehicle.VehicleClass.Class.ToLower().Contains(searchString.ToLower(), StringComparison.OrdinalIgnoreCase))
					matchCount++;

				return matchCount > 0;
			}
			private bool VehicleClassFlagsContainsSearchString(IVehicle vehicle, string? searchString, out int matchCount)
			{
				matchCount = 0;

				if (string.IsNullOrWhiteSpace(searchString))
					return true;

				if (vehicle.VehicleClass?.Flags == null) return false;

				foreach (string vehicleclassflag in vehicle.VehicleClass.Flags)
					if (vehicleclassflag.ToLower().Contains(searchString.ToLower(), StringComparison.OrdinalIgnoreCase))
						matchCount++;

				return matchCount > 0;
			}
		}
	}

	public static class IVehicleExtensions
	{
		public static StringBuilder Append<T>(this StringBuilder stringbuilder, IVehicle.ISearchContainables<T>? searchcontainables)
		{
			if (searchcontainables is null)
				return stringbuilder;

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(IVehicle.ISearchContainables<T>.VehicleClass), searchcontainables.VehicleClass).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IVehicle.ISearchContainables<T>.VehicleClassFlags), searchcontainables.VehicleClassFlags).AppendLine();

			return stringbuilder.Append<T>(searchcontainables as ITransporter.ISearchContainables<T>);
		}
	}
}
