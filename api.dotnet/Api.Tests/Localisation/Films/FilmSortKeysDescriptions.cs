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
		public void FilmSortKeysDescriptions(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IFilmLocalisations localisation = new FilmLocalisations();

			// Act

			IFilm.ISortKeys? sortkeysdescriptions = null;

			Exception? exception = Record.Exception(() => sortkeysdescriptions = localisation.FilmSortKeysDescriptions(cultureInfo));

			_OutputHelper.WriteLine(sortkeysdescriptions?.ToString(_StringBuilder) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(sortkeysdescriptions);
		}
	}
}
