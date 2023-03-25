using Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Queries.Search
{
	public interface ITransportersSearchQuery<T> : IStarWarsModelSearchQuery<T>
	{
		T CargoCapacities { get; set; }
		T CargoCapacityRangeLower { get; set; }
		T CargoCapacityRangeUpper { get; set; }
		T Consumables { get; set; }
		T ConsumableRangeLower { get; set; }
		T ConsumableRangeUpper { get; set; }	 
		T CostInCredits { get; set; }
		T CostInCreditRangeLower { get; set; }
		T CostInCreditRangeUpper { get; set; }
		T Description { get; set; }
		T Lengths { get; set; }
		T LengthRangeLower { get; set; }
		T LengthRangeUpper { get; set; }
		T ManufacturersDescription { get; set; }
		T ManufacturersName { get; set; }
		T MaxAtmospheringSpeeds { get; set; }
		T MaxAtmospheringSpeedRangeLower { get; set; }
		T MaxAtmospheringSpeedRangeUpper { get; set; }
		T MaxCrews { get; set; }
		T MaxCrewRangeLower { get; set; }
		T MaxCrewRangeUpper { get; set; }
		T MinCrews { get; set; }
		T MinCrewRangeLower { get; set; }
		T MinCrewRangeUpper { get; set; }
		T Model { get; set; }
		T Name { get; set; }
		T Passengers { get; set; }
		T PassengerRangeLower { get; set; }
		T PassengerRangeUpper { get; set; }
		T PilotsDescription { get; set; }
		T PilotsName { get; set; }

		public new IEnumerable<T> AsEnumerable()
		{
			return (this as IStarWarsModelSearchQuery<T>).AsEnumerable()
				.Append(CargoCapacities)
				.Append(CargoCapacityRangeLower)
				.Append(CargoCapacityRangeUpper)
				.Append(Consumables)
				.Append(ConsumableRangeLower)
				.Append(ConsumableRangeUpper)		  
				.Append(CostInCredits)
				.Append(CostInCreditRangeLower)
				.Append(CostInCreditRangeUpper)
				.Append(Description)
				.Append(Lengths)
				.Append(LengthRangeLower)
				.Append(LengthRangeUpper)
				.Append(ManufacturersDescription)
				.Append(ManufacturersName)
				.Append(MaxAtmospheringSpeeds)
				.Append(MaxAtmospheringSpeedRangeLower)
				.Append(MaxAtmospheringSpeedRangeUpper)
				.Append(MaxCrews)
				.Append(MaxCrewRangeLower)
				.Append(MaxCrewRangeUpper)
				.Append(MinCrews)
				.Append(MinCrewRangeLower)
				.Append(MinCrewRangeUpper)
				.Append(Model)
				.Append(Name)
				.Append(Passengers)
				.Append(PassengerRangeLower)
				.Append(PassengerRangeUpper)
				.Append(PilotsDescription)
				.Append(PilotsName);
		}
	}
	public interface ITransportersSearchQuery : IStarWarsModelSearchQuery
	{
		public static string? ConsumableToString(ITransporter.IConsumable? consumable = null)
		{
			if (consumable is null)
				return null;

			return string.Format("{0}{1}", consumable.TimeUnit, consumable.Value);
		}
		public static ITransporter.IConsumable? StringToConsumable(string? consumable = null)
		{
			if (string.IsNullOrWhiteSpace(consumable))
				return null;

			string? timeunit = ITransporter.IConsumable.TimeUnits.AsEnumerable()
				.FirstOrDefault(timeunit => consumable.Contains(timeunit, StringComparison.OrdinalIgnoreCase));

			int? value = int.TryParse(consumable.Replace(timeunit, string.Empty, StringComparison.OrdinalIgnoreCase), out int outvalue)
				? outvalue
				: new int?();

			return new ITransporter.IConsumable.Default
			{
				TimeUnit = timeunit,
				Value = value,
			};
		}

		long?[]? CargoCapacities { get; set; }
		long? CargoCapacityRangeLower { get; set; }
		long? CargoCapacityRangeUpper { get; set; }
		string?[]? Consumables { get; set; }
		string? ConsumableRangeLower { get; set; }
		string? ConsumableRangeUpper { get; set; }		  
		long?[]? CostInCredits { get; set; }
		long? CostInCreditRangeLower { get; set; }
		long? CostInCreditRangeUpper { get; set; }
		bool? Description { get; set; }
		double?[]? Lengths { get; set; }
		double? LengthRangeLower { get; set; }
		double? LengthRangeUpper { get; set; }
		bool? ManufacturersDescription { get; set; }
		bool? ManufacturersName { get; set; }
		int?[]? MaxAtmospheringSpeeds { get; set; }
		int? MaxAtmospheringSpeedRangeLower { get; set; }
		int? MaxAtmospheringSpeedRangeUpper { get; set; }
		int?[]? MaxCrews { get; set; }
		int? MaxCrewRangeLower { get; set; }
		int? MaxCrewRangeUpper { get; set; }
		int?[]? MinCrews { get; set; }
		int? MinCrewRangeLower { get; set; }
		int? MinCrewRangeUpper { get; set; }
		bool? Model { get; set; }
		bool? Name { get; set; }
		int?[]? Passengers { get; set; }
		int? PassengerRangeLower { get; set; }
		int? PassengerRangeUpper { get; set; }
		bool? PilotsDescription { get; set; }
		bool? PilotsName { get; set; }

		public bool ShouldSearchManufacturers()
		{
			return
				(ManufacturersDescription ?? false) ||
				(ManufacturersName ?? false);
		}
		public bool ShouldSearchPilots()
		{
			return
				(PilotsDescription ?? false) ||
				(PilotsName ?? false);
		}

		public IEnumerable<string> AsQueryData(ITransportersSearchQuery<string>? keys = null)
		{
			IEnumerable<string> querydata = AsQueryData(keys as IStarWarsModelSearchQuery<string>);

			if (CargoCapacities != null)
				querydata = querydata.Concat(CargoCapacities.Select(cargocapacity => string.Format("{0}={1}", keys?.CargoCapacities ?? nameof(CargoCapacities).ToLower(), cargocapacity)));

			if (CargoCapacityRangeLower.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.CargoCapacityRangeLower ?? nameof(CargoCapacityRangeLower).ToLower(), CargoCapacityRangeLower.Value));

			if (CargoCapacityRangeUpper.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.CargoCapacityRangeUpper ?? nameof(CargoCapacityRangeUpper).ToLower(), CargoCapacityRangeUpper.Value));

			if (Consumables != null)
				querydata = querydata.Concat(Consumables.Select(consumable => string.Format("{0}={1}", keys?.Consumables ?? nameof(Consumables).ToLower(), consumable)));

			if (ConsumableRangeLower is string)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.ConsumableRangeLower ?? nameof(ConsumableRangeLower).ToLower(), ConsumableRangeLower));

			if (ConsumableRangeUpper is string)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.ConsumableRangeUpper ?? nameof(ConsumableRangeUpper).ToLower(), ConsumableRangeUpper));			

			if (CostInCredits != null)
				querydata = querydata.Concat(CostInCredits.Select(costincredit => string.Format("{0}={1}", keys?.CostInCredits ?? nameof(CostInCredits).ToLower(), costincredit)));

			if (CostInCreditRangeLower.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.CostInCreditRangeLower ?? nameof(CostInCreditRangeLower).ToLower(), CostInCreditRangeLower.Value));

			if (CostInCreditRangeUpper.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.CostInCreditRangeUpper ?? nameof(CostInCreditRangeUpper).ToLower(), CostInCreditRangeUpper.Value));

			if (Description.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.Description ?? nameof(Description).ToLower(), Description.Value));

			if (Lengths != null)
				querydata = querydata.Concat(Lengths.Select(length => string.Format("{0}={1}", keys?.Lengths ?? nameof(Lengths).ToLower(), length)));

			if (LengthRangeLower.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.LengthRangeLower ?? nameof(LengthRangeLower).ToLower(), LengthRangeLower.Value));

			if (LengthRangeUpper.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.LengthRangeUpper ?? nameof(LengthRangeUpper).ToLower(), LengthRangeUpper.Value));

			if (ManufacturersDescription.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.ManufacturersDescription ?? nameof(ManufacturersDescription).ToLower(), ManufacturersDescription.Value));

			if (ManufacturersName.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.ManufacturersName ?? nameof(ManufacturersName).ToLower(), ManufacturersName.Value));

			if (MaxAtmospheringSpeeds != null)
				querydata = querydata.Concat(MaxAtmospheringSpeeds.Select(maxatmospheringspeed => string.Format("{0}={1}", keys?.MaxAtmospheringSpeeds ?? nameof(MaxAtmospheringSpeeds).ToLower(), maxatmospheringspeed)));

			if (MaxAtmospheringSpeedRangeLower.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.MaxAtmospheringSpeedRangeLower ?? nameof(MaxAtmospheringSpeedRangeLower).ToLower(), MaxAtmospheringSpeedRangeLower.Value));

			if (MaxAtmospheringSpeedRangeUpper.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.MaxAtmospheringSpeedRangeUpper ?? nameof(MaxAtmospheringSpeedRangeUpper).ToLower(), MaxAtmospheringSpeedRangeUpper.Value));

			if (MaxCrews != null)
				querydata = querydata.Concat(MaxCrews.Select(maxcrew => string.Format("{0}={1}", keys?.MaxCrews ?? nameof(MaxCrews).ToLower(), maxcrew)));

			if (MaxCrewRangeLower.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.MaxCrewRangeLower ?? nameof(MaxCrewRangeLower).ToLower(), MaxCrewRangeLower.Value));

			if (MaxCrewRangeUpper.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.MaxCrewRangeUpper ?? nameof(MaxCrewRangeUpper).ToLower(), MaxCrewRangeUpper.Value));

			if (MinCrews != null)
				querydata = querydata.Concat(MinCrews.Select(mincrew => string.Format("{0}={1}", keys?.MinCrews ?? nameof(MinCrews).ToLower(), mincrew)));

			if (MinCrewRangeLower.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.MinCrewRangeLower ?? nameof(MinCrewRangeLower).ToLower(), MinCrewRangeLower.Value));

			if (MinCrewRangeUpper.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.MinCrewRangeUpper ?? nameof(MinCrewRangeUpper).ToLower(), MinCrewRangeUpper.Value));

			if (Model.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.Model ?? nameof(Model).ToLower(), Model.Value));

			if (Name.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.Name ?? nameof(Name).ToLower(), Name.Value));

			if (Passengers != null)
				querydata = querydata.Concat(Passengers.Select(passenger => string.Format("{0}={1}", keys?.Passengers ?? nameof(Passengers).ToLower(), passenger)));

			if (PassengerRangeLower.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.PassengerRangeLower ?? nameof(PassengerRangeLower).ToLower(), PassengerRangeLower.Value));

			if (PassengerRangeUpper.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.PassengerRangeUpper ?? nameof(PassengerRangeUpper).ToLower(), PassengerRangeUpper.Value));

			if (PilotsDescription.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.PilotsDescription ?? nameof(PilotsDescription).ToLower(), PilotsDescription.Value));

			if (PilotsName.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.PilotsName ?? nameof(PilotsName).ToLower(), PilotsName.Value));

			return querydata;
		}

		public new class Default : IStarWarsModelSearchQuery.Default, ITransportersSearchQuery
		{
			public Default() : base() { }
			public Default(ITransporter.ISearch transportersearch) : base(transportersearch)
			{
				Description = transportersearch.SearchContainables?.Description;
				Model = transportersearch.SearchContainables?.Model;
				Name = transportersearch.SearchContainables?.Name;

				CargoCapacities = transportersearch.CargoCapacities?.Values?.ToArray();
				CargoCapacityRangeLower = transportersearch.CargoCapacities?.Lower;
				CargoCapacityRangeUpper = transportersearch.CargoCapacities?.Upper;

				Consumables = transportersearch.Consumables?.Values?.Select(consumable => ConsumableToString(consumable)).ToArray();
				ConsumableRangeLower = ConsumableToString(transportersearch.Consumables?.Lower);
				ConsumableRangeUpper = ConsumableToString(transportersearch.Consumables?.Upper);		  

				CostInCredits = transportersearch.CostInCredits?.Values?.ToArray();
				CostInCreditRangeLower = transportersearch.CostInCredits?.Lower;
				CostInCreditRangeUpper = transportersearch.CostInCredits?.Upper;

				Lengths = transportersearch.Lengths?.Values?.ToArray();
				LengthRangeLower = transportersearch.Lengths?.Lower;
				LengthRangeUpper = transportersearch.Lengths?.Upper;

				Passengers = transportersearch.Passengers?.Values?.ToArray();
				PassengerRangeLower = transportersearch.Passengers?.Lower;
				PassengerRangeUpper = transportersearch.Passengers?.Upper;

				ManufacturersDescription = transportersearch.Manufacturers?.Description;
				ManufacturersName = transportersearch.Manufacturers?.Name;

				MaxAtmospheringSpeeds = transportersearch.MaxAtmospheringSpeeds?.Values?.ToArray();
				MaxAtmospheringSpeedRangeLower = transportersearch.MaxAtmospheringSpeeds?.Lower;
				MaxAtmospheringSpeedRangeUpper = transportersearch.MaxAtmospheringSpeeds?.Upper;

				MaxCrews = transportersearch.MaxCrews?.Values?.ToArray();
				MaxCrewRangeLower = transportersearch.MaxCrews?.Lower;
				MaxCrewRangeUpper = transportersearch.MaxCrews?.Upper;

				MinCrews = transportersearch.MinCrews?.Values?.ToArray();
				MinCrewRangeLower = transportersearch.MinCrews?.Lower;
				MinCrewRangeUpper = transportersearch.MinCrews?.Upper;

				PilotsDescription = transportersearch.Pilots?.Description;
				PilotsName = transportersearch.Pilots?.Name;
			}

			public long?[]? CargoCapacities { get; set; }
			public long? CargoCapacityRangeLower { get; set; }
			public long? CargoCapacityRangeUpper { get; set; }
			public string?[]? Consumables { get; set; }
			public string? ConsumableRangeLower { get; set; }
			public string? ConsumableRangeUpper { get; set; }
			public long?[]? CostInCredits { get; set; }
			public long? CostInCreditRangeLower { get; set; }
			public long? CostInCreditRangeUpper { get; set; }
			public bool? Description { get; set; }
			public double?[]? Lengths { get; set; }
			public double? LengthRangeLower { get; set; }
			public double? LengthRangeUpper { get; set; }
			public bool? ManufacturersDescription { get; set; }
			public bool? ManufacturersName { get; set; }
			public int?[]? MaxAtmospheringSpeeds { get; set; }
			public int? MaxAtmospheringSpeedRangeLower { get; set; }
			public int? MaxAtmospheringSpeedRangeUpper { get; set; }
			public int?[]? MaxCrews { get; set; }
			public int? MaxCrewRangeLower { get; set; }
			public int? MaxCrewRangeUpper { get; set; }
			public int?[]? MinCrews { get; set; }
			public int? MinCrewRangeLower { get; set; }
			public int? MinCrewRangeUpper { get; set; }
			public bool? Model { get; set; }
			public bool? Name { get; set; }
			public int?[]? Passengers { get; set; }
			public int? PassengerRangeLower { get; set; }
			public int? PassengerRangeUpper { get; set; }
			public bool? PilotsDescription { get; set; }
			public bool? PilotsName { get; set; }
		}
		public new class Default<T> : IStarWarsModelSearchQuery.Default<T>, ITransportersSearchQuery<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				CargoCapacities = defaultvalue;
				CargoCapacityRangeLower = defaultvalue;
				CargoCapacityRangeUpper = defaultvalue;
				Consumables = defaultvalue;
				ConsumableRangeLower = defaultvalue;
				ConsumableRangeUpper = defaultvalue;
				CostInCredits = defaultvalue;
				CostInCreditRangeLower = defaultvalue;
				CostInCreditRangeUpper = defaultvalue;
				Description = defaultvalue;
				Lengths = defaultvalue;
				LengthRangeLower = defaultvalue;
				LengthRangeUpper = defaultvalue;
				ManufacturersDescription = defaultvalue;
				ManufacturersName = defaultvalue;
				MaxAtmospheringSpeeds = defaultvalue;
				MaxAtmospheringSpeedRangeLower = defaultvalue;
				MaxAtmospheringSpeedRangeUpper = defaultvalue;
				MaxCrews = defaultvalue;
				MaxCrewRangeLower = defaultvalue;
				MaxCrewRangeUpper = defaultvalue;
				MinCrews = defaultvalue;
				MinCrewRangeLower = defaultvalue;
				MinCrewRangeUpper = defaultvalue;
				Model = defaultvalue;
				Name = defaultvalue;
				Passengers = defaultvalue;
				PassengerRangeLower = defaultvalue;
				PassengerRangeUpper = defaultvalue;
				PilotsDescription = defaultvalue;
				PilotsName = defaultvalue;
			}

			public T CargoCapacities { get; set; }
			public T CargoCapacityRangeLower { get; set; }
			public T CargoCapacityRangeUpper { get; set; }
			public T Consumables { get; set; }
			public T ConsumableRangeLower { get; set; }
			public T ConsumableRangeUpper { get; set; }
			public T CostInCredits { get; set; }
			public T CostInCreditRangeLower { get; set; }
			public T CostInCreditRangeUpper { get; set; }
			public T Description { get; set; }
			public T Lengths { get; set; }
			public T LengthRangeLower { get; set; }
			public T LengthRangeUpper { get; set; }
			public T ManufacturersDescription { get; set; }
			public T ManufacturersName { get; set; }
			public T MaxAtmospheringSpeeds { get; set; }
			public T MaxAtmospheringSpeedRangeLower { get; set; }
			public T MaxAtmospheringSpeedRangeUpper { get; set; }
			public T MaxCrews { get; set; }
			public T MaxCrewRangeLower { get; set; }
			public T MaxCrewRangeUpper { get; set; }
			public T MinCrews { get; set; }
			public T MinCrewRangeLower { get; set; }
			public T MinCrewRangeUpper { get; set; }
			public T Model { get; set; }
			public T Name { get; set; }
			public T Passengers { get; set; }
			public T PassengerRangeLower { get; set; }
			public T PassengerRangeUpper { get; set; }
			public T PilotsDescription { get; set; }
			public T PilotsName { get; set; }
		}
	}
}