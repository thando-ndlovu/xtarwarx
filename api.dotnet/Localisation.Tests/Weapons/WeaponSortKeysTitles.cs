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
		public void WeaponSortKeysTitles(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IWeaponLocalisations localisation = new WeaponLocalisations();

			// Act

			IWeapon.ISortKeys? sortkeystitles = null;

			Exception? exception = Record.Exception(() => sortkeystitles = localisation.WeaponSortKeysTitles(cultureInfo));

			_OutputHelper.WriteLine(sortkeystitles?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(sortkeystitles);
		}
	}
}
