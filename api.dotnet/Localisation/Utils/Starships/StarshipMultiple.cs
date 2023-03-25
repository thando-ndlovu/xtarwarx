using Localisation.Abstractions.Starships;

namespace Localisation.Utils.Starships
{
	public class StarshipMultiple 
	{
		public const string ResourceName = "Starships.StarshipMultiple";

		public static readonly IStarshipMultipleLocalisation<string> Keys = new IStarshipMultipleLocalisation.Default<string>(string.Empty)
		{
			StarshipsEmptyText = "StarshipMultiple_StarshipsEmptyText",
			StarshipsTitle = "StarshipMultiple_StarshipsTitle",
			StarshipsSearchbarPlaceholder = "StarshipMultiple_StarshipsSearchbarPlaceholder",
		};
	}

	public static class StarshipMultipleExtensions
	{
		public static IStarshipMultipleLocalisation? GetStarshipMultiple(this LocalisationResourceManager? localisationResourceManager, IStarshipMultipleLocalisation<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IStarshipMultipleLocalisation.Default
				{
					StarshipsEmptyText = retriever?.StarshipsEmptyText ?? true ? localisationResourceManager.GetString(StarshipMultiple.Keys.StarshipsEmptyText) : null,
					StarshipsTitle = retriever?.StarshipsTitle ?? true ? localisationResourceManager.GetString(StarshipMultiple.Keys.StarshipsTitle) : null,
					StarshipsSearchbarPlaceholder = retriever?.StarshipsSearchbarPlaceholder ?? true ? localisationResourceManager.GetString(StarshipMultiple.Keys.StarshipsSearchbarPlaceholder) : null,
				};
	}
}
