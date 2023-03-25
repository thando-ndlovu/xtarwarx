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
		public void ManufacturerSearch(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IManufacturerLocalisations localisation = new ManufacturerLocalisations();

			// Act

			IManufacturerSearchLocalisation? searchlocalisation = null;

			Exception? exception = Record.Exception(() => searchlocalisation = localisation.ManufacturerSearch(cultureInfo));

			_OutputHelper.WriteLine(searchlocalisation?.ToString(
				stringbuilder: _StringBuilder,
				converter: new IManufacturerSearchLocalisation.Default<Func<object?, string>>(obj => obj?.ToString() ?? "null")) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(searchlocalisation);
		}
	}
}
