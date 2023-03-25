using Domain.Models;

using Localisation.Abstractions;
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
		public void FilmDescriptions(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IFilmLocalisations localisation = new FilmLocalisations();

			// Act

			IFilm<string?>? descriptions = null;

			Exception? exception = Record.Exception(() => descriptions = localisation.FilmDescriptions(cultureInfo));

			_OutputHelper.WriteLine(descriptions?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(descriptions);
		}
	}
}
