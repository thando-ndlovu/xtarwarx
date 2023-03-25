using Domain.Models;

namespace Localisation.Utils.Manufacturers
{
	public class ManufacturerTitles 
	{
		public const string ResourceName = "Manufacturers.ManufacturerTitles";

		public static readonly IManufacturer<string> Keys = new IManufacturer.Default<string>(string.Empty)
		{
			Description = "ManufacturerTitles_Description",
			HeadquatersPlanetId = "ManufacturerTitles_HeadquatersPlanetId",
			Id = "ManufacturerTitles_Id",
			Name = "ManufacturerTitles_Name",
			StarshipIds = "ManufacturerTitles_StarshipIds",
			VehicleIds = "ManufacturerTitles_VehicleIds",
			WeaponIds = "ManufacturerTitles_WeaponIds",
			Uris = "ManufacturerTitles_Uris",
			Created = "ManufacturerTitles_Created",
			Edited = "ManufacturerTitles_Edited",
		};
	}

	public static class ManufacturerTitlesExtensions
	{
		public static IManufacturer<string?>? GetManufacturerTitles(this LocalisationResourceManager? localisationResourceManager, IManufacturer<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IManufacturer.Default<string?>(null)
				{
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(ManufacturerTitles.Keys.Created) : null,
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(ManufacturerTitles.Keys.Description) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(ManufacturerTitles.Keys.Edited) : null,
					HeadquatersPlanetId = retriever?.HeadquatersPlanetId ?? true ? localisationResourceManager.GetString(ManufacturerTitles.Keys.HeadquatersPlanetId) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(ManufacturerTitles.Keys.Id) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(ManufacturerTitles.Keys.Name) : null,
					StarshipIds = retriever?.StarshipIds ?? true ? localisationResourceManager.GetString(ManufacturerTitles.Keys.StarshipIds) : null,
					Uris = retriever?.Uris ?? true ? localisationResourceManager.GetString(ManufacturerTitles.Keys.Uris) : null,
					VehicleIds = retriever?.VehicleIds ?? true ? localisationResourceManager.GetString(ManufacturerTitles.Keys.VehicleIds) : null,
					WeaponIds = retriever?.WeaponIds ?? true ? localisationResourceManager.GetString(ManufacturerTitles.Keys.WeaponIds) : null,
				};
	}
}
