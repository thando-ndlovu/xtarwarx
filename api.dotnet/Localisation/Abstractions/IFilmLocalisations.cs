using Domain.Models;

using Localisation.Abstractions.Films;

using System;
using System.Globalization;

namespace Localisation.Abstractions
{
	public interface IFilmLocalisations : IDisposable
	{
		IFilm<string?>? FilmTitles(CultureInfo? cultureInfo = null, IFilm<bool>? retriever = null);
		IFilm<string?>? FilmDescriptions(CultureInfo? cultureInfo = null, IFilm<bool>? retriever = null);
		IFilm.ISortKeys? FilmSortKeysTitles(CultureInfo? cultureInfo = null, IFilm.ISortKeys<bool>? retriever = null);
		IFilm.ISortKeys? FilmSortKeysDescriptions(CultureInfo? cultureInfo = null, IFilm.ISortKeys<bool>? retriever = null);
		IFilmSingleLocalisation? FilmSingle(CultureInfo? cultureInfo = null, IFilmSingleLocalisation<bool>? retriever = null);
		IFilmMultipleLocalisation? FilmMultiple(CultureInfo? cultureInfo = null, IFilmMultipleLocalisation<bool>? retriever = null);
		IFilmSearchLocalisation? FilmSearch(CultureInfo? cultureInfo = null, IFilmSearchLocalisationTyped<bool>? retriever = null);
		IFilm.ISearchContainables<string?>? FilmSearchContainablesTitles(CultureInfo? cultureInfo = null, IFilm.ISearchContainables<bool>? retriever = null);
		IFilm.ISearchContainables<string?>? FilmSearchContainablesDescriptions(CultureInfo? cultureInfo = null, IFilm.ISearchContainables<bool>? retriever = null);
	}
}
