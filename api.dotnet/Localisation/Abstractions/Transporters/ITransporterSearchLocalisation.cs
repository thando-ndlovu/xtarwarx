using Localisation.Abstractions.StarWarsModels;

using System;
using System.Text;

namespace Localisation.Abstractions.Transporters
{
	public interface ITransporterSearchLocalisation<T> : IStarWarsModelSearchLocalisation<T>
	{
		T CargoCapacitiesList { get; set; }
		T CargoCapacityRange { get; set; }
		T ConsumablesList { get; set; }
		T ConsumableRange { get; set; }			 
		T CostInCreditsList { get; set; }
		T CostInCreditRange { get; set; }
		T LengthsList { get; set; }
		T LengthRange { get; set; }
		T ManufacturersSearchContainables { get; set; }
		T MaxAtmospheringSpeedsList { get; set; }
		T MaxAtmospheringSpeedRange { get; set; }
		T MaxCrewsList { get; set; }
		T MaxCrewRange { get; set; }
		T MinCrewsList { get; set; }
		T MinCrewRange { get; set; }
		T PassengersList { get; set; }
		T PassengerRange { get; set; }
		T PilotsSearchContainables { get; set; }

		public new string ToString(StringBuilder? stringbuilder = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(CargoCapacitiesList), CargoCapacitiesList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(CargoCapacityRange), CargoCapacityRange).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ConsumableRange), ConsumableRange).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ConsumablesList), ConsumablesList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(CostInCreditRange), CostInCreditRange).AppendLine()
				.AppendFormat("{0}: {1}", nameof(CostInCreditsList), CostInCreditsList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(LengthRange), LengthRange).AppendLine()
				.AppendFormat("{0}: {1}", nameof(LengthsList), LengthsList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ManufacturersSearchContainables), ManufacturersSearchContainables).AppendLine()
				.AppendFormat("{0}: {1}", nameof(MaxAtmospheringSpeedRange), MaxAtmospheringSpeedRange).AppendLine()
				.AppendFormat("{0}: {1}", nameof(MaxAtmospheringSpeedsList), MaxAtmospheringSpeedsList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(MaxCrewRange), MaxCrewRange).AppendLine()
				.AppendFormat("{0}: {1}", nameof(MaxCrewsList), MaxCrewsList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(MinCrewRange), MinCrewRange).AppendLine()
				.AppendFormat("{0}: {1}", nameof(MinCrewsList), MinCrewsList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(PassengerRange), PassengerRange).AppendLine()
				.AppendFormat("{0}: {1}", nameof(PassengersList), PassengersList).AppendLine()
				.AppendFormat("{0}: {1}", nameof(PilotsSearchContainables), PilotsSearchContainables).AppendLine();

			return (this as IStarWarsModelSearchLocalisation<T>).ToString(stringbuilder);
		}
	}
	public interface ITransporterSearchLocalisationTyped<T> : IStarWarsModelSearchLocalisationTyped<T>
	{
		ISearchListLocalisation<T> CargoCapacitiesList { get; set; }
		ISearchRangeLocalisation<T> CargoCapacityRange { get; set; }
		ISearchListLocalisation<T> CostInCreditsList { get; set; }
		ISearchRangeLocalisation<T> CostInCreditRange { get; set; }		 
		ISearchListLocalisation<T> ConsumablesList { get; set; }
		ISearchRangeLocalisation<T> ConsumableRange { get; set; }
		ISearchListLocalisation<T> LengthsList { get; set; }
		ISearchRangeLocalisation<T> LengthRange { get; set; }
		ISearchItemLocalisation<T> ManufacturersSearchContainables { get; set; }
		ISearchListLocalisation<T> MaxAtmospheringSpeedsList { get; set; }
		ISearchRangeLocalisation<T> MaxAtmospheringSpeedRange { get; set; }
		ISearchListLocalisation<T> MaxCrewsList { get; set; }
		ISearchRangeLocalisation<T> MaxCrewRange { get; set; }
		ISearchListLocalisation<T> MinCrewsList { get; set; }
		ISearchRangeLocalisation<T> MinCrewRange { get; set; }
		ISearchListLocalisation<T> PassengersList { get; set; }
		ISearchRangeLocalisation<T> PassengerRange { get; set; }
		ISearchItemLocalisation<T> PilotsSearchContainables { get; set; }

		public new string ToString(StringBuilder? stringbuilder = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendLine(nameof(CargoCapacitiesList)).AppendLine(CargoCapacitiesList.ToString()).AppendLine()
				.AppendLine(nameof(CargoCapacityRange)).AppendLine(CargoCapacityRange.ToString()).AppendLine()
				.AppendLine(nameof(CostInCreditRange)).AppendLine(CostInCreditRange.ToString()).AppendLine()
				.AppendLine(nameof(CostInCreditsList)).AppendLine(CostInCreditsList.ToString()).AppendLine()
				.AppendLine(nameof(ConsumableRange)).AppendLine(ConsumableRange.ToString()).AppendLine()
				.AppendLine(nameof(ConsumablesList)).AppendLine(ConsumablesList.ToString()).AppendLine()
				.AppendLine(nameof(LengthRange)).AppendLine(LengthRange.ToString()).AppendLine()
				.AppendLine(nameof(LengthsList)).AppendLine(LengthsList.ToString()).AppendLine()
				.AppendLine(nameof(ManufacturersSearchContainables)).AppendLine(ManufacturersSearchContainables.ToString()).AppendLine()
				.AppendLine(nameof(MaxAtmospheringSpeedRange)).AppendLine(MaxAtmospheringSpeedRange.ToString()).AppendLine()
				.AppendLine(nameof(MaxAtmospheringSpeedsList)).AppendLine(MaxAtmospheringSpeedsList.ToString()).AppendLine()
				.AppendLine(nameof(MaxCrewRange)).AppendLine(MaxCrewRange.ToString()).AppendLine()
				.AppendLine(nameof(MaxCrewsList)).AppendLine(MaxCrewsList.ToString()).AppendLine()
				.AppendLine(nameof(MinCrewRange)).AppendLine(MinCrewRange.ToString()).AppendLine()
				.AppendLine(nameof(MinCrewsList)).AppendLine(MinCrewsList.ToString()).AppendLine()
				.AppendLine(nameof(PassengerRange)).AppendLine(PassengerRange.ToString()).AppendLine()
				.AppendLine(nameof(PassengersList)).AppendLine(PassengersList.ToString()).AppendLine()
				.AppendLine(nameof(PilotsSearchContainables)).AppendLine(PilotsSearchContainables.ToString()).AppendLine();

			return (this as IStarWarsModelSearchLocalisationTyped<T>).ToString(stringbuilder);
		}
	}
	public interface ITransporterSearchLocalisation	: IStarWarsModelSearchLocalisation
	{
		ISearchListLocalisation? CargoCapacitiesList { get; set; }
		ISearchRangeLocalisation? CargoCapacityRange { get; set; }
		ISearchListLocalisation? CostInCreditsList { get; set; }
		ISearchRangeLocalisation? CostInCreditRange { get; set; }	 
		ISearchListLocalisation? ConsumablesList { get; set; }
		ISearchRangeLocalisation? ConsumableRange { get; set; }
		ISearchListLocalisation? LengthsList { get; set; }
		ISearchRangeLocalisation? LengthRange { get; set; }
		ISearchItemLocalisation? ManufacturersSearchContainables { get; set; }
		ISearchListLocalisation? MaxAtmospheringSpeedsList { get; set; }
		ISearchRangeLocalisation? MaxAtmospheringSpeedRange { get; set; }
		ISearchListLocalisation? MaxCrewsList { get; set; }
		ISearchRangeLocalisation? MaxCrewRange { get; set; }
		ISearchListLocalisation? MinCrewsList { get; set; }
		ISearchRangeLocalisation? MinCrewRange { get; set; }
		ISearchListLocalisation? PassengersList { get; set; }
		ISearchRangeLocalisation? PassengerRange { get; set; }
		ISearchItemLocalisation? PilotsSearchContainables { get; set; }

		public string ToString(StringBuilder? stringbuilder = null, ITransporterSearchLocalisation<Func<object?, string>>? converter = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendLine(nameof(CargoCapacitiesList)).AppendLine(CargoCapacitiesList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(CargoCapacityRange)).AppendLine(CargoCapacityRange?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(CostInCreditRange)).AppendLine(CostInCreditRange?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(CostInCreditsList)).AppendLine(CostInCreditsList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(ConsumableRange)).AppendLine(ConsumableRange?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(ConsumablesList)).AppendLine(ConsumablesList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(LengthRange)).AppendLine(LengthRange?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(LengthsList)).AppendLine(LengthsList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(ManufacturersSearchContainables)).AppendLine(ManufacturersSearchContainables?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(MaxAtmospheringSpeedRange)).AppendLine(MaxAtmospheringSpeedRange?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(MaxAtmospheringSpeedsList)).AppendLine(MaxAtmospheringSpeedsList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(MaxCrewRange)).AppendLine(MaxCrewRange?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(MaxCrewsList)).AppendLine(MaxCrewsList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(MinCrewRange)).AppendLine(MinCrewRange?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(MinCrewsList)).AppendLine(MinCrewsList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(PassengerRange)).AppendLine(PassengerRange?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(PassengersList)).AppendLine(PassengersList?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(PilotsSearchContainables)).AppendLine(PilotsSearchContainables?.ToString(null, converter)).AppendLine();

			return (this as IStarWarsModelSearchLocalisation).ToString(stringbuilder, converter);
		}

		public new class Default : IStarWarsModelSearchLocalisation.Default, ITransporterSearchLocalisation
		{
			public ISearchListLocalisation? CargoCapacitiesList { get; set; }
			public ISearchRangeLocalisation? CargoCapacityRange { get; set; }
			public ISearchListLocalisation? CostInCreditsList { get; set; }
			public ISearchRangeLocalisation? CostInCreditRange { get; set; }		   
			public ISearchListLocalisation? ConsumablesList { get; set; }
			public ISearchRangeLocalisation? ConsumableRange { get; set; }
			public ISearchListLocalisation? CrewsList { get; set; }
			public ISearchRangeLocalisation? CrewRange { get; set; }
			public ISearchListLocalisation? LengthsList { get; set; }
			public ISearchRangeLocalisation? LengthRange { get; set; }
			public ISearchItemLocalisation? ManufacturersSearchContainables { get; set; }
			public ISearchListLocalisation? MaxAtmospheringSpeedsList { get; set; }
			public ISearchRangeLocalisation? MaxAtmospheringSpeedRange { get; set; }
			public ISearchListLocalisation? MaxCrewsList { get; set; }
			public ISearchRangeLocalisation? MaxCrewRange { get; set; }
			public ISearchListLocalisation? MinCrewsList { get; set; }
			public ISearchRangeLocalisation? MinCrewRange { get; set; }
			public ISearchListLocalisation? PassengersList { get; set; }
			public ISearchRangeLocalisation? PassengerRange { get; set; }
			public ISearchItemLocalisation? PilotsSearchContainables { get; set; }
		}		 
		public new class DefaultTyped<T> : IStarWarsModelSearchLocalisation.DefaultTyped<T>, ITransporterSearchLocalisationTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue)
			{
				CargoCapacitiesList = new ISearchListLocalisation.Default<T>(defaultvalue);
				CargoCapacityRange = new ISearchRangeLocalisation.Default<T>(defaultvalue);
				ConsumablesList = new ISearchListLocalisation.Default<T>(defaultvalue);
				ConsumableRange = new ISearchRangeLocalisation.Default<T>(defaultvalue);	  
				CostInCreditsList = new ISearchListLocalisation.Default<T>(defaultvalue);
				CostInCreditRange = new ISearchRangeLocalisation.Default<T>(defaultvalue);
				LengthsList = new ISearchListLocalisation.Default<T>(defaultvalue);
				LengthRange = new ISearchRangeLocalisation.Default<T>(defaultvalue);
				ManufacturersSearchContainables = new ISearchItemLocalisation.Default<T>(defaultvalue);
				MaxAtmospheringSpeedsList = new ISearchListLocalisation.Default<T>(defaultvalue);
				MaxAtmospheringSpeedRange = new ISearchRangeLocalisation.Default<T>(defaultvalue);
				MaxCrewsList = new ISearchListLocalisation.Default<T>(defaultvalue);
				MaxCrewRange = new ISearchRangeLocalisation.Default<T>(defaultvalue);
				MinCrewsList = new ISearchListLocalisation.Default<T>(defaultvalue);
				MinCrewRange = new ISearchRangeLocalisation.Default<T>(defaultvalue);
				PassengersList = new ISearchListLocalisation.Default<T>(defaultvalue);
				PassengerRange = new ISearchRangeLocalisation.Default<T>(defaultvalue);
				PilotsSearchContainables = new ISearchItemLocalisation.Default<T>(defaultvalue);
			}

			public ISearchListLocalisation<T> CargoCapacitiesList { get; set; }
			public ISearchRangeLocalisation<T> CargoCapacityRange { get; set; }
			public ISearchListLocalisation<T> ConsumablesList { get; set; }
			public ISearchRangeLocalisation<T> ConsumableRange { get; set; }
			public ISearchListLocalisation<T> CostInCreditsList { get; set; }
			public ISearchRangeLocalisation<T> CostInCreditRange { get; set; }
			public ISearchListLocalisation<T> LengthsList { get; set; }
			public ISearchRangeLocalisation<T> LengthRange { get; set; }
			public ISearchItemLocalisation<T> ManufacturersSearchContainables { get; set; }
			public ISearchListLocalisation<T> MaxAtmospheringSpeedsList { get; set; }
			public ISearchRangeLocalisation<T> MaxAtmospheringSpeedRange { get; set; }
			public ISearchListLocalisation<T> MaxCrewsList { get; set; }
			public ISearchRangeLocalisation<T> MaxCrewRange { get; set; }
			public ISearchListLocalisation<T> MinCrewsList { get; set; }
			public ISearchRangeLocalisation<T> MinCrewRange { get; set; }
			public ISearchListLocalisation<T> PassengersList { get; set; }
			public ISearchRangeLocalisation<T> PassengerRange { get; set; }
			public ISearchItemLocalisation<T> PilotsSearchContainables { get; set; }
		}					   		 
		public new class Default<T> : IStarWarsModelSearchLocalisation.Default<T>, ITransporterSearchLocalisation<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				CargoCapacitiesList = defaultvalue;
				CargoCapacityRange = defaultvalue;
				ConsumablesList = defaultvalue;
				ConsumableRange = defaultvalue;		 
				CostInCreditsList = defaultvalue;
				CostInCreditRange = defaultvalue;
				LengthsList = defaultvalue;
				LengthRange = defaultvalue;
				ManufacturersSearchContainables = defaultvalue;
				MaxAtmospheringSpeedsList = defaultvalue;
				MaxAtmospheringSpeedRange = defaultvalue;
				MaxCrewsList = defaultvalue;
				MaxCrewRange = defaultvalue;
				MinCrewsList = defaultvalue;
				MinCrewRange = defaultvalue;
				PassengersList = defaultvalue;
				PassengerRange = defaultvalue;
				PilotsSearchContainables = defaultvalue;
			}

			public T CargoCapacitiesList { get; set; }
			public T CargoCapacityRange { get; set; }
			public T ConsumablesList { get; set; }
			public T ConsumableRange { get; set; }  
			public T CostInCreditsList { get; set; }
			public T CostInCreditRange { get; set; }
			public T LengthsList { get; set; }
			public T LengthRange { get; set; }
			public T ManufacturersSearchContainables { get; set; }
			public T MaxAtmospheringSpeedsList { get; set; }
			public T MaxAtmospheringSpeedRange { get; set; }
			public T MaxCrewsList { get; set; }
			public T MaxCrewRange { get; set; }
			public T MinCrewsList { get; set; }
			public T MinCrewRange { get; set; }
			public T PassengersList { get; set; }
			public T PassengerRange { get; set; }
			public T PilotsSearchContainables { get; set; }
		}
	}
}
