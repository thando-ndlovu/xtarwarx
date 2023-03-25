using Domain.Models;

using Localisation.Abstractions;
using Localisation.Implementation;

using System;
using System.Globalization;

using Xunit;

namespace Localisation.Tests
{
	public partial class Planets
	{
		[Theory]
		[MemberData(nameof(PlanetsMemberData))]
		[Trait("IPlanetLocalisation", "")]
		public void PlanetTitles(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IPlanetLocalisations localisation = new PlanetLocalisations();

			// Act

			IPlanet<string?>? titles = null;

			Exception? exception = Record.Exception(() => titles = localisation.PlanetTitles(cultureInfo));

			_OutputHelper.WriteLine(titles?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(titles);
		}
	}
}
