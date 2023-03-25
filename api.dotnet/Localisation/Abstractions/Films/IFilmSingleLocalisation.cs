using Domain.Models;

namespace Localisation.Abstractions.Films
{
	public interface IFilmSingleLocalisation<T> : IFilm<T>
	{
		T ImagesTitle { get; set; }
		T ImagesEmptyText { get; set; }

		T CharactersTitle { get; set; }
		T CharactersEmptyText { get; set; }

		T FactionsTitle { get; set; }
		T FactionsEmptyText { get; set; }

		T ManufacturersTitle { get; set; }
		T ManufacturersEmptyText { get; set; }

		T PlanetsTitle { get; set; }
		T PlanetsEmptyText { get; set; }

		T SpeciesTitle { get; set; }
		T SpeciesEmptyText { get; set; }

		T StarshipsTitle { get; set; }
		T StarshipsEmptyText { get; set; }

		T VehiclesTitle { get; set; }
		T VehiclesEmptyText { get; set; }

		T WeaponsTitle { get; set; }
		T WeaponsEmptyText { get; set; }
	}
	public interface IFilmSingleLocalisation : IFilm<string?>
	{
		string? ImagesTitle { get; set; }
		string? ImagesEmptyText { get; set; }

		string? CharactersTitle { get; set; }
		string? CharactersEmptyText { get; set; }

		string? FactionsTitle { get; set; }
		string? FactionsEmptyText { get; set; }

		string? ManufacturersTitle { get; set; }
		string? ManufacturersEmptyText { get; set; }

		string? PlanetsTitle { get; set; }
		string? PlanetsEmptyText { get; set; }

		string? SpeciesTitle { get; set; }
		string? SpeciesEmptyText { get; set; }

		string? StarshipsTitle { get; set; }
		string? StarshipsEmptyText { get; set; }

		string? VehiclesTitle { get; set; }
		string? VehiclesEmptyText { get; set; }

		string? WeaponsTitle { get; set; }
		string? WeaponsEmptyText { get; set; }

		#region Methods

		public static IFilmSingleLocalisation? FromFilm(IFilm<string?>? film)
			=> film == null
				? null
				: new Default
				{
					Uris = film.Uris,
					Created = film.Created,
					Edited = film.Edited,

					CastMembers = film.CastMembers,
					CharacterIds = film.CharacterIds,
					Description = film.Description,
					Director = film.Director,
					Duration = film.Duration,
					EpisodeId = film.EpisodeId,
					FactionIds = film.FactionIds,
					ManufacturerIds = film.ManufacturerIds,
					OpeningCrawl = film.OpeningCrawl,
					PlanetIds = film.PlanetIds,
					Producers = film.Producers,
					ReleaseDate = film.ReleaseDate,
					SpecieIds = film.SpecieIds,
					StarshipIds = film.StarshipIds,
					Title = film.Title,
					VehicleIds = film.VehicleIds,
					WeaponIds = film.WeaponIds,
				};

		#endregion

		#region Defaults

		public class Default : IFilm.Default<string?>, IFilmSingleLocalisation
		{
			public Default() : base(null) { }

			public string? ImagesTitle { get; set; }
			public string? ImagesEmptyText { get; set; }

			public string? CharactersTitle { get; set; }
			public string? CharactersEmptyText { get; set; }

			public string? FactionsTitle { get; set; }
			public string? FactionsEmptyText { get; set; }

			public string? ManufacturersTitle { get; set; }
			public string? ManufacturersEmptyText { get; set; }

			public string? PlanetsTitle { get; set; }
			public string? PlanetsEmptyText { get; set; }

			public string? SpeciesTitle { get; set; }
			public string? SpeciesEmptyText { get; set; }

			public string? StarshipsTitle { get; set; }
			public string? StarshipsEmptyText { get; set; }

			public string? VehiclesTitle { get; set; }
			public string? VehiclesEmptyText { get; set; }

			public string? WeaponsTitle { get; set; }
			public string? WeaponsEmptyText { get; set; }
		}
		public class Default<T> : IFilm.Default<T>, IFilmSingleLocalisation<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				ImagesTitle = defaultvalue;
				ImagesEmptyText = defaultvalue;
				
				CharactersTitle = defaultvalue;
				CharactersEmptyText = defaultvalue;
				
				FactionsTitle = defaultvalue;
				FactionsEmptyText = defaultvalue;
				
				ManufacturersTitle = defaultvalue;
				ManufacturersEmptyText = defaultvalue;
				
				PlanetsTitle = defaultvalue;
				PlanetsEmptyText = defaultvalue;
				
				SpeciesTitle = defaultvalue;
				SpeciesEmptyText = defaultvalue;
				
				StarshipsTitle = defaultvalue;
				StarshipsEmptyText = defaultvalue;
				
				VehiclesTitle = defaultvalue;
				VehiclesEmptyText = defaultvalue;

				WeaponsTitle = defaultvalue;
				WeaponsEmptyText = defaultvalue;
			}
			
			public T ImagesTitle { get; set; }
			public T ImagesEmptyText { get; set; }

			public T CharactersTitle { get; set; }
			public T CharactersEmptyText { get; set; }

			public T FactionsTitle { get; set; }
			public T FactionsEmptyText { get; set; }

			public T ManufacturersTitle { get; set; }
			public T ManufacturersEmptyText { get; set; }

			public T PlanetsTitle { get; set; }
			public T PlanetsEmptyText { get; set; }

			public T SpeciesTitle { get; set; }
			public T SpeciesEmptyText { get; set; }

			public T StarshipsTitle { get; set; }
			public T StarshipsEmptyText { get; set; }

			public T VehiclesTitle { get; set; }
			public T VehiclesEmptyText { get; set; }

			public T WeaponsTitle { get; set; }
			public T WeaponsEmptyText { get; set; }
		}

		#endregion
	}
}
