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
		public void WeaponSearch(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IWeaponLocalisations localisation = new WeaponLocalisations();

			// Act

			IWeaponSearchLocalisation? searchlocalisation = null;

			Exception? exception = Record.Exception(() => searchlocalisation = localisation.WeaponSearch(cultureInfo));

			_OutputHelper.WriteLine(searchlocalisation?.ToString(
				stringbuilder: _StringBuilder,
				converter: new IWeaponSearchLocalisation.Default<Func<object?, string>>(obj => obj?.ToString() ?? "null")) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(searchlocalisation);
		}
	}
}
