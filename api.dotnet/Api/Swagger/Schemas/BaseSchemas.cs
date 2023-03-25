using Api.Queries.Search;
using Api.Swagger.Options;

using Microsoft.OpenApi.Models;

using System;

namespace Api.Swagger.Schemas
{
	public class BaseSchemas
	{
		protected static SwaggerSchema DefaultSchema(Action<SwaggerSchema>? action = null)
		{
			SwaggerSchema swaggerschema = new()
			{
				AllowEmptyValue = true,
				Deprecated = false,
				In = ParameterLocation.Query,
				Required = false,
			};

			action?.Invoke(swaggerschema);

			return swaggerschema;
		}
	}
}
