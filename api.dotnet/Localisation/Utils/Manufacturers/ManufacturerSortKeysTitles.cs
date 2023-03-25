using Domain.Models;

namespace Localisation.Utils.Manufacturers
{
	public class ManufacturerSortKeysTitles
	{
		public const string ResourceName = "Manufacturers.ManufacturerSortKeysTitles";

		public static readonly IManufacturer.ISortKeys<string> Keys = new IManufacturer.ISortKeys.Default<string>(string.Empty)
		{
			Created = "ManufacturerSortKeysTitles_Created",
			Edited = "ManufacturerSortKeysTitles_Edited",
			Id = "ManufacturerSortKeysTitles_Id",
			Name = "ManufacturerSortKeysTitles_Name",
			StarshipsCount = "ManufacturerSortKeysTitles_StarshipsCount",
			VehiclesCount = "ManufacturerSortKeysTitles_VehiclesCount",
			WeaponsCount = "ManufacturerSortKeysTitles_WeaponsCount",
		};
	}

	public static class ManufacturerSortKeysTitlesExtensions
	{
		public static IManufacturer.ISortKeys? GetManufacturerSortKeysTitles(this LocalisationResourceManager? localisationResourceManager, IManufacturer.ISortKeys<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IManufacturer.ISortKeys.Default
				{
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(ManufacturerSortKeysTitles.Keys.Created) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(ManufacturerSortKeysTitles.Keys.Edited) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(ManufacturerSortKeysTitles.Keys.Id) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(ManufacturerSortKeysTitles.Keys.Name) : null,
					StarshipsCount = retriever?.StarshipsCount ?? true ? localisationResourceManager.GetString(ManufacturerSortKeysTitles.Keys.StarshipsCount) : null,
					VehiclesCount = retriever?.VehiclesCount ?? true ? localisationResourceManager.GetString(ManufacturerSortKeysTitles.Keys.VehiclesCount) : null,
					WeaponsCount = retriever?.WeaponsCount ?? true ? localisationResourceManager.GetString(ManufacturerSortKeysTitles.Keys.WeaponsCount) : null,
				};
	}
}
