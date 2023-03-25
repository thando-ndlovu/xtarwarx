using Localisation.Abstractions.StarWarsModels;

using System;
using System.Text;

namespace Localisation.Abstractions.Planets
{
	public interface IPlanetSearchLocalisation<T> : IStarWarsModelSearchLocalisation<T>
	{
		T Containables { get; set; }
		T ClimateFlagsList { get; set; }
		T ClimateTypesList { get; set; }
		T DiametersList { get; set; }
		T DiameterRange { get; set; }
		T GravitiesList { get; set; }
		T GravityRange { get; set; }
		T OrbitalPeriodsList { get; set; }
		T OrbitalPeriodRange { get; set; }
		T PopulationsList { get; set; }
		T PopulationRange { get; set; }
		T ResidentsSearchContainables { get; set; }
		T RotationalPeriodsList { get; set; }
		T RotationalPeriodRange { get; set; }
		T SurfaceWatersList { get; set; }
		T SurfaceWaterRange { get; set; }
		T TerrainFlagsList { get; set; }
		T TerrainTypesList { get; set; }

		public new string ToString(StringBuilder? stringbuilder = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(Containables), Containables).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ClimateFlagsList), ClimateFlagsList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ClimateTypesList), ClimateTypesList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(DiameterRange), DiameterRange).AppendLine()
				.AppendFormat("{0}: {1}", nameof(DiametersList), DiametersList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(GravitiesList), GravitiesList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(GravityRange), GravityRange).AppendLine()
				.AppendFormat("{0}: {1}", nameof(OrbitalPeriodRange), OrbitalPeriodRange).AppendLine()
				.AppendFormat("{0}: {1}", nameof(OrbitalPeriodsList), OrbitalPeriodsList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(PopulationRange), PopulationRange).AppendLine()
				.AppendFormat("{0}: {1}", nameof(PopulationsList), PopulationsList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ResidentsSearchContainables), ResidentsSearchContainables).AppendLine()
				.AppendFormat("{0}: {1}", nameof(RotationalPeriodRange), RotationalPeriodRange).AppendLine()
				.AppendFormat("{0}: {1}", nameof(RotationalPeriodsList), RotationalPeriodsList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(SurfaceWaterRange), SurfaceWaterRange).AppendLine()
				.AppendFormat("{0}: {1}", nameof(SurfaceWatersList), SurfaceWatersList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(TerrainFlagsList), TerrainFlagsList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(TerrainTypesList), TerrainTypesList).AppendLine();

			return (this as IStarWarsModelSearchLocalisation<T>).ToString(stringbuilder);
		}
	}		
	public interface IPlanetSearchLocalisationTyped<T> : IStarWarsModelSearchLocalisationTyped<T>
	{
		ISearchItemLocalisation<T> Containables { get; set; }
		ISearchListLocalisation<T> ClimateFlagsList { get; set; } 
		ISearchListLocalisation<T> ClimateTypesList { get; set; } 
		ISearchListLocalisation<T> DiametersList { get; set; }
		ISearchRangeLocalisation<T> DiameterRange { get; set; }
		ISearchListLocalisation<T> GravitiesList { get; set; }
		ISearchRangeLocalisation<T> GravityRange { get; set; }
		ISearchListLocalisation<T> OrbitalPeriodsList { get; set; }
		ISearchRangeLocalisation<T> OrbitalPeriodRange { get; set; }
		ISearchListLocalisation<T> PopulationsList { get; set; }
		ISearchRangeLocalisation<T> PopulationRange { get; set; }
		ISearchItemLocalisation<T> ResidentsSearchContainables { get; set; }
		ISearchListLocalisation<T> RotationalPeriodsList { get; set; }
		ISearchRangeLocalisation<T> RotationalPeriodRange { get; set; }
		ISearchListLocalisation<T> SurfaceWatersList { get; set; }
		ISearchRangeLocalisation<T> SurfaceWaterRange { get; set; }
		ISearchListLocalisation<T> TerrainFlagsList { get; set; }  
		ISearchListLocalisation<T> TerrainTypesList { get; set; }  

		public new string ToString(StringBuilder? stringbuilder = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendLine(nameof(Containables)).AppendLine(Containables.ToString()).AppendLine()
				.AppendLine(nameof(ClimateFlagsList)).AppendLine(ClimateFlagsList.ToString()).AppendLine()
				.AppendLine(nameof(ClimateTypesList)).AppendLine(ClimateTypesList.ToString()).AppendLine()
				.AppendLine(nameof(DiameterRange)).AppendLine(DiameterRange.ToString()).AppendLine()
				.AppendLine(nameof(DiametersList)).AppendLine(DiametersList.ToString()).AppendLine()
				.AppendLine(nameof(GravitiesList)).AppendLine(GravitiesList.ToString()).AppendLine()
				.AppendLine(nameof(GravityRange)).AppendLine(GravityRange.ToString()).AppendLine()
				.AppendLine(nameof(OrbitalPeriodRange)).AppendLine(OrbitalPeriodRange.ToString()).AppendLine()
				.AppendLine(nameof(OrbitalPeriodsList)).AppendLine(OrbitalPeriodsList.ToString()).AppendLine()
				.AppendLine(nameof(PopulationRange)).AppendLine(PopulationRange.ToString()).AppendLine()
				.AppendLine(nameof(PopulationsList)).AppendLine(PopulationsList.ToString()).AppendLine()
				.AppendLine(nameof(ResidentsSearchContainables)).AppendLine(ResidentsSearchContainables.ToString()).AppendLine()
				.AppendLine(nameof(RotationalPeriodRange)).AppendLine(RotationalPeriodRange.ToString()).AppendLine()
				.AppendLine(nameof(RotationalPeriodsList)).AppendLine(RotationalPeriodsList.ToString()).AppendLine()
				.AppendLine(nameof(SurfaceWaterRange)).AppendLine(SurfaceWaterRange.ToString()).AppendLine()
				.AppendLine(nameof(SurfaceWatersList)).AppendLine(SurfaceWatersList.ToString()).AppendLine()
				.AppendLine(nameof(TerrainFlagsList)).AppendLine(TerrainFlagsList.ToString()).AppendLine()
				.AppendLine(nameof(TerrainTypesList)).AppendLine(TerrainTypesList.ToString()).AppendLine();

			return (this as IStarWarsModelSearchLocalisationTyped<T>).ToString(stringbuilder);
		}
	}
	public interface IPlanetSearchLocalisation : IStarWarsModelSearchLocalisation
	{
		ISearchItemLocalisation? Containables { get; set; }
		ISearchListLocalisation? ClimateFlagsList { get; set; }
		ISearchListLocalisation? ClimateTypesList { get; set; }
		ISearchListLocalisation? DiametersList { get; set; }
		ISearchRangeLocalisation? DiameterRange { get; set; }
		ISearchListLocalisation? GravitiesList { get; set; }
		ISearchRangeLocalisation? GravityRange { get; set; }
		ISearchListLocalisation? OrbitalPeriodsList { get; set; }
		ISearchRangeLocalisation? OrbitalPeriodRange { get; set; }
		ISearchListLocalisation? PopulationsList { get; set; }
		ISearchRangeLocalisation? PopulationRange { get; set; }
		ISearchItemLocalisation? ResidentsSearchContainables { get; set; }
		ISearchListLocalisation? RotationalPeriodsList { get; set; }
		ISearchRangeLocalisation? RotationalPeriodRange { get; set; }
		ISearchListLocalisation? SurfaceWatersList { get; set; }
		ISearchRangeLocalisation? SurfaceWaterRange { get; set; }
		ISearchListLocalisation? TerrainFlagsList { get; set; }
		ISearchListLocalisation? TerrainTypesList { get; set; }

		public string ToString(StringBuilder? stringbuilder = null, IPlanetSearchLocalisation<Func<object?, string>>? converter = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendLine(nameof(Containables)).AppendLine(Containables?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(ClimateFlagsList)).AppendLine(ClimateFlagsList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(ClimateTypesList)).AppendLine(ClimateTypesList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(DiameterRange)).AppendLine(DiameterRange?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(DiametersList)).AppendLine(DiametersList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(GravitiesList)).AppendLine(GravitiesList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(GravityRange)).AppendLine(GravityRange?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(OrbitalPeriodRange)).AppendLine(OrbitalPeriodRange?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(OrbitalPeriodsList)).AppendLine(OrbitalPeriodsList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(PopulationRange)).AppendLine(PopulationRange?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(PopulationsList)).AppendLine(PopulationsList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(ResidentsSearchContainables)).AppendLine(ResidentsSearchContainables?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(RotationalPeriodRange)).AppendLine(RotationalPeriodRange?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(RotationalPeriodsList)).AppendLine(RotationalPeriodsList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(SurfaceWaterRange)).AppendLine(SurfaceWaterRange?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(SurfaceWatersList)).AppendLine(SurfaceWatersList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(TerrainFlagsList)).AppendLine(TerrainFlagsList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(TerrainTypesList)).AppendLine(TerrainTypesList?.ToString(null, converter)).AppendLine();

			return (this as IStarWarsModelSearchLocalisation).ToString(stringbuilder, converter);
		}

		public new class Default : IStarWarsModelSearchLocalisation.Default, IPlanetSearchLocalisation
		{
			public ISearchItemLocalisation? Containables { get; set; }
			public ISearchListLocalisation? ClimateFlagsList { get; set; }
			public ISearchListLocalisation? ClimateTypesList { get; set; }
			public ISearchListLocalisation? DiametersList { get; set; }
			public ISearchRangeLocalisation? DiameterRange { get; set; }
			public ISearchListLocalisation? GravitiesList { get; set; }
			public ISearchRangeLocalisation? GravityRange { get; set; }
			public ISearchListLocalisation? OrbitalPeriodsList { get; set; }
			public ISearchRangeLocalisation? OrbitalPeriodRange { get; set; }
			public ISearchListLocalisation? PopulationsList { get; set; }
			public ISearchRangeLocalisation? PopulationRange { get; set; }
			public ISearchItemLocalisation? ResidentsSearchContainables { get; set; }
			public ISearchListLocalisation? RotationalPeriodsList { get; set; }
			public ISearchRangeLocalisation? RotationalPeriodRange { get; set; }
			public ISearchListLocalisation? SurfaceWatersList { get; set; }
			public ISearchRangeLocalisation? SurfaceWaterRange { get; set; }
			public ISearchListLocalisation? TerrainFlagsList { get; set; }
			public ISearchListLocalisation? TerrainTypesList { get; set; }
		}
		public new class DefaultTyped<T> : IStarWarsModelSearchLocalisation.DefaultTyped<T>, IPlanetSearchLocalisationTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue)
			{
				Containables = new ISearchItemLocalisation.Default<T>(defaultvalue);
				ClimateFlagsList = new ISearchListLocalisation.Default<T>(defaultvalue);
				ClimateTypesList = new ISearchListLocalisation.Default<T>(defaultvalue);
				DiametersList = new ISearchListLocalisation.Default<T>(defaultvalue);
				DiameterRange = new ISearchRangeLocalisation.Default<T>(defaultvalue);
				GravitiesList = new ISearchListLocalisation.Default<T>(defaultvalue);
				GravityRange = new ISearchRangeLocalisation.Default<T>(defaultvalue);
				OrbitalPeriodsList = new ISearchListLocalisation.Default<T>(defaultvalue);
				OrbitalPeriodRange = new ISearchRangeLocalisation.Default<T>(defaultvalue);
				PopulationsList = new ISearchListLocalisation.Default<T>(defaultvalue);
				PopulationRange = new ISearchRangeLocalisation.Default<T>(defaultvalue);
				ResidentsSearchContainables = new ISearchItemLocalisation.Default<T>(defaultvalue);
				RotationalPeriodsList = new ISearchListLocalisation.Default<T>(defaultvalue);
				RotationalPeriodRange = new ISearchRangeLocalisation.Default<T>(defaultvalue);
				SurfaceWatersList = new ISearchListLocalisation.Default<T>(defaultvalue);
				SurfaceWaterRange = new ISearchRangeLocalisation.Default<T>(defaultvalue);
				TerrainFlagsList = new ISearchListLocalisation.Default<T>(defaultvalue);
				TerrainTypesList = new ISearchListLocalisation.Default<T>(defaultvalue);
			}

			public ISearchItemLocalisation<T> Containables { get; set; }
			public ISearchListLocalisation<T> ClimateFlagsList { get; set; }
			public ISearchListLocalisation<T> ClimateTypesList { get; set; }
			public ISearchListLocalisation<T> DiametersList { get; set; }
			public ISearchRangeLocalisation<T> DiameterRange { get; set; }
			public ISearchListLocalisation<T> GravitiesList { get; set; }
			public ISearchRangeLocalisation<T> GravityRange { get; set; }
			public ISearchListLocalisation<T> OrbitalPeriodsList { get; set; }
			public ISearchRangeLocalisation<T> OrbitalPeriodRange { get; set; }
			public ISearchListLocalisation<T> PopulationsList { get; set; }
			public ISearchRangeLocalisation<T> PopulationRange { get; set; }
			public ISearchItemLocalisation<T> ResidentsSearchContainables { get; set; }
			public ISearchListLocalisation<T> RotationalPeriodsList { get; set; }
			public ISearchRangeLocalisation<T> RotationalPeriodRange { get; set; }
			public ISearchListLocalisation<T> SurfaceWatersList { get; set; }
			public ISearchRangeLocalisation<T> SurfaceWaterRange { get; set; }
			public ISearchListLocalisation<T> TerrainFlagsList { get; set; }
			public ISearchListLocalisation<T> TerrainTypesList { get; set; }
		}
		public new class Default<T> : IStarWarsModelSearchLocalisation.Default<T>, IPlanetSearchLocalisation<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				Containables = defaultvalue;
				ClimateFlagsList = defaultvalue;
				ClimateTypesList = defaultvalue;
				DiametersList = defaultvalue;
				DiameterRange = defaultvalue;
				GravitiesList = defaultvalue;
				GravityRange = defaultvalue;
				OrbitalPeriodsList = defaultvalue;
				OrbitalPeriodRange = defaultvalue;
				PopulationsList = defaultvalue;
				PopulationRange = defaultvalue;
				ResidentsSearchContainables = defaultvalue;
				RotationalPeriodsList = defaultvalue;
				RotationalPeriodRange = defaultvalue;
				SurfaceWatersList = defaultvalue;
				SurfaceWaterRange = defaultvalue;
				TerrainFlagsList = defaultvalue;
				TerrainTypesList = defaultvalue;
			}

			public T Containables { get; set; }
			public T ClimateFlagsList { get; set; }
			public T ClimateTypesList { get; set; }
			public T DiametersList { get; set; }
			public T DiameterRange { get; set; }
			public T GravitiesList { get; set; }
			public T GravityRange { get; set; }
			public T OrbitalPeriodsList { get; set; }
			public T OrbitalPeriodRange { get; set; }
			public T PopulationsList { get; set; }
			public T PopulationRange { get; set; }
			public T ResidentsSearchContainables { get; set; }
			public T RotationalPeriodsList { get; set; }
			public T RotationalPeriodRange { get; set; }
			public T SurfaceWatersList { get; set; }
			public T SurfaceWaterRange { get; set; }
			public T TerrainFlagsList { get; set; }
			public T TerrainTypesList { get; set; }
		}
	}
}
