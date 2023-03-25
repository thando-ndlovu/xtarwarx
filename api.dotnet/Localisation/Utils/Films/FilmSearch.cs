using Localisation.Abstractions.Films;
using Localisation.Abstractions.StarWarsModels;

namespace Localisation.Utils.Films
{
	public class FilmSearch
	{
		public const string ResourceName = "Films.FilmSearch";

		public static readonly IFilmSearchLocalisationTyped<string> Keys = new IFilmSearchLocalisation.DefaultTyped<string>(string.Empty)
		{
			Title = "FilmSearch_Title",

			CharactersSearchContainables = new ISearchItemLocalisation.Default<string>(string.Empty)
			{
				Title = "FilmSearch_CharactersSearchContainables_Title",
				Description = "FilmSearch_CharactersSearchContainables_Description",
			},
			DurationRange = new ISearchRangeLocalisation.Default<string>(string.Empty)
			{
				Title = "FilmSearch_DurationRange_Title",
				Description = "FilmSearch_DurationRange_Description",
				LowerTitle = "FilmSearch_DurationRange_LowerTitle",
				LowerDescription = "FilmSearch_DurationRange_LowerDescription",
				LowerPlaceholder = "FilmSearch_DurationRange_LowerPlaceholder",
				UpperTitle = "FilmSearch_DurationRange_UpperTitle",
				UpperDescription = "FilmSearch_DurationRange_UpperDescription",
				UpperPlaceholder = "FilmSearch_DurationRange_UpperPlaceholder",
				LowerErrorMessageInvalid = "FilmSearch_DurationRange_LowerErrorMessageInvalid",
				UpperErrorMessageInvalid = "FilmSearch_DurationRange_UpperErrorMessageInvalid",
				LowerGreaterThanUpperInfoMessage = "FilmSearch_DurationRange_LowerGreaterThanUpperInfoMessage",
				UpperLessThanLowerInfoMessage = "FilmSearch_DurationRange_UpperLessThanLowerInfoMessage",
			},
			DurationsList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "FilmSearch_DurationsList_Title",
				Description = "FilmSearch_DurationsList_Description",
				AddButtonText = "FilmSearch_DurationsList_AddButtonText",
				EntryPlaceholder = "FilmSearch_DurationsList_EntryPlaceholder",
				ToastInvalid = "FilmSearch_DurationsList_ToastInvalid",
				ToastAlreadySelected = "FilmSearch_DurationsList_ToastAlreadySelected",
			},
			EpisodeIdRange = new ISearchRangeLocalisation.Default<string>(string.Empty)
			{
				Title = "FilmSearch_EpisodeIdRange_Title",
				Description = "FilmSearch_EpisodeIdRange_Description",
				LowerTitle = "FilmSearch_EpisodeIdRange_LowerTitle",
				LowerDescription = "FilmSearch_EpisodeIdRange_LowerDescription",
				LowerPlaceholder = "FilmSearch_EpisodeIdRange_LowerPlaceholder",
				UpperTitle = "FilmSearch_EpisodeIdRange_UpperTitle",
				UpperDescription = "FilmSearch_EpisodeIdRange_UpperDescription",
				UpperPlaceholder = "FilmSearch_EpisodeIdRange_UpperPlaceholder",
				LowerErrorMessageInvalid = "FilmSearch_EpisodeIdRange_LowerErrorMessageInvalid",
				UpperErrorMessageInvalid = "FilmSearch_EpisodeIdRange_UpperErrorMessageInvalid",
				LowerGreaterThanUpperInfoMessage = "FilmSearch_EpisodeIdRange_LowerGreaterThanUpperInfoMessage",
				UpperLessThanLowerInfoMessage = "FilmSearch_EpisodeIdRange_UpperLessThanLowerInfoMessage",
			},
			EpisodeIdsList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "FilmSearch_EpisodeIdsList_Title",
				Description = "FilmSearch_EpisodeIdsList_Description",
				AddButtonText = "FilmSearch_EpisodeIdsList_AddButtonText",
				EntryPlaceholder = "FilmSearch_EpisodeIdsList_EntryPlaceholder",
				ToastInvalid = "FilmSearch_EpisodeIdsList_ToastInvalid",
				ToastAlreadySelected = "FilmSearch_EpisodeIdsList_ToastAlreadySelected",
			},
			FactionsSearchContainables = new ISearchItemLocalisation.Default<string>(string.Empty)
			{
				Title = "FilmSearch_FactionsSearchContainables_Title",
				Description = "FilmSearch_FactionsSearchContainables_Description",
			},
			ManufacturersSearchContainables = new ISearchItemLocalisation.Default<string>(string.Empty)
			{
				Title = "FilmSearch_ManufacturersSearchContainables_Title",
				Description = "FilmSearch_ManufacturersSearchContainables_Description",
			},
			PlanetsSearchContainables = new ISearchItemLocalisation.Default<string>(string.Empty)
			{
				Title = "FilmSearch_PlanetsSearchContainables_Title",
				Description = "FilmSearch_PlanetsSearchContainables_Description",
			},
			ReleaseDateRange = new ISearchRangeLocalisation.Default<string>(string.Empty)
			{
				Title = "FilmSearch_ReleaseDateRange_Title",
				Description = "FilmSearch_ReleaseDateRange_Description",
				LowerTitle = "FilmSearch_ReleaseDateRange_LowerTitle",
				LowerDescription = "FilmSearch_ReleaseDateRange_LowerDescription",
				UpperTitle = "FilmSearch_ReleaseDateRange_UpperTitle",
				UpperDescription = "FilmSearch_ReleaseDateRange_UpperDescription",
				LowerGreaterThanUpperInfoMessage = "FilmSearch_ReleaseDateRange_LowerGreaterThanUpperInfoMessage",
				UpperLessThanLowerInfoMessage = "FilmSearch_ReleaseDateRange_UpperLessThanLowerInfoMessage",
			},
			ReleaseDatesList = new ISearchListLocalisation.Default<string>(string.Empty)
			{
				Title = "FilmSearch_ReleaseDatesList_Title",
				Description = "FilmSearch_ReleaseDatesList_Description",
				AddButtonText = "FilmSearch_ReleaseDatesList_AddButtonText",
				PromptTitle = "FilmSearch_ReleaseDatesList_PromptTitle",
				PromptOk = "FilmSearch_ReleaseDatesList_PromptOk",
				PromptCancel = "FilmSearch_ReleaseDatesList_PromptCancel",
				ToastInvalid = "FilmSearch_ReleaseDatesList_ToastInvalid",
				ToastAlreadySelected = "FilmSearch_ReleaseDatesList_ToastAlreadySelected",
			},
			SpeciesSearchContainables = new ISearchItemLocalisation.Default<string>(string.Empty)
			{
				Title = "FilmSearch_SpeciesSearchContainables_Title",
				Description = "FilmSearch_SpeciesSearchContainables_Description",
			},
			StarshipsSearchContainables = new ISearchItemLocalisation.Default<string>(string.Empty)
			{
				Title = "FilmSearch_StarshipsSearchContainables_Title",
				Description = "FilmSearch_StarshipsSearchContainables_Description",
			},
			VehiclesSearchContainables = new ISearchItemLocalisation.Default<string>(string.Empty)
			{
				Title = "FilmSearch_VehiclesSearchContainables_Title",
				Description = "FilmSearch_VehiclesSearchContainables_Description",
			},
			WeaponsSearchContainables = new ISearchItemLocalisation.Default<string>(string.Empty)
			{
				Title = "FilmSearch_WeaponsSearchContainables_Title",
				Description = "FilmSearch_WeaponsSearchContainables_Description",
			},
        };
	}

	public static class FilmSearchExtensions
	{
		public static IFilmSearchLocalisation? GetFilmSearch(this LocalisationResourceManager? localisationResourceManager, IFilmSearchLocalisationTyped<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IFilmSearchLocalisation.Default 
				{
					Title = retriever?.Title ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.Title) : null,

					CharactersSearchContainables = new ISearchItemLocalisation.Default
					{
						Title = retriever?.CharactersSearchContainables?.Title ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.CharactersSearchContainables.Title) : null,
						Description = retriever?.CharactersSearchContainables?.Description ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.CharactersSearchContainables.Description) : null,
					},
					DurationRange = new ISearchRangeLocalisation.Default
					{
						Title = retriever?.DurationRange?.Title ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.DurationRange.Title) : null,
						Description = retriever?.DurationRange?.Description ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.DurationRange.Description) : null,
						LowerTitle = retriever?.DurationRange?.LowerTitle ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.DurationRange.LowerTitle) : null,
						LowerDescription = retriever?.DurationRange?.LowerDescription ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.DurationRange.LowerDescription) : null,
						LowerPlaceholder = retriever?.DurationRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.DurationRange.LowerPlaceholder) : null,
						UpperTitle = retriever?.DurationRange?.UpperTitle ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.DurationRange.UpperTitle) : null,
						UpperDescription = retriever?.DurationRange?.UpperDescription ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.DurationRange.UpperDescription) : null,
						UpperPlaceholder = retriever?.DurationRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.DurationRange.UpperPlaceholder) : null,
						LowerErrorMessageInvalid = retriever?.DurationRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(FilmSearch.Keys.DurationRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
						UpperErrorMessageInvalid = retriever?.DurationRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(FilmSearch.Keys.DurationRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
						LowerGreaterThanUpperInfoMessage = retriever?.DurationRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.DurationRange.LowerGreaterThanUpperInfoMessage) : null,
						UpperLessThanLowerInfoMessage = retriever?.DurationRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.DurationRange.UpperLessThanLowerInfoMessage) : null,
					},
					DurationsList = new ISearchListLocalisation.Default
					{
						Title = retriever?.DurationsList?.Title ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.DurationsList.Title) : null,
						Description = retriever?.DurationsList?.Description ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.DurationsList.Description) : null,
						AddButtonText = retriever?.DurationsList?.AddButtonText ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.DurationsList.AddButtonText) : null,
						EntryPlaceholder = retriever?.DurationsList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.DurationsList.EntryPlaceholder) : null,
						ToastInvalid = retriever?.DurationsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(FilmSearch.Keys.DurationsList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.DurationsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(FilmSearch.Keys.DurationsList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
					EpisodeIdRange = new ISearchRangeLocalisation.Default
					{
						Title = retriever?.EpisodeIdRange?.Title ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.EpisodeIdRange.Title) : null,
						Description = retriever?.EpisodeIdRange?.Description ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.EpisodeIdRange.Description) : null,
						LowerTitle = retriever?.EpisodeIdRange?.LowerTitle ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.EpisodeIdRange.LowerTitle) : null,
						LowerDescription = retriever?.EpisodeIdRange?.LowerDescription ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.EpisodeIdRange.LowerDescription) : null,
						LowerPlaceholder = retriever?.EpisodeIdRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.EpisodeIdRange.LowerPlaceholder) : null,
						UpperTitle = retriever?.EpisodeIdRange?.UpperTitle ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.EpisodeIdRange.UpperTitle) : null,
						UpperDescription = retriever?.EpisodeIdRange?.UpperDescription ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.EpisodeIdRange.UpperDescription) : null,
						UpperPlaceholder = retriever?.EpisodeIdRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.EpisodeIdRange.UpperPlaceholder) : null,
						LowerErrorMessageInvalid = retriever?.EpisodeIdRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(FilmSearch.Keys.EpisodeIdRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
						UpperErrorMessageInvalid = retriever?.EpisodeIdRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(FilmSearch.Keys.EpisodeIdRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
						LowerGreaterThanUpperInfoMessage = retriever?.EpisodeIdRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.EpisodeIdRange.LowerGreaterThanUpperInfoMessage) : null,
						UpperLessThanLowerInfoMessage = retriever?.EpisodeIdRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.EpisodeIdRange.UpperLessThanLowerInfoMessage) : null,
					},
					EpisodeIdsList = new ISearchListLocalisation.Default
					{
						Title = retriever?.EpisodeIdsList?.Title ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.EpisodeIdsList.Title) : null,
						Description = retriever?.EpisodeIdsList?.Description ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.EpisodeIdsList.Description) : null,
						AddButtonText = retriever?.EpisodeIdsList?.AddButtonText ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.EpisodeIdsList.AddButtonText) : null,
						EntryPlaceholder = retriever?.EpisodeIdsList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.EpisodeIdsList.EntryPlaceholder) : null,
						ToastInvalid = retriever?.EpisodeIdsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(FilmSearch.Keys.EpisodeIdsList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.EpisodeIdsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(FilmSearch.Keys.EpisodeIdsList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
					FactionsSearchContainables = new ISearchItemLocalisation.Default
					{
						Title = retriever?.FactionsSearchContainables?.Title ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.FactionsSearchContainables.Title) : null,
						Description = retriever?.FactionsSearchContainables?.Description ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.FactionsSearchContainables.Description) : null,
					},
					ManufacturersSearchContainables = new ISearchItemLocalisation.Default
					{
						Title = retriever?.ManufacturersSearchContainables?.Title ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.ManufacturersSearchContainables.Title) : null,
						Description = retriever?.ManufacturersSearchContainables?.Description ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.ManufacturersSearchContainables.Description) : null,
					},
					PlanetsSearchContainables = new ISearchItemLocalisation.Default
					{
						Title = retriever?.PlanetsSearchContainables?.Title ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.PlanetsSearchContainables.Title) : null,
						Description = retriever?.PlanetsSearchContainables?.Description ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.PlanetsSearchContainables.Description) : null,
					},
					ReleaseDateRange = new ISearchRangeLocalisation.Default
					{
						Title = retriever?.ReleaseDateRange?.Title ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.ReleaseDateRange.Title) : null,
						Description = retriever?.ReleaseDateRange?.Description ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.ReleaseDateRange.Description) : null,
						LowerTitle = retriever?.ReleaseDateRange?.LowerTitle ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.ReleaseDateRange.LowerTitle) : null,
						UpperTitle = retriever?.ReleaseDateRange?.UpperTitle ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.ReleaseDateRange.UpperTitle) : null,
						LowerGreaterThanUpperInfoMessage = retriever?.ReleaseDateRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.ReleaseDateRange.LowerGreaterThanUpperInfoMessage) : null,
						UpperLessThanLowerInfoMessage = retriever?.ReleaseDateRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.ReleaseDateRange.UpperLessThanLowerInfoMessage) : null,
					},
					ReleaseDatesList = new ISearchListLocalisation.Default
					{
						Title = retriever?.ReleaseDatesList?.Title ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.ReleaseDatesList.Title) : null,
						Description = retriever?.ReleaseDatesList?.Description ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.ReleaseDatesList.Description) : null,
						AddButtonText = retriever?.ReleaseDatesList?.AddButtonText ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.ReleaseDatesList.AddButtonText) : null,
						PromptTitle = retriever?.ReleaseDatesList?.PromptTitle ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.ReleaseDatesList.PromptTitle) : null,
						PromptOk = retriever?.ReleaseDatesList?.PromptOk ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.ReleaseDatesList.PromptOk) : null,
						PromptCancel = retriever?.ReleaseDatesList?.PromptCancel ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.ReleaseDatesList.PromptCancel) : null,
						ToastInvalid = retriever?.ReleaseDatesList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(FilmSearch.Keys.ReleaseDatesList.ToastInvalid) ?? "{0}", value) : null,
						ToastAlreadySelected = retriever?.ReleaseDatesList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(FilmSearch.Keys.ReleaseDatesList.ToastAlreadySelected) ?? "{0}", value) : null,
					},
					SpeciesSearchContainables = new ISearchItemLocalisation.Default
					{
						Title = retriever?.SpeciesSearchContainables?.Title ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.SpeciesSearchContainables.Title) : null,
						Description = retriever?.SpeciesSearchContainables?.Description ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.SpeciesSearchContainables.Description) : null,
					},
					StarshipsSearchContainables = new ISearchItemLocalisation.Default
					{
						Title = retriever?.StarshipsSearchContainables?.Title ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.StarshipsSearchContainables.Title) : null,
						Description = retriever?.StarshipsSearchContainables?.Description ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.StarshipsSearchContainables.Description) : null,
					},
					VehiclesSearchContainables = new ISearchItemLocalisation.Default
					{
						Title = retriever?.VehiclesSearchContainables?.Title ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.VehiclesSearchContainables.Title) : null,
						Description = retriever?.VehiclesSearchContainables?.Description ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.VehiclesSearchContainables.Description) : null,
					},
					WeaponsSearchContainables = new ISearchItemLocalisation.Default
					{
						Title = retriever?.WeaponsSearchContainables?.Title ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.WeaponsSearchContainables.Title) : null,
						Description = retriever?.WeaponsSearchContainables?.Description ?? true ? localisationResourceManager.GetString(FilmSearch.Keys.WeaponsSearchContainables.Description) : null,
					},
				};
	}
}