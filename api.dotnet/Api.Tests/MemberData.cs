using Api.Localisation;

using System.Collections.Generic;
using System.Linq;

namespace Api.Localisation.Tests
{
	public static class MemberData
	{
		public static IEnumerable<object[]> CultureNamesMemberData => LocalisationCultures.AsEnumerable()
			.Select(cultureinfo => new object[] 
			{
				cultureinfo.Name
			});
	}
}
