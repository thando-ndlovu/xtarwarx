using Domain.Models;

using System.Collections.Generic;

using Xunit;

namespace Domain.Tests.Models
{
	public partial class Faction
	{
		public static IEnumerable<object[]> SearchContainablesMemberData => new List<object[]>
		{
			new object[]
			{
				Defaults.Zero.String,
				Defaults.Models.Faction,
				new IFaction.ISearchContainables.Default
				{
					Description = true,
					Name = true,
					OrganizationTypes = true,
				},
				false,
				0
			}, 

			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Faction,
				new IFaction.ISearchContainables.Default
				{
					Description = false,
					Name = false,
					OrganizationTypes = false,
				},
				false,
				0
			},	  

			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Faction,
				new IFaction.ISearchContainables.Default
				{
					Description = true,
					Name = false,
					OrganizationTypes = false,
				},
				true,
				1
			},
			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Faction,
				new IFaction.ISearchContainables.Default
				{
					Description = false,
					Name = true,
					OrganizationTypes = false,
				},
				true,
				1
			}, 
			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Faction,
				new IFaction.ISearchContainables.Default
				{
					Description = false,
					Name = false,
					OrganizationTypes = true,
				},
				true,
				1
			},	

			new object[]
			{
				Defaults.One.String,
				new IFaction.Default(0)
				{
					Description = Defaults.One.String,
					Name = Defaults.One.String,
					OrganizationTypes = new string[] { Defaults.One.String, Defaults.One.String }
				},
				new IFaction.ISearchContainables.Default
				{
					Description = false,
					Name = false,
					OrganizationTypes = true,
				},
				true,
				2
			},
		};

		[Theory]
		[MemberData(nameof(SearchContainablesMemberData))]
		[Trait(nameof(IFaction.ISearchContainables), "")]
		public void SearchContainables(string searchstring, IFaction faction, IFaction.ISearchContainables searchcontainables, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("SearchString: ", searchstring);
			TestOutputHelper.WriteLine("IFaction: ", faction.ToString(stringBuilder: null));
			TestOutputHelper.WriteLine("IFaction.ISearchContainables: ", _StringBuilder.Append(searchcontainables).ToString());

			// Arrange
			// Act

			bool actualresult = searchcontainables.ShouldReturnFaction(faction, searchstring, out int actualmatchcount);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}
	}
}
