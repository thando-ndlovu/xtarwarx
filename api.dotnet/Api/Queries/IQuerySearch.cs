using Api.Queries.Search;

using Domain.Enums;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Api.Queries
{
	public interface IQuerySearch<T> : IQuery<T>
	{
		T SearchString { get; set; }
		T Characters { get; set; }
		T Factions { get; set; }
		T Films { get; set; }
		T Manufacturers { get; set; }
		T Planets { get; set; }
		T Species { get; set; }
		T Starships { get; set; }
		T Vehicles { get; set; }
		T Weapons { get; set; }
	}
	public interface IQuerySearchTyped<T> : IQueryTyped<T>
	{
		T SearchString { get; set; }
		ICharactersSearchQuery<T>? Characters { get; set; }
		IFactionsSearchQuery<T>? Factions { get; set; }
		IFilmsSearchQuery<T>? Films { get; set; }
		IManufacturersSearchQuery<T>? Manufacturers { get; set; }
		IPlanetsSearchQuery<T>? Planets { get; set; }
		ISpeciesSearchQuery<T>? Species { get; set; }
		IStarshipsSearchQuery<T>? Starships { get; set; }
		IVehiclesSearchQuery<T>? Vehicles { get; set; }
		IWeaponsSearchQuery<T>? Weapons { get; set; }
	}
	public interface IQuerySearch : IQuery
	{
		string? SearchString { get; set; }
		ICharactersSearchQuery? Characters { get; set; }
		IFactionsSearchQuery? Factions { get; set; }
		IFilmsSearchQuery? Films { get; set; }
		IManufacturersSearchQuery? Manufacturers { get; set; }
		IPlanetsSearchQuery? Planets { get; set; }
		ISpeciesSearchQuery? Species { get; set; }
		IStarshipsSearchQuery? Starships { get; set; }
		IVehiclesSearchQuery? Vehicles { get; set; }
		IWeaponsSearchQuery? Weapons { get; set; }

		public new interface IResult : IResult<IQuerySearchResult>
		{
			public class Default<T> : IQuery.IResult.Default<T>, IResult<T> { }
			public class Default : IQuery.IResult.Default<IQuerySearchResult>, IResult<IQuerySearchResult>, IResult { }
		}

		public new class Default : IQuery.Default, IQuerySearch
		{
			public string? SearchString { get; set; }
			public ICharactersSearchQuery? Characters { get; set; }
			public IFactionsSearchQuery? Factions { get; set; }
			public IFilmsSearchQuery? Films { get; set; }
			public IManufacturersSearchQuery? Manufacturers { get; set; }
			public IPlanetsSearchQuery? Planets { get; set; }
			public ISpeciesSearchQuery? Species { get; set; }
			public IStarshipsSearchQuery? Starships { get; set; }
			public IVehiclesSearchQuery? Vehicles { get; set; }
			public IWeaponsSearchQuery? Weapons { get; set; }
		}
		public new class Default<T> : IQuery.Default<T>, IQuerySearch<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				SearchString = defaultvalue;
				Characters = defaultvalue;
				Factions = defaultvalue;
				Films = defaultvalue;
				Manufacturers = defaultvalue;
				Planets = defaultvalue;
				Species = defaultvalue;
				Starships = defaultvalue;
				Vehicles = defaultvalue;
				Weapons = defaultvalue;
			}

			public T SearchString { get; set; }
			public T Characters { get; set; }
			public T Factions { get; set; }
			public T Films { get; set; }
			public T Manufacturers { get; set; }
			public T Planets { get; set; }
			public T Species { get; set; }
			public T Starships { get; set; }
			public T Vehicles { get; set; }
			public T Weapons { get; set; }
		}
		public new class DefaultTyped<T> : IQuery.DefaultTyped<T> , IQuerySearchTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue) 
			{
				SearchString = defaultvalue;
			}

			public T SearchString { get; set; }
			public ICharactersSearchQuery<T>? Characters { get; set; }
			public IFactionsSearchQuery<T>? Factions { get; set; }
			public IFilmsSearchQuery<T>? Films { get; set; }
			public IManufacturersSearchQuery<T>? Manufacturers { get; set; }
			public IPlanetsSearchQuery<T>? Planets { get; set; }
			public ISpeciesSearchQuery<T>? Species { get; set; }
			public IStarshipsSearchQuery<T>? Starships { get; set; }
			public IVehiclesSearchQuery<T>? Vehicles { get; set; }
			public IWeaponsSearchQuery<T>? Weapons { get; set; }
		}
	}

	public interface IQuerySearchResult<T>
	{
		T Id { get; set; }
		T MatchCount { get; set; }
		T StarWarsType { get; set; }
	}
	public interface IQuerySearchResultTyped<T> : IQuerySearchResult<T> { }
	public interface IQuerySearchResult
	{
		int Id { get; set; }
		int MatchCount { get; set; }
		StarWarsTypes StarWarsType { get; set; }

		public class Default : IQuerySearchResult
		{
			public int Id { get; set; }
			public int MatchCount { get; set; }
			public StarWarsTypes StarWarsType { get; set; }
		}
		public class Default<T> : IQuerySearchResult<T>
		{
			public Default(T defaultvalue)
			{
				Id = defaultvalue;
				MatchCount = defaultvalue;
				StarWarsType = defaultvalue;
			}

			public T Id { get; set; }
			public T MatchCount { get; set; }
			public T StarWarsType { get; set; }
		}
		public class DefaultTyped<T> : Default<T>, IQuerySearchResultTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue) { }
		}
	}
}
