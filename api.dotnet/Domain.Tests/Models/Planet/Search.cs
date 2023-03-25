using Domain.Models;

using System;
using System.Collections.Generic;
using System.Threading;

using Xunit;

namespace Domain.Tests.Models
{
	public partial class Planet
	{
		public class FuncsSync
		{
			public Func<IEnumerable<ICharacter>>? Residents { get; set; }
		}	   
		public class FuncsAsync
		{
			public Func<IAsyncEnumerable<ICharacter>>? Residents { get; set; }
		}

		public static IEnumerable<object[]> SearchMemberData => new List<object[]>
		{
			new object[]
			{
				new IPlanet.ISearch.Default{ },
				Defaults.Models.Planet,
				false,
				0
			},

			new object[]
			{
				new IPlanet.ISearch.Default
				{
					ClimateFlags = new string[] { Defaults.Zero.String }
				},
				Defaults.Models.Planet,
				false,
				0
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					ClimateFlags = new string[] { Defaults.One.String }
				},
				Defaults.Models.Planet,
				true,
				1
			},		

			new object[]
			{
				new IPlanet.ISearch.Default
				{
					ClimateTypes = new string[] { Defaults.Zero.String }
				},
				Defaults.Models.Planet,
				false,
				0
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					ClimateTypes = new string[] { Defaults.One.String }
				},
				Defaults.Models.Planet,
				true,
				1
			},

