using Domain.Models;

namespace Localisation.Utils.Films
{
	public class FilmSortKeysTitles
	{
		public const string ResourceName = "Films.FilmSortKeysTitles";

		public static readonly IFilm.ISortKeys<string> Keys = new IFilm.ISortKeys.Default<string>(string.Empty)
		{
			CastMembersCount = "FilmSortKeysTitles_CastMembersCount",
			CharactersCount = "FilmSortKeysTitles_CharactersCount",
			Created = "FilmSortKeysTitles_Created",
			Director = "FilmSortKeysTitles_Director",
			Duration = "FilmSortKeysTitles_Duration",
			Edited = "FilmSortKeysTitles_Edited",
			EpisodeId = "FilmSortKeysTitles_EpisodeId",
			FactionsCount = "FilmSortKeysTitles_FactionsCount",
			Id = "FilmSortKeysTitles_Id",
			ManufacturersCount = "FilmSortKeysTitles_ManufacturersCount",
			PlanetsCount = "FilmSortKeysTitles_PlanetsCount",
			ProducersCount = "FilmSortKeysTitles_ProducersCount",
			ReleaseDate = "FilmSortKeysTitles_ReleaseDate",
			SpeciesCount = "FilmSortKeysTitles_SpeciesCount",
			StarshipsCount = "FilmSortKeysTitles_StarshipsCount",
			Title = "FilmSortKeysTitles_Title",
			VehiclesCount = "FilmSortKeysTitles_VehiclesCount",
			WeaponsCount = "FilmSortKeysTitles_WeaponsCount",
		};
	}

	public static class FilmSortKeysTitlesExtensions
	{
		public static IFilm.ISortKeys? GetFilmSortKeysTitles(this LocalisationResourceManager? localisationResourceManager, IFilm.ISortKeys<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IFilm.ISortKeys.Default
				{
					CastMembersCount = retriever?.CastMembersCount ?? true ? localisationResourceManager.GetString(FilmSortKeysTitles.Keys.CastMembersCount) : null,
					CharactersCount = retriever?.CharactersCount ?? true ? localisationResourceManager.GetString(FilmSortKeysTitles.Keys.CharactersCount) : null,
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(FilmSortKeysTitles.Keys.Created) : null,
					Director = retriever?.Director ?? true ? localisationResourceManager.GetString(FilmSortKeysTitles.Keys.Director) : null,
					Duration = retriever?.Duration ?? true ? localisationResourceManager.GetString(FilmSortKeysTitles.Keys.Duration) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(FilmSortKeysTitles.Keys.Edited) : null,
					EpisodeId = retriever?.EpisodeId ?? true ? localisationResourceManager.GetString(FilmSortKeysTitles.Keys.EpisodeId) : null,
					FactionsCount = retriever?.FactionsCount ?? true ? localisationResourceManager.GetString(FilmSortKeysTitles.Keys.FactionsCount) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(FilmSortKeysTitles.Keys.Id) : null,
					ManufacturersCount = retriever?.ManufacturersCount ?? true ? localisationResourceManager.GetString(FilmSortKeysTitles.Keys.ManufacturersCount) : null,
					PlanetsCount = retriever?.PlanetsCount ?? true ? localisationResourceManager.GetString(FilmSortKeysTitles.Keys.PlanetsCount) : null,
					ProducersCount = retriever?.ProducersCount ?? true ? localisationResourceManager.GetString(FilmSortKeysTitles.Keys.ProducersCount) : null,
					ReleaseDate = retriever?.ReleaseDate ?? true ? localisationResourceManager.GetString(FilmSortKeysTitles.Keys.ReleaseDate) : null,
					SpeciesCount = retriever?.SpeciesCount ?? true ? localisationResourceManager.GetString(FilmSortKeysTitles.Keys.SpeciesCount) : null,
					StarshipsCount = retriever?.StarshipsCount ?? true ? localisationResourceManager.GetString(FilmSortKeysTitles.Keys.StarshipsCount) : null,
					Title = retriever?.Title ?? true ? localisationResourceManager.GetString(FilmSortKeysTitles.Keys.Title) : null,
					VehiclesCount = retriever?.VehiclesCount ?? true ? localisationResourceManager.GetString(FilmSortKeysTitles.Keys.VehiclesCount) : null,
					WeaponsCount = retriever?.WeaponsCount ?? true ? localisationResourceManager.GetString(FilmSortKeysTitles.Keys.WeaponsCount) : null,
				};
	}
}
