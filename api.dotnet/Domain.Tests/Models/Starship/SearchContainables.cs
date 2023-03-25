using Domain.Models;

using System.Collections.Generic;

using Xunit;

namespace Domain.Tests.Models
{
	public partial class Starship
	{
		public static IEnumerable<object[]> SearchContainablesMemberData => new List<object[]>
		{
			new object[]
			{
				Defaults.Zero.String,
				Defaults.Models.Starship,
				new IStarship.ISearchContainables.Default
				{
					StarshipClass = true,
					StarshipClassFlags = true,
				},
				false,
				0
			}, 

			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Starship,
				new IStarship.ISearchContainables.Default
				{
					StarshipClass = false,
					StarshipClassFlags = false,
				},
				false,
				0
			},	  

			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Starship,
				new IStarship.ISearchContainables.Default
				{
					StarshipClass = true,
					StarshipClassFlags = false,
				},
				true,
				1
			},
			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Starship,
				new IStarship.ISearchContainables.Default
				{
					StarshipClass = false,
					StarshipClassFlags = true,
				},
				true,
				1
			},

			new object[]
			{
				Defaults.One.String,
				new IStarship.Default(0)
				{
					StarshipClass = new IStarship.IStarshipClass.Default
					{
						Class = Defaults.One.String,
						Flags = new string[] { Defaults.One.String, Defaults.One.String }
					},
				},
				new IStarship.ISearchContainables.Default
				{
					StarshipClass = false,
					StarshipClassFlags = true,
				},
				true,
				2
			},
		};

		[Theory]
		[MemberData(nameof(SearchContainablesMemberData))]
		[Trait(nameof(IStarship.ISearchContainables), "")]
		public void SearchContainables(string searchstring, IStarship starship, IStarship.ISearchContainables searchcontainables, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("SearchString: ", searchstring);
			TestOutputHelper.WriteLine("IStarship: ", starship.ToString(stringBuilder: null));
			TestOutputHelper.WriteLine("IStarship.ISearchContainables: ", _StringBuilder.Append(searchcontainables).ToString());

			// Arrange
			// Act

			bool actualresult = searchcontainables.ShouldReturnStarship(starship, searchstring, out int actualmatchcount);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}
	}
}
