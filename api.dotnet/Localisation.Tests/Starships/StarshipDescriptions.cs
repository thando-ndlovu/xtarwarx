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
		public void StarshipDescriptions(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IStarshipLocalisations localisation = new StarshipLocalisations();

			// Act

			IStarship<string?>? descriptions = null;

			Exception? exception = Record.Exception(() => descriptions = localisation.StarshipDescriptions(cultureInfo));

			_OutputHelper.WriteLine(descriptions?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(descriptions);
		}
	}
}
