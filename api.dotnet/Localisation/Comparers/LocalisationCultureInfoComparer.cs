using Localisation.Utils;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Localisation.Comparers
{
	public class LocalisationCultureInfoComparer : IComparer<LocalisationCultureInfo?>
	{
		public int Compare(LocalisationCultureInfo? x, LocalisationCultureInfo? y)
		{
			bool XIsParentOfY = y?.AllParents.Contains(x) ?? false;
			bool YIsParentOfX = x?.AllParents.Contains(y) ?? false;

			if (XIsParentOfY)
				return -1;

			if (YIsParentOfX)
				return 1;

			return 0;
		}
	}
}
