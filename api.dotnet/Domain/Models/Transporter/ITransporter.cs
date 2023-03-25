using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Models
{
	public interface ITransporter<T> : IStarWarsModel<T>
	{
		T CargoCapacity { get; set; }
		T Consumables { get; set; }
		T CostInCredits { get; set; }
		T Description { get; set; }
		T Length { get; set; }
		T ManufacturerIds { get; set; }
		T MaxAtmospheringSpeed { get; set; }
		T MaxCrew { get; set; }
		T MinCrew { get; set; }
		T Model { get; set; }
		T Name { get; set; }
		T Passengers { get; set; }
		T PilotIds { get; set; }

		public new string ToString(StringBuilder? stringBuilder = null)
		{
			return (this as IStarWarsModel<T>).ToString(
				(stringBuilder ?? new StringBuilder())
					.AppendFormat("{0}: {1}", nameof(CargoCapacity), CargoCapacity).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Consumables), Consumables).AppendLine()
					.AppendFormat("{0}: {1}", nameof(CostInCredits), CostInCredits).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Length), Length).AppendLine()
					.AppendFormat("{0}: {1}", nameof(ManufacturerIds), ManufacturerIds).AppendLine()
					.AppendFormat("{0}: {1}", nameof(MaxAtmospheringSpeed), MaxAtmospheringSpeed).AppendLine()
					.AppendFormat("{0}: {1}", nameof(MaxCrew), MaxCrew).AppendLine()
					.AppendFormat("{0}: {1}", nameof(MinCrew), MinCrew).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Model), Model).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Name), Name).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Passengers), Passengers).AppendLine()
					.AppendFormat("{0}: {1}", nameof(PilotIds), PilotIds).AppendLine());
		}
	}
	public interface ITransporterTyped<T> : ITransporter<T>, IStarWarsModelTyped<T>
	{
		new ITransporter.IConsumable<T>? Consumables { get; set; }
	}
	public partial interface ITransporter : IStarWarsModel
	{
		long? CargoCapacity { get; set; }
		IConsumable? Consumables { get; set; }
		long? CostInCredits { get; set; }
		string? Description { get; set; }
		double? Length { get; set; }
		IEnumerable<int>? ManufacturerIds { get; set; }
		int? MaxAtmospheringSpeed { get; set; }
		int? MaxCrew { get; set; }
		int? MinCrew { get; set; }
		string? Model { get; set; }
		string? Name { get; set; }
		int? Passengers { get; set; }
		IEnumerable<int>? PilotIds { get; set; }

		public new class Default : IStarWarsModel.Default, ITransporter
		{
			public Default(int id) : base(id) { }
			public Default(int id, JObject jobject) : base(id, jobject)
			{
				if (jobject.Type is JTokenType.Null)
					return;

				CargoCapacity = jobject.GetValue(nameof(CargoCapacity), StringComparison.OrdinalIgnoreCase)?.ToObject<long?>();
				Consumables = jobject.GetValue(nameof(Consumables), StringComparison.OrdinalIgnoreCase) is JObject ConsumablesJObject && ConsumablesJObject.Type is not JTokenType.Null
					? new IConsumable.Default(JObject.FromObject(ConsumablesJObject))
					: null;
				CostInCredits = jobject.GetValue(nameof(CostInCredits), StringComparison.OrdinalIgnoreCase)?.ToObject<long?>();
				Description = jobject.GetValue(nameof(Description), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>();
				Length = jobject.GetValue(nameof(Length), StringComparison.OrdinalIgnoreCase)?.ToObject<double?>();
				ManufacturerIds = jobject.GetValue(nameof(ManufacturerIds), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Values<int>();
				MaxAtmospheringSpeed = jobject.GetValue(nameof(MaxAtmospheringSpeed), StringComparison.OrdinalIgnoreCase)?.ToObject<int?>();
				MaxCrew = jobject.GetValue(nameof(MaxCrew), StringComparison.OrdinalIgnoreCase)?.ToObject<int?>();
				MinCrew = jobject.GetValue(nameof(MinCrew), StringComparison.OrdinalIgnoreCase)?.ToObject<int?>();
				Model = jobject.GetValue(nameof(Model), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>();
				Name = jobject.GetValue(nameof(Name), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>();
				Passengers = jobject.GetValue(nameof(Passengers), StringComparison.OrdinalIgnoreCase)?.ToObject<int?>();
				PilotIds = jobject.GetValue(nameof(PilotIds), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Values<int>();
			}

			public long? CargoCapacity { get; set; }
			public IConsumable? Consumables { get; set; }
			public long? CostInCredits { get; set; }
			public string? Description { get; set; }
			public double? Length { get; set; }
			public IEnumerable<int>? ManufacturerIds { get; set; }
			public int? MaxAtmospheringSpeed { get; set; }
			public int? MaxCrew { get; set; }
			public int? MinCrew { get; set; }
			public string? Model { get; set; }
			public string? Name { get; set; }
			public int? Passengers { get; set; }
			public IEnumerable<int>? PilotIds { get; set; }
		}
		public new class Default<T> : IStarWarsModel.Default<T>, ITransporter<T> 
		{
			public Default(T defaultvalue) : base(defaultvalue) 
			{
				CargoCapacity = defaultvalue;
				Consumables = defaultvalue;
				CostInCredits = defaultvalue;
				Description = defaultvalue;
				Length = defaultvalue;
				ManufacturerIds = defaultvalue;
				MaxAtmospheringSpeed = defaultvalue;
				MaxCrew = defaultvalue;
				MinCrew = defaultvalue;
				Model = defaultvalue;
				Name = defaultvalue;
				Passengers = defaultvalue;
				PilotIds = defaultvalue;
			}

			public T CargoCapacity { get; set; }
			public T Consumables { get; set; }
			public T CostInCredits { get; set; }
			public T Description { get; set; }
			public T Length { get; set; }
			public T ManufacturerIds { get; set; }
			public T MaxAtmospheringSpeed { get; set; }
			public T MaxCrew { get; set; }
			public T MinCrew { get; set; }
			public T Model { get; set; }
			public T Name { get; set; }
			public T Passengers { get; set; }
			public T PilotIds { get; set; }
		}
		public new class DefaultTyped<T> : Default<T>, ITransporterTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue)
			{
				BaseTyped = new IStarWarsModel.DefaultTyped<T>(defaultvalue);
			}

			private IStarWarsModelTyped<T> BaseTyped { get; set; }
			IURI<T>? IStarWarsModelTyped<T>.Uris
			{
				get => BaseTyped.Uris;
				set => BaseTyped.Uris = value;
			}

			public new ITransporter.IConsumable<T>? Consumables { get; set; }
		}

		public new string ToString(StringBuilder? stringBuilder = null)
		{
			return (this as IStarWarsModel).ToString(
				(stringBuilder ?? new StringBuilder())
					.AppendFormat("{0}: {1}", nameof(CargoCapacity), CargoCapacity).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Consumables), Consumables).AppendLine()
					.AppendFormat("{0}: {1}", nameof(CostInCredits), CostInCredits).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Length), Length).AppendLine()
					.AppendFormat("{0}: ", nameof(ManufacturerIds)).AppendJoin(", ", ManufacturerIds ?? Enumerable.Empty<int>()).AppendLine()
					.AppendFormat("{0}: {1}", nameof(MaxAtmospheringSpeed), MaxAtmospheringSpeed).AppendLine()
					.AppendFormat("{0}: {1}", nameof(MaxCrew), MaxCrew).AppendLine()
					.AppendFormat("{0}: {1}", nameof(MinCrew), MinCrew).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Model), Model).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Name), Name).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Passengers), Passengers).AppendLine()
					.AppendFormat("{0}: ", nameof(PilotIds)).AppendJoin(", ", PilotIds ?? Enumerable.Empty<int>()).AppendLine());
		}
	}
}
