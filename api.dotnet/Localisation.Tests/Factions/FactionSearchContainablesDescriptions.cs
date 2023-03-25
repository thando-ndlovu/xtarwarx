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
		public void FactionSearchContainablesDescriptions(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IFactionLocalisations localisation = new FactionLocalisations();

			// Act

			IFaction.ISearchContainables<string?>? searchcontainablesdescriptions = null;

			Exception? exception = Record.Exception(() => searchcontainablesdescriptions = localisation.FactionSearchContainablesDescriptions(cultureInfo));

			_OutputHelper.WriteLine(_StringBuilder.Append(searchcontainablesdescriptions).ToString() ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(localisation);
		}
	}
}
