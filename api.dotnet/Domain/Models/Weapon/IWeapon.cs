using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Models
{
	public interface IWeapon<T> : IStarWarsModel<T>
	{
		T Description { get; set; }
		T ManufacturerIds { get; set; }
		T Model { get; set; }
		T Name { get; set; }
		T WeaponClass { get; set; }

		public new string ToString(StringBuilder? stringBuilder = null)
		{
			return (this as IStarWarsModel<T>).ToString(
				(stringBuilder ?? new StringBuilder())
					.AppendFormat("{0}: {1}", nameof(Description), Description).AppendLine()
					.AppendFormat("{0}: {1}", nameof(ManufacturerIds), ManufacturerIds).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Name), Name).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Model), Model).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Name), Name).AppendLine()
					.AppendFormat("{0}: {1}", nameof(WeaponClass), WeaponClass).AppendLine());
		}
	}
	public interface IWeaponTyped<T> : IWeapon<T>, IStarWarsModelTyped<T>
	{
		new IWeapon.IWeaponClass<T>? WeaponClass { get; set; }
	}
	public partial interface IWeapon : IStarWarsModel
	{
		string? Description { get; set; }
		IEnumerable<int>? ManufacturerIds { get; set; }
		string? Model { get; set; }
		string? Name { get; set; }
		IWeaponClass? WeaponClass { get; set; }

		public new class Default : IStarWarsModel.Default, IWeapon
		{
			public Default(int id) : base(id) { }
			public Default(int id, JObject jobject) : base(id, jobject)
			{
				Description = jobject.GetValue(nameof(Description), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>();
				ManufacturerIds = jobject.GetValue(nameof(ManufacturerIds), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Values<int>(); 
				Model = jobject.GetValue(nameof(Model), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>();
				Name = jobject.GetValue(nameof(Name), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>();
				WeaponClass = jobject.GetValue(nameof(WeaponClass), StringComparison.OrdinalIgnoreCase) is JObject WeaponClassJObject && WeaponClassJObject.Type is not JTokenType.Null
					? new IWeaponClass.Default(JObject.FromObject(WeaponClassJObject))
					: null;
			}

			public string? Description { get; set; }
			public IEnumerable<int>? ManufacturerIds { get; set; }
			public string? Model { get; set; }
			public string? Name { get; set; }
			public IWeaponClass? WeaponClass { get; set; }
		}
		public new class Default<T> : IStarWarsModel.Default<T>, IWeapon<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				Description = defaultvalue;
				ManufacturerIds = defaultvalue;
				Model = defaultvalue;
				Name = defaultvalue;
				WeaponClass = defaultvalue;
			}

			public T Description { get; set; }
			public T ManufacturerIds { get; set; }
			public T Model { get; set; }
			public T Name { get; set; }
			public T WeaponClass { get; set; }
		}
		public new class DefaultTyped<T> : Default<T>, IWeaponTyped<T>
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

			public new IWeaponClass<T>? WeaponClass { get; set; }
		}

		public new string ToString(StringBuilder? stringBuilder = null)
		{
			return (this as IStarWarsModel).ToString(
				(stringBuilder ?? new StringBuilder())
					.AppendFormat("{0}: {1}", nameof(Description), Description).AppendLine()
					.AppendFormat("{0}: ", nameof(ManufacturerIds)).AppendJoin(", ", ManufacturerIds ?? Enumerable.Empty<int>()).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Name), Name).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Model), Model).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Name), Name).AppendLine()
					.AppendFormat("{0}: {1}", nameof(WeaponClass), WeaponClass).AppendLine());
		}
	}
}
