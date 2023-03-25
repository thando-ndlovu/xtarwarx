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
		public void ManufacturerSearchContainablesTitles(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IManufacturerLocalisations localisation = new ManufacturerLocalisations();

			// Act

			IManufacturer.ISearchContainables<string?>? searchcontainablestitles = null;

			Exception? exception = Record.Exception(() => searchcontainablestitles = localisation.ManufacturerSearchContainablesTitles(cultureInfo));

			_OutputHelper.WriteLine(_StringBuilder.Append(searchcontainablestitles).ToString() ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(searchcontainablestitles);
		}
	}
}