			// Diameters int
			#region
			// true
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					Diameters = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Lower = Defaults.One.Int
					}
				},
				Defaults.Models.Planet,
				true,
				1
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					Diameters = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Upper = Defaults.One.Int
					}
				},
				Defaults.Models.Planet,
				true,
				1
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					Diameters = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = Defaults.One.IntEnumerable
					}
				},
				Defaults.Models.Planet,
				true,
				1
			},
			// true

			// false
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					Diameters = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Lower = Defaults.Two.Int
					}
				},
				Defaults.Models.Planet,
				false,
				0
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					Diameters = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Upper = Defaults.Zero.Int
					}
				},
				Defaults.Models.Planet,
				false,
				0
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					Diameters = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = Defaults.Zero.IntEnumerable
					}
				},
				Defaults.Models.Planet,
				false,
				0
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					Diameters = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = Defaults.Two.IntEnumerable
					}
				},
				Defaults.Models.Planet,
				false,
				0
			},
			// false
			#endregion
			// Diameters

			// Gravities double
			#region
			// true
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					Gravities = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Lower = Defaults.One.Double
					}
				},
				Defaults.Models.Planet,
				true,
				1
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					Gravities = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Upper = Defaults.One.Double
					}
				},
				Defaults.Models.Planet,
				true,
				1
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					Gravities = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Values = Defaults.One.DoubleEnumerable
					}
				},
				Defaults.Models.Planet,
				true,
				1
			},
			// true

			// false
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					Gravities = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Lower = Defaults.Two.Double
					}
				},
				Defaults.Models.Planet,
				false,
				0
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					Gravities = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Upper = Defaults.Zero.Double
					}
				},
				Defaults.Models.Planet,
				false,
				0
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					Gravities = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Values = Defaults.Zero.DoubleEnumerable
					}
				},
				Defaults.Models.Planet,
				false,
				0
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					Gravities = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Values = Defaults.Two.DoubleEnumerable
					}
				},
				Defaults.Models.Planet,
				false,
				0
			},
			// false
			#endregion
			// Gravities

			// OrbitalPeriods TimeSpan
			#region
			// true
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					OrbitalPeriods = new IStarWarsModel.ISearchValues.Default<TimeSpan?>(null)
					{
						Lower = Defaults.One.TimeSpan
					}
				},
				Defaults.Models.Planet,
				true,
				1
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					OrbitalPeriods = new IStarWarsModel.ISearchValues.Default<TimeSpan?>(null)
					{
						Upper = Defaults.One.TimeSpan
					}
				},
				Defaults.Models.Planet,
				true,
				1
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					OrbitalPeriods = new IStarWarsModel.ISearchValues.Default<TimeSpan?>(null)
					{
						Values = Defaults.One.TimeSpanEnumerable
					}
				},
				Defaults.Models.Planet,
				true,
				1
			},
			// true

			// false
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					OrbitalPeriods = new IStarWarsModel.ISearchValues.Default<TimeSpan?>(null)
					{
						Lower = Defaults.Two.TimeSpan
					}
				},
				Defaults.Models.Planet,
				false,
				0
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					OrbitalPeriods = new IStarWarsModel.ISearchValues.Default<TimeSpan?>(null)
					{
						Upper = Defaults.Zero.TimeSpan
					}
				},
				Defaults.Models.Planet,				   
				false,
				0
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					OrbitalPeriods = new IStarWarsModel.ISearchValues.Default<TimeSpan?>(null)
					{
						Values = Defaults.Zero.TimeSpanEnumerable
					}
				},
				Defaults.Models.Planet,
				false,
				0
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					OrbitalPeriods = new IStarWarsModel.ISearchValues.Default<TimeSpan?>(null)
					{
						Values = Defaults.Two.TimeSpanEnumerable
					}
				},
				Defaults.Models.Planet,
				false,
				0
			},
			// false
			#endregion
			// OrbitalPeriods

			// Populations long
			#region
			// true
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					Populations = new IStarWarsModel.ISearchValues.Default<long?>(null)
					{
						Lower = Defaults.One.Long
					}
				},
				Defaults.Models.Planet,
				true,
				1
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					Populations = new IStarWarsModel.ISearchValues.Default<long?>(null)
					{
						Upper = Defaults.One.Long
					}
				},
				Defaults.Models.Planet,
				true,
				1
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					Populations = new IStarWarsModel.ISearchValues.Default<long?>(null)
					{
						Values = Defaults.One.LongEnumerable
					}
				},
				Defaults.Models.Planet,
				true,
				1
			},
			// true

			// false
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					Populations = new IStarWarsModel.ISearchValues.Default<long?>(null)
					{
						Lower = Defaults.Two.Long
					}
				},
				Defaults.Models.Planet,
				false,
				0
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					Populations = new IStarWarsModel.ISearchValues.Default<long?>(null)
					{
						Upper = Defaults.Zero.Long
					}
				},
				Defaults.Models.Planet,
				false,
				0
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					Populations = new IStarWarsModel.ISearchValues.Default<long?>(null)
					{
						Values = Defaults.Zero.LongEnumerable
					}
				},
				Defaults.Models.Planet,
				false,
				0
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					Populations = new IStarWarsModel.ISearchValues.Default<long?>(null)
					{
						Values = Defaults.Two.LongEnumerable
					}
				},
				Defaults.Models.Planet,
				false,
				0
			},
			// false
			#endregion
			// Populations

			// RotationalPeriods TimeSpan
			#region
			// true
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					RotationalPeriods = new IStarWarsModel.ISearchValues.Default<TimeSpan?>(null)
					{
						Lower = Defaults.One.TimeSpan
					}
				},
				Defaults.Models.Planet,
				true,
				1
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					RotationalPeriods = new IStarWarsModel.ISearchValues.Default<TimeSpan?>(null)
					{
						Upper = Defaults.One.TimeSpan
					}
				},
				Defaults.Models.Planet,
				true,
				1
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					RotationalPeriods = new IStarWarsModel.ISearchValues.Default<TimeSpan?>(null)
					{
						Values = Defaults.One.TimeSpanEnumerable
					}
				},
				Defaults.Models.Planet,
				true,
				1
			},
			// true

			// false
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					RotationalPeriods = new IStarWarsModel.ISearchValues.Default<TimeSpan?>(null)
					{
						Lower = Defaults.Two.TimeSpan
					}
				},
				Defaults.Models.Planet,
				false,
				0
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					RotationalPeriods = new IStarWarsModel.ISearchValues.Default<TimeSpan?>(null)
					{
						Upper = Defaults.Zero.TimeSpan
					}
				},
				Defaults.Models.Planet,
				false,
				0
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					RotationalPeriods = new IStarWarsModel.ISearchValues.Default<TimeSpan?>(null)
					{
						Values = Defaults.Zero.TimeSpanEnumerable
					}
				},
				Defaults.Models.Planet,
				false,
				0
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					RotationalPeriods = new IStarWarsModel.ISearchValues.Default<TimeSpan?>(null)
					{
						Values = Defaults.Two.TimeSpanEnumerable
					}
				},
				Defaults.Models.Planet,
				false,
				0
			},
			// false
			#endregion
			// RotationalPeriods

			// SurfaceWaters double
			#region
			// true
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					SurfaceWaters = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Lower = Defaults.One.Double
					}
				},
				Defaults.Models.Planet,
				true,
				1
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					SurfaceWaters = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Upper = Defaults.One.Double
					}
				},
				Defaults.Models.Planet,
				true,
				1
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					SurfaceWaters = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Values = Defaults.One.DoubleEnumerable
					}
				},
				Defaults.Models.Planet,
				true,
				1
			},
			// true

			// false
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					SurfaceWaters = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Lower = Defaults.Two.Double
					}
				},
				Defaults.Models.Planet,
				false,
				0
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					SurfaceWaters = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Upper = Defaults.Zero.Double
					}
				},
				Defaults.Models.Planet,
				false,
				0
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					SurfaceWaters = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Values = Defaults.Zero.DoubleEnumerable
					}
				},
				Defaults.Models.Planet,
				false,
				0
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					SurfaceWaters = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Values = Defaults.Two.DoubleEnumerable
					}
				},
				Defaults.Models.Planet,
				false,
				0
			},
			// false
			#endregion
			// SurfaceWaters

			new object[]
			{
				new IPlanet.ISearch.Default
				{
					TerrainFlags = new string[] { Defaults.Zero.String }
				},
				Defaults.Models.Planet,
				false,
				0
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					TerrainFlags = new string[] { Defaults.One.String }
				},
				Defaults.Models.Planet,
				true,
				1
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					TerrainTypes = new string[] { Defaults.Zero.String }
				},
				Defaults.Models.Planet,
				false,
				0
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					TerrainTypes = new string[] { Defaults.One.String }
				},
				Defaults.Models.Planet,
				true,
				1
			},
		};
		public static IEnumerable<object[]> SearchSyncMemberData => new List<object[]>
		{
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Residents = new ICharacter.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new IPlanet.Default(0) { },
				new FuncsSync
				{
					Residents = () => Defaults.Models.CharacterEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Residents = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IPlanet.Default(0) { },
				new FuncsSync { },
				false,
				0
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Residents = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IPlanet.Default(0) { },
				new FuncsSync
				{
					Residents = () => Defaults.Models.CharacterEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Residents = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IPlanet.Default(0) { },
				new FuncsSync
				{
					Residents = () => Defaults.Models.CharacterEnumerable,
				},
				true,
				2
			},
		};
		public static IEnumerable<object[]> SearchAsyncMemberData => new List<object[]> 
		{
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Residents = new ICharacter.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new IPlanet.Default(0) { },
				new FuncsAsync
				{
					Residents = () => Defaults.Models.CharacterAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Residents = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IPlanet.Default(0) { },
				new FuncsAsync { },
				false,
				0
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Residents = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IPlanet.Default(0) { },
				new FuncsAsync
				{
					Residents = () => Defaults.Models.CharacterAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IPlanet.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Residents = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IPlanet.Default(0) { },
				new FuncsAsync
				{
					Residents = () => Defaults.Models.CharacterAsyncEnumerable(),
				},
				true,
				2
			},
		};

		[Theory]
		[MemberData(nameof(SearchMemberData))]
		[Trait(nameof(IPlanet.ISearch), "")]
		public void Search(IPlanet.ISearch search, IPlanet planet, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("IPlanet.ISearch: ", _StringBuilder.Append(search).ToString());
			TestOutputHelper.WriteLine("IPlanet: ", planet.ToString(_StringBuilder));

			// Arrange
			// Act

			bool actualresult = search.ShouldReturnPlanet(planet);
			int actualmatchcount = search.GetMatchCount(planet);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}	  

		[Theory]
		[MemberData(nameof(SearchSyncMemberData))]
		[Trait(nameof(IPlanet.ISearch), "")]
		public void SearchSync(IPlanet.ISearch search, IPlanet planet, FuncsSync funcs, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("IPlanet.ISearch: ", _StringBuilder.Append(search).ToString());
			TestOutputHelper.WriteLine("IPlanet: ", planet.ToString(_StringBuilder));

			// Arrange
			// Act

			bool actualresult = search.ShouldReturnPlanet(planet, funcs.Residents);
			int actualmatchcount = search.GetMatchCount(planet, funcs.Residents);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}	  

		[Theory]
		[MemberData(nameof(SearchAsyncMemberData))]
		[Trait(nameof(IPlanet.ISearch), "")]
		public async void SearchAsync(IPlanet.ISearch search, IPlanet planet, FuncsAsync funcs, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("IPlanet.ISearch: ", _StringBuilder.Append(search).ToString());
			TestOutputHelper.WriteLine("IPlanet: ", planet.ToString(_StringBuilder));

			// Arrange
			// Act

			bool actualresult = await search.ShouldReturnPlanetAsync(planet, funcs.Residents, CancellationToken.None);
			int actualmatchcount = await search.GetMatchCountAsync(planet, funcs.Residents, CancellationToken.None);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}
	}
}
