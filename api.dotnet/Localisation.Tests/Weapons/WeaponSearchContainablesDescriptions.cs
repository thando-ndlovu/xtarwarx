using Domain.Models;

using Localisation.Abstractions;
using Localisation.Implementation;

using System;
using System.Globalization;

using Xunit;

namespace Localisation.Tests
{
	public partial class Weapons
	{
		[Theory]
		[MemberData(nameof(WeaponsMemberData))]
		[Trait("IWeaponLocalisation", "")]
		public void WeaponSearchContainablesDescriptions(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IWeaponLocalisations localisation = new WeaponLocalisations();

			// Act

			IWeapon.ISearchContainables<string?>? searchcontainablesdescriptions = null;

			Exception? exception = Record.Exception(() => searchcontainablesdescriptions = localisation.WeaponSearchContainablesDescriptions(cultureInfo));

			_OutputHelper.WriteLine(_StringBuilder.Append(searchcontainablesdescriptions).ToString() ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(localisation);
		}
	}
}
