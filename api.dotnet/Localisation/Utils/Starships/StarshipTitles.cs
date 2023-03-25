using Domain.Models;

namespace Localisation.Utils.Starships
{
	public class StarshipTitles 
	{
		public const string ResourceName = "Starships.StarshipTitles";

		public static readonly IStarship<string> Keys = new IStarship.Default<string>(string.Empty)
		{
			CargoCapacity = "StarshipTitles_CargoCapacity",
			Consumables = "StarshipTitles_Consumables",
			CostInCredits = "StarshipTitles_CostInCredits",
			Description = "StarshipTitles_Description",
			Id = "StarshipTitles_Id",
			Length = "StarshipTitles_Length",
			ManufacturerIds = "StarshipTitles_ManufacturerIds",
			MaxAtmospheringSpeed = "StarshipTitles_MaxAtmospheringSpeed",
			MaxCrew = "StarshipTitles_MaxCrew",
			MinCrew = "StarshipTitles_MinCrew",
			Model = "StarshipTitles_Model",
			Name = "StarshipTitles_Name",
			Passengers = "StarshipTitles_Passengers",
			PilotIds = "StarshipTitles_PilotIds",
			HyperdriveRating = "StarshipTitles_HyperdriveRating",
			MGLT = "StarshipTitles_MGLT",
			StarshipClass = "StarshipTitles_StarshipClass",
			Uris = "StarshipTitles_Uris",
			Created = "StarshipTitles_Created",
			Edited = "StarshipTitles_Edited",
		};
	}

	public static class StarshipTitlesExtensions
	{
		public static IStarship<string?>? GetStarshipTitles(this LocalisationResourceManager? localisationResourceManager, IStarship<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IStarship.Default<string?>(null)
				{
					CargoCapacity = retriever?.CargoCapacity ?? true ? localisationResourceManager.GetString(StarshipTitles.Keys.CargoCapacity) : null,
					Consumables = retriever?.Consumables ?? true ? localisationResourceManager.GetString(StarshipTitles.Keys.Consumables) : null,
					CostInCredits = retriever?.CostInCredits ?? true ? localisationResourceManager.GetString(StarshipTitles.Keys.CostInCredits) : null,
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(StarshipTitles.Keys.Created) : null,
					Description = retriever?.Description ?? true ? localisationResourceManager.GetString(StarshipTitles.Keys.Description) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(StarshipTitles.Keys.Edited) : null,
					HyperdriveRating = retriever?.HyperdriveRating ?? true ? localisationResourceManager.GetString(StarshipTitles.Keys.HyperdriveRating) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(StarshipTitles.Keys.Id) : null,
					Length = retriever?.Length ?? true ? localisationResourceManager.GetString(StarshipTitles.Keys.Length) : null,
					ManufacturerIds = retriever?.ManufacturerIds ?? true ? localisationResourceManager.GetString(StarshipTitles.Keys.ManufacturerIds) : null,
					MaxAtmospheringSpeed = retriever?.MaxAtmospheringSpeed ?? true ? localisationResourceManager.GetString(StarshipTitles.Keys.MaxAtmospheringSpeed) : null,
					MaxCrew = retriever?.MaxCrew ?? true ? localisationResourceManager.GetString(StarshipTitles.Keys.MaxCrew) : null,
					MGLT = retriever?.MGLT ?? true ? localisationResourceManager.GetString(StarshipTitles.Keys.MGLT) : null,
					MinCrew = retriever?.MinCrew ?? true ? localisationResourceManager.GetString(StarshipTitles.Keys.MinCrew) : null,
					Model = localisationResourceManager.GetString(StarshipTitles.Keys.Model),
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(StarshipTitles.Keys.Name) : null,
					Passengers = retriever?.Passengers ?? true ? localisationResourceManager.GetString(StarshipTitles.Keys.Passengers) : null,
					PilotIds = retriever?.PilotIds ?? true ? localisationResourceManager.GetString(StarshipTitles.Keys.PilotIds) : null,
					StarshipClass = retriever?.StarshipClass ?? true ? localisationResourceManager.GetString(StarshipTitles.Keys.StarshipClass) : null,
					Uris = localisationResourceManager.GetString(StarshipTitles.Keys.Uris),
				};
	}
}
