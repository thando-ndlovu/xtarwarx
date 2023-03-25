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
		public void StarshipSingle(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IStarshipLocalisations localisation = new StarshipLocalisations();

			// Act

			IStarshipSingleLocalisation? singlelocalisation = null;

			Exception? exception = Record.Exception(() => singlelocalisation = localisation.StarshipSingle(cultureInfo));

			_OutputHelper.WriteLine(singlelocalisation?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(singlelocalisation);
		}
	}
}
