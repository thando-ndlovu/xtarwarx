using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Models
{
	public partial interface IFilm 
	{
		public new interface ISortKeys<T> : IStarWarsModel.ISortKeys<T> 
		{
			T CastMembersCount { get; set; }
			T CharactersCount { get; set; }
			T Director { get; set; }
			T Duration { get; set; }
			T EpisodeId { get; set; }
			T FactionsCount { get; set; }
			T ManufacturersCount { get; set; }
			T PlanetsCount { get; set; }
			T ProducersCount { get; set; }
			T ReleaseDate { get; set; }
			T SpeciesCount { get; set; }
			T StarshipsCount { get; set; }
			T Title { get; set; }
			T VehiclesCount { get; set; }
			T WeaponsCount { get; set; }

			public new T GetValue(string sortkey)
			{
				return sortkey switch
				{
					ISortKeys.Keys.CastMembersCount => CastMembersCount,
					ISortKeys.Keys.CharactersCount => CharactersCount,
					ISortKeys.Keys.Director => Director,
					ISortKeys.Keys.Duration => Duration,
					ISortKeys.Keys.EpisodeId => EpisodeId,
					ISortKeys.Keys.FactionsCount => FactionsCount,
					ISortKeys.Keys.ManufacturersCount => ManufacturersCount,
					ISortKeys.Keys.PlanetsCount => PlanetsCount,
					ISortKeys.Keys.ProducersCount => ProducersCount,
					ISortKeys.Keys.ReleaseDate => ReleaseDate,
					ISortKeys.Keys.SpeciesCount => SpeciesCount,
					ISortKeys.Keys.StarshipsCount => StarshipsCount,
					ISortKeys.Keys.Title => Title,
					ISortKeys.Keys.VehiclesCount => VehiclesCount,
					ISortKeys.Keys.WeaponsCount => WeaponsCount,

					_ => (this as IStarWarsModel.ISortKeys<T>).GetValue(sortkey),
				};
			}
			public new string ToString(StringBuilder? stringBuilder = null)
			{
				return (this as IStarWarsModel.ISortKeys<T>).ToString(
					(stringBuilder ?? new StringBuilder())
						.AppendFormat("{0}: {1}", nameof(CastMembersCount), CastMembersCount).AppendLine()
						.AppendFormat("{0}: {1}", nameof(CharactersCount), CharactersCount).AppendLine()
						.AppendFormat("{0}: {1}", nameof(Director), Director).AppendLine()
						.AppendFormat("{0}: {1}", nameof(Duration), Duration).AppendLine()
						.AppendFormat("{0}: {1}", nameof(EpisodeId), EpisodeId).AppendLine()
						.AppendFormat("{0}: {1}", nameof(FactionsCount), FactionsCount).AppendLine()
						.AppendFormat("{0}: {1}", nameof(ManufacturersCount), ManufacturersCount).AppendLine()
						.AppendFormat("{0}: {1}", nameof(PlanetsCount), PlanetsCount).AppendLine()
						.AppendFormat("{0}: {1}", nameof(ProducersCount), ProducersCount).AppendLine()
						.AppendFormat("{0}: {1}", nameof(ReleaseDate), ReleaseDate).AppendLine()
						.AppendFormat("{0}: {1}", nameof(SpeciesCount), SpeciesCount).AppendLine()
						.AppendFormat("{0}: {1}", nameof(StarshipsCount), StarshipsCount).AppendLine()
						.AppendFormat("{0}: {1}", nameof(Title), Title).AppendLine()
						.AppendFormat("{0}: {1}", nameof(VehiclesCount), VehiclesCount).AppendLine()
						.AppendFormat("{0}: {1}", nameof(WeaponsCount), WeaponsCount).AppendLine());
			}
		}
		public new interface ISortKeys : ISortKeys<string?>, IStarWarsModel.ISortKeys
		{
			public new class Keys : IStarWarsModel.ISortKeys.Keys
			{
				public const string CastMembersCount = "CastMembersCount";
				public const string CharactersCount = "CharactersCount";
				public const string Director = "Director";
				public const string Duration = "Duration";
				public const string EpisodeId = "EpisodeId";
				public const string FactionsCount = "FactionsCount";
				public const string ManufacturersCount = "ManufacturersCount";
				public const string PlanetsCount = "PlanetsCount";
				public const string ProducersCount = "ProducersCount";
				public const string ReleaseDate = "ReleaseDate";
				public const string SpeciesCount = "SpeciesCount";
				public const string StarshipsCount = "StarshipsCount";
				public const string Title = "Title";
				public const string VehiclesCount = "VehiclesCount";
				public const string WeaponsCount = "WeaponsCount";

				public new static IEnumerable<string> AsEnumerable()
				{
					return IStarWarsModel.ISortKeys.Keys
						.AsEnumerable()
						.Append(CastMembersCount)
						.Append(CharactersCount)
						.Append(Director)
						.Append(Duration)
						.Append(EpisodeId)
						.Append(FactionsCount)
						.Append(ManufacturersCount)
						.Append(PlanetsCount)
						.Append(ProducersCount)
						.Append(ReleaseDate)
						.Append(SpeciesCount)
						.Append(StarshipsCount)
						.Append(Title)
						.Append(VehiclesCount)
						.Append(WeaponsCount);
				}
				public static IOrderedEnumerable<IFilm> Sort(IEnumerable<IFilm> films, params Sorter[] sorters)
				{
					IOrderedEnumerable<IFilm>? ordered = null;

					foreach (Sorter sorter in sorters)
						ordered = (sorter.SortKey, sorter.Descending) switch
						{
							(CastMembersCount, false) => 
								ordered?.ThenBy(film => film.CastMembers?.Count()) ??
								films.OrderBy(film => film.CastMembers?.Count()),
							(CastMembersCount, true) => 
								ordered?.ThenByDescending(film => film.CastMembers?.Count()) ??
								films.OrderByDescending(film => film.CastMembers?.Count()),

							(CharactersCount, false) => 
								ordered?.ThenBy(film => film.CharacterIds?.Count()) ??
								films.OrderBy(film => film.CharacterIds?.Count()),
							(CharactersCount, true) => 
								ordered?.ThenByDescending(film => film.CharacterIds?.Count()) ??
								films.OrderByDescending(film => film.CharacterIds?.Count()),

							(Director, false) => 
								ordered?.ThenBy(film => film.Director) ??
								films.OrderBy(film => film.Director),
							(Director, true) => 
								ordered?.ThenByDescending(film => film.Director) ??
								films.OrderByDescending(film => film.Director),

							(Duration, false) => 
								ordered?.ThenBy(film => film.Duration) ??
								films.OrderBy(film => film.Duration),
							(Duration, true) => 
								ordered?.ThenByDescending(film => film.Duration) ??
								films.OrderByDescending(film => film.Duration),

							(EpisodeId, false) => 
								ordered?.ThenBy(film => film.EpisodeId) ??
								films.OrderBy(film => film.EpisodeId),
							(EpisodeId, true) => 
								ordered?.ThenByDescending(film => film.EpisodeId) ??
								films.OrderByDescending(film => film.EpisodeId),

							(FactionsCount, false) => 
								ordered?.ThenBy(film => film.FactionIds?.Count()) ??
								films.OrderBy(film => film.FactionIds?.Count()),
							(FactionsCount, true) => 
								ordered?.ThenByDescending(film => film.FactionIds?.Count()) ??
								films.OrderByDescending(film => film.FactionIds?.Count()),

							(ManufacturersCount, false) => 
								ordered?.ThenBy(film => film.ManufacturerIds?.Count()) ??
								films.OrderBy(film => film.ManufacturerIds?.Count()),
							(ManufacturersCount, true) => 
								ordered?.ThenByDescending(film => film.ManufacturerIds?.Count()) ??
								films.OrderByDescending(film => film.ManufacturerIds?.Count()),

							(PlanetsCount, false) => 
								ordered?.ThenBy(film => film.PlanetIds?.Count()) ??
								films.OrderBy(film => film.PlanetIds?.Count()),
							(PlanetsCount, true) => 
								ordered?.ThenByDescending(film => film.PlanetIds?.Count()) ??
								films.OrderByDescending(film => film.PlanetIds?.Count()),

							(ProducersCount, false) => 
								ordered?.ThenBy(film => film.Producers?.Count()) ??
								films.OrderBy(film => film.Producers?.Count()),
							(ProducersCount, true) => 
								ordered?.ThenByDescending(film => film.Producers?.Count()) ??
								films.OrderByDescending(film => film.Producers?.Count()),

							(ReleaseDate, false) => 
								ordered?.ThenBy(film => film.ReleaseDate) ??
								films.OrderBy(film => film.ReleaseDate),
							(ReleaseDate, true) => 
								ordered?.ThenByDescending(film => film.ReleaseDate) ??
								films.OrderByDescending(film => film.ReleaseDate),

							(SpeciesCount, false) => 
								ordered?.ThenBy(film => film.SpecieIds?.Count()) ??
								films.OrderBy(film => film.SpecieIds?.Count()),
							(SpeciesCount, true) => 
								ordered?.ThenByDescending(film => film.SpecieIds?.Count()) ??
								films.OrderByDescending(film => film.SpecieIds?.Count()),

							(StarshipsCount, false) => 
								ordered?.ThenBy(film => film.StarshipIds?.Count()) ??
								films.OrderBy(film => film.StarshipIds?.Count()),
							(StarshipsCount, true) => 
								ordered?.ThenByDescending(film => film.StarshipIds?.Count()) ??
								films.OrderByDescending(film => film.StarshipIds?.Count()),

							(Title, false) => 
								ordered?.ThenBy(film => film.Title) ??
								films.OrderBy(film => film.Title),
							(Title, true) => 
								ordered?.ThenByDescending(film => film.Title) ??
								films.OrderByDescending(film => film.Title),

							(VehiclesCount, false) => 
								ordered?.ThenBy(film => film.VehicleIds?.Count()) ??
								films.OrderBy(film => film.VehicleIds?.Count()),
							(VehiclesCount, true) => 
								ordered?.ThenByDescending(film => film.VehicleIds?.Count()) ??
								films.OrderByDescending(film => film.VehicleIds?.Count()),

							(WeaponsCount, false) => 
								ordered?.ThenBy(film => film.WeaponIds?.Count()) ??
								films.OrderBy(film => film.WeaponIds?.Count()),
							(WeaponsCount, true) => 
								ordered?.ThenByDescending(film => film.WeaponIds?.Count()) ??
								films.OrderByDescending(film => film.WeaponIds?.Count()),

							(_, _) => IStarWarsModel.ISortKeys.Keys.Sort(ordered ?? films, sorters),
						};

					return ordered ?? films.OrderBy(film => film);
				}
				public static IOrderedQueryable<IFilm> Sort(IQueryable<IFilm> films, params Sorter[] sorters)
				{
					IOrderedQueryable<IFilm>? ordered = null;

					foreach (Sorter sorter in sorters)
						ordered = (sorter.SortKey, sorter.Descending) switch
						{
							(CastMembersCount, false) => 
								ordered?.ThenBy(film => film.CastMembers != null ? film.CastMembers.Count() : 0) ??
								films.OrderBy(film => film.CastMembers != null ? film.CastMembers.Count() : 0),
							(CastMembersCount, true) => 
								ordered?.ThenByDescending(film => film.CastMembers != null ? film.CastMembers.Count() : 0) ??
								films.OrderByDescending(film => film.CastMembers != null ? film.CastMembers.Count() : 0),

							(CharactersCount, false) => 
								ordered?.ThenBy(film => film.CharacterIds != null ? film.CharacterIds.Count() : 0) ??
								films.OrderBy(film => film.CharacterIds != null ? film.CharacterIds.Count() : 0),
							(CharactersCount, true) => 
								ordered?.ThenByDescending(film => film.CharacterIds != null ? film.CharacterIds.Count() : 0) ??
								films.OrderByDescending(film => film.CharacterIds != null ? film.CharacterIds.Count() : 0),

							(Director, false) => 
								ordered?.ThenBy(film => film.Director) ??
								films.OrderBy(film => film.Director),
							(Director, true) => 
								ordered?.ThenByDescending(film => film.Director) ??
								films.OrderByDescending(film => film.Director),

							(Duration, false) => 
								ordered?.ThenBy(film => film.Duration) ??
								films.OrderBy(film => film.Duration),
							(Duration, true) => 
								ordered?.ThenByDescending(film => film.Duration) ??
								films.OrderByDescending(film => film.Duration),

							(EpisodeId, false) => 
								ordered?.ThenBy(film => film.EpisodeId) ??
								films.OrderBy(film => film.EpisodeId),
							(EpisodeId, true) => 
								ordered?.ThenByDescending(film => film.EpisodeId) ??
								films.OrderByDescending(film => film.EpisodeId),

							(FactionsCount, false) => 
								ordered?.ThenBy(film => film.FactionIds != null ? film.FactionIds.Count() : 0) ??
								films.OrderBy(film => film.FactionIds != null ? film.FactionIds.Count() : 0),
							(FactionsCount, true) => 
								ordered?.ThenByDescending(film => film.FactionIds != null ? film.FactionIds.Count() : 0) ??
								films.OrderByDescending(film => film.FactionIds != null ? film.FactionIds.Count() : 0),

							(ManufacturersCount, false) => 
								ordered?.ThenBy(film => film.ManufacturerIds != null ? film.ManufacturerIds.Count() : 0) ??
								films.OrderBy(film => film.ManufacturerIds != null ? film.ManufacturerIds.Count() : 0),
							(ManufacturersCount, true) => 
								ordered?.ThenByDescending(film => film.ManufacturerIds != null ? film.ManufacturerIds.Count() : 0) ??
								films.OrderByDescending(film => film.ManufacturerIds != null ? film.ManufacturerIds.Count() : 0),

							(PlanetsCount, false) => 
								ordered?.ThenBy(film => film.PlanetIds != null ? film.PlanetIds.Count() : 0) ??
								films.OrderBy(film => film.PlanetIds != null ? film.PlanetIds.Count() : 0),
							(PlanetsCount, true) => 
								ordered?.ThenByDescending(film => film.PlanetIds != null ? film.PlanetIds.Count() : 0) ??
								films.OrderByDescending(film => film.PlanetIds != null ? film.PlanetIds.Count() : 0),

							(ProducersCount, false) => 
								ordered?.ThenBy(film => film.Producers != null ? film.Producers.Count() : 0) ??
								films.OrderBy(film => film.Producers != null ? film.Producers.Count() : 0),
							(ProducersCount, true) => 
								ordered?.ThenByDescending(film => film.Producers != null ? film.Producers.Count() : 0) ??
								films.OrderByDescending(film => film.Producers != null ? film.Producers.Count() : 0),

							(ReleaseDate, false) => 
								ordered?.ThenBy(film => film.ReleaseDate) ??
								films.OrderBy(film => film.ReleaseDate),
							(ReleaseDate, true) => 
								ordered?.ThenByDescending(film => film.ReleaseDate) ??
								films.OrderByDescending(film => film.ReleaseDate),

							(SpeciesCount, false) => 
								ordered?.ThenBy(film => film.SpecieIds != null ? film.SpecieIds.Count() : 0) ??
								films.OrderBy(film => film.SpecieIds != null ? film.SpecieIds.Count() : 0),
							(SpeciesCount, true) => 
								ordered?.ThenByDescending(film => film.SpecieIds != null ? film.SpecieIds.Count() : 0) ??
								films.OrderByDescending(film => film.SpecieIds != null ? film.SpecieIds.Count() : 0),

							(StarshipsCount, false) => 
								ordered?.ThenBy(film => film.StarshipIds != null ? film.StarshipIds.Count() : 0) ??
								films.OrderBy(film => film.StarshipIds != null ? film.StarshipIds.Count() : 0),
							(StarshipsCount, true) => 
								ordered?.ThenByDescending(film => film.StarshipIds != null ? film.StarshipIds.Count() : 0) ??
								films.OrderByDescending(film => film.StarshipIds != null ? film.StarshipIds.Count() : 0),

							(Title, false) => 
								ordered?.ThenBy(film => film.Title) ??
								films.OrderBy(film => film.Title),
							(Title, true) => 
								ordered?.ThenByDescending(film => film.Title) ??
								films.OrderByDescending(film => film.Title),

							(VehiclesCount, false) => 
								ordered?.ThenBy(film => film.VehicleIds != null ? film.VehicleIds.Count() : 0) ??
								films.OrderBy(film => film.VehicleIds != null ? film.VehicleIds.Count() : 0),
							(VehiclesCount, true) => 
								ordered?.ThenByDescending(film => film.VehicleIds != null ? film.VehicleIds.Count() : 0) ??
								films.OrderByDescending(film => film.VehicleIds != null ? film.VehicleIds.Count() : 0),

							(WeaponsCount, false) => 
								ordered?.ThenBy(film => film.WeaponIds != null ? film.WeaponIds.Count() : 0) ??
								films.OrderBy(film => film.WeaponIds != null ? film.WeaponIds.Count() : 0),
							(WeaponsCount, true) => 
								ordered?.ThenByDescending(film => film.WeaponIds != null ? film.WeaponIds.Count() : 0) ??
								films.OrderByDescending(film => film.WeaponIds != null ? film.WeaponIds.Count() : 0),

							(_, _) => IStarWarsModel.ISortKeys.Keys.Sort(ordered ?? films, sorters),
						};

					return ordered ?? films.OrderBy(film => film);
				}
			}
			public new class Default : Default<string?>, ISortKeys
			{
				public Default() : base(null) { }
			}
			public new class Default<T> : IStarWarsModel.ISortKeys.Default<T>, ISortKeys<T>
			{
				public Default(T defaultvalue) : base(defaultvalue) 
				{
					CastMembersCount = defaultvalue;
					CharactersCount = defaultvalue;
					Director = defaultvalue;
					Duration = defaultvalue;
					EpisodeId = defaultvalue;
					FactionsCount = defaultvalue;
					ManufacturersCount = defaultvalue;
					PlanetsCount = defaultvalue;
					ProducersCount = defaultvalue;
					ReleaseDate = defaultvalue;
					SpeciesCount = defaultvalue;
					StarshipsCount = defaultvalue;
					Title = defaultvalue;
					VehiclesCount = defaultvalue;
					WeaponsCount = defaultvalue;
				}

				public T CastMembersCount { get; set; }
				public T CharactersCount { get; set; }
				public T Director { get; set; }
				public T Duration { get; set; }
				public T EpisodeId { get; set; }
				public T FactionsCount { get; set; }
				public T ManufacturersCount { get; set; }
				public T PlanetsCount { get; set; }
				public T ProducersCount { get; set; }
				public T ReleaseDate { get; set; }
				public T SpeciesCount { get; set; }
				public T StarshipsCount { get; set; }
				public T Title { get; set; }
				public T VehiclesCount { get; set; }
				public T WeaponsCount { get; set; }
			}
		}
	}
}
