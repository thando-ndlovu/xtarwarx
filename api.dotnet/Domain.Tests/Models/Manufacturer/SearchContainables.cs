using Domain.Models;

using System.Collections.Generic;

using Xunit;

namespace Domain.Tests.Models
{
	public partial class Manufacturer
	{
		public static IEnumerable<object[]> SearchContainablesMemberData => new List<object[]>
		{
			new object[]
			{
				Defaults.Zero.String,
				Defaults.Models.Manufacturer,
				new IManufacturer.ISearchContainables.Default
				{
					Description = true,
					Name = true,
				},
				false,
				0
			}, 

			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Manufacturer,
				new IManufacturer.ISearchContainables.Default
				{
					Description = false,
					Name = false,
				},
				false,
				0
			},	  

			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Manufacturer,
				new IManufacturer.ISearchContainables.Default
				{
					Description = false,
					Name = true,
				},
				true,
				1
			},
			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Manufacturer,
				new IManufacturer.ISearchContainables.Default
				{
					Description = true,
					Name = false,
				},
				true,
				1
			},

			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Manufacturer,
				new IManufacturer.ISearchContainables.Default
				{
					Description = true,
					Name = true,
				},
				true,
				2
			},
		};

		[Theory]
		[MemberData(nameof(SearchContainablesMemberData))]
		[Trait(nameof(IManufacturer.ISearchContainables), "")]
		public void SearchContainables(string searchstring, IManufacturer manufacturer, IManufacturer.ISearchContainables searchcontainables, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("SearchString: ", searchstring);
			TestOutputHelper.WriteLine("IManufacturer: ", manufacturer.ToString(stringBuilder: null));
			TestOutputHelper.WriteLine("IManufacturer.ISearchContainables: ", _StringBuilder.Append(searchcontainables).ToString());

			// Arrange
			// Act

			bool actualresult = searchcontainables.ShouldReturnManufacturer(manufacturer, searchstring, out int actualmatchcount);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}
	}
}
