using Domain.Models;

using Localisation.Abstractions;
using Localisation.Implementation;

using System;
using System.Globalization;

using Xunit;

namespace Localisation.Tests
{
	public partial class Starships
	{
		[Theory]
		[MemberData(nameof(StarshipsMemberData))]
		[Trait("IStarshipLocalisation", "")]
		public void StarshipSortKeysTitles(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IStarshipLocalisations localisation = new StarshipLocalisations();

			// Act

			IStarship.ISortKeys? sortkeystitles = null;

			Exception? exception = Record.Exception(() => sortkeystitles = localisation.StarshipSortKeysTitles(cultureInfo));

			_OutputHelper.WriteLine(sortkeystitles?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(sortkeystitles);
		}
	}
}
