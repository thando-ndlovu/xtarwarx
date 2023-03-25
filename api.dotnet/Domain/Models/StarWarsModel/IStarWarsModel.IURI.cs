using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
	public partial interface IStarWarsModel 
	{
		public interface IURI<T>
		{
			T Key { get; set; }
			T Uri { get; set; }

			public string? ToString()
			{
				return string.Format("{0}: {1}, {2}: {3}",
					nameof(Key), Key,
					nameof(Uri), Uri);
			}
		}
		public partial interface IURI 
		{
			public static class Keys
			{
				public const string AdditionalImage = "AdditionalImage";
				public const string AdditionalPoster = "AdditionalPoster";
				public const string Fandom = "Fandom";
				public const string IGN = "IGN";
				public const string IMDB = "IMDB";
				public const string Insignia = "Insignia";
				public const string MainImage = "MainImage";
				public const string MainPoster = "MainPoster";
				public const string RottenTomatoes = "RottenTomatoes";
				public const string ThumbnailSmall = "ThumbnailSmall";
				public const string ThumbnailMedium = "ThumbnailMedium";
				public const string ThumbnailLarge = "ThumbnailLarge";
				public const string Wikipedia = "Wikipedia";

				public static IEnumerable<string> AsEnumerable()
				{
					return Enumerable.Empty<string>()
						.Append(AdditionalImage)
						.Append(AdditionalPoster)
						.Append(Fandom)
						.Append(IGN)
						.Append(IMDB)
						.Append(Insignia)
						.Append(MainImage)
						.Append(MainPoster)
						.Append(RottenTomatoes)
						.Append(ThumbnailSmall)
						.Append(ThumbnailMedium)
						.Append(ThumbnailLarge)
						.Append(Wikipedia);
				}
				public static IEnumerable<string> AsEnumerableExternalLinks()
				{
					return Enumerable.Empty<string>()
						.Append(Fandom)
						.Append(IGN)
						.Append(IMDB)
						.Append(RottenTomatoes)
						.Append(Wikipedia);
				}		   
				public static IEnumerable<string> AsEnumerableImages()
				{
					return Enumerable.Empty<string>()
						.Append(AdditionalImage)
						.Append(AdditionalPoster)
						.Append(Insignia)
						.Append(MainImage)
						.Append(MainPoster)
						.Append(ThumbnailSmall)
						.Append(ThumbnailMedium)
						.Append(ThumbnailLarge);
				}
			}

			string? Key { get; set; }
			Uri? Uri { get; set; }

			public class Default : IURI
			{
				public Default() { }
				public Default(JObject jobject) 
				{
					Key = jobject.GetValue(nameof(Key), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>() is not string value
						? null
						: Keys.AsEnumerable()
							.FirstOrDefault(type => string.Equals(type, value, StringComparison.OrdinalIgnoreCase))
							?? throw new ArgumentException(string.Format("Key '{0}' is invalid.", value));

					Uri = jobject.GetValue(nameof(Uri), StringComparison.OrdinalIgnoreCase)?.ToObject<string?>() is string uri 
						? new Uri(uri) 
						: null;
				}

				public string? Key { get; set; }
				public Uri? Uri { get; set; }
			}
			public class Default<T> : IURI<T>
			{
				public Default(T defaultvalue)
				{
					Key = defaultvalue;
					Uri = defaultvalue;
				}

				public T Key { get; set; }
				public T Uri { get; set; }
			}

			public string? ToString()
			{
				return string.Format("{0}: {1}, {2}: {3}",
					nameof(Key), Key,
					nameof(Uri), Uri);
			}
		}
	}
}
