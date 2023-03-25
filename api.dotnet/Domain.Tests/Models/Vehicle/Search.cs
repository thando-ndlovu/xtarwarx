using Domain.Models;

using System.Collections.Generic;

using Xunit;

namespace Domain.Tests.Models
{
	public partial class Vehicle
	{
		public static IEnumerable<object[]> SearchMemberData => new List<object[]>
		{
			new object[]
			{
				new IVehicle.ISearch.Default
				{
					SearchString = Defaults.Zero.String,
				},
				Defaults.Models.Vehicle,
				false,
				0
			}, 
		};

		[Theory]
		[MemberData(nameof(SearchMemberData))]
		[Trait(nameof(IVehicle.ISearch), "")]
		public void Search(IVehicle.ISearch search, IVehicle vehicle, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("IVehicle.ISearch: ", _StringBuilder.Append(search).ToString());
			TestOutputHelper.WriteLine("IVehicle: ", vehicle.ToString(_StringBuilder));

			// Arrange
			// Act

			bool actualresult = search.ShouldReturnVehicle(vehicle);
			int actualmatchcount = search.GetMatchCount(vehicle);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}
	}
}
