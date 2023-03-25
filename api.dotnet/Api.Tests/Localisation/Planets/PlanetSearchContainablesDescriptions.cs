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
		public void PlanetSearchContainablesDescriptions(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IPlanetLocalisations localisation = new PlanetLocalisations();

			// Act

			IPlanet.ISearchContainables<string?>? searchcontainablesdescriptions = null;

			Exception? exception = Record.Exception(() => searchcontainablesdescriptions = localisation.PlanetSearchContainablesDescriptions(cultureInfo));

			_OutputHelper.WriteLine(_StringBuilder.Append(searchcontainablesdescriptions).ToString() ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(localisation);
		}
	}
}
