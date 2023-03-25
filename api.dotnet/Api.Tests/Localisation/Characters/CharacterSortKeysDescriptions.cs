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
		public void CharacterSortKeysDescriptions(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using ICharacterLocalisations localisation = new CharacterLocalisations();

			// Act

			ICharacter.ISortKeys? sortkeysdescriptions = null;

			Exception? exception = Record.Exception(() => sortkeysdescriptions = localisation.CharacterSortKeysDescriptions(cultureInfo));

			_OutputHelper.WriteLine(sortkeysdescriptions?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(sortkeysdescriptions);
		}
	}
}
