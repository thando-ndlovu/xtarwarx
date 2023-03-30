using Api.Queries;
using Api.Queries.Search;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

using Repository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Controllers
{
	[Controller]
	public partial class RestController : Controller
	{
		public RestController(IServiceProvider serviceProvider)
		{
			ServiceProvider = serviceProvider;
		}

		protected IServiceProvider ServiceProvider { get; }

		[HttpGet(Routes.Rest)]
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet(Routes.Api_Rest_Search)]
		public async Task<IQuerySearch.IResult> Search([FromQuery] IQuerySearch.Default query, CancellationToken cancellationToken = default)
		{
			bool IsDefaultSearch =
				query.Characters == null &&
				query.Factions == null &&
				query.Films == null &&
				query.Manufacturers == null &&
				query.Planets == null &&
				query.Species == null &&
				query.Starships == null &&
				query.Vehicles == null &&
				query.Weapons == null;

			if (IsDefaultSearch && string.IsNullOrWhiteSpace(query.SearchString)) { }
			else if (IsDefaultSearch)
			{
				query.Characters ??= new ICharactersSearchQuery.Default
				{
					SearchString = query.SearchString,
					Name = true,
				};
				query.Factions ??= new IFactionsSearchQuery.Default
				{
					SearchString = query.SearchString,
					Name = true,
				};
				query.Films ??= new IFilmsSearchQuery.Default
				{
					SearchString = query.SearchString,
					Title = true,
				};
				query.Manufacturers ??= new IManufacturersSearchQuery.Default
				{
					SearchString = query.SearchString,
					Name = true,
				};
				query.Planets ??= new IPlanetsSearchQuery.Default
				{
					SearchString = query.SearchString,
					Name = true,
				};
				query.Species ??= new ISpeciesSearchQuery.Default
				{
					SearchString = query.SearchString,
					Name = true,
				};
				query.Starships ??= new IStarshipsSearchQuery.Default
				{
					SearchString = query.SearchString,
					Name = true,
				};
				query.Vehicles ??= new IVehiclesSearchQuery.Default
				{
					SearchString = query.SearchString,
					Name = true,
				};
				query.Weapons ??= new IWeaponsSearchQuery.Default
				{
					SearchString = query.SearchString,
					Name = true,
				};
			}

			IRepository repository = ServiceProvider.GetRequiredService<IRepository>();

			IEnumerable<IQuerySearchResult>? charactersearchresults = query.Characters?.GetQuerySearchResults(repository.Characters.AsQueryable(), repository);
			IEnumerable<IQuerySearchResult>? factionsearchresults = query.Factions?.GetQuerySearchResults(repository.Factions.AsQueryable(), repository);
			IEnumerable<IQuerySearchResult>? filmsearchresults = query.Films?.GetQuerySearchResults(repository.Films.AsQueryable(), repository);
			IEnumerable<IQuerySearchResult>? manufacturersearchresults = query.Manufacturers?.GetQuerySearchResults(repository.Manufacturers.AsQueryable(), repository);
			IEnumerable<IQuerySearchResult>? planetsearchresults = query.Planets?.GetQuerySearchResults(repository.Planets.AsQueryable(), repository);
			IEnumerable<IQuerySearchResult>? speciessearchresults = query.Species?.GetQuerySearchResults(repository.Species.AsQueryable(), repository);
			IEnumerable<IQuerySearchResult>? starshipsearchresults = query.Starships?.GetQuerySearchResults(repository.Starships.AsQueryable(), repository);
			IEnumerable<IQuerySearchResult>? vehiclesearchresults = query.Vehicles?.GetQuerySearchResults(repository.Vehicles.AsQueryable(), repository);
			IEnumerable<IQuerySearchResult>? weaponsearchresults = query.Weapons?.GetQuerySearchResults(repository.Weapons.AsQueryable(), repository);

			IEnumerable<IQuerySearchResult> searchresults = Enumerable.Empty<IQuerySearchResult>()
				.Concat(charactersearchresults ?? Enumerable.Empty<IQuerySearchResult>())
				.Concat(factionsearchresults ?? Enumerable.Empty<IQuerySearchResult>())
				.Concat(filmsearchresults ?? Enumerable.Empty<IQuerySearchResult>())
				.Concat(manufacturersearchresults ?? Enumerable.Empty<IQuerySearchResult>())
				.Concat(planetsearchresults ?? Enumerable.Empty<IQuerySearchResult>())
				.Concat(speciessearchresults ?? Enumerable.Empty<IQuerySearchResult>())
				.Concat(starshipsearchresults ?? Enumerable.Empty<IQuerySearchResult>())
				.Concat(vehiclesearchresults ?? Enumerable.Empty<IQuerySearchResult>())
				.Concat(weaponsearchresults ?? Enumerable.Empty<IQuerySearchResult>());

			IQuerySearch.IResult result = query.ProcessQuerySearch(searchresults);

			return await Task.FromResult(result);
		}

		[HttpGet(Routes.Api_Rest_Characters)]
		public async Task<IQuery.IResult<object>> Characters([FromQuery] IQuery.Default query, CancellationToken cancellationToken = default)
		{
			IQuery.IResult<object> result = query.ProcessCharactersAsObject(
				 characters: ServiceProvider
					.GetRequiredService<IRepository>()
					.Characters
					.AsQueryable());

			return await Task.FromResult(result);
		}

		[HttpGet(Routes.Api_Rest_Factions)]
		public async Task<IQuery.IResult<object>> Factions([FromQuery] IQuery.Default query, CancellationToken cancellationToken = default)
		{
			IQuery.IResult<object> result = query.ProcessFactionsAsObject(
				 factions: ServiceProvider
					.GetRequiredService<IRepository>()
					.Factions
					.AsQueryable());

			return await Task.FromResult(result);
		}

		[HttpGet(Routes.Api_Rest_Films)]
		public async Task<IQuery.IResult<object>> Films([FromQuery] IQuery.Default query, CancellationToken cancellationToken = default)
		{
			IQuery.IResult<object> result = query.ProcessFilmsAsObject(
				 films: ServiceProvider
					.GetRequiredService<IRepository>()
					.Films
					.AsQueryable());

			return await Task.FromResult(result);
		}

		[HttpGet(Routes.Api_Rest_Manufacturers)]
		public async Task<IQuery.IResult<object>> Manufacturers([FromQuery] IQuery.Default query, CancellationToken cancellationToken = default)
		{
			IQuery.IResult<object> result = query.ProcessManufacturersAsObject(
				 manufacturers: ServiceProvider
					.GetRequiredService<IRepository>()
					.Manufacturers
					.AsQueryable());

			return await Task.FromResult(result);
		}

		[HttpGet(Routes.Api_Rest_Planets)]
		public async Task<IQuery.IResult<object>> Planets([FromQuery] IQuery.Default query, CancellationToken cancellationToken = default)
		{
			IQuery.IResult<object> result = query.ProcessPlanetsAsObject(
				 planets: ServiceProvider
					.GetRequiredService<IRepository>()
					.Planets
					.AsQueryable());

			return await Task.FromResult(result);
		}

		[HttpGet(Routes.Api_Rest_Species)]
		public async Task<IQuery.IResult<object>> Species([FromQuery] IQuery.Default query, CancellationToken cancellationToken = default)
		{
			IQuery.IResult<object> result = query.ProcessSpeciesAsObject(
				 species: ServiceProvider
					.GetRequiredService<IRepository>()
					.Species
					.AsQueryable());

			return await Task.FromResult(result);
		}

		[HttpGet(Routes.Api_Rest_Starships)]
		public async Task<IQuery.IResult<object>> Starships([FromQuery] IQuery.Default query, CancellationToken cancellationToken = default)
		{
			IQuery.IResult<object> result = query.ProcessStarshipsAsObject(
				 starships: ServiceProvider
					.GetRequiredService<IRepository>()
					.Starships
					.AsQueryable());

			return await Task.FromResult(result);
		}

		[HttpGet(Routes.Api_Rest_Vehicles)]
		public async Task<IQuery.IResult<object>> Vehicles([FromQuery] IQuery.Default query, CancellationToken cancellationToken = default)
		{
			IQuery.IResult<object> result = query.ProcessVehiclesAsObject(
				 vehicles: ServiceProvider
					.GetRequiredService<IRepository>()
					.Vehicles
					.AsQueryable());

			return await Task.FromResult(result);
		}

		[HttpGet(Routes.Api_Rest_Weapons)]
		public async Task<IQuery.IResult<object>> Weapons([FromQuery] IQuery.Default query, CancellationToken cancellationToken = default)
		{
			IQuery.IResult<object> result = query.ProcessWeaponsAsObject(
				 weapons: ServiceProvider
					.GetRequiredService<IRepository>()
					.Weapons
					.AsQueryable());

			return await Task.FromResult(result);
		}

		[HttpGet(Routes.Api_Rest_Meta)]
		public async Task<IQueryMeta.IResult> Meta([FromQuery] IQueryMeta.Default query, CancellationToken cancellationToken = default)
		{
			IRepository repository = ServiceProvider.GetRequiredService<IRepository>();

			IQueryMeta.IResult result = query.ProcessMetaQuery(
				characters: repository.Characters.AsQueryable(),
				factions: repository.Factions.AsQueryable(),
				films: repository.Films.AsQueryable(),
				manufacturers: repository.Manufacturers.AsQueryable(),
				planets: repository.Planets.AsQueryable(),
				species: repository.Species.AsQueryable(),
				starships: repository.Starships.AsQueryable(),
				vehicles: repository.Vehicles.AsQueryable(),
				weapons: repository.Weapons.AsQueryable());

			return await Task.FromResult(result);
		}
	}
}