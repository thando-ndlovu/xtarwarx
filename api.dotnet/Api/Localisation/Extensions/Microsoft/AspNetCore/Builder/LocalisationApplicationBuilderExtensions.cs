using Localisation;

using Microsoft.AspNetCore.Localization;

using System.Linq;
using System.Globalization;

namespace Microsoft.AspNetCore.Builder
{
	public static class LocalisationApplicationBuilderExtensions
	{
		public static IApplicationBuilder UseLocalisation(this IApplicationBuilder applicationBuilder)
		{
			applicationBuilder.UseRequestLocalization(new RequestLocalizationOptions
			{
				DefaultRequestCulture = new RequestCulture(LocalisationCultures.English),

				FallBackToParentCultures = true,
				FallBackToParentUICultures = true,

				SupportedCultures = LocalisationCultures.AsEnumerable().Cast<CultureInfo>().ToList(),
				SupportedUICultures = LocalisationCultures.AsEnumerable().Cast<CultureInfo>().ToList(),
			});

			return applicationBuilder;
		}
	}
}
