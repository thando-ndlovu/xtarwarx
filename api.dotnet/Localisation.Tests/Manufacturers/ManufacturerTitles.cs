using Domain.Models;

using Localisation.Abstractions;
using Localisation.Implementation;

using System;
using System.Globalization;

using Xunit;

namespace Localisation.Tests
{
	public partial class Manufacturers
	{
		[Theory]
		[MemberData(nameof(ManufacturersMemberData))]
		[Trait("IManufacturerLocalisation", "")]
		public void ManufacturerTitles(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IManufacturerLocalisations localisation = new ManufacturerLocalisations();

			// Act

			IManufacturer<string?>? titles = null;

			Exception? exception = Record.Exception(() => titles = localisation.ManufacturerTitles(cultureInfo));

			_OutputHelper.WriteLine(titles?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(titles);
		}
	}
}
