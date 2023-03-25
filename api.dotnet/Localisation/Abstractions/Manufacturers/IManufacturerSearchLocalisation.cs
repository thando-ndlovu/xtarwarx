using Localisation.Abstractions.StarWarsModels;

using System;
using System.Text;

namespace Localisation.Abstractions.Manufacturers
{
	public interface IManufacturerSearchLocalisation<T>	: IStarWarsModelSearchLocalisation<T>
	{
		T Containables { get; set; }
		T HeadquatersPlanetSearchContainables { get; set; }
		T StarshipsSearchContainables { get; set; }
		T VehiclesSearchContainables { get; set; }
		T WeaponsSearchContainables { get; set; }

		public new string ToString(StringBuilder? stringbuilder = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(Containables), Containables).AppendLine()
				.AppendFormat("{0}: {1}", nameof(HeadquatersPlanetSearchContainables), HeadquatersPlanetSearchContainables).AppendLine()
				.AppendFormat("{0}: {1}", nameof(StarshipsSearchContainables), StarshipsSearchContainables).AppendLine()
				.AppendFormat("{0}: {1}", nameof(VehiclesSearchContainables), VehiclesSearchContainables).AppendLine()
				.AppendFormat("{0}: {1}", nameof(WeaponsSearchContainables), WeaponsSearchContainables).AppendLine();

			return (this as IStarWarsModelSearchLocalisation<T>).ToString(stringbuilder);
		}
	}
	public interface IManufacturerSearchLocalisationTyped<T> : IStarWarsModelSearchLocalisationTyped<T>
	{
		ISearchItemLocalisation<T> Containables { get; set; }
		ISearchItemLocalisation<T> HeadquatersPlanetSearchContainables { get; set; }
		ISearchItemLocalisation<T> StarshipsSearchContainables { get; set; }
		ISearchItemLocalisation<T> VehiclesSearchContainables { get; set; }
		ISearchItemLocalisation<T> WeaponsSearchContainables { get; set; }

		public new string ToString(StringBuilder? stringbuilder = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendLine(nameof(Containables)).AppendLine(Containables.ToString()).AppendLine()
				.AppendLine(nameof(HeadquatersPlanetSearchContainables)).AppendLine(HeadquatersPlanetSearchContainables.ToString()).AppendLine()
				.AppendLine(nameof(StarshipsSearchContainables)).AppendLine(StarshipsSearchContainables.ToString()).AppendLine()
				.AppendLine(nameof(VehiclesSearchContainables)).AppendLine(VehiclesSearchContainables.ToString()).AppendLine()
				.AppendLine(nameof(WeaponsSearchContainables)).AppendLine(WeaponsSearchContainables.ToString()).AppendLine();

			return (this as IStarWarsModelSearchLocalisationTyped<T>).ToString(stringbuilder);
		}
	}
	public interface IManufacturerSearchLocalisation : IStarWarsModelSearchLocalisation
	{
		ISearchItemLocalisation? Containables { get; set; }
		ISearchItemLocalisation? HeadquatersPlanetSearchContainables { get; set; }
		ISearchItemLocalisation? StarshipsSearchContainables { get; set; }
		ISearchItemLocalisation? VehiclesSearchContainables { get; set; }
		ISearchItemLocalisation? WeaponsSearchContainables { get; set; }

		public string ToString(StringBuilder? stringbuilder = null, IManufacturerSearchLocalisation<Func<object?, string>>? converter = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendLine(nameof(Containables)).AppendLine(Containables?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(HeadquatersPlanetSearchContainables)).AppendLine(HeadquatersPlanetSearchContainables?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(StarshipsSearchContainables)).AppendLine(StarshipsSearchContainables?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(VehiclesSearchContainables)).AppendLine(VehiclesSearchContainables?.ToString(null, converter)).AppendLine()
				.AppendLine(nameof(WeaponsSearchContainables)).AppendLine(WeaponsSearchContainables?.ToString(null, converter)).AppendLine();

			return (this as IStarWarsModelSearchLocalisation).ToString(stringbuilder, converter);
		}

		public new class Default : IStarWarsModelSearchLocalisation.Default, IManufacturerSearchLocalisation
		{
			public ISearchItemLocalisation? Containables { get; set; }
			public ISearchItemLocalisation? HeadquatersPlanetSearchContainables { get; set; }
			public ISearchItemLocalisation? StarshipsSearchContainables { get; set; }
			public ISearchItemLocalisation? VehiclesSearchContainables { get; set; }
			public ISearchItemLocalisation? WeaponsSearchContainables { get; set; }
		}
		public new class DefaultTyped<T> : IStarWarsModelSearchLocalisation.DefaultTyped<T>, IManufacturerSearchLocalisationTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue)
			{
				Containables = new ISearchItemLocalisation.Default<T>(defaultvalue);
				HeadquatersPlanetSearchContainables = new ISearchItemLocalisation.Default<T>(defaultvalue);
				StarshipsSearchContainables = new ISearchItemLocalisation.Default<T>(defaultvalue);
				VehiclesSearchContainables = new ISearchItemLocalisation.Default<T>(defaultvalue);
				WeaponsSearchContainables = new ISearchItemLocalisation.Default<T>(defaultvalue);
			}

			public ISearchItemLocalisation<T> Containables { get; set; }
			public ISearchItemLocalisation<T> HeadquatersPlanetSearchContainables { get; set; }
			public ISearchItemLocalisation<T> StarshipsSearchContainables { get; set; }
			public ISearchItemLocalisation<T> VehiclesSearchContainables { get; set; }
			public ISearchItemLocalisation<T> WeaponsSearchContainables { get; set; }
		}	  
		public new class Default<T> : IStarWarsModelSearchLocalisation.Default<T>, IManufacturerSearchLocalisation<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				Containables = defaultvalue;
				HeadquatersPlanetSearchContainables = defaultvalue;
				StarshipsSearchContainables = defaultvalue;
				VehiclesSearchContainables = defaultvalue;
				WeaponsSearchContainables = defaultvalue;
			}

			public T Containables { get; set; }
			public T HeadquatersPlanetSearchContainables { get; set; }
			public T StarshipsSearchContainables { get; set; }
			public T VehiclesSearchContainables { get; set; }
			public T WeaponsSearchContainables { get; set; }
		}
	}
}
