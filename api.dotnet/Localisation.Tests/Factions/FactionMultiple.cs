using Localisation.Abstractions;
using Localisation.Abstractions.Factions;
using Localisation.Implementation;

using System;
using System.Globalization;

using Xunit;

namespace Localisation.Tests
{
	public partial class Factions
	{
		[Theory]
		[MemberData(nameof(FactionsMemberData))]
		[Trait("IFactionLocalisation", "")]
		public void FactionMultiple(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IFactionLocalisations localisation = new FactionLocalisations();

			// Act

			IFactionMultipleLocalisation? multiplelocalisation = null;

			Exception? exception = Record.Exception(() => multiplelocalisation = localisation.FactionMultiple(cultureInfo));

			_OutputHelper.WriteLine(multiplelocalisation?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(multiplelocalisation);
		}
	}
}
