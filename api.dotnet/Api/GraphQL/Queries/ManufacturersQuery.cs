using Api.Queries;
using Api.GraphQL.Types;

using Domain.Models;

using GraphQL;

using Microsoft.Extensions.DependencyInjection;

using Repository;

using System;

namespace Api.GraphQL.Queries
{
	public partial class ManufacturersQuery : StarWarsModelQuery<IManufacturerGraphType>
	{
		public new class Arguments : StarWarsModelQuery<IManufacturerGraphType>.Arguments
		{
			public new static IQuery DefaultQuery
			{
				get
				{
					IQuery defaultquery = StarWarsModelQuery<IManufacturerGraphType>.Arguments.DefaultQuery;

					defaultquery.OrderBy = IManufacturer.ISortKeys.Keys.Name;

					return defaultquery;
				}
			}
		}

		public ManufacturersQuery(IServiceProvider serviceprovider) : base(serviceprovider) { }

		public static Func<IResolveFieldContext, object> Resolve(IServiceProvider serviceprovider, IQuery? defaultquery = null)
		{
			return resolvefieldcontext =>
			{
				IRepository repository = serviceprovider.GetRequiredService<IRepository>();
				IQuery query = Arguments.GenerateQuery(resolvefieldcontext, defaultquery);
				IQuery.IResult<IManufacturer> result = query.ProcessManufacturers(repository.Manufacturers.AsQueryable());

				return result;
			};
		}
		public static Func<IResolveFieldContext, object> Resolve(IServiceProvider serviceprovider, Func<IResolveFieldContext, IQuery>? defaultquery = null)
		{
			return resolvefieldcontext =>
			{
				IRepository repository = serviceprovider.GetRequiredService<IRepository>();
				IQuery query = Arguments.GenerateQuery(resolvefieldcontext, defaultquery?.Invoke(resolvefieldcontext));
				IQuery.IResult<IManufacturer> result = query.ProcessManufacturers(repository.Manufacturers.AsQueryable());

				return result;
			};
		}
	}
}
