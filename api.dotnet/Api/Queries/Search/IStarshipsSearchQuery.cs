using Domain.Models;

using System.Collections.Generic;
using System.Linq;

namespace Api.Queries.Search
{
	public interface IStarshipsSearchQuery<T> : ITransportersSearchQuery<T>
	{
		T HyperdriveRatings { get; set; }
		T HyperdriveRatingRangeLower { get; set; }
		T HyperdriveRatingRangeUpper { get; set; }
		T MGLTs { get; set; }
		T MGLTRangeLower { get; set; }
		T MGLTRangeUpper { get; set; }
		T StarshipClass { get; set; }
		T StarshipClassFlags { get; set; }

		public new IEnumerable<T> AsEnumerable()
		{
			return (this as ITransportersSearchQuery<T>).AsEnumerable()
				.Append(HyperdriveRatings)
				.Append(HyperdriveRatingRangeLower)
				.Append(HyperdriveRatingRangeUpper)
				.Append(MGLTs)
				.Append(MGLTRangeLower)
				.Append(MGLTRangeUpper)
				.Append(StarshipClass)
				.Append(StarshipClassFlags);
		}
	}
	public interface IStarshipsSearchQuery : ITransportersSearchQuery
	{
		double?[]? HyperdriveRatings { get; set; }
		double? HyperdriveRatingRangeLower { get; set; }
		double? HyperdriveRatingRangeUpper { get; set; }
		int?[]? MGLTs { get; set; }
		int? MGLTRangeLower { get; set; }
		int? MGLTRangeUpper { get; set; }
		bool? StarshipClass { get; set; }
		bool? StarshipClassFlags { get; set; }

		public IStarship.ISearch AsStarshipSearch(string? searchstring = null)
		{
			return new IStarship.ISearch.Default
			{
				SearchString = searchstring,

				SearchContainables = new IStarship.ISearchContainables.Default
				{
					Description = Description ?? false,
					Model = Model ?? false,
					Name = Name ?? false,
					StarshipClass = StarshipClass ?? false,
					StarshipClassFlags = StarshipClassFlags ?? false,
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

				HyperdriveRatings = new IStarWarsModel.ISearchValues.Default<double?>(default)
				{
					Lower = HyperdriveRatingRangeLower,
					Upper = HyperdriveRatingRangeUpper,
					Values = HyperdriveRatings,
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

				MGLTs = new IStarWarsModel.ISearchValues.Default<int?>(default)
				{
					Lower = MGLTRangeLower,
					Upper = MGLTRangeUpper,
					Values = MGLTs,
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
		}
		public IEnumerable<string> AsQueryData(IStarshipsSearchQuery<string>? keys = null)
		{
			IEnumerable<string> querydata = AsQueryData(keys as ITransportersSearchQuery<string>);

			if (HyperdriveRatings != null)
				querydata = querydata.Concat(HyperdriveRatings.Select(hyperdriverating => string.Format("{0}={1}", keys?.HyperdriveRatings ?? nameof(HyperdriveRatings).ToLower(), hyperdriverating)));

			if (HyperdriveRatingRangeLower.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.HyperdriveRatingRangeLower ?? nameof(HyperdriveRatingRangeLower).ToLower(), HyperdriveRatingRangeLower.Value));

			if (HyperdriveRatingRangeUpper.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.HyperdriveRatingRangeUpper ?? nameof(HyperdriveRatingRangeUpper).ToLower(), HyperdriveRatingRangeUpper.Value));

			if (MGLTs != null)
				querydata = querydata.Concat(MGLTs.Select(mglt => string.Format("{0}={1}", keys?.MGLTs ?? nameof(MGLTs).ToLower(), mglt)));

			if (MGLTRangeLower.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.MGLTRangeLower ?? nameof(MGLTRangeLower).ToLower(), MGLTRangeLower.Value));

			if (MGLTRangeUpper.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.MGLTRangeUpper ?? nameof(MGLTRangeUpper).ToLower(), MGLTRangeUpper.Value));

			if (StarshipClass.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.StarshipClass ?? nameof(StarshipClass).ToLower(), StarshipClass.Value));

			if (StarshipClassFlags.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.StarshipClassFlags ?? nameof(StarshipClassFlags).ToLower(), StarshipClassFlags.Value));

			return querydata;
		}

		public new class Default : ITransportersSearchQuery.Default, IStarshipsSearchQuery
		{
			public Default() : base() { }
			public Default(IStarship.ISearch starshipsearch) : base(starshipsearch)
			{
				StarshipClass = starshipsearch.SearchContainables?.StarshipClass;
				StarshipClassFlags = starshipsearch.SearchContainables?.StarshipClassFlags;

				HyperdriveRatings = starshipsearch.HyperdriveRatings?.Values?.ToArray();
				HyperdriveRatingRangeLower = starshipsearch.HyperdriveRatings?.Lower;
				HyperdriveRatingRangeUpper = starshipsearch.HyperdriveRatings?.Upper;

				MGLTs = starshipsearch.MGLTs?.Values?.ToArray();
				MGLTRangeLower = starshipsearch.MGLTs?.Lower;
				MGLTRangeUpper = starshipsearch.MGLTs?.Upper;
			}

			public double?[]? HyperdriveRatings { get; set; }
			public double? HyperdriveRatingRangeLower { get; set; }
			public double? HyperdriveRatingRangeUpper { get; set; }
			public int?[]? MGLTs { get; set; }
			public int? MGLTRangeLower { get; set; }
			public int? MGLTRangeUpper { get; set; }
			public bool? StarshipClass { get; set; }
			public bool? StarshipClassFlags { get; set; }
		}
		public new class Default<T> : ITransportersSearchQuery.Default<T>, IStarshipsSearchQuery<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				HyperdriveRatings = defaultvalue;
				HyperdriveRatingRangeLower = defaultvalue;
				HyperdriveRatingRangeUpper = defaultvalue;
				MGLTs = defaultvalue;
				MGLTRangeLower = defaultvalue;
				MGLTRangeUpper = defaultvalue;
				StarshipClass = defaultvalue;
				StarshipClassFlags = defaultvalue;
			}

			public T HyperdriveRatings { get; set; }
			public T HyperdriveRatingRangeLower { get; set; }
			public T HyperdriveRatingRangeUpper { get; set; }
			public T MGLTs { get; set; }
			public T MGLTRangeLower { get; set; }
			public T MGLTRangeUpper { get; set; }
			public T StarshipClass { get; set; }
			public T StarshipClassFlags { get; set; }
		}
	}
}
