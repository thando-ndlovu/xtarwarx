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
		public void StarshipSearch(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IStarshipLocalisations localisation = new StarshipLocalisations();

			// Act

			IStarshipSearchLocalisation? searchlocalisation = null;

			Exception? exception = Record.Exception(() => searchlocalisation = localisation.StarshipSearch(cultureInfo));

			_OutputHelper.WriteLine(searchlocalisation?.ToString(
				stringbuilder: _StringBuilder,
				converter: new IStarshipSearchLocalisation.Default<Func<object?, string>>(obj => obj?.ToString() ?? "null")) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(searchlocalisation);
		}
	}
}
