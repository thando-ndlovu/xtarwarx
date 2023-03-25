using Domain.Models;

using Localisation.Abstractions.Planets;

namespace Localisation.Utils.Planets
{
	public class PlanetSingle
	{
		public const string ResourceName = "Planets.PlanetSingle";

		public static readonly IPlanetSingleLocalisation<string> Keys = new IPlanetSingleLocalisation.Default<string>(string.Empty)
		{
			ImagesTitle = "PlanetSingle_ImagesTitle",
			ImagesEmptyText = "PlanetSingle_ImagesEmptyText",
			ResidentsTitle = "PlanetSingle_ResidentsTitle",
			ResidentsEmptyText = "PlanetSingle_ResidentsEmptyText",
		};
	}

	public static class PlanetSingleExtensions
	{
		public static IPlanetSingleLocalisation? GetPlanetSingle(this LocalisationResourceManager? localisationResourceManager, IPlanetSingleLocalisation<bool>? retriever = null, IPlanet<string?>? planetTitles = null)
		{
			if (localisationResourceManager == null)
				return planetTitles as IPlanetSingleLocalisation;

			IPlanetSingleLocalisation planetsingle = IPlanetSingleLocalisation.FromPlanet(planetTitles) ?? new IPlanetSingleLocalisation.Default { };

			planetsingle.ImagesTitle = retriever?.ImagesTitle ?? true ? localisationResourceManager.GetString(PlanetSingle.Keys.ImagesTitle) : null;
			planetsingle.ImagesEmptyText = retriever?.ImagesEmptyText ?? true ? localisationResourceManager.GetString(PlanetSingle.Keys.ImagesEmptyText) : null;   
			planetsingle.ResidentsTitle = retriever?.ResidentsTitle ?? true ? localisationResourceManager.GetString(PlanetSingle.Keys.ResidentsTitle) : null;
			planetsingle.ResidentsEmptyText = retriever?.ResidentsEmptyText ?? true ? localisationResourceManager.GetString(PlanetSingle.Keys.ResidentsEmptyText) : null;

			return planetsingle;

		}
		public static IPlanetSingleLocalisation? GetPlanetSingle(this LocalisationResourceManager? localisationResourceManager, IPlanetSingleLocalisation<bool>? retriever = null, LocalisationResourceManager? planetTitlesLocalisationResourceManager = null)
			=> localisationResourceManager.GetPlanetSingle(
				retriever: retriever,
				planetTitles: planetTitlesLocalisationResourceManager.GetPlanetTitles());
	}
}