using Localisation.Abstractions.Planets;
using Localisation.Abstractions.StarWarsModels;

namespace Localisation.Utils.Planets
{
	public class PlanetSearch
	{
		public const string ResourceName = "Planets.PlanetSearch";

		public static readonly IPlanetSearchLocalisationTyped<string> Keys = new IPlanetSearchLocalisation.DefaultTyped<string>(string.Empty)
        {
            Title = "PlanetSearch_Title",

            ClimateFlagsList = new ISearchListLocalisation.Default<string>(string.Empty) 
            {
                Title = "PlanetSearch_ClimateFlagsList_Title",
                Description = "PlanetSearch_ClimateFlagsList_Description",
                AddButtonText = "PlanetSearch_ClimateFlagsList_AddButtonText",
                PickerTitle = "PlanetSearch_ClimateFlagsList_PickerTitle",
                PickerCancel = "PlanetSearch_ClimateFlagsList_PickerCancel",
                ToastInvalid = "PlanetSearch_ClimateFlagsList_ToastInvalid",
                ToastAlreadySelected = "PlanetSearch_ClimateFlagsList_ToastAlreadySelected",
            },
            ClimateTypesList = new ISearchListLocalisation.Default<string>(string.Empty)
            {
                Title = "PlanetSearch_ClimateTypesList_Title",
                Description = "PlanetSearch_ClimateTypesList_Description",
                AddButtonText = "PlanetSearch_ClimateTypesList_AddButtonText",
                PickerTitle = "PlanetSearch_ClimateTypesList_PickerTitle",
                PickerCancel = "PlanetSearch_ClimateTypesList_PickerCancel",
                ToastInvalid = "PlanetSearch_ClimateTypesList_ToastInvalid",
                ToastAlreadySelected = "PlanetSearch_ClimateTypesList_ToastAlreadySelected",
            },
            DiametersList = new ISearchListLocalisation.Default<string>(string.Empty) 
            {
                Title = "PlanetSearch_DiametersList_Title",
                Description = "PlanetSearch_DiametersList_Description",
                AddButtonText = "PlanetSearch_DiametersList_AddButtonText",
                EntryPlaceholder = "PlanetSearch_DiametersList_EntryPlaceholder",
                ToastInvalid = "PlanetSearch_DiametersList_ToastInvalid",
                ToastAlreadySelected = "PlanetSearch_DiametersList_ToastAlreadySelected",
            },
			DiameterRange = new ISearchRangeLocalisation.Default<string>(string.Empty) 
            {
                Title = "PlanetSearch_DiameterRange_Title",
                Description = "PlanetSearch_DiameterRange_Description",
                LowerTitle = "PlanetSearch_DiameterRange_LowerTitle",
                LowerDescription = "PlanetSearch_DiameterRange_LowerDescription",
                LowerPlaceholder = "PlanetSearch_DiameterRange_LowerPlaceholder",
                UpperTitle = "PlanetSearch_DiameterRange_UpperTitle",
                UpperDescription = "PlanetSearch_DiameterRange_UpperDescription",
                UpperPlaceholder = "PlanetSearch_DiameterRange_UpperPlaceholder",
                LowerErrorMessageInvalid = "PlanetSearch_DiameterRange_LowerErrorMessageInvalid",
                UpperErrorMessageInvalid = "PlanetSearch_DiameterRange_UpperErrorMessageInvalid",
                LowerGreaterThanUpperInfoMessage = "PlanetSearch_DiameterRange_LowerGreaterThanUpperInfoMessage",
                UpperLessThanLowerInfoMessage = "PlanetSearch_DiameterRange_UpperLessThanLowerInfoMessage",
            },
			GravitiesList = new ISearchListLocalisation.Default<string>(string.Empty) 
            {
                Title = "PlanetSearch_GravitiesList_Title",
                Description = "PlanetSearch_GravitiesList_Description",
                AddButtonText = "PlanetSearch_GravitiesList_AddButtonText",
                EntryPlaceholder = "PlanetSearch_GravitiesList_EntryPlaceholder",
                ToastInvalid = "PlanetSearch_GravitiesList_ToastInvalid",
                ToastAlreadySelected = "PlanetSearch_GravitiesList_ToastAlreadySelected",
            },
			GravityRange = new ISearchRangeLocalisation.Default<string>(string.Empty) 
            {
                Title = "PlanetSearch_GravityRange_Title",
                Description = "PlanetSearch_GravityRange_Description",
                LowerTitle = "PlanetSearch_GravityRange_LowerTitle",
                LowerDescription = "PlanetSearch_GravityRange_LowerDescription",
                LowerPlaceholder = "PlanetSearch_GravityRange_LowerPlaceholder",
                UpperTitle = "PlanetSearch_GravityRange_UpperTitle",
                UpperDescription = "PlanetSearch_GravityRange_UpperDescription",
                UpperPlaceholder = "PlanetSearch_GravityRange_UpperPlaceholder",
                LowerErrorMessageInvalid = "PlanetSearch_GravityRange_LowerErrorMessageInvalid",
                UpperErrorMessageInvalid = "PlanetSearch_GravityRange_UpperErrorMessageInvalid",
                LowerGreaterThanUpperInfoMessage = "PlanetSearch_GravityRange_LowerGreaterThanUpperInfoMessage",
                UpperLessThanLowerInfoMessage = "PlanetSearch_GravityRange_UpperLessThanLowerInfoMessage",
            },
			OrbitalPeriodsList = new ISearchListLocalisation.Default<string>(string.Empty) 
            {
                Title = "PlanetSearch_OrbitalPeriodsList_Title",
                Description = "PlanetSearch_OrbitalPeriodsList_Description",
                AddButtonText = "PlanetSearch_OrbitalPeriodsList_AddButtonText",
                EntryPlaceholder = "PlanetSearch_OrbitalPeriodsList_EntryPlaceholder",
                ToastInvalid = "PlanetSearch_OrbitalPeriodsList_ToastInvalid",
                ToastAlreadySelected = "PlanetSearch_OrbitalPeriodsList_ToastAlreadySelected",
            },
			OrbitalPeriodRange = new ISearchRangeLocalisation.Default<string>(string.Empty) 
            {
                Title = "PlanetSearch_OrbitalPeriodRange_Title",
                Description = "PlanetSearch_OrbitalPeriodRange_Description",
                LowerTitle = "PlanetSearch_OrbitalPeriodRange_LowerTitle",
                LowerDescription = "PlanetSearch_OrbitalPeriodRange_LowerDescription",
                LowerPlaceholder = "PlanetSearch_OrbitalPeriodRange_LowerPlaceholder",
                UpperTitle = "PlanetSearch_OrbitalPeriodRange_UpperTitle",
                UpperDescription = "PlanetSearch_OrbitalPeriodRange_UpperDescription",
                UpperPlaceholder = "PlanetSearch_OrbitalPeriodRange_UpperPlaceholder",
                LowerErrorMessageInvalid = "PlanetSearch_OrbitalPeriodRange_LowerErrorMessageInvalid",
                UpperErrorMessageInvalid = "PlanetSearch_OrbitalPeriodRange_UpperErrorMessageInvalid",
                LowerGreaterThanUpperInfoMessage = "PlanetSearch_OrbitalPeriodRange_LowerGreaterThanUpperInfoMessage",
                UpperLessThanLowerInfoMessage = "PlanetSearch_OrbitalPeriodRange_UpperLessThanLowerInfoMessage",
            },
			PopulationsList = new ISearchListLocalisation.Default<string>(string.Empty) 
            {
                Title = "PlanetSearch_PopulationsList_Title",
                Description = "PlanetSearch_PopulationsList_Description",
                AddButtonText = "PlanetSearch_PopulationsList_AddButtonText",
                EntryPlaceholder = "PlanetSearch_PopulationsList_EntryPlaceholder",
                ToastInvalid = "PlanetSearch_PopulationsList_ToastInvalid",
                ToastAlreadySelected = "PlanetSearch_PopulationsList_ToastAlreadySelected",
            },
			PopulationRange = new ISearchRangeLocalisation.Default<string>(string.Empty) 
            {
                Title = "PlanetSearch_PopulationRange_Title",
                Description = "PlanetSearch_PopulationRange_Description",
                LowerTitle = "PlanetSearch_PopulationRange_LowerTitle",
                LowerDescription = "PlanetSearch_PopulationRange_LowerDescription",
                LowerPlaceholder = "PlanetSearch_PopulationRange_LowerPlaceholder",
                UpperTitle = "PlanetSearch_PopulationRange_UpperTitle",
                UpperDescription = "PlanetSearch_PopulationRange_UpperDescription",
                UpperPlaceholder = "PlanetSearch_PopulationRange_UpperPlaceholder",
                LowerErrorMessageInvalid = "PlanetSearch_PopulationRange_LowerErrorMessageInvalid",
                UpperErrorMessageInvalid = "PlanetSearch_PopulationRange_UpperErrorMessageInvalid",
                LowerGreaterThanUpperInfoMessage = "PlanetSearch_PopulationRange_LowerGreaterThanUpperInfoMessage",
                UpperLessThanLowerInfoMessage = "PlanetSearch_PopulationRange_UpperLessThanLowerInfoMessage",
            },
			ResidentsSearchContainables = new ISearchRangeLocalisation.Default<string>(string.Empty) 
            {
                Title = "PlanetSearch_ResidentsSearchContainables_Title",
                Description = "PlanetSearch_ResidentsSearchContainables_Description",
            },
			RotationalPeriodsList = new ISearchListLocalisation.Default<string>(string.Empty) 
            {
                Title = "PlanetSearch_RotationalPeriodsList_Title",
                Description = "PlanetSearch_RotationalPeriodsList_Description",
                AddButtonText = "PlanetSearch_RotationalPeriodsList_AddButtonText",
                EntryPlaceholder = "PlanetSearch_RotationalPeriodsList_EntryPlaceholder",
                ToastInvalid = "PlanetSearch_RotationalPeriodsList_ToastInvalid",
                ToastAlreadySelected = "PlanetSearch_RotationalPeriodsList_ToastAlreadySelected",
            },
			RotationalPeriodRange = new ISearchRangeLocalisation.Default<string>(string.Empty) 
            {
                Title = "PlanetSearch_RotationalPeriodRange_Title",
                Description = "PlanetSearch_RotationalPeriodRange_Description",
                LowerTitle = "PlanetSearch_RotationalPeriodRange_LowerTitle",
                LowerDescription = "PlanetSearch_RotationalPeriodRange_LowerDescription",
                LowerPlaceholder = "PlanetSearch_RotationalPeriodRange_LowerPlaceholder",
                UpperTitle = "PlanetSearch_RotationalPeriodRange_UpperTitle",
                UpperDescription = "PlanetSearch_RotationalPeriodRange_UpperDescription",
                UpperPlaceholder = "PlanetSearch_RotationalPeriodRange_UpperPlaceholder",
                LowerErrorMessageInvalid = "PlanetSearch_RotationalPeriodRange_LowerErrorMessageInvalid",
                UpperErrorMessageInvalid = "PlanetSearch_RotationalPeriodRange_UpperErrorMessageInvalid",
                LowerGreaterThanUpperInfoMessage = "PlanetSearch_RotationalPeriodRange_LowerGreaterThanUpperInfoMessage",
                UpperLessThanLowerInfoMessage = "PlanetSearch_RotationalPeriodRange_UpperLessThanLowerInfoMessage",
            },
			SurfaceWatersList = new ISearchListLocalisation.Default<string>(string.Empty) 
            {
                Title = "PlanetSearch_SurfaceWatersList_Title",
                Description = "PlanetSearch_SurfaceWatersList_Description",
                AddButtonText = "PlanetSearch_SurfaceWatersList_AddButtonText",
                EntryPlaceholder = "PlanetSearch_SurfaceWatersList_EntryPlaceholder",
                ToastInvalid = "PlanetSearch_SurfaceWatersList_ToastInvalid",
                ToastAlreadySelected = "PlanetSearch_SurfaceWatersList_ToastAlreadySelected",
            },
			SurfaceWaterRange = new ISearchRangeLocalisation.Default<string>(string.Empty) 
            {
                Title = "PlanetSearch_SurfaceWaterRange_Title",
                Description = "PlanetSearch_SurfaceWaterRange_Description",
                LowerTitle = "PlanetSearch_SurfaceWaterRange_LowerTitle",
                LowerDescription = "PlanetSearch_SurfaceWaterRange_LowerDescription",
                LowerPlaceholder = "PlanetSearch_SurfaceWaterRange_LowerPlaceholder",
                UpperTitle = "PlanetSearch_SurfaceWaterRange_UpperTitle",
                UpperDescription = "PlanetSearch_SurfaceWaterRange_UpperDescription",
                UpperPlaceholder = "PlanetSearch_SurfaceWaterRange_UpperPlaceholder",
                LowerErrorMessageInvalid = "PlanetSearch_SurfaceWaterRange_LowerErrorMessageInvalid",
                UpperErrorMessageInvalid = "PlanetSearch_SurfaceWaterRange_UpperErrorMessageInvalid",
                LowerGreaterThanUpperInfoMessage = "PlanetSearch_SurfaceWaterRange_LowerGreaterThanUpperInfoMessage",
                UpperLessThanLowerInfoMessage = "PlanetSearch_SurfaceWaterRange_UpperLessThanLowerInfoMessage",
            },
            TerrainFlagsList = new ISearchListLocalisation.Default<string>(string.Empty)
            {
                Title = "PlanetSearch_TerrainFlagsList_Title",
                Description = "PlanetSearch_TerrainFlagsList_Description",
                AddButtonText = "PlanetSearch_TerrainFlagsList_AddButtonText",
                PickerTitle = "PlanetSearch_TerrainFlagsList_PickerTitle",
                PickerCancel = "PlanetSearch_TerrainFlagsList_PickerCancel",
                ToastInvalid = "PlanetSearch_TerrainFlagsList_ToastInvalid",
                ToastAlreadySelected = "PlanetSearch_TerrainFlagsList_ToastAlreadySelected",
            },
            TerrainTypesList = new ISearchListLocalisation.Default<string>(string.Empty)
            {
                Title = "PlanetSearch_TerrainTypesList_Title",
                Description = "PlanetSearch_TerrainTypesList_Description",
                AddButtonText = "PlanetSearch_TerrainTypesList_AddButtonText",
                PickerTitle = "PlanetSearch_TerrainTypesList_PickerTitle",
                PickerCancel = "PlanetSearch_TerrainTypesList_PickerCancel",
                ToastInvalid = "PlanetSearch_TerrainTypesList_ToastInvalid",
                ToastAlreadySelected = "PlanetSearch_TerrainTypesList_ToastAlreadySelected",
            },
        };
	}

