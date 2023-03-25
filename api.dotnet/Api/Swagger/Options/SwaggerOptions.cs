using System;
using System.Collections.Generic;

using Swashbuckle.AspNetCore.SwaggerGen;

namespace Api.Swagger.Options
{
	public class SwaggerOptions
	{
		public Func<SwaggerDocument, IEnumerable<string>>? DocumentsFilepaths { get; set; }
		public Func<IServiceProvider, IEnumerable<SwaggerDocument>>? Documents { get; set; }
		public Action<SwaggerGenOptions>? GenOptions { get; set; }
	}
}
