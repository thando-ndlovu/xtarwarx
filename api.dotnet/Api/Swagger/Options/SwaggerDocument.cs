using Microsoft.OpenApi.Models;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.Json.Serialization;

namespace Api.Swagger.Options
{
	public class SwaggerDocument
	{
		public static class Versions
		{
			public const string V_300 = "3.0.0";
			public const string V_301 = "3.0.1";
			public const string V_302 = "3.0.2";
			public const string V_303 = "3.0.3";

			public static IEnumerable<string> AsEnumerable()
			{
				return Enumerable.Empty<string>()
					.Append(V_300)
					.Append(V_301)
					.Append(V_302)
					.Append(V_303);
			}
		}

		[JsonIgnore]
		public SwaggerCulture? Culture { get; set; }
		public SwaggerInfo? Info { get; set; }
		public string? Openapi { get; set; }
		public IDictionary<string, SwaggerPath>? Paths { get; set; }
		public IEnumerable<SwaggerServer>? Servers { get; set; }
		public IEnumerable<SwaggerTag>? Tags { get; set; }
	}
	public class SwaggerCulture
	{
		public bool IsDefault { get; set; }
		public CultureInfo? Culture { get; set; }
	}
	public class SwaggerServer
	{
		public string? Description { get; set; }
		public Uri? Url { get; set; }
		public IDictionary<string, SwaggerServerVariable>? Variables { get; set; }
	}
	public class SwaggerTag
	{
		public string? Description { get; set; }
		public string? Name { get; set; }
	}
	public class SwaggerServerVariable
	{
		public string? Default { get; set; }
		public string? Description { get; set; }
		public IEnumerable<string>? Enum { get; set; }
	}
	public class SwaggerContact
	{
		public string? Email { get; set; }
		public string? Name { get; set; }
		public Uri? Url { get; set; }
	}
	public class SwaggerInfo
	{
		public SwaggerContact? Contact { get; set; }
		public string? Description { get; set; }
		public SwaggerLicense? License { get; set; }
		public string? TermsOfService { get; set; }
		public string? Title { get; set; }
		public string? Version { get; set; }
	}
	public class SwaggerLicense
	{
		public string? Name { get; set; }
		public Uri? Url { get; set; }
	}
	public class SwaggerOperation
	{
		public IEnumerable<string>? Consumes { get; set; }
		public bool Deprecated { get; set; }
		public string? Description { get; set; }
		public string? OperationId { get; set; }
		public IEnumerable<SwaggerSchema>? Parameters { get; set; }
		public IDictionary<string, SwaggerPathResponse>? Responses { get; set; }
		public string? Summary { get; set; }
		public IEnumerable<string>? Tags { get; set; }
	}
	public class SwaggerPath : Dictionary<string, SwaggerOperation> { }
	public class SwaggerPathResponse
	{
		public string? Description { get; set; }
		public IEnumerable<object>? Examples { get; set; }
		public IEnumerable<string>? Headers { get; set; }
		public SwaggerSchema? Schema { get; set; }
	}
	public class SwaggerSchema
	{
		[JsonIgnore]
		public string? Id { get; set; }
		public bool AllowEmptyValue { get; set; }
		public object? Default { get; set; }
		public bool Deprecated { get; set; }
		public string? Description { get; set; }
		public IDictionary<string, SwaggerExample>? Examples { get; set; }
		public ParameterLocation? In { get; set; }
		public string? Name { get; set; }
		public bool Required { get; set; }
	}
	public class SwaggerExample
	{
		public string? Description { get; set; }
		public string? ExternalValue { get; set; }
		public string? Summary { get; set; }
		public object? Value { get; set; }
	}
}
