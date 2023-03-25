using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
	public partial interface IVehicle 
	{
		public interface IVehicleClass<T>
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
		public partial interface IVehicleClass
		{
			public static class Classes
			{
				public const string Barge = "Barge";
				public const string Bomber = "Bomber";
				public const string Craft = "Craft";
				public const string Fighter = "Fighter";
				public const string Gunship = "Gunship";
				public const string Ship = "Ship";
				public const string Speeder = "Speeder";
				public const string Submarine = "Submarine";
				public const string Tank = "Tank";
				public const string Transporter = "Transporter";
				public const string Walker = "Walker";

				public static IEnumerable<string> AsEnumerable()
				{
					return Enumerable.Empty<string>()
						.Append(Barge)
						.Append(Bomber)
						.Append(Craft)
						.Append(Fighter)
						.Append(Gunship)
						.Append(Ship)
						.Append(Speeder)
						.Append(Submarine)
						.Append(Tank)
						.Append(Transporter)
						.Append(Walker);
				}
			}
			public static class ClassFlags
			{
				public const string Air = "Air";
				public const string Assault = "Assault";
				public const string CargoSkiff = "CargoSkiff";
				public const string Droid = "Droid";
				public const string FireSuppression = "FireSuppression";
				public const string Landing = "Landing";
				public const string Planetary = "Planetary";
				public const string Repulsor = "Repulsor";
				public const string Sail = "Sail";
				public const string Star = "Star";
				public const string Wheeled = "Wheeled";

				public static IEnumerable<string> AsEnumerable()
				{
					return Enumerable.Empty<string>()
						.Append(Air)
						.Append(Assault)
						.Append(CargoSkiff)
						.Append(Droid)
						.Append(FireSuppression)
						.Append(Landing)
						.Append(Planetary)
						.Append(Repulsor)
						.Append(Sail)
						.Append(Star)
						.Append(Wheeled);
				}
			}

			string? Class { get; set; }
			IEnumerable<string>? Flags { get; set; }

			public class Default : IVehicleClass
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
			public class Default<T> : IVehicleClass<T>
			{
				public Default(T defaultvalue)
				{
					Class = defaultvalue;
					Flags = defaultvalue;
				}

				public T Class { get; set; }
				public T Flags { get; set; }
			}

			public string? ToString()
			{
				return string.Format("{0}: {1}, {2}: {3}",
					nameof(Class), Class,
					nameof(Flags), string.Join(",", Flags ?? Enumerable.Empty<string>()));
			}
		}
	}
}
