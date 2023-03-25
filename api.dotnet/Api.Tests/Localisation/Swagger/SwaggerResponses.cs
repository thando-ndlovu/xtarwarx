using Domain.Models;

using Localisation.Abstractions;
using Localisation.Abstractions.Swagger;
using Localisation.Implementation;

using System;
using System.Globalization;

using Xunit;

namespace Localisation.Tests
{
	public partial class Swagger
	{
		[Theory]
		[MemberData(nameof(SwaggersMemberData))]
		[Trait("ISwaggerLocalisation", "")]
		public void SwaggerResponses(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using ISwaggerLocalisations swaggerLocalisation = new SwaggerLocalisations();

			// Act

			ISwaggerResponsesLocalisation? swaggerResponses = null;

			Exception? exception = Record.Exception(() => swaggerResponses = swaggerLocalisation.SwaggerResponses(cultureInfo));


			_OutputHelper.WriteLine(message: _StringBuilder.Clear()
				.AppendFormat("200: {0},", swaggerResponses?.X_200Desctiption)
				.ToString());

			// Assert

			Assert.Null(exception);
			Assert.NotNull(swaggerResponses);
		}
	}
}
