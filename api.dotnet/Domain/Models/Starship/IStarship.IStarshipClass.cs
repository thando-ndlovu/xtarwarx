using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
	public partial interface IStarship 
	{
		public interface IStarshipClass<T>
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
		public partial interface IStarshipClass
		{
			public static class Classes
			{
				public const string Barge = "Barge";
				public const string Battlestation = "Battlestation";
				public const string Corvette = "Corvette";
				public const string Craft = "Craft";
				public const string Cruiser = "Cruiser";
				public const string Destroyer = "Destroyer";
				public const string Dreadnought = "Dreadnought";
				public const string Fighter = "Fighter";
				public const string Freighter = "Freighter";
				public const string Ship = "Ship";
				public const string Transporter = "Transporter";
				public const string Yacht = "Yacht";

				public static IEnumerable<string> AsEnumerable()
				{
					return Enumerable.Empty<string>()
						.Append(Barge)
						.Append(Battlestation)
						.Append(Corvette)
						.Append(Craft)
						.Append(Cruiser)
						.Append(Destroyer)
						.Append(Dreadnought)
						.Append(Fighter)
						.Append(Freighter)
						.Append(Ship)
						.Append(Transporter)
						.Append(Yacht);
				}  
			}
			public static class ClassFlags
			{
				public const string Armed = "Armed";
				public const string Assault = "Assault";
				public const string Capital = "Capital";
				public const string DeepSpace = "DeepSpace";
				public const string Diplomatic = "Diplomatic";
				public const string DroidControl = "DroidControl";
				public const string Escort = "Escort";
				public const string Landing = "Landing";
				public const string Light = "Light";
				public const string Mobile = "Mobile";
				public const string Patrol = "Patrol";
				public const string Planetary = "Planetary";
				public const string Star = "Star";
				public const string Space = "Space";

				public static IEnumerable<string> AsEnumerable()
				{
					return Enumerable.Empty<string>()
						.Append(Armed)
						.Append(Assault)
						.Append(Capital)
						.Append(DeepSpace)
						.Append(Diplomatic)
						.Append(DroidControl)
						.Append(Escort)
						.Append(Landing)
						.Append(Light)
						.Append(Mobile)
						.Append(Patrol)
						.Append(Planetary)
						.Append(Star)
						.Append(Space);
				}
			}

			string? Class { get; set; }
			IEnumerable<string>? Flags { get; set; }

			public class Default : IStarshipClass
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
			public class Default<T> : IStarshipClass<T>
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
