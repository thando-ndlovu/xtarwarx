using Localisation.Abstractions;
using Localisation.Abstractions.General;
using Localisation.Implementation;

using System;
using System.Globalization;

using Xunit;

namespace Localisation.Tests
{
	public partial class General
	{
		[Theory]
		[MemberData(nameof(GeneralMemberData))]
		[Trait("IGeneralLocalisation", "")]
		public void GeneralPhrases(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IGeneralLocalisations generalLocalisation = new GeneralLocalisations();

			// Act

			IGeneralPhrases? generalphrases = null;

			Exception? exception = Record.Exception(() => generalphrases = generalLocalisation.GeneralPhrases(cultureInfo));

			_OutputHelper.WriteLine(generalphrases?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(generalphrases);
		}
	}
}
