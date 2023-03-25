using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Localisation
{
	public class LocalisationCultures 
	{
		public static readonly LocalisationCultureInfo English = new (CultureInfo.GetCultureInfo("en"));

		public static IEnumerable<LocalisationCultureInfo> AsEnumerable()
		{
			return Enumerable.Empty<LocalisationCultureInfo>()
				.Append(English);
		}
	}
}
