using Domain.Models;

namespace Localisation.Utils.Films
{
	public class FilmSortKeysDescriptions
	{
		public const string ResourceName = "Films.FilmSortKeysDescriptions";

		public static readonly IFilm.ISortKeys<string> Keys = new IFilm.ISortKeys.Default<string>(string.Empty)
		{
			CastMembersCount = "FilmSortKeysDescriptions_CastMembersCount",
			CharactersCount = "FilmSortKeysDescriptions_CharactersCount",
			Created = "FilmSortKeysDescriptions_Created",
			Director = "FilmSortKeysDescriptions_Director",
			Duration = "FilmSortKeysDescriptions_Duration",
			EpisodeId = "FilmSortKeysDescriptions_EpisodeId",
			Edited = "FilmSortKeysDescriptions_Edited",
			FactionsCount = "FilmSortKeysDescriptions_FactionsCount",
			Id = "FilmSortKeysDescriptions_Id",
			ManufacturersCount = "FilmSortKeysDescriptions_ManufacturersCount",
			PlanetsCount = "FilmSortKeysDescriptions_PlanetsCount",
			ProducersCount = "FilmSortKeysDescriptions_ProducersCount",
			ReleaseDate = "FilmSortKeysDescriptions_ReleaseDate",
			SpeciesCount = "FilmSortKeysDescriptions_SpeciesCount",
			StarshipsCount = "FilmSortKeysDescriptions_StarshipsCount",
			Title = "FilmSortKeysDescriptions_Title",
			VehiclesCount = "FilmSortKeysDescriptions_VehiclesCount",
			WeaponsCount = "FilmSortKeysDescriptions_WeaponsCount",
		};
	}

	public static class FilmSortKeysDescriptionsExtensions
	{
		public static IFilm.ISortKeys? GetFilmSortKeysDescriptions(this LocalisationResourceManager? localisationResourceManager, IFilm.ISortKeys<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IFilm.ISortKeys.Default
				{
					CastMembersCount = retriever?.CastMembersCount ?? true ? localisationResourceManager.GetString(FilmSortKeysDescriptions.Keys.CastMembersCount) : null,
					CharactersCount = retriever?.CharactersCount ?? true ? localisationResourceManager.GetString(FilmSortKeysDescriptions.Keys.CharactersCount) : null,
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(FilmSortKeysDescriptions.Keys.Created) : null,
					Director = retriever?.Director ?? true ? localisationResourceManager.GetString(FilmSortKeysDescriptions.Keys.Director) : null,
					Duration = retriever?.Duration ?? true ? localisationResourceManager.GetString(FilmSortKeysDescriptions.Keys.Duration) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(FilmSortKeysDescriptions.Keys.Edited) : null,
					EpisodeId = retriever?.EpisodeId ?? true ? localisationResourceManager.GetString(FilmSortKeysDescriptions.Keys.EpisodeId) : null,
					FactionsCount = retriever?.FactionsCount ?? true ? localisationResourceManager.GetString(FilmSortKeysDescriptions.Keys.FactionsCount) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(FilmSortKeysDescriptions.Keys.Id) : null,
					ManufacturersCount = retriever?.ManufacturersCount ?? true ? localisationResourceManager.GetString(FilmSortKeysDescriptions.Keys.ManufacturersCount) : null,
					PlanetsCount = retriever?.PlanetsCount ?? true ? localisationResourceManager.GetString(FilmSortKeysDescriptions.Keys.PlanetsCount) : null,
					ProducersCount = retriever?.ProducersCount ?? true ? localisationResourceManager.GetString(FilmSortKeysDescriptions.Keys.ProducersCount) : null,
					ReleaseDate = retriever?.ReleaseDate ?? true ? localisationResourceManager.GetString(FilmSortKeysDescriptions.Keys.ReleaseDate) : null,
					SpeciesCount = retriever?.SpeciesCount ?? true ? localisationResourceManager.GetString(FilmSortKeysDescriptions.Keys.SpeciesCount) : null,
					StarshipsCount = retriever?.StarshipsCount ?? true ? localisationResourceManager.GetString(FilmSortKeysDescriptions.Keys.StarshipsCount) : null,
					Title = retriever?.Title ?? true ? localisationResourceManager.GetString(FilmSortKeysDescriptions.Keys.Title) : null,
					VehiclesCount = retriever?.VehiclesCount ?? true ? localisationResourceManager.GetString(FilmSortKeysDescriptions.Keys.VehiclesCount) : null,
					WeaponsCount = retriever?.WeaponsCount ?? true ? localisationResourceManager.GetString(FilmSortKeysDescriptions.Keys.WeaponsCount) : null,
				};
	}
}
