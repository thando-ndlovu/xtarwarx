using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Domain.Models
{
	public interface ICharacter<T> : IStarWarsModel<T> 
	{
		T BirthYear { get; set; }
		T Description { get; set; }
		T EyeColors { get; set; }
		T HairColors { get; set; }
		T Height { get; set; }
		T HomeworldId { get; set; }
		T Mass { get; set; }
		T Name { get; set; }
		T Sex { get; set; }
		T SkinColors { get; set; }

		public new string ToString(StringBuilder? stringBuilder = null)
		{
			return (this as IStarWarsModel<T>).ToString(
				(stringBuilder ?? new StringBuilder())
					.AppendFormat("{0}: {1}", nameof(Description), Description).AppendLine()
					.AppendFormat("{0}: {1}", nameof(EyeColors), EyeColors).AppendLine()
					.AppendFormat("{0}: {1}", nameof(HairColors), HairColors).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Height), Height).AppendLine()
					.AppendFormat("{0}: {1}", nameof(HomeworldId), HomeworldId).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Mass), Mass).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Name), Name).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Sex), Sex).AppendLine()
					.AppendFormat("{0}: {1}", nameof(SkinColors), SkinColors).AppendLine());
		}
	}
	public interface ICharacterTyped<T> : ICharacter<T>, IStarWarsModelTyped<T> { }
	public partial interface ICharacter : IStarWarsModel
	{
		double? BirthYear { get; set; }
		string? Description { get; set; }
		IEnumerable<KnownColor>? EyeColors { get; set; }
		IEnumerable<KnownColor>? HairColors { get; set; }
		int? Height { get; set; }
		int? HomeworldId { get; set; }
		double? Mass { get; set; }
		string? Name { get; set; }
		string? Sex { get; set; }
		IEnumerable<KnownColor>? SkinColors { get; set; }

		public new class Default : IStarWarsModel.Default, ICharacter
		{
			public Default(int id) : base(id) { }
			public Default(int id, JObject jobject) : base(id, jobject)
			{
				BirthYear = jobject.GetValue(nameof(BirthYear), StringComparison.OrdinalIgnoreCase)?.ToObject<double?>();
				Description = jobject.GetValue(nameof(Description), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>();
				EyeColors = jobject.GetValue(nameof(EyeColors), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Values<string?>()
					.Select(value =>
					{
						if (Enum.TryParse(value, out KnownColor knowncolor) && default(KnownColor).NonSystemColors().Contains(knowncolor))
							return knowncolor;

						throw new ArgumentException(string.Format("Color '{0}' is not a valid color", value));
					});
				HairColors = jobject.GetValue(nameof(HairColors), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Values<string?>()
					.Select(value =>
					{
						if (Enum.TryParse(value, out KnownColor knowncolor) && default(KnownColor).NonSystemColors().Contains(knowncolor))
							return knowncolor;

						throw new ArgumentException(string.Format("Color '{0}' is not a valid color", value));
					});
				Height = jobject.GetValue(nameof(Height), StringComparison.OrdinalIgnoreCase)?.ToObject<int?>();
				HomeworldId = jobject.GetValue(nameof(HomeworldId), StringComparison.OrdinalIgnoreCase)?.ToObject<int?>();
				Mass = jobject.GetValue(nameof(Mass), StringComparison.OrdinalIgnoreCase)?.ToObject<int?>();
				Name = jobject.GetValue(nameof(Name), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>();
				Sex = jobject.GetValue(nameof(Sex), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>() is not string sexvalue
					? null
					: Sexes.AsEnumerable()
						.FirstOrDefault(sex => string.Equals(sex, sexvalue, StringComparison.OrdinalIgnoreCase))
						?? throw new ArgumentException(string.Format("Sex '{0}' is invalid.", sexvalue));
				SkinColors = jobject.GetValue(nameof(SkinColors), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Values<string?>()
					.Select(value =>
					{
						if (Enum.TryParse(value, out KnownColor knowncolor) && default(KnownColor).NonSystemColors().Contains(knowncolor))
							return knowncolor;

						throw new ArgumentException(string.Format("Color '{0}' is not a valid color", value));
					});
			}

			public double? BirthYear { get; set; }
			public string? Description { get; set; }
			public IEnumerable<KnownColor>? EyeColors { get; set; }
			public IEnumerable<KnownColor>? HairColors { get; set; }
			public int? Height { get; set; }
			public int? HomeworldId { get; set; }
			public double? Mass { get; set; }
			public string? Name { get; set; }
			public string? Sex { get; set; }
			public IEnumerable<KnownColor>? SkinColors { get; set; }
		}
		public new class Default<T> : IStarWarsModel.Default<T>, ICharacter<T> 
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				BirthYear = defaultvalue;
				Description = defaultvalue;
				EyeColors = defaultvalue;
				HairColors = defaultvalue;
				Height = defaultvalue;
				HomeworldId = defaultvalue;
				Mass = defaultvalue;
				Name = defaultvalue;
				Sex = defaultvalue;
				SkinColors = defaultvalue;
			}

			public T BirthYear { get; set; }
			public T Description { get; set; }
			public T EyeColors { get; set; }
			public T HairColors { get; set; }
			public T Height { get; set; }
			public T HomeworldId { get; set; }
			public T Mass { get; set; }
			public T Name { get; set; }
			public T Sex { get; set; }
			public T SkinColors { get; set; }
		}
		public new class DefaultTyped<T> : Default<T>, ICharacterTyped<T>
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
					.AppendFormat("{0}: ", nameof(EyeColors)).AppendJoin(", ", EyeColors ?? Enumerable.Empty<KnownColor>()).AppendLine()
					.AppendFormat("{0}: ", nameof(HairColors)).AppendJoin(", ", HairColors ?? Enumerable.Empty<KnownColor>()).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Height), Height).AppendLine()
					.AppendFormat("{0}: {1}", nameof(HomeworldId), HomeworldId).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Mass), Mass).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Name), Name).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Sex), Sex).AppendLine()
					.AppendFormat("{0}: ", nameof(SkinColors)).AppendJoin(", ", SkinColors ?? Enumerable.Empty<KnownColor>()).AppendLine());
		}
	}
}
