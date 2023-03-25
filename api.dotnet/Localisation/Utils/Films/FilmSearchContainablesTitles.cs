using Domain.Models;

namespace Localisation.Utils.Films
{
	public class FilmSearchContainablesTitles
	{
		public const string ResourceName = "Films.FilmSearchContainablesTitles";

		public static readonly IFilm.ISearchContainables<string> Keys = new IFilm.ISearchContainables.Default<string>(string.Empty)
		{
			CastMembers = "FilmSearchContainablesTitles_CastMembers",
			Description = "FilmSearchContainablesTitles_Description",
			Director = "FilmSearchContainablesTitles_Director",
			OpeningCrawl = "FilmSearchContainablesTitles_OpeningCrawl",
			Producers = "FilmSearchContainablesTitles_Producers",
			Title = "FilmSearchContainablesTitles_Title",
		};
	}

	public static class FilmSearchContainablesTitlesExtensions
	{
		public static IFilm.ISearchContainables<string?>? GetFilmSearchContainablesTitles(this LocalisationResourceManager? localisationResourceManager, IFilm.ISearchContainables<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IFilm.ISearchContainables.Default<string?>(null)
				{
					CastMembers = retriever?.CastMembers ?? true ? localisationResourceManager.GetString(FilmSearchContainablesTitles.Keys.CastMembers) : null,
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(FilmSearchContainablesTitles.Keys.Description) : null,
					Director = retriever?.Director ?? true ? localisationResourceManager.GetString(FilmSearchContainablesTitles.Keys.Director) : null,
					OpeningCrawl = retriever?.OpeningCrawl ?? true ? localisationResourceManager.GetString(FilmSearchContainablesTitles.Keys.OpeningCrawl) : null,
					Producers = retriever?.Producers ?? true ? localisationResourceManager.GetString(FilmSearchContainablesTitles.Keys.Producers) : null,
					Title = retriever?.Title ?? true ? localisationResourceManager.GetString(FilmSearchContainablesTitles.Keys.Title) : null,
				};
	}
}
