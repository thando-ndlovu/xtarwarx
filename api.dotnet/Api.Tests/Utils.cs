using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace Api.Tests
{
	public static class Utils
	{
		public static class ApiTypes
		{
			public const string MVC = "Api.MVC";

			public static IEnumerable<string> AsEnumerable()
			{
				return Enumerable.Empty<string>()
					.Append(MVC);
			}

			public static void GetWebApplicationFactoryFields(string apitype, out IServiceProvider serviceprovider, out HttpClient httpclient)
			{
				switch (apitype)
				{
					case MVC:
						{
							WebApplicationFactory<Api.MVC.Startup> webapplicationfactory = new();

							serviceprovider = webapplicationfactory.Services;
							httpclient = webapplicationfactory.CreateClient();
						
						} break;

					default:
						throw new ArgumentException(string.Format("Invalid Api Type: '{0}'", apitype));
				}
			}
		}	   
	}
}
