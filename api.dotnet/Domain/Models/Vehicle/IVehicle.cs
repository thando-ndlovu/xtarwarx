using Newtonsoft.Json.Linq;

using System;
using System.Text;

namespace Domain.Models
{
	public interface IVehicle<T> : ITransporter<T>
	{
		T VehicleClass { get; set; }

		public new string ToString(StringBuilder? stringBuilder = null)
		{
			return (this as IStarWarsModel<T>).ToString(
				(stringBuilder ?? new StringBuilder())
					.AppendFormat("{0}: {1}", nameof(VehicleClass), VehicleClass).AppendLine());
		}
	}
	public interface IVehicleTyped<T> : IVehicle<T>, ITransporterTyped<T>
	{
		new IVehicle.IVehicleClass<T>? VehicleClass { get; set; }
	}
	public partial interface IVehicle : ITransporter
	{
		IVehicleClass? VehicleClass { get; set; }

		public new class Default : ITransporter.Default, IVehicle
		{
			public Default(int id) : base(id) { }
			public Default(int id, JObject jobject) : base(id, jobject)
			{
				VehicleClass = jobject.GetValue(nameof(VehicleClass), StringComparison.OrdinalIgnoreCase) is JObject VehicleClassJObject && VehicleClassJObject.Type is not JTokenType.Null
					? new IVehicleClass.Default(JObject.FromObject(VehicleClassJObject))
					: null;
			}

			public IVehicleClass? VehicleClass { get; set; }
		}
		public new class Default<T> : ITransporter.Default<T>, IVehicle<T>
		{
			public Default(T defaultvalue) : base(defaultvalue) 
			{
				VehicleClass = defaultvalue;
			}

			public T VehicleClass { get; set; }
		}
		public new class DefaultTyped<T> : Default<T>, IVehicleTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue)
			{
				BaseTyped = new ITransporter.DefaultTyped<T>(defaultvalue);
			}

			private ITransporterTyped<T> BaseTyped { get; set; }
			IConsumable<T>? ITransporterTyped<T>.Consumables
			{
				get => BaseTyped.Consumables;
				set => BaseTyped.Consumables = value;
			}
			IURI<T>? IStarWarsModelTyped<T>.Uris
			{
				get => BaseTyped.Uris;
				set => BaseTyped.Uris = value;
			}

			public new IVehicleClass<T>? VehicleClass { get; set; }
		}

		public new string ToString(StringBuilder? stringBuilder = null)
		{
			return (this as IStarWarsModel).ToString(
				(stringBuilder ?? new StringBuilder())
					.AppendFormat("{0}: {1}", nameof(VehicleClass), VehicleClass).AppendLine());
		}
	}
}
