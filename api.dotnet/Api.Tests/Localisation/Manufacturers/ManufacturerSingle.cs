using Localisation.Abstractions;
using Localisation.Abstractions.Manufacturers;
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
		public void ManufacturerSingle(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IManufacturerLocalisations localisation = new ManufacturerLocalisations();

			// Act

			IManufacturerSingleLocalisation? singlelocalisation = null;

			Exception? exception = Record.Exception(() => singlelocalisation = localisation.ManufacturerSingle(cultureInfo));

			_OutputHelper.WriteLine(singlelocalisation?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(singlelocalisation);
		}
	}
}
