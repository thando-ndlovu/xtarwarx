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
		public void FilmSearch(string cultureName)
		{
			// Arrange

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			using IFilmLocalisations localisation = new FilmLocalisations();

			// Act

			IFilmSearchLocalisation? searchlocalisation = null;

			Exception? exception = Record.Exception(() => searchlocalisation = localisation.FilmSearch(cultureInfo));

			_OutputHelper.WriteLine(searchlocalisation?.ToString(
				stringbuilder: _StringBuilder,
				converter: new IFilmSearchLocalisation.Default<Func<object?, string>>(obj => obj?.ToString() ?? "null")) ?? "null");

			// Assert

			Assert.Null(exception);
			Assert.NotNull(searchlocalisation);
		}
	}
}