	public static class PlanetSearchExtensions
	{
		public static IPlanetSearchLocalisation? GetPlanetSearch(this LocalisationResourceManager? localisationResourceManager, IPlanetSearchLocalisationTyped<bool>? retriever = null)
			=> localisationResourceManager == null
				? null
				: new IPlanetSearchLocalisation.Default 
				{
                    Title = retriever?.Title ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.Title) : null,

                    ClimateFlagsList = new ISearchListLocalisation.Default
                    {
                        Title = retriever?.ClimateFlagsList?.Title ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.ClimateFlagsList.Title) : null,
                        Description = retriever?.ClimateFlagsList?.Description ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.ClimateFlagsList.Description) : null,
                        AddButtonText = retriever?.ClimateFlagsList?.AddButtonText ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.ClimateFlagsList.AddButtonText) : null,
                        PickerTitle = retriever?.ClimateFlagsList?.PickerTitle ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.ClimateFlagsList.PickerTitle) : null,
                        PickerCancel = retriever?.ClimateFlagsList?.PickerCancel ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.ClimateFlagsList.PickerCancel) : null,
                        ToastInvalid = retriever?.ClimateFlagsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.ClimateFlagsList.ToastInvalid) ?? "{0}", value) : null,
                        ToastAlreadySelected = retriever?.ClimateFlagsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.ClimateFlagsList.ToastAlreadySelected) ?? "{0}", value) : null,
                    },
                    ClimateTypesList = new ISearchListLocalisation.Default
                    {
                        Title = retriever?.ClimateTypesList?.Title ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.ClimateTypesList.Title) : null,
                        Description = retriever?.ClimateTypesList?.Description ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.ClimateTypesList.Description) : null,
                        AddButtonText = retriever?.ClimateTypesList?.AddButtonText ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.ClimateTypesList.AddButtonText) : null,
                        PickerTitle = retriever?.ClimateTypesList?.PickerTitle ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.ClimateTypesList.PickerTitle) : null,
                        PickerCancel = retriever?.ClimateTypesList?.PickerCancel ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.ClimateTypesList.PickerCancel) : null,
                        ToastInvalid = retriever?.ClimateTypesList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.ClimateTypesList.ToastInvalid) ?? "{0}", value) : null,
                        ToastAlreadySelected = retriever?.ClimateTypesList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.ClimateTypesList.ToastAlreadySelected) ?? "{0}", value) : null,
                    },
                    DiametersList = new ISearchListLocalisation.Default 
                    {
                        Title = retriever?.DiametersList?.Title ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.DiametersList.Title) : null,
                        Description = retriever?.DiametersList?.Description ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.DiametersList.Description) : null,
                        AddButtonText = retriever?.DiametersList?.AddButtonText ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.DiametersList.AddButtonText) : null,
                        EntryPlaceholder = retriever?.DiametersList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.DiametersList.EntryPlaceholder) : null,
                        ToastInvalid = retriever?.DiametersList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.DiametersList.ToastInvalid) ?? "{0}", value) : null,
                        ToastAlreadySelected = retriever?.DiametersList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.DiametersList.ToastAlreadySelected) ?? "{0}", value) : null,
                    },
                    DiameterRange = new ISearchRangeLocalisation.Default 
                    {
                        Title = retriever?.DiameterRange?.Title ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.DiameterRange.Title) : null,
                        Description = retriever?.DiameterRange?.Description ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.DiameterRange.Description) : null,
                        LowerTitle = retriever?.DiameterRange?.LowerTitle ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.DiameterRange.LowerTitle) : null,
                        LowerDescription = retriever?.DiameterRange?.LowerDescription ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.DiameterRange.LowerDescription) : null,
                        LowerPlaceholder = retriever?.DiameterRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.DiameterRange.LowerPlaceholder) : null,
                        UpperTitle = retriever?.DiameterRange?.UpperTitle ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.DiameterRange.UpperTitle) : null,
                        UpperDescription = retriever?.DiameterRange?.UpperDescription ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.DiameterRange.UpperDescription) : null,
                        UpperPlaceholder = retriever?.DiameterRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.DiameterRange.UpperPlaceholder) : null,
                        LowerErrorMessageInvalid = retriever?.DiameterRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.DiameterRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
                        UpperErrorMessageInvalid = retriever?.DiameterRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.DiameterRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
                        LowerGreaterThanUpperInfoMessage = retriever?.DiameterRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.DiameterRange.LowerGreaterThanUpperInfoMessage) : null,
                        UpperLessThanLowerInfoMessage = retriever?.DiameterRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.DiameterRange.UpperLessThanLowerInfoMessage) : null,
                    },
                    GravitiesList = new ISearchListLocalisation.Default 
                    {
                        Title = retriever?.GravitiesList?.Title ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.GravitiesList.Title) : null,
                        Description = retriever?.GravitiesList?.Description ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.GravitiesList.Description) : null,
                        AddButtonText = retriever?.GravitiesList?.AddButtonText ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.GravitiesList.AddButtonText) : null,
                        EntryPlaceholder = retriever?.GravitiesList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.GravitiesList.EntryPlaceholder) : null,
                        ToastInvalid = retriever?.GravitiesList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.GravitiesList.ToastInvalid) ?? "{0}", value) : null,
                        ToastAlreadySelected = retriever?.GravitiesList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.GravitiesList.ToastAlreadySelected) ?? "{0}", value) : null,
                    },
                    GravityRange = new ISearchRangeLocalisation.Default 
                    {
                        Title = retriever?.GravityRange?.Title ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.GravityRange.Title) : null,
                        Description = retriever?.GravityRange?.Description ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.GravityRange.Description) : null,
                        LowerTitle = retriever?.GravityRange?.LowerTitle ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.GravityRange.LowerTitle) : null,
                        LowerDescription = retriever?.GravityRange?.LowerDescription ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.GravityRange.LowerDescription) : null,
                        LowerPlaceholder = retriever?.GravityRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.GravityRange.LowerPlaceholder) : null,
                        UpperTitle = retriever?.GravityRange?.UpperTitle ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.GravityRange.UpperTitle) : null,
                        UpperDescription = retriever?.GravityRange?.UpperDescription ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.GravityRange.UpperDescription) : null,
                        UpperPlaceholder = retriever?.GravityRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.GravityRange.UpperPlaceholder) : null,
                        LowerErrorMessageInvalid = retriever?.GravityRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.GravityRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
                        UpperErrorMessageInvalid = retriever?.GravityRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.GravityRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
                        LowerGreaterThanUpperInfoMessage = retriever?.GravityRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.GravityRange.LowerGreaterThanUpperInfoMessage) : null,
                        UpperLessThanLowerInfoMessage = retriever?.GravityRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.GravityRange.UpperLessThanLowerInfoMessage) : null,
                    },
                    OrbitalPeriodsList = new ISearchListLocalisation.Default 
                    {
                        Title = retriever?.OrbitalPeriodsList?.Title ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.OrbitalPeriodsList.Title) : null,
                        Description = retriever?.OrbitalPeriodsList?.Description ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.OrbitalPeriodsList.Description) : null,
                        AddButtonText = retriever?.OrbitalPeriodsList?.AddButtonText ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.OrbitalPeriodsList.AddButtonText) : null,
                        EntryPlaceholder = retriever?.OrbitalPeriodsList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.OrbitalPeriodsList.EntryPlaceholder) : null,
                        ToastInvalid = retriever?.OrbitalPeriodsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.OrbitalPeriodsList.ToastInvalid) ?? "{0}", value) : null,
                        ToastAlreadySelected = retriever?.OrbitalPeriodsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.OrbitalPeriodsList.ToastAlreadySelected) ?? "{0}", value) : null,
                    },
                    OrbitalPeriodRange = new ISearchRangeLocalisation.Default 
                    {
                        Title = retriever?.OrbitalPeriodRange?.Title ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.OrbitalPeriodRange.Title) : null,
                        Description = retriever?.OrbitalPeriodRange?.Description ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.OrbitalPeriodRange.Description) : null,
                        LowerTitle = retriever?.OrbitalPeriodRange?.LowerTitle ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.OrbitalPeriodRange.LowerTitle) : null,
                        LowerDescription = retriever?.OrbitalPeriodRange?.LowerDescription ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.OrbitalPeriodRange.LowerDescription) : null,
                        LowerPlaceholder = retriever?.OrbitalPeriodRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.OrbitalPeriodRange.LowerPlaceholder) : null,
                        UpperDescription = retriever?.OrbitalPeriodRange?.UpperDescription ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.OrbitalPeriodRange.UpperDescription) : null,
                        UpperPlaceholder = retriever?.OrbitalPeriodRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.OrbitalPeriodRange.UpperPlaceholder) : null,
                        LowerErrorMessageInvalid = retriever?.OrbitalPeriodRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.OrbitalPeriodRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
                        UpperErrorMessageInvalid = retriever?.OrbitalPeriodRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.OrbitalPeriodRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
                        LowerGreaterThanUpperInfoMessage = retriever?.OrbitalPeriodRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.OrbitalPeriodRange.LowerGreaterThanUpperInfoMessage) : null,
                        UpperLessThanLowerInfoMessage = retriever?.OrbitalPeriodRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.OrbitalPeriodRange.UpperLessThanLowerInfoMessage) : null,
                    },
                    PopulationsList = new ISearchListLocalisation.Default 
                    {
                        Title = retriever?.PopulationsList?.Title ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.PopulationsList.Title) : null,
                        Description = retriever?.PopulationsList?.Description ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.PopulationsList.Description) : null,
                        AddButtonText = retriever?.PopulationsList?.AddButtonText ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.PopulationsList.AddButtonText) : null,
                        EntryPlaceholder = retriever?.PopulationsList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.PopulationsList.EntryPlaceholder) : null,
                        ToastInvalid = retriever?.PopulationsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.PopulationsList.ToastInvalid) ?? "{0}", value) : null,
                        ToastAlreadySelected = retriever?.PopulationsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.PopulationsList.ToastAlreadySelected) ?? "{0}", value) : null,
                    },
                    PopulationRange = new ISearchRangeLocalisation.Default 
                    {
                        Title = retriever?.PopulationRange?.Title ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.PopulationRange.Title) : null,
                        Description = retriever?.PopulationRange?.Description ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.PopulationRange.Description) : null,
                        LowerTitle = retriever?.PopulationRange?.LowerTitle ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.PopulationRange.LowerTitle) : null,
                        LowerDescription = retriever?.PopulationRange?.LowerDescription ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.PopulationRange.LowerDescription) : null,
                        LowerPlaceholder = retriever?.PopulationRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.PopulationRange.LowerPlaceholder) : null,
                        UpperTitle = retriever?.PopulationRange?.UpperTitle ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.PopulationRange.UpperTitle) : null,
                        UpperDescription = retriever?.PopulationRange?.UpperDescription ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.PopulationRange.UpperDescription) : null,
                        UpperPlaceholder = retriever?.PopulationRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.PopulationRange.UpperPlaceholder) : null,
                        LowerErrorMessageInvalid = retriever?.PopulationRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.PopulationRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
                        UpperErrorMessageInvalid = retriever?.PopulationRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.PopulationRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
                        LowerGreaterThanUpperInfoMessage = retriever?.PopulationRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.PopulationRange.LowerGreaterThanUpperInfoMessage) : null,
                        UpperLessThanLowerInfoMessage = retriever?.PopulationRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.PopulationRange.UpperLessThanLowerInfoMessage) : null,
                    },
                    ResidentsSearchContainables = new ISearchRangeLocalisation.Default 
                    {
                        Title = retriever?.ResidentsSearchContainables?.Title ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.ResidentsSearchContainables.Title) : null,
                        Description = retriever?.ResidentsSearchContainables?.Description ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.ResidentsSearchContainables.Description) : null,
                    },
                    RotationalPeriodsList = new ISearchListLocalisation.Default 
                    {
                        Title = retriever?.RotationalPeriodsList?.Title ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.RotationalPeriodsList.Title) : null,
                        Description = retriever?.RotationalPeriodsList?.Description ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.RotationalPeriodsList.Description) : null,
                        AddButtonText = retriever?.RotationalPeriodsList?.AddButtonText ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.RotationalPeriodsList.AddButtonText) : null,
                        EntryPlaceholder = retriever?.RotationalPeriodsList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.RotationalPeriodsList.EntryPlaceholder) : null,
                        ToastInvalid = retriever?.RotationalPeriodsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.RotationalPeriodsList.ToastInvalid) ?? "{0}", value) : null,
                        ToastAlreadySelected = retriever?.RotationalPeriodsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.RotationalPeriodsList.ToastAlreadySelected) ?? "{0}", value) : null,
                    },
                    RotationalPeriodRange = new ISearchRangeLocalisation.Default 
                    {
                        Title = retriever?.RotationalPeriodRange?.Title ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.RotationalPeriodRange.Title) : null,
                        Description = retriever?.RotationalPeriodRange?.Description ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.RotationalPeriodRange.Description) : null,
                        LowerTitle = retriever?.RotationalPeriodRange?.LowerTitle ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.RotationalPeriodRange.LowerTitle) : null,
                        LowerDescription = retriever?.RotationalPeriodRange?.LowerDescription ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.RotationalPeriodRange.LowerDescription) : null,
                        LowerPlaceholder = retriever?.RotationalPeriodRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.RotationalPeriodRange.LowerPlaceholder) : null,
                        UpperTitle = retriever?.RotationalPeriodRange?.UpperTitle ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.RotationalPeriodRange.UpperTitle) : null,
                        UpperDescription = retriever?.RotationalPeriodRange?.UpperDescription ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.RotationalPeriodRange.UpperDescription) : null,
                        UpperPlaceholder = retriever?.RotationalPeriodRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.RotationalPeriodRange.UpperPlaceholder) : null,
                        LowerErrorMessageInvalid = retriever?.RotationalPeriodRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.RotationalPeriodRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
                        UpperErrorMessageInvalid = retriever?.RotationalPeriodRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.RotationalPeriodRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
                        LowerGreaterThanUpperInfoMessage = retriever?.RotationalPeriodRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.RotationalPeriodRange.LowerGreaterThanUpperInfoMessage) : null,
                        UpperLessThanLowerInfoMessage = retriever?.RotationalPeriodRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.RotationalPeriodRange.UpperLessThanLowerInfoMessage) : null,
                    },
                    SurfaceWatersList = new ISearchListLocalisation.Default 
                    {
                        Title = retriever?.SurfaceWatersList?.Title ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.SurfaceWatersList.Title) : null,
                        Description = retriever?.SurfaceWatersList?.Description ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.SurfaceWatersList.Description) : null,
                        AddButtonText = retriever?.SurfaceWatersList?.AddButtonText ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.SurfaceWatersList.AddButtonText) : null,
                        EntryPlaceholder = retriever?.SurfaceWatersList?.EntryPlaceholder ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.SurfaceWatersList.EntryPlaceholder) : null,
                        ToastInvalid = retriever?.SurfaceWatersList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.SurfaceWatersList.ToastInvalid) ?? "{0}", value) : null,
                        ToastAlreadySelected = retriever?.SurfaceWatersList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.SurfaceWatersList.ToastAlreadySelected) ?? "{0}", value) : null,
                    },
                    SurfaceWaterRange = new ISearchRangeLocalisation.Default 
                    {
                        Title = retriever?.SurfaceWaterRange?.Title ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.SurfaceWaterRange.Title) : null,
                        Description = retriever?.SurfaceWaterRange?.Description ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.SurfaceWaterRange.Description) : null,
                        LowerTitle = retriever?.SurfaceWaterRange?.LowerTitle ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.SurfaceWaterRange.LowerTitle) : null,
                        LowerDescription = retriever?.SurfaceWaterRange?.LowerDescription ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.SurfaceWaterRange.LowerDescription) : null,
                        LowerPlaceholder = retriever?.SurfaceWaterRange?.LowerPlaceholder ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.SurfaceWaterRange.LowerPlaceholder) : null,
                        UpperTitle = retriever?.SurfaceWaterRange?.UpperTitle ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.SurfaceWaterRange.UpperTitle) : null,
                        UpperDescription = retriever?.SurfaceWaterRange?.UpperDescription ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.SurfaceWaterRange.UpperDescription) : null,
                        UpperPlaceholder = retriever?.SurfaceWaterRange?.UpperPlaceholder ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.SurfaceWaterRange.UpperPlaceholder) : null,
                        LowerErrorMessageInvalid = retriever?.SurfaceWaterRange?.LowerErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.SurfaceWaterRange.LowerErrorMessageInvalid) ?? "{0}", value) : null,
                        UpperErrorMessageInvalid = retriever?.SurfaceWaterRange?.UpperErrorMessageInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.SurfaceWaterRange.UpperErrorMessageInvalid) ?? "{0}", value) : null,
                        LowerGreaterThanUpperInfoMessage = retriever?.SurfaceWaterRange?.LowerGreaterThanUpperInfoMessage ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.SurfaceWaterRange.LowerGreaterThanUpperInfoMessage) : null,
                        UpperLessThanLowerInfoMessage = retriever?.SurfaceWaterRange?.UpperLessThanLowerInfoMessage ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.SurfaceWaterRange.UpperLessThanLowerInfoMessage) : null,
                    },
                    TerrainFlagsList = new ISearchListLocalisation.Default
                    {
                        Title = retriever?.TerrainFlagsList?.Title ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.TerrainFlagsList.Title) : null,
                        Description = retriever?.TerrainFlagsList?.Description ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.TerrainFlagsList.Description) : null,
                        AddButtonText = retriever?.TerrainFlagsList?.AddButtonText ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.TerrainFlagsList.AddButtonText) : null,
                        PickerTitle = retriever?.TerrainFlagsList?.PickerTitle ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.TerrainFlagsList.PickerTitle) : null,
                        PickerCancel = retriever?.TerrainFlagsList?.PickerCancel ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.TerrainFlagsList.PickerCancel) : null,
                        ToastInvalid = retriever?.TerrainFlagsList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.TerrainFlagsList.ToastInvalid) ?? "{0}", value) : null,
                        ToastAlreadySelected = retriever?.TerrainFlagsList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.TerrainFlagsList.ToastAlreadySelected) ?? "{0}", value) : null,
                    },
                    TerrainTypesList = new ISearchListLocalisation.Default
                    {
                        Title = retriever?.TerrainTypesList?.Title ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.TerrainTypesList.Title) : null,
                        Description = retriever?.TerrainTypesList?.Description ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.TerrainTypesList.Description) : null,
                        AddButtonText = retriever?.TerrainTypesList?.AddButtonText ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.TerrainTypesList.AddButtonText) : null,
                        PickerTitle = retriever?.TerrainTypesList?.PickerTitle ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.TerrainTypesList.PickerTitle) : null,
                        PickerCancel = retriever?.TerrainTypesList?.PickerCancel ?? true ? localisationResourceManager.GetString(PlanetSearch.Keys.TerrainTypesList.PickerCancel) : null,
                        ToastInvalid = retriever?.TerrainTypesList?.ToastInvalid ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.TerrainTypesList.ToastInvalid) ?? "{0}", value) : null,
                        ToastAlreadySelected = retriever?.TerrainTypesList?.ToastAlreadySelected ?? true ? value => string.Format(localisationResourceManager.GetString(PlanetSearch.Keys.TerrainTypesList.ToastAlreadySelected) ?? "{0}", value) : null,
                    },
                };
	}
}