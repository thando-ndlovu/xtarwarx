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
		public void FilmSearchContainablesDescriptions(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IFilmLocalisations localisation = new FilmLocalisations();

			// Act

			IFilm.ISearchContainables<string?>? searchcontainablesdescriptions = null;

			Exception? exception = Record.Exception(() => searchcontainablesdescriptions = localisation.FilmSearchContainablesDescriptions(cultureInfo));

			_OutputHelper.WriteLine(_StringBuilder.Append(searchcontainablesdescriptions).ToString() ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(localisation);
		}
	}
}
