using Localisation.Abstractions;
using Localisation.Abstractions.Characters;
using Localisation.Implementation;

using System;
using System.Globalization;

using Xunit;

namespace Localisation.Tests
{
	public partial class Characters
	{
		[Theory]
		[MemberData(nameof(CharactersMemberData))]
		[Trait("ICharacterLocalisation", "")]
		public void CharacterSearch(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using ICharacterLocalisations localisation = new CharacterLocalisations();

			// Act

			ICharacterSearchLocalisation? searchlocalisation = null;

			Exception? exception = Record.Exception(() => searchlocalisation = localisation.CharacterSearch(cultureInfo));

			_OutputHelper.WriteLine(searchlocalisation?.ToString(
				stringbuilder: _StringBuilder,
				converter: new ICharacterSearchLocalisation.Default<Func<object?, string>>(obj => obj?.ToString() ?? "null")) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(searchlocalisation);
		}
	}
}
