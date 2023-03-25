using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Models
{
	public interface IManufacturer<T> : IStarWarsModel<T>
	{
		T Description { get; set; }
		T HeadquatersPlanetId { get; set; }
		T Name { get; set; }
		T StarshipIds { get; set; }
		T VehicleIds { get; set; }
		T WeaponIds { get; set; }

		public new string ToString(StringBuilder? stringBuilder = null)
		{
			return (this as IStarWarsModel<T>).ToString(
				(stringBuilder ?? new StringBuilder())
					.AppendFormat("{0}: {1}", nameof(Description), Description).AppendLine()
					.AppendFormat("{0}: {1}", nameof(HeadquatersPlanetId), HeadquatersPlanetId).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Name), Name).AppendLine()
					.AppendFormat("{0}: {1}", nameof(StarshipIds), StarshipIds).AppendLine()
					.AppendFormat("{0}: {1}", nameof(VehicleIds), VehicleIds).AppendLine()
					.AppendFormat("{0}: {1}", nameof(WeaponIds), WeaponIds).AppendLine());
		}
	}
	public interface IManufacturerTyped<T> : IManufacturer<T>, IStarWarsModelTyped<T> { }
	public partial interface IManufacturer : IStarWarsModel
	{
		string? Description { get; set; }
		int? HeadquatersPlanetId { get; set; }
		string? Name { get; set; }
		IEnumerable<int>? StarshipIds { get; set; }
		IEnumerable<int>? VehicleIds { get; set; }
		IEnumerable<int>? WeaponIds { get; set; }

		public new class Default : IStarWarsModel.Default, IManufacturer
		{
			public Default(int id) : base(id) { }
			public Default(int id, JObject jobject) : base(id, jobject)
			{
				Description = jobject.GetValue(nameof(Description), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>();
				HeadquatersPlanetId = jobject.GetValue(nameof(HeadquatersPlanetId), StringComparison.OrdinalIgnoreCase)?.ToObject<int?>();
				Name = jobject.GetValue(nameof(Name), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>();
				StarshipIds = jobject.GetValue(nameof(StarshipIds), StringComparison.OrdinalIgnoreCase)?.ToObject<IEnumerable<int>?>();
				VehicleIds = jobject.GetValue(nameof(VehicleIds), StringComparison.OrdinalIgnoreCase)?.ToObject<IEnumerable<int>?>();
				WeaponIds = jobject.GetValue(nameof(WeaponIds), StringComparison.OrdinalIgnoreCase)?.ToObject<IEnumerable<int>?>();
			}

			public string? Description { get; set; }
			public int? HeadquatersPlanetId { get; set; }
			public string? Name { get; set; }
			public IEnumerable<int>? StarshipIds { get; set; }
			public IEnumerable<int>? VehicleIds { get; set; }
			public IEnumerable<int>? WeaponIds { get; set; }
		}
		public new class Default<T> : IStarWarsModel.Default<T>, IManufacturer<T> 
		{
			public Default(T defaultvalue) : base(defaultvalue) 
			{
				Description = defaultvalue;
				HeadquatersPlanetId = defaultvalue;
				Name = defaultvalue;
				StarshipIds = defaultvalue;
				VehicleIds = defaultvalue;
				WeaponIds = defaultvalue;
			}

			public T Description { get; set; }
			public T HeadquatersPlanetId { get; set; }
			public T Name { get; set; }
			public T StarshipIds { get; set; }
			public T VehicleIds { get; set; }
			public T WeaponIds { get; set; }
		}
		public new class DefaultTyped<T> : Default<T>, IManufacturerTyped<T>
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
		}

		public new string ToString(StringBuilder? stringBuilder = null)
		{
			return (this as IStarWarsModel).ToString(
				(stringBuilder ?? new StringBuilder())
					.AppendFormat("{0}: {1}", nameof(Description), Description).AppendLine()
					.AppendFormat("{0}: {1}", nameof(HeadquatersPlanetId), HeadquatersPlanetId).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Name), Name).AppendLine()
					.AppendFormat("{0}: ", nameof(StarshipIds)).AppendJoin(", ", StarshipIds ?? Enumerable.Empty<int>()).AppendLine()
					.AppendFormat("{0}: ", nameof(VehicleIds)).AppendJoin(", ", VehicleIds ?? Enumerable.Empty<int>()).AppendLine()
					.AppendFormat("{0}: ", nameof(WeaponIds)).AppendJoin(", ", WeaponIds ?? Enumerable.Empty<int>()).AppendLine());
		}
	}
}
