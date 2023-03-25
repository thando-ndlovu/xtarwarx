using Domain.Models;

using Newtonsoft.Json.Linq;

using System;
using System.Linq;
using System.Collections.Generic;

namespace Api.Queries.Retrievers
{
	public interface IFilmRetriever<T> : IStarWarsModelRetriever<T>, IFilm<T> 
	{
		T Characters { get; set; }
		T Factions { get; set; }
		T Manufacturers { get; set; }
		T Planets { get; set; }
		T Species { get; set; }
		T Starships { get; set; }
		T Vehicles { get; set; }
		T Weapons { get; set; }
	}						  
	public interface IFilmRetrieverTyped<T> : IStarWarsModelRetrieverTyped<T>, IFilmTyped<T> 
	{
		ICharacterRetrieverTyped<T>? Characters { get; set; }
		IFactionRetrieverTyped<T>? Factions { get; set; }
		IManufacturerRetrieverTyped<T>? Manufacturers { get; set; }
		IPlanetRetrieverTyped<T>? Planets { get; set; }
		ISpecieRetrieverTyped<T>? Species { get; set; }
		IStarshipRetrieverTyped<T>? Starships { get; set; }
		IVehicleRetrieverTyped<T>? Vehicles { get; set; }
		IWeaponRetrieverTyped<T>? Weapons { get; set; }
	}
	public interface IFilmRetriever : IStarWarsModelRetriever, IFilmRetrieverTyped<bool>
	{
		public new interface IRetrieved<T> : IStarWarsModelRetriever.IRetrieved<T>, IFilm<T> 
		{
			T Characters { get; set; }
			T Factions { get; set; }
			T Manufacturers { get; set; }
			T Planets { get; set; }
			T Species { get; set; }
			T Starships { get; set; }
			T Vehicles { get; set; }
			T Weapons { get; set; }
		}
		public new interface IRetrieved : IStarWarsModelRetriever.IRetrieved, IFilm
		{
			IEnumerable<ICharacterRetriever.IRetrieved>? Characters { get; set; }
			IEnumerable<IFactionRetriever.IRetrieved>? Factions { get; set; }
			IEnumerable<IManufacturerRetriever.IRetrieved>? Manufacturers { get; set; }
			IEnumerable<IPlanetRetriever.IRetrieved>? Planets { get; set; }
			IEnumerable<ISpecieRetriever.IRetrieved>? Species { get; set; }
			IEnumerable<IStarshipRetriever.IRetrieved>? Starships { get; set; }
			IEnumerable<IVehicleRetriever.IRetrieved>? Vehicles { get; set; }
			IEnumerable<IWeaponRetriever.IRetrieved>? Weapons { get; set; }

			public new class Default : IFilm.Default, IRetrieved
			{
				public Default(int id) : base(id) { }
				public Default(int id, JObject jobject) : base(id, jobject) 
				{
					Characters = jobject.GetValue(nameof(Characters), StringComparison.OrdinalIgnoreCase)?
						.ToObject<JArray?>()?
						.Select(jtoken =>
						{
							if (jtoken.Value<int?>(nameof(Id)) is int id)
								return new ICharacterRetriever.IRetrieved.Default(id, JObject.FromObject(jtoken));

							return null;

						}).OfType<ICharacterRetriever.IRetrieved>(); 
					Factions = jobject.GetValue(nameof(Factions), StringComparison.OrdinalIgnoreCase)?
						.ToObject<JArray?>()?
						.Select(jtoken =>
						{
							if (jtoken.Value<int?>(nameof(Id)) is int id)
								return new IFactionRetriever.IRetrieved.Default(id, JObject.FromObject(jtoken));

							return null;

						}).OfType<IFactionRetriever.IRetrieved>(); 
					Manufacturers = jobject.GetValue(nameof(Manufacturers), StringComparison.OrdinalIgnoreCase)?
						.ToObject<JArray?>()?
						.Select(jtoken =>
						{
							if (jtoken.Value<int?>(nameof(Id)) is int id)
								return new IManufacturerRetriever.IRetrieved.Default(id, JObject.FromObject(jtoken));

							return null;

						}).OfType<IManufacturerRetriever.IRetrieved>(); 
					Planets = jobject.GetValue(nameof(Planets), StringComparison.OrdinalIgnoreCase)?
						.ToObject<JArray?>()?
						.Select(jtoken =>
						{
							if (jtoken.Value<int?>(nameof(Id)) is int id)
								return new IPlanetRetriever.IRetrieved.Default(id, JObject.FromObject(jtoken));

							return null;

						}).OfType<IPlanetRetriever.IRetrieved>(); 
					Species = jobject.GetValue(nameof(Species), StringComparison.OrdinalIgnoreCase)?
						.ToObject<JArray?>()?
						.Select(jtoken =>
						{
							if (jtoken.Value<int?>(nameof(Id)) is int id)
								return new ISpecieRetriever.IRetrieved.Default(id, JObject.FromObject(jtoken));

							return null;

						}).OfType<ISpecieRetriever.IRetrieved>(); 
					Starships = jobject.GetValue(nameof(Starships), StringComparison.OrdinalIgnoreCase)?
						.ToObject<JArray?>()?
						.Select(jtoken =>
						{
							if (jtoken.Value<int?>(nameof(Id)) is int id)
								return new IStarshipRetriever.IRetrieved.Default(id, JObject.FromObject(jtoken));

							return null;

						}).OfType<IStarshipRetriever.IRetrieved>(); 
					Vehicles = jobject.GetValue(nameof(Vehicles), StringComparison.OrdinalIgnoreCase)?
						.ToObject<JArray?>()?
						.Select(jtoken =>
						{
							if (jtoken.Value<int?>(nameof(Id)) is int id)
								return new IVehicleRetriever.IRetrieved.Default(id, JObject.FromObject(jtoken));

							return null;

						}).OfType<IVehicleRetriever.IRetrieved>(); 
					Weapons = jobject.GetValue(nameof(Weapons), StringComparison.OrdinalIgnoreCase)?
						.ToObject<JArray?>()?
						.Select(jtoken =>
						{
							if (jtoken.Value<int?>(nameof(Id)) is int id)
								return new IWeaponRetriever.IRetrieved.Default(id, JObject.FromObject(jtoken));

							return null;

						}).OfType<IWeaponRetriever.IRetrieved>();
				}
				public Default(IFilm film) : base(film.Id) 
				{
					CastMembers = film.CastMembers;
					CharacterIds = film.CharacterIds;
					Description = film.Description;
					Director = film.Director;
					Duration = film.Duration;
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
					VehicleIds = film.VehicleIds;
					WeaponIds = film.WeaponIds;
				}

				public IEnumerable<ICharacterRetriever.IRetrieved>? Characters { get; set; }
				public IEnumerable<IFactionRetriever.IRetrieved>? Factions { get; set; }
				public IEnumerable<IManufacturerRetriever.IRetrieved>? Manufacturers { get; set; }
				public IEnumerable<IPlanetRetriever.IRetrieved>? Planets { get; set; }
				public IEnumerable<ISpecieRetriever.IRetrieved>? Species { get; set; }
				public IEnumerable<IStarshipRetriever.IRetrieved>? Starships { get; set; }
				public IEnumerable<IVehicleRetriever.IRetrieved>? Vehicles { get; set; }
				public IEnumerable<IWeaponRetriever.IRetrieved>? Weapons { get; set; }
			}
			public new class Default<T> : IFilm.Default<T>, IRetrieved<T>
			{
				public Default(T defaultvalue) : base(defaultvalue) 
				{
					Characters = defaultvalue;
					Factions = defaultvalue;
					Manufacturers = defaultvalue;
					Planets = defaultvalue;
					Species = defaultvalue;
					Starships = defaultvalue;
					Vehicles = defaultvalue;
					Weapons = defaultvalue;
				}

				public T Characters { get; set; }
				public T Factions { get; set; }
				public T Manufacturers { get; set; }
				public T Planets { get; set; }
				public T Species { get; set; }
				public T Starships { get; set; }
				public T Vehicles { get; set; }
				public T Weapons { get; set; }
			}
		}

