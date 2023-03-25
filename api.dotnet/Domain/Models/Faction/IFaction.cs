using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Models
{
	public interface IFaction<T> : IStarWarsModel<T>
	{
		T AlliedCharacterIds { get; set; }
		T AlliedFactionIds { get; set; }
		T Description { get; set; }
		T LeaderIds { get; set; }
		T MemberCharacterIds { get; set; }
		T MemberFactionIds { get; set; }
		T Name { get; set; }
		T OrganizationTypes { get; set; }

		public new string ToString(StringBuilder? stringBuilder = null)
		{
			return (this as IStarWarsModel<T>).ToString(
				(stringBuilder ?? new StringBuilder())
					.AppendFormat("{0}: {1}", nameof(AlliedCharacterIds), AlliedCharacterIds).AppendLine()
					.AppendFormat("{0}: {1}", nameof(AlliedFactionIds), AlliedFactionIds).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Description), Description).AppendLine()
					.AppendFormat("{0}: {1}", nameof(LeaderIds), LeaderIds).AppendLine()
					.AppendFormat("{0}: {1}", nameof(MemberCharacterIds), MemberCharacterIds).AppendLine()
					.AppendFormat("{0}: {1}", nameof(MemberFactionIds), MemberFactionIds).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Name), Name).AppendLine()
					.AppendFormat("{0}: {1}", nameof(OrganizationTypes), OrganizationTypes).AppendLine());
		}
	}
	public interface IFactionTyped<T> : IFaction<T>, IStarWarsModelTyped<T> { }
	public partial interface IFaction : IStarWarsModel
	{
		IEnumerable<int>? AlliedCharacterIds { get; set; }
		IEnumerable<int>? AlliedFactionIds { get; set; }
		string? Description { get; set; }
		IEnumerable<int>? LeaderIds { get; set; }
		IEnumerable<int>? MemberCharacterIds { get; set; }
		IEnumerable<int>? MemberFactionIds { get; set; }
		string? Name { get; set; }
		IEnumerable<string>? OrganizationTypes { get; set; }

		public new class Default : IStarWarsModel.Default, IFaction
		{
			public Default(int id) : base(id) { }
			public Default(int id, JObject jobject) : base(id, jobject)
			{
				AlliedCharacterIds = jobject.GetValue(nameof(AlliedCharacterIds), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Values<int>();
				AlliedFactionIds = jobject.GetValue(nameof(AlliedFactionIds), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Values<int>();
				Description = jobject.GetValue(nameof(Description), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>();
				LeaderIds = jobject.GetValue(nameof(LeaderIds), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Values<int>();
				MemberCharacterIds = jobject.GetValue(nameof(MemberCharacterIds), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Values<int>();
				MemberFactionIds = jobject.GetValue(nameof(MemberFactionIds), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Values<int>();
				Name = jobject.GetValue(nameof(Name), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>();
				OrganizationTypes = jobject.GetValue(nameof(OrganizationTypes), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Values<string>()
					.Select(value =>
					{
						return OrganizationTypeTypes.AsEnumerable()
							.FirstOrDefault(organizationtype => string.Equals(organizationtype, value, StringComparison.OrdinalIgnoreCase))
							?? throw new ArgumentException(string.Format("Organization Type '{0}' is invalid", value));
					});
			}

			public IEnumerable<int>? AlliedCharacterIds { get; set; }
			public IEnumerable<int>? AlliedFactionIds { get; set; }
			public string? Description { get; set; }
			public IEnumerable<int>? LeaderIds { get; set; }
			public IEnumerable<int>? MemberCharacterIds { get; set; }
			public IEnumerable<int>? MemberFactionIds { get; set; }
			public string? Name { get; set; }
			public IEnumerable<string>? OrganizationTypes { get; set; }
		}
		public new class Default<T> : IStarWarsModel.Default<T>, IFaction<T> 
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				AlliedCharacterIds = defaultvalue;
				AlliedFactionIds = defaultvalue;
				Description = defaultvalue;
				LeaderIds = defaultvalue;
				MemberCharacterIds = defaultvalue;
				MemberFactionIds = defaultvalue;
				Name = defaultvalue;
				OrganizationTypes = defaultvalue;
			}

			public T AlliedCharacterIds { get; set; }
			public T AlliedFactionIds { get; set; }
			public T Description { get; set; }
			public T LeaderIds { get; set; }
			public T MemberCharacterIds { get; set; }
			public T MemberFactionIds { get; set; }
			public T Name { get; set; }
			public T OrganizationTypes { get; set; }
		}
		public new class DefaultTyped<T> : Default<T>, IStarWarsModelTyped<T>
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
					.AppendFormat("{0}: ", nameof(AlliedCharacterIds)).AppendJoin(", ", AlliedCharacterIds ?? Enumerable.Empty<int>()).AppendLine()
					.AppendFormat("{0}: ", nameof(AlliedFactionIds)).AppendJoin(", ", AlliedFactionIds ?? Enumerable.Empty<int>()).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Description), Description).AppendLine()
					.AppendFormat("{0}: ", nameof(LeaderIds)).AppendJoin(", ", LeaderIds ?? Enumerable.Empty<int>()).AppendLine()
					.AppendFormat("{0}: ", nameof(MemberCharacterIds)).AppendJoin(", ", MemberCharacterIds ?? Enumerable.Empty<int>()).AppendLine()
					.AppendFormat("{0}: ", nameof(MemberFactionIds)).AppendJoin(", ", MemberFactionIds ?? Enumerable.Empty<int>()).AppendLine()
					.AppendFormat("{0}: {1}", nameof(Name), Name).AppendLine()
					.AppendFormat("{0}: ", nameof(OrganizationTypes)).AppendJoin(", ", OrganizationTypes ?? Enumerable.Empty<string>()).AppendLine());
		}
	}
}
