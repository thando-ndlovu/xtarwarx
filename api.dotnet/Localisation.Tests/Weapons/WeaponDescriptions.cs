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
		public void WeaponDescriptions(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IWeaponLocalisations localisation = new WeaponLocalisations();

			// Act

			IWeapon<string?>? descriptions = null;

			Exception? exception = Record.Exception(() => descriptions = localisation.WeaponDescriptions(cultureInfo));

			_OutputHelper.WriteLine(descriptions?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(descriptions);
		}
	}
}
