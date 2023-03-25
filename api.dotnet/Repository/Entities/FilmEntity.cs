using Domain.Models;

namespace Repository.Entities
{
	public class FilmEntity : IFilm.Default
	{
		public FilmEntity(int id) : base(id) { }
		public FilmEntity(IFilm film) : base(film.Id)
		{
			CastMembers = film.CastMembers;
			CharacterIds = film.CharacterIds;
			Created = film.Created;
			Description = film.Description;
			Director = film.Director;
			Duration = film.Duration;
			Edited = film.Edited;
			EpisodeId = film.EpisodeId;
			FactionIds = film.FactionIds;
			ManufacturerIds = film.ManufacturerIds;
			OpeningCrawl = film.OpeningCrawl;
			PlanetIds = film.PlanetIds;
			Producers = film.Producers;
			ReleaseDate = film.ReleaseDate;
			SpecieIds = film.SpecieIds;
			StarshipIds = film.StarshipIds;
			Title = film.Title;
			Uris = film.Uris;
			VehicleIds = film.VehicleIds;
			WeaponIds = film.WeaponIds;
		}
	}
}
