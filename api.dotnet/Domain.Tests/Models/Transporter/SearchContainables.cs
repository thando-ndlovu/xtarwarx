using Domain.Models;

using System.Collections.Generic;

using Xunit;

namespace Domain.Tests.Models
{
	public partial class Transporter
	{
		public static IEnumerable<object[]> SearchContainablesMemberData => new List<object[]>
		{
			new object[]
			{
				Defaults.Zero.String,
				Defaults.Models.Transporter,
				new ITransporter.ISearchContainables.Default
				{
					Description = true,
					Model = true,
					Name = true,
				},
				false,
				0
			}, 

			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Transporter,
				new ITransporter.ISearchContainables.Default
				{
					Description = false,
					Model = false,
					Name = false,
				},
				false,
				0
			},	  

			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Transporter,
				new ITransporter.ISearchContainables.Default
				{
					Description = true,
					Model = false,
					Name = false,
				},
				true,
				1
			},
			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Transporter,
				new ITransporter.ISearchContainables.Default
				{
					Description = false,
					Model = true,
					Name = false,
				},
				true,
				1
			},
			new object[]
			{
				Defaults.One.String,
				Defaults.Models.Transporter,
				new ITransporter.ISearchContainables.Default
				{
					Description = false,
					Model = false,
					Name = true,
				},
				true,
				1
			},
		};

		[Theory]
		[MemberData(nameof(SearchContainablesMemberData))]
		[Trait(nameof(ITransporter.ISearchContainables), "")]
		public void SearchContainables(string searchstring, ITransporter transporter, ITransporter.ISearchContainables searchcontainables, bool expectedresult, int expectedmatchcount)
		{
			TestOutputHelper.WriteLine("SearchString: ", searchstring);
			TestOutputHelper.WriteLine("ITransporter: ", transporter.ToString(stringBuilder: null));
			TestOutputHelper.WriteLine("ITransporter.ISearchContainables: ", _StringBuilder.Append(searchcontainables).ToString());

			// Arrange
			// Act

			bool actualresult = searchcontainables.ShouldReturnTransporter(transporter, searchstring, out int actualmatchcount);

			// Assert

			Assert.Equal(expectedresult, actualresult);
			Assert.Equal(expectedmatchcount, actualmatchcount);
		}
	}
}
