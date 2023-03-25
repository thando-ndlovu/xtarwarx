using System;
using System.Reflection;
using System.Resources;

namespace Localisation
{
	public class LocalisationResourceManager : ResourceManager
	{
		protected LocalisationResourceManager() : base() { }
		public LocalisationResourceManager(Type resourceSource) : base(resourceSource) { }
		public LocalisationResourceManager(string baseName, Assembly assembly) : base(baseName, assembly) { }
		public LocalisationResourceManager(string baseName, Assembly assembly, Type usingResourceSet) : base(baseName, assembly, usingResourceSet) { }

		public string? ResourceName { get; set; }
		public LocalisationCultureInfo? CultureInfo { get; set; }
	}
}
