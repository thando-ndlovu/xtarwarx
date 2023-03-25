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
		public void CharacterSearchContainablesTitles(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using ICharacterLocalisations localisation = new CharacterLocalisations();

			// Act

			ICharacter.ISearchContainables<string?>? searchcontainablestitles = null;

			Exception? exception = Record.Exception(() => searchcontainablestitles = localisation.CharacterSearchContainablesTitles(cultureInfo));

			_OutputHelper.WriteLine(_StringBuilder.Append(searchcontainablestitles).ToString() ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(searchcontainablestitles);
		}
	}
}
