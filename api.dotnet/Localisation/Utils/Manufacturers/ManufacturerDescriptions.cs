using Domain.Models;

namespace Localisation.Utils.Manufacturers
{
	public class ManufacturerDescriptions
	{
		public const string ResourceName = "Manufacturers.ManufacturerDescriptions";

		public static readonly IManufacturer<string> Keys = new IManufacturer.Default<string>(string.Empty)
		{
			Description = "ManufacturerDescriptions_Description",
			HeadquatersPlanetId = "ManufacturerDescriptions_HeadquatersPlanetId",
			Id = "ManufacturerDescriptions_Id",
			Name = "ManufacturerDescriptions_Name",
			StarshipIds = "ManufacturerDescriptions_StarshipIds",
			VehicleIds = "ManufacturerDescriptions_VehicleIds",
			WeaponIds = "ManufacturerDescriptions_WeaponIds",
			Uris = "ManufacturerDescriptions_Uris",
			Created = "ManufacturerDescriptions_Created",
			Edited = "ManufacturerDescriptions_Edited",
		};
	}

	public static class ManufacturerDescriptionsExtensions
	{
		public static IManufacturer<string?>? GetManufacturerDescriptions(this LocalisationResourceManager? localisationResourceManager, IManufacturer<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IManufacturer.Default<string?>(null)
				{
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(ManufacturerDescriptions.Keys.Created) : null,
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(ManufacturerDescriptions.Keys.Description) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(ManufacturerDescriptions.Keys.Edited) : null,
					HeadquatersPlanetId = retriever?.HeadquatersPlanetId ?? true ? localisationResourceManager.GetString(ManufacturerDescriptions.Keys.HeadquatersPlanetId) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(ManufacturerDescriptions.Keys.Id) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(ManufacturerDescriptions.Keys.Name) : null,
					StarshipIds = retriever?.StarshipIds ?? true ? localisationResourceManager.GetString(ManufacturerDescriptions.Keys.StarshipIds) : null,
					Uris = retriever?.Uris ?? true ? localisationResourceManager.GetString(ManufacturerDescriptions.Keys.Uris) : null,
					VehicleIds = retriever?.VehicleIds ?? true ? localisationResourceManager.GetString(ManufacturerDescriptions.Keys.VehicleIds) : null,
					WeaponIds = retriever?.WeaponIds ?? true ? localisationResourceManager.GetString(ManufacturerDescriptions.Keys.WeaponIds) : null,
				};
	}
}
