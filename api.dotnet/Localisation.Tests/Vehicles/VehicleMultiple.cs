using Localisation.Abstractions;
using Localisation.Abstractions.Vehicles;
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
		public void VehicleMultiple(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IVehicleLocalisations localisation = new VehicleLocalisations();

			// Act

			IVehicleMultipleLocalisation? multiplelocalisation = null;

			Exception? exception = Record.Exception(() => multiplelocalisation = localisation.VehicleMultiple(cultureInfo));

			_OutputHelper.WriteLine(multiplelocalisation?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(multiplelocalisation);
		}
	}
}
