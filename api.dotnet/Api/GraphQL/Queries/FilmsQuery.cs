using Api.Queries;
using Api.GraphQL.Types;

using Domain.Models;

using GraphQL;

using Microsoft.Extensions.DependencyInjection;

using Repository;

using System;

namespace Api.GraphQL.Queries
{
	public partial class FilmsQuery : StarWarsModelQuery<IFilmGraphType>
	{
		public new class Arguments : StarWarsModelQuery<IFilmGraphType>.Arguments
		{
			public new static IQuery DefaultQuery
			{
				get
				{
					IQuery defaultquery = StarWarsModelQuery<IFilmGraphType>.Arguments.DefaultQuery;

					defaultquery.OrderBy = IFilm.ISortKeys.Keys.Title;

					return defaultquery;
				}
			}
		}

		public FilmsQuery(IServiceProvider serviceprovider) : base(serviceprovider) { }

		public static Func<IResolveFieldContext, object> Resolve(IServiceProvider serviceprovider, IQuery? defaultquery = null)
		{
			return resolvefieldcontext =>
			{
				IRepository repository = serviceprovider.GetRequiredService<IRepository>();
				IQuery query = Arguments.GenerateQuery(resolvefieldcontext, defaultquery);
				IQuery.IResult<IFilm> result = query.ProcessFilms(repository.Films.AsQueryable());

				return result;
			};
		}
		public static Func<IResolveFieldContext, object> Resolve(IServiceProvider serviceprovider, Func<IResolveFieldContext, IQuery>? defaultquery = null)
		{
			return resolvefieldcontext =>
			{
				IRepository repository = serviceprovider.GetRequiredService<IRepository>();
				IQuery query = Arguments.GenerateQuery(resolvefieldcontext, defaultquery?.Invoke(resolvefieldcontext));
				IQuery.IResult<IFilm> result = query.ProcessFilms(repository.Films.AsQueryable());

				return result;
			};
		}
	}
}
