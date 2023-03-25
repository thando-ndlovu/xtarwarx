using Api.Queries.Search;
using Api.Swagger.Options;

using Microsoft.OpenApi.Models;

using System;

namespace Api.Swagger.Schemas
{
	public class StarWarsModelSearchQuerySchemas : BaseSchemas
	{
		public const string Id_SearchString = nameof(IStarWarsModelSearchQuery.SearchString);

		public static IStarWarsModelSearchQuery<SwaggerSchema?> Default()
		{
			return new IStarWarsModelSearchQuery.Default<SwaggerSchema?>(null)
			{
				SearchString = DefaultSchema(swaggerschema =>
				{
					swaggerschema.Id = Id_SearchString;
					swaggerschema.Name = "SearchString";
				}),
			};
		}
	}
}
