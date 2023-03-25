using Api.Swagger.Options;
using Api.Swagger.Services;

using System;

namespace Microsoft.Extensions.DependencyInjection
{
	public static class SwaggerServiceCollectionExtensions
	{
		public static IServiceCollection AddSwagger(this IServiceCollection services, Action<SwaggerOptions>? options = null)
		{
			SwaggerOptions swaggeroptions = new();

			options?.Invoke(swaggeroptions);

			services.AddSwaggerGen(swaggeroptions.GenOptions);
			if (options != null)
				services.AddOptions<SwaggerOptions>().Configure(options);

			services.AddHostedService<SwaggerJsonCreatorStartup>();

			return services;
		}
	}
}
