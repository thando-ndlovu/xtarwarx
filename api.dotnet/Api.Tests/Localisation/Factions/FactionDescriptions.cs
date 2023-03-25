using Domain.Models;

using Localisation.Abstractions;
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
		public void FactionDescriptions(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IFactionLocalisations localisation = new FactionLocalisations();

			// Act

			IFaction<string?>? descriptions = null;

			Exception? exception = Record.Exception(() => descriptions = localisation.FactionDescriptions(cultureInfo));

			_OutputHelper.WriteLine(descriptions?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(descriptions);
		}
	}
}
