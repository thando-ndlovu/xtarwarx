using System;
using System.Text;

namespace Domain.Models
{
	public partial interface IFilm 
	{
		public new interface ISearchContainables<T> : IStarWarsModel.ISearchContainables<T>
		{
			T CastMembers { get; set; }
			T Description { get; set; }
			T Director { get; set; }
			T OpeningCrawl { get; set; }
			T Producers { get; set; }
			T Title { get; set; }

			public new string? ToString()
			{
				return new StringBuilder()
					.Append(this)
					.ToString();
			}
		}
		public new interface ISearchContainables : ISearchContainables<bool>, IStarWarsModel.ISearchContainables
		{
			public new class Default : Default<bool>, ISearchContainables
			{
				public Default() : base(false) { }
			}
			public new class Default<T> : IStarWarsModel.ISearchContainables.Default<T>, ISearchContainables<T>
			{
				public Default(T defaultvalue) : base(defaultvalue)
				{
					CastMembers = defaultvalue;
					Description = defaultvalue;
					Director = defaultvalue;
					OpeningCrawl = defaultvalue;
					Producers = defaultvalue;
					Title = defaultvalue;
				}

				public T CastMembers { get; set; }
				public T Description { get; set; }
				public T Director { get; set; }
				public T OpeningCrawl { get; set; }
				public T Producers { get; set; }
				public T Title { get; set; }
			}

			public bool ShouldReturnFilm(IFilm film, string? searchString)
			{
				if (CastMembers && CastMembersContainsSearchString(film, searchString, out int _)) return true;
				if (Description && DescriptionContainsSearchString(film, searchString, out int _)) return true;
				if (Director && DirectorContainsSearchString(film, searchString, out int _)) return true;
				if (OpeningCrawl && OpeningCrawlContainsSearchString(film, searchString, out int _)) return true;
				if (Producers && ProducersContainsSearchString(film, searchString, out int _)) return true;
				if (Title && TitleContainsSearchString(film, searchString, out int _)) return true;

				return false;
			}
			public bool ShouldReturnFilm(IFilm film, string? searchString, out int matchCount)
			{
				matchCount = 0;

				bool shouldreturn = false;

				if (CastMembers && CastMembersContainsSearchString(film, searchString, out int castMembersMatchCount))
				{
					matchCount += castMembersMatchCount;

					shouldreturn = true;
				}
				if (Description && DescriptionContainsSearchString(film, searchString, out int descriptionMatchCount))
				{
					matchCount += descriptionMatchCount;

					shouldreturn = true;
				}
				if (Director && DirectorContainsSearchString(film, searchString, out int directorMatchCount))
				{
					matchCount += directorMatchCount;

					shouldreturn = true;
				}
				if (OpeningCrawl && OpeningCrawlContainsSearchString(film, searchString, out int openingCrawlMatchCount))
				{
					matchCount += openingCrawlMatchCount;

					shouldreturn = true;
				}
				if (Producers && ProducersContainsSearchString(film, searchString, out int producersMatchCount))
				{
					matchCount += producersMatchCount;

					shouldreturn = true;
				}
				if (Title && TitleContainsSearchString(film, searchString, out int titleMatchCount))
				{
					matchCount += titleMatchCount;

					shouldreturn = true;
				}

				return shouldreturn;
			}

			private bool CastMembersContainsSearchString(IFilm film, string? searchString, out int matchCount)
			{
				matchCount = 0;

				if (string.IsNullOrWhiteSpace(searchString))
					return true;

				if (film.CastMembers == null) return false;

				foreach (string castmember in film.CastMembers)
					if (castmember.ToLower().Contains(searchString.ToLower(), StringComparison.OrdinalIgnoreCase))
						matchCount++;

				return matchCount > 0;
			}
			private bool DescriptionContainsSearchString(IFilm film, string? searchString, out int matchCount)
			{
				matchCount = 0;

				if (string.IsNullOrWhiteSpace(searchString))
					return true;

				if (string.IsNullOrWhiteSpace(film.Description)) return false;

				if (film.Description.ToLower().Contains(searchString.ToLower(), StringComparison.OrdinalIgnoreCase))
					matchCount++;

				return matchCount > 0;
			}
			private bool DirectorContainsSearchString(IFilm film, string? searchString, out int matchCount)
			{
				matchCount = 0;

				if (string.IsNullOrWhiteSpace(searchString))
					return true;

				if (string.IsNullOrWhiteSpace(film.Director)) return false;

				if (film.Director.ToLower().Contains(searchString.ToLower(), StringComparison.OrdinalIgnoreCase))
					matchCount++;

				return matchCount > 0;
			}
			private bool OpeningCrawlContainsSearchString(IFilm film, string? searchString, out int matchCount)
			{
				matchCount = 0;

				if (string.IsNullOrWhiteSpace(searchString))
					return true;

				if (string.IsNullOrWhiteSpace(film.OpeningCrawl)) return false;

				if (film.OpeningCrawl.ToLower().Contains(searchString.ToLower(), StringComparison.OrdinalIgnoreCase))
					matchCount++;

				return matchCount > 0;
			}
			private bool ProducersContainsSearchString(IFilm film, string? searchString, out int matchCount)
			{
				matchCount = 0;

				if (string.IsNullOrWhiteSpace(searchString))
					return true;

				if (film.Producers == null) return false;

				foreach (string producer in film.Producers)
					if (producer.ToLower().Contains(searchString.ToLower(), StringComparison.OrdinalIgnoreCase))
						matchCount++;

				return matchCount > 0;
			}
			private bool TitleContainsSearchString(IFilm film, string? searchString, out int matchCount)
			{
				matchCount = 0;

				if (string.IsNullOrWhiteSpace(searchString))
					return true;

				if (string.IsNullOrWhiteSpace(film.Title)) return false;

				if (film.Title.ToLower().Contains(searchString.ToLower(), StringComparison.OrdinalIgnoreCase))
					matchCount++;

				return matchCount > 0;
			}
		}
	}

	public static class IFilmExtensions
	{
		public static StringBuilder Append<T>(this StringBuilder stringbuilder, IFilm.ISearchContainables<T>? searchcontainables)
		{
			if (searchcontainables is null)
				return stringbuilder;

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(IFilm.ISearchContainables<T>.CastMembers), searchcontainables.CastMembers).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IFilm.ISearchContainables<T>.Description), searchcontainables.Description).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IFilm.ISearchContainables<T>.Director), searchcontainables.Director).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IFilm.ISearchContainables<T>.OpeningCrawl), searchcontainables.OpeningCrawl).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IFilm.ISearchContainables<T>.Producers), searchcontainables.Producers).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IFilm.ISearchContainables<T>.Title), searchcontainables.Title).AppendLine();

			return stringbuilder.Append<T>(searchcontainables as IStarWarsModel.ISearchContainables<T>);
		}
	}
}
