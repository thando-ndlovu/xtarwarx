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
		public void SwaggerGeneral(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using ISwaggerLocalisations swaggerLocalisation = new SwaggerLocalisations();

			// Act

			ISwaggerGeneralLocalisation? swaggerGeneral = null;

			Exception? exception = Record.Exception(() => swaggerGeneral = swaggerLocalisation.SwaggerGeneral(cultureInfo));


			_OutputHelper.WriteLine(message: _StringBuilder.Clear()
				.AppendFormat("Description: {0},", swaggerGeneral?.Description)
				.AppendFormat("Title: {0},", swaggerGeneral?.Title)
				.ToString());

			// Assert

			Assert.Null(exception);
			Assert.NotNull(swaggerGeneral);
		}
	}
}
