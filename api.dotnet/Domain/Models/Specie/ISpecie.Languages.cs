using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
	public partial interface ISpecie
	{
		public static class Languages
		{
			public const string Aleena = "Aleena";
			public const string Besalisk = "Besalisk";
			public const string Clawdite = "Clawdite";
			public const string Chagria = "Chagria";
			public const string Cerean = "Cerean";
			public const string Dosh = "Dosh";
			public const string Dugese = "Dugese";
			public const string Ewokese = "Ewokese";
			public const string GalacticBasic = "GalacticBasic";
			public const string Geonosian = "Geonosian";
			public const string GunganBasic = "GunganBasic";
			public const string Huttese = "Huttese";
			public const string Iktotchese = "Iktotchese";
			public const string Kaleesh = "Kaleesh";
			public const string Kaminoan = "Kaminoan";
			public const string KelDor = "KelDor";
			public const string Mirialan = "Mirialan";
			public const string MonCalamarian = "MonCalamarian";
			public const string Muun = "Muun";
			public const string Nautila = "Nautila";
			public const string Neimodia = "Neimodia";
			public const string Quermian = "Quermian";
			public const string Shyriiwook = "Shyriiwook";
			public const string Skakoan = "Skakoan";
			public const string Sullutese = "Sullutese";
			public const string Togruti = "Togruti";
			public const string Toydarian = "Toydarian";
			public const string Tundan = "Tundan";
			public const string Twileki = "Twi'leki";
			public const string Utapese = "Utapese";
			public const string Vulpterish = "Vulpterish";
			public const string Xextese = "Xextese";
			public const string Zabraki = "Zabraki";

			public static IEnumerable<string> AsEnumerable()
			{
				return Enumerable.Empty<string>()
					.Append(Aleena)
					.Append(Besalisk)
					.Append(Clawdite)
					.Append(Chagria)
					.Append(Cerean)
					.Append(Dosh)
					.Append(Dugese)
					.Append(Ewokese)
					.Append(GalacticBasic)
					.Append(Geonosian)
					.Append(GunganBasic)
					.Append(Huttese)
					.Append(Iktotchese)
					.Append(Kaleesh)
					.Append(Kaminoan)
					.Append(KelDor)
					.Append(Mirialan)
					.Append(MonCalamarian)
					.Append(Muun)
					.Append(Nautila)
					.Append(Neimodia)
					.Append(Quermian)
					.Append(Shyriiwook)
					.Append(Skakoan)
					.Append(Sullutese)
					.Append(Togruti)
					.Append(Toydarian)
					.Append(Tundan)
					.Append(Twileki)
					.Append(Utapese)
					.Append(Vulpterish)
					.Append(Xextese)
					.Append(Zabraki);
			}
		}
	}
}
