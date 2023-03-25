using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
	public partial interface IWeapon 
	{
		public interface IWeaponClass<T>
		{
			T Class { get; set; }
			T Flags { get; set; }

			public string? ToString()
			{
				return string.Format("{0}: {1}, {2}: {3}",
					nameof(Class), Class,
					nameof(Flags), Flags);
			}
		}
		public partial interface IWeaponClass
		{
			public static class Classes 
			{
				public static IEnumerable<string> AsEnumerable()
				{
					return Enumerable.Empty<string>();
				}
			}
			public static class ClassFlags 
			{
				public static IEnumerable<string> AsEnumerable()
				{
					return Enumerable.Empty<string>();
				}
			}

			string? Class { get; set; }
			IEnumerable<string>? Flags { get; set; }

			public string? ToString()
			{
				return string.Format("{0}: {1}, {2}: {3}",
					nameof(Class), Class,
					nameof(Flags), string.Join(",", Flags ?? Enumerable.Empty<string>()));
			}

			public class Default : IWeaponClass
			{
				public Default() { }
				public Default(JObject jobject)
				{
					Class = jobject.GetValue(nameof(Class), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>() is not string value
						? null
						: Classes.AsEnumerable()
							.FirstOrDefault(@class => string.Equals(@class, value, StringComparison.OrdinalIgnoreCase))
							?? throw new ArgumentException(string.Format("Class '{0}' is invalid.", value));

					Flags = jobject.GetValue(nameof(Flags), StringComparison.OrdinalIgnoreCase)?.ToObject<JArray>()?
						.Values<string?>()
						.Select(value =>
						{
							return ClassFlags.AsEnumerable()
								.FirstOrDefault(classflag => string.Equals(classflag, value, StringComparison.OrdinalIgnoreCase))
								?? throw new ArgumentException(string.Format("Class Flag '{0}' is invalid", value));
						});
				}

				public string? Class { get; set; }
				public IEnumerable<string>? Flags { get; set; }
			}
			public class Default<T> : IWeaponClass<T>
			{
				public Default(T defaultvalue)
				{
					Class = defaultvalue;
					Flags = defaultvalue;
				}

				public T Class { get; set; }
				public T Flags { get; set; }
			}
		}
	}
}
