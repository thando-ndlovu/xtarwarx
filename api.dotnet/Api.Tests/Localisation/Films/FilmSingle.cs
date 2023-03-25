using Localisation.Abstractions;
using Localisation.Abstractions.Films;
using Localisation.Implementation;

using System;
using System.Globalization;

using Xunit;

namespace Localisation.Tests
{
	public partial class Films
	{
		[Theory]
		[MemberData(nameof(FilmsMemberData))]
		[Trait("IFilmLocalisation", "")]
		public void FilmSingle(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IFilmLocalisations localisation = new FilmLocalisations();

			// Act

			IFilmSingleLocalisation? singlelocalisation = null;

			Exception? exception = Record.Exception(() => singlelocalisation = localisation.FilmSingle(cultureInfo));

			_OutputHelper.WriteLine(singlelocalisation?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(singlelocalisation);
		}
	}
}
