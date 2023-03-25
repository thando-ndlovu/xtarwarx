using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
	public partial interface IPlanet 
	{
		public interface ITerrain<T>
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
		public partial interface ITerrain
		{
			public static class Types 
			{
				public const string Arches = "Arches";
				public const string Ash = "Ash";
				public const string Asteroid = "Asteroid";
				public const string Barren = "Barren";
				public const string Bogs = "Bogs";
				public const string Canyons = "Canyons";
				public const string Caves = "Caves";
				public const string Cityscapes = "Cityscapes";
				public const string Cliffs = "Cliffs";
				public const string Clouds = "Clouds";
				public const string Cloudsea = "Cloudsea";
				public const string Deserts = "Deserts";
				public const string Fields = "Fields";
				public const string Forests = "Forests";
				public const string Frozen = "Frozen";
				public const string Fungus = "Fungus";
				public const string Glaciers = "Glaciers";
				public const string Grasslands = "Grasslands";
				public const string Hills = "Hills";
				public const string Ice = "Ice";
				public const string Islands = "Islands";
				public const string Jungles = "Jungles";
				public const string Lakes = "Lakes";
				public const string Mesas = "Mesas";
				public const string Mountains = "Mountains";
				public const string Oceans = "Oceans";
				public const string Plains = "Plains";
				public const string Plateaus = "Plateaus";
				public const string Pools = "Pools";
				public const string Rainforests = "Rainforests";
				public const string Reefs = "Reefs";
				public const string Rivers = "Rivers";
				public const string Rocky = "Rocky";
				public const string Savannas = "Savannas";
				public const string SaltPans = "SaltPans";
				public const string Scrublands = "Scrublands";
				public const string Seas = "Seas";
				public const string Sinkholes = "Sinkholes";
				public const string Swamps = "Swamps";
				public const string Tundra = "Tundra";
				public const string Urban = "Urban";
				public const string Valleys = "Valleys";
				public const string Verdant = "Verdant";
				public const string Vines = "Vines";
				public const string Volcanoes = "Volcanoes";

				public static IEnumerable<string> AsEnumerable()
				{
					return Enumerable.Empty<string>()
						.Append(Arches)
						.Append(Ash)
						.Append(Asteroid)
						.Append(Barren)
						.Append(Bogs)
						.Append(Canyons)
						.Append(Caves)
						.Append(Cityscapes)
						.Append(Cliffs)
						.Append(Clouds)
						.Append(Cloudsea)
						.Append(Deserts)
						.Append(Fields)
						.Append(Forests)
						.Append(Frozen)
						.Append(Fungus)
						.Append(Glaciers)
						.Append(Grasslands)
						.Append(Hills)
						.Append(Ice)
						.Append(Islands)
						.Append(Jungles)
						.Append(Lakes)
						.Append(Mesas)
						.Append(Mountains)
						.Append(Oceans)
						.Append(Plains)
						.Append(Plateaus)
						.Append(Pools)
						.Append(Rainforests)
						.Append(Reefs)
						.Append(Rivers)
						.Append(Rocky)
						.Append(Savannas)
						.Append(SaltPans)
						.Append(Scrublands)
						.Append(Seas)
						.Append(Sinkholes)
						.Append(Swamps)
						.Append(Tundra)
						.Append(Urban)
						.Append(Valleys)
						.Append(Verdant)
						.Append(Vines)
						.Append(Volcanoes);
				}
			}
			public static class TypeFlags 
			{
				public const string Acidic = "Acidic";
				public const string Airless = "Airless";
				public const string Barren = "Barren";
				public const string Boggy = "Boggy";
				public const string Gaseous = "Gaseous";
				public const string Grassy = "Grassy";
				public const string Icy = "Icy";
				public const string Molten = "Molten";
				public const string Rocky = "Rocky";
				public const string Toxic = "Toxic";
				public const string Tropical = "Tropical";

				public static IEnumerable<string> AsEnumerable()
				{
					return Enumerable.Empty<string>()
						.Append(Acidic)
						.Append(Airless)
						.Append(Barren)
						.Append(Boggy)
						.Append(Gaseous)
						.Append(Grassy)
						.Append(Icy)
						.Append(Molten)
						.Append(Rocky)
						.Append(Toxic)
						.Append(Tropical);
				}
			}

			string? Type { get; set; }
			IEnumerable<string>? Flags { get; set; }

			public class Default : ITerrain
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
			public class Default<T> : ITerrain<T>
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
