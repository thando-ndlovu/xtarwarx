using Domain.Models;

namespace Localisation.Utils.Starships
{
	public class StarshipSortKeysTitles
	{
		public const string ResourceName = "Starships.StarshipSortKeysTitles";

		public static readonly IStarship.ISortKeys<string> Keys = new IStarship.ISortKeys.Default<string>(string.Empty)
		{
			CargoCapacity = "StarshipSortKeysTitles_CargoCapacity",	
			Consumables = "StarshipSortKeysTitles_Consumables",	
			CostInCredits = "StarshipSortKeysTitles_CostInCredits",	
			Created = "StarshipSortKeysTitles_Created",	
			Edited = "StarshipSortKeysTitles_Edited",	
			HyperdriveRating = "StarshipSortKeysTitles_HyperdriveRating",	
			Id = "StarshipSortKeysTitles_Id",
			Length = "StarshipSortKeysTitles_Length",
			ManufacturerCount = "StarshipSortKeysTitles_ManufacturerCount",
			MaxAtmospheringSpeed = "StarshipSortKeysTitles_MaxAtmospheringSpeed",
			MaxCrew = "StarshipSortKeysTitles_MaxCrew",
			MGLT = "StarshipSortKeysTitles_MGLT",
			MinCrew = "StarshipSortKeysTitles_MinCrew",
			Model = "StarshipSortKeysTitles_Model",
			Name = "StarshipSortKeysTitles_Name",
			Passengers = "StarshipSortKeysTitles_Passengers",
			PilotCount = "StarshipSortKeysTitles_PilotCount",
			StarshipClass = "StarshipSortKeysTitles_StarshipClass",
			StarshipClassFlagsCount = "StarshipSortKeysTitles_StarshipClassFlagsCount",
		};
	}

	public static class StarshipSortKeysTitlesExtensions
	{
		public static IStarship.ISortKeys? GetStarshipSortKeysTitles(this LocalisationResourceManager? localisationResourceManager, IStarship.ISortKeys<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IStarship.ISortKeys.Default
				{
					CargoCapacity = retriever?.CargoCapacity ?? true ? localisationResourceManager.GetString(StarshipSortKeysTitles.Keys.CargoCapacity) : null,
					Consumables = retriever?.Consumables ?? true ? localisationResourceManager.GetString(StarshipSortKeysTitles.Keys.Consumables) : null,
					CostInCredits = retriever?.CostInCredits ?? true ? localisationResourceManager.GetString(StarshipSortKeysTitles.Keys.CostInCredits) : null,
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(StarshipSortKeysTitles.Keys.Created) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(StarshipSortKeysTitles.Keys.Edited) : null,
					HyperdriveRating = retriever?.HyperdriveRating ?? true ? localisationResourceManager.GetString(StarshipSortKeysTitles.Keys.HyperdriveRating) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(StarshipSortKeysTitles.Keys.Id) : null,
					Length = retriever?.Length ?? true ? localisationResourceManager.GetString(StarshipSortKeysTitles.Keys.Length) : null,
					ManufacturerCount = retriever?.ManufacturerCount ?? true ? localisationResourceManager.GetString(StarshipSortKeysTitles.Keys.ManufacturerCount) : null,
					MaxAtmospheringSpeed = retriever?.MaxAtmospheringSpeed ?? true ? localisationResourceManager.GetString(StarshipSortKeysTitles.Keys.MaxAtmospheringSpeed) : null,
					MaxCrew = retriever?.MaxCrew ?? true ? localisationResourceManager.GetString(StarshipSortKeysTitles.Keys.MaxCrew) : null,
					MGLT = retriever?.MGLT ?? true ? localisationResourceManager.GetString(StarshipSortKeysTitles.Keys.MGLT) : null,
					MinCrew = retriever?.MinCrew ?? true ? localisationResourceManager.GetString(StarshipSortKeysTitles.Keys.MinCrew) : null,
					Model = retriever?.Model ?? true ? localisationResourceManager.GetString(StarshipSortKeysTitles.Keys.Model) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(StarshipSortKeysTitles.Keys.Name) : null,
					Passengers = retriever?.Passengers ?? true ? localisationResourceManager.GetString(StarshipSortKeysTitles.Keys.Passengers) : null,
					PilotCount = retriever?.PilotCount ?? true ? localisationResourceManager.GetString(StarshipSortKeysTitles.Keys.PilotCount) : null,
					StarshipClass = retriever?.StarshipClass ?? true ? localisationResourceManager.GetString(StarshipSortKeysTitles.Keys.StarshipClass) : null,
					StarshipClassFlagsCount = retriever?.StarshipClassFlagsCount ?? true ? localisationResourceManager.GetString(StarshipSortKeysTitles.Keys.StarshipClassFlagsCount) : null,
				};
	}
}
