using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Models
{
	public interface IStarWarsModel<T>
	{
		T Id { get; set; }
		T Uris { get; set; }
		T Created { get; set; }
		T Edited { get; set; }

		public string ToString(StringBuilder? stringBuilder = null)
		{
			return (stringBuilder ?? new StringBuilder())
				.AppendFormat("{0}: {1}", nameof(Created), Created).AppendLine()
				.AppendFormat("{0}: {1}", nameof(Edited), Edited).AppendLine()
				.AppendFormat("{0}: {1}", nameof(Id), Id).AppendLine()
				.AppendFormat("{0}: {1}", nameof(Uris), Uris).AppendLine()
				.ToString();
		}
	}
	public interface IStarWarsModelTyped<T> : IStarWarsModel<T>
	{
		new IStarWarsModel.IURI<T>? Uris { get; set; }
	}
	public partial interface IStarWarsModel 
	{
		int Id { get; }
		IEnumerable<IURI>? Uris { get; set; }

		DateTime? Created { get; set; }
		DateTime? Edited { get; set; }

		public string ToString(StringBuilder? stringBuilder = null)
		{
			return (stringBuilder ?? new StringBuilder())
				.AppendFormat("{0}: {1}", nameof(Created), Created).AppendLine()
				.AppendFormat("{0}: {1}", nameof(Edited), Edited).AppendLine()
				.AppendFormat("{0}: {1}", nameof(Id), Id).AppendLine()
				.AppendFormat("{0}: ", nameof(Uris)).AppendJoin(", ", Uris?.Select(_ => _.ToString()) ?? Enumerable.Empty<string>()).AppendLine()
				.ToString();
		}

		public class Default : IStarWarsModel
		{
			public Default(int id)
			{
				Id = id;
			}
			public Default(int id, JObject jobject) 
			{
				Id = id;

				Created = jobject.GetValue(nameof(Created), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>() is string created && DateTime.TryParse(created, out DateTime outcreated)
					? outcreated
					: new DateTime?();
				Edited = jobject.GetValue(nameof(Edited), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>() is string edited && DateTime.TryParse(edited, out DateTime outedited)
					? outedited
					: new DateTime?();

				Uris = jobject.GetValue(nameof(Uris), StringComparison.OrdinalIgnoreCase)?
					.ToObject<JArray?>()?
					.Select(UriJObject => new IURI.Default(JObject.FromObject(UriJObject)));
			}

			public int Id { get; }
			public DateTime? Created { get; set; }
			public DateTime? Edited { get; set; }
			public IEnumerable<IURI>? Uris { get; set; }
		}
		public class Default<T> : IStarWarsModel<T> 
		{
			public Default(T defaultvalue) 
			{
				Id = defaultvalue;
				Uris = defaultvalue;
				Created = defaultvalue;
				Edited = defaultvalue;
			}

			public T Id { get; set; }
			public T Uris { get; set; }
			public T Created { get; set; }
			public T Edited { get; set; }
		}
		public class DefaultTyped<T> : Default<T>, IStarWarsModelTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue) { }

			public new IURI<T>? Uris { get; set; }
		}
	}
}
