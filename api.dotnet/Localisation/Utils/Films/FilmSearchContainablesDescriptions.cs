using Domain.Models;

namespace Localisation.Utils.Films
{
	public class FilmSearchContainablesDescriptions
	{
		public const string ResourceName = "Films.FilmSearchContainablesDescriptions";

		public static readonly IFilm.ISearchContainables<string> Keys = new IFilm.ISearchContainables.Default<string>(string.Empty)
		{
			CastMembers = "FilmSearchContainablesDescriptions_CastMembers",
			Description = "FilmSearchContainablesDescriptions_Description",
			Director = "FilmSearchContainablesDescriptions_Director",
			OpeningCrawl = "FilmSearchContainablesDescriptions_OpeningCrawl",
			Producers = "FilmSearchContainablesDescriptions_Producers",
			Title = "FilmSearchContainablesDescriptions_Title",
		};
	}

	public static class FilmSearchContainablesDescriptionsExtensions
	{
		public static IFilm.ISearchContainables<string?>? GetFilmSearchContainablesDescriptions(this LocalisationResourceManager? localisationResourceManager, IFilm.ISearchContainables<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IFilm.ISearchContainables.Default<string?>(null)
				{
					CastMembers = retriever?.CastMembers ?? true ? localisationResourceManager.GetString(FilmSearchContainablesDescriptions.Keys.CastMembers) : null,
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(FilmSearchContainablesDescriptions.Keys.Description) : null,
					Director = retriever?.Director ?? true ? localisationResourceManager.GetString(FilmSearchContainablesDescriptions.Keys.Director) : null,
					OpeningCrawl = retriever?.OpeningCrawl ?? true ? localisationResourceManager.GetString(FilmSearchContainablesDescriptions.Keys.OpeningCrawl) : null,
					Producers = retriever?.Producers ?? true ? localisationResourceManager.GetString(FilmSearchContainablesDescriptions.Keys.Producers) : null,
					Title = retriever?.Title ?? true ? localisationResourceManager.GetString(FilmSearchContainablesDescriptions.Keys.Title) : null,
				};
	}
}
