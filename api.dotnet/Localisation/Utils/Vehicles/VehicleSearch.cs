using System;

using Localisation.Abstractions.Vehicles;
using Localisation.Abstractions.StarWarsModels;

namespace Localisation.Utils.Vehicles
{
	public class VehicleSearch
	{
		public const string ResourceName = "Vehicles.VehicleSearch";

		public static readonly IVehicleSearchLocalisationTyped<string> Keys = new IVehicleSearchLocalisation.DefaultTyped<string>(string.Empty)
		{
			Title = "VehicleSearch_Title",

			CargoCapacitiesList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "VehicleSearch_CargoCapacitiesList_Title",
				Description = "VehicleSearch_CargoCapacitiesList_Description",
				AddButtonText = "VehicleSearch_CargoCapacitiesList_AddButtonText",
				EntryPlaceholder = "VehicleSearch_CargoCapacitiesList_EntryPlaceholder",
				ToastInvalid = "VehicleSearch_CargoCapacitiesList_ToastInvalid",
				ToastAlreadySelected = "VehicleSearch_CargoCapacitiesList_ToastAlreadySelected",
			},
			CargoCapacityRange = new ISearchRangeLocalisation.Default<string>(string.Empty)
			{
				Title = "VehicleSearch_CargoCapacityRange_Title",
				Description = "VehicleSearch_CargoCapacityRange_Description",
				LowerTitle = "VehicleSearch_CargoCapacityRange_LowerTitle",
				LowerDescription = "VehicleSearch_CargoCapacityRange_LowerDescription",
				LowerPlaceholder = "VehicleSearch_CargoCapacityRange_LowerPlaceholder",
				UpperTitle = "VehicleSearch_CargoCapacityRange_UpperTitle",
				UpperDescription = "VehicleSearch_CargoCapacityRange_UpperDescription",
				UpperPlaceholder = "VehicleSearch_CargoCapacityRange_UpperPlaceholder",
				LowerErrorMessageInvalid = "VehicleSearch_CargoCapacityRange_LowerErrorMessageInvalid",
				UpperErrorMessageInvalid = "VehicleSearch_CargoCapacityRange_UpperErrorMessageInvalid",
				LowerGreaterThanUpperInfoMessage = "VehicleSearch_CargoCapacityRange_LowerGreaterThanUpperInfoMessage",
				UpperLessThanLowerInfoMessage = "VehicleSearch_CargoCapacityRange_UpperLessThanLowerInfoMessage",
			},
			ConsumablesList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "VehicleSearch_ConsumablesList_Title",
				Description = "VehicleSearch_ConsumablesList_Description",
				AddButtonText = "VehicleSearch_ConsumablesList_AddButtonText",
				EntryPlaceholder = "VehicleSearch_ConsumablesList_EntryPlaceholder",
				ToastInvalid = "VehicleSearch_ConsumablesList_ToastInvalid",
				ToastAlreadySelected = "VehicleSearch_ConsumablesList_ToastAlreadySelected",
			},
			ConsumableRange = new ISearchRangeLocalisation.Default<string>(string.Empty)
			{
				Title = "VehicleSearch_ConsumableRange_Title",
				Description = "VehicleSearch_ConsumableRange_Description",
				LowerTitle = "VehicleSearch_ConsumableRange_LowerTitle",
				LowerDescription = "VehicleSearch_ConsumableRange_LowerDescription",
				LowerPlaceholder = "VehicleSearch_ConsumableRange_LowerPlaceholder",
				UpperTitle = "VehicleSearch_ConsumableRange_UpperTitle",
				UpperDescription = "VehicleSearch_ConsumableRange_UpperDescription",
				UpperPlaceholder = "VehicleSearch_ConsumableRange_UpperPlaceholder",
				LowerErrorMessageInvalid = "VehicleSearch_ConsumableRange_LowerErrorMessageInvalid",
				UpperErrorMessageInvalid = "VehicleSearch_ConsumableRange_UpperErrorMessageInvalid",
				LowerGreaterThanUpperInfoMessage = "VehicleSearch_ConsumableRange_LowerGreaterThanUpperInfoMessage",
				UpperLessThanLowerInfoMessage = "VehicleSearch_ConsumableRange_UpperLessThanLowerInfoMessage",
			},
			CostInCreditsList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "VehicleSearch_CostInCreditsList_Title",
				Description = "VehicleSearch_CostInCreditsList_Description",
				AddButtonText = "VehicleSearch_CostInCreditsList_AddButtonText",
				EntryPlaceholder = "VehicleSearch_CostInCreditsList_EntryPlaceholder",
				ToastInvalid = "VehicleSearch_CostInCreditsList_ToastInvalid",
				ToastAlreadySelected = "VehicleSearch_CostInCreditsList_ToastAlreadySelected",
			},
			CostInCreditRange = new ISearchRangeLocalisation.Default<string>(string.Empty)
			{
				Title = "VehicleSearch_CostInCreditRange_Title",
				Description = "VehicleSearch_CostInCreditRange_Description",
				LowerTitle = "VehicleSearch_CostInCreditRange_LowerTitle",
				LowerDescription = "VehicleSearch_CostInCreditRange_LowerDescription",
				LowerPlaceholder = "VehicleSearch_CostInCreditRange_LowerPlaceholder",
				UpperTitle = "VehicleSearch_CostInCreditRange_UpperTitle",
				UpperDescription = "VehicleSearch_CostInCreditRange_UpperDescription",
				UpperPlaceholder = "VehicleSearch_CostInCreditRange_UpperPlaceholder",
				LowerErrorMessageInvalid = "VehicleSearch_CostInCreditRange_LowerErrorMessageInvalid",
				UpperErrorMessageInvalid = "VehicleSearch_CostInCreditRange_UpperErrorMessageInvalid",
				LowerGreaterThanUpperInfoMessage = "VehicleSearch_CostInCreditRange_LowerGreaterThanUpperInfoMessage",
				UpperLessThanLowerInfoMessage = "VehicleSearch_CostInCreditRange_UpperLessThanLowerInfoMessage",
			},
			LengthsList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "VehicleSearch_LengthsList_Title",
				Description = "VehicleSearch_LengthsList_Description",
				AddButtonText = "VehicleSearch_LengthsList_AddButtonText",
				EntryPlaceholder = "VehicleSearch_LengthsList_EntryPlaceholder",
				ToastInvalid = "VehicleSearch_LengthsList_ToastInvalid",
				ToastAlreadySelected = "VehicleSearch_LengthsList_ToastAlreadySelected",
			},
			LengthRange = new ISearchRangeLocalisation.Default<string>(string.Empty)
			{
				Title = "VehicleSearch_LengthRange_Title",
				Description = "VehicleSearch_LengthRange_Description",
				LowerTitle = "VehicleSearch_LengthRange_LowerTitle",
				LowerDescription = "VehicleSearch_LengthRange_LowerDescription",
				LowerPlaceholder = "VehicleSearch_LengthRange_LowerPlaceholder",
				UpperTitle = "VehicleSearch_LengthRange_UpperTitle",
				UpperDescription = "VehicleSearch_LengthRange_UpperDescription",
				UpperPlaceholder = "VehicleSearch_LengthRange_UpperPlaceholder",
				LowerErrorMessageInvalid = "VehicleSearch_LengthRange_LowerErrorMessageInvalid",
				UpperErrorMessageInvalid = "VehicleSearch_LengthRange_UpperErrorMessageInvalid",
				LowerGreaterThanUpperInfoMessage = "VehicleSearch_LengthRange_LowerGreaterThanUpperInfoMessage",
				UpperLessThanLowerInfoMessage = "VehicleSearch_LengthRange_UpperLessThanLowerInfoMessage",
			},
			ManufacturersSearchContainables = new ISearchItemLocalisation.Default<string>(string.Empty)
			{
				Title = "VehicleSearch_ManufacturersSearchContainables_Title",
				Description = "VehicleSearch_ManufacturersSearchContainables_Description",
			},
			MaxAtmospheringSpeedsList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "VehicleSearch_MaxAtmospheringSpeedsList_Title",
				Description = "VehicleSearch_MaxAtmospheringSpeedsList_Description",
				AddButtonText = "VehicleSearch_MaxAtmospheringSpeedsList_AddButtonText",
				EntryPlaceholder = "VehicleSearch_MaxAtmospheringSpeedsList_EntryPlaceholder",
				ToastInvalid = "VehicleSearch_MaxAtmospheringSpeedsList_ToastInvalid",
				ToastAlreadySelected = "VehicleSearch_MaxAtmospheringSpeedsList_ToastAlreadySelected",
			},
			MaxAtmospheringSpeedRange = new ISearchRangeLocalisation.Default<string>(string.Empty)
			{
				Title = "VehicleSearch_MaxAtmospheringSpeedRange_Title",
				Description = "VehicleSearch_MaxAtmospheringSpeedRange_Description",
				LowerTitle = "VehicleSearch_MaxAtmospheringSpeedRange_LowerTitle",
				LowerDescription = "VehicleSearch_MaxAtmospheringSpeedRange_LowerDescription",
				LowerPlaceholder = "VehicleSearch_MaxAtmospheringSpeedRange_LowerPlaceholder",
				UpperTitle = "VehicleSearch_MaxAtmospheringSpeedRange_UpperTitle",
				UpperDescription = "VehicleSearch_MaxAtmospheringSpeedRange_UpperDescription",
				UpperPlaceholder = "VehicleSearch_MaxAtmospheringSpeedRange_UpperPlaceholder",
				LowerErrorMessageInvalid = "VehicleSearch_MaxAtmospheringSpeedRange_LowerErrorMessageInvalid",
				UpperErrorMessageInvalid = "VehicleSearch_MaxAtmospheringSpeedRange_UpperErrorMessageInvalid",
				LowerGreaterThanUpperInfoMessage = "VehicleSearch_MaxAtmospheringSpeedRange_LowerGreaterThanUpperInfoMessage",
				UpperLessThanLowerInfoMessage = "VehicleSearch_MaxAtmospheringSpeedRange_UpperLessThanLowerInfoMessage",
			},
			MaxCrewsList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "VehicleSearch_MaxCrewsList_Title",
				Description = "VehicleSearch_MaxCrewsList_Description",
				AddButtonText = "VehicleSearch_MaxCrewsList_AddButtonText",
				EntryPlaceholder = "VehicleSearch_MaxCrewsList_EntryPlaceholder",
				ToastInvalid = "VehicleSearch_MaxCrewsList_ToastInvalid",
				ToastAlreadySelected = "VehicleSearch_MaxCrewsList_ToastAlreadySelected",
			},
			MaxCrewRange = new ISearchRangeLocalisation.Default<string>(string.Empty)
			{
				Title = "VehicleSearch_MaxCrewRange_Title",
				Description = "VehicleSearch_MaxCrewRange_Description",
				LowerTitle = "VehicleSearch_MaxCrewRange_LowerTitle",
				LowerDescription = "VehicleSearch_MaxCrewRange_LowerDescription",
				LowerPlaceholder = "VehicleSearch_MaxCrewRange_LowerPlaceholder",
				UpperTitle = "VehicleSearch_MaxCrewRange_UpperTitle",
				UpperDescription = "VehicleSearch_MaxCrewRange_UpperDescription",
				UpperPlaceholder = "VehicleSearch_MaxCrewRange_UpperPlaceholder",
				LowerErrorMessageInvalid = "VehicleSearch_MaxCrewRange_LowerErrorMessageInvalid",
				UpperErrorMessageInvalid = "VehicleSearch_MaxCrewRange_UpperErrorMessageInvalid",
				LowerGreaterThanUpperInfoMessage = "VehicleSearch_MaxCrewRange_LowerGreaterThanUpperInfoMessage",
				UpperLessThanLowerInfoMessage = "VehicleSearch_MaxCrewRange_UpperLessThanLowerInfoMessage",
			},
			MinCrewsList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "VehicleSearch_MinCrewsList_Title",
				Description = "VehicleSearch_MinCrewsList_Description",
				AddButtonText = "VehicleSearch_MinCrewsList_AddButtonText",
				EntryPlaceholder = "VehicleSearch_MinCrewsList_EntryPlaceholder",
				ToastInvalid = "VehicleSearch_MinCrewsList_ToastInvalid",
				ToastAlreadySelected = "VehicleSearch_MinCrewsList_ToastAlreadySelected",
			},
			MinCrewRange = new ISearchRangeLocalisation.Default<string>(string.Empty)
			{
				Title = "VehicleSearch_MinCrewRange_Title",
				Description = "VehicleSearch_MinCrewRange_Description",
				LowerTitle = "VehicleSearch_MinCrewRange_LowerTitle",
				LowerDescription = "VehicleSearch_MinCrewRange_LowerDescription",
				LowerPlaceholder = "VehicleSearch_MinCrewRange_LowerPlaceholder",
				UpperTitle = "VehicleSearch_MinCrewRange_UpperTitle",
				UpperDescription = "VehicleSearch_MinCrewRange_UpperDescription",
				UpperPlaceholder = "VehicleSearch_MinCrewRange_UpperPlaceholder",
				LowerErrorMessageInvalid = "VehicleSearch_MinCrewRange_LowerErrorMessageInvalid",
				UpperErrorMessageInvalid = "VehicleSearch_MinCrewRange_UpperErrorMessageInvalid",
				LowerGreaterThanUpperInfoMessage = "VehicleSearch_MinCrewRange_LowerGreaterThanUpperInfoMessage",
				UpperLessThanLowerInfoMessage = "VehicleSearch_MinCrewRange_UpperLessThanLowerInfoMessage",
			},
			PassengersList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "VehicleSearch_PassengersList_Title",
				Description = "VehicleSearch_PassengersList_Description",
				AddButtonText = "VehicleSearch_PassengersList_AddButtonText",
				EntryPlaceholder = "VehicleSearch_PassengersList_EntryPlaceholder",
				ToastInvalid = "VehicleSearch_PassengersList_ToastInvalid",
				ToastAlreadySelected = "VehicleSearch_PassengersList_ToastAlreadySelected",
			},
			PassengerRange = new ISearchRangeLocalisation.Default<string>(string.Empty)
			{
				Title = "VehicleSearch_PassengerRange_Title",
				Description = "VehicleSearch_PassengerRange_Description",
				LowerTitle = "VehicleSearch_PassengerRange_LowerTitle",
				LowerDescription = "VehicleSearch_PassengerRange_LowerDescription",
				LowerPlaceholder = "VehicleSearch_PassengerRange_LowerPlaceholder",
				UpperTitle = "VehicleSearch_PassengerRange_UpperTitle",
				UpperDescription = "VehicleSearch_PassengerRange_UpperDescription",
				UpperPlaceholder = "VehicleSearch_PassengerRange_UpperPlaceholder",
				LowerErrorMessageInvalid = "VehicleSearch_PassengerRange_LowerErrorMessageInvalid",
				UpperErrorMessageInvalid = "VehicleSearch_PassengerRange_UpperErrorMessageInvalid",
				LowerGreaterThanUpperInfoMessage = "VehicleSearch_PassengerRange_LowerGreaterThanUpperInfoMessage",
				UpperLessThanLowerInfoMessage = "VehicleSearch_PassengerRange_UpperLessThanLowerInfoMessage",
			},
			PilotsSearchContainables = new ISearchItemLocalisation.Default<string>(string.Empty)
			{
				Title = "VehicleSearch_PilotsSearchContainables_Title",
				Description = "VehicleSearch_PilotsSearchContainables_Description",
			},
		};
	}

	public static class VehicleSearchExtensions
	{
		public static IVehicleSearchLocalisation? GetVehicleSearch(this LocalisationResourceManager? localisationResourceManager, IVehicleSearchLocalisationTyped<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IVehicleSearchLocalisation.Default
				{
					Title = retriever?.Title ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.Title) : null,

					CargoCapacitiesList = new ISearchListLocalisation.Default
					{
						Title = retriever?.CargoCapacitiesList?.Title ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.CargoCapacitiesList.Title) : null,
						Description = retriever?.CargoCapacitiesList?.Description ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.CargoCapacitiesList.Description) : null,
						AddButtonText = retriever?.CargoCapacitiesList?.AddButtonText ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.CargoCapacitiesList.AddButtonText) : null,
						EntryPlaceholder = retriever?.CargoCapacitiesList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.CargoCapacitiesList.EntryPlaceholder) : null,
						ToastInvalid = retriever?.CargoCapacitiesList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.CargoCapacitiesList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.CargoCapacitiesList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.CargoCapacitiesList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
					CargoCapacityRange = new ISearchRangeLocalisation.Default
					{
						Title = retriever?.CargoCapacityRange?.Title ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.CargoCapacityRange.Title) : null,
						Description = retriever?.CargoCapacityRange?.Description ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.CargoCapacityRange.Description) : null,
						LowerTitle = retriever?.CargoCapacityRange?.LowerTitle ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.CargoCapacityRange.LowerTitle) : null,
						LowerDescription = retriever?.CargoCapacityRange?.LowerDescription ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.CargoCapacityRange.LowerDescription) : null,
						LowerPlaceholder = retriever?.CargoCapacityRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.CargoCapacityRange.LowerPlaceholder) : null,
						UpperTitle = retriever?.CargoCapacityRange?.UpperTitle ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.CargoCapacityRange.UpperTitle) : null,
						UpperDescription = retriever?.CargoCapacityRange?.UpperDescription ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.CargoCapacityRange.UpperDescription) : null,
						UpperPlaceholder = retriever?.CargoCapacityRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.CargoCapacityRange.UpperPlaceholder) : null,
						LowerErrorMessageInvalid = retriever?.CargoCapacityRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.CargoCapacityRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
						UpperErrorMessageInvalid = retriever?.CargoCapacityRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.CargoCapacityRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
						LowerGreaterThanUpperInfoMessage = retriever?.CargoCapacityRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.CargoCapacityRange.LowerGreaterThanUpperInfoMessage) : null,
						UpperLessThanLowerInfoMessage = retriever?.CargoCapacityRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.CargoCapacityRange.UpperLessThanLowerInfoMessage) : null,
					},
					ConsumablesList = new ISearchListLocalisation.Default
					{
						Title = retriever?.ConsumablesList?.Title ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.ConsumablesList.Title) : null,
						Description = retriever?.ConsumablesList?.Description ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.ConsumablesList.Description) : null,
						AddButtonText = retriever?.ConsumablesList?.AddButtonText ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.ConsumablesList.AddButtonText) : null,
						EntryPlaceholder = retriever?.ConsumablesList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.ConsumablesList.EntryPlaceholder) : null,
						ToastInvalid = retriever?.ConsumablesList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.ConsumablesList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.ConsumablesList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.ConsumablesList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
					ConsumableRange = new ISearchRangeLocalisation.Default
					{
						Title = retriever?.ConsumableRange?.Title ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.ConsumableRange.Title) : null,
						Description = retriever?.ConsumableRange?.Description ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.ConsumableRange.Description) : null,
						LowerTitle = retriever?.ConsumableRange?.LowerTitle ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.ConsumableRange.LowerTitle) : null,
						LowerDescription = retriever?.ConsumableRange?.LowerDescription ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.ConsumableRange.LowerDescription) : null,
						LowerPlaceholder = retriever?.ConsumableRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.ConsumableRange.LowerPlaceholder) : null,
						UpperTitle = retriever?.ConsumableRange?.UpperTitle ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.ConsumableRange.UpperTitle) : null,
						UpperDescription = retriever?.ConsumableRange?.UpperDescription ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.ConsumableRange.UpperDescription) : null,
						UpperPlaceholder = retriever?.ConsumableRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.ConsumableRange.UpperPlaceholder) : null,
						LowerErrorMessageInvalid = retriever?.ConsumableRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.ConsumableRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
						UpperErrorMessageInvalid = retriever?.ConsumableRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.ConsumableRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
						LowerGreaterThanUpperInfoMessage = retriever?.ConsumableRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.ConsumableRange.LowerGreaterThanUpperInfoMessage) : null,
						UpperLessThanLowerInfoMessage = retriever?.ConsumableRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.ConsumableRange.UpperLessThanLowerInfoMessage) : null,
					},
					CostInCreditsList = new ISearchListLocalisation.Default
					{
						Title = retriever?.CostInCreditsList?.Title ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.CostInCreditsList.Title) : null,
						Description = retriever?.CostInCreditsList?.Description ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.CostInCreditsList.Description) : null,
						AddButtonText = retriever?.CostInCreditsList?.AddButtonText ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.CostInCreditsList.AddButtonText) : null,
						EntryPlaceholder = retriever?.CostInCreditsList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.CostInCreditsList.EntryPlaceholder) : null,
						ToastInvalid = retriever?.CostInCreditsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.CostInCreditsList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.CostInCreditsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.CostInCreditsList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
					CostInCreditRange = new ISearchRangeLocalisation.Default
					{
						Title = retriever?.CostInCreditRange?.Title ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.CostInCreditRange.Title) : null,
						Description = retriever?.CostInCreditRange?.Description ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.CostInCreditRange.Description) : null,
						LowerTitle = retriever?.CostInCreditRange?.LowerTitle ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.CostInCreditRange.LowerTitle) : null,
						LowerDescription = retriever?.CostInCreditRange?.LowerDescription ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.CostInCreditRange.LowerDescription) : null,
						LowerPlaceholder = retriever?.CostInCreditRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.CostInCreditRange.LowerPlaceholder) : null,
						UpperTitle = retriever?.CostInCreditRange?.UpperTitle ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.CostInCreditRange.UpperTitle) : null,
						UpperDescription = retriever?.CostInCreditRange?.UpperDescription ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.CostInCreditRange.UpperDescription) : null,
						UpperPlaceholder = retriever?.CostInCreditRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.CostInCreditRange.UpperPlaceholder) : null,
						LowerErrorMessageInvalid = retriever?.CostInCreditRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.CostInCreditRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
						UpperErrorMessageInvalid = retriever?.CostInCreditRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.CostInCreditRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
						LowerGreaterThanUpperInfoMessage = retriever?.CostInCreditRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.CostInCreditRange.LowerGreaterThanUpperInfoMessage) : null,
						UpperLessThanLowerInfoMessage = retriever?.CostInCreditRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.CostInCreditRange.UpperLessThanLowerInfoMessage) : null,
					},
					LengthsList = new ISearchListLocalisation.Default
					{
						Title = retriever?.LengthsList?.Title ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.LengthsList.Title) : null,
						Description = retriever?.LengthsList?.Description ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.LengthsList.Description) : null,
						AddButtonText = retriever?.LengthsList?.AddButtonText ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.LengthsList.AddButtonText) : null,
						EntryPlaceholder = retriever?.LengthsList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.LengthsList.EntryPlaceholder) : null,
						ToastInvalid = retriever?.LengthsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.LengthsList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.LengthsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.LengthsList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
					LengthRange = new ISearchRangeLocalisation.Default
					{
						Title = retriever?.LengthRange?.Title ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.LengthRange.Title) : null,
						Description = retriever?.LengthRange?.Description ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.LengthRange.Description) : null,
						LowerTitle = retriever?.LengthRange?.LowerTitle ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.LengthRange.LowerTitle) : null,
						LowerDescription = retriever?.LengthRange?.LowerDescription ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.LengthRange.LowerDescription) : null,
						LowerPlaceholder = retriever?.LengthRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.LengthRange.LowerPlaceholder) : null,
						UpperTitle = retriever?.LengthRange?.UpperTitle ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.LengthRange.UpperTitle) : null,
						UpperDescription = retriever?.LengthRange?.UpperDescription ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.LengthRange.UpperDescription) : null,
						UpperPlaceholder = retriever?.LengthRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.LengthRange.UpperPlaceholder) : null,
						LowerErrorMessageInvalid = retriever?.LengthRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.LengthRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
						UpperErrorMessageInvalid = retriever?.LengthRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.LengthRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
						LowerGreaterThanUpperInfoMessage = retriever?.LengthRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.LengthRange.LowerGreaterThanUpperInfoMessage) : null,
						UpperLessThanLowerInfoMessage = retriever?.LengthRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.LengthRange.UpperLessThanLowerInfoMessage) : null,
					},
					ManufacturersSearchContainables = new ISearchItemLocalisation.Default
					{
						Title = retriever?.ManufacturersSearchContainables?.Title ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.ManufacturersSearchContainables.Title) : null,
						Description = retriever?.ManufacturersSearchContainables?.Description ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.ManufacturersSearchContainables.Description) : null,
					},
					MaxAtmospheringSpeedsList = new ISearchListLocalisation.Default
					{
						Title = retriever?.MaxAtmospheringSpeedsList?.Title ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MaxAtmospheringSpeedsList.Title) : null,
						Description = retriever?.MaxAtmospheringSpeedsList?.Description ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MaxAtmospheringSpeedsList.Description) : null,
						AddButtonText = retriever?.MaxAtmospheringSpeedsList?.AddButtonText ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MaxAtmospheringSpeedsList.AddButtonText) : null,
						EntryPlaceholder = retriever?.MaxAtmospheringSpeedsList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MaxAtmospheringSpeedsList.EntryPlaceholder) : null,
						ToastInvalid = retriever?.MaxAtmospheringSpeedsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.MaxAtmospheringSpeedsList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.MaxAtmospheringSpeedsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.MaxAtmospheringSpeedsList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
					MaxAtmospheringSpeedRange = new ISearchRangeLocalisation.Default
					{
						Title = retriever?.MaxAtmospheringSpeedRange?.Title ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MaxAtmospheringSpeedRange.Title) : null,
						Description = retriever?.MaxAtmospheringSpeedRange?.Description ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MaxAtmospheringSpeedRange.Description) : null,
						LowerTitle = retriever?.MaxAtmospheringSpeedRange?.LowerTitle ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MaxAtmospheringSpeedRange.LowerTitle) : null,
						LowerDescription = retriever?.MaxAtmospheringSpeedRange?.LowerDescription ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MaxAtmospheringSpeedRange.LowerDescription) : null,
						LowerPlaceholder = retriever?.MaxAtmospheringSpeedRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MaxAtmospheringSpeedRange.LowerPlaceholder) : null,
						UpperTitle = retriever?.MaxAtmospheringSpeedRange?.UpperTitle ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MaxAtmospheringSpeedRange.UpperTitle) : null,
						UpperDescription = retriever?.MaxAtmospheringSpeedRange?.UpperDescription ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MaxAtmospheringSpeedRange.UpperDescription) : null,
						UpperPlaceholder = retriever?.MaxAtmospheringSpeedRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MaxAtmospheringSpeedRange.UpperPlaceholder) : null,
						LowerErrorMessageInvalid = retriever?.MaxAtmospheringSpeedRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.MaxAtmospheringSpeedRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
						UpperErrorMessageInvalid = retriever?.MaxAtmospheringSpeedRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.MaxAtmospheringSpeedRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
						LowerGreaterThanUpperInfoMessage = retriever?.MaxAtmospheringSpeedRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MaxAtmospheringSpeedRange.LowerGreaterThanUpperInfoMessage) : null,
						UpperLessThanLowerInfoMessage = retriever?.MaxAtmospheringSpeedRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MaxAtmospheringSpeedRange.UpperLessThanLowerInfoMessage) : null,
					},
					MaxCrewsList = new ISearchListLocalisation.Default
					{
						Title = retriever?.MaxCrewsList?.Title ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MaxCrewsList.Title) : null,
						Description = retriever?.MaxCrewsList?.Description ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MaxCrewsList.Description) : null,
						AddButtonText = retriever?.MaxCrewsList?.AddButtonText ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MaxCrewsList.AddButtonText) : null,
						EntryPlaceholder = retriever?.MaxCrewsList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MaxCrewsList.EntryPlaceholder) : null,
						ToastInvalid = retriever?.MaxCrewsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.MaxCrewsList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.MaxCrewsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.MaxCrewsList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
					MaxCrewRange = new ISearchRangeLocalisation.Default
					{
						Title = retriever?.MaxCrewRange?.Title ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MaxCrewRange.Title) : null,
						Description = retriever?.MaxCrewRange?.Description ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MaxCrewRange.Description) : null,
						LowerTitle = retriever?.MaxCrewRange?.LowerTitle ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MaxCrewRange.LowerTitle) : null,
						LowerDescription = retriever?.MaxCrewRange?.LowerDescription ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MaxCrewRange.LowerDescription) : null,
						LowerPlaceholder = retriever?.MaxCrewRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MaxCrewRange.LowerPlaceholder) : null,
						UpperTitle = retriever?.MaxCrewRange?.UpperTitle ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MaxCrewRange.UpperTitle) : null,
						UpperDescription = retriever?.MaxCrewRange?.UpperDescription ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MaxCrewRange.UpperDescription) : null,
						UpperPlaceholder = retriever?.MaxCrewRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MaxCrewRange.UpperPlaceholder) : null,
						LowerErrorMessageInvalid = retriever?.MaxCrewRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.MaxCrewRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
						UpperErrorMessageInvalid = retriever?.MaxCrewRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.MaxCrewRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
						LowerGreaterThanUpperInfoMessage = retriever?.MaxCrewRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MaxCrewRange.LowerGreaterThanUpperInfoMessage) : null,
						UpperLessThanLowerInfoMessage = retriever?.MaxCrewRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MaxCrewRange.UpperLessThanLowerInfoMessage) : null,
					},
					MinCrewsList = new ISearchListLocalisation.Default
					{
						Title = retriever?.MinCrewsList?.Title ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MinCrewsList.Title) : null,
						Description = retriever?.MinCrewsList?.Description ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MinCrewsList.Description) : null,
						AddButtonText = retriever?.MinCrewsList?.AddButtonText ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MinCrewsList.AddButtonText) : null,
						EntryPlaceholder = retriever?.MinCrewsList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MinCrewsList.EntryPlaceholder) : null,
						ToastInvalid = retriever?.MinCrewsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.MinCrewsList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.MinCrewsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.MinCrewsList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
					MinCrewRange = new ISearchRangeLocalisation.Default
					{
						Title = retriever?.MinCrewRange?.Title ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MinCrewRange.Title) : null,
						Description = retriever?.MinCrewRange?.Description ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MinCrewRange.Description) : null,
						LowerTitle = retriever?.MinCrewRange?.LowerTitle ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MinCrewRange.LowerTitle) : null,
						LowerDescription = retriever?.MinCrewRange?.LowerDescription ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MinCrewRange.LowerDescription) : null,
						LowerPlaceholder = retriever?.MinCrewRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MinCrewRange.LowerPlaceholder) : null,
						UpperTitle = retriever?.MinCrewRange?.UpperTitle ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MinCrewRange.UpperTitle) : null,
						UpperDescription = retriever?.MinCrewRange?.UpperDescription ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MinCrewRange.UpperDescription) : null,
						UpperPlaceholder = retriever?.MinCrewRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MinCrewRange.UpperPlaceholder) : null,
						LowerErrorMessageInvalid = retriever?.MinCrewRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.MinCrewRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
						UpperErrorMessageInvalid = retriever?.MinCrewRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.MinCrewRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
						LowerGreaterThanUpperInfoMessage = retriever?.MinCrewRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MinCrewRange.LowerGreaterThanUpperInfoMessage) : null,
						UpperLessThanLowerInfoMessage = retriever?.MinCrewRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.MinCrewRange.UpperLessThanLowerInfoMessage) : null,
					},
					PassengersList = new ISearchListLocalisation.Default
					{
						Title = retriever?.PassengersList?.Title ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.PassengersList.Title) : null,
						Description = retriever?.PassengersList?.Description ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.PassengersList.Description) : null,
						AddButtonText = retriever?.PassengersList?.AddButtonText ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.PassengersList.AddButtonText) : null,
						EntryPlaceholder = retriever?.PassengersList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.PassengersList.EntryPlaceholder) : null,
						ToastInvalid = retriever?.PassengersList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.PassengersList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.PassengersList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.PassengersList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
					PassengerRange = new ISearchRangeLocalisation.Default
					{
						Title = retriever?.PassengerRange?.Title ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.PassengerRange.Title) : null,
						Description = retriever?.PassengerRange?.Description ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.PassengerRange.Description) : null,
						LowerTitle = retriever?.PassengerRange?.LowerTitle ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.PassengerRange.LowerTitle) : null,
						LowerDescription = retriever?.PassengerRange?.LowerDescription ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.PassengerRange.LowerDescription) : null,
						LowerPlaceholder = retriever?.PassengerRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.PassengerRange.LowerPlaceholder) : null,
						UpperTitle = retriever?.PassengerRange?.UpperTitle ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.PassengerRange.UpperTitle) : null,
						UpperDescription = retriever?.PassengerRange?.UpperDescription ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.PassengerRange.UpperDescription) : null,
						UpperPlaceholder = retriever?.PassengerRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.PassengerRange.UpperPlaceholder) : null,
						LowerErrorMessageInvalid = retriever?.PassengerRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.PassengerRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
						UpperErrorMessageInvalid = retriever?.PassengerRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(VehicleSearch.Keys.PassengerRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
						LowerGreaterThanUpperInfoMessage = retriever?.PassengerRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.PassengerRange.LowerGreaterThanUpperInfoMessage) : null,
						UpperLessThanLowerInfoMessage = retriever?.PassengerRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.PassengerRange.UpperLessThanLowerInfoMessage) : null,
					},
					PilotsSearchContainables = new ISearchItemLocalisation.Default
					{
						Title = retriever?.PilotsSearchContainables?.Title ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.PilotsSearchContainables.Title) : null,
						Description = retriever?.PilotsSearchContainables?.Description ?? true ? localisationResourceManager.GetString(VehicleSearch.Keys.PilotsSearchContainables.Description) : null,
					},
				};
	}
}