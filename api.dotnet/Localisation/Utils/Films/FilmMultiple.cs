using Localisation.Abstractions.Films;

namespace Localisation.Utils.Films
{
	public class FilmMultiple 
	{
		public const string ResourceName = "Films.FilmMultiple";

		public static readonly IFilmMultipleLocalisation<string> Keys = new IFilmMultipleLocalisation.Default<string>(string.Empty)
		{
			FilmsEmptyText = "FilmMultiple_FilmsEmptyText",
			FilmsTitle = "FilmMultiple_FilmsTitle",
			FilmsSearchbarPlaceholder = "FilmMultiple_FilmsSearchbarPlaceholder",
		};
	}

	public static class FilmMultipleExtensions
	{
		public static IFilmMultipleLocalisation? GetFilmMultiple(this LocalisationResourceManager? localisationResourceManager, IFilmMultipleLocalisation<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IFilmMultipleLocalisation.Default
				{
					FilmsEmptyText = retriever?.FilmsEmptyText ?? true ? localisationResourceManager.GetString(FilmMultiple.Keys.FilmsEmptyText) : null,
					FilmsTitle = retriever?.FilmsTitle ?? true ? localisationResourceManager.GetString(FilmMultiple.Keys.FilmsTitle) : null,
					FilmsSearchbarPlaceholder = retriever?.FilmsSearchbarPlaceholder ?? true ? localisationResourceManager.GetString(FilmMultiple.Keys.FilmsSearchbarPlaceholder) : null,
				};
	}
}
