using Domain.Models;

namespace Localisation.Utils.Manufacturers
{
	public class ManufacturerSortKeysDescriptions
	{
		public const string ResourceName = "Manufacturers.ManufacturerSortKeysDescriptions";

		public static readonly IManufacturer.ISortKeys<string> Keys = new IManufacturer.ISortKeys.Default<string>(string.Empty)
		{
			Created = "ManufacturerSortKeysDescriptions_Created",
			Edited = "ManufacturerSortKeysDescriptions_Edited",
			Id = "ManufacturerSortKeysDescriptions_Id",
			Name = "ManufacturerSortKeysDescriptions_Name",
			StarshipsCount = "ManufacturerSortKeysDescriptions_StarshipsCount",
			VehiclesCount = "ManufacturerSortKeysDescriptions_VehiclesCount",
			WeaponsCount = "ManufacturerSortKeysDescriptions_WeaponsCount",
		};
	}

	public static class ManufacturerSortKeysDescriptionsExtensions
	{
		public static IManufacturer.ISortKeys? GetManufacturerSortKeysDescriptions(this LocalisationResourceManager? localisationResourceManager, IManufacturer.ISortKeys<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IManufacturer.ISortKeys.Default
				{
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(ManufacturerSortKeysDescriptions.Keys.Created) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(ManufacturerSortKeysDescriptions.Keys.Edited) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(ManufacturerSortKeysDescriptions.Keys.Id) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(ManufacturerSortKeysDescriptions.Keys.Name) : null,
					StarshipsCount = retriever?.StarshipsCount ?? true ? localisationResourceManager.GetString(ManufacturerSortKeysDescriptions.Keys.StarshipsCount) : null,
					VehiclesCount = retriever?.VehiclesCount ?? true ? localisationResourceManager.GetString(ManufacturerSortKeysDescriptions.Keys.VehiclesCount) : null,
					WeaponsCount = retriever?.WeaponsCount ?? true ? localisationResourceManager.GetString(ManufacturerSortKeysDescriptions.Keys.WeaponsCount) : null,
				};
	}
}
