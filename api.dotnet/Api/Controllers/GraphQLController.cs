using Api.GraphQL;
using Api.Queries.GraphQL;

using GraphQL;
using GraphQL.NewtonsoftJson;
using GraphQL.Types;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using Newtonsoft.Json;

using System;
using System.IO;
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
			if (graphqlquery is null || string.IsNullOrWhiteSpace(graphqlquery.Query))
				return null;

			IDocumentExecuter documentexecuter = ServiceProvider.GetRequiredService<IDocumentExecuter>();

			ExecutionResult executionresult = await documentexecuter.ExecuteAsync(configure: executionoptions =>
			{
				executionoptions.CancellationToken = HttpContext.RequestAborted;
				executionoptions.OperationName = graphqlquery.OperationName;
				executionoptions.Query = graphqlquery.Query;
				executionoptions.RequestServices = ServiceProvider;
				executionoptions.Schema = new Schema { Query = new StarWarsQuery(ServiceProvider) };
				executionoptions.Variables = graphqlquery.Variables is null ? Inputs.Empty : new Inputs(graphqlquery.Variables!);
			});

			StringWriter stringwriter = new();
			JsonTextWriter jsontextwriter = new(stringwriter);

			new ExecutionResultJsonConverter()
				.WriteJson(jsontextwriter, executionresult, JsonSerializer.CreateDefault());

			return stringwriter.GetStringBuilder().ToString();
		}
	}
}