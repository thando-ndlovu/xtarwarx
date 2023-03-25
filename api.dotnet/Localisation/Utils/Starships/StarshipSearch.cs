using Localisation.Abstractions.Starships;
using Localisation.Abstractions.StarWarsModels;

namespace Localisation.Utils.Starships
{
	public class StarshipSearch
	{
		public const string ResourceName = "Starships.StarshipSearch";

		public static readonly IStarshipSearchLocalisationTyped<string> Keys = new IStarshipSearchLocalisation.DefaultTyped<string>(string.Empty)
		{
			Title = "StarshipSearch_Title",

			CargoCapacitiesList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "StarshipSearch_CargoCapacitiesList_Title",
				Description = "StarshipSearch_CargoCapacitiesList_Description",
				AddButtonText = "StarshipSearch_CargoCapacitiesList_AddButtonText",
				EntryPlaceholder = "StarshipSearch_CargoCapacitiesList_EntryPlaceholder",
				ToastInvalid = "StarshipSearch_CargoCapacitiesList_ToastInvalid",
				ToastAlreadySelected = "StarshipSearch_CargoCapacitiesList_ToastAlreadySelected",
			},
			CargoCapacityRange = new ISearchRangeLocalisation.Default<string>(string.Empty)
			{
				Title = "StarshipSearch_CargoCapacityRange_Title",
				Description = "StarshipSearch_CargoCapacityRange_Description",
				LowerTitle = "StarshipSearch_CargoCapacityRange_LowerTitle",
				LowerDescription = "StarshipSearch_CargoCapacityRange_LowerDescription",
				LowerPlaceholder = "StarshipSearch_CargoCapacityRange_LowerPlaceholder",
				UpperTitle = "StarshipSearch_CargoCapacityRange_UpperTitle",
				UpperDescription = "StarshipSearch_CargoCapacityRange_UpperDescription",
				UpperPlaceholder = "StarshipSearch_CargoCapacityRange_UpperPlaceholder",
				LowerErrorMessageInvalid = "StarshipSearch_CargoCapacityRange_LowerErrorMessageInvalid",
				UpperErrorMessageInvalid = "StarshipSearch_CargoCapacityRange_UpperErrorMessageInvalid",
				LowerGreaterThanUpperInfoMessage = "StarshipSearch_CargoCapacityRange_LowerGreaterThanUpperInfoMessage",
				UpperLessThanLowerInfoMessage = "StarshipSearch_CargoCapacityRange_UpperLessThanLowerInfoMessage",
			},
			ConsumablesList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "StarshipSearch_ConsumablesList_Title",
				Description = "StarshipSearch_ConsumablesList_Description",
				AddButtonText = "StarshipSearch_ConsumablesList_AddButtonText",
				EntryPlaceholder = "StarshipSearch_ConsumablesList_EntryPlaceholder",
				ToastInvalid = "StarshipSearch_ConsumablesList_ToastInvalid",
				ToastAlreadySelected = "StarshipSearch_ConsumablesList_ToastAlreadySelected",
			},
			ConsumableRange = new ISearchRangeLocalisation.Default<string>(string.Empty)
			{
				Title = "StarshipSearch_ConsumableRange_Title",
				Description = "StarshipSearch_ConsumableRange_Description",
				LowerTitle = "StarshipSearch_ConsumableRange_LowerTitle",
				LowerDescription = "StarshipSearch_ConsumableRange_LowerDescription",
				LowerPlaceholder = "StarshipSearch_ConsumableRange_LowerPlaceholder",
				UpperTitle = "StarshipSearch_ConsumableRange_UpperTitle",
				UpperDescription = "StarshipSearch_ConsumableRange_UpperDescription",
				UpperPlaceholder = "StarshipSearch_ConsumableRange_UpperPlaceholder",
				LowerErrorMessageInvalid = "StarshipSearch_ConsumableRange_LowerErrorMessageInvalid",
				UpperErrorMessageInvalid = "StarshipSearch_ConsumableRange_UpperErrorMessageInvalid",
				LowerGreaterThanUpperInfoMessage = "StarshipSearch_ConsumableRange_LowerGreaterThanUpperInfoMessage",
				UpperLessThanLowerInfoMessage = "StarshipSearch_ConsumableRange_UpperLessThanLowerInfoMessage",
			},
			CostInCreditsList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "StarshipSearch_CostInCreditsList_Title",
				Description = "StarshipSearch_CostInCreditsList_Description",
				AddButtonText = "StarshipSearch_CostInCreditsList_AddButtonText",
				EntryPlaceholder = "StarshipSearch_CostInCreditsList_EntryPlaceholder",
				ToastInvalid = "StarshipSearch_CostInCreditsList_ToastInvalid",
				ToastAlreadySelected = "StarshipSearch_CostInCreditsList_ToastAlreadySelected",
			},
			CostInCreditRange = new ISearchRangeLocalisation.Default<string>(string.Empty)
			{
				Title = "StarshipSearch_CostInCreditRange_Title",
				Description = "StarshipSearch_CostInCreditRange_Description",
				LowerTitle = "StarshipSearch_CostInCreditRange_LowerTitle",
				LowerDescription = "StarshipSearch_CostInCreditRange_LowerDescription",
				LowerPlaceholder = "StarshipSearch_CostInCreditRange_LowerPlaceholder",
				UpperTitle = "StarshipSearch_CostInCreditRange_UpperTitle",
				UpperDescription = "StarshipSearch_CostInCreditRange_UpperDescription",
				UpperPlaceholder = "StarshipSearch_CostInCreditRange_UpperPlaceholder",
				LowerErrorMessageInvalid = "StarshipSearch_CostInCreditRange_LowerErrorMessageInvalid",
				UpperErrorMessageInvalid = "StarshipSearch_CostInCreditRange_UpperErrorMessageInvalid",
				LowerGreaterThanUpperInfoMessage = "StarshipSearch_CostInCreditRange_LowerGreaterThanUpperInfoMessage",
				UpperLessThanLowerInfoMessage = "StarshipSearch_CostInCreditRange_UpperLessThanLowerInfoMessage",
			},
			HyperdriveRatingsList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "StarshipSearch_HyperdriveRatingsList_Title",
				Description = "StarshipSearch_HyperdriveRatingsList_Description",
				AddButtonText = "StarshipSearch_HyperdriveRatingsList_AddButtonText",
				EntryPlaceholder = "StarshipSearch_HyperdriveRatingsList_EntryPlaceholder",
				ToastInvalid = "StarshipSearch_HyperdriveRatingsList_ToastInvalid",
				ToastAlreadySelected = "StarshipSearch_HyperdriveRatingsList_ToastAlreadySelected",
			},
			HyperdriveRatingRange = new ISearchRangeLocalisation.Default<string>(string.Empty)
			{
				Title = "StarshipSearch_HyperdriveRatingRange_Title",
				Description = "StarshipSearch_HyperdriveRatingRange_Description",
				LowerTitle = "StarshipSearch_HyperdriveRatingRange_LowerTitle",
				LowerDescription = "StarshipSearch_HyperdriveRatingRange_LowerDescription",
				LowerPlaceholder = "StarshipSearch_HyperdriveRatingRange_LowerPlaceholder",
				UpperTitle = "StarshipSearch_HyperdriveRatingRange_UpperTitle",
				UpperDescription = "StarshipSearch_HyperdriveRatingRange_UpperDescription",
				UpperPlaceholder = "StarshipSearch_HyperdriveRatingRange_UpperPlaceholder",
				LowerErrorMessageInvalid = "StarshipSearch_HyperdriveRatingRange_LowerErrorMessageInvalid",
				UpperErrorMessageInvalid = "StarshipSearch_HyperdriveRatingRange_UpperErrorMessageInvalid",
				LowerGreaterThanUpperInfoMessage = "StarshipSearch_HyperdriveRatingRange_LowerGreaterThanUpperInfoMessage",
				UpperLessThanLowerInfoMessage = "StarshipSearch_HyperdriveRatingRange_UpperLessThanLowerInfoMessage",
			},
			LengthsList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "StarshipSearch_LengthsList_Title",
				Description = "StarshipSearch_LengthsList_Description",
				AddButtonText = "StarshipSearch_LengthsList_AddButtonText",
				EntryPlaceholder = "StarshipSearch_LengthsList_EntryPlaceholder",
				ToastInvalid = "StarshipSearch_LengthsList_ToastInvalid",
				ToastAlreadySelected = "StarshipSearch_LengthsList_ToastAlreadySelected",
			},
			LengthRange = new ISearchRangeLocalisation.Default<string>(string.Empty)
			{
				Title = "StarshipSearch_LengthRange_Title",
				Description = "StarshipSearch_LengthRange_Description",
				LowerTitle = "StarshipSearch_LengthRange_LowerTitle",
				LowerDescription = "StarshipSearch_LengthRange_LowerDescription",
				LowerPlaceholder = "StarshipSearch_LengthRange_LowerPlaceholder",
				UpperTitle = "StarshipSearch_LengthRange_UpperTitle",
				UpperDescription = "StarshipSearch_LengthRange_UpperDescription",
				UpperPlaceholder = "StarshipSearch_LengthRange_UpperPlaceholder",
				LowerErrorMessageInvalid = "StarshipSearch_LengthRange_LowerErrorMessageInvalid",
				UpperErrorMessageInvalid = "StarshipSearch_LengthRange_UpperErrorMessageInvalid",
				LowerGreaterThanUpperInfoMessage = "StarshipSearch_LengthRange_LowerGreaterThanUpperInfoMessage",
				UpperLessThanLowerInfoMessage = "StarshipSearch_LengthRange_UpperLessThanLowerInfoMessage",
			},
			ManufacturersSearchContainables = new ISearchItemLocalisation.Default<string>(string.Empty)
			{
				Title = "StarshipSearch_ManufacturersSearchContainables_Title",
				Description = "StarshipSearch_ManufacturersSearchContainables_Description",
			},
			MaxAtmospheringSpeedsList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "StarshipSearch_MaxAtmospheringSpeedsList_Title",
				Description = "StarshipSearch_MaxAtmospheringSpeedsList_Description",
				AddButtonText = "StarshipSearch_MaxAtmospheringSpeedsList_AddButtonText",
				EntryPlaceholder = "StarshipSearch_MaxAtmospheringSpeedsList_EntryPlaceholder",
				ToastInvalid = "StarshipSearch_MaxAtmospheringSpeedsList_ToastInvalid",
				ToastAlreadySelected = "StarshipSearch_MaxAtmospheringSpeedsList_ToastAlreadySelected",
			},
			MaxAtmospheringSpeedRange = new ISearchRangeLocalisation.Default<string>(string.Empty)
			{
				Title = "StarshipSearch_MaxAtmospheringSpeedRange_Title",
				Description = "StarshipSearch_MaxAtmospheringSpeedRange_Description",
				LowerTitle = "StarshipSearch_MaxAtmospheringSpeedRange_LowerTitle",
				LowerDescription = "StarshipSearch_MaxAtmospheringSpeedRange_LowerDescription",
				LowerPlaceholder = "StarshipSearch_MaxAtmospheringSpeedRange_LowerPlaceholder",
				UpperTitle = "StarshipSearch_MaxAtmospheringSpeedRange_UpperTitle",
				UpperDescription = "StarshipSearch_MaxAtmospheringSpeedRange_UpperDescription",
				UpperPlaceholder = "StarshipSearch_MaxAtmospheringSpeedRange_UpperPlaceholder",
				LowerErrorMessageInvalid = "StarshipSearch_MaxAtmospheringSpeedRange_LowerErrorMessageInvalid",
				UpperErrorMessageInvalid = "StarshipSearch_MaxAtmospheringSpeedRange_UpperErrorMessageInvalid",
				LowerGreaterThanUpperInfoMessage = "StarshipSearch_MaxAtmospheringSpeedRange_LowerGreaterThanUpperInfoMessage",
				UpperLessThanLowerInfoMessage = "StarshipSearch_MaxAtmospheringSpeedRange_UpperLessThanLowerInfoMessage",
			},
			MaxCrewsList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "StarshipSearch_MaxCrewsList_Title",
				Description = "StarshipSearch_MaxCrewsList_Description",
				AddButtonText = "StarshipSearch_MaxCrewsList_AddButtonText",
				EntryPlaceholder = "StarshipSearch_MaxCrewsList_EntryPlaceholder",
				ToastInvalid = "StarshipSearch_MaxCrewsList_ToastInvalid",
				ToastAlreadySelected = "StarshipSearch_MaxCrewsList_ToastAlreadySelected",
			},
			MaxCrewRange = new ISearchRangeLocalisation.Default<string>(string.Empty)
			{
				Title = "StarshipSearch_MaxCrewRange_Title",
				Description = "StarshipSearch_MaxCrewRange_Description",
				LowerTitle = "StarshipSearch_MaxCrewRange_LowerTitle",
				LowerDescription = "StarshipSearch_MaxCrewRange_LowerDescription",
				LowerPlaceholder = "StarshipSearch_MaxCrewRange_LowerPlaceholder",
				UpperTitle = "StarshipSearch_MaxCrewRange_UpperTitle",
				UpperDescription = "StarshipSearch_MaxCrewRange_UpperDescription",
				UpperPlaceholder = "StarshipSearch_MaxCrewRange_UpperPlaceholder",
				LowerErrorMessageInvalid = "StarshipSearch_MaxCrewRange_LowerErrorMessageInvalid",
				UpperErrorMessageInvalid = "StarshipSearch_MaxCrewRange_UpperErrorMessageInvalid",
				LowerGreaterThanUpperInfoMessage = "StarshipSearch_MaxCrewRange_LowerGreaterThanUpperInfoMessage",
				UpperLessThanLowerInfoMessage = "StarshipSearch_MaxCrewRange_UpperLessThanLowerInfoMessage",
			},
			MinCrewsList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "StarshipSearch_MinCrewsList_Title",
				Description = "StarshipSearch_MinCrewsList_Description",
				AddButtonText = "StarshipSearch_MinCrewsList_AddButtonText",
				EntryPlaceholder = "StarshipSearch_MinCrewsList_EntryPlaceholder",
				ToastInvalid = "StarshipSearch_MinCrewsList_ToastInvalid",
				ToastAlreadySelected = "StarshipSearch_MinCrewsList_ToastAlreadySelected",
			},
			MinCrewRange = new ISearchRangeLocalisation.Default<string>(string.Empty)
			{
				Title = "StarshipSearch_MinCrewRange_Title",
				Description = "StarshipSearch_MinCrewRange_Description",
				LowerTitle = "StarshipSearch_MinCrewRange_LowerTitle",
				LowerDescription = "StarshipSearch_MinCrewRange_LowerDescription",
				LowerPlaceholder = "StarshipSearch_MinCrewRange_LowerPlaceholder",
				UpperTitle = "StarshipSearch_MinCrewRange_UpperTitle",
				UpperDescription = "StarshipSearch_MinCrewRange_UpperDescription",
				UpperPlaceholder = "StarshipSearch_MinCrewRange_UpperPlaceholder",
				LowerErrorMessageInvalid = "StarshipSearch_MinCrewRange_LowerErrorMessageInvalid",
				UpperErrorMessageInvalid = "StarshipSearch_MinCrewRange_UpperErrorMessageInvalid",
				LowerGreaterThanUpperInfoMessage = "StarshipSearch_MinCrewRange_LowerGreaterThanUpperInfoMessage",
				UpperLessThanLowerInfoMessage = "StarshipSearch_MinCrewRange_UpperLessThanLowerInfoMessage",
			},
			MGLTsList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "StarshipSearch_MGLTsList_Title",
				Description = "StarshipSearch_MGLTsList_Description",
				AddButtonText = "StarshipSearch_MGLTsList_AddButtonText",
				EntryPlaceholder = "StarshipSearch_MGLTsList_EntryPlaceholder",
				ToastInvalid = "StarshipSearch_MGLTsList_ToastInvalid",
				ToastAlreadySelected = "StarshipSearch_MGLTsList_ToastAlreadySelected",
			},
			MGLTRange = new ISearchRangeLocalisation.Default<string>(string.Empty)
			{
				Title = "StarshipSearch_MGLTRange_Title",
				Description = "StarshipSearch_MGLTRange_Description",
				LowerTitle = "StarshipSearch_MGLTRange_LowerTitle",
				LowerDescription = "StarshipSearch_MGLTRange_LowerDescription",
				LowerPlaceholder = "StarshipSearch_MGLTRange_LowerPlaceholder",
				UpperTitle = "StarshipSearch_MGLTRange_UpperTitle",
				UpperDescription = "StarshipSearch_MGLTRange_UpperDescription",
				UpperPlaceholder = "StarshipSearch_MGLTRange_UpperPlaceholder",
				LowerErrorMessageInvalid = "StarshipSearch_MGLTRange_LowerErrorMessageInvalid",
				UpperErrorMessageInvalid = "StarshipSearch_MGLTRange_UpperErrorMessageInvalid",
				LowerGreaterThanUpperInfoMessage = "StarshipSearch_MGLTRange_LowerGreaterThanUpperInfoMessage",
				UpperLessThanLowerInfoMessage = "StarshipSearch_MGLTRange_UpperLessThanLowerInfoMessage",
			},
			PassengersList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "StarshipSearch_PassengersList_Title",
				Description = "StarshipSearch_PassengersList_Description",
				AddButtonText = "StarshipSearch_PassengersList_AddButtonText",
				EntryPlaceholder = "StarshipSearch_PassengersList_EntryPlaceholder",
				ToastInvalid = "StarshipSearch_PassengersList_ToastInvalid",
				ToastAlreadySelected = "StarshipSearch_PassengersList_ToastAlreadySelected",
			},
			PassengerRange = new ISearchRangeLocalisation.Default<string>(string.Empty)
			{
				Title = "StarshipSearch_PassengerRange_Title",
				Description = "StarshipSearch_PassengerRange_Description",
				LowerTitle = "StarshipSearch_PassengerRange_LowerTitle",
				LowerDescription = "StarshipSearch_PassengerRange_LowerDescription",
				LowerPlaceholder = "StarshipSearch_PassengerRange_LowerPlaceholder",
				UpperTitle = "StarshipSearch_PassengerRange_UpperTitle",
				UpperDescription = "StarshipSearch_PassengerRange_UpperDescription",
				UpperPlaceholder = "StarshipSearch_PassengerRange_UpperPlaceholder",
				LowerErrorMessageInvalid = "StarshipSearch_PassengerRange_LowerErrorMessageInvalid",
				UpperErrorMessageInvalid = "StarshipSearch_PassengerRange_UpperErrorMessageInvalid",
				LowerGreaterThanUpperInfoMessage = "StarshipSearch_PassengerRange_LowerGreaterThanUpperInfoMessage",
				UpperLessThanLowerInfoMessage = "StarshipSearch_PassengerRange_UpperLessThanLowerInfoMessage",
			},
			PilotsSearchContainables = new ISearchItemLocalisation.Default<string>(string.Empty)
			{
				Title = "StarshipSearch_PilotsSearchContainables_Title",
				Description = "StarshipSearch_PilotsSearchContainables_Description",
			},
        };
	}

	public static class StarshipSearchExtensions
	{
		public static IStarshipSearchLocalisation? GetStarshipSearch(this LocalisationResourceManager? localisationResourceManager, IStarshipSearchLocalisationTyped<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IStarshipSearchLocalisation.Default 
				{
					Title = retriever?.Title?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.Title) : null,

					CargoCapacitiesList = new ISearchListLocalisation.Default
					{
						Title = retriever?.CargoCapacitiesList?.Title ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.CargoCapacitiesList.Title) : null,
						Description = retriever?.CargoCapacitiesList?.Description ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.CargoCapacitiesList.Description) : null,
						AddButtonText = retriever?.CargoCapacitiesList?.AddButtonText ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.CargoCapacitiesList.AddButtonText) : null,
						EntryPlaceholder = retriever?.CargoCapacitiesList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.CargoCapacitiesList.EntryPlaceholder) : null,
						ToastInvalid = retriever?.CargoCapacitiesList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.CargoCapacitiesList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.CargoCapacitiesList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.CargoCapacitiesList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
					CargoCapacityRange = new ISearchRangeLocalisation.Default
					{
						Title = retriever?.CargoCapacityRange?.Title ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.CargoCapacityRange.Title) : null,
						Description = retriever?.CargoCapacityRange?.Description ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.CargoCapacityRange.Description) : null,
						LowerTitle = retriever?.CargoCapacityRange?.LowerTitle ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.CargoCapacityRange.LowerTitle) : null,
						LowerDescription = retriever?.CargoCapacityRange?.LowerDescription ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.CargoCapacityRange.LowerDescription) : null,
						LowerPlaceholder = retriever?.CargoCapacityRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.CargoCapacityRange.LowerPlaceholder) : null,
						UpperTitle = retriever?.CargoCapacityRange?.UpperTitle ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.CargoCapacityRange.UpperTitle) : null,
						UpperDescription = retriever?.CargoCapacityRange?.UpperDescription ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.CargoCapacityRange.UpperDescription) : null,
						UpperPlaceholder = retriever?.CargoCapacityRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.CargoCapacityRange.UpperPlaceholder) : null,
						LowerErrorMessageInvalid = retriever?.CargoCapacityRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.CargoCapacityRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
						UpperErrorMessageInvalid = retriever?.CargoCapacityRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.CargoCapacityRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
						LowerGreaterThanUpperInfoMessage = retriever?.CargoCapacityRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.CargoCapacityRange.LowerGreaterThanUpperInfoMessage) : null,
						UpperLessThanLowerInfoMessage = retriever?.CargoCapacityRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.CargoCapacityRange.UpperLessThanLowerInfoMessage) : null,
					},
					ConsumablesList = new ISearchListLocalisation.Default
					{
						Title = retriever?.ConsumablesList?.Title ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.ConsumablesList.Title) : null,
						Description = retriever?.ConsumablesList?.Description ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.ConsumablesList.Description) : null,
						AddButtonText = retriever?.ConsumablesList?.AddButtonText ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.ConsumablesList.AddButtonText) : null,
						EntryPlaceholder = retriever?.ConsumablesList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.ConsumablesList.EntryPlaceholder) : null,
						ToastInvalid = retriever?.ConsumablesList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.ConsumablesList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.ConsumablesList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.ConsumablesList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
					ConsumableRange = new ISearchRangeLocalisation.Default
					{
						Title = retriever?.ConsumableRange?.Title ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.ConsumableRange.Title) : null,
						Description = retriever?.ConsumableRange?.Description ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.ConsumableRange.Description) : null,
						LowerTitle = retriever?.ConsumableRange?.LowerTitle ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.ConsumableRange.LowerTitle) : null,
						LowerDescription = retriever?.ConsumableRange?.LowerDescription ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.ConsumableRange.LowerDescription) : null,
						LowerPlaceholder = retriever?.ConsumableRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.ConsumableRange.LowerPlaceholder) : null,
						UpperTitle = retriever?.ConsumableRange?.UpperTitle ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.ConsumableRange.UpperTitle) : null,
						UpperDescription = retriever?.ConsumableRange?.UpperDescription ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.ConsumableRange.UpperDescription) : null,
						UpperPlaceholder = retriever?.ConsumableRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.ConsumableRange.UpperPlaceholder) : null,
						LowerErrorMessageInvalid = retriever?.ConsumableRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.ConsumableRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
						UpperErrorMessageInvalid = retriever?.ConsumableRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.ConsumableRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
						LowerGreaterThanUpperInfoMessage = retriever?.ConsumableRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.ConsumableRange.LowerGreaterThanUpperInfoMessage) : null,
						UpperLessThanLowerInfoMessage = retriever?.ConsumableRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.ConsumableRange.UpperLessThanLowerInfoMessage) : null,
					},
					CostInCreditsList = new ISearchListLocalisation.Default
					{
						Title = retriever?.CostInCreditsList?.Title ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.CostInCreditsList.Title) : null,
						Description = retriever?.CostInCreditsList?.Description ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.CostInCreditsList.Description) : null,
						AddButtonText = retriever?.CostInCreditsList?.AddButtonText ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.CostInCreditsList.AddButtonText) : null,
						EntryPlaceholder = retriever?.CostInCreditsList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.CostInCreditsList.EntryPlaceholder) : null,
						ToastInvalid = retriever?.CostInCreditsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.CostInCreditsList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.CostInCreditsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.CostInCreditsList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
					CostInCreditRange = new ISearchRangeLocalisation.Default
					{
						Title = retriever?.CostInCreditRange?.Title ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.CostInCreditRange.Title) : null,
						Description = retriever?.CostInCreditRange?.Description ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.CostInCreditRange.Description) : null,
						LowerTitle = retriever?.CostInCreditRange?.LowerTitle ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.CostInCreditRange.LowerTitle) : null,
						LowerDescription = retriever?.CostInCreditRange?.LowerDescription ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.CostInCreditRange.LowerDescription) : null,
						LowerPlaceholder = retriever?.CostInCreditRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.CostInCreditRange.LowerPlaceholder) : null,
						UpperTitle = retriever?.CostInCreditRange?.UpperTitle ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.CostInCreditRange.UpperTitle) : null,
						UpperDescription = retriever?.CostInCreditRange?.UpperDescription ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.CostInCreditRange.UpperDescription) : null,
						UpperPlaceholder = retriever?.CostInCreditRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.CostInCreditRange.UpperPlaceholder) : null,
						LowerErrorMessageInvalid = retriever?.CostInCreditRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.CostInCreditRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
						UpperErrorMessageInvalid = retriever?.CostInCreditRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.CostInCreditRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
						LowerGreaterThanUpperInfoMessage = retriever?.CostInCreditRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.CostInCreditRange.LowerGreaterThanUpperInfoMessage) : null,
						UpperLessThanLowerInfoMessage = retriever?.CostInCreditRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.CostInCreditRange.UpperLessThanLowerInfoMessage) : null,
					},
					HyperdriveRatingsList = new ISearchListLocalisation.Default
					{
						Title = retriever?.HyperdriveRatingsList?.Title ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.HyperdriveRatingsList.Title) : null,
						Description = retriever?.HyperdriveRatingsList?.Description ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.HyperdriveRatingsList.Description) : null,
						AddButtonText = retriever?.HyperdriveRatingsList?.AddButtonText ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.HyperdriveRatingsList.AddButtonText) : null,
						EntryPlaceholder = retriever?.HyperdriveRatingsList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.HyperdriveRatingsList.EntryPlaceholder) : null,
						ToastInvalid = retriever?.HyperdriveRatingsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.HyperdriveRatingsList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.HyperdriveRatingsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.HyperdriveRatingsList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
					HyperdriveRatingRange = new ISearchRangeLocalisation.Default
					{
						Title = retriever?.HyperdriveRatingRange?.Title ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.HyperdriveRatingRange.Title) : null,
						Description = retriever?.HyperdriveRatingRange?.Description ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.HyperdriveRatingRange.Description) : null,
						LowerDescription = retriever?.HyperdriveRatingRange?.LowerDescription ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.HyperdriveRatingRange.LowerDescription) : null,
						LowerPlaceholder = retriever?.HyperdriveRatingRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.HyperdriveRatingRange.LowerPlaceholder) : null,
						UpperDescription = retriever?.HyperdriveRatingRange?.UpperDescription ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.HyperdriveRatingRange.UpperDescription) : null,
						UpperPlaceholder = retriever?.HyperdriveRatingRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.HyperdriveRatingRange.UpperPlaceholder) : null,
						LowerErrorMessageInvalid = retriever?.HyperdriveRatingRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.HyperdriveRatingRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
						UpperErrorMessageInvalid = retriever?.HyperdriveRatingRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.HyperdriveRatingRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
						LowerGreaterThanUpperInfoMessage = retriever?.HyperdriveRatingRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.HyperdriveRatingRange.LowerGreaterThanUpperInfoMessage) : null,
						UpperLessThanLowerInfoMessage = retriever?.HyperdriveRatingRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.HyperdriveRatingRange.UpperLessThanLowerInfoMessage) : null,
					},
					LengthsList = new ISearchListLocalisation.Default
					{
						Title = retriever?.LengthsList?.Title ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.LengthsList.Title) : null,
						Description = retriever?.LengthsList?.Description ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.LengthsList.Description) : null,
						AddButtonText = retriever?.LengthsList?.AddButtonText ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.LengthsList.AddButtonText) : null,
						EntryPlaceholder = retriever?.LengthsList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.LengthsList.EntryPlaceholder) : null,
						ToastInvalid = retriever?.LengthsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.LengthsList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.LengthsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.LengthsList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
					LengthRange = new ISearchRangeLocalisation.Default
					{
						Title = retriever?.LengthRange?.Title ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.LengthRange.Title) : null,
						Description = retriever?.LengthRange?.Description ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.LengthRange.Description) : null,
						LowerTitle = retriever?.LengthRange?.LowerTitle ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.LengthRange.LowerTitle) : null,
						LowerDescription = retriever?.LengthRange?.LowerDescription ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.LengthRange.LowerDescription) : null,
						LowerPlaceholder = retriever?.LengthRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.LengthRange.LowerPlaceholder) : null,
						UpperTitle = retriever?.LengthRange?.UpperTitle ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.LengthRange.UpperTitle) : null,
						UpperDescription = retriever?.LengthRange?.UpperDescription ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.LengthRange.UpperDescription) : null,
						UpperPlaceholder = retriever?.LengthRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.LengthRange.UpperPlaceholder) : null,
						LowerErrorMessageInvalid = retriever?.LengthRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.LengthRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
						UpperErrorMessageInvalid = retriever?.LengthRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.LengthRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
						LowerGreaterThanUpperInfoMessage = retriever?.LengthRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.LengthRange.LowerGreaterThanUpperInfoMessage) : null,
						UpperLessThanLowerInfoMessage = retriever?.LengthRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.LengthRange.UpperLessThanLowerInfoMessage) : null,
					},
					ManufacturersSearchContainables = new ISearchItemLocalisation.Default
					{
						Title = retriever?.ManufacturersSearchContainables?.Title ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.ManufacturersSearchContainables.Title) : null,
						Description = retriever?.ManufacturersSearchContainables?.Description ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.ManufacturersSearchContainables.Description) : null,
					},
					MaxAtmospheringSpeedsList = new ISearchListLocalisation.Default
					{
						Title = retriever?.MaxAtmospheringSpeedsList?.Title ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MaxAtmospheringSpeedsList.Title) : null,
						Description = retriever?.MaxAtmospheringSpeedsList?.Description ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MaxAtmospheringSpeedsList.Description) : null,
						AddButtonText = retriever?.MaxAtmospheringSpeedsList?.AddButtonText ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MaxAtmospheringSpeedsList.AddButtonText) : null,
						EntryPlaceholder = retriever?.MaxAtmospheringSpeedsList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MaxAtmospheringSpeedsList.EntryPlaceholder) : null,
						ToastInvalid = retriever?.MaxAtmospheringSpeedsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.MaxAtmospheringSpeedsList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.MaxAtmospheringSpeedsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.MaxAtmospheringSpeedsList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
					MaxAtmospheringSpeedRange = new ISearchRangeLocalisation.Default
					{
						Title = retriever?.MaxAtmospheringSpeedRange?.Title ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MaxAtmospheringSpeedRange.Title) : null,
						Description = retriever?.MaxAtmospheringSpeedRange?.Description ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MaxAtmospheringSpeedRange.Description) : null,
						LowerTitle = retriever?.MaxAtmospheringSpeedRange?.LowerTitle ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MaxAtmospheringSpeedRange.LowerTitle) : null,
						LowerDescription = retriever?.MaxAtmospheringSpeedRange?.LowerDescription ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MaxAtmospheringSpeedRange.LowerDescription) : null,
						LowerPlaceholder = retriever?.MaxAtmospheringSpeedRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MaxAtmospheringSpeedRange.LowerPlaceholder) : null,
						UpperTitle = retriever?.MaxAtmospheringSpeedRange?.UpperTitle ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MaxAtmospheringSpeedRange.UpperTitle) : null,
						UpperDescription = retriever?.MaxAtmospheringSpeedRange?.UpperDescription ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MaxAtmospheringSpeedRange.UpperDescription) : null,
						UpperPlaceholder = retriever?.MaxAtmospheringSpeedRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MaxAtmospheringSpeedRange.UpperPlaceholder) : null,
						LowerErrorMessageInvalid = retriever?.MaxAtmospheringSpeedRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.MaxAtmospheringSpeedRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
						UpperErrorMessageInvalid = retriever?.MaxAtmospheringSpeedRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.MaxAtmospheringSpeedRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
						LowerGreaterThanUpperInfoMessage = retriever?.MaxAtmospheringSpeedRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MaxAtmospheringSpeedRange.LowerGreaterThanUpperInfoMessage) : null,
						UpperLessThanLowerInfoMessage = retriever?.MaxAtmospheringSpeedRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MaxAtmospheringSpeedRange.UpperLessThanLowerInfoMessage) : null,
					},
					MaxCrewsList = new ISearchListLocalisation.Default
					{
						Title = retriever?.MaxCrewsList?.Title ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MaxCrewsList.Title) : null,
						Description = retriever?.MaxCrewsList?.Description ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MaxCrewsList.Description) : null,
						AddButtonText = retriever?.MaxCrewsList?.AddButtonText ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MaxCrewsList.AddButtonText) : null,
						EntryPlaceholder = retriever?.MaxCrewsList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MaxCrewsList.EntryPlaceholder) : null,
						ToastInvalid = retriever?.MaxCrewsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.MaxCrewsList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.MaxCrewsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.MaxCrewsList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
					MaxCrewRange = new ISearchRangeLocalisation.Default
					{
						Title = retriever?.MaxCrewRange?.Title ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MaxCrewRange.Title) : null,
						Description = retriever?.MaxCrewRange?.Description ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MaxCrewRange.Description) : null,
						LowerTitle = retriever?.MaxCrewRange?.LowerTitle ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MaxCrewRange.LowerTitle) : null,
						LowerDescription = retriever?.MaxCrewRange?.LowerDescription ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MaxCrewRange.LowerDescription) : null,
						LowerPlaceholder = retriever?.MaxCrewRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MaxCrewRange.LowerPlaceholder) : null,
						UpperTitle = retriever?.MaxCrewRange?.UpperTitle ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MaxCrewRange.UpperTitle) : null,
						UpperDescription = retriever?.MaxCrewRange?.UpperDescription ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MaxCrewRange.UpperDescription) : null,
						UpperPlaceholder = retriever?.MaxCrewRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MaxCrewRange.UpperPlaceholder) : null,
						LowerErrorMessageInvalid = retriever?.MaxCrewRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.MaxCrewRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
						UpperErrorMessageInvalid = retriever?.MaxCrewRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.MaxCrewRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
						LowerGreaterThanUpperInfoMessage = retriever?.MaxCrewRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MaxCrewRange.LowerGreaterThanUpperInfoMessage) : null,
						UpperLessThanLowerInfoMessage = retriever?.MaxCrewRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MaxCrewRange.UpperLessThanLowerInfoMessage) : null,
					},
					MinCrewsList = new ISearchListLocalisation.Default
					{
						Title = retriever?.MinCrewsList?.Title ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MinCrewsList.Title) : null,
						Description = retriever?.MinCrewsList?.Description ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MinCrewsList.Description) : null,
						AddButtonText = retriever?.MinCrewsList?.AddButtonText ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MinCrewsList.AddButtonText) : null,
						EntryPlaceholder = retriever?.MinCrewsList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MinCrewsList.EntryPlaceholder) : null,
						ToastInvalid = retriever?.MinCrewsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.MinCrewsList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.MinCrewsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.MinCrewsList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
					MinCrewRange = new ISearchRangeLocalisation.Default
					{
						Title = retriever?.MinCrewRange?.Title ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MinCrewRange.Title) : null,
						Description = retriever?.MinCrewRange?.Description ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MinCrewRange.Description) : null,
						LowerTitle = retriever?.MinCrewRange?.LowerTitle ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MinCrewRange.LowerTitle) : null,
						LowerDescription = retriever?.MinCrewRange?.LowerDescription ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MinCrewRange.LowerDescription) : null,
						LowerPlaceholder = retriever?.MinCrewRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MinCrewRange.LowerPlaceholder) : null,
						UpperTitle = retriever?.MinCrewRange?.UpperTitle ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MinCrewRange.UpperTitle) : null,
						UpperDescription = retriever?.MinCrewRange?.UpperDescription ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MinCrewRange.UpperDescription) : null,
						UpperPlaceholder = retriever?.MinCrewRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MinCrewRange.UpperPlaceholder) : null,
						LowerErrorMessageInvalid = retriever?.MinCrewRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.MinCrewRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
						UpperErrorMessageInvalid = retriever?.MinCrewRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.MinCrewRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
						LowerGreaterThanUpperInfoMessage = retriever?.MinCrewRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MinCrewRange.LowerGreaterThanUpperInfoMessage) : null,
						UpperLessThanLowerInfoMessage = retriever?.MinCrewRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MinCrewRange.UpperLessThanLowerInfoMessage) : null,
					},
					MGLTsList = new ISearchListLocalisation.Default
					{
						Title = retriever?.MGLTsList?.Title ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MGLTsList.Title) : null,
						Description = retriever?.MGLTsList?.Description ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MGLTsList.Description) : null,
						AddButtonText = retriever?.MGLTsList?.AddButtonText ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MGLTsList.AddButtonText) : null,
						EntryPlaceholder = retriever?.MGLTsList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MGLTsList.EntryPlaceholder) : null,
						ToastInvalid = retriever?.MGLTsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.MGLTsList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.MGLTsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.MGLTsList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
					MGLTRange = new ISearchRangeLocalisation.Default
					{
						Title = retriever?.MGLTRange?.Title ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MGLTRange.Title) : null,
						Description = retriever?.MGLTRange?.Description ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MGLTRange.Description) : null,
						LowerTitle = retriever?.MGLTRange?.LowerTitle ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MGLTRange.LowerTitle) : null,
						LowerDescription = retriever?.MGLTRange?.LowerDescription ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MGLTRange.LowerDescription) : null,
						LowerPlaceholder = retriever?.MGLTRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MGLTRange.LowerPlaceholder) : null,
						UpperTitle = retriever?.MGLTRange?.UpperTitle ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MGLTRange.UpperTitle) : null,
						UpperDescription = retriever?.MGLTRange?.UpperDescription ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MGLTRange.UpperDescription) : null,
						UpperPlaceholder = retriever?.MGLTRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MGLTRange.UpperPlaceholder) : null,
						LowerErrorMessageInvalid = retriever?.MGLTRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.MGLTRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
						UpperErrorMessageInvalid = retriever?.MGLTRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.MGLTRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
						LowerGreaterThanUpperInfoMessage = retriever?.MGLTRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MGLTRange.LowerGreaterThanUpperInfoMessage) : null,
						UpperLessThanLowerInfoMessage = retriever?.MGLTRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.MGLTRange.UpperLessThanLowerInfoMessage) : null,
					},
					PassengersList = new ISearchListLocalisation.Default
					{
						Title = retriever?.PassengersList?.Title ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.PassengersList.Title) : null,
						Description = retriever?.PassengersList?.Description ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.PassengersList.Description) : null,
						AddButtonText = retriever?.PassengersList?.AddButtonText ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.PassengersList.AddButtonText) : null,
						EntryPlaceholder = retriever?.PassengersList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.PassengersList.EntryPlaceholder) : null,
						ToastInvalid = retriever?.PassengersList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.PassengersList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.PassengersList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.PassengersList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
					PassengerRange = new ISearchRangeLocalisation.Default
					{
						Title = retriever?.PassengerRange?.Title ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.PassengerRange.Title) : null,
						Description = retriever?.PassengerRange?.Description ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.PassengerRange.Description) : null,
						LowerTitle = retriever?.PassengerRange?.LowerTitle ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.PassengerRange.LowerTitle) : null,
						LowerDescription = retriever?.PassengerRange?.LowerDescription ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.PassengerRange.LowerDescription) : null,
						LowerPlaceholder = retriever?.PassengerRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.PassengerRange.LowerPlaceholder) : null,
						UpperTitle = retriever?.PassengerRange?.UpperTitle ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.PassengerRange.UpperTitle) : null,
						UpperDescription = retriever?.PassengerRange?.UpperDescription ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.PassengerRange.UpperDescription) : null,
						UpperPlaceholder = retriever?.PassengerRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.PassengerRange.UpperPlaceholder) : null,
						LowerErrorMessageInvalid = retriever?.PassengerRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.PassengerRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
						UpperErrorMessageInvalid = retriever?.PassengerRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(StarshipSearch.Keys.PassengerRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
						LowerGreaterThanUpperInfoMessage = retriever?.PassengerRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.PassengerRange.LowerGreaterThanUpperInfoMessage) : null,
						UpperLessThanLowerInfoMessage = retriever?.PassengerRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.PassengerRange.UpperLessThanLowerInfoMessage) : null,
					},
					PilotsSearchContainables = new ISearchItemLocalisation.Default
					{
						Title = retriever?.PilotsSearchContainables?.Title ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.PilotsSearchContainables.Title) : null,
						Description = retriever?.PilotsSearchContainables?.Description ?? true ? localisationResourceManager.GetString(StarshipSearch.Keys.PilotsSearchContainables.Description) : null,
					},
				};
	}
}