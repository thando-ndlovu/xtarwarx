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
		public void PlanetSearch(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IPlanetLocalisations localisation = new PlanetLocalisations();

			// Act

			IPlanetSearchLocalisation? searchlocalisation = null;

			Exception? exception = Record.Exception(() => searchlocalisation = localisation.PlanetSearch(cultureInfo));

			_OutputHelper.WriteLine(searchlocalisation?.ToString(
				stringbuilder: _StringBuilder,
				converter: new IPlanetSearchLocalisation.Default<Func<object?, string>>(obj => obj?.ToString() ?? "null")) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(searchlocalisation);
		}
	}
}
