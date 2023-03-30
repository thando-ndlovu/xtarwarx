using Api.Repository.Options;

using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Altair;
using GraphQL.Server.Ui.GraphiQL;
using GraphQL.Server.Ui.Playground;

using Localisation;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Swashbuckle.AspNetCore.SwaggerUI;

namespace Api.MVC
{
	public partial class Startup
	{
		public Startup(IWebHostEnvironment webhostenvironment)
		{
			WebHostEnvironment = webhostenvironment;
		}

		private IWebHostEnvironment WebHostEnvironment { get; }

		public void ConfigureServices(IServiceCollection servicecollection)
		{
			servicecollection.AddControllers();

			servicecollection.AddGraphQL(graphqlbuilder =>
			{
				graphqlbuilder.AddSchema<Api.GraphQL.StarWarsSchema>();
				graphqlbuilder.AddErrorInfoProvider(errorinfoprovideroptions =>
				{
					bool development = true;

					errorinfoprovideroptions.ExposeCode = development;
					errorinfoprovideroptions.ExposeCodes = development;
					errorinfoprovideroptions.ExposeData = development;
					errorinfoprovideroptions.ExposeExtensions = development;
					errorinfoprovideroptions.ExposeExceptionDetails = development;
				});

				graphqlbuilder.AddGraphTypes(typeof(Api.GraphQL.StarWarsSchema).Assembly);
			});

			servicecollection.AddDefaultRepository()
				.Configure(options =>
				{
					options.DatabaseName = "starwarx";

					options.ConnectionString = "";
					options.ConfigurationType = RepositoryConfigurationOptions.ConfigurationType_InMemory;

					//options.ConnectionString = "mongodb://localhost:27017";
					//options.ConfigurationType = RepositoryConfigurationOptions.ConfigurationType_MongoDB;

					//options.ConnectionString = "server=localhost;port=3306;database=starwarx;user=root;password=12345"; 
					//options.ConfigurationType = RepositoryConfigurationOptions.ConfigurationType_MySQL; 

					//options.ConnectionString = "Data Source=c:\starwarx.db;Version=3";						// Disk  
					//options.ConnectionString = "Data Source=:memory:;Version=3;New=True";						// Memory
					//options.ConfigurationType = RepositoryConfigurationOptions.ConfigurationType_SQLite;

					//options.ConnectionString = "";
					//options.ConfigurationType = RepositoryConfigurationOptions.ConfigurationType_SqlServer;
				});
			servicecollection.AddLogging();
			servicecollection.AddLocalisations(options =>
			{
				options.DefaultCultureInfo = LocalisationCultures.English;
			});

			ConfigureServicesSwagger(servicecollection);
			
			servicecollection.Configure<RazorViewEngineOptions>(razorViewEngineOptions =>
			{
				razorViewEngineOptions.ViewLocationFormats.Add("/Views/Partials/{0}.cshtml");
			
			}).AddControllersWithViews(mvcoptions =>
			{
				mvcoptions.EnableEndpointRouting = false;
			});
		}
		public void Configure(IApplicationBuilder applicationbuilder)
		{
			if (WebHostEnvironment.IsDevelopment())
			{
				applicationbuilder.UseDeveloperExceptionPage();
			}
			else
			{
				applicationbuilder.UseHsts();
			}

			applicationbuilder.UseCors(corspolicybuilder =>
			{
				corspolicybuilder
					.AllowAnyHeader()
					.AllowAnyOrigin()
					.AllowAnyMethod();
			});

			applicationbuilder.UseSwagger(swaggeroptions =>
			{
				swaggeroptions.SerializeAsV2 = false;
			});
			applicationbuilder.UseSwaggerUI(swaggeruioptions =>
			{
				swaggeruioptions.DocumentTitle = "StarWarX Swagger";
				swaggeruioptions.RoutePrefix = Routes.Rest_Swagger.TrimStart('/');

				// Core	   
				swaggeruioptions.SwaggerEndpoint("/swaggerdocs/3.0.3/docs.json", "Open API English");
				swaggeruioptions.SwaggerEndpoint("/swaggerdocs/3.0.3/docs.en-ZA.json", "Open API English (South Africa)");

				// Display
				swaggeruioptions.DefaultModelExpandDepth(2);
				swaggeruioptions.DefaultModelRendering(ModelRendering.Example);
				swaggeruioptions.DefaultModelsExpandDepth(-1);
				swaggeruioptions.DisplayOperationId();
				swaggeruioptions.DisplayRequestDuration();
				swaggeruioptions.DocExpansion(DocExpansion.List);
				swaggeruioptions.EnableDeepLinking();
				swaggeruioptions.EnableFilter();
				swaggeruioptions.ShowExtensions();

				// Network
				swaggeruioptions.EnableValidator();
				swaggeruioptions.SupportedSubmitMethods(SubmitMethod.Get);

				// Other
				swaggeruioptions.InjectJavascript("../../js/swagger.js");
				swaggeruioptions.InjectStylesheet("../../css/swagger.css");
				swaggeruioptions.InjectStylesheet("../../css/swagger.theme.dark.css");
				swaggeruioptions.InjectStylesheet("../../css/swagger.theme.light.css");
			});

			applicationbuilder.UseCookiePolicy();
			applicationbuilder.UseLocalisation();
			applicationbuilder.UseHttpsRedirection();
			applicationbuilder.UseStaticFiles();
			applicationbuilder.UseRouting();
			applicationbuilder.UseEndpoints(endpointroutebuilder =>
			{
				endpointroutebuilder.MapDefaultControllerRoute();
				endpointroutebuilder.MapGraphQLAltair(pattern: Routes.GraphQL_Altair, options: new AltairOptions
				{
					GraphQLEndPoint = Routes.Api_GraphQL,
				});
				endpointroutebuilder.MapGraphQLGraphiQL(pattern: Routes.GraphQL_GraphiQL, options: new GraphiQLOptions
				{
					GraphQLEndPoint = Routes.Api_GraphQL,
				});
				endpointroutebuilder.MapGraphQLPlayground(pattern: Routes.GraphQL_Playground, options: new PlaygroundOptions
				{
					GraphQLEndPoint = Routes.Api_GraphQL,
				});
			});
		}
	}
}

