using Localisation.Abstractions;
using Localisation.Abstractions.Planets;
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
		public void PlanetSingle(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IPlanetLocalisations localisation = new PlanetLocalisations();

			// Act

			IPlanetSingleLocalisation? singlelocalisation = null;

			Exception? exception = Record.Exception(() => singlelocalisation = localisation.PlanetSingle(cultureInfo));

			_OutputHelper.WriteLine(singlelocalisation?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(singlelocalisation);
		}
	}
}
