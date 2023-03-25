using System;
using System.Drawing;

using Localisation.Abstractions.Species;
using Localisation.Abstractions.StarWarsModels;

namespace Localisation.Utils.Species
{
	public class SpecieSearch
	{
		public const string ResourceName = "Species.SpecieSearch";

		public static readonly ISpecieSearchLocalisationTyped<string> Keys = new ISpecieSearchLocalisation.DefaultTyped<string>(string.Empty)
		{
			Title = "SpecieSearch_Title",
			
			AverageHeightsList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "SpecieSearch_AverageHeightsList_Title",
				Description = "SpecieSearch_AverageHeightsList_Description",
				AddButtonText = "SpecieSearch_AverageHeightsList_AddButtonText",
				EntryPlaceholder = "SpecieSearch_AverageHeightsList_EntryPlaceholder",
				ToastInvalid = "SpecieSearch_AverageHeightsList_ToastInvalid",
				ToastAlreadySelected = "SpecieSearch_AverageHeightsList_ToastAlreadySelected",
			},
			AverageHeightRange = new ISearchRangeLocalisation.Default<string>(string.Empty)
			{
				Title = "SpecieSearch_AverageHeightRange_Title",
				Description = "SpecieSearch_AverageHeightRange_Description",
				LowerTitle = "SpecieSearch_AverageHeightRange_LowerTitle",
				LowerDescription = "SpecieSearch_AverageHeightRange_LowerDescription",
				LowerPlaceholder = "SpecieSearch_AverageHeightRange_LowerPlaceholder",
				UpperTitle = "SpecieSearch_AverageHeightRange_UpperTitle",
				UpperDescription = "SpecieSearch_AverageHeightRange_UpperDescription",
				UpperPlaceholder = "SpecieSearch_AverageHeightRange_UpperPlaceholder",
				LowerErrorMessageInvalid = "SpecieSearch_AverageHeightRange_LowerErrorMessageInvalid",
				UpperErrorMessageInvalid = "SpecieSearch_AverageHeightRange_UpperErrorMessageInvalid",
				LowerGreaterThanUpperInfoMessage = "SpecieSearch_AverageHeightRange_LowerGreaterThanUpperInfoMessage",
				UpperLessThanLowerInfoMessage = "SpecieSearch_AverageHeightRange_UpperLessThanLowerInfoMessage",
			},
			AverageLifespansList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "SpecieSearch_AverageLifespansList_Title",
				Description = "SpecieSearch_AverageLifespansList_Description",
				AddButtonText = "SpecieSearch_AverageLifespansList_AddButtonText",
				EntryPlaceholder = "SpecieSearch_AverageLifespansList_EntryPlaceholder",
				ToastInvalid = "SpecieSearch_AverageLifespansList_ToastInvalid",
				ToastAlreadySelected = "SpecieSearch_AverageLifespansList_ToastAlreadySelected",
			},
			AverageLifespanRange = new ISearchRangeLocalisation.Default<string>(string.Empty)
			{
				Title = "SpecieSearch_AverageLifespanRange_Title",
				Description = "SpecieSearch_AverageLifespanRange_Description",
				LowerTitle = "SpecieSearch_AverageLifespanRange_LowerTitle",
				LowerDescription = "SpecieSearch_AverageLifespanRange_LowerDescription",
				LowerPlaceholder = "SpecieSearch_AverageLifespanRange_LowerPlaceholder",
				UpperTitle = "SpecieSearch_AverageLifespanRange_UpperTitle",
				UpperDescription = "SpecieSearch_AverageLifespanRange_UpperDescription",
				UpperPlaceholder = "SpecieSearch_AverageLifespanRange_UpperPlaceholder",
				LowerErrorMessageInvalid = "SpecieSearch_AverageLifespanRange_LowerErrorMessageInvalid",
				UpperErrorMessageInvalid = "SpecieSearch_AverageLifespanRange_UpperErrorMessageInvalid",
				LowerGreaterThanUpperInfoMessage = "SpecieSearch_AverageLifespanRange_LowerGreaterThanUpperInfoMessage",
				UpperLessThanLowerInfoMessage = "SpecieSearch_AverageLifespanRange_UpperLessThanLowerInfoMessage",
			},
			ClassificationsList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "SpecieSearch_ClassificationsList_Title",
				Description = "SpecieSearch_ClassificationsList_Description",
				AddButtonText = "SpecieSearch_ClassificationsList_AddButtonText",
				PickerTitle = "SpecieSearch_ClassificationsList_PickerTitle",
				PickerCancel = "SpecieSearch_ClassificationsList_PickerCancel",
				ToastInvalid = "SpecieSearch_ClassificationsList_ToastInvalid",
				ToastAlreadySelected = "SpecieSearch_ClassificationsList_ToastAlreadySelected",
			},
			CharactersSearchContainables = new ISearchItemLocalisation.Default<string>(string.Empty)
			{
				Title = "SpecieSearch_CharactersSearchContainables_Title",
				Description = "SpecieSearch_CharactersSearchContainables_Description",
			},
			DesignationsList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "SpecieSearch_DesignationsList_Title",
				Description = "SpecieSearch_DesignationsList_Description",
				AddButtonText = "SpecieSearch_DesignationsList_AddButtonText",
				PickerTitle = "SpecieSearch_DesignationsList_PickerTitle",
				PickerCancel = "SpecieSearch_DesignationsList_PickerCancel",
				ToastInvalid = "SpecieSearch_DesignationsList_ToastInvalid",
				ToastAlreadySelected = "SpecieSearch_DesignationsList_ToastAlreadySelected",
			},
			EyeColorsList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "SpecieSearch_EyeColorsList_Title",
				Description = "SpecieSearch_EyeColorsList_Description",
				AddButtonText = "SpecieSearch_EyeColorsList_AddButtonText",
				PickerTitle = "SpecieSearch_EyeColorsList_PickerTitle",
				PickerCancel = "SpecieSearch_EyeColorsList_PickerCancel",
				ToastInvalid = "SpecieSearch_EyeColorsList_ToastInvalid",
				ToastAlreadySelected = "SpecieSearch_EyeColorsList_ToastAlreadySelected",
			},
			HairColorsList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "SpecieSearch_HairColorsList_Title",
				Description = "SpecieSearch_HairColorsList_Description",
				AddButtonText = "SpecieSearch_HairColorsList_AddButtonText",
				PickerTitle = "SpecieSearch_HairColorsList_PickerTitle",
				PickerCancel = "SpecieSearch_HairColorsList_PickerCancel",
				ToastInvalid = "SpecieSearch_HairColorsList_ToastInvalid",
				ToastAlreadySelected = "SpecieSearch_HairColorsList_ToastAlreadySelected",
			},
			HomeworldSearchContainables = new ISearchItemLocalisation.Default<string>(string.Empty)
			{
				Title = "SpecieSearch_HomeworldSearchContainables_Title",
				Description = "SpecieSearch_HomeworldSearchContainables_Description",
			},
			LanguagesList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "SpecieSearch_LanguagesList_Title",
				Description = "SpecieSearch_LanguagesList_Description",
				AddButtonText = "SpecieSearch_LanguagesList_AddButtonText",
				PickerTitle = "SpecieSearch_LanguagesList_PickerTitle",
				PickerCancel = "SpecieSearch_LanguagesList_PickerCancel",
				ToastInvalid = "SpecieSearch_LanguagesList_ToastInvalid",
				ToastAlreadySelected = "SpecieSearch_LanguagesList_ToastAlreadySelected",
			},
			SkinColorsList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "SpecieSearch_SkinColorsList_Title",
				Description = "SpecieSearch_SkinColorsList_Description",
				AddButtonText = "SpecieSearch_SkinColorsList_AddButtonText",
				PickerTitle = "SpecieSearch_SkinColorsList_PickerTitle",
				PickerCancel = "SpecieSearch_SkinColorsList_PickerCancel",
				ToastInvalid = "SpecieSearch_SkinColorsList_ToastInvalid",
				ToastAlreadySelected = "SpecieSearch_SkinColorsList_ToastAlreadySelected",
			},
        };
	}

	public static class SpecieSearchExtensions
	{
		public static ISpecieSearchLocalisation? GetSpecieSearch(this LocalisationResourceManager? localisationResourceManager, ISpecieSearchLocalisationTyped<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new ISpecieSearchLocalisation.Default 
				{
					Title = retriever?.Title ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.Title) : null,

					AverageHeightsList = new ISearchListLocalisation.Default
					{
						Title = retriever?.AverageHeightsList?.Title ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.AverageHeightsList.Title) : null,
						Description = retriever?.AverageHeightsList?.Description ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.AverageHeightsList.Description) : null,
						AddButtonText = retriever?.AverageHeightsList?.AddButtonText ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.AverageHeightsList.AddButtonText) : null,
						EntryPlaceholder = retriever?.AverageHeightsList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.AverageHeightsList.EntryPlaceholder) : null,
						ToastInvalid = retriever?.AverageHeightsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(SpecieSearch.Keys.AverageHeightsList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.AverageHeightsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(SpecieSearch.Keys.AverageHeightsList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
					AverageHeightRange = new ISearchRangeLocalisation.Default
					{
						Title = retriever?.AverageHeightRange?.Title ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.AverageHeightRange.Title) : null,
						Description = retriever?.AverageHeightRange?.Description ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.AverageHeightRange.Description) : null,
						LowerTitle = retriever?.AverageHeightRange?.LowerTitle ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.AverageHeightRange.LowerTitle) : null,
						LowerDescription = retriever?.AverageHeightRange?.LowerDescription ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.AverageHeightRange.LowerDescription) : null,
						LowerPlaceholder = retriever?.AverageHeightRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.AverageHeightRange.LowerPlaceholder) : null,
						UpperTitle = retriever?.AverageHeightRange?.UpperTitle ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.AverageHeightRange.UpperTitle) : null,
						UpperDescription = retriever?.AverageHeightRange?.UpperDescription ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.AverageHeightRange.UpperDescription) : null,
						UpperPlaceholder = retriever?.AverageHeightRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.AverageHeightRange.UpperPlaceholder) : null,
						LowerErrorMessageInvalid = retriever?.AverageHeightRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(SpecieSearch.Keys.AverageHeightRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
						UpperErrorMessageInvalid = retriever?.AverageHeightRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(SpecieSearch.Keys.AverageHeightRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
						LowerGreaterThanUpperInfoMessage = retriever?.AverageHeightRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.AverageHeightRange.LowerGreaterThanUpperInfoMessage) : null,
						UpperLessThanLowerInfoMessage = retriever?.AverageHeightRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.AverageHeightRange.UpperLessThanLowerInfoMessage) : null,
					},
					AverageLifespansList = new ISearchListLocalisation.Default
					{
						Title = retriever?.AverageLifespansList?.Title ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.AverageLifespansList.Title) : null,
						Description = retriever?.AverageLifespansList?.Description ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.AverageLifespansList.Description) : null,
						AddButtonText = retriever?.AverageLifespansList?.AddButtonText ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.AverageLifespansList.AddButtonText) : null,
						EntryPlaceholder = retriever?.AverageLifespansList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.AverageLifespansList.EntryPlaceholder) : null,
						ToastInvalid = retriever?.AverageLifespansList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(SpecieSearch.Keys.AverageLifespansList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.AverageLifespansList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(SpecieSearch.Keys.AverageLifespansList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
					AverageLifespanRange = new ISearchRangeLocalisation.Default
					{
						Title = retriever?.AverageLifespanRange?.Title ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.AverageLifespanRange.Title) : null,
						Description = retriever?.AverageLifespanRange?.Description ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.AverageLifespanRange.Description) : null,
						LowerTitle = retriever?.AverageLifespanRange?.LowerTitle ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.AverageLifespanRange.LowerTitle) : null,
						LowerDescription = retriever?.AverageLifespanRange?.LowerDescription ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.AverageLifespanRange.LowerDescription) : null,
						LowerPlaceholder = retriever?.AverageLifespanRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.AverageLifespanRange.LowerPlaceholder) : null,
						UpperTitle = retriever?.AverageLifespanRange?.UpperTitle ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.AverageLifespanRange.UpperTitle) : null,
						UpperDescription = retriever?.AverageLifespanRange?.UpperDescription ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.AverageLifespanRange.UpperDescription) : null,
						UpperPlaceholder = retriever?.AverageLifespanRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.AverageLifespanRange.UpperPlaceholder) : null,
						LowerErrorMessageInvalid = retriever?.AverageLifespanRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(SpecieSearch.Keys.AverageLifespanRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
						UpperErrorMessageInvalid = retriever?.AverageLifespanRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(SpecieSearch.Keys.AverageLifespanRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
						LowerGreaterThanUpperInfoMessage = retriever?.AverageLifespanRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.AverageLifespanRange.LowerGreaterThanUpperInfoMessage) : null,
						UpperLessThanLowerInfoMessage = retriever?.AverageLifespanRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.AverageLifespanRange.UpperLessThanLowerInfoMessage) : null,
					},
					ClassificationsList = new ISearchListLocalisation.Default
					{
						Title = retriever?.ClassificationsList?.Title ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.ClassificationsList.Title) : null,
						Description = retriever?.ClassificationsList?.Description ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.ClassificationsList.Description) : null,
						AddButtonText = retriever?.ClassificationsList?.AddButtonText ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.ClassificationsList.AddButtonText) : null,
						PickerTitle = retriever?.ClassificationsList?.PickerTitle ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.ClassificationsList.PickerTitle) : null,
						PickerCancel = retriever?.ClassificationsList?.PickerCancel ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.ClassificationsList.PickerCancel) : null,
						ToastInvalid = retriever?.ClassificationsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(SpecieSearch.Keys.ClassificationsList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.ClassificationsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(SpecieSearch.Keys.ClassificationsList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
					CharactersSearchContainables = new ISearchItemLocalisation.Default
					{
						Title = retriever?.CharactersSearchContainables.Title ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.CharactersSearchContainables.Title) : null,
						Description = retriever?.CharactersSearchContainables.Description ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.CharactersSearchContainables.Description) : null,
					},
					DesignationsList = new ISearchListLocalisation.Default
					{
						Title = retriever?.DesignationsList?.Title ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.DesignationsList.Title) : null,
						Description = retriever?.DesignationsList?.Description ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.DesignationsList.Description) : null,
						AddButtonText = retriever?.DesignationsList?.AddButtonText ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.DesignationsList.AddButtonText) : null,
						PickerTitle = retriever?.DesignationsList?.PickerTitle ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.DesignationsList.PickerTitle) : null,
						PickerCancel = retriever?.DesignationsList?.PickerCancel ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.DesignationsList.PickerCancel) : null,
						ToastInvalid = retriever?.DesignationsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(SpecieSearch.Keys.DesignationsList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.DesignationsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(SpecieSearch.Keys.DesignationsList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
					EyeColorsList = new ISearchListLocalisation.Default
					{
						Title = retriever?.EyeColorsList?.Title ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.EyeColorsList.Title) : null,
						Description = retriever?.EyeColorsList?.Description ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.EyeColorsList.Description) : null,
						AddButtonText = retriever?.EyeColorsList?.AddButtonText ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.EyeColorsList.AddButtonText) : null,
						PickerTitle = retriever?.EyeColorsList?.PickerTitle ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.EyeColorsList.PickerTitle) : null,
						PickerCancel = retriever?.EyeColorsList?.PickerCancel ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.EyeColorsList.PickerCancel) : null,
						ToastInvalid = retriever?.EyeColorsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(SpecieSearch.Keys.EyeColorsList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.EyeColorsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(SpecieSearch.Keys.EyeColorsList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
					HairColorsList = new ISearchListLocalisation.Default
					{
						Title = retriever?.HairColorsList?.Title ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.HairColorsList.Title) : null,
						Description = retriever?.HairColorsList?.Description ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.HairColorsList.Description) : null,
						AddButtonText = retriever?.HairColorsList?.AddButtonText ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.HairColorsList.AddButtonText) : null,
						PickerTitle = retriever?.HairColorsList?.PickerTitle ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.HairColorsList.PickerTitle) : null,
						PickerCancel = retriever?.HairColorsList?.PickerCancel ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.HairColorsList.PickerCancel) : null,
						ToastInvalid = retriever?.HairColorsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(SpecieSearch.Keys.HairColorsList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.HairColorsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(SpecieSearch.Keys.HairColorsList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
					HomeworldSearchContainables = new ISearchItemLocalisation.Default
					{
						Title = retriever?.HomeworldSearchContainables.Title ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.HomeworldSearchContainables.Title) : null,
						Description = retriever?.HomeworldSearchContainables.Description ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.HomeworldSearchContainables.Description) : null,
					},
					LanguagesList = new ISearchListLocalisation.Default
					{
						Title = retriever?.LanguagesList?.Title ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.LanguagesList.Title) : null,
						Description = retriever?.LanguagesList?.Description ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.LanguagesList.Description) : null,
						AddButtonText = retriever?.LanguagesList?.AddButtonText ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.LanguagesList.AddButtonText) : null,
						PickerTitle = retriever?.LanguagesList?.PickerTitle ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.LanguagesList.PickerTitle) : null,
						PickerCancel = retriever?.LanguagesList?.PickerCancel ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.LanguagesList.PickerCancel) : null,
						ToastInvalid = retriever?.LanguagesList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(SpecieSearch.Keys.LanguagesList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.LanguagesList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(SpecieSearch.Keys.LanguagesList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
					SkinColorsList = new ISearchListLocalisation.Default
					{
						Title = retriever?.SkinColorsList?.Title ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.SkinColorsList.Title) : null,
						Description = retriever?.SkinColorsList?.Description ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.SkinColorsList.Description) : null,
						AddButtonText = retriever?.SkinColorsList?.AddButtonText ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.SkinColorsList.AddButtonText) : null,
						PickerTitle = retriever?.SkinColorsList?.PickerTitle ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.SkinColorsList.PickerTitle) : null,
						PickerCancel = retriever?.SkinColorsList?.PickerCancel ?? true ? localisationResourceManager.GetString(SpecieSearch.Keys.SkinColorsList.PickerCancel) : null,
						ToastInvalid = retriever?.SkinColorsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(SpecieSearch.Keys.SkinColorsList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.SkinColorsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(SpecieSearch.Keys.SkinColorsList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
				};
	}
} 