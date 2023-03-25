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
		public void SpecieDescriptions(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using ISpecieLocalisations localisation = new SpecieLocalisations();

			// Act

			ISpecie<string?>? descriptions = null;

			Exception? exception = Record.Exception(() => descriptions = localisation.SpecieDescriptions(cultureInfo));

			_OutputHelper.WriteLine(descriptions?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(descriptions);
		}
	}
}
