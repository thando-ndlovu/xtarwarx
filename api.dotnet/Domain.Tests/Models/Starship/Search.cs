using Domain.Models;

using System.Collections.Generic;

using Xunit;

namespace Domain.Tests.Models
{
	public partial class Starship
	{
		public static IEnumerable<object[]> SearchMemberData => new List<object[]>
		{
			new object[]
			{
				new IStarship.ISearch.Default{ },
				Defaults.Models.Starship,
				false,
				0
			},

			// HyperdriveRatings
			#region
			// true
			new object[]
			{
				new IStarship.ISearch.Default
				{
					HyperdriveRatings = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Lower = Defaults.One.Double
					}
				},
				Defaults.Models.Starship,
				true,
				1
			},
			new object[]
			{
				new IStarship.ISearch.Default
				{
					HyperdriveRatings = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Upper = Defaults.One.Double
					}
				},
				Defaults.Models.Starship,
				true,
				1
			},
			new object[]
			{
				new IStarship.ISearch.Default
				{
					HyperdriveRatings = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Values = new double?[] { Defaults.One.Double }
					}
				},
				Defaults.Models.Starship,
				true,
				1
			},
			// true

			// false
			new object[]
			{
				new IStarship.ISearch.Default
				{
					HyperdriveRatings = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Lower = Defaults.Two.Double
					}
				},
				Defaults.Models.Starship,
				false,
				0
			},
			new object[]
			{
				new IStarship.ISearch.Default
				{
					HyperdriveRatings = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Upper = Defaults.Zero.Double
					}
				},
				Defaults.Models.Starship,
				false,
				0
			},
			new object[]
			{
				new IStarship.ISearch.Default
				{
					HyperdriveRatings = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Values = new double?[] { Defaults.Zero.Double }
					}
				},
				Defaults.Models.Starship,
				false,
				0
			},	   	 
			new object[]
			{
				new IStarship.ISearch.Default
				{
					HyperdriveRatings = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Values = new double?[] { Defaults.Two.Double }
					}
				},
				Defaults.Models.Starship,
				false,
				0
			},
			// false
			#endregion
			// HyperdriveRatings

			// MGLTs
			#region
			// true
			new object[]
			{
				new IStarship.ISearch.Default
				{
					MGLTs = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Lower = Defaults.One.Int
					}
				},
				Defaults.Models.Starship,
				true,
				1
			},
			new object[]
			{
				new IStarship.ISearch.Default
				{
					MGLTs = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Upper = Defaults.One.Int
					}
				},
				Defaults.Models.Starship,
				true,
				1
			},
			new object[]
			{
				new IStarship.ISearch.Default
				{
					MGLTs = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = new int?[] { Defaults.One.Int }
					}
				},
				Defaults.Models.Starship,
				true,
				1
			},
			// true

			// false
			new object[]
			{
				new IStarship.ISearch.Default
				{
					MGLTs = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Lower = Defaults.Two.Int
					}
				},
				Defaults.Models.Starship,
				false,
				0
			},
			new object[]
			{
				new IStarship.ISearch.Default
				{
					MGLTs = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Upper = Defaults.Zero.Int
					}
				},
				Defaults.Models.Starship,
				false,
				0
			},
			new object[]
			{
				new IStarship.ISearch.Default
				{
					MGLTs = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = new int?[] { Defaults.Zero.Int }
					}
				},
				Defaults.Models.Starship,
				false,
				0
			},
			new object[]
			{
				new IStarship.ISearch.Default
				{
					MGLTs = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = new int?[] { Defaults.Two.Int }
					}
				},
				Defaults.Models.Starship,
				false,
				0
			},
			// false
			#endregion
			// MGLTs
		};

		[Theory]
		[MemberData(nameof(SearchMemberData))]
		[Trait(nameof(IStarship.ISearch), "")]
		public void Search(IStarship.ISearch search, IStarship starship, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("IStarship.ISearch: ", _StringBuilder.Append(search).ToString());
			TestOutputHelper.WriteLine("IStarship: ", starship.ToString(_StringBuilder));

			// Arrange
			// Act

			bool actualresult = search.ShouldReturnStarship(starship);
			int actualmatchcount = search.GetMatchCount(starship);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}
	}
}
