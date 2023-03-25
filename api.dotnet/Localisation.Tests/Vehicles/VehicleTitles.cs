using Domain.Models;

using Localisation.Abstractions;
using Localisation.Implementation;

using System;
using System.Globalization;

using Xunit;

namespace Localisation.Tests
{
	public partial class Vehicles
	{
		[Theory]
		[MemberData(nameof(VehiclesMemberData))]
		[Trait("IVehicleLocalisation", "")]
		public void VehicleTitles(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IVehicleLocalisations localisation = new VehicleLocalisations();

			// Act

			IVehicle<string?>? titles = null;

			Exception? exception = Record.Exception(() => titles = localisation.VehicleTitles(cultureInfo));

			_OutputHelper.WriteLine(titles?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(titles);
		}
	}
}
