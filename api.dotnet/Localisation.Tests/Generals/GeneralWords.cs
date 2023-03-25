using Localisation.Abstractions;
using Localisation.Abstractions.General;
using Localisation.Implementation;

using System;
using System.Globalization;
using System.Text;

using Xunit;

namespace Localisation.Tests
{
	public partial class General
	{
		[Theory]
		[MemberData(nameof(GeneralMemberData))]
		[Trait("IGeneralLocalisation", "")]
		public void GeneralWords(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IGeneralLocalisations generalLocalisation = new GeneralLocalisations();

			// Act

			IGeneralWords? generalWords = null;

			Exception? exception = Record.Exception(() => generalWords = generalLocalisation.GeneralWords(cultureInfo));

			_OutputHelper.WriteLine(generalWords?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(generalWords);
		}
	}
}
