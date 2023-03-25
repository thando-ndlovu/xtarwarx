using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
	public partial interface ITransporter 
	{
		public interface IConsumable<T>
		{
			T TimeUnit { get; set; }
			T Value { get; set; }

			public string? ToString()
			{
				return string.Format("{0}: {1}, {2}: {3}",
					nameof(TimeUnit), TimeUnit,
					nameof(Value), Value);
			}
		}
		public partial interface IConsumable
		{															   
			public static class TimeUnits
			{
				public const string Hour = "Hour";
				public const string Day = "Day";
				public const string Week = "Week";
				public const string Month = "Month";
				public const string Year = "Year";

				public static IEnumerable<string> AsEnumerable()
				{
					return Enumerable.Empty<string>()
						.Append(Hour)
						.Append(Day)
						.Append(Week)
						.Append(Month)
						.Append(Year);
				}
			}

			string? TimeUnit { get; set; }
			int? Value { get; set; }

			public class Default : IConsumable
			{
				public Default() { }
				public Default(JObject jobject)
				{
					TimeUnit = jobject.GetValue(nameof(TimeUnit), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>() is not string value
						? null
						: TimeUnits.AsEnumerable()
							.FirstOrDefault(timeunit => string.Equals(timeunit, value, StringComparison.OrdinalIgnoreCase))
							?? throw new ArgumentException(string.Format("TimeUnit '{0}' is invalid.", value));

					Value = jobject.GetValue(nameof(Value), StringComparison.OrdinalIgnoreCase)?.ToObject<int?>();
				}

				public string? TimeUnit { get; set; }
				public int? Value { get; set; }
			}
			public class Default<T> : IConsumable<T>
			{
				public Default(T defaultvalue)
				{
					TimeUnit = defaultvalue;
					Value = defaultvalue;
				}

				public T TimeUnit { get; set; }
				public T Value { get; set; }
			}

			public string? ToString()
			{
				return string.Format("{0}: {1}, {2}: {3}",
					nameof(TimeUnit), TimeUnit,
					nameof(Value), Value);
			}
		}
	}
}
