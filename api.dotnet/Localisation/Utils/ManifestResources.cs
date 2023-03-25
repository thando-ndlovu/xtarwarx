using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Localisation.Utils
{
	public class ManifestResources
	{
		public static string? GetManifestResourceName(string resourcename, CultureInfo cultureInfo, string? localisationformat = null, Assembly? assembly = null)
		{
			return GetManifestResourceName(resourcename, LocalisationCultureInfo.FromCultureInfo(cultureInfo), localisationformat, assembly);
		}
		public static string? GetManifestResourceName(string resourcename, LocalisationCultureInfo localisationCultureInfo, string? localisationformat = null, Assembly? assembly = null)
		{
			IEnumerable<string> cultures = localisationCultureInfo.AllParents
				.Select(localisationcultureinfo =>
				{
					return string.Format(
						arg1: resourcename,
						arg0: localisationcultureinfo.Name.Replace('-', '_'),
						format: localisationformat ?? "Localisation.Languages.{0}.{1}");
				});

			string? manifestresourcename = (assembly ?? typeof(ManifestResources).Assembly)
				.GetManifestResourceNames()
				.FirstOrDefault(manifestresourcename => cultures.Any(culture => manifestresourcename.Contains(culture)));

			return manifestresourcename?.Replace(".resources", string.Empty);
		}
	}
}
