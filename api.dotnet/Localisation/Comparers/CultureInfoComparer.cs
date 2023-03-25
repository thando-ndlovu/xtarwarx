using System.Collections.Generic;
using System.Globalization;

namespace Localisation.Comparers
{
	public class CultureInfoComparer : IComparer<CultureInfo?>
	{
		public int Compare(CultureInfo? x, CultureInfo? y)
		{
			return new LocalisationCultureInfoComparer()
				.Compare(
					x: x == null ? null : LocalisationCultureInfo.FromCultureInfo(x),
					y: y == null ? null : LocalisationCultureInfo.FromCultureInfo(y));
		}
	}
}
