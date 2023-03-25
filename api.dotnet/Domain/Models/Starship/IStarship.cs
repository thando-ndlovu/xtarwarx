using Newtonsoft.Json.Linq;

using System;
using System.Text;

namespace Domain.Models
{
	public interface IStarship<T> : ITransporter<T>
	{
		T HyperdriveRating { get; set; }
		T MGLT { get; set; }
		T StarshipClass { get; set; }

		public new string ToString(StringBuilder? stringBuilder = null)
		{
			return (this as ITransporter<T>).ToString(
				(stringBuilder ?? new StringBuilder())
					.AppendFormat("{0}: {1}", nameof(HyperdriveRating), HyperdriveRating).AppendLine()
					.AppendFormat("{0}: {1}", nameof(MGLT), MGLT).AppendLine()
					.AppendFormat("{0}: {1}", nameof(StarshipClass), StarshipClass).AppendLine());
		}
	}
	public interface IStarshipTyped<T> : IStarship<T>, ITransporterTyped<T>
	{
		public new IStarship.IStarshipClass<T>? StarshipClass { get; set; }
	}
	public partial interface IStarship : ITransporter
	{
		double? HyperdriveRating { get; set; }
		int? MGLT { get; set; }
		IStarshipClass? StarshipClass { get; set; }

		public new class Default : ITransporter.Default, IStarship
		{
			public Default(int id) : base(id) { }
			public Default(int id, JObject jobject) : base(id, jobject)
			{
				HyperdriveRating = jobject.GetValue(nameof(HyperdriveRating), StringComparison.OrdinalIgnoreCase)?.ToObject<double?>();
				MGLT = jobject.GetValue(nameof(MGLT), StringComparison.OrdinalIgnoreCase)?.ToObject<int?>();
				StarshipClass = jobject.GetValue(nameof(StarshipClass), StringComparison.OrdinalIgnoreCase) is JObject StarshipClassJObject && StarshipClassJObject.Type is not JTokenType.Null
					? new IStarshipClass.Default(JObject.FromObject(StarshipClassJObject))
					: null;
			}

			public double? HyperdriveRating { get; set; }
			public int? MGLT { get; set; }
			public IStarshipClass? StarshipClass { get; set; }
		}
		public new class Default<T> : ITransporter.Default<T>, IStarship<T> 
		{
			public Default(T defaultvalue) : base(defaultvalue) 
			{
				HyperdriveRating = defaultvalue;
				MGLT = defaultvalue;
				StarshipClass = defaultvalue;
			}

			public T HyperdriveRating { get; set; }
			public T MGLT { get; set; }
			public T StarshipClass { get; set; }
		}
		public new class DefaultTyped<T> : Default<T>, IStarshipTyped<T>
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

			public new IStarship.IStarshipClass<T>? StarshipClass { get; set; }
		}

		public new string ToString(StringBuilder? stringBuilder = null)
		{
			return (this as ITransporter).ToString(
				(stringBuilder ?? new StringBuilder())
					.AppendFormat("{0}: {1}", nameof(HyperdriveRating), HyperdriveRating).AppendLine()
					.AppendFormat("{0}: {1}", nameof(MGLT), MGLT).AppendLine()
					.AppendFormat("{0}: {1}", nameof(StarshipClass), StarshipClass).AppendLine());
		}
	}
}
