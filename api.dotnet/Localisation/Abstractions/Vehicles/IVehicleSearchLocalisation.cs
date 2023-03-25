using Localisation.Abstractions.StarWarsModels;
using Localisation.Abstractions.Transporters;

using System;
using System.Text;

namespace Localisation.Abstractions.Vehicles
{
	public interface IVehicleSearchLocalisation<T> : ITransporterSearchLocalisation<T>
	{
		T Containables { get; set; }

		public new string ToString(StringBuilder? stringbuilder = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(Containables), Containables).AppendLine();

			return (this as ITransporterSearchLocalisation<T>).ToString(stringbuilder);
		}
	}
	public interface IVehicleSearchLocalisationTyped<T> : ITransporterSearchLocalisationTyped<T>
	{
		ISearchItemLocalisation<T> Containables { get; set; }

		public new string ToString(StringBuilder? stringbuilder = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendLine(nameof(Containables)).AppendLine(Containables.ToString()).AppendLine();

			return (this as ITransporterSearchLocalisationTyped<T>).ToString(stringbuilder);
		}
	}
	public interface IVehicleSearchLocalisation : ITransporterSearchLocalisation
	{
		ISearchItemLocalisation? Containables { get; set; }

		public string ToString(StringBuilder? stringbuilder = null, IVehicleSearchLocalisation<Func<object?, string>>? converter = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendLine(nameof(Containables)).AppendLine(Containables?.ToString(null, converter)).AppendLine();

			return (this as ITransporterSearchLocalisation).ToString(stringbuilder, converter);
		}

		#region Defaults

		public new class Default : ITransporterSearchLocalisation.Default, IVehicleSearchLocalisation
		{
			public ISearchItemLocalisation? Containables { get; set; }
		}
		public new class DefaultTyped<T> : ITransporterSearchLocalisation.DefaultTyped<T>, IVehicleSearchLocalisationTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue)
			{
				Containables = new ISearchItemLocalisation.Default<T>(defaultvalue);
			}

			public ISearchItemLocalisation<T> Containables { get; set; }
		}
		public new class Default<T> : ITransporterSearchLocalisation.Default<T>, IVehicleSearchLocalisation<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				Containables = defaultvalue;
			}

			public T Containables { get; set; }
		}

		#endregion
	}
}
