using Domain.Models;

using Localisation.Abstractions;
using Localisation.Implementation;

using System;
using System.Globalization;

using Xunit;

namespace Localisation.Tests
{
	public partial class Species
	{
		[Theory]
		[MemberData(nameof(SpeciesMemberData))]
		[Trait("ISpecieLocalisation", "")]
		public void SpecieTitles(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using ISpecieLocalisations localisation = new SpecieLocalisations();

			// Act

			ISpecie<string?>? titles = null;

			Exception? exception = Record.Exception(() => titles = localisation.SpecieTitles(cultureInfo));

			_OutputHelper.WriteLine(titles?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(titles);
		}
	}
}
