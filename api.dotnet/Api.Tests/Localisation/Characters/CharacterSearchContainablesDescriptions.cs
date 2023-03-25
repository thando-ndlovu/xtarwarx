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
		public void CharacterSearchContainablesDescriptions(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using ICharacterLocalisations localisation = new CharacterLocalisations();

			// Act

			ICharacter.ISearchContainables<string?>? searchcontainablesdescriptions = null;

			Exception? exception = Record.Exception(() => searchcontainablesdescriptions = localisation.CharacterSearchContainablesDescriptions(cultureInfo));

			_OutputHelper.WriteLine(_StringBuilder.Append(searchcontainablesdescriptions).ToString() ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(localisation);
		}
	}
}
