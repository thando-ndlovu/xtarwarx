using Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Queries.Search
{
	public interface IFilmsSearchQuery<T> : IStarWarsModelSearchQuery<T>
	{
		T CastMembers { get; set; }
		T CharactersDescription { get; set; }
		T CharactersName { get; set; }
		T Description { get; set; }
		T Director { get; set; }
		T Durations { get; set; }
		T DurationRangeLower { get; set; }
		T DurationRangeUpper { get; set; }
		T EpisodeIds { get; set; }
		T EpisodeIdRangeLower { get; set; }
		T EpisodeIdRangeUpper { get; set; }
		T FactionsDescription { get; set; }
		T FactionsName { get; set; }
		T ManufacturersDescription { get; set; }
		T ManufacturersName { get; set; }
		T OpeningCrawl { get; set; }
		T PlanetsDescription { get; set; }
		T PlanetsName { get; set; }
		T Producers { get; set; }
		T ReleaseDates { get; set; }
		T ReleaseDateRangeLower { get; set; }
		T ReleaseDateRangeUpper { get; set; }
		T SpeciesDescription { get; set; }
		T SpeciesName { get; set; }
		T StarshipsDescription { get; set; }
		T StarshipsModel { get; set; }
		T StarshipsName { get; set; }
		T StarshipsStarshipClass { get; set; }
		T StarshipsStarshipClassFlags { get; set; }
		T Title { get; set; }
		T VehiclesDescription { get; set; }
		T VehiclesModel { get; set; }
		T VehiclesName { get; set; }
		T VehiclesVehicleClass { get; set; }
		T VehiclesVehicleClassFlags { get; set; }
		T WeaponsDescription { get; set; }
		T WeaponsModel { get; set; }
		T WeaponsName { get; set; }
		T WeaponsWeaponClass { get; set; }
		T WeaponsWeaponClassFlags { get; set; }

		public new IEnumerable<T> AsEnumerable()
		{
			return (this as IStarWarsModelSearchQuery<T>).AsEnumerable()
				.Append(CastMembers)
				.Append(CharactersDescription)
				.Append(CharactersName)
				.Append(Description)
				.Append(Director)
				.Append(Durations)
				.Append(DurationRangeLower)
				.Append(DurationRangeUpper)
				.Append(EpisodeIds)
				.Append(EpisodeIdRangeLower)
				.Append(EpisodeIdRangeUpper)
				.Append(FactionsDescription)
				.Append(FactionsName)
				.Append(ManufacturersDescription)
				.Append(ManufacturersName)
				.Append(OpeningCrawl)
				.Append(PlanetsDescription)
				.Append(PlanetsName)
				.Append(Producers)
				.Append(ReleaseDates)
				.Append(ReleaseDateRangeLower)
				.Append(ReleaseDateRangeUpper)
				.Append(SpeciesDescription)
				.Append(SpeciesName)
				.Append(StarshipsDescription)
				.Append(StarshipsModel)
				.Append(StarshipsName)
				.Append(StarshipsStarshipClass)
				.Append(StarshipsStarshipClassFlags)
				.Append(Title)
				.Append(VehiclesDescription)
				.Append(VehiclesModel)
				.Append(VehiclesName)
				.Append(VehiclesVehicleClass)
				.Append(VehiclesVehicleClassFlags)
				.Append(WeaponsDescription)
				.Append(WeaponsModel)
				.Append(WeaponsName)
				.Append(WeaponsWeaponClass)
				.Append(WeaponsWeaponClassFlags);
		}
	}
	public interface IFilmsSearchQuery : IStarWarsModelSearchQuery
	{
		bool? CastMembers { get; set; }
		bool? CharactersDescription { get; set; }
		bool? CharactersName { get; set; }
		bool? Description { get; set; }
		bool? Director { get; set; }
		TimeSpan?[]? Durations { get; set; }
		TimeSpan? DurationRangeLower { get; set; }
		TimeSpan? DurationRangeUpper { get; set; }
		int?[]? EpisodeIds { get; set; }
		int? EpisodeIdRangeLower { get; set; }
		int? EpisodeIdRangeUpper { get; set; }
		bool? FactionsDescription { get; set; }
		bool? FactionsName { get; set; }
		bool? ManufacturersDescription { get; set; }
		bool? ManufacturersName { get; set; }
		bool? OpeningCrawl { get; set; }
		bool? PlanetsDescription { get; set; }
		bool? PlanetsName { get; set; }
		bool? Producers { get; set; }
		DateTime?[]? ReleaseDates { get; set; }
		DateTime? ReleaseDateRangeLower { get; set; }
		DateTime? ReleaseDateRangeUpper { get; set; }
		bool? SpeciesDescription { get; set; }
		bool? SpeciesName { get; set; }
		bool? StarshipsDescription { get; set; }
		bool? StarshipsModel { get; set; }
		bool? StarshipsName { get; set; }
		bool? StarshipsStarshipClass { get; set; }
		bool? StarshipsStarshipClassFlags { get; set; }
		bool? Title { get; set; }
		bool? VehiclesDescription { get; set; }
		bool? VehiclesModel { get; set; }
		bool? VehiclesName { get; set; }
		bool? VehiclesVehicleClass { get; set; }
		bool? VehiclesVehicleClassFlags { get; set; }
		bool? WeaponsDescription { get; set; }
		bool? WeaponsModel { get; set; }
		bool? WeaponsName { get; set; }
		bool? WeaponsWeaponClass { get; set; }
		bool? WeaponsWeaponClassFlags { get; set; }

		public bool ShouldSearchCharacters()
		{
			return
				(CharactersDescription ?? false) ||
				(CharactersName ?? false);
		}
		public bool ShouldSearchFactions()
		{
			return
				(FactionsDescription ?? false) ||
				(FactionsName ?? false);
		}
		public bool ShouldSearchManufacturers()
		{
			return
				(ManufacturersDescription ?? false) ||
				(ManufacturersName ?? false);
		}
		public bool ShouldSearchPlanets()
		{
			return
				(PlanetsDescription ?? false) ||
				(PlanetsName ?? false);
		}
		public bool ShouldSearchSpecies()
		{
			return
				(SpeciesDescription ?? false) ||
				(SpeciesName ?? false);
		}
		public bool ShouldSearchStarships()
		{
			return
				(StarshipsDescription ?? false) ||
				(StarshipsModel ?? false) ||
				(StarshipsName ?? false) ||
				(StarshipsStarshipClass ?? false) ||
				(StarshipsStarshipClassFlags ?? false);
		}
		public bool ShouldSearchVehicles()
		{
			return
				(VehiclesDescription ?? false) ||
				(VehiclesModel ?? false) ||
				(VehiclesName ?? false) ||
				(VehiclesVehicleClass ?? false) ||
				(VehiclesVehicleClassFlags ?? false);
		}
		public bool ShouldSearchWeapons()
		{
			return
				(WeaponsDescription ?? false) ||
				(WeaponsModel ?? false) ||
				(WeaponsName ?? false) ||
				(WeaponsWeaponClass ?? false) ||
				(WeaponsWeaponClassFlags ?? false);
		}

		public IFilm.ISearch AsFilmSearch(string? searchstring = null)
		{
			return new IFilm.ISearch.Default
			{
				SearchString = searchstring,

				SearchContainables = new IFilm.ISearchContainables.Default
				{
					CastMembers = CastMembers ?? false,
					Description = Description ?? false,
					Director = Director ?? false,
					OpeningCrawl = OpeningCrawl ?? false,
					Producers = Producers ?? false,
					Title = Title ?? false,
				},

				Characters = new ICharacter.ISearchContainables.Default
				{
					Description = CharactersDescription ?? false,
					Name = CharactersName ?? false,
				},

				Durations = new IStarWarsModel.ISearchValues.Default<TimeSpan?>(default)
				{
					Lower = DurationRangeLower,
					Upper = DurationRangeUpper,
					Values = Durations,
				},

				EpisodeIds = new IStarWarsModel.ISearchValues.Default<int?>(default)
				{
					Lower = EpisodeIdRangeLower,
					Upper = EpisodeIdRangeUpper,
					Values = EpisodeIds,
				},

				Factions = new IFaction.ISearchContainables.Default
				{
					Description = FactionsDescription ?? false,
					Name = FactionsName ?? false,
				},

				Manufacturers = new IManufacturer.ISearchContainables.Default
				{
					Description = ManufacturersDescription ?? false,
					Name = ManufacturersName ?? false,
				},

				Planets = new IPlanet.ISearchContainables.Default
				{
					Description = PlanetsDescription ?? false,
					Name = PlanetsName ?? false,
				},

				ReleaseDates = new IStarWarsModel.ISearchValues.Default<DateTime?>(default)
				{
					Lower = ReleaseDateRangeLower,
					Upper = ReleaseDateRangeUpper,
					Values = ReleaseDates,
				},

				Species = new ISpecie.ISearchContainables.Default
				{
					Description = SpeciesDescription ?? false,
					Name = SpeciesName ?? false,
				},

				Starships = new IStarship.ISearchContainables.Default
				{
					Description = StarshipsDescription ?? false,
					Model = StarshipsModel ?? false,
					Name = StarshipsName ?? false,
					StarshipClass = StarshipsStarshipClass ?? false,
					StarshipClassFlags = StarshipsStarshipClassFlags ?? false,
				},

				Vehicles = new IVehicle.ISearchContainables.Default
				{
					Description = VehiclesDescription ?? false,
					Model = VehiclesModel ?? false,
					Name = VehiclesName ?? false,
					VehicleClass = VehiclesVehicleClass ?? false,
					VehicleClassFlags = VehiclesVehicleClassFlags ?? false,
				},

				Weapons = new IWeapon.ISearchContainables.Default
				{
					Description = WeaponsDescription ?? false,
					Model = WeaponsModel ?? false,
					Name = WeaponsName ?? false,
					WeaponClass = WeaponsWeaponClass ?? false,
					WeaponClassFlags = WeaponsWeaponClassFlags ?? false,
				},
			};
		}
		public IEnumerable<string> AsQueryData(IFilmsSearchQuery<string>? keys = null)
		{
			IEnumerable<string> querydata = AsQueryData(keys as IStarWarsModelSearchQuery<string>);

			if (CastMembers.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.CastMembers ?? nameof(CastMembers).ToLower(), CastMembers.Value));

			if (CharactersDescription.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.CharactersDescription ?? nameof(CharactersDescription).ToLower(), CharactersDescription.Value));

			if (CharactersName.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.CharactersName ?? nameof(CharactersName).ToLower(), CharactersName.Value));

			if (Description.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.Description ?? nameof(Description).ToLower(), Description.Value));

			if (Director.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.Director ?? nameof(Director).ToLower(), Director.Value));

			if (Durations != null)
				querydata = querydata.Concat(Durations.Select(passenger => string.Format("{0}={1}", keys?.Durations ?? nameof(Durations).ToLower(), passenger)));

			if (DurationRangeLower.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.DurationRangeLower ?? nameof(DurationRangeLower).ToLower(), DurationRangeLower.Value));

			if (DurationRangeUpper.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.DurationRangeUpper ?? nameof(DurationRangeUpper).ToLower(), DurationRangeUpper.Value));

			if (EpisodeIds != null)
				querydata = querydata.Concat(EpisodeIds.Select(passenger => string.Format("{0}={1}", keys?.EpisodeIds ?? nameof(EpisodeIds).ToLower(), passenger)));

			if (EpisodeIdRangeLower.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.EpisodeIdRangeLower ?? nameof(EpisodeIdRangeLower).ToLower(), EpisodeIdRangeLower.Value));

			if (EpisodeIdRangeUpper.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.EpisodeIdRangeUpper ?? nameof(EpisodeIdRangeUpper).ToLower(), EpisodeIdRangeUpper.Value));

			if (FactionsDescription.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.FactionsDescription ?? nameof(FactionsDescription).ToLower(), FactionsDescription.Value));

			if (FactionsName.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.FactionsName ?? nameof(FactionsName).ToLower(), FactionsName.Value));

			if (ManufacturersDescription.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.ManufacturersDescription ?? nameof(ManufacturersDescription).ToLower(), ManufacturersDescription.Value));

			if (ManufacturersName.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.ManufacturersName ?? nameof(ManufacturersName).ToLower(), ManufacturersName.Value));

			if (OpeningCrawl.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.OpeningCrawl ?? nameof(OpeningCrawl).ToLower(), OpeningCrawl.Value));

			if (PlanetsDescription.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.PlanetsDescription ?? nameof(PlanetsDescription).ToLower(), PlanetsDescription.Value));

			if (PlanetsName.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.PlanetsName ?? nameof(PlanetsName).ToLower(), PlanetsName.Value));

			if (Producers.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.Producers ?? nameof(Producers).ToLower(), Producers.Value));

			if (ReleaseDates != null)
				querydata = querydata.Concat(ReleaseDates.Select(passenger => string.Format("{0}={1}", keys?.ReleaseDates ?? nameof(ReleaseDates).ToLower(), passenger)));

			if (ReleaseDateRangeLower.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.ReleaseDateRangeLower ?? nameof(ReleaseDateRangeLower).ToLower(), ReleaseDateRangeLower.Value));

			if (ReleaseDateRangeUpper.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.ReleaseDateRangeUpper ?? nameof(ReleaseDateRangeUpper).ToLower(), ReleaseDateRangeUpper.Value));

			if (SpeciesDescription.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.SpeciesDescription ?? nameof(SpeciesDescription).ToLower(), SpeciesDescription.Value));

			if (SpeciesName.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.SpeciesName ?? nameof(SpeciesName).ToLower(), SpeciesName.Value));

			if (StarshipsDescription.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.StarshipsDescription ?? nameof(StarshipsDescription).ToLower(), StarshipsDescription.Value));

			if (StarshipsModel.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.StarshipsModel ?? nameof(StarshipsModel).ToLower(), StarshipsModel.Value));

			if (StarshipsName.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.StarshipsName ?? nameof(StarshipsName).ToLower(), StarshipsName.Value));

			if (StarshipsStarshipClass.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.StarshipsStarshipClass ?? nameof(StarshipsStarshipClass).ToLower(), StarshipsStarshipClass.Value));

			if (StarshipsStarshipClassFlags.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.StarshipsStarshipClassFlags ?? nameof(StarshipsStarshipClassFlags).ToLower(), StarshipsStarshipClassFlags.Value));

			if (Title.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.Title ?? nameof(Title).ToLower(), Title.Value));

			if (VehiclesDescription.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.VehiclesDescription ?? nameof(VehiclesDescription).ToLower(), VehiclesDescription.Value));

			if (VehiclesModel.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.VehiclesModel ?? nameof(VehiclesModel).ToLower(), VehiclesModel.Value));

			if (VehiclesName.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.VehiclesName ?? nameof(VehiclesName).ToLower(), VehiclesName.Value));

			if (VehiclesVehicleClass.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.VehiclesVehicleClass ?? nameof(VehiclesVehicleClass).ToLower(), VehiclesVehicleClass.Value));

			if (VehiclesVehicleClassFlags.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.VehiclesVehicleClassFlags ?? nameof(VehiclesVehicleClassFlags).ToLower(), VehiclesVehicleClassFlags.Value));

			if (WeaponsDescription.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.WeaponsDescription ?? nameof(WeaponsDescription).ToLower(), WeaponsDescription.Value));

			if (WeaponsModel.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.WeaponsModel ?? nameof(WeaponsModel).ToLower(), WeaponsModel.Value));

			if (WeaponsName.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.WeaponsName ?? nameof(WeaponsName).ToLower(), WeaponsName.Value));

			if (WeaponsWeaponClass.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.WeaponsWeaponClass ?? nameof(WeaponsWeaponClass).ToLower(), WeaponsWeaponClass.Value));

			if (WeaponsWeaponClassFlags.HasValue)
				querydata = querydata.Append(string.Format("{0}={1}", keys?.WeaponsWeaponClassFlags ?? nameof(WeaponsWeaponClassFlags).ToLower(), WeaponsWeaponClassFlags.Value));


			return querydata;
		}

		public new class Default : IStarWarsModelSearchQuery.Default, IFilmsSearchQuery
		{
			public Default() : base() { }
			public Default(IFilm.ISearch filmsearch) : base(filmsearch)
			{
				CastMembers = filmsearch.SearchContainables?.CastMembers;
				Description = filmsearch.SearchContainables?.Description;
				Director = filmsearch.SearchContainables?.Director;
				OpeningCrawl = filmsearch.SearchContainables?.OpeningCrawl;
				Producers = filmsearch.SearchContainables?.Producers;
				Title = filmsearch.SearchContainables?.Title;

				CharactersDescription = filmsearch.Characters?.Description;
				CharactersName = filmsearch.Characters?.Name;

				Durations = filmsearch.Durations?.Values?.ToArray();
				DurationRangeLower = filmsearch.Durations?.Lower;
				DurationRangeUpper = filmsearch.Durations?.Upper;

				EpisodeIds = filmsearch.EpisodeIds?.Values?.ToArray();
				EpisodeIdRangeLower = filmsearch.EpisodeIds?.Lower;
				EpisodeIdRangeUpper = filmsearch.EpisodeIds?.Upper;

				FactionsDescription = filmsearch.Factions?.Description;
				FactionsName = filmsearch.Factions?.Name;

				ManufacturersDescription = filmsearch.Manufacturers?.Description;
				ManufacturersName = filmsearch.Manufacturers?.Name;

				PlanetsDescription = filmsearch.Planets?.Description;
				PlanetsName = filmsearch.Planets?.Name;

				ReleaseDates = filmsearch.ReleaseDates?.Values?.ToArray();
				ReleaseDateRangeLower = filmsearch.ReleaseDates?.Lower;
				ReleaseDateRangeUpper = filmsearch.ReleaseDates?.Upper;

				SpeciesDescription = filmsearch.Species?.Description;
				SpeciesName = filmsearch.Species?.Name;

				StarshipsDescription = filmsearch.Starships?.Description;
				StarshipsModel = filmsearch.Starships?.Model;
				StarshipsName = filmsearch.Starships?.Name;
				StarshipsStarshipClass = filmsearch.Starships?.StarshipClass;
				StarshipsStarshipClassFlags = filmsearch.Starships?.StarshipClassFlags;

				VehiclesDescription = filmsearch.Vehicles?.Description;
				VehiclesModel = filmsearch.Vehicles?.Model;
				VehiclesName = filmsearch.Vehicles?.Name;
				VehiclesVehicleClass = filmsearch.Vehicles?.VehicleClass;
				VehiclesVehicleClassFlags = filmsearch.Vehicles?.VehicleClassFlags;

				WeaponsDescription = filmsearch.Weapons?.Description;
				WeaponsModel = filmsearch.Weapons?.Model;
				WeaponsName = filmsearch.Weapons?.Name;
				WeaponsWeaponClass = filmsearch.Weapons?.WeaponClass;
				WeaponsWeaponClassFlags = filmsearch.Weapons?.WeaponClassFlags;
			}

			public bool? CastMembers { get; set; }
			public bool? CharactersDescription { get; set; }
			public bool? CharactersName { get; set; }
			public bool? Description { get; set; }
			public bool? Director { get; set; }
			public TimeSpan?[]? Durations { get; set; }
			public TimeSpan? DurationRangeLower { get; set; }
			public TimeSpan? DurationRangeUpper { get; set; }
			public int?[]? EpisodeIds { get; set; }
			public int? EpisodeIdRangeLower { get; set; }
			public int? EpisodeIdRangeUpper { get; set; }
			public bool? FactionsDescription { get; set; }
			public bool? FactionsName { get; set; }
			public bool? ManufacturersDescription { get; set; }
			public bool? ManufacturersName { get; set; }
			public bool? OpeningCrawl { get; set; }
			public bool? PlanetsDescription { get; set; }
			public bool? PlanetsName { get; set; }
			public bool? Producers { get; set; }
			public DateTime?[]? ReleaseDates { get; set; }
			public DateTime? ReleaseDateRangeLower { get; set; }
			public DateTime? ReleaseDateRangeUpper { get; set; }
			public bool? SpeciesDescription { get; set; }
			public bool? SpeciesName { get; set; }
			public bool? StarshipsDescription { get; set; }
			public bool? StarshipsModel { get; set; }
			public bool? StarshipsName { get; set; }
			public bool? StarshipsStarshipClass { get; set; }
			public bool? StarshipsStarshipClassFlags { get; set; }
			public bool? Title { get; set; }
			public bool? VehiclesDescription { get; set; }
			public bool? VehiclesModel { get; set; }
			public bool? VehiclesName { get; set; }
			public bool? VehiclesVehicleClass { get; set; }
			public bool? VehiclesVehicleClassFlags { get; set; }
			public bool? WeaponsDescription { get; set; }
			public bool? WeaponsModel { get; set; }
			public bool? WeaponsName { get; set; }
			public bool? WeaponsWeaponClass { get; set; }
			public bool? WeaponsWeaponClassFlags { get; set; }
		}
		public new class Default<T> : IStarWarsModelSearchQuery.Default<T>, IFilmsSearchQuery<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				CastMembers = defaultvalue;
				CharactersDescription = defaultvalue;
				CharactersName = defaultvalue;
				Description = defaultvalue;
				Director = defaultvalue;
				Durations = defaultvalue;
				DurationRangeLower = defaultvalue;
				DurationRangeUpper = defaultvalue;
				EpisodeIds = defaultvalue;
				EpisodeIdRangeLower = defaultvalue;
				EpisodeIdRangeUpper = defaultvalue;
				FactionsDescription = defaultvalue;
				FactionsName = defaultvalue;
				ManufacturersDescription = defaultvalue;
				ManufacturersName = defaultvalue;
				OpeningCrawl = defaultvalue;
				PlanetsDescription = defaultvalue;
				PlanetsName = defaultvalue;
				Producers = defaultvalue;
				ReleaseDates = defaultvalue;
				ReleaseDateRangeLower = defaultvalue;
				ReleaseDateRangeUpper = defaultvalue;
				SpeciesDescription = defaultvalue;
				SpeciesName = defaultvalue;
				StarshipsDescription = defaultvalue;
				StarshipsModel = defaultvalue;
				StarshipsName = defaultvalue;
				StarshipsStarshipClass = defaultvalue;
				StarshipsStarshipClassFlags = defaultvalue;
				Title = defaultvalue;
				VehiclesDescription = defaultvalue;
				VehiclesModel = defaultvalue;
				VehiclesName = defaultvalue;
				VehiclesVehicleClass = defaultvalue;
				VehiclesVehicleClassFlags = defaultvalue;
				WeaponsDescription = defaultvalue;
				WeaponsModel = defaultvalue;
				WeaponsName = defaultvalue;
				WeaponsWeaponClass = defaultvalue;
				WeaponsWeaponClassFlags = defaultvalue;
			}

			public T CastMembers { get; set; }
			public T CharactersDescription { get; set; }
			public T CharactersName { get; set; }
			public T Description { get; set; }
			public T Director { get; set; }
			public T Durations { get; set; }
			public T DurationRangeLower { get; set; }
			public T DurationRangeUpper { get; set; }
			public T EpisodeIds { get; set; }
			public T EpisodeIdRangeLower { get; set; }
			public T EpisodeIdRangeUpper { get; set; }
			public T FactionsDescription { get; set; }
			public T FactionsName { get; set; }
			public T ManufacturersDescription { get; set; }
			public T ManufacturersName { get; set; }
			public T OpeningCrawl { get; set; }
			public T PlanetsDescription { get; set; }
			public T PlanetsName { get; set; }
			public T Producers { get; set; }
			public T ReleaseDates { get; set; }
			public T ReleaseDateRangeLower { get; set; }
			public T ReleaseDateRangeUpper { get; set; }
			public T SpeciesDescription { get; set; }
			public T SpeciesName { get; set; }
			public T StarshipsDescription { get; set; }
			public T StarshipsModel { get; set; }
			public T StarshipsName { get; set; }
			public T StarshipsStarshipClass { get; set; }
			public T StarshipsStarshipClassFlags { get; set; }
			public T Title { get; set; }
			public T VehiclesDescription { get; set; }
			public T VehiclesModel { get; set; }
			public T VehiclesName { get; set; }
			public T VehiclesVehicleClass { get; set; }
			public T VehiclesVehicleClassFlags { get; set; }
			public T WeaponsDescription { get; set; }
			public T WeaponsModel { get; set; }
			public T WeaponsName { get; set; }
			public T WeaponsWeaponClass { get; set; }
			public T WeaponsWeaponClassFlags { get; set; }
		}
	}
}
