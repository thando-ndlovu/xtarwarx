using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Localisation
{
	public class LocalisationCultureInfo : CultureInfo
	{
		public LocalisationCultureInfo(int culture) : base(culture) { }
		public LocalisationCultureInfo(string name) : base(name) { }
		public LocalisationCultureInfo(int culture, bool useUserOverride) : base(culture, useUserOverride) { }
		public LocalisationCultureInfo(string name, bool useUserOverride) : base(name, useUserOverride) { }
		public LocalisationCultureInfo(CultureInfo cultureInfo) : base(cultureInfo.Name, cultureInfo.UseUserOverride) { }

		public bool IsDefaultLocalisationCulture { get; set; }
								 
		public new LocalisationCultureInfo Parent
		{
			get => FromCultureInfo(base.Parent);
		}
		public IEnumerable<LocalisationCultureInfo> AllParents
		{
			get
			{
				IList<LocalisationCultureInfo> allparents = new List<LocalisationCultureInfo>();

				LocalisationCultureInfo? localisationcultureinfo = this;

				while (localisationcultureinfo != null)
				{
					allparents.Add(localisationcultureinfo);

					localisationcultureinfo = localisationcultureinfo.IsNeutralCulture
						? null
						: localisationcultureinfo.Parent;
				}

				return allparents;
			}
		}

		public static LocalisationCultureInfo FromCultureInfo(CultureInfo cultureInfo)
		{
			return new LocalisationCultureInfo(
				name: cultureInfo.Name,
				useUserOverride: cultureInfo.UseUserOverride);
		}
	}
}
