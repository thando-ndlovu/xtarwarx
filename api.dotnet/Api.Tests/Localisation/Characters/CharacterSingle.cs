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
		public void CharacterSingle(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using ICharacterLocalisations localisation = new CharacterLocalisations();

			// Act

			ICharacterSingleLocalisation? singlelocalisation = null;

			Exception? exception = Record.Exception(() => singlelocalisation = localisation.CharacterSingle(cultureInfo));

			_OutputHelper.WriteLine(singlelocalisation?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(singlelocalisation);
		}
	}
}
