using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Models
{
	public interface IPlanet<T> : IStarWarsModel<T>
	{
		T Climates { get; set; }
		T Description { get; set; }
		T Diameter { get; set; }
		T Gravity { get; set; }
		T Name { get; set; }
		T OrbitalPeriod { get; set; }
		T Population { get; set; }
		T ResidentIds { get; set; }
		T RotationalPeriod { get; set; }
		T SurfaceWater { get; set; }
		T Terrains { get; set; }

		public new string ToString(StringBuilder? stringBuilder = null)
		{
			return (this as IStarWarsModel<T>).ToString(
				(stringBuilder ?? new StringBuilder())
					.AppendFormat("{0}: {1}", nameof(Climates), Climates).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Description), Description).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Diameter), Diameter).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Gravity), Gravity).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Name), Name).AppendLine()
					.AppendFormat("{0}: {1}", nameof(OrbitalPeriod), OrbitalPeriod).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Population), Population).AppendLine()
					.AppendFormat("{0}: {1}", nameof(ResidentIds), ResidentIds).AppendLine()
					.AppendFormat("{0}: {1}", nameof(RotationalPeriod), RotationalPeriod).AppendLine()
					.AppendFormat("{0}: {1}", nameof(SurfaceWater), SurfaceWater).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Terrains), Terrains).AppendLine());
		}
	}
	public interface IPlanetTyped<T> : IPlanet<T>, IStarWarsModelTyped<T>
	{
		new IPlanet.IClimate<T>? Climates { get; set; }
		new IPlanet.ITerrain<T>? Terrains { get; set; }
	}
	public partial interface IPlanet : IStarWarsModel
	{
		IEnumerable<IClimate>? Climates { get; set; }
		string? Description { get; set; }
		int? Diameter { get; set; }
		double? Gravity { get; set; }
		string? Name { get; set; }
		TimeSpan? OrbitalPeriod { get; set; }
		long? Population { get; set; }
		IEnumerable<int>? ResidentIds { get; set; }
		TimeSpan? RotationalPeriod { get; set; }
		double? SurfaceWater { get; set; }
		IEnumerable<ITerrain>? Terrains { get; set; }

		public new string ToString(StringBuilder? stringBuilder = null)
		{
			return (this as IStarWarsModel).ToString(
				(stringBuilder ?? new StringBuilder())
					.AppendFormat("{0}: ", nameof(Climates)).AppendJoin(", ", Climates?.Select(_ => _.ToString()) ?? Enumerable.Empty<string>()).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Description), Description).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Diameter), Diameter).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Gravity), Gravity).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Name), Name).AppendLine()
					.AppendFormat("{0}: {1}", nameof(OrbitalPeriod), OrbitalPeriod).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Population), Population).AppendLine()
					.AppendFormat("{0}: ", nameof(ResidentIds)).AppendJoin(", ", ResidentIds ?? Enumerable.Empty<int>()).AppendLine()
					.AppendFormat("{0}: {1}", nameof(RotationalPeriod), RotationalPeriod).AppendLine()
					.AppendFormat("{0}: {1}", nameof(SurfaceWater), SurfaceWater).AppendLine()
					.AppendFormat("{0}: ", nameof(Terrains)).AppendJoin(", ", Terrains?.Select(_ => _.ToString()) ?? Enumerable.Empty<string>()).AppendLine());
		}

		public new class Default : IStarWarsModel.Default, IPlanet
		{
			public Default(int id) : base(id) { }
			public Default(int id, JObject jobject) : base(id, jobject) 
			{
				Climates = jobject.GetValue(nameof(Climates), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Select(ClimateJObject => new IClimate.Default(JObject.FromObject(ClimateJObject)));
				Description = jobject.GetValue(nameof(Description), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>();
				Diameter = jobject.GetValue(nameof(Diameter), StringComparison.OrdinalIgnoreCase)?.ToObject<int?>();
				Gravity = jobject.GetValue(nameof(Gravity), StringComparison.OrdinalIgnoreCase)?.ToObject<double?>();
				Name = jobject.GetValue(nameof(Name), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>();
				OrbitalPeriod = jobject.GetValue(nameof(OrbitalPeriod), StringComparison.OrdinalIgnoreCase)?.ToObject<int?>() is not int orbitalperiodvalue
					? new TimeSpan?()
					: TimeSpan.FromDays(orbitalperiodvalue);
				Population = jobject.GetValue(nameof(Population), StringComparison.OrdinalIgnoreCase)?.ToObject<long?>();
				ResidentIds = jobject.GetValue(nameof(ResidentIds), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Values<int>();
				RotationalPeriod = jobject.GetValue(nameof(RotationalPeriod), StringComparison.OrdinalIgnoreCase)?.ToObject<int?>() is not int rotationalperiodvalue
					? new TimeSpan?()
					: TimeSpan.FromHours(rotationalperiodvalue);
				SurfaceWater = jobject.GetValue(nameof(SurfaceWater), StringComparison.OrdinalIgnoreCase)?.ToObject<double?>();
				Terrains = jobject.GetValue(nameof(Terrains), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Select(TerrainJObject => new ITerrain.Default(JObject.FromObject(TerrainJObject)));
			}

			public IEnumerable<IClimate>? Climates { get; set; }
			public string? Description { get; set; }
			public int? Diameter { get; set; }
			public double? Gravity { get; set; }
			public string? Name { get; set; }
			public TimeSpan? OrbitalPeriod { get; set; }
			public long? Population { get; set; }
			public IEnumerable<int>? ResidentIds { get; set; }
			public TimeSpan? RotationalPeriod { get; set; }
			public double? SurfaceWater { get; set; }
			public IEnumerable<ITerrain>? Terrains { get; set; }
		}
		public new class Default<T> : IStarWarsModel.Default<T>, IPlanet<T> 
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				Climates = defaultvalue;
				Description = defaultvalue;
				Diameter = defaultvalue;
				Gravity = defaultvalue;
				Name = defaultvalue;
				OrbitalPeriod = defaultvalue;
				Population = defaultvalue;
				ResidentIds = defaultvalue;
				RotationalPeriod = defaultvalue;
				SurfaceWater = defaultvalue;
				Terrains = defaultvalue;
			}

			public T Climates { get; set; }
			public T Description { get; set; }
			public T Diameter { get; set; }
			public T Gravity { get; set; }
			public T Name { get; set; }
			public T OrbitalPeriod { get; set; }
			public T Population { get; set; }
			public T ResidentIds { get; set; }
			public T RotationalPeriod { get; set; }
			public T SurfaceWater { get; set; }
			public T Terrains { get; set; }
		}
		public new class DefaultTyped<T> : Default<T>, IPlanetTyped<T>
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

			public new IClimate<T>? Climates { get; set; }
			public new ITerrain<T>? Terrains { get; set; }
		}
	}
}
