using Domain.Models;

namespace Localisation.Utils.Starships
{
	public class StarshipSortKeysDescriptions
	{
		public const string ResourceName = "Starships.StarshipSortKeysDescriptions";

		public static readonly IStarship.ISortKeys<string> Keys = new IStarship.ISortKeys.Default<string>(string.Empty)
		{
			CargoCapacity = "StarshipSortKeysDescriptions_CargoCapacity",	
			Consumables = "StarshipSortKeysDescriptions_Consumables",	
			CostInCredits = "StarshipSortKeysDescriptions_CostInCredits",	
			Created = "StarshipSortKeysDescriptions_Created",	
			Edited = "StarshipSortKeysDescriptions_Edited",	
			HyperdriveRating = "StarshipSortKeysDescriptions_HyperdriveRating",	
			Id = "StarshipSortKeysDescriptions_Id",
			Length = "StarshipSortKeysDescriptions_Length",
			ManufacturerCount = "StarshipSortKeysDescriptions_ManufacturerCount",
			MaxAtmospheringSpeed = "StarshipSortKeysDescriptions_MaxAtmospheringSpeed",
			MaxCrew = "StarshipSortKeysDescriptions_MaxCrew",
			MGLT = "StarshipSortKeysDescriptions_MGLT",
			MinCrew = "StarshipSortKeysDescriptions_MinCrew",
			Model = "StarshipSortKeysDescriptions_Model",
			Name = "StarshipSortKeysDescriptions_Name",
			Passengers = "StarshipSortKeysDescriptions_Passengers",
			PilotCount = "StarshipSortKeysDescriptions_PilotCount",
			StarshipClass = "StarshipSortKeysDescriptions_StarshipClass",
			StarshipClassFlagsCount = "StarshipSortKeysDescriptions_StarshipClassFlagsCount",
		};
	}

	public static class StarshipSortKeysDescriptionsExtensions
	{
		public static IStarship.ISortKeys? GetStarshipSortKeysDescriptions(this LocalisationResourceManager? localisationResourceManager, IStarship.ISortKeys<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IStarship.ISortKeys.Default
				{
					CargoCapacity = retriever?.CargoCapacity ?? true ? localisationResourceManager.GetString(StarshipSortKeysDescriptions.Keys.CargoCapacity) : null,
					Consumables = retriever?.Consumables ?? true ? localisationResourceManager.GetString(StarshipSortKeysDescriptions.Keys.Consumables) : null,
					CostInCredits = retriever?.CostInCredits ?? true ? localisationResourceManager.GetString(StarshipSortKeysDescriptions.Keys.CostInCredits) : null,
					Created = retriever?.Created ?? true ? localisationResourceManager.GetString(StarshipSortKeysDescriptions.Keys.Created) : null,
					Edited = retriever?.Edited ?? true ? localisationResourceManager.GetString(StarshipSortKeysDescriptions.Keys.Edited) : null,
					HyperdriveRating = retriever?.HyperdriveRating ?? true ? localisationResourceManager.GetString(StarshipSortKeysDescriptions.Keys.HyperdriveRating) : null,
					Id = retriever?.Id ?? true ? localisationResourceManager.GetString(StarshipSortKeysDescriptions.Keys.Id) : null,
					Length = retriever?.Length ?? true ? localisationResourceManager.GetString(StarshipSortKeysDescriptions.Keys.Length) : null,
					ManufacturerCount = retriever?.ManufacturerCount ?? true ? localisationResourceManager.GetString(StarshipSortKeysDescriptions.Keys.ManufacturerCount) : null,
					MaxAtmospheringSpeed = retriever?.MaxAtmospheringSpeed ?? true ? localisationResourceManager.GetString(StarshipSortKeysDescriptions.Keys.MaxAtmospheringSpeed) : null,
					MaxCrew = retriever?.MaxCrew ?? true ? localisationResourceManager.GetString(StarshipSortKeysDescriptions.Keys.MaxCrew) : null,
					MGLT = retriever?.MGLT ?? true ? localisationResourceManager.GetString(StarshipSortKeysDescriptions.Keys.MGLT) : null,
					MinCrew = retriever?.MinCrew ?? true ? localisationResourceManager.GetString(StarshipSortKeysDescriptions.Keys.MinCrew) : null,
					Model = retriever?.Model ?? true ? localisationResourceManager.GetString(StarshipSortKeysDescriptions.Keys.Model) : null,
					Name = retriever?.Name ?? true ? localisationResourceManager.GetString(StarshipSortKeysDescriptions.Keys.Name) : null,
					Passengers = retriever?.Passengers ?? true ? localisationResourceManager.GetString(StarshipSortKeysDescriptions.Keys.Passengers) : null,
					PilotCount = retriever?.PilotCount ?? true ? localisationResourceManager.GetString(StarshipSortKeysDescriptions.Keys.PilotCount) : null,
					StarshipClass = retriever?.StarshipClass ?? true ? localisationResourceManager.GetString(StarshipSortKeysDescriptions.Keys.StarshipClass) : null,
					StarshipClassFlagsCount = retriever?.StarshipClassFlagsCount ?? true ? localisationResourceManager.GetString(StarshipSortKeysDescriptions.Keys.StarshipClassFlagsCount) : null,
				};
	}
}
