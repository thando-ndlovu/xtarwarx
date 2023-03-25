using Localisation.Utils;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Localisation.Implementation.Base
{
	public class BaseLocalisations : IDisposable
	{
		protected HashSet<string>? ResourceManagerBaseNames { get; set; }

		public CultureInfo? DefaultCultureInfo { get; set; }
		public IList<LocalisationResourceManager>? ResourceManagers { get; set; }

		public LocalisationResourceManager? GetResourceManager(string? baseName = null, Assembly? assembly = null)
		{
			if (string.IsNullOrWhiteSpace(baseName))
				return null;

			ResourceManagerBaseNames ??= new HashSet<string>();
			ResourceManagerBaseNames.Add(baseName);

			ResourceManagers ??= new List<LocalisationResourceManager>();

			LocalisationResourceManager? localisationresourcemanager = ResourceManagers
				.FirstOrDefault(resourcemanager => resourcemanager.BaseName == baseName);

			if (localisationresourcemanager == null)
			{
				localisationresourcemanager = new LocalisationResourceManager(
					baseName: baseName,
					assembly: assembly ?? typeof(BaseLocalisations).Assembly);

				if (localisationresourcemanager != null)
					ResourceManagers.Add(localisationresourcemanager);
			}

			return localisationresourcemanager;
		}		  
		public LocalisationResourceManager? GetResourceManager(string resourceName, LocalisationCultureInfo localisationCultureInfo)
		{
			return GetResourceManager(
				baseName: ManifestResources.GetManifestResourceName(
					resourcename: resourceName,
					localisationCultureInfo: localisationCultureInfo));
		}
		public LocalisationResourceManager? GetResourceManager(string resourceName, LocalisationCultureInfo localisationCultureInfo, Assembly? assembly = null, string? localisationFormat = null)
		{
			return GetResourceManager(
				assembly: assembly ?? typeof(BaseLocalisations).Assembly,
				baseName: ManifestResources.GetManifestResourceName(
					assembly: assembly,
					resourcename: resourceName,
					localisationformat: localisationFormat,
					localisationCultureInfo: localisationCultureInfo));
		}

		public virtual void Dispose()
		{
			ResourceManagers = ResourceManagers?
				.Where(resourcemanager =>
				{
					if (!ResourceManagerBaseNames?.Contains(resourcemanager.BaseName) ?? true)
						return true;

					resourcemanager.ReleaseAllResources();

					return false;

				}).ToList();

			ResourceManagerBaseNames?.Clear();
			ResourceManagerBaseNames = null;
		}
	}
}
