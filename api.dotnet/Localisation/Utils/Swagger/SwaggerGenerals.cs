using Localisation.Abstractions.Swagger;

namespace Localisation.Utils.Swagger
{
	public class SwaggerGeneral
	{
		public const string ResourceName = "Swagger.SwaggerGeneral";

		public static readonly ISwaggerGeneralLocalisation<string> Keys = new ISwaggerGeneralLocalisation.Default<string>(string.Empty)
		{
			Title = "SwaggerGeneral_Title",
			Description = "SwaggerGeneral_Description",
		};
	}

	public static class SwaggerGeneralExtensions
	{
		public static ISwaggerGeneralLocalisation? GetSwaggerGeneral(this LocalisationResourceManager? localisationResourceManager, ISwaggerGeneralLocalisation<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new ISwaggerGeneralLocalisation.Default
				{
					Title = retriever?.Title ?? true ? localisationResourceManager.GetString(SwaggerGeneral.Keys.Description) : null,
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(SwaggerGeneral.Keys.Description) : null,
				};
	}
}
