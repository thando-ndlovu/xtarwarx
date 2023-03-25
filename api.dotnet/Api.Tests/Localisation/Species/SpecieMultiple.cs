using Localisation.Abstractions;
using Localisation.Abstractions.Species;
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
		public void SpecieMultiple(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using ISpecieLocalisations localisation = new SpecieLocalisations();

			// Act

			ISpecieMultipleLocalisation? multiplelocalisation = null;

			Exception? exception = Record.Exception(() => multiplelocalisation = localisation.SpecieMultiple(cultureInfo));

			_OutputHelper.WriteLine(multiplelocalisation?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(multiplelocalisation);
		}
	}
}
