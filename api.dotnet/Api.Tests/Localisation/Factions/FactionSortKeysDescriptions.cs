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
		public void FactionSortKeysDescriptions(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IFactionLocalisations localisation = new FactionLocalisations();

			// Act

			IFaction.ISortKeys? sortkeysdescriptions = null;

			Exception? exception = Record.Exception(() => sortkeysdescriptions = localisation.FactionSortKeysDescriptions(cultureInfo));

			_OutputHelper.WriteLine(sortkeysdescriptions?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(sortkeysdescriptions);
		}
	}
}
