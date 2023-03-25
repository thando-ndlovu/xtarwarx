using Localisation.Abstractions;
using Localisation.Abstractions.Starships;
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
		public void StarshipMultiple(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IStarshipLocalisations localisation = new StarshipLocalisations();

			// Act

			IStarshipMultipleLocalisation? multiplelocalisation = null;

			Exception? exception = Record.Exception(() => multiplelocalisation = localisation.StarshipMultiple(cultureInfo));

			_OutputHelper.WriteLine(multiplelocalisation?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(multiplelocalisation);
		}
	}
}
