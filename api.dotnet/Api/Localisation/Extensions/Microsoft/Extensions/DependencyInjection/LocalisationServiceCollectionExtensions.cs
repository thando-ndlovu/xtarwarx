using Api.Localisation.Options;

using Localisation;

using System;
using System.Globalization;

namespace Microsoft.Extensions.DependencyInjection
{
	public static class LocalisationServiceCollectionExtensions
	{
		public static IServiceCollection AddLocalisations(this IServiceCollection serviceCollection, Action<LocalisationOptions>? localisationOptions = null)
		{
			LocalisationOptions options = new ();

			localisationOptions?.Invoke(options);

			serviceCollection.AddLocalization();
			serviceCollection.AddSingleton<ILocalisation>(new ILocalisation.Default
			{
				DefaultCultureInfo = options.DefaultCultureInfo ?? CultureInfo.CurrentCulture,
			});

			return serviceCollection;
		}
	}
}
