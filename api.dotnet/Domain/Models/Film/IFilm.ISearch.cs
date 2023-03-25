using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Models
{
	public partial interface IFilm 
	{
		public new interface ISearch<T> : IStarWarsModel.ISearch<T>
		{
			T Characters { get; set; }
			T Durations { get; set; }
			T EpisodeIds { get; set; }
			T Factions { get; set; }
			T Manufacturers { get; set; }
			T Planets { get; set; }
			T ReleaseDates { get; set; }
			T Species { get; set; }
			T Starships { get; set; }
			T Vehicles { get; set; }
			T Weapons { get; set; }

			public new string? ToString()
			{
				return new StringBuilder()
					.Append(this)
					.ToString();
			}
		}
		public new interface ISearch : IStarWarsModel.ISearch
		{
			new ISearchContainables? SearchContainables { get; set; }

			ICharacter.ISearchContainables? Characters { get; set; }
			ISearchValues<TimeSpan?>? Durations { get; set; }
			ISearchValues<int?>? EpisodeIds { get; set; }
			IFaction.ISearchContainables? Factions { get; set; }
			IManufacturer.ISearchContainables? Manufacturers { get; set; }
			IPlanet.ISearchContainables? Planets { get; set; }
			ISearchValues<DateTime?>? ReleaseDates { get; set; }
			ISpecie.ISearchContainables? Species { get; set; }
			IStarship.ISearchContainables? Starships { get; set; }
			IVehicle.ISearchContainables? Vehicles { get; set; }
			IWeapon.ISearchContainables? Weapons { get; set; }

			public new string? ToString()
			{
				return new StringBuilder()
					.Append(this)
					.ToString();
			}

			public new class Default : IStarWarsModel.ISearch.Default, ISearch
			{
				public new IFilm.ISearchContainables? SearchContainables { get; set; }

				public ICharacter.ISearchContainables? Characters { get; set; }
				public ISearchValues<TimeSpan?>? Durations { get; set; }
				public ISearchValues<int?>? EpisodeIds { get; set; }
				public IFaction.ISearchContainables? Factions { get; set; }
				public IManufacturer.ISearchContainables? Manufacturers { get; set; }
				public IPlanet.ISearchContainables? Planets { get; set; }
				public ISearchValues<DateTime?>? ReleaseDates { get; set; }
				public ISpecie.ISearchContainables? Species { get; set; }
				public IStarship.ISearchContainables? Starships { get; set; }
				public IVehicle.ISearchContainables? Vehicles { get; set; }
				public IWeapon.ISearchContainables? Weapons { get; set; }
			}
			public new class Default<T> : IStarWarsModel.ISearch.Default<T>, ISearch<T>
			{
				public Default(T defaultvalue) : base(defaultvalue)
				{
					Characters = defaultvalue;
					Durations = defaultvalue;
					EpisodeIds = defaultvalue;
					Factions = defaultvalue;
					Manufacturers = defaultvalue;
					Planets = defaultvalue;
					ReleaseDates = defaultvalue;
					Species = defaultvalue;
					Starships = defaultvalue;
					Vehicles = defaultvalue;
					Weapons = defaultvalue;
				}

				public T Characters { get; set; }
				public T Durations { get; set; }
				public T EpisodeIds { get; set; }
				public T Factions { get; set; }
				public T Manufacturers { get; set; }
				public T Planets { get; set; }
				public T ReleaseDates { get; set; }
				public T Species { get; set; }
				public T Starships { get; set; }
				public T Vehicles { get; set; }
				public T Weapons { get; set; }
			}

			public bool ShouldReturnFilm(IFilm film)
			{
				if (SearchContainables?.ShouldReturnFilm(film, SearchString) ?? false)
					return true;

				if (Durations?.Search(film.Duration, out int _) ?? false) return true;
				if (EpisodeIds?.Search(film.EpisodeId, out int _) ?? false) return true;
				if (ReleaseDates?.Search(film.ReleaseDate, out int _) ?? false) return true;

				return false;
			}
			public bool ShouldReturnFilm(
				IFilm film,
				Func<IEnumerable<ICharacter>>? charactersFunc = null,
				Func<IEnumerable<IFaction>>? factionsFunc = null,
				Func<IEnumerable<IManufacturer>>? manufacturersFunc = null,
				Func<IEnumerable<IPlanet>>? planetsFunc = null,
				Func<IEnumerable<ISpecie>>? speciesFunc = null,
				Func<IEnumerable<IStarship>>? starshipsFunc = null,
				Func<IEnumerable<IVehicle>>? vehiclesFunc = null,
				Func<IEnumerable<IWeapon>>? weaponsFunc = null)
			{
				if (ShouldReturnFilm(film))
					return true;

				if (Characters is not null && charactersFunc is not null)
					foreach (ICharacter character in charactersFunc.Invoke())
						if (Characters.ShouldReturnCharacter(character, SearchString))
							return true;

				if (Factions is not null && factionsFunc is not null)
					foreach (IFaction faction in factionsFunc.Invoke())
						if (Factions.ShouldReturnFaction(faction, SearchString))
							return true;

				if (Manufacturers is not null && manufacturersFunc is not null)
					foreach (IManufacturer manufacturer in manufacturersFunc.Invoke())
						if (Manufacturers.ShouldReturnManufacturer(manufacturer, SearchString))
							return true;

				if (Planets is not null && planetsFunc is not null)
					foreach (IPlanet planet in planetsFunc.Invoke())
						if (Planets.ShouldReturnPlanet(planet, SearchString))
							return true;

				if (Species is not null && speciesFunc is not null)
					foreach (ISpecie specie in speciesFunc.Invoke())
						if (Species.ShouldReturnSpecie(specie, SearchString))
							return true;

				if (Starships is not null && starshipsFunc is not null)
					foreach (IStarship starship in starshipsFunc.Invoke())
						if (Starships.ShouldReturnStarship(starship, SearchString))
							return true;

				if (Vehicles is not null && vehiclesFunc is not null)
					foreach (IVehicle vehicle in vehiclesFunc.Invoke())
						if (Vehicles.ShouldReturnVehicle(vehicle, SearchString))
							return true;

				if (Weapons is not null && weaponsFunc is not null)
					foreach (IWeapon weapon in weaponsFunc.Invoke())
						if (Weapons.ShouldReturnWeapon(weapon, SearchString))
							return true;

				return false;
			}

			public async Task<bool> ShouldReturnFilmAsync(
				IFilm film,
				Func<IAsyncEnumerable<ICharacter>>? charactersFunc = null,
				Func<IAsyncEnumerable<IFaction>>? factionsFunc = null,
				Func<IAsyncEnumerable<IManufacturer>>? manufacturersFunc = null,
				Func<IAsyncEnumerable<IPlanet>>? planetsFunc = null,
				Func<IAsyncEnumerable<ISpecie>>? speciesFunc = null,
				Func<IAsyncEnumerable<IStarship>>? starshipsFunc = null,
				Func<IAsyncEnumerable<IVehicle>>? vehiclesFunc = null,
				Func<IAsyncEnumerable<IWeapon>>? weaponsFunc = null,
				CancellationToken cancellationToken = default)
			{
				if (ShouldReturnFilm(film))
					return true;

				if (Characters is not null && charactersFunc is not null)
					await foreach (ICharacter character in charactersFunc.Invoke().WithCancellation(cancellationToken))
						if (Characters.ShouldReturnCharacter(character, SearchString))
							return true;

				if (Factions is not null && factionsFunc is not null)
					await foreach (IFaction faction in factionsFunc.Invoke().WithCancellation(cancellationToken))
						if (Factions.ShouldReturnFaction(faction, SearchString))
							return true;

				if (Manufacturers is not null && manufacturersFunc is not null)
					await foreach (IManufacturer manufacturer in manufacturersFunc.Invoke().WithCancellation(cancellationToken))
						if (Manufacturers.ShouldReturnManufacturer(manufacturer, SearchString))
							return true;

				if (Planets is not null && planetsFunc is not null)
					await foreach (IPlanet planet in planetsFunc.Invoke().WithCancellation(cancellationToken))
						if (Planets.ShouldReturnPlanet(planet, SearchString))
							return true;

				if (Species is not null && speciesFunc is not null)
					await foreach (ISpecie specie in speciesFunc.Invoke().WithCancellation(cancellationToken))
						if (Species.ShouldReturnSpecie(specie, SearchString))
							return true;

				if (Starships is not null && starshipsFunc is not null)
					await foreach (IStarship starship in starshipsFunc.Invoke().WithCancellation(cancellationToken))
						if (Starships.ShouldReturnStarship(starship, SearchString))
							return true;

				if (Vehicles is not null && vehiclesFunc is not null)
					await foreach (IVehicle vehicle in vehiclesFunc.Invoke().WithCancellation(cancellationToken))
						if (Vehicles.ShouldReturnVehicle(vehicle, SearchString))
							return true;

				if (Weapons is not null && weaponsFunc is not null)
					await foreach (IWeapon weapon in weaponsFunc.Invoke().WithCancellation(cancellationToken))
						if (Weapons.ShouldReturnWeapon(weapon, SearchString))
							return true;

				return false;
			}


			public int GetMatchCount(IFilm film)
			{
				int matchcount = 0;

				if (SearchContainables is not null)
				{
					SearchContainables.ShouldReturnFilm(film, SearchString, out int containablesmatchcount); matchcount += containablesmatchcount;
				}

				if (Durations is not null && Durations.Search(film.Duration, out int durationmatchcount)) matchcount += durationmatchcount;
				if (EpisodeIds is not null && EpisodeIds.Search(film.EpisodeId, out int episodeidmatchcount)) matchcount += episodeidmatchcount;
				if (ReleaseDates is not null && ReleaseDates.Search(film.ReleaseDate, out int releasedatematchcount)) matchcount += releasedatematchcount;

				return matchcount;
			}
			public int GetMatchCount(
				IFilm film,
				Func<IEnumerable<ICharacter>>? charactersFunc = null,
				Func<IEnumerable<IFaction>>? factionsFunc = null,
				Func<IEnumerable<IManufacturer>>? manufacturersFunc = null,
				Func<IEnumerable<IPlanet>>? planetsFunc = null,
				Func<IEnumerable<ISpecie>>? speciesFunc = null,
				Func<IEnumerable<IStarship>>? starshipsFunc = null,
				Func<IEnumerable<IVehicle>>? vehiclesFunc = null,
				Func<IEnumerable<IWeapon>>? weaponsFunc = null)
			{
				int matchcount = GetMatchCount(film);

				if (Characters is not null && charactersFunc is not null)
					matchcount += charactersFunc.Invoke()
						.Select(character =>
						{
							Characters.ShouldReturnCharacter(character, SearchString, out int charactermatchcount);

							return charactermatchcount;

						}).Sum();

				if (Factions is not null && factionsFunc is not null)
					matchcount += factionsFunc.Invoke()
						.Select(faction =>
						{
							Factions.ShouldReturnFaction(faction, SearchString, out int factionmatchcount);

							return factionmatchcount;

						}).Sum();

				if (Manufacturers is not null && manufacturersFunc is not null)
					matchcount += manufacturersFunc.Invoke()
						.Select(manufacturer =>
						{
							Manufacturers.ShouldReturnManufacturer(manufacturer, SearchString, out int manufacturermatchcount);

							return manufacturermatchcount;

						}).Sum();

				if (Planets is not null && planetsFunc is not null)
					matchcount += planetsFunc.Invoke()
						.Select(planet =>
						{
							Planets.ShouldReturnPlanet(planet, SearchString, out int planetmatchcount);

							return planetmatchcount;

						}).Sum();

				if (Species is not null && speciesFunc is not null)
					matchcount += speciesFunc.Invoke()
						.Select(specie =>
						{
							Species.ShouldReturnSpecie(specie, SearchString, out int speciematchcount);

							return speciematchcount;

						}).Sum();

				if (Starships is not null && starshipsFunc is not null)
					matchcount += starshipsFunc.Invoke()
						.Select(starship =>
						{
							Starships.ShouldReturnStarship(starship, SearchString, out int starshipmatchcount);

							return starshipmatchcount;

						}).Sum();

				if (Vehicles is not null && vehiclesFunc is not null)
					matchcount += vehiclesFunc.Invoke()
						.Select(vehicle =>
						{
							Vehicles.ShouldReturnVehicle(vehicle, SearchString, out int vehiclematchcount);

							return vehiclematchcount;

						}).Sum();

				if (Weapons is not null && weaponsFunc is not null)
					matchcount += weaponsFunc.Invoke()
						.Select(weapon =>
						{
							Weapons.ShouldReturnWeapon(weapon, SearchString, out int weaponmatchcount);

							return weaponmatchcount;

						}).Sum();

				return matchcount;
			}

			public async Task<int> GetMatchCountAsync(
				IFilm film,
				Func<IAsyncEnumerable<ICharacter>>? charactersFunc = null,
				Func<IAsyncEnumerable<IFaction>>? factionsFunc = null,
				Func<IAsyncEnumerable<IManufacturer>>? manufacturersFunc = null,
				Func<IAsyncEnumerable<IPlanet>>? planetsFunc = null,
				Func<IAsyncEnumerable<ISpecie>>? speciesFunc = null,
				Func<IAsyncEnumerable<IStarship>>? starshipsFunc = null,
				Func<IAsyncEnumerable<IVehicle>>? vehiclesFunc = null,
				Func<IAsyncEnumerable<IWeapon>>? weaponsFunc = null,
				CancellationToken cancellationToken = default)
			{
				int matchcount = GetMatchCount(film);

				if (Characters is not null && charactersFunc is not null)
					await foreach (ICharacter character in charactersFunc.Invoke().WithCancellation(cancellationToken))
					{
						Characters.ShouldReturnCharacter(character, SearchString, out int charactermatchcount); matchcount += charactermatchcount;
					}

				if (Factions is not null && factionsFunc is not null)
					await foreach (IFaction faction in factionsFunc.Invoke().WithCancellation(cancellationToken))
					{
						Factions.ShouldReturnFaction(faction, SearchString, out int factionmatchcount); matchcount += factionmatchcount;
					}

				if (Manufacturers is not null && manufacturersFunc is not null)
					await foreach (IManufacturer manufacturer in manufacturersFunc.Invoke().WithCancellation(cancellationToken))
					{
						Manufacturers.ShouldReturnManufacturer(manufacturer, SearchString, out int manufacturermatchcount); matchcount += manufacturermatchcount;
					}

				if (Planets is not null && planetsFunc is not null)
					await foreach (IPlanet planet in planetsFunc.Invoke().WithCancellation(cancellationToken))
					{
						Planets.ShouldReturnPlanet(planet, SearchString, out int planetmatchcount); matchcount += planetmatchcount;
					}

				if (Species is not null && speciesFunc is not null)
					await foreach (ISpecie specie in speciesFunc.Invoke().WithCancellation(cancellationToken))
					{
						Species.ShouldReturnSpecie(specie, SearchString, out int speciematchcount); matchcount += speciematchcount;
					}

				if (Starships is not null && starshipsFunc is not null)
					await foreach (IStarship starship in starshipsFunc.Invoke().WithCancellation(cancellationToken))
					{
						Starships.ShouldReturnStarship(starship, SearchString, out int starshipmatchcount); matchcount += starshipmatchcount;
					}

				if (Vehicles is not null && vehiclesFunc is not null)
					await foreach (IVehicle vehicle in vehiclesFunc.Invoke().WithCancellation(cancellationToken))
					{
						Vehicles.ShouldReturnVehicle(vehicle, SearchString, out int vehiclematchcount); matchcount += vehiclematchcount;
					}

				if (Weapons is not null && weaponsFunc is not null)
					await foreach (IWeapon weapon in weaponsFunc.Invoke().WithCancellation(cancellationToken))
					{
						Weapons.ShouldReturnWeapon(weapon, SearchString, out int weaponmatchcount); matchcount += weaponmatchcount;
					}

				return matchcount;
			}
		}
	}

	public static class FilmSearchExtensions
	{
		public static StringBuilder Append<T>(this StringBuilder stringbuilder, IFilm.ISearch<T>? search)
		{
			if (search is null)
				return stringbuilder;

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(IFilm.ISearch<T>.Characters), search.Characters).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IFilm.ISearch<T>.Durations), search.Durations).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IFilm.ISearch<T>.EpisodeIds), search.EpisodeIds).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IFilm.ISearch<T>.Factions), search.Factions).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IFilm.ISearch<T>.Manufacturers), search.Manufacturers).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IFilm.ISearch<T>.Planets), search.Planets).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IFilm.ISearch<T>.ReleaseDates), search.ReleaseDates).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IFilm.ISearch<T>.Species), search.Species).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IFilm.ISearch<T>.Starships), search.Starships).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IFilm.ISearch<T>.Vehicles), search.Vehicles).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IFilm.ISearch<T>.Weapons), search.Weapons).AppendLine();

			return stringbuilder.Append(search as IStarWarsModel.ISearch<T>);
		}
		public static StringBuilder Append(this StringBuilder stringbuilder, IFilm.ISearch? search)
		{
			if (search is null)
				return stringbuilder;

			if (search.SearchContainables is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(IFilm.ISearch.SearchContainables)).AppendLine()
					.Append(search.SearchContainables).AppendLine();

			if (search.Characters is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(IFilm.ISearch.Characters)).AppendLine()
					.Append(search.Characters).AppendLine();

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(IFilm.ISearch.Durations)).AppendJoin(", ", search.Durations).AppendLine()
				.AppendFormat("{0}: {1}", nameof(IFilm.ISearch.EpisodeIds)).AppendJoin(", ", search.EpisodeIds).AppendLine();

			if (search.Factions is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(IFilm.ISearch.Factions)).AppendLine()
					.Append(search.Factions).AppendLine();			

			if (search.Manufacturers is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(IFilm.ISearch.Manufacturers)).AppendLine()
					.Append(search.Manufacturers).AppendLine();			

			if (search.Planets is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(IFilm.ISearch.Planets)).AppendLine()
					.Append(search.Planets).AppendLine();

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(IFilm.ISearch.ReleaseDates)).AppendJoin(", ", search.ReleaseDates).AppendLine();

			if (search.Species is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(IFilm.ISearch.Species)).AppendLine()
					.Append(search.Species).AppendLine();			

			if (search.Starships is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(IFilm.ISearch.Starships)).AppendLine()
					.Append(search.Starships).AppendLine();			

			if (search.Vehicles is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(IFilm.ISearch.Vehicles)).AppendLine()
					.Append(search.Vehicles).AppendLine();			

			if (search.Weapons is not null)
				stringbuilder
					.AppendFormat("{0}: ", nameof(IFilm.ISearch.Weapons)).AppendLine()
					.Append(search.Weapons).AppendLine();

			return stringbuilder.Append(search as IStarWarsModel.ISearch);
		}
	}
}
