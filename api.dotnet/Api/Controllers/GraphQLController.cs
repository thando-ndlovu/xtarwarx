using Api.GraphQL;
using Api.Queries.GraphQL;

using GraphQL;
using GraphQL.Types;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Controllers
{
	[Controller]
	public partial class GraphQLController : Controller
	{
		public GraphQLController(IServiceProvider serviceProvider)
		{
			ServiceProvider = serviceProvider;
		}

		protected IServiceProvider ServiceProvider { get; }

		[HttpGet(Routes.GraphQL)]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost(Routes.Api_GraphQL)]
		public async Task<string?> GraphQLQuery([FromBody] IGraphQLQuery.Default? graphqlquery)
		{
			if (string.IsNullOrWhiteSpace(graphqlquery?.Query))
				return null;

			string? result = null;


			ISchema starwarsschema = ServiceProvider.GetRequiredService<ISchema>();
			starwarsschema.Query = ServiceProvider.GetRequiredService<StarWarsQuery>();

			try
			{
				result = await starwarsschema.ExecuteAsync(
					serializer: new TextSerializer(),
					configure: executionoptions =>
					{
						executionoptions.CancellationToken = HttpContext.RequestAborted;
						executionoptions.OperationName = graphqlquery.OperationName;
						executionoptions.Query = graphqlquery.Query;
						executionoptions.RequestServices = ServiceProvider;
					});
			}
			catch (Exception ex)
			{
				string f = ex.Message;
			}
 

			//string result = await starwarsschema.ExecuteAsync(
			//	serializer: new TextSerializer(),
			//	configure: executionoptions =>
			//	{
			//		executionoptions.CancellationToken = HttpContext.RequestAborted;
			//		executionoptions.OperationName = graphqlquery.OperationName;
			//		executionoptions.Query = graphqlquery.Query;
			//		executionoptions.RequestServices = ServiceProvider;
			//	});

			return result;
		}

		private class TextSerializer : IGraphQLTextSerializer
		{
			public bool IsNativelyAsync => throw new NotImplementedException();

			public T? Deserialize<T>(string? value)
			{
				return default;
			}

			public ValueTask<T?> ReadAsync<T>(Stream stream, CancellationToken cancellationToken = default)
			{
				return ValueTask.FromResult<T?>(default);
			}

			public T? ReadNode<T>(object? value)
			{
				return default;
			}

			public string Serialize<T>(T? value)
			{
				ExecutionResult? executionresult = value as ExecutionResult;
				
				switch (true)
				{
					case true when executionresult is null:
						return string.Empty;

					case true when executionresult.Errors?.Any() ?? false:
						{
							StringBuilder stringbuilder = new();

							foreach (ExecutionError executionerror in executionresult.Errors)
								stringbuilder.AppendLine(executionerror.Message);

							return stringbuilder.ToString();
						}

					case true when (value as ExecutionResult)?.Data is object data:
						{
							byte[] buffer = JsonSerializer.SerializeToUtf8Bytes(
								value: executionresult.Errors ?? executionresult.Data,
								options: new JsonSerializerOptions
								{
									AllowTrailingCommas = false,
									PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
									WriteIndented = true,
								});

							using MemoryStream memorystream = new(buffer);
							using StreamReader streamreader = new(memorystream);
							string result = streamreader.ReadToEnd();

							return result;
						}

					default: return string.Empty;
				}
			}

			public async Task WriteAsync<T>(Stream stream, T value, CancellationToken cancellationToken = default)
			{
				switch (true)
				{
					case true when value is ExecutionResult executionresult:
						try
						{
							byte[] buffer = JsonSerializer.SerializeToUtf8Bytes(
								value: executionresult.Errors ?? executionresult.Data,
								options: new JsonSerializerOptions
								{
									AllowTrailingCommas = false,
									PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
									WriteIndented = true,
								});

							await stream.WriteAsync(buffer.AsMemory(0, buffer.Length), cancellationToken);
						}
						catch (Exception) { }
						break;

					default: break;
				}
			}
		}
	}
}
