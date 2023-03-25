package com.xyclonedesigns.xtarwarx.views.search;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.search.SpecieSearchModel;
import com.xyclonedesigns.xtarwarx.views.models.BaseModelView;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.CharacterSearchContainablesView;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.PlanetSearchContainablesView;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.SpecieSearchContainablesView;

public class SpecieSearchView extends BaseSearchView {
    public static class Ids {
        public static final int Layout = R.layout.xtarwarx_view_search_specie;

        public static final int Containables_SpecieSearchContainablesView = R.id.xtarwarx_view_search_specie_containables_speciesearchcontainablesview;
        public static final int Characters_CharacterSearchContainablesView = R.id.xtarwarx_view_search_specie_characters_charactersearchcontainablesview;
        public static final int Homeworld_PlanetSearchContainablesView = R.id.xtarwarx_view_search_specie_homeworld_planetsearchcontainablesview;
        public static final int AverageHeights_SearchValuesView = R.id.xtarwarx_view_search_specie_averageheights_searchvaluesview;
        public static final int AverageLifespans_SearchValuesView = R.id.xtarwarx_view_search_specie_averagelifespans_searchvaluesview;
        public static final int Classifications_SearchValuesView = R.id.xtarwarx_view_search_specie_classifications_searchvaluesview;
        public static final int Designations_SearchValuesView = R.id.xtarwarx_view_search_specie_designations_searchvaluesview;
        public static final int EyeColors_SearchValuesView = R.id.xtarwarx_view_search_specie_eyecolors_searchvaluesview;
        public static final int HairColors_SearchValuesView = R.id.xtarwarx_view_search_specie_haircolors_searchvaluesview;
        public static final int Languages_SearchValuesView = R.id.xtarwarx_view_search_specie_languages_searchvaluesview;
        public static final int SkinColors_SearchValuesView = R.id.xtarwarx_view_search_specie_skincolors_searchvaluesview;
    }

    public SpecieSearchView(Context context) {
        super(context);
    }
    public SpecieSearchView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public SpecieSearchView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public SpecieSearchView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        inflate(context, Ids.Layout, this);
        super.init(context, attr);

        _Containables = findViewById(Ids.Containables_SpecieSearchContainablesView);
        _Characters = findViewById(Ids.Characters_CharacterSearchContainablesView);
        _Homeworld = findViewById(Ids.Homeworld_PlanetSearchContainablesView);
        _AverageHeights = findViewById(Ids.AverageHeights_SearchValuesView);
        _AverageLifespans = findViewById(Ids.AverageLifespans_SearchValuesView);
        _Classifications = findViewById(Ids.Classifications_SearchValuesView);
        _Designations = findViewById(Ids.Designations_SearchValuesView);
        _EyeColors = findViewById(Ids.EyeColors_SearchValuesView);
        _HairColors = findViewById(Ids.HairColors_SearchValuesView);
        _Languages = findViewById(Ids.Languages_SearchValuesView);
        _SkinColors = findViewById(Ids.SkinColors_SearchValuesView);
    }

    SpecieSearchContainablesView _Containables;
    CharacterSearchContainablesView _Characters;
    PlanetSearchContainablesView _Homeworld;
    SearchValuesView _AverageHeights;
    SearchValuesView _AverageLifespans;
    SearchValuesView _Classifications;
    SearchValuesView _Designations;
    SearchValuesView _EyeColors;
    SearchValuesView _HairColors;
    SearchValuesView _Languages;
    SearchValuesView _SkinColors;
    SpecieSearchModel _Search;

    public @NonNull SpecieSearchModel getSearch() {
        if (_Search == null)
            _Search = new SpecieSearchModel();

        _Search._Containables = _Containables.getSearchContainables();
        _Search._Characters = _Characters.getSearchContainables();
        _Search._Homeworld = _Homeworld.getSearchContainables();

        _Search._AverageHeights = _AverageHeights.getSearchValues_Integer();
        _Search._AverageLifespans = _AverageLifespans.getSearchValues_Integer();
        _Search._Classifications = _Classifications.getSearchValues_String();
        _Search._Designations = _Designations.getSearchValues_String();
        _Search._EyeColors = _EyeColors.getSearchValues_Color();
        _Search._HairColors = _HairColors.getSearchValues_Color();
        _Search._Languages = _Languages.getSearchValues_String();
        _Search._SkinColors = _SkinColors.getSearchValues_Color();

        return _Search;
    }
    public void setSearch(@NonNull SpecieSearchModel search) {
        _Search = search;

        _Containables.setSearchContainables(_Search._Containables);
        _Characters.setSearchContainables(_Search._Characters);
        _Homeworld.setSearchContainables(_Search._Homeworld);

        _AverageHeights.setSearchValues_Integer(_Search._AverageHeights);
        _AverageLifespans.setSearchValues_Integer(_Search._AverageLifespans);
        _Classifications.setSearchValues_String(_Search._Classifications);
        _Designations.setSearchValues_String(_Search._Designations);
        _EyeColors.setSearchValues_Color(_Search._EyeColors);
        _HairColors.setSearchValues_Color(_Search._HairColors);
        _Languages.setSearchValues_String(_Search._Languages);
        _SkinColors.setSearchValues_Color(_Search._SkinColors);
    }
}