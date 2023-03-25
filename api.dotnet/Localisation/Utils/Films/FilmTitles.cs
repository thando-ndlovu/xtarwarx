using Domain.Models;

namespace Localisation.Utils.Films
{
	public class FilmTitles 
	{
		public const string ResourceName = "Films.FilmTitles";

		public static readonly IFilm<string> Keys = new IFilm.Default<string>(string.Empty)
		{
			CastMembers = "FilmTitles_CastMembers",
			CharacterIds = "FilmTitles_CharacterIds",
			Description = "FilmTitles_Description",
			Director = "FilmTitles_Director",
			Duration = "FilmTitles_Duration",
			EpisodeId = "FilmTitles_EpisodeId",
			FactionIds = "FilmTitles_FactionIds",
			Id = "FilmTitles_Id",
			ManufacturerIds = "FilmTitles_ManufacturerIds",
			OpeningCrawl = "FilmTitles_OpeningCrawl",
			PlanetIds = "FilmTitles_PlanetIds",
			Producers = "FilmTitles_Producers",
			ReleaseDate = "FilmTitles_ReleaseDate",
			SpecieIds = "FilmTitles_SpecieIds",
			StarshipIds = "FilmTitles_StarshipIds",
			Title = "FilmTitles_Title",
			VehicleIds = "FilmTitles_VehicleIds",
			WeaponIds = "FilmTitles_WeaponIds",
			Uris = "FilmTitles_Uris",
			Created = "FilmTitles_Created",
			Edited = "FilmTitles_Edited",
		};
	}

	public static class FilmTitlesExtensions
	{
		public static IFilm<string?>? GetFilmTitles(this LocalisationResourceManager? localisationResourceManager, IFilm<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IFilm.Default<string?>(null)
				{
					CastMembers = retriever?.CastMembers ?? true ? localisationResourceManager.GetString(FilmTitles.Keys.CastMembers) : null,
					CharacterIds = retriever?.CharacterIds ?? true ? localisationResourceManager.GetString(FilmTitles.Keys.CharacterIds) : null,
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(FilmTitles.Keys.Created) : null,
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(FilmTitles.Keys.Description) : null,
					Director = retriever?.Director ?? true ? localisationResourceManager.GetString(FilmTitles.Keys.Director) : null,
					Duration = retriever?.Duration ?? true ? localisationResourceManager.GetString(FilmTitles.Keys.Duration) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(FilmTitles.Keys.Edited) : null,
					EpisodeId = retriever?.EpisodeId ?? true ? localisationResourceManager.GetString(FilmTitles.Keys.EpisodeId) : null,
					FactionIds = retriever?.FactionIds ?? true ? localisationResourceManager.GetString(FilmTitles.Keys.FactionIds) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(FilmTitles.Keys.Id) : null,
					ManufacturerIds = retriever?.ManufacturerIds ?? true ? localisationResourceManager.GetString(FilmTitles.Keys.ManufacturerIds) : null,
					OpeningCrawl = retriever?.OpeningCrawl ?? true ? localisationResourceManager.GetString(FilmTitles.Keys.OpeningCrawl) : null,
					PlanetIds = retriever?.PlanetIds ?? true ? localisationResourceManager.GetString(FilmTitles.Keys.PlanetIds) : null,
					Producers = retriever?.Producers ?? true ? localisationResourceManager.GetString(FilmTitles.Keys.Producers) : null,
					ReleaseDate = retriever?.ReleaseDate ?? true ? localisationResourceManager.GetString(FilmTitles.Keys.ReleaseDate) : null,
					SpecieIds = retriever?.SpecieIds ?? true ? localisationResourceManager.GetString(FilmTitles.Keys.SpecieIds) : null,
					StarshipIds = retriever?.StarshipIds ?? true ? localisationResourceManager.GetString(FilmTitles.Keys.StarshipIds) : null,
					Title = retriever?.Title ?? true ? localisationResourceManager.GetString(FilmTitles.Keys.Title) : null,
					Uris = retriever?.Uris ?? true ? localisationResourceManager.GetString(FilmTitles.Keys.Uris) : null,
					VehicleIds = retriever?.VehicleIds ?? true ? localisationResourceManager.GetString(FilmTitles.Keys.VehicleIds) : null,
					WeaponIds = retriever?.WeaponIds ?? true ? localisationResourceManager.GetString(FilmTitles.Keys.WeaponIds) : null,
				};
	}
}
