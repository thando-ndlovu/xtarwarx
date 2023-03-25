using Domain.Models;

using Localisation.Abstractions;
using Localisation.Utils.Films;

using System.Globalization;

using Localisation.Abstractions.Films;

using FilmUtils = Localisation.Utils.Films;

namespace Localisation.Implementation
{
	public class FilmLocalisations : Base.BaseLocalisations, IFilmLocalisations
	{
		public IFilm<string?>? FilmTitles(CultureInfo? cultureInfo = null, IFilm<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(FilmUtils.FilmTitles.ResourceName, localisationcultureinfo)?
				.GetFilmTitles(retriever);
		}
		public IFilm<string?>? FilmDescriptions(CultureInfo? cultureInfo = null, IFilm<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(FilmUtils.FilmDescriptions.ResourceName, localisationcultureinfo)?
				.GetFilmDescriptions(retriever);
		}
		public IFilm.ISortKeys? FilmSortKeysTitles(CultureInfo? cultureInfo = null, IFilm.ISortKeys<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(FilmUtils.FilmSortKeysTitles.ResourceName, localisationcultureinfo)?
				.GetFilmSortKeysTitles(retriever);
		}
		public IFilm.ISortKeys? FilmSortKeysDescriptions(CultureInfo? cultureInfo = null, IFilm.ISortKeys<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(FilmUtils.FilmSortKeysDescriptions.ResourceName, localisationcultureinfo)?
				.GetFilmSortKeysDescriptions(retriever);
		}
		public IFilmSingleLocalisation? FilmSingle(CultureInfo? cultureInfo = null, IFilmSingleLocalisation<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			IFilm<string?>? titles = FilmTitles(cultureInfo, retriever);

			return GetResourceManager(FilmUtils.FilmSingle.ResourceName, localisationcultureinfo)?
				.GetFilmSingle(retriever, titles);
		}
		public IFilmMultipleLocalisation? FilmMultiple(CultureInfo? cultureInfo = null, IFilmMultipleLocalisation<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(FilmUtils.FilmMultiple.ResourceName, localisationcultureinfo)?
				.GetFilmMultiple(retriever);
		}
		public IFilmSearchLocalisation? FilmSearch(CultureInfo? cultureInfo = null, IFilmSearchLocalisationTyped<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(FilmUtils.FilmSearch.ResourceName, localisationcultureinfo)?
				.GetFilmSearch(retriever);
		}
		public IFilm.ISearchContainables<string?>? FilmSearchContainablesTitles(CultureInfo? cultureInfo = null, IFilm.ISearchContainables<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(FilmUtils.FilmSearchContainablesTitles.ResourceName, localisationcultureinfo)?
				.GetFilmSearchContainablesTitles(retriever);
		}
		public IFilm.ISearchContainables<string?>? FilmSearchContainablesDescriptions(CultureInfo? cultureInfo = null, IFilm.ISearchContainables<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(FilmUtils.FilmSearchContainablesDescriptions.ResourceName, localisationcultureinfo)?
				.GetFilmSearchContainablesDescriptions(retriever);
		}
	}
}
