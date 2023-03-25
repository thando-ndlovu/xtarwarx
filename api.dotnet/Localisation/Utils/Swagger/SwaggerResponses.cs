using Localisation.Abstractions.Swagger;

namespace Localisation.Utils.Swagger
{
	public class SwaggerResponses
	{
		public const string ResourceName = "Swagger.SwaggerResponses";

		public static readonly ISwaggerResponsesLocalisation<string> Keys = new ISwaggerResponsesLocalisation.Default<string>(string.Empty)
		{
			X_200Desctiption = "SwaggerResponses_200_Description",
		};
	}

	public static class SwaggerResponsesExtensions
	{
		public static ISwaggerResponsesLocalisation? GetSwaggerResponses(this LocalisationResourceManager? localisationResourceManager, ISwaggerResponsesLocalisation<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new ISwaggerResponsesLocalisation.Default
				{
					X_200Desctiption = retriever?.X_200Desctiption ?? true ? localisationResourceManager.GetString(SwaggerResponses.Keys.X_200Desctiption) : null,
				};
	}
}
