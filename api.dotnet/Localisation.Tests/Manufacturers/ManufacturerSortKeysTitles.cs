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
		public void ManufacturerSortKeysTitles(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IManufacturerLocalisations localisation = new ManufacturerLocalisations();

			// Act

			IManufacturer.ISortKeys? sortkeystitles = null;

			Exception? exception = Record.Exception(() => sortkeystitles = localisation.ManufacturerSortKeysTitles(cultureInfo));

			_OutputHelper.WriteLine(sortkeystitles?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(sortkeystitles);
		}
	}
}
