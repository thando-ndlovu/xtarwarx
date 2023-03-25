using Domain.Models;

using System.Collections.Generic;

using Xunit;

namespace Domain.Tests.Models
{
	public partial class Vehicle
	{
		public static IEnumerable<object[]> SearchContainablesMemberData => new List<object[]>
		{
			new object[]
			{
				Defaults.Zero.String,
				Defaults.Models.Vehicle,
				new IVehicle.ISearchContainables.Default
				{
					VehicleClass = true,
					VehicleClassFlags = true,
				},
				false,
				0
			},

			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Vehicle,
				new IVehicle.ISearchContainables.Default
				{
					VehicleClass = false,
					VehicleClassFlags = false,
				},
				false,
				0
			},

			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Vehicle,
				new IVehicle.ISearchContainables.Default
				{
					VehicleClass = true,
					VehicleClassFlags = false,
				},
				true,
				1
			},
			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Vehicle,
				new IVehicle.ISearchContainables.Default
				{
					VehicleClass = false,
					VehicleClassFlags = true,
				},
				true,
				1
			},

			new object[]
			{
				Defaults.One.String,
				new IVehicle.Default(0)
				{
					VehicleClass = new IVehicle.IVehicleClass.Default
					{
						Class = Defaults.One.String,
						Flags = new string[] { Defaults.One.String, Defaults.One.String }
					},
				},
				new IVehicle.ISearchContainables.Default
				{
					VehicleClass = false,
					VehicleClassFlags = true,
				},
				true,
				2
			},
		};

		[Theory]
		[MemberData(nameof(SearchContainablesMemberData))]
		[Trait(nameof(IVehicle.ISearchContainables), "")]
		public void SearchContainables(string searchstring, IVehicle vehicle, IVehicle.ISearchContainables searchcontainables, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("SearchString: ", searchstring);
			TestOutputHelper.WriteLine("IVehicle: ", vehicle.ToString(stringBuilder: null));
			TestOutputHelper.WriteLine("IVehicle.ISearchContainables: ", searchcontainables.ToString());

			// Arrange
			// Act

			bool actualresult = searchcontainables.ShouldReturnVehicle(vehicle, searchstring, out int actualmatchcount);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}
	}
}
