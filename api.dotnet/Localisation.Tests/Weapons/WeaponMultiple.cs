using Localisation.Abstractions;
using Localisation.Abstractions.Weapons;
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
		public void WeaponMultiple(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IWeaponLocalisations localisation = new WeaponLocalisations();

			// Act

			IWeaponMultipleLocalisation? multiplelocalisation = null;

			Exception? exception = Record.Exception(() => multiplelocalisation = localisation.WeaponMultiple(cultureInfo));

			_OutputHelper.WriteLine(multiplelocalisation?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(multiplelocalisation);
		}
	}
}
