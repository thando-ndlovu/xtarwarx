using Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Queries.Search
{
	public interface IPlanetsSearchQuery<T> : IStarWarsModelSearchQuery<T>
	{
		T ClimateTypes { get; set; }
		T ClimateFlags { get; set; }
		T Description { get; set; }
		T Diameters { get; set; }
		T DiameterRangeLower { get; set; }
		T DiameterRangeUpper { get; set; }
		T Gravities { get; set; }
		T GravityRangeLower { get; set; }
		T GravityRangeUpper { get; set; }
		T Name { get; set; }
		T OrbitalPeriods { get; set; }
		T OrbitalPeriodRangeLower { get; set; }
		T OrbitalPeriodRangeUpper { get; set; }
		T Populations { get; set; }
		T PopulationRangeLower { get; set; }
		T PopulationRangeUpper { get; set; }
		T ResidentsDescription { get; set; }
		T ResidentsName { get; set; }
		T RotationalPeriods { get; set; }
		T RotationalPeriodRangeLower { get; set; }
		T RotationalPeriodRangeUpper { get; set; }
		T SurfaceWaters { get; set; }
		T SurfaceWaterRangeLower { get; set; }
		T SurfaceWaterRangeUpper { get; set; }
		T TerrainTypes { get; set; }
		T TerrainFlags { get; set; }

		public new IEnumerable<T> AsEnumerable()
		{
			return (this as IStarWarsModelSearchQuery<T>).AsEnumerable()
				.Append(ClimateTypes)
				.Append(ClimateFlags)
				.Append(Description)
				.Append(Diameters)
				.Append(DiameterRangeLower)
				.Append(DiameterRangeUpper)
				.Append(Gravities)
				.Append(GravityRangeLower)
				.Append(GravityRangeUpper)
				.Append(Name)
				.Append(OrbitalPeriods)
				.Append(OrbitalPeriodRangeLower)
				.Append(OrbitalPeriodRangeUpper)
				.Append(Populations)
				.Append(PopulationRangeLower)
				.Append(PopulationRangeUpper)
				.Append(ResidentsDescription)
				.Append(ResidentsName)
				.Append(RotationalPeriods)
				.Append(RotationalPeriodRangeLower)
				.Append(RotationalPeriodRangeUpper)
				.Append(SurfaceWaters)
				.Append(SurfaceWaterRangeLower)
				.Append(SurfaceWaterRangeUpper)
				.Append(TerrainTypes)
				.Append(TerrainFlags);
		}
	}
	public interface IPlanetsSearchQuery : IStarWarsModelSearchQuery
	{
		string[]? ClimateTypes { get; set; }
		string[]? ClimateFlags { get; set; }
		bool? Description { get; set; }
		int?[]? Diameters { get; set; }
		int? DiameterRangeLower { get; set; }
		int? DiameterRangeUpper { get; set; }
		double?[]? Gravities { get; set; }
		double? GravityRangeLower { get; set; }
		double? GravityRangeUpper { get; set; }
		bool? Name { get; set; }
		TimeSpan?[]? OrbitalPeriods { get; set; }
		TimeSpan? OrbitalPeriodRangeLower { get; set; }
		TimeSpan? OrbitalPeriodRangeUpper { get; set; }
		long?[]? Populations { get; set; }
		long? PopulationRangeLower { get; set; }
		long? PopulationRangeUpper { get; set; }
		bool? ResidentsDescription { get; set; }
		bool? ResidentsName { get; set; }
		TimeSpan?[]? RotationalPeriods { get; set; }
		TimeSpan? RotationalPeriodRangeLower { get; set; }
		TimeSpan? RotationalPeriodRangeUpper { get; set; }
		double?[]? SurfaceWaters { get; set; }
		double? SurfaceWaterRangeLower { get; set; }
		double? SurfaceWaterRangeUpper { get; set; }
		string[]? TerrainTypes { get; set; }
		string[]? TerrainFlags { get; set; }

		public bool ShouldSearchResidents()
		{
			return
				(ResidentsDescription ?? false) ||
				(ResidentsName ?? false);
		}

		public IPlanet.ISearch AsPlanetSearch(string? searchstring = null)
		{
			return new IPlanet.ISearch.Default
			{
				SearchString = searchstring,

				SearchContainables = new IPlanet.ISearchContainables.Default
				{
					Description = Description ?? false,
					Name = Name ?? false,
				},

				ClimateTypes = ClimateTypes?.ToArray(),
				ClimateFlags = ClimateFlags?.ToArray(),

				Diameters = new IStarWarsModel.ISearchValues.Default<int?>(default)
				{
					Lower = DiameterRangeLower,
					Upper = DiameterRangeUpper,
					Values = Diameters,
				},

				Gravities = new IStarWarsModel.ISearchValues.Default<double?>(default)
				{
					Lower = GravityRangeLower,
					Upper = GravityRangeUpper,
					Values = Gravities,
				},

				OrbitalPeriods = new IStarWarsModel.ISearchValues.Default<TimeSpan?>(default)
				{
					Lower = OrbitalPeriodRangeLower,
					Upper = OrbitalPeriodRangeUpper,
					Values = OrbitalPeriods,
				},

				Populations = new IStarWarsModel.ISearchValues.Default<long?>(default)
				{
					Lower = PopulationRangeLower,
					Upper = PopulationRangeUpper,
					Values = Populations,
				},

				Residents = new ICharacter.ISearchContainables.Default
				{
					Description = ResidentsDescription ?? false,
					Name = ResidentsName ?? false,
				},

				RotationalPeriods = new IStarWarsModel.ISearchValues.Default<TimeSpan?>(default)
				{
					Lower = RotationalPeriodRangeLower,
					Upper = RotationalPeriodRangeUpper,
					Values = RotationalPeriods,
				},

				SurfaceWaters = new IStarWarsModel.ISearchValues.Default<double?>(default)
				{
					Lower = SurfaceWaterRangeLower,
					Upper = SurfaceWaterRangeUpper,
					Values = SurfaceWaters,
				},

				TerrainTypes = TerrainTypes?.ToArray(),
				TerrainFlags = TerrainFlags?.ToArray(),
			};
		}
		public IEnumerable<string> AsQueryData(IPlanetsSearchQuery<string>? keys = null)
		{
			IEnumerable<string> querydata = AsQueryData(keys as IStarWarsModelSearchQuery<string>);

			if (ClimateTypes != null)
				querydata = querydata.Concat(ClimateTypes.Select(climatetype => string.Format("{0}={1}", keys?.ClimateTypes ?? nameof(ClimateTypes).ToLower(), climatetype)));

			if (ClimateFlags != null)
				querydata = querydata.Concat(ClimateFlags.Select(climateflag => string.Format("{0}={1}", keys?.ClimateFlags ?? nameof(ClimateFlags).ToLower(), climateflag)));

			if (Diameters != null)
				querydata = querydata.Concat(Diameters.Select(diameter => string.Format("{0}={1}", keys?.Diameters ?? nameof(Diameters).ToLower(), diameter)));

			if (DiameterRangeLower.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.DiameterRangeLower ?? nameof(DiameterRangeLower).ToLower(), DiameterRangeLower.Value));

			if (DiameterRangeUpper.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.DiameterRangeUpper ?? nameof(DiameterRangeUpper).ToLower(), DiameterRangeUpper.Value));

			if (Description.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.Description ?? nameof(Description).ToLower(), Description.Value));

			if (Gravities != null)
				querydata = querydata.Concat(Gravities.Select(gravity => string.Format("{0}={1}", keys?.Gravities ?? nameof(Gravities).ToLower(), gravity)));

			if (GravityRangeLower.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.GravityRangeLower ?? nameof(GravityRangeLower).ToLower(), GravityRangeLower.Value));

			if (GravityRangeUpper.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.GravityRangeUpper ?? nameof(GravityRangeUpper).ToLower(), GravityRangeUpper.Value));

			if (Name.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.Name ?? nameof(Name).ToLower(), Name.Value));

			if (OrbitalPeriods != null)
				querydata = querydata.Concat(OrbitalPeriods.Select(orbitalperiod => string.Format("{0}={1}", keys?.OrbitalPeriods ?? nameof(OrbitalPeriods).ToLower(), orbitalperiod)));

			if (OrbitalPeriodRangeLower.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.OrbitalPeriodRangeLower ?? nameof(OrbitalPeriodRangeLower).ToLower(), OrbitalPeriodRangeLower.Value));

			if (OrbitalPeriodRangeUpper.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.OrbitalPeriodRangeUpper ?? nameof(OrbitalPeriodRangeUpper).ToLower(), OrbitalPeriodRangeUpper.Value));

			if (Populations != null)
				querydata = querydata.Concat(Populations.Select(population => string.Format("{0}={1}", keys?.Populations ?? nameof(Populations).ToLower(), population)));

			if (PopulationRangeLower.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.PopulationRangeLower ?? nameof(PopulationRangeLower).ToLower(), PopulationRangeLower.Value));

			if (PopulationRangeUpper.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.PopulationRangeUpper ?? nameof(PopulationRangeUpper).ToLower(), PopulationRangeUpper.Value));

			if (ResidentsDescription.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.ResidentsDescription ?? nameof(ResidentsDescription).ToLower(), ResidentsDescription.Value));

			if (ResidentsName.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.ResidentsName ?? nameof(ResidentsName).ToLower(), ResidentsName.Value));

			if (RotationalPeriods != null)
				querydata = querydata.Concat(RotationalPeriods.Select(rotationalperiod => string.Format("{0}={1}", keys?.RotationalPeriods ?? nameof(RotationalPeriods).ToLower(), rotationalperiod)));

			if (RotationalPeriodRangeLower.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.RotationalPeriodRangeLower ?? nameof(RotationalPeriodRangeLower).ToLower(), RotationalPeriodRangeLower.Value));

			if (RotationalPeriodRangeUpper.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.RotationalPeriodRangeUpper ?? nameof(RotationalPeriodRangeUpper).ToLower(), RotationalPeriodRangeUpper.Value));

			if (SurfaceWaters != null)
				querydata = querydata.Concat(SurfaceWaters.Select(surfacewater => string.Format("{0}={1}", keys?.SurfaceWaters ?? nameof(SurfaceWaters).ToLower(), surfacewater)));

			if (SurfaceWaterRangeLower.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.SurfaceWaterRangeLower ?? nameof(SurfaceWaterRangeLower).ToLower(), SurfaceWaterRangeLower.Value));

			if (SurfaceWaterRangeUpper.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.SurfaceWaterRangeUpper ?? nameof(SurfaceWaterRangeUpper).ToLower(), SurfaceWaterRangeUpper.Value));

			if (TerrainTypes != null)
				querydata = querydata.Concat(TerrainTypes.Select(terraintype => string.Format("{0}={1}", keys?.TerrainTypes ?? nameof(TerrainTypes).ToLower(), terraintype)));

			if (TerrainFlags != null)
				querydata = querydata.Concat(TerrainFlags.Select(terrainflag => string.Format("{0}={1}", keys?.TerrainFlags ?? nameof(TerrainFlags).ToLower(), terrainflag)));

			return querydata;
		}

		public new class Default : IStarWarsModelSearchQuery.Default, IPlanetsSearchQuery
		{
			public Default() : base() { }
			public Default(IPlanet.ISearch planetsearch) : base(planetsearch)
			{
				Description = planetsearch.SearchContainables?.Description;
				Name = planetsearch.SearchContainables?.Name;

				ClimateTypes = planetsearch.ClimateTypes?.ToArray();
				ClimateFlags = planetsearch.ClimateFlags?.ToArray();

				Diameters = planetsearch.Diameters?.Values?.ToArray();
				DiameterRangeLower = planetsearch.Diameters?.Lower;
				DiameterRangeUpper = planetsearch.Diameters?.Upper;

				Gravities = planetsearch.Gravities?.Values?.ToArray();
				GravityRangeLower = planetsearch.Gravities?.Lower;
				GravityRangeUpper = planetsearch.Gravities?.Upper;

				OrbitalPeriods = planetsearch.OrbitalPeriods?.Values?.ToArray();
				OrbitalPeriodRangeLower = planetsearch.OrbitalPeriods?.Lower;
				OrbitalPeriodRangeUpper = planetsearch.OrbitalPeriods?.Upper;

				Populations = planetsearch.Populations?.Values?.ToArray();
				PopulationRangeLower = planetsearch.Populations?.Lower;
				PopulationRangeUpper = planetsearch.Populations?.Upper;

				RotationalPeriods = planetsearch.RotationalPeriods?.Values?.ToArray();
				RotationalPeriodRangeLower = planetsearch.RotationalPeriods?.Lower;
				RotationalPeriodRangeUpper = planetsearch.RotationalPeriods?.Upper;

				ResidentsDescription = planetsearch.Residents?.Description;
				ResidentsName = planetsearch.Residents?.Name;

				SurfaceWaters = planetsearch.SurfaceWaters?.Values?.ToArray();
				SurfaceWaterRangeLower = planetsearch.SurfaceWaters?.Lower;
				SurfaceWaterRangeUpper = planetsearch.SurfaceWaters?.Upper;

				TerrainTypes = planetsearch.TerrainTypes?.ToArray();
				TerrainFlags = planetsearch.TerrainFlags?.ToArray();
			}

			public string[]? ClimateTypes { get; set; }
			public string[]? ClimateFlags { get; set; }
			public int?[]? Diameters { get; set; }
			public int? DiameterRangeLower { get; set; }
			public int? DiameterRangeUpper { get; set; }
			public bool? Description { get; set; }
			public double?[]? Gravities { get; set; }
			public double? GravityRangeLower { get; set; }
			public double? GravityRangeUpper { get; set; }
			public bool? Name { get; set; }
			public TimeSpan?[]? OrbitalPeriods { get; set; }
			public TimeSpan? OrbitalPeriodRangeLower { get; set; }
			public TimeSpan? OrbitalPeriodRangeUpper { get; set; }
			public long?[]? Populations { get; set; }
			public long? PopulationRangeLower { get; set; }
			public long? PopulationRangeUpper { get; set; }
			public bool? ResidentsDescription { get; set; }
			public bool? ResidentsName { get; set; }
			public TimeSpan?[]? RotationalPeriods { get; set; }
			public TimeSpan? RotationalPeriodRangeLower { get; set; }
			public TimeSpan? RotationalPeriodRangeUpper { get; set; }
			public double?[]? SurfaceWaters { get; set; }
			public double? SurfaceWaterRangeLower { get; set; }
			public double? SurfaceWaterRangeUpper { get; set; }
			public string[]? TerrainTypes { get; set; }
			public string[]? TerrainFlags { get; set; }
		}
		public new class Default<T> : IStarWarsModelSearchQuery.Default<T>, IPlanetsSearchQuery<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				ClimateTypes = defaultvalue;
				ClimateFlags = defaultvalue;
				Description = defaultvalue;
				Diameters = defaultvalue;
				DiameterRangeLower = defaultvalue;
				DiameterRangeUpper = defaultvalue;
				Gravities = defaultvalue;
				GravityRangeLower = defaultvalue;
				GravityRangeUpper = defaultvalue;
				Name = defaultvalue;
				OrbitalPeriods = defaultvalue;
				OrbitalPeriodRangeLower = defaultvalue;
				OrbitalPeriodRangeUpper = defaultvalue;
				Populations = defaultvalue;
				PopulationRangeLower = defaultvalue;
				PopulationRangeUpper = defaultvalue;
				ResidentsDescription = defaultvalue;
				ResidentsName = defaultvalue;
				RotationalPeriods = defaultvalue;
				RotationalPeriodRangeLower = defaultvalue;
				RotationalPeriodRangeUpper = defaultvalue;
				SurfaceWaters = defaultvalue;
				SurfaceWaterRangeLower = defaultvalue;
				SurfaceWaterRangeUpper = defaultvalue;
				TerrainTypes = defaultvalue;
				TerrainFlags = defaultvalue;
			}

			public T ClimateTypes { get; set; }
			public T ClimateFlags { get; set; }
			public T Description { get; set; }
			public T Diameters { get; set; }
			public T DiameterRangeLower { get; set; }
			public T DiameterRangeUpper { get; set; }
			public T Gravities { get; set; }
			public T GravityRangeLower { get; set; }
			public T GravityRangeUpper { get; set; }
			public T Name { get; set; }
			public T OrbitalPeriods { get; set; }
			public T OrbitalPeriodRangeLower { get; set; }
			public T OrbitalPeriodRangeUpper { get; set; }
			public T Populations { get; set; }
			public T PopulationRangeLower { get; set; }
			public T PopulationRangeUpper { get; set; }
			public T ResidentsDescription { get; set; }
			public T ResidentsName { get; set; }
			public T RotationalPeriods { get; set; }
			public T RotationalPeriodRangeLower { get; set; }
			public T RotationalPeriodRangeUpper { get; set; }
			public T SurfaceWaters { get; set; }
			public T SurfaceWaterRangeLower { get; set; }
			public T SurfaceWaterRangeUpper { get; set; }
			public T TerrainTypes { get; set; }
			public T TerrainFlags { get; set; }
		}
	}
}