		public new class Default : DefaultTyped<bool>, IFilmRetriever
		{
			public Default(bool defaultvalue) : base(defaultvalue) { }

			public IPagination? Pagination { get; set; }
		}
		public new class Default<T> : IFilm.Default<T>, IFilmRetriever<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				Characters = defaultvalue;
				Factions = defaultvalue;
				Manufacturers = defaultvalue;
				Planets = defaultvalue;
				Species = defaultvalue;
				Starships = defaultvalue;
				Vehicles = defaultvalue;
				Weapons = defaultvalue;
			}

			public T Characters { get; set; }
			public T Factions { get; set; }
			public T Manufacturers { get; set; }
			public T Planets { get; set; }
			public T Species { get; set; }
			public T Starships { get; set; }
			public T Vehicles { get; set; }
			public T Weapons { get; set; }
		}  					  
		public new class DefaultTyped<T> : IFilm.DefaultTyped<T>, IFilmRetrieverTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue) { }

			public ICharacterRetrieverTyped<T>? Characters { get; set; }
			public IFactionRetrieverTyped<T>? Factions { get; set; }
			public IManufacturerRetrieverTyped<T>? Manufacturers { get; set; }
			public IPlanetRetrieverTyped<T>? Planets { get; set; }
			public ISpecieRetrieverTyped<T>? Species { get; set; }
			public IStarshipRetrieverTyped<T>? Starships { get; set; }
			public IVehicleRetrieverTyped<T>? Vehicles { get; set; }
			public IWeaponRetrieverTyped<T>? Weapons { get; set; }
		}
	}
}
