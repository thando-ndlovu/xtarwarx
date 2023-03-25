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
		public void SwaggerParameters(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using ISwaggerLocalisations swaggerLocalisation = new SwaggerLocalisations();

			// Act

			ISwaggerParametersLocalisation? swaggerParameters = null;

			Exception? exception = Record.Exception(() => swaggerParameters = swaggerLocalisation.SwaggerParameters(cultureInfo));

			_OutputHelper.WriteLine(swaggerParameters?.ToString() ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(swaggerParameters);
		}
	}
}
