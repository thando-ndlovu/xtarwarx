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
		public void SpecieSearchContainablesTitles(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using ISpecieLocalisations localisation = new SpecieLocalisations();

			// Act

			ISpecie.ISearchContainables<string?>? searchcontainablestitles = null;

			Exception? exception = Record.Exception(() => searchcontainablestitles = localisation.SpecieSearchContainablesTitles(cultureInfo));

			_OutputHelper.WriteLine(_StringBuilder.Append(searchcontainablestitles).ToString() ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(searchcontainablestitles);
		}
	}
}
