using Domain.Models;

using Localisation.Abstractions.Manufacturers;

namespace Localisation.Utils.Manufacturers
{
	public class ManufacturerSingle
	{
		public const string ResourceName = "Manufacturers.ManufacturerSingle";

		public static readonly IManufacturerSingleLocalisation<string> Keys = new IManufacturerSingleLocalisation.Default<string>(string.Empty)
		{
			HeadquatersPlanetTitle = "ManufacturerSingle_HeadquatersPlanetTitle",
			HeadquatersPlanetAbsentText = "ManufacturerSingle_HeadquatersPlanetAbsentText",
			ImagesTitle = "ManufacturerSingle_ImagesTitle",
			ImagesEmptyText = "ManufacturerSingle_ImagesEmptyText",
			StarshipsTitle = "ManufacturerSingle_StarshipsTitle",
			StarshipsEmptyText = "ManufacturerSingle_StarshipsEmptyText",
			VehiclesTitle = "ManufacturerSingle_VehiclesTitle",
			VehiclesEmptyText = "ManufacturerSingle_VehiclesEmptyText",
			WeaponsTitle = "ManufacturerSingle_WeaponsTitle",
			WeaponsEmptyText = "ManufacturerSingle_WeaponsEmptyText",
		};
	}

	public static class ManufacturerSingleExtensions
	{
		public static IManufacturerSingleLocalisation? GetManufacturerSingle(this LocalisationResourceManager? localisationResourceManager, IManufacturerSingleLocalisation<bool>? retriever = null, IManufacturer<string?>? manufacturerTitles = null)
		{
			if (localisationResourceManager == null)
				return manufacturerTitles as IManufacturerSingleLocalisation;

			IManufacturerSingleLocalisation manufacturersingle = IManufacturerSingleLocalisation.FromManufacturer(manufacturerTitles) ?? new IManufacturerSingleLocalisation.Default { };

			manufacturersingle.HeadquatersPlanetTitle = retriever?.HeadquatersPlanetTitle ?? true ? localisationResourceManager.GetString(ManufacturerSingle.Keys.HeadquatersPlanetTitle) : null;
			manufacturersingle.HeadquatersPlanetAbsentText = retriever?.HeadquatersPlanetAbsentText ?? true ? localisationResourceManager.GetString(ManufacturerSingle.Keys.HeadquatersPlanetAbsentText) : null; 
			manufacturersingle.ImagesTitle = retriever?.ImagesTitle ?? true ? localisationResourceManager.GetString(ManufacturerSingle.Keys.ImagesTitle) : null;
			manufacturersingle.ImagesEmptyText = retriever?.ImagesEmptyText ?? true ? localisationResourceManager.GetString(ManufacturerSingle.Keys.ImagesEmptyText) : null;
			manufacturersingle.StarshipsTitle = retriever?.StarshipsTitle ?? true ? localisationResourceManager.GetString(ManufacturerSingle.Keys.StarshipsTitle) : null;
			manufacturersingle.StarshipsEmptyText = retriever?.StarshipsEmptyText ?? true ? localisationResourceManager.GetString(ManufacturerSingle.Keys.StarshipsEmptyText) : null;
			manufacturersingle.VehiclesTitle = retriever?.VehiclesTitle ?? true ? localisationResourceManager.GetString(ManufacturerSingle.Keys.VehiclesTitle) : null;
			manufacturersingle.VehiclesEmptyText = retriever?.VehiclesEmptyText ?? true ? localisationResourceManager.GetString(ManufacturerSingle.Keys.VehiclesEmptyText) : null;
			manufacturersingle.WeaponsTitle = retriever?.WeaponsTitle ?? true ? localisationResourceManager.GetString(ManufacturerSingle.Keys.WeaponsTitle) : null;
			manufacturersingle.WeaponsEmptyText = retriever?.WeaponsEmptyText ?? true ? localisationResourceManager.GetString(ManufacturerSingle.Keys.WeaponsEmptyText) : null;

			return manufacturersingle;

		}
		public static IManufacturerSingleLocalisation? GetManufacturerSingle(this LocalisationResourceManager? localisationResourceManager, IManufacturerSingleLocalisation<bool>? retriever = null, LocalisationResourceManager? manufacturerTitlesLocalisationResourceManager = null)
			=> localisationResourceManager.GetManufacturerSingle(
				retriever: retriever,
				manufacturerTitles: manufacturerTitlesLocalisationResourceManager.GetManufacturerTitles());
	}
}
