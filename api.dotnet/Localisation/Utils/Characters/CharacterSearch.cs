using Localisation.Abstractions.Characters;
using Localisation.Abstractions.StarWarsModels;

namespace Localisation.Utils.Characters
{
	public class CharacterSearch
	{
		public const string ResourceName = "Characters.CharacterSearch";

		public static readonly ICharacterSearchLocalisationTyped<string> Keys = new ICharacterSearchLocalisation.DefaultTyped<string>(string.Empty)
		{
			Title = "CharacterSearch_Title",

			BirthYearRange = new ISearchRangeLocalisation.Default<string>(string.Empty)
			{
				LowerErrorMessageInvalid = "CharacterSearch_BirthYearRange_UpperErrorMessageInvalid",
				LowerGreaterThanUpperInfoMessage = "CharacterSearch_BirthYearRange_LowerGreaterThanUpperInfoMessage",
				LowerPlaceholder = "CharacterSearch_BirthYearRange_LowerPlaceholder",
				LowerTitle = "CharacterSearch_BirthYearRange_LowerTitle",
				LowerDescription = "CharacterSearch_BirthYearRange_LowerDescription",
				Title = "CharacterSearch_BirthYearRange_Title",
				Description = "CharacterSearch_BirthYearRange_Description",
				UpperErrorMessageInvalid = "CharacterSearch_BirthYearRange_UpperErrorMessageInvalid",
				UpperLessThanLowerInfoMessage = "CharacterSearch_BirthYearRange_UpperLessThanLowerInfoMessage",
				UpperPlaceholder = "CharacterSearch_BirthYearRange_UpperPlaceholder",
				UpperTitle = "CharacterSearch_BirthYearRange_UpperTitle",
				UpperDescription = "CharacterSearch_BirthYearRange_UpperDescription",
			},
			BirthYearsList = new ISearchListLocalisation.Default<string>(string.Empty) 
			{
				AddButtonText = "CharacterSearch_BirthYearsList_AddButtonText",
				EntryPlaceholder = "CharacterSearch_BirthYearsList_EntryPlaceholder",
				Title = "CharacterSearch_BirthYearsList_Title",
				Description = "CharacterSearch_BirthYearsList_Description",
				ToastAlreadySelected = "CharacterSearch_BirthYearsList_ToastAlreadySelected",
				ToastInvalid = "CharacterSearch_BirthYearsList_ToastInvalid",
			},
			EyeColorsList = new ISearchListLocalisation.Default<string>(string.Empty) 
			{
				PickerCancel = "CharacterSearch_EyeColorsList_PickerCancel",
				PickerTitle = "CharacterSearch_EyeColorsList_PickerTitle",
				AddButtonText = "CharacterSearch_EyeColorsList_AddButtonText",
				Title = "CharacterSearch_EyeColorsList_Title",
				Description = "CharacterSearch_EyeColorsList_Description",
				ToastAlreadySelected = "CharacterSearch_EyeColorsList_ToastAlreadySelected",
				ToastInvalid = "CharacterSearch_EyeColorsList_ToastInvalid",
			},
			HairColorsList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				PickerCancel = "CharacterSearch_HairColorsList_PickerCancel",
				PickerTitle = "CharacterSearch_HairColorsList_PickerTitle",
				AddButtonText = "CharacterSearch_HairColorsList_AddButtonText",
				Title = "CharacterSearch_HairColorsList_Title",
				Description = "CharacterSearch_HairColorsList_Description",
				ToastAlreadySelected = "CharacterSearch_HairColorsList_ToastAlreadySelected",
				ToastInvalid = "CharacterSearch_HairColorsList_ToastInvalid",
			},
			HeightRange = new ISearchRangeLocalisation.Default<string>(string.Empty)
			{
				LowerErrorMessageInvalid = "CharacterSearch_HeightRange_LowerErrorMessageInvalid",
				LowerGreaterThanUpperInfoMessage = "CharacterSearch_HeightRange_LowerGreaterThanUpperInfoMessage",
				LowerPlaceholder = "CharacterSearch_HeightRange_LowerPlaceholder",
				LowerTitle = "CharacterSearch_HeightRange_LowerTitle",
				LowerDescription = "CharacterSearch_HeightRange_LowerDescription",
				Title = "CharacterSearch_HeightRange_Title",
				Description = "CharacterSearch_HeightRange_Description",
				UpperErrorMessageInvalid = "CharacterSearch_HeightRange_UpperErrorMessageInvalid",
				UpperLessThanLowerInfoMessage = "CharacterSearch_HeightRange_UpperLessThanLowerInfoMessage",
				UpperPlaceholder = "CharacterSearch_HeightRange_UpperPlaceholder",
				UpperTitle = "CharacterSearch_HeightRange_UpperTitle",
				UpperDescription = "CharacterSearch_HeightRange_UpperDescription",
			},
			HeightsList = new ISearchListLocalisation.Default<string>(string.Empty) 
			{
				AddButtonText = "CharacterSearch_HeightsList_AddButtonText",
				EntryPlaceholder = "CharacterSearch_HeightsList_EntryPlaceholder",
				Title = "CharacterSearch_HeightsList_Title",
				Description = "CharacterSearch_HeightsList_Description",
				ToastAlreadySelected = "CharacterSearch_HeightsList_ToastAlreadySelected",
				ToastInvalid = "CharacterSearch_HeightsList_ToastInvalid",
			},		 
			HomeworldSearchContainables = new ISearchItemLocalisation.Default<string>(string.Empty) 
			{
				Title = "CharacterSearch_HomeworldSearchContainables_Title",
				Description = "CharacterSearch_HomeworldSearchContainables_Description",
			},
			MassRange = new ISearchRangeLocalisation.Default<string>(string.Empty) 
			{
				LowerErrorMessageInvalid = "CharacterSearch_MassRange_LowerErrorMessageInvalid",
				LowerGreaterThanUpperInfoMessage = "CharacterSearch_MassRange_LowerGreaterThanUpperInfoMessage",
				LowerPlaceholder = "CharacterSearch_MassRange_LowerPlaceholder",
				LowerTitle = "CharacterSearch_MassRange_LowerTitle",
				LowerDescription = "CharacterSearch_MassRange_LowerDescription",
				Title = "CharacterSearch_MassRange_Title",
				Description = "CharacterSearch_MassRange_Description",
				UpperErrorMessageInvalid = "CharacterSearch_MassRange_UpperErrorMessageInvalid",
				UpperLessThanLowerInfoMessage = "CharacterSearch_MassRange_UpperLessThanLowerInfoMessage",
				UpperPlaceholder = "CharacterSearch_MassRange_UpperPlaceholder",
				UpperTitle = "CharacterSearch_MassRange_UpperTitle",
				UpperDescription = "CharacterSearch_MassRange_UpperDescription",
			},
			MassesList = new ISearchListLocalisation.Default<string>(string.Empty) 
			{
				AddButtonText = "CharacterSearch_MassesList_AddButtonText",
				EntryPlaceholder = "CharacterSearch_MassesList_EntryPlaceholder",
				Title = "CharacterSearch_MassesList_Title",
				Description = "CharacterSearch_MassesList_Description",
				ToastAlreadySelected = "CharacterSearch_MassesList_ToastAlreadySelected",
				ToastInvalid = "CharacterSearch_MassesList_ToastInvalid",
			},
			SexesList = new ISearchListLocalisation.Default<string>(string.Empty) 
			{
				PickerCancel = "CharacterSearch_SexesList_PickerCancel",
				PickerTitle = "CharacterSearch_SexesList_PickerTitle",
				AddButtonText = "CharacterSearch_SexesList_AddButtonText",
				Title = "CharacterSearch_SexesList_Title",
				Description = "CharacterSearch_SexesList_Description",
				ToastAlreadySelected = "CharacterSearch_SexesList_ToastAlreadySelected",
				ToastInvalid = "CharacterSearch_SexesList_ToastInvalid",
			},
			SkinColorsList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				PickerCancel = "CharacterSearch_SkinColorsList_PickerCancel",
				PickerTitle = "CharacterSearch_SkinColorsList_PickerTitle",
				AddButtonText = "CharacterSearch_SkinColorsList_AddButtonText",
				Title = "CharacterSearch_SkinColorsList_Title",
				Description = "CharacterSearch_SkinColorsList_Description",
				ToastAlreadySelected = "CharacterSearch_SkinColorsList_ToastAlreadySelected",
				ToastInvalid = "CharacterSearch_SkinColorsList_ToastInvalid",
			},
		};
	}

	public static class CharacterSearchExtensions
	{
		public static ICharacterSearchLocalisation? GetCharacterSearch(this LocalisationResourceManager? localisationResourceManager, ICharacterSearchLocalisationTyped<bool>? retriever = null)
			=> localisationResourceManager is null
				? null
				: new ICharacterSearchLocalisation.Default 
				{
					BirthYearRange = retriever is not null && retriever.BirthYearRange is null 
						? null
						: new ISearchRangeLocalisation.Default
						{
							Description = retriever?.BirthYearRange?.Description ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.BirthYearRange.Description) : null,
							LowerErrorMessageInvalid = retriever?.BirthYearRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(CharacterSearch.Keys.BirthYearRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
							LowerGreaterThanUpperInfoMessage = retriever?.BirthYearRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.BirthYearRange.LowerGreaterThanUpperInfoMessage) : null,
							LowerPlaceholder = retriever?.BirthYearRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.BirthYearRange.LowerPlaceholder) : null,
							LowerTitle = retriever?.BirthYearRange?.LowerTitle ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.BirthYearRange.LowerTitle) : null,
							LowerDescription = retriever?.BirthYearRange?.LowerDescription ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.BirthYearRange.LowerDescription) : null,
							Title = retriever?.BirthYearRange?.Title ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.BirthYearRange.Title) : null,
							UpperErrorMessageInvalid = retriever?.BirthYearRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(CharacterSearch.Keys.BirthYearRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
							UpperLessThanLowerInfoMessage = retriever?.BirthYearRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.BirthYearRange.UpperLessThanLowerInfoMessage) : null,
							UpperPlaceholder = retriever?.BirthYearRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.BirthYearRange.UpperPlaceholder) : null,
							UpperTitle = retriever?.BirthYearRange?.UpperTitle ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.BirthYearRange.UpperTitle) : null,
							UpperDescription = retriever?.BirthYearRange?.UpperDescription ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.BirthYearRange.UpperDescription) : null,
						},

					BirthYearsList = retriever is not null && retriever.BirthYearsList is null
						? null
						: new ISearchListLocalisation.Default
						{
							AddButtonText = retriever?.BirthYearsList?.AddButtonText ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.BirthYearsList.AddButtonText) : null,
							EntryPlaceholder = retriever?.BirthYearsList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.BirthYearsList.EntryPlaceholder) : null,
							Title = retriever?.BirthYearsList?.Title ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.BirthYearsList.Title) : null,
							Description = retriever?.BirthYearsList?.Description ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.BirthYearsList.Description) : null,
							ToastAlreadySelected = retriever?.BirthYearsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(CharacterSearch.Keys.BirthYearsList.ToastAlreadySelected) ?? "{0}", value) : null,
							ToastInvalid = retriever?.BirthYearsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(CharacterSearch.Keys.BirthYearsList.ToastInvalid) ?? "{0}", value) : null,
						},

					EyeColorsList = retriever is not null && retriever.EyeColorsList is null
						? null
						: new ISearchListLocalisation.Default
						{
							PickerCancel = retriever?.EyeColorsList?.PickerCancel ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.EyeColorsList.PickerCancel) : null,
							PickerTitle = retriever?.EyeColorsList?.PickerTitle ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.EyeColorsList.PickerTitle) : null,
							AddButtonText = retriever?.EyeColorsList?.AddButtonText ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.EyeColorsList.AddButtonText) : null,
							Title = retriever?.EyeColorsList?.Title ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.EyeColorsList.Title) : null,
							Description = retriever?.EyeColorsList?.Description ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.EyeColorsList.Description) : null,
							ToastAlreadySelected = retriever?.EyeColorsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(CharacterSearch.Keys.EyeColorsList.ToastAlreadySelected) ?? "{0}", value) : null,
							ToastInvalid = retriever?.EyeColorsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(CharacterSearch.Keys.EyeColorsList.ToastInvalid) ?? "{0}", value) : null,
						},	

					HairColorsList = retriever is not null && retriever.HairColorsList is null
						? null
						: new ISearchListLocalisation.Default
						{
							PickerCancel = retriever?.HairColorsList?.PickerCancel ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.HairColorsList.PickerCancel) : null,
							PickerTitle = retriever?.HairColorsList?.PickerTitle ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.HairColorsList.PickerTitle) : null,
							AddButtonText = retriever?.HairColorsList?.AddButtonText ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.HairColorsList.AddButtonText) : null,
							Title = retriever?.HairColorsList?.Title ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.HairColorsList.Title) : null,
							Description = retriever?.HairColorsList?.Description ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.HairColorsList.Description) : null,
							ToastAlreadySelected = retriever?.HairColorsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(CharacterSearch.Keys.HairColorsList.ToastAlreadySelected) ?? "{0}", value) : null,
							ToastInvalid = retriever?.HairColorsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(CharacterSearch.Keys.HairColorsList.ToastInvalid) ?? "{0}", value) : null,
						},

					HeightRange = retriever is not null && retriever.HeightRange is null
						? null
						: new ISearchRangeLocalisation.Default
						{
							LowerErrorMessageInvalid = retriever?.HeightRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(CharacterSearch.Keys.HeightRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
							LowerGreaterThanUpperInfoMessage = retriever?.HeightRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.HeightRange.LowerGreaterThanUpperInfoMessage) : null,
							LowerPlaceholder = retriever?.HeightRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.HeightRange.LowerPlaceholder) : null,
							LowerTitle = retriever?.HeightRange?.LowerTitle ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.HeightRange.LowerTitle) : null,
							LowerDescription = retriever?.HeightRange?.LowerDescription ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.HeightRange.LowerDescription) : null,
							Title = retriever?.HeightRange?.Title ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.HeightRange.Title) : null,
							Description = retriever?.HeightRange?.Description ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.HeightRange.Description) : null,
							UpperErrorMessageInvalid = retriever?.HeightRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(CharacterSearch.Keys.HeightRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
							UpperLessThanLowerInfoMessage = retriever?.HeightRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.HeightRange.UpperLessThanLowerInfoMessage) : null,
							UpperPlaceholder = retriever?.HeightRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.HeightRange.UpperPlaceholder) : null,
							UpperTitle = retriever?.HeightRange?.UpperTitle ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.HeightRange.UpperTitle) : null,
							UpperDescription = retriever?.HeightRange?.UpperDescription ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.HeightRange.UpperDescription) : null,
						},

					HeightsList = retriever is not null && retriever.HeightsList is null
						? null
						: new ISearchListLocalisation.Default
						{
							PickerCancel = retriever?.HeightsList?.PickerCancel ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.HeightsList.PickerCancel) : null,
							PickerTitle = retriever?.HeightsList?.PickerTitle ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.HeightsList.PickerTitle) : null,
							AddButtonText = retriever?.HeightsList?.AddButtonText ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.HeightsList.AddButtonText) : null,
							Title = retriever?.HeightsList?.Title ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.HeightsList.Title) : null,
							Description = retriever?.HeightsList?.Description ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.HeightsList.Description) : null,
							ToastAlreadySelected = retriever?.HeightsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(CharacterSearch.Keys.HeightsList.ToastAlreadySelected) ?? "{0}", value) : null,
							ToastInvalid = retriever?.HeightsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(CharacterSearch.Keys.HeightsList.ToastInvalid) ?? "{0}", value) : null,
						},

					HomeworldSearchContainables = retriever is not null && retriever.HomeworldSearchContainables is null
						? null
						: new ISearchItemLocalisation.Default
						{
							Title = retriever?.HomeworldSearchContainables?.Title ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.HomeworldSearchContainables.Title) : null,
							Description = retriever?.HomeworldSearchContainables?.Description ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.HomeworldSearchContainables.Description) : null,
						},

					MassesList = retriever is not null && retriever.MassesList is null
						? null
						: new ISearchListLocalisation.Default
						{
							PickerCancel = retriever?.MassesList?.PickerCancel ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.MassesList.PickerCancel) : null,
							PickerTitle = retriever?.MassesList?.PickerTitle ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.MassesList.PickerTitle) : null,
							AddButtonText = retriever?.MassesList?.AddButtonText ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.MassesList.AddButtonText) : null,
							Title = retriever?.MassesList?.Title ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.MassesList.Title) : null,
							Description = retriever?.MassesList?.Description ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.MassesList.Description) : null,
							ToastAlreadySelected = retriever?.MassesList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(CharacterSearch.Keys.MassesList.ToastAlreadySelected) ?? "{0}", value) : null,
							ToastInvalid = retriever?.MassesList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(CharacterSearch.Keys.MassesList.ToastInvalid) ?? "{0}", value) : null,
						},

					MassRange = retriever is not null && retriever.MassRange is null
						? null
						: new ISearchRangeLocalisation.Default
						{
							LowerErrorMessageInvalid = retriever?.MassRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(CharacterSearch.Keys.MassRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
							LowerGreaterThanUpperInfoMessage = retriever?.MassRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.MassRange.LowerGreaterThanUpperInfoMessage) : null,
							LowerPlaceholder = retriever?.MassRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.MassRange.LowerPlaceholder) : null,
							LowerTitle = retriever?.MassRange?.LowerTitle ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.MassRange.LowerTitle) : null,
							LowerDescription = retriever?.MassRange?.LowerDescription ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.MassRange.LowerDescription) : null,
							Title = retriever?.MassRange?.Title ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.MassRange.Title) : null,
							Description = retriever?.MassRange?.Description ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.MassRange.Description) : null,
							UpperErrorMessageInvalid = retriever?.MassRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(CharacterSearch.Keys.MassRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
							UpperLessThanLowerInfoMessage = retriever?.MassRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.MassRange.UpperLessThanLowerInfoMessage) : null,
							UpperPlaceholder = retriever?.MassRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.MassRange.UpperPlaceholder) : null,
							UpperTitle = retriever?.MassRange?.UpperTitle ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.MassRange.UpperTitle) : null,
							UpperDescription = retriever?.MassRange?.UpperDescription ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.MassRange.UpperDescription) : null,
						},

					SexesList = retriever is not null && retriever.SexesList is null
						? null
						: new ISearchListLocalisation.Default
						{
							PickerCancel = retriever?.SexesList?.PickerCancel ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.SexesList.PickerCancel) : null,
							PickerTitle = retriever?.SexesList?.PickerTitle ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.SexesList.PickerTitle) : null,
							AddButtonText = retriever?.SexesList?.AddButtonText ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.SexesList.AddButtonText) : null,
							Title = retriever?.SexesList?.Title ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.SexesList.Title) : null,
							Description = retriever?.SexesList?.Description ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.SexesList.Description) : null,
							ToastAlreadySelected = retriever?.SexesList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(CharacterSearch.Keys.SexesList.ToastAlreadySelected) ?? "{0}", value) : null,
							ToastInvalid = retriever?.SexesList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(CharacterSearch.Keys.SexesList.ToastInvalid) ?? "{0}", value) : null,
						},

					SkinColorsList = retriever is not null && retriever.SkinColorsList is null
						? null
						: new ISearchListLocalisation.Default
						{
							PickerCancel = retriever?.SkinColorsList?.PickerCancel ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.SkinColorsList.PickerCancel) : null,
							PickerTitle = retriever?.SkinColorsList?.PickerTitle ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.SkinColorsList.PickerTitle) : null,
							AddButtonText = retriever?.SkinColorsList?.AddButtonText ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.SkinColorsList.AddButtonText) : null,
							Title = retriever?.SkinColorsList?.Title ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.SkinColorsList.Title) : null,
							Description = retriever?.SkinColorsList?.Description ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.SkinColorsList.Description) : null,
							ToastAlreadySelected = retriever?.SkinColorsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(CharacterSearch.Keys.SkinColorsList.ToastAlreadySelected) ?? "{0}", value) : null,
							ToastInvalid = retriever?.SkinColorsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(CharacterSearch.Keys.SkinColorsList.ToastInvalid) ?? "{0}", value) : null,
						},

					Title = retriever?.Title ?? true ? localisationResourceManager.GetString(CharacterSearch.Keys.Title) : null,
				};
	}
}