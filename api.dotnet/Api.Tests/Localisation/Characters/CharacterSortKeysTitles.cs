using Domain.Models;

using Localisation.Abstractions;
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
		public void CharacterSortKeysTitles(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using ICharacterLocalisations localisation = new CharacterLocalisations();

			// Act

			ICharacter.ISortKeys? sortkeystitles = null;

			Exception? exception = Record.Exception(() => sortkeystitles = localisation.CharacterSortKeysTitles(cultureInfo));

			_OutputHelper.WriteLine(sortkeystitles?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(sortkeystitles);
		}
	}
}
