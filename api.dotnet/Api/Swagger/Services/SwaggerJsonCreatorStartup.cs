using Api.Swagger.Options;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Swagger.Services
{
	public class SwaggerJsonCreatorStartup : IHostedService
	{
		public SwaggerJsonCreatorStartup(IServiceProvider serviceprovider)
		{
			ServiceProvider = serviceprovider;
		}

		private readonly IServiceProvider ServiceProvider;

		public async Task StartAsync(CancellationToken cancellationToken)
		{
			SwaggerOptions swaggeroptions = ServiceProvider.GetRequiredService<IOptions<SwaggerOptions>>().Value;

			if (swaggeroptions.Documents?.Invoke(ServiceProvider) is IEnumerable<SwaggerDocument> swaggerdocuments)
			{
				JsonSerializerOptions jsonserializeroptions = new()
				{
					AllowTrailingCommas = false,
					DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
					DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
					IncludeFields = true,
					PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
					WriteIndented = true,
				};

				jsonserializeroptions.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase, false));

				IEnumerable<Task> swaggertasks = swaggerdocuments.Select(async swaggerdocument =>
				{
					if (swaggeroptions.DocumentsFilepaths?.Invoke(swaggerdocument) is IEnumerable<string> paths)
						foreach (string path in paths)
						{
							using FileStream filestream = File.Open(
								path: path,
								mode: FileMode.Create);

							await JsonSerializer.SerializeAsync(
								value: swaggerdocument,
								utf8Json: filestream,
								options: jsonserializeroptions,
								cancellationToken: cancellationToken);
						}
				});

				await Task.WhenAll(swaggertasks);
			}
		}
		public async Task StopAsync(CancellationToken cancellationToken)
		{
			await Task.CompletedTask;
		}
	}
}
