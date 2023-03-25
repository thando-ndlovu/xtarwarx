using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Domain.Models
{
	public interface ISpecie<T> : IStarWarsModel<T>
	{
		T AverageHeight { get; set; }
		T AverageLifespan { get; set; }
		T CharacterIds { get; set; }
		T Classification { get; set; }
		T Description { get; set; }
		T Designation { get; set; }
		T EyeColors { get; set; }
		T HairColors { get; set; }
		T HomeworldId { get; set; }
		T Language { get; set; }
		T Name { get; set; }
		T SkinColors { get; set; }

		public new string ToString(StringBuilder? stringBuilder = null)
		{
			return (this as IStarWarsModel<T>).ToString(
				(stringBuilder ?? new StringBuilder())
					.AppendFormat("{0}: {1}", nameof(AverageHeight), AverageHeight).AppendLine()
					.AppendFormat("{0}: {1}", nameof(AverageLifespan), AverageLifespan).AppendLine()
					.AppendFormat("{0}: {1}", nameof(CharacterIds), CharacterIds).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Classification), Classification).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Description), Description).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Designation), Designation).AppendLine()
					.AppendFormat("{0}: {1}", nameof(EyeColors), EyeColors).AppendLine()
					.AppendFormat("{0}: {1}", nameof(HairColors), HairColors).AppendLine()
					.AppendFormat("{0}: {1}", nameof(HomeworldId), HomeworldId).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Language), Language).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Name), Name).AppendLine()
					.AppendFormat("{0}: {1}", nameof(SkinColors), SkinColors).AppendLine());
		}
	}
	public interface ISpecieTyped<T> : ISpecie<T>, IStarWarsModelTyped<T> { }
	public partial interface ISpecie : IStarWarsModel
	{
		int? AverageHeight { get; set; }
		int? AverageLifespan { get; set; }
		IEnumerable<int>? CharacterIds { get; set; }
		string? Classification { get; set; }
		string? Description { get; set; }
		string? Designation { get; set; }
		IEnumerable<KnownColor>? EyeColors { get; set; }
		IEnumerable<KnownColor>? HairColors { get; set; }
		int? HomeworldId { get; set; }
		string? Language { get; set; }
		string? Name { get; set; }
		IEnumerable<KnownColor>? SkinColors { get; set; }

		public new class Default : IStarWarsModel.Default, ISpecie
		{
			public Default(int id) : base(id) { }
			public Default(int id, JObject jobject) : base(id, jobject)
			{
				AverageHeight = jobject.GetValue(nameof(AverageHeight), StringComparison.OrdinalIgnoreCase)?.ToObject<int?>();
				AverageLifespan = jobject.GetValue(nameof(AverageLifespan), StringComparison.OrdinalIgnoreCase)?.ToObject<int?>();
				CharacterIds = jobject.GetValue(nameof(CharacterIds), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Values<int>();
				Classification = jobject.GetValue(nameof(Classification), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>() is not string classificationvalue
					? null
					: Classifications.AsEnumerable()
						.FirstOrDefault(classification => string.Equals(classification, classificationvalue, StringComparison.OrdinalIgnoreCase))
						?? throw new ArgumentException(string.Format("Classification '{0}' is invalid.", classificationvalue));
				Description = jobject.GetValue(nameof(Description), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>();
				Designation = jobject.GetValue(nameof(Designation), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>() is not string designationvalue
					? null
					: Designations.AsEnumerable()
						.FirstOrDefault(designation => string.Equals(designation, designationvalue, StringComparison.OrdinalIgnoreCase))
						?? throw new ArgumentException(string.Format("Designation '{0}' is invalid.", designationvalue));
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
				HomeworldId = jobject.GetValue(nameof(HomeworldId), StringComparison.OrdinalIgnoreCase)?.ToObject<int?>();
				Language = jobject.GetValue(nameof(Language), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>() is not string languagevalue
					? null
					: Languages.AsEnumerable()
						.FirstOrDefault(language => string.Equals(language, languagevalue, StringComparison.OrdinalIgnoreCase))
						?? throw new ArgumentException(string.Format("Language '{0}' is invalid.", languagevalue));
				Name = jobject.GetValue(nameof(Name), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>();
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

			public int? AverageHeight { get; set; }
			public int? AverageLifespan { get; set; }
			public IEnumerable<int>? CharacterIds { get; set; }
			public string? Classification { get; set; }
			public string? Description { get; set; }
			public string? Designation { get; set; }
			public IEnumerable<KnownColor>? EyeColors { get; set; }
			public IEnumerable<KnownColor>? HairColors { get; set; }
			public int? HomeworldId { get; set; }
			public string? Language { get; set; }
			public string? Name { get; set; }
			public IEnumerable<KnownColor>? SkinColors { get; set; }
		}
		public new class Default<T> : IStarWarsModel.Default<T>, ISpecie<T> 
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				AverageHeight = defaultvalue;
				AverageLifespan = defaultvalue;
				CharacterIds = defaultvalue;
				Classification = defaultvalue;
				Description = defaultvalue;
				Designation = defaultvalue;
				EyeColors = defaultvalue;
				HairColors = defaultvalue;
				HomeworldId = defaultvalue;
				Language = defaultvalue;
				Name = defaultvalue;
				SkinColors = defaultvalue;
			}

			public T AverageHeight { get; set; }
			public T AverageLifespan { get; set; }
			public T CharacterIds { get; set; }
			public T Classification { get; set; }
			public T Description { get; set; }
			public T Designation { get; set; }
			public T EyeColors { get; set; }
			public T HairColors { get; set; }
			public T HomeworldId { get; set; }
			public T Language { get; set; }
			public T Name { get; set; }
			public T SkinColors { get; set; }
		}
		public new class DefaultTyped<T> : Default<T>, ISpecieTyped<T>
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
					.AppendFormat("{0}: {1}", nameof(AverageHeight), AverageHeight).AppendLine()
					.AppendFormat("{0}: {1}", nameof(AverageLifespan), AverageLifespan).AppendLine()
					.AppendFormat("{0}: ", nameof(CharacterIds)).AppendJoin(", ", CharacterIds ?? Enumerable.Empty<int>()).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Classification), Classification).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Description), Description).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Designation), Designation).AppendLine()
					.AppendFormat("{0}: ", nameof(EyeColors)).AppendJoin(", ", EyeColors ?? Enumerable.Empty<KnownColor>()).AppendLine()
					.AppendFormat("{0}: ", nameof(HairColors)).AppendJoin(", ", HairColors ?? Enumerable.Empty<KnownColor>()).AppendLine()
					.AppendFormat("{0}: {1}", nameof(HomeworldId), HomeworldId).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Language), Language).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Name), Name).AppendLine()
					.AppendFormat("{0}: ", nameof(SkinColors)).AppendJoin(", ", SkinColors ?? Enumerable.Empty<KnownColor>()).AppendLine());
		}
	}
}
