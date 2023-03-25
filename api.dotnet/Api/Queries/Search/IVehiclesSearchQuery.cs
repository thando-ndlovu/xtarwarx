using Domain.Models;

using System.Collections.Generic;
using System.Linq;

namespace Api.Queries.Search
{
	public interface IVehiclesSearchQuery<T> : ITransportersSearchQuery<T>
	{
		T VehicleClass { get; set; }
		T VehicleClassFlags { get; set; }

		public new IEnumerable<T> AsEnumerable()
		{
			return (this as ITransportersSearchQuery<T>).AsEnumerable()
				.Append(VehicleClass)
				.Append(VehicleClassFlags);
		}
	}
	public interface IVehiclesSearchQuery : ITransportersSearchQuery
	{
		bool? VehicleClass { get; set; }
		bool? VehicleClassFlags { get; set; }

		public IVehicle.ISearch AsVehicleSearch(string? searchstring = null)
				=> new IVehicle.ISearch.Default
				{
					SearchString = searchstring,

					SearchContainables = new IVehicle.ISearchContainables.Default
					{
						Description = Description ?? false,
						Model = Model ?? false,
						Name = Name ?? false,
						VehicleClass = VehicleClass ?? false,
						VehicleClassFlags = VehicleClassFlags ?? false,
					},

					CargoCapacities = new IStarWarsModel.ISearchValues.Default<long?>(default)
					{
						Lower = CargoCapacityRangeLower,
						Upper = CargoCapacityRangeUpper,
						Values = CargoCapacities,
					},

					CostInCredits = new IStarWarsModel.ISearchValues.Default<long?>(default)
					{
						Lower = CostInCreditRangeLower,
						Upper = CostInCreditRangeUpper,
						Values = CostInCredits,
					},

					Lengths = new IStarWarsModel.ISearchValues.Default<double?>(default)
					{
						Lower = LengthRangeLower,
						Upper = LengthRangeUpper,
						Values = Lengths,
					},

					Manufacturers = new IManufacturer.ISearchContainables.Default
					{
						Description = ManufacturersDescription ?? false,
						Name = ManufacturersName ?? false,
					},

					MaxAtmospheringSpeeds = new IStarWarsModel.ISearchValues.Default<int?>(default)
					{
						Lower = MaxAtmospheringSpeedRangeLower,
						Upper = MaxAtmospheringSpeedRangeUpper,
						Values = MaxAtmospheringSpeeds,
					},

					MaxCrews = new IStarWarsModel.ISearchValues.Default<int?>(default)
					{
						Lower = MaxCrewRangeLower,
						Upper = MaxCrewRangeUpper,
						Values = MaxCrews,
					},

					MinCrews = new IStarWarsModel.ISearchValues.Default<int?>(default)
					{
						Lower = MinCrewRangeLower,
						Upper = MinCrewRangeUpper,
						Values = MinCrews,
					},

					Passengers = new IStarWarsModel.ISearchValues.Default<int?>(default)
					{
						Lower = PassengerRangeLower,
						Upper = PassengerRangeUpper,
						Values = Passengers,
					},

					Pilots = new ICharacter.ISearchContainables.Default
					{
						Description = PilotsDescription ?? false,
						Name = PilotsName ?? false,
					},
				};
		public IEnumerable<string> AsQueryData(IVehiclesSearchQuery<string>? keys = null)
		{
			IEnumerable<string> querydata = AsQueryData(keys as ITransportersSearchQuery<string>);

			if (VehicleClass.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.VehicleClass ?? nameof(VehicleClass).ToLower(), VehicleClass.Value));

			if (VehicleClassFlags.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.VehicleClassFlags ?? nameof(VehicleClassFlags).ToLower(), VehicleClassFlags.Value));

			return querydata;
		}

		public new class Default : ITransportersSearchQuery.Default, IVehiclesSearchQuery
		{
			public Default() : base() { }
			public Default(IVehicle.ISearch vehiclesearch) : base(vehiclesearch)
			{
				VehicleClass = vehiclesearch.SearchContainables?.VehicleClass;
				VehicleClassFlags = vehiclesearch.SearchContainables?.VehicleClassFlags;
			}

			public bool? VehicleClass { get; set; }
			public bool? VehicleClassFlags { get; set; }
		}
		public new class Default<T> : ITransportersSearchQuery.Default<T>, IVehiclesSearchQuery<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				VehicleClass = defaultvalue;
				VehicleClassFlags = defaultvalue;
			}

			public T VehicleClass { get; set; }
			public T VehicleClassFlags { get; set; }
		}
	}
}
