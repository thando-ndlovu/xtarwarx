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
		public void VehicleSearchContainablesTitles(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IVehicleLocalisations localisation = new VehicleLocalisations();

			// Act

			IVehicle.ISearchContainables<string?>? searchcontainablestitles = null;

			Exception? exception = Record.Exception(() => searchcontainablestitles = localisation.VehicleSearchContainablesTitles(cultureInfo));

			_OutputHelper.WriteLine(_StringBuilder.Append(searchcontainablestitles).ToString() ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(searchcontainablestitles);
		}
	}
}
