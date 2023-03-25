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
		public void VehicleSearch(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IVehicleLocalisations localisation = new VehicleLocalisations();

			// Act

			IVehicleSearchLocalisation? searchlocalisation = null;

			Exception? exception = Record.Exception(() => searchlocalisation = localisation.VehicleSearch(cultureInfo));

			_OutputHelper.WriteLine(searchlocalisation?.ToString(
				stringbuilder: _StringBuilder,
				converter: new IVehicleSearchLocalisation.Default<Func<object?, string>>(obj => obj?.ToString() ?? "null")) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(searchlocalisation);
		}
	}
}
