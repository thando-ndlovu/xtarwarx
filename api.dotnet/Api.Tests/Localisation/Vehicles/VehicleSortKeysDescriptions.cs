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
		public void VehicleSortKeysDescriptions(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IVehicleLocalisations localisation = new VehicleLocalisations();

			// Act

			IVehicle.ISortKeys? sortkeysdescriptions = null;

			Exception? exception = Record.Exception(() => sortkeysdescriptions = localisation.VehicleSortKeysDescriptions(cultureInfo));

			_OutputHelper.WriteLine(sortkeysdescriptions?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(sortkeysdescriptions);
		}
	}
}
