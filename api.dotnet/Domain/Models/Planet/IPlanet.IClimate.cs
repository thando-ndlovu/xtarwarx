using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
	public partial interface IPlanet : IStarWarsModel
	{
		public interface IClimate<T>
		{
			T Type { get; set; }
			T Flags { get; set; }

			public string? ToString()
			{
				return string.Format("{0}: {1}, {2}: {3}",
					nameof(Type), Type,
					nameof(Flags), Flags);
			}
		}
		public partial interface IClimate
		{
			public static class Types 
			{
				public const string Arid = "Arid";
				public const string Artic = "Artic";
				public const string Frigid = "Frigid";
				public const string Frozen = "Frozen";
				public const string Hot = "Hot";
				public const string Humid = "Humid";
				public const string Moist = "Moist";
				public const string Murky = "Murky";
				public const string Polluted = "Polluted";
				public const string Rocky = "Rocky";
				public const string Temperate = "Temperate";
				public const string Tropical = "Tropical";
				public const string Windy = "Windy";

				public static IEnumerable<string> AsEnumerable()
				{
					return Enumerable.Empty<string>()
						.Append(Arid)
						.Append(Artic)
						.Append(Frigid)
						.Append(Frozen)
						.Append(Hot)
						.Append(Humid)
						.Append(Moist)
						.Append(Murky)
						.Append(Polluted)
						.Append(Rocky)
						.Append(Temperate)
						.Append(Tropical)
						.Append(Windy);
				}
			}
			public static class TypeFlags 
			{
				public const string Artificial = "Artificial";
				public const string Sub = "Sub";
				public const string Super = "Super";

				public static IEnumerable<string> AsEnumerable()
				{
					return Enumerable.Empty<string>()
						.Append(Artificial)
						.Append(Sub)
						.Append(Super);
				}
			}

			string? Type { get; set; }
			IEnumerable<string>? Flags { get; set; }

			public class Default : IClimate
			{
				public Default() { }
				public Default(JObject jobject)
				{
					Flags = jobject.GetValue(nameof(Flags), StringComparison.OrdinalIgnoreCase)?.ToObject<JArray>()?
						.Values<string?>()
						.Select(value =>
						{
							return TypeFlags.AsEnumerable()
								.FirstOrDefault(classflag => string.Equals(classflag, value, StringComparison.OrdinalIgnoreCase))
								?? throw new ArgumentException(string.Format("Class Flag '{0}' is invalid", value));
						});

					Type = jobject.GetValue(nameof(Type), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>() is not string value
						? null
						: Types.AsEnumerable()
							.FirstOrDefault(type => string.Equals(type, value, StringComparison.OrdinalIgnoreCase))
							?? throw new ArgumentException(string.Format("Type '{0}' is invalid.", value));
				}

				public string? Type { get; set; }
				public IEnumerable<string>? Flags { get; set; }
			}
			public class Default<T> : IClimate<T>
			{
				public Default(T defaultvalue)
				{
					Type = defaultvalue;
					Flags = defaultvalue;
				}

				public T Type { get; set; }
				public T Flags { get; set; }
			}

			public string? ToString()
			{
				return string.Format("{0}: {1}, {2}: {3}",
					nameof(Type), Type,
					nameof(Flags), string.Join(",", Flags ?? Enumerable.Empty<string>()));
			}
		}
	}
}
