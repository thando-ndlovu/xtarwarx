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
		public void SpecieSearch(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using ISpecieLocalisations localisation = new SpecieLocalisations();

			// Act

			ISpecieSearchLocalisation? searchlocalisation = null;

			Exception? exception = Record.Exception(() => searchlocalisation = localisation.SpecieSearch(cultureInfo));

			_OutputHelper.WriteLine(searchlocalisation?.ToString(
				stringbuilder: _StringBuilder,
				converter: new ISpecieSearchLocalisation.Default<Func<object?, string>>(obj => obj?.ToString() ?? "null")) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(searchlocalisation);
		}
	}
}
