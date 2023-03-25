using Domain.Models;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

using Xunit;

namespace Domain.Tests.Models
{
	public partial class Character
	{
		public class FuncsSync
		{
			public Func<IPlanet?>? Homeworld { get; set; }
		}		
		public class FuncsAsync
		{
			public Func<Task<IPlanet?>>? Homeworld { get; set; }
		}

		public static IEnumerable<object[]> SearchMemberData => new List<object[]>
		{
			new object[]
			{
				new ICharacter.ISearch.Default{ },
				Defaults.Models.Character,
				false,
				0
			},

			// BirthYears double
			#region
			// true
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					BirthYears = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Lower = Defaults.One.Double
					}
				},
				Defaults.Models.Character,
				true,
				1
			},
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					BirthYears = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Upper = Defaults.One.Double
					}
				},
				Defaults.Models.Character,
				true,
				1
			},
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					BirthYears = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Values = Defaults.One.DoubleEnumerable
					}
				},
				Defaults.Models.Character,
				true,
				1
			},
			// true

			// false
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					BirthYears = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Lower = Defaults.Two.Double
					}
				},
				Defaults.Models.Character,
				false,
				0
			},
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					BirthYears = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Upper = Defaults.Zero.Double
					}
				},
				Defaults.Models.Character,
				false,
				0
			},
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					BirthYears = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Values = Defaults.Zero.DoubleEnumerable
					}
				},
				Defaults.Models.Character,
				false,
				0
			},
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					BirthYears = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Values = Defaults.Two.DoubleEnumerable
					}
				},
				Defaults.Models.Character,
				false,
				0
			},
			// false
			#endregion
			// BirthYears
			
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					EyeColors = new KnownColor[] { Defaults.Zero.KnownColor }
				},
				Defaults.Models.Character,
				false,
				0
			},
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					EyeColors = new KnownColor[] { Defaults.One.KnownColor }
				},
				Defaults.Models.Character,
				true,
				1
			},
			
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					HairColors = new KnownColor[] { Defaults.Zero.KnownColor }
				},
				Defaults.Models.Character,
				false,
				0
			},
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					HairColors = new KnownColor[] { Defaults.One.KnownColor }
				},
				Defaults.Models.Character,
				true,
				1
			},

			// Heights int
			#region
			// true
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					Heights = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Lower = Defaults.One.Int
					}
				},
				Defaults.Models.Character,
				true,
				1
			},
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					Heights = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Upper = Defaults.One.Int
					}
				},
				Defaults.Models.Character,
				true,
				1
			},
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					Heights = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = Defaults.One.IntEnumerable
					}
				},
				Defaults.Models.Character,
				true,
				1
			},
			// true

			// false
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					Heights = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Lower = Defaults.Two.Int
					}
				},
				Defaults.Models.Character,
				false,
				0
			},
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					Heights = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Upper = Defaults.Zero.Int
					}
				},
				Defaults.Models.Character,
				false,
				0
			},
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					Heights = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = Defaults.Zero.IntEnumerable
					}
				},
				Defaults.Models.Character,
				false,
				0
			},
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					Heights = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = Defaults.Two.IntEnumerable
					}
				},
				Defaults.Models.Character,
				false,
				0
			},
			// false
			#endregion
			// Heights
			
			// Masses double
			#region
			// true
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					Masses = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Lower = Defaults.One.Double
					}
				},
				Defaults.Models.Character,
				true,
				1
			},
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					Masses = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Upper = Defaults.One.Double
					}
				},
				Defaults.Models.Character,
				true,
				1
			},
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					Masses = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Values = Defaults.One.DoubleEnumerable
					}
				},
				Defaults.Models.Character,
				true,
				1
			},
			// true

			// false
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					Masses = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Lower = Defaults.Two.Double
					}
				},
				Defaults.Models.Character,
				false,
				0
			},
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					Masses = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Upper = Defaults.Zero.Double
					}
				},
				Defaults.Models.Character,
				false,
				0
			},
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					Masses = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Values = Defaults.Zero.DoubleEnumerable
					}
				},
				Defaults.Models.Character,
				false,
				0
			},
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					Masses = new IStarWarsModel.ISearchValues.Default<double?>(null)
					{
						Values = Defaults.Two.DoubleEnumerable
					}
				},
				Defaults.Models.Character,
				false,
				0
			},
			// false
			#endregion
			// Masses
			
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					Sexes = new string[] { Defaults.Zero.String }
				},
				Defaults.Models.Character,
				false,
				0
			},
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					Sexes = new string[] { Defaults.One.String }
				},
				Defaults.Models.Character,
				true,
				1
			},

			new object[]
			{
				new ICharacter.ISearch.Default
				{
					SkinColors = new KnownColor[] { Defaults.Zero.KnownColor }
				},
				Defaults.Models.Character,
				false,
				0
			},
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					SkinColors = new KnownColor[] { Defaults.One.KnownColor }
				},
				Defaults.Models.Character,
				true,
				1
			},
		};
		public static IEnumerable<object[]> SearchSyncMemberData => new List<object[]>
		{
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Homeworld = new IPlanet.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new ICharacter.Default(0) { },
				new FuncsSync
				{
					Homeworld = () => Defaults.Models.Planet,
				},
				false,
				0
			},
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Homeworld = new IPlanet.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new ICharacter.Default(0) { },
				new FuncsSync { },
				false,
				0
			},
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Homeworld = new IPlanet.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new ICharacter.Default(0) { },
				new FuncsSync
				{
					Homeworld = () => Defaults.Models.Planet,
				},
				false,
				0
			},
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Homeworld = new IPlanet.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new ICharacter.Default(0) { },
				new FuncsSync
				{
					Homeworld = () => Defaults.Models.Planet,
				},
				true,
				2
			},
		};
		public static IEnumerable<object[]> SearchAsyncMemberData => new List<object[]>
		{
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Homeworld = new IPlanet.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new ICharacter.Default(0) { },
				new FuncsAsync
				{
					Homeworld = () => Task.FromResult<IPlanet?>(Defaults.Models.Planet),
				},
				false,
				0
			},
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Homeworld = new IPlanet.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new ICharacter.Default(0) { },
				new FuncsAsync { },
				false,
				0
			},
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Homeworld = new IPlanet.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new ICharacter.Default(0) { },
				new FuncsAsync
				{
					Homeworld = () => Task.FromResult<IPlanet?>(Defaults.Models.Planet),
				},
				false,
				0
			},
			new object[]
			{
				new ICharacter.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Homeworld = new IPlanet.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new ICharacter.Default(0) { },
				new FuncsAsync
				{
					Homeworld = () => Task.FromResult<IPlanet?>(Defaults.Models.Planet),
				},
				true,
				2
			},
		};

		[Theory]
		[MemberData(nameof(SearchMemberData))]
		[Trait(nameof(ICharacter.ISearch), "")]
		public void Search(ICharacter.ISearch search, ICharacter character, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("ICharacter.ISearch: ", _StringBuilder.Append(search).ToString());
			TestOutputHelper.WriteLine("ICharacter: ", character.ToString(_StringBuilder));

			// Arrange
			// Act

			bool actualresult = search.ShouldReturnCharacter(character);
			int actualmatchcount = search.GetMatchCount(character);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}			   

		[Theory]
		[MemberData(nameof(SearchSyncMemberData))]
		[Trait(nameof(ICharacter.ISearch), "")]
		public void SearchSync(ICharacter.ISearch search, ICharacter character, FuncsSync funcs, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("ICharacter.ISearch: ", _StringBuilder.Append(search).ToString());
			TestOutputHelper.WriteLine("ICharacter: ", character.ToString(_StringBuilder));

			// Arrange
			// Act

			bool actualresult = search.ShouldReturnCharacter(character, funcs.Homeworld);
			int actualmatchcount = search.GetMatchCount(character, funcs.Homeworld);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}			   

		[Theory]
		[MemberData(nameof(SearchAsyncMemberData))]
		[Trait(nameof(ICharacter.ISearch), "")]
		public async void SearchAsync(ICharacter.ISearch search, ICharacter character, FuncsAsync funcs, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("ICharacter.ISearch: ", _StringBuilder.Append(search).ToString());
			TestOutputHelper.WriteLine("ICharacter: ", character.ToString(_StringBuilder));

			// Arrange
			// Act

			bool actualresult = await search.ShouldReturnCharacterAsync(character, funcs.Homeworld, CancellationToken.None);
			int actualmatchcount = await search.GetMatchCountAsync(character, funcs.Homeworld, CancellationToken.None);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}
	}
}
