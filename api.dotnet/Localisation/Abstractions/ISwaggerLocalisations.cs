using Domain.Models;

using Localisation.Abstractions.Swagger;

using System;
using System.Globalization;

namespace Localisation.Abstractions
{
	public interface ISwaggerLocalisations : IDisposable
	{
		ISwaggerEndpointsLocalisation? SwaggerEndpoints(CultureInfo? cultureInfo = null, ISwaggerEndpointsLocalisation<bool>? retriever = null);
		ISwaggerGeneralLocalisation? SwaggerGeneral(CultureInfo? cultureInfo = null, ISwaggerGeneralLocalisation<bool>? retriever = null);
		ISwaggerParametersLocalisation? SwaggerParameters(CultureInfo? cultureInfo = null, ISwaggerParametersLocalisation<bool>? retriever = null);
		ISwaggerResponsesLocalisation? SwaggerResponses(CultureInfo? cultureInfo = null, ISwaggerResponsesLocalisation<bool>? retriever = null);
	}
}
