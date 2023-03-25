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
		public void VehicleSingle(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IVehicleLocalisations localisation = new VehicleLocalisations();

			// Act

			IVehicleSingleLocalisation? singlelocalisation = null;

			Exception? exception = Record.Exception(() => singlelocalisation = localisation.VehicleSingle(cultureInfo));

			_OutputHelper.WriteLine(singlelocalisation?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(singlelocalisation);
		}
	}
}
