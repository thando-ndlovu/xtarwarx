using Domain.Models;

using Localisation.Abstractions.Starships;

namespace Localisation.Utils.Starships
{
	public class StarshipSingle 
	{
		public const string ResourceName = "Starships.StarshipSingle";

		public static readonly IStarshipSingleLocalisation<string> Keys = new IStarshipSingleLocalisation.Default<string>(string.Empty)
		{
			ImagesTitle = "StarshipSingle_ImagesTitle",
			ImagesEmptyText = "StarshipSingle_ImagesEmptyText",
			ManufacturersTitle = "StarshipSingle_ManufacturersTitle",
			ManufacturersEmptyText = "StarshipSingle_ManufacturersEmptyText",
			PilotsTitle = "StarshipSingle_PilotsTitle",
			PilotsEmptyText = "StarshipSingle_PilotsEmptyText",
		};
	}

	public static class StarshipSingleExtensions
	{
		public static IStarshipSingleLocalisation? GetStarshipSingle(this LocalisationResourceManager? localisationResourceManager, IStarshipSingleLocalisation<bool>? retriever = null, IStarship<string?>? starshipTitles = null)
		{
			if (localisationResourceManager == null)
				return starshipTitles as IStarshipSingleLocalisation;

			IStarshipSingleLocalisation starshipsingle = IStarshipSingleLocalisation.FromStarship(starshipTitles) ?? new IStarshipSingleLocalisation.Default { };

			starshipsingle.ImagesTitle = retriever?.ImagesTitle ?? true ? localisationResourceManager.GetString(StarshipSingle.Keys.ImagesTitle) : null;
			starshipsingle.ImagesEmptyText = retriever?.ImagesEmptyText ?? true ? localisationResourceManager.GetString(StarshipSingle.Keys.ImagesEmptyText) : null;
			starshipsingle.ManufacturersTitle = retriever?.ManufacturersTitle ?? true ? localisationResourceManager.GetString(StarshipSingle.Keys.ManufacturersTitle) : null;
			starshipsingle.ManufacturersEmptyText = retriever?.ManufacturersEmptyText ?? true ? localisationResourceManager.GetString(StarshipSingle.Keys.ManufacturersEmptyText) : null;
			starshipsingle.PilotsTitle = retriever?.PilotsTitle ?? true ? localisationResourceManager.GetString(StarshipSingle.Keys.PilotsTitle) : null;
			starshipsingle.PilotsEmptyText = retriever?.PilotsEmptyText ?? true ? localisationResourceManager.GetString(StarshipSingle.Keys.PilotsEmptyText) : null;

			return starshipsingle;

		}
		public static IStarshipSingleLocalisation? GetStarshipSingle(this LocalisationResourceManager? localisationResourceManager, IStarshipSingleLocalisation<bool>? retriever = null, LocalisationResourceManager? starshipTitlesLocalisationResourceManager = null)
			=> localisationResourceManager.GetStarshipSingle(
				retriever: retriever,
				starshipTitles: starshipTitlesLocalisationResourceManager.GetStarshipTitles());
	}
}
