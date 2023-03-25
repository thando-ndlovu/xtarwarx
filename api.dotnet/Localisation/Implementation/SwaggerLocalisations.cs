using Localisation.Abstractions;
using Localisation.Abstractions.Swagger;
using Localisation.Utils.Swagger;

using System.Globalization;

using SwaggerUtils = Localisation.Utils.Swagger;

namespace Localisation.Implementation
{
	public class SwaggerLocalisations : Base.BaseLocalisations, ISwaggerLocalisations
	{
		public ISwaggerEndpointsLocalisation? SwaggerEndpoints(CultureInfo? cultureInfo = null, ISwaggerEndpointsLocalisation<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(SwaggerUtils.SwaggerEndpoints.ResourceName, localisationcultureinfo)?
				.GetSwaggerEndpoints(retriever);
		}
		public ISwaggerGeneralLocalisation? SwaggerGeneral(CultureInfo? cultureInfo = null, ISwaggerGeneralLocalisation<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(SwaggerUtils.SwaggerGeneral.ResourceName, localisationcultureinfo)?
				.GetSwaggerGeneral(retriever);
		}
		public ISwaggerParametersLocalisation? SwaggerParameters(CultureInfo? cultureInfo = null, ISwaggerParametersLocalisation<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(SwaggerUtils.SwaggerParameters.ResourceName, localisationcultureinfo)?
				.GetSwaggerParameters(retriever);
		}
		public ISwaggerResponsesLocalisation? SwaggerResponses(CultureInfo? cultureInfo = null, ISwaggerResponsesLocalisation<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(SwaggerUtils.SwaggerResponses.ResourceName, localisationcultureinfo)?
				.GetSwaggerResponses(retriever);
		}
	}
}
