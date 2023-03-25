using Domain.Models;

using System.Collections.Generic;

using Xunit;

namespace Domain.Tests.Models
{
	public partial class Specie
	{
		public static IEnumerable<object[]> SearchContainablesMemberData => new List<object[]>
		{
			new object[]
			{
				Defaults.Zero.String,
				Defaults.Models.Specie,
				new ISpecie.ISearchContainables.Default
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
				Defaults.Models.Specie,
				new ISpecie.ISearchContainables.Default
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
				Defaults.Models.Specie,
				new ISpecie.ISearchContainables.Default
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
				Defaults.Models.Specie,
				new ISpecie.ISearchContainables.Default
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
				Defaults.Models.Specie,
				new ISpecie.ISearchContainables.Default
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
		[Trait(nameof(ISpecie.ISearchContainables), "")]
		public void SearchContainables(string searchstring, ISpecie specie, ISpecie.ISearchContainables searchcontainables, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("SearchString: ", searchstring);
			TestOutputHelper.WriteLine("ISpecie: ", specie.ToString(stringBuilder: null));
			TestOutputHelper.WriteLine("ISpecie.ISearchContainables: ", _StringBuilder.Append(searchcontainables).ToString());

			// Arrange
			// Act

			bool actualresult = searchcontainables.ShouldReturnSpecie(specie, searchstring, out int actualmatchcount);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}
	}
}
