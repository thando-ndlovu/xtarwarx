using Domain.Models;

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using Xunit;

namespace Domain.Tests.Models
{
	public partial class Faction
	{
		public class FuncsSync
		{
			public Func<IEnumerable<ICharacter>>? AlliedCharacters { get; set; }
			public Func<IEnumerable<IFaction>>? AlliedFactions { get; set; }			
			public Func<IEnumerable<ICharacter>>? Leaders { get; set; }
			public Func<IEnumerable<ICharacter>>? MemberCharacters { get; set; }
			public Func<IEnumerable<IFaction>>? MemberFactions { get; set; }
		}		
		public class FuncsAsync
		{
			public Func<IAsyncEnumerable<ICharacter>>? AlliedCharacters { get; set; }
			public Func<IAsyncEnumerable<IFaction>>? AlliedFactions { get; set; }			
			public Func<IAsyncEnumerable<ICharacter>>? Leaders { get; set; }
			public Func<IAsyncEnumerable<ICharacter>>? MemberCharacters { get; set; }
			public Func<IAsyncEnumerable<IFaction>>? MemberFactions { get; set; }
		}

		public static IEnumerable<object[]> SearchMemberData => new List<object[]>
		{
			new object[]
			{
				new IFaction.ISearch.Default{ },
				Defaults.Models.Faction,
				false,
				0
			},
		};
		public static IEnumerable<object[]> SearchSyncMemberData => new List<object[]>
		{
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					AlliedCharacters = new ICharacter.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new IFaction.Default(0) { },
				new FuncsSync
				{
					AlliedCharacters = () => Defaults.Models.CharacterEnumerable,
				},
				false,
				0
			}, 	
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					AlliedCharacters = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsSync { },
				false,
				0
			},		 
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					AlliedCharacters = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsSync
				{
					AlliedCharacters = () => Defaults.Models.CharacterEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					AlliedCharacters = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsSync
				{
					AlliedCharacters = () => Defaults.Models.CharacterEnumerable,
				},
				true,
				2
			},

			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					AlliedFactions = new IFaction.ISearchContainables.Default
					{
						Description = false,
						Name = false,
						OrganizationTypes = false,
					},
				},
				new IFaction.Default(0) { },
				new FuncsSync
				{
					AlliedFactions = () => Defaults.Models.FactionEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					AlliedFactions = new IFaction.ISearchContainables.Default
					{
						Description = true,
						Name = true,
						OrganizationTypes = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsSync { },
				false,
				0
			},
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					AlliedFactions = new IFaction.ISearchContainables.Default
					{
						Description = true,
						Name = true,
						OrganizationTypes = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsSync
				{
					AlliedFactions = () => Defaults.Models.FactionEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					AlliedFactions = new IFaction.ISearchContainables.Default
					{
						Description = true,
						Name = true,
						OrganizationTypes = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsSync
				{
					AlliedFactions = () => Defaults.Models.FactionEnumerable,
				},
				true,
				3
			},

			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Leaders = new ICharacter.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new IFaction.Default(0) { },
				new FuncsSync
				{
					Leaders = () => Defaults.Models.CharacterEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Leaders = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsSync { },
				false,
				0
			},
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Leaders = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsSync
				{
					Leaders = () => Defaults.Models.CharacterEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Leaders = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsSync
				{
					Leaders = () => Defaults.Models.CharacterEnumerable,
				},
				true,
				2
			},

			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					MemberCharacters = new ICharacter.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new IFaction.Default(0) { },
				new FuncsSync
				{
					MemberCharacters = () => Defaults.Models.CharacterEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					MemberCharacters = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsSync { },
				false,
				0
			},
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					MemberCharacters = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsSync
				{
					MemberCharacters = () => Defaults.Models.CharacterEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					MemberCharacters = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsSync
				{
					MemberCharacters = () => Defaults.Models.CharacterEnumerable,
				},
				true,
				2
			},

			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					MemberFactions = new IFaction.ISearchContainables.Default
					{
						Description = false,
						Name = false,
						OrganizationTypes = false,
					},
				},
				new IFaction.Default(0) { },
				new FuncsSync
				{
					MemberFactions = () => Defaults.Models.FactionEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					MemberFactions = new IFaction.ISearchContainables.Default
					{
						Description = true,
						Name = true,
						OrganizationTypes = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsSync { },
				false,
				0
			},
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					MemberFactions = new IFaction.ISearchContainables.Default
					{
						Description = true,
						Name = true,
						OrganizationTypes = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsSync
				{
					MemberFactions = () => Defaults.Models.FactionEnumerable,
				},
				false,
				0
			},
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					MemberFactions = new IFaction.ISearchContainables.Default
					{
						Description = true,
						Name = true,
						OrganizationTypes = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsSync
				{
					MemberFactions = () => Defaults.Models.FactionEnumerable,
				},
				true,
				3
			},
		};
		public static IEnumerable<object[]> SearchAsyncMemberData => new List<object[]>
		{
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					AlliedCharacters = new ICharacter.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new IFaction.Default(0) { },
				new FuncsAsync
				{
					AlliedCharacters = () => Defaults.Models.CharacterAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					AlliedCharacters = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsAsync { },
				false,
				0
			},
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					AlliedCharacters = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsAsync
				{
					AlliedCharacters = () => Defaults.Models.CharacterAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					AlliedCharacters = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsAsync
				{
					AlliedCharacters = () => Defaults.Models.CharacterAsyncEnumerable(),
				},
				true,
				2
			},

			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					AlliedFactions = new IFaction.ISearchContainables.Default
					{
						Description = false,
						Name = false,
						OrganizationTypes = false,
					},
				},
				new IFaction.Default(0) { },
				new FuncsAsync
				{
					AlliedFactions = () => Defaults.Models.FactionAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					AlliedFactions = new IFaction.ISearchContainables.Default
					{
						Description = true,
						Name = true,
						OrganizationTypes = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsAsync { },
				false,
				0
			},
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					AlliedFactions = new IFaction.ISearchContainables.Default
					{
						Description = true,
						Name = true,
						OrganizationTypes = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsAsync
				{
					AlliedFactions = () => Defaults.Models.FactionAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					AlliedFactions = new IFaction.ISearchContainables.Default
					{
						Description = true,
						Name = true,
						OrganizationTypes = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsAsync
				{
					AlliedFactions = () => Defaults.Models.FactionAsyncEnumerable(),
				},
				true,
				3
			},

			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Leaders = new ICharacter.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new IFaction.Default(0) { },
				new FuncsAsync
				{
					Leaders = () => Defaults.Models.CharacterAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Leaders = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsAsync { },
				false,
				0
			},
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					Leaders = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsAsync
				{
					Leaders = () => Defaults.Models.CharacterAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					Leaders = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsAsync
				{
					Leaders = () => Defaults.Models.CharacterAsyncEnumerable(),
				},
				true,
				2
			},

			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					MemberCharacters = new ICharacter.ISearchContainables.Default
					{
						Description = false,
						Name = false,
					},
				},
				new IFaction.Default(0) { },
				new FuncsAsync
				{
					MemberCharacters = () => Defaults.Models.CharacterAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					MemberCharacters = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsAsync { },
				false,
				0
			},
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					MemberCharacters = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsAsync
				{
					MemberCharacters = () => Defaults.Models.CharacterAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					MemberCharacters = new ICharacter.ISearchContainables.Default
					{
						Description = true,
						Name = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsAsync
				{
					MemberCharacters = () => Defaults.Models.CharacterAsyncEnumerable(),
				},
				true,
				2
			},

			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					MemberFactions = new IFaction.ISearchContainables.Default
					{
						Description = false,
						Name = false,
						OrganizationTypes = false,
					},
				},
				new IFaction.Default(0) { },
				new FuncsAsync
				{
					MemberFactions = () => Defaults.Models.FactionAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					MemberFactions = new IFaction.ISearchContainables.Default
					{
						Description = true,
						Name = true,
						OrganizationTypes = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsAsync { },
				false,
				0
			},
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.Zero.String,

					MemberFactions = new IFaction.ISearchContainables.Default
					{
						Description = true,
						Name = true,
						OrganizationTypes = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsAsync
				{
					MemberFactions = () => Defaults.Models.FactionAsyncEnumerable(),
				},
				false,
				0
			},
			new object[]
			{
				new IFaction.ISearch.Default
				{
					SearchString = Defaults.One.String,

					MemberFactions = new IFaction.ISearchContainables.Default
					{
						Description = true,
						Name = true,
						OrganizationTypes = true,
					},
				},
				new IFaction.Default(0) { },
				new FuncsAsync
				{
					MemberFactions = () => Defaults.Models.FactionAsyncEnumerable(),
				},
				true,
				3
			},
		};

		[Theory]
		[MemberData(nameof(SearchMemberData))]
		[Trait(nameof(IFaction.ISearch), "")]
		public void Search(IFaction.ISearch search, IFaction faction, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("IFaction.ISearch: ", _StringBuilder.Append(search).ToString());
			TestOutputHelper.WriteLine("IFaction: ", faction.ToString(_StringBuilder));

			// Arrange
			// Act

			bool actualresult = search.ShouldReturnFaction(faction);
			int actualmatchcount = search.GetMatchCount(faction);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}				 

		[Theory]
		[MemberData(nameof(SearchSyncMemberData))]
		[Trait(nameof(IFaction.ISearch), "")]
		public void SearchSync(IFaction.ISearch search, IFaction faction, FuncsSync funcs, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("IFaction.ISearch: ", _StringBuilder.Append(search).ToString());
			TestOutputHelper.WriteLine("IFaction: ", faction.ToString(_StringBuilder));

			// Arrange
			// Act

			bool actualresult = search.ShouldReturnFaction(faction, funcs.AlliedCharacters, funcs.AlliedFactions, funcs.Leaders, funcs.MemberCharacters, funcs.MemberFactions);
			int actualmatchcount = search.GetMatchCount(faction, funcs.AlliedCharacters, funcs.AlliedFactions, funcs.Leaders, funcs.MemberCharacters, funcs.MemberFactions);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}				 

		[Theory]
		[MemberData(nameof(SearchAsyncMemberData))]
		[Trait(nameof(IFaction.ISearch), "")]
		public async void SearchAsync(IFaction.ISearch search, IFaction faction, FuncsAsync funcs, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("IFaction.ISearch: ", _StringBuilder.Append(search).ToString());
			TestOutputHelper.WriteLine("IFaction: ", faction.ToString(_StringBuilder));

			// Arrange
			// Act

			bool actualresult = await search.ShouldReturnFactionAsync(faction, funcs.AlliedCharacters, funcs.AlliedFactions, funcs.Leaders, funcs.MemberCharacters, funcs.MemberFactions, CancellationToken.None);
			int actualmatchcount = await search.GetMatchCountAsync(faction, funcs.AlliedCharacters, funcs.AlliedFactions, funcs.Leaders, funcs.MemberCharacters, funcs.MemberFactions, CancellationToken.None);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}
	}
}
