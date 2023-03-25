using Domain.Models;

namespace Localisation.Utils.Films
{
	public class FilmDescriptions
	{
		public const string ResourceName = "Films.FilmDescriptions";

		public static readonly IFilm<string> Keys = new IFilm.Default<string>(string.Empty)
		{
			CastMembers = "FilmDescriptions_CastMembers",
			CharacterIds = "FilmDescriptions_CharacterIds",
			Description = "FilmDescriptions_Description",
			Director = "FilmDescriptions_Director",
			Duration = "FilmDescriptions_Duration",
			EpisodeId = "FilmDescriptions_EpisodeId",
			FactionIds = "FilmDescriptions_FactionIds",
			Id = "FilmDescriptions_Id",
			ManufacturerIds = "FilmDescriptions_ManufacturerIds",
			OpeningCrawl = "FilmDescriptions_OpeningCrawl",
			PlanetIds = "FilmDescriptions_PlanetIds",
			Producers = "FilmDescriptions_Producers",
			ReleaseDate = "FilmDescriptions_ReleaseDate",
			SpecieIds = "FilmDescriptions_SpecieIds",
			StarshipIds = "FilmDescriptions_StarshipIds",
			Title = "FilmDescriptions_Title",
			VehicleIds = "FilmDescriptions_VehicleIds",
			WeaponIds = "FilmDescriptions_WeaponIds",
			Uris = "FilmDescriptions_Uris",
			Created = "FilmDescriptions_Created",
			Edited = "FilmDescriptions_Edited",
		};
	}

	public static class FilmDescriptionsExtensions
	{
		public static IFilm<string?>? GetFilmDescriptions(this LocalisationResourceManager? localisationResourceManager, IFilm<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IFilm.Default<string?>(null)
				{
					CastMembers = retriever?.CastMembers ?? true ? localisationResourceManager.GetString(FilmDescriptions.Keys.CastMembers) : null,
					CharacterIds = retriever?.CharacterIds ?? true ? localisationResourceManager.GetString(FilmDescriptions.Keys.CharacterIds) : null,
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(FilmDescriptions.Keys.Created) : null,
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(FilmDescriptions.Keys.Description) : null,
					Director = retriever?.Director ?? true ? localisationResourceManager.GetString(FilmDescriptions.Keys.Director) : null,
					Duration = retriever?.Duration ?? true ? localisationResourceManager.GetString(FilmDescriptions.Keys.Duration) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(FilmDescriptions.Keys.Edited) : null,
					EpisodeId = retriever?.EpisodeId ?? true ? localisationResourceManager.GetString(FilmDescriptions.Keys.EpisodeId) : null,
					FactionIds = retriever?.FactionIds ?? true ? localisationResourceManager.GetString(FilmDescriptions.Keys.FactionIds) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(FilmDescriptions.Keys.Id) : null,
					ManufacturerIds = retriever?.ManufacturerIds ?? true ? localisationResourceManager.GetString(FilmDescriptions.Keys.ManufacturerIds) : null,
					OpeningCrawl = retriever?.OpeningCrawl ?? true ? localisationResourceManager.GetString(FilmDescriptions.Keys.OpeningCrawl) : null,
					PlanetIds = retriever?.PlanetIds ?? true ? localisationResourceManager.GetString(FilmDescriptions.Keys.PlanetIds) : null,
					Producers = retriever?.Producers ?? true ? localisationResourceManager.GetString(FilmDescriptions.Keys.Producers) : null,
					ReleaseDate = retriever?.ReleaseDate ?? true ? localisationResourceManager.GetString(FilmDescriptions.Keys.ReleaseDate) : null,
					SpecieIds = retriever?.SpecieIds ?? true ? localisationResourceManager.GetString(FilmDescriptions.Keys.SpecieIds) : null,
					StarshipIds = retriever?.StarshipIds ?? true ? localisationResourceManager.GetString(FilmDescriptions.Keys.StarshipIds) : null,
					Title = retriever?.Title ?? true ? localisationResourceManager.GetString(FilmDescriptions.Keys.Title) : null,
					Uris = retriever?.Uris ?? true ? localisationResourceManager.GetString(FilmDescriptions.Keys.Uris) : null,
					VehicleIds = retriever?.VehicleIds ?? true ? localisationResourceManager.GetString(FilmDescriptions.Keys.VehicleIds) : null,
					WeaponIds = retriever?.WeaponIds ?? true ? localisationResourceManager.GetString(FilmDescriptions.Keys.WeaponIds) : null,
				};
	}
}
