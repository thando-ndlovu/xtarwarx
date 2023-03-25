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
		public void FilmSearchContainablesTitles(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IFilmLocalisations localisation = new FilmLocalisations();

			// Act

			IFilm.ISearchContainables<string?>? searchcontainablestitles = null;

			Exception? exception = Record.Exception(() => searchcontainablestitles = localisation.FilmSearchContainablesTitles(cultureInfo));

			_OutputHelper.WriteLine(_StringBuilder.Append(searchcontainablestitles).ToString() ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(searchcontainablestitles);
		}
	}
}
