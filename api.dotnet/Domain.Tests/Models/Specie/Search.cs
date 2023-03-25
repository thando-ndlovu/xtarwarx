using Domain.Models;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

using Xunit;

namespace Domain.Tests.Models
{
	public partial class Specie
	{
		public class FuncsSync
		{
			public Func<IEnumerable<ICharacter>>? Characters { get; set; }
			public Func<IPlanet?>? Homeworld { get; set; }
		}	
		public class FuncsAsync
		{
			public Func<IAsyncEnumerable<ICharacter>>? Characters { get; set; }
			public Func<Task<IPlanet?>>? Homeworld { get; set; }
		}

		public static IEnumerable<object[]> SearchMemberData => new List<object[]>
		{
			new object[]
			{
				new ISpecie.ISearch.Default{ },
				Defaults.Models.Specie,
				false,
				0
			},

			// AverageHeights 
			#region
			// true
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					AverageHeights = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Lower = Defaults.One.Int
					}
				},
				Defaults.Models.Specie,
				true,
				1
			},
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					AverageHeights = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Upper = Defaults.One.Int
					}
				},
				Defaults.Models.Specie,
				true,
				1
			},
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					AverageHeights = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = Defaults.One.IntEnumerable
					}
				},
				Defaults.Models.Specie,
				true,
				1
			},
			// true

			// false
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					AverageHeights = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Lower = Defaults.Two.Int
					}
				},
				Defaults.Models.Specie,
				false,
				0
			},
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					AverageHeights = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Upper = Defaults.Zero.Int
					}
				},
				Defaults.Models.Specie,
				false,
				0
			},
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					AverageHeights = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = Defaults.Zero.IntEnumerable
					}
				},
				Defaults.Models.Specie,
				false,
				0
			},
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					AverageHeights = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = Defaults.Two.IntEnumerable
					}
				},
				Defaults.Models.Specie,
				false,
				0
			},
			// false
			#endregion
			// AverageHeights		   

			// AverageLifespans 
			#region
			// true
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					AverageLifespans = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Lower = Defaults.One.Int
					}
				},
				Defaults.Models.Specie,
				true,
				1
			},
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					AverageLifespans = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Upper = Defaults.One.Int
					}
				},
				Defaults.Models.Specie,
				true,
				1
			},
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					AverageLifespans = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = Defaults.One.IntEnumerable
					}
				},
				Defaults.Models.Specie,
				true,
				1
			},
			// true

			// false
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					AverageLifespans = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Lower = Defaults.Two.Int
					}
				},
				Defaults.Models.Specie,
				false,
				0
			},
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					AverageLifespans = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Upper = Defaults.Zero.Int
					}
				},
				Defaults.Models.Specie,
				false,
				0
			},
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					AverageLifespans = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = Defaults.Zero.IntEnumerable
					}
				},
				Defaults.Models.Specie,
				false,
				0
			},
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					AverageLifespans = new IStarWarsModel.ISearchValues.Default<int?>(null)
					{
						Values = Defaults.Two.IntEnumerable
					}
				},
				Defaults.Models.Specie,
				false,
				0
			},
			// false
			#endregion
			// AverageLifespans

			new object[]
			{
				new ISpecie.ISearch.Default
				{
					Classifications = new string[] { Defaults.Zero.String }
				},
				Defaults.Models.Specie,
				false,
				0
			},
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					Classifications = new string[] { Defaults.One.String }
				},
				Defaults.Models.Specie,
				true,
				1
			},

			new object[]
			{
				new ISpecie.ISearch.Default
				{
					Designations = new string[] { Defaults.Zero.String }
				},
				Defaults.Models.Specie,
				false,
				0
			},
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					Designations = new string[] { Defaults.One.String }
				},
				Defaults.Models.Specie,
				true,
				1
			},

			new object[]
			{
				new ISpecie.ISearch.Default
				{
					EyeColors = new KnownColor[] { Defaults.Zero.KnownColor }
				},
				Defaults.Models.Specie,
				false,
				0
			},
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					EyeColors = new KnownColor[] { Defaults.One.KnownColor }
				},
				Defaults.Models.Specie,
				true,
				1
			},

			new object[]
			{
				new ISpecie.ISearch.Default
				{
					HairColors = new KnownColor[] { Defaults.Zero.KnownColor }
				},
				Defaults.Models.Specie,
				false,
				0
			},
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					HairColors = new KnownColor[] { Defaults.One.KnownColor }
				},
				Defaults.Models.Specie,
				true,
				1
			},

			new object[]
			{
				new ISpecie.ISearch.Default
				{
					Languages = new string[] { Defaults.Zero.String }
				},
				Defaults.Models.Specie,
				false,
				0
			},
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					Languages = new string[] { Defaults.One.String }
				},
				Defaults.Models.Specie,
				true,
				1
			},

			new object[]
			{
				new ISpecie.ISearch.Default
				{
					SkinColors = new KnownColor[] { Defaults.Zero.KnownColor }
				},
				Defaults.Models.Specie,
				false,
				0
			},
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					SkinColors = new KnownColor[] { Defaults.One.KnownColor }
				},
				Defaults.Models.Specie,
				true,
				1
			},
		};
		public static IEnumerable<object[]> SearchSyncMemberData => new List<object[]>
		{ 
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Characters = new ICharacter.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new ISpecie.Default(0) { },
				new FuncsSync
				{
					Characters = () => Defaults.Models.CharacterEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Characters = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new ISpecie.Default(0) { },
				new FuncsSync { },
				false,
				0
			},
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Characters = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new ISpecie.Default(0) { },
				new FuncsSync
				{
					Characters = () => Defaults.Models.CharacterEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Characters = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new ISpecie.Default(0) { },
				new FuncsSync
				{
					Characters = () => Defaults.Models.CharacterEnumerable,
				},
				true,
				2
			},

			new object[]
			{
				new ISpecie.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Homeworld = new IPlanet.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new ISpecie.Default(0) { },
				new FuncsSync
				{
					Homeworld = () => Defaults.Models.Planet,
				},
				false,
				0
			},
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Homeworld = new IPlanet.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new ISpecie.Default(0) { },
				new FuncsSync { },
				false,
				0
			},
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Homeworld = new IPlanet.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new ISpecie.Default(0) { },
				new FuncsSync
				{
					Homeworld = () => Defaults.Models.Planet,
				},
				false,
				0
			},
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Homeworld = new IPlanet.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new ISpecie.Default(0) { },
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
				new ISpecie.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Characters = new ICharacter.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new ISpecie.Default(0) { },
				new FuncsAsync
				{
					Characters = () => Defaults.Models.CharacterAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Characters = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new ISpecie.Default(0) { },
				new FuncsAsync { },
				false,
				0
			},
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Characters = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new ISpecie.Default(0) { },
				new FuncsAsync
				{
					Characters = () => Defaults.Models.CharacterAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Characters = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new ISpecie.Default(0) { },
				new FuncsAsync
				{
					Characters = () => Defaults.Models.CharacterAsyncEnumerable(),
				},
				true,
				2
			},

			new object[]
			{
				new ISpecie.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Homeworld = new IPlanet.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new ISpecie.Default(0) { },
				new FuncsAsync
				{
					Homeworld = () => Task.FromResult<IPlanet?>(Defaults.Models.Planet),
				},
				false,
				0
			},
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Homeworld = new IPlanet.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new ISpecie.Default(0) { },
				new FuncsAsync { },
				false,
				0
			},
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Homeworld = new IPlanet.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new ISpecie.Default(0) { },
				new FuncsAsync
				{
					Homeworld = () => Task.FromResult<IPlanet?>(Defaults.Models.Planet),
				},
				false,
				0
			},
			new object[]
			{
				new ISpecie.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Homeworld = new IPlanet.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new ISpecie.Default(0) { },
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
		[Trait(nameof(ISpecie.ISearch), "")]
		public void Search(ISpecie.ISearch search, ISpecie specie, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("ISpecie.ISearch: ", _StringBuilder.Append(search).ToString());
			TestOutputHelper.WriteLine("ISpecie: ", specie.ToString(_StringBuilder));

			// Arrange
			// Act

			bool actualresult = search.ShouldReturnSpecie(specie);
			int actualmatchcount = search.GetMatchCount(specie);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}			  

		[Theory]
		[MemberData(nameof(SearchSyncMemberData))]
		[Trait(nameof(ISpecie.ISearch), "")]
		public void SearchSync(ISpecie.ISearch search, ISpecie specie, FuncsSync funcs, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("ISpecie.ISearch: ", _StringBuilder.Append(search).ToString());
			TestOutputHelper.WriteLine("ISpecie: ", specie.ToString(_StringBuilder));

			// Arrange
			// Act

			bool actualresult = search.ShouldReturnSpecie(specie, funcs.Characters, funcs.Homeworld);
			int actualmatchcount = search.GetMatchCount(specie, funcs.Characters, funcs.Homeworld);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}			  

		[Theory]
		[MemberData(nameof(SearchAsyncMemberData))]
		[Trait(nameof(ISpecie.ISearch), "")]
		public async void SearchAsync(ISpecie.ISearch search, ISpecie specie, FuncsAsync funcs, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("ISpecie.ISearch: ", _StringBuilder.Append(search).ToString());
			TestOutputHelper.WriteLine("ISpecie: ", specie.ToString(_StringBuilder));

			// Arrange
			// Act

			bool actualresult = await search.ShouldReturnSpecieAsync(specie, funcs.Characters, funcs.Homeworld, CancellationToken.None);
			int actualmatchcount = await search.GetMatchCountAsync(specie, funcs.Characters, funcs.Homeworld, CancellationToken.None);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}
	}
}
