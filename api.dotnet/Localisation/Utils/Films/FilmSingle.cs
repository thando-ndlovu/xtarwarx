using Domain.Models;

using Localisation.Abstractions.Films;

namespace Localisation.Utils.Films
{
	public class FilmSingle 
	{
		public const string ResourceName = "Films.FilmSingle";

		public static readonly IFilmSingleLocalisation<string> Keys = new IFilmSingleLocalisation.Default<string>(string.Empty)
		{
			CharactersTitle = "FilmSingle_CharactersTitle",
			CharactersEmptyText = "FilmSingle_CharactersEmptyText",
			FactionsTitle = "FilmSingle_FactionsTitle",
			FactionsEmptyText = "FilmSingle_FactionsEmptyText",
			ImagesTitle = "FilmSingle_ImagesTitle",
			ImagesEmptyText = "FilmSingle_ImagesEmptyText",
			ManufacturersTitle = "FilmSingle_ManufacturersTitle",
			ManufacturersEmptyText = "FilmSingle_ManufacturersEmptyText",
			PlanetsTitle = "FilmSingle_PlanetsTitle",
			PlanetsEmptyText = "FilmSingle_PlanetsEmptyText",
			SpeciesTitle = "FilmSingle_SpeciesTitle",
			SpeciesEmptyText = "FilmSingle_SpeciesEmptyText",
			StarshipsTitle = "FilmSingle_StarshipsTitle",
			StarshipsEmptyText = "FilmSingle_StarshipsEmptyText",
			VehiclesTitle = "FilmSingle_VehiclesTitle",
			VehiclesEmptyText = "FilmSingle_VehiclesEmptyText",
			WeaponsTitle = "FilmSingle_WeaponsTitle",
			WeaponsEmptyText = "FilmSingle_WeaponsEmptyText",
		};
	}

	public static class FilmSingleExtensions
	{
		public static IFilmSingleLocalisation? GetFilmSingle(this LocalisationResourceManager? localisationResourceManager, IFilmSingleLocalisation<bool>? retriever = null, IFilm<string?>? filmTitles = null)
		{
			if (localisationResourceManager == null)
				return filmTitles as IFilmSingleLocalisation;

			IFilmSingleLocalisation filmsingle = IFilmSingleLocalisation.FromFilm(filmTitles) ?? new IFilmSingleLocalisation.Default { };

			filmsingle.CharactersTitle = retriever?.CharactersTitle ?? true ? localisationResourceManager.GetString(FilmSingle.Keys.CharactersTitle) : null;
			filmsingle.CharactersEmptyText = retriever?.CharactersEmptyText ?? true ? localisationResourceManager.GetString(FilmSingle.Keys.CharactersEmptyText) : null;
			filmsingle.FactionsTitle = retriever?.FactionsTitle ?? true ? localisationResourceManager.GetString(FilmSingle.Keys.FactionsTitle) : null;
			filmsingle.FactionsEmptyText = retriever?.FactionsEmptyText ?? true ? localisationResourceManager.GetString(FilmSingle.Keys.FactionsEmptyText) : null;
			filmsingle.ImagesTitle = retriever?.ImagesTitle ?? true ? localisationResourceManager.GetString(FilmSingle.Keys.ImagesTitle) : null;
			filmsingle.ImagesEmptyText = retriever?.ImagesEmptyText ?? true ? localisationResourceManager.GetString(FilmSingle.Keys.ImagesEmptyText) : null;
			filmsingle.ManufacturersTitle = retriever?.ManufacturersTitle ?? true ? localisationResourceManager.GetString(FilmSingle.Keys.ManufacturersTitle) : null;
			filmsingle.ManufacturersEmptyText = retriever?.ManufacturersEmptyText ?? true ? localisationResourceManager.GetString(FilmSingle.Keys.ManufacturersEmptyText) : null;
			filmsingle.PlanetsTitle = retriever?.PlanetsTitle ?? true ? localisationResourceManager.GetString(FilmSingle.Keys.PlanetsTitle) : null;
			filmsingle.PlanetsEmptyText = retriever?.PlanetsEmptyText ?? true ? localisationResourceManager.GetString(FilmSingle.Keys.PlanetsEmptyText) : null;
			filmsingle.SpeciesTitle = retriever?.SpeciesTitle ?? true ? localisationResourceManager.GetString(FilmSingle.Keys.SpeciesTitle) : null;
			filmsingle.SpeciesEmptyText = retriever?.SpeciesEmptyText ?? true ? localisationResourceManager.GetString(FilmSingle.Keys.SpeciesEmptyText) : null;
			filmsingle.StarshipsTitle = retriever?.StarshipsTitle ?? true ? localisationResourceManager.GetString(FilmSingle.Keys.StarshipsTitle) : null;
			filmsingle.StarshipsEmptyText = retriever?.StarshipsEmptyText ?? true ? localisationResourceManager.GetString(FilmSingle.Keys.StarshipsEmptyText) : null;
			filmsingle.VehiclesTitle = retriever?.VehiclesTitle ?? true ? localisationResourceManager.GetString(FilmSingle.Keys.VehiclesTitle) : null;
			filmsingle.VehiclesEmptyText = retriever?.VehiclesEmptyText ?? true ? localisationResourceManager.GetString(FilmSingle.Keys.VehiclesEmptyText) : null;
			filmsingle.WeaponsTitle = retriever?.WeaponsTitle ?? true ? localisationResourceManager.GetString(FilmSingle.Keys.WeaponsTitle) : null;
			filmsingle.WeaponsEmptyText = retriever?.WeaponsEmptyText ?? true ? localisationResourceManager.GetString(FilmSingle.Keys.WeaponsEmptyText) : null;

			return filmsingle;

		}
		public static IFilmSingleLocalisation? GetFilmSingle(this LocalisationResourceManager? localisationResourceManager, IFilmSingleLocalisation<bool>? retriever = null, LocalisationResourceManager? filmTitlesLocalisationResourceManager = null)
			=> localisationResourceManager.GetFilmSingle(
				retriever: retriever,
				filmTitles: filmTitlesLocalisationResourceManager.GetFilmTitles());
	}
}
