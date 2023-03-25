using Domain.Models;

namespace Localisation.Utils.Starships
{
	public class StarshipDescriptions
	{
		public const string ResourceName = "Starships.StarshipDescriptions";

		public static readonly IStarship<string> Keys = new IStarship.Default<string>(string.Empty)
		{
			CargoCapacity = "StarshipDescriptions_CargoCapacity",
			Consumables = "StarshipDescriptions_Consumables",
			CostInCredits = "StarshipDescriptions_CostInCredits",
			Description = "StarshipDescriptions_Description",
			Id = "StarshipDescriptions_Id",
			Length = "StarshipDescriptions_Length",
			ManufacturerIds = "StarshipDescriptions_ManufacturerIds",
			MaxAtmospheringSpeed = "StarshipDescriptions_MaxAtmospheringSpeed",
			MaxCrew = "StarshipDescriptions_MaxCrew",
			MinCrew = "StarshipDescriptions_MinCrew",
			Model = "StarshipDescriptions_Model",
			Name = "StarshipDescriptions_Name",
			Passengers = "StarshipDescriptions_Passengers",
			PilotIds = "StarshipDescriptions_PilotIds",
			HyperdriveRating = "StarshipDescriptions_HyperdriveRating",
			MGLT = "StarshipDescriptions_MGLT",
			StarshipClass = "StarshipDescriptions_StarshipClass",
			Uris = "StarshipDescriptions_Uris",
			Created = "StarshipDescriptions_Created",
			Edited = "StarshipDescriptions_Edited",
		};
	}

	public static class StarshipDescriptionsExtensions
	{
		public static IStarship<string?>? GetStarshipDescriptions(this LocalisationResourceManager? localisationResourceManager, IStarship<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IStarship.Default<string?>(null)
				{
					CargoCapacity = retriever?.CargoCapacity ?? true ? localisationResourceManager.GetString(StarshipDescriptions.Keys.CargoCapacity) : null,
					Consumables = retriever?.Consumables ?? true ? localisationResourceManager.GetString(StarshipDescriptions.Keys.Consumables) : null,
					CostInCredits = retriever?.CostInCredits ?? true ? localisationResourceManager.GetString(StarshipDescriptions.Keys.CostInCredits) : null,
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(StarshipDescriptions.Keys.Created) : null,
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(StarshipDescriptions.Keys.Description) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(StarshipDescriptions.Keys.Edited) : null,
					HyperdriveRating = retriever?.HyperdriveRating ?? true ? localisationResourceManager.GetString(StarshipDescriptions.Keys.HyperdriveRating) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(StarshipDescriptions.Keys.Id) : null,
					Length = retriever?.Length ?? true ? localisationResourceManager.GetString(StarshipDescriptions.Keys.Length) : null,
					ManufacturerIds = retriever?.ManufacturerIds ?? true ? localisationResourceManager.GetString(StarshipDescriptions.Keys.ManufacturerIds) : null,
					MaxAtmospheringSpeed = retriever?.MaxAtmospheringSpeed ?? true ? localisationResourceManager.GetString(StarshipDescriptions.Keys.MaxAtmospheringSpeed) : null,
					MaxCrew = retriever?.MaxCrew ?? true ? localisationResourceManager.GetString(StarshipDescriptions.Keys.MaxCrew) : null,
					MGLT = retriever?.MGLT ?? true ? localisationResourceManager.GetString(StarshipDescriptions.Keys.MGLT) : null,
					MinCrew = retriever?.MinCrew ?? true ? localisationResourceManager.GetString(StarshipDescriptions.Keys.MinCrew) : null,
					Model = retriever?.Model ?? true ? localisationResourceManager.GetString(StarshipDescriptions.Keys.Model) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(StarshipDescriptions.Keys.Name) : null,
					Passengers = retriever?.Passengers ?? true ? localisationResourceManager.GetString(StarshipDescriptions.Keys.Passengers) : null,
					PilotIds = retriever?.PilotIds ?? true ? localisationResourceManager.GetString(StarshipDescriptions.Keys.PilotIds) : null,
					StarshipClass = retriever?.StarshipClass ?? true ? localisationResourceManager.GetString(StarshipDescriptions.Keys.StarshipClass) : null,
					Uris = retriever?.Uris ?? true ? localisationResourceManager.GetString(StarshipDescriptions.Keys.Uris) : null,
				};
	}
}
