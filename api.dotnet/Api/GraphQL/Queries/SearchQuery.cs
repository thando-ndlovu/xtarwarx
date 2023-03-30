using Api.Queries;
using Api.Queries.Search;
using Api.GraphQL.Types;

using Domain.Models;

using GraphQL;
using GraphQL.Types;

using Microsoft.Extensions.DependencyInjection;

using Repository;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.GraphQL.Queries
{
	public partial class SearchQuery : StarWarsModelQuery<IQuerySearchResultGraphType>
	{
		public SearchQuery(IServiceProvider serviceprovider) : base(serviceprovider) { }

		public static Func<IResolveFieldContext, object> Resolve(IServiceProvider serviceprovider, IQuerySearch? defaultquery = null)
		{
			return resolvefieldcontext =>
			{
				IRepository repository = serviceprovider.GetRequiredService<IRepository>();
				IQuerySearch querysearch = Arguments.GenerateQuery(resolvefieldcontext, defaultquery);

				IEnumerable<IQuerySearchResult>? charactersearchresults = querysearch.Characters?.GetQuerySearchResults(repository.Characters.AsQueryable(), repository);
				IEnumerable<IQuerySearchResult>? factionsearchresults = querysearch.Factions?.GetQuerySearchResults(repository.Factions.AsQueryable(), repository);
				IEnumerable<IQuerySearchResult>? filmsearchresults = querysearch.Films?.GetQuerySearchResults(repository.Films.AsQueryable(), repository);
				IEnumerable<IQuerySearchResult>? manufacturersearchresults = querysearch.Manufacturers?.GetQuerySearchResults(repository.Manufacturers.AsQueryable(), repository);
				IEnumerable<IQuerySearchResult>? planetsearchresults = querysearch.Planets?.GetQuerySearchResults(repository.Planets.AsQueryable(), repository);
				IEnumerable<IQuerySearchResult>? speciessearchresults = querysearch.Species?.GetQuerySearchResults(repository.Species.AsQueryable(), repository);
				IEnumerable<IQuerySearchResult>? starshipsearchresults = querysearch.Starships?.GetQuerySearchResults(repository.Starships.AsQueryable(), repository);
				IEnumerable<IQuerySearchResult>? vehiclesearchresults = querysearch.Vehicles?.GetQuerySearchResults(repository.Vehicles.AsQueryable(), repository);
				IEnumerable<IQuerySearchResult>? weaponsearchresults = querysearch.Weapons?.GetQuerySearchResults(repository.Weapons.AsQueryable(), repository);

				IEnumerable<IQuerySearchResult> searchresults = Enumerable.Empty<IQuerySearchResult>()
					.Concat(charactersearchresults ?? Enumerable.Empty<IQuerySearchResult>())
					.Concat(factionsearchresults ?? Enumerable.Empty<IQuerySearchResult>())
					.Concat(filmsearchresults ?? Enumerable.Empty<IQuerySearchResult>())
					.Concat(manufacturersearchresults ?? Enumerable.Empty<IQuerySearchResult>())
					.Concat(speciessearchresults ?? Enumerable.Empty<IQuerySearchResult>())
					.Concat(starshipsearchresults ?? Enumerable.Empty<IQuerySearchResult>())
					.Concat(vehiclesearchresults ?? Enumerable.Empty<IQuerySearchResult>())
					.Concat(weaponsearchresults ?? Enumerable.Empty<IQuerySearchResult>());

				IQuerySearch.IResult result = querysearch.ProcessQuerySearch(searchresults);

				return new IQuerySearch.IResult.Default<IQuerySearchResult>
				{
					Page = result.Page,
					Pages = result.Pages,
					Items = result.Items,
				};
			};
		}
	}
}
