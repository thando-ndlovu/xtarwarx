using Domain.Models;

using System.Collections.Generic;

using Xunit;

namespace Domain.Tests.Models
{
	public partial class Film
	{
		public static IEnumerable<object[]> SearchContainablesMemberData => new List<object[]>
		{
			new object[]
			{
				Defaults.Zero.String,    
				Defaults.Models.Film,
				new IFilm.ISearchContainables.Default
				{
					CastMembers = true,
					Description = true,
					Director = true,
					OpeningCrawl = true,
					Producers = true,
					Title = true,
				},
				false,
				0
			}, 

			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Film,
				new IFilm.ISearchContainables.Default
				{
					CastMembers = false,
					Description = false,
					Director = false,
					OpeningCrawl = false,
					Producers = false,
					Title = false,
				},
				false,
				0
			},	  

			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Film,
				new IFilm.ISearchContainables.Default
				{
					CastMembers = true,
					Description = false,
					Director = false,
					OpeningCrawl = false,
					Producers = false,
					Title = false,
				},
				true,
				1
			},
			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Film,
				new IFilm.ISearchContainables.Default
				{
					CastMembers = false,
					Description = true,
					Director = false,
					OpeningCrawl = false,
					Producers = false,
					Title = false,
				},
				true,
				1
			},
			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Film,
				new IFilm.ISearchContainables.Default
				{
					CastMembers = false,
					Description = false,
					Director = true,
					OpeningCrawl = false,
					Producers = false,
					Title = false,
				},
				true,
				1
			},
			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Film,
				new IFilm.ISearchContainables.Default
				{
					CastMembers = false,
					Description = false,
					Director = false,
					OpeningCrawl = true,
					Producers = false,
					Title = false,
				},
				true,
				1
			},
			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Film,
				new IFilm.ISearchContainables.Default
				{
					CastMembers = false,
					Description = false,
					Director = false,
					OpeningCrawl = false,
					Producers = true,
					Title = false,
				},
				true,
				1
			},
			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Film,
				new IFilm.ISearchContainables.Default
				{
					CastMembers = false,
					Description = false,
					Director = false,
					OpeningCrawl = false,
					Producers = false,
					Title = true,
				},
				true,
				1
			},

			new object[]
			{
				Defaults.One.String,
				new IFilm.Default(0)
				{
					CastMembers = new string[] { Defaults.One.String, Defaults.One.String },
					Description = Defaults.One.String,
					Director = Defaults.One.String,
					OpeningCrawl = Defaults.One.String,
					Producers = new string[] { Defaults.One.String, Defaults.One.String },
					Title = Defaults.One.String,
				},
				new IFilm.ISearchContainables.Default
				{
					CastMembers = true,
					Description = false,
					Director = false,
					OpeningCrawl = false,
					Producers = false,
					Title = false,
				},
				true,
				2
			},
			new object[]
			{
				Defaults.One.String,
				new IFilm.Default(0)
				{
					CastMembers = new string[] { Defaults.One.String, Defaults.One.String },
					Description = Defaults.One.String,
					Director = Defaults.One.String,
					OpeningCrawl = Defaults.One.String,
					Producers = new string[] { Defaults.One.String, Defaults.One.String },
					Title = Defaults.One.String,
				},
				new IFilm.ISearchContainables.Default
				{
					CastMembers = false,
					Description = false,
					Director = false,
					OpeningCrawl = false,
					Producers = true,
					Title = false,
				},
				true,
				2
			},
		};

		[Theory]
		[MemberData(nameof(SearchContainablesMemberData))]
		[Trait(nameof(IFilm.ISearchContainables), "")]
		public void SearchContainables(string searchstring, IFilm film, IFilm.ISearchContainables searchcontainables, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("SearchString: ", searchstring);
			TestOutputHelper.WriteLine("IFilm: ", film.ToString(stringBuilder: null));
			TestOutputHelper.WriteLine("IFilm.ISearchContainables: ", _StringBuilder.Append(searchcontainables).ToString());

			// Arrange
			// Act

			bool actualresult = searchcontainables.ShouldReturnFilm(film, searchstring, out int actualmatchcount);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}
	}
}
