package com.xyclonedesigns.xtarwarx.views.search;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.search.CharacterSearchModel;
import com.xyclonedesigns.xtarwarx.views.models.BaseModelView;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.CharacterSearchContainablesView;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.PlanetSearchContainablesView;

public class CharacterSearchView extends BaseSearchView {
    public static class Ids {
        public static final int Layout = R.layout.xtarwarx_view_search_character;

        public static final int Containables_CharacterSearchContainablesView = R.id.xtarwarx_view_search_character_containables_charactersearchcontainablesview;
        public static final int Homeworld_PlanetSearchContainablesView = R.id.xtarwarx_view_search_character_homeworld_planetsearchcontainablesview;
        public static final int BirthYears_SearchValuesView = R.id.xtarwarx_view_search_character_birthyears_searchvaluesview;
        public static final int EyeColors_SearchValuesView = R.id.xtarwarx_view_search_character_eyecolors_searchvaluesview;
        public static final int HairColors_SearchValuesView = R.id.xtarwarx_view_search_character_haircolors_searchvaluesview;
        public static final int Heights_SearchValuesView = R.id.xtarwarx_view_search_character_heights_searchvaluesview;
        public static final int Masses_SearchValuesView = R.id.xtarwarx_view_search_character_masses_searchvaluesview;
        public static final int Sexes_SearchValuesView = R.id.xtarwarx_view_search_character_sexes_searchvaluesview;
        public static final int SkinColors_SearchValuesView = R.id.xtarwarx_view_search_character_skincolors_searchvaluesview;
    }

    public CharacterSearchView(Context context) {
        super(context);
    }
    public CharacterSearchView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public CharacterSearchView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public CharacterSearchView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        inflate(context, Ids.Layout, this);
        super.init(context, attr);

        _Containables = findViewById(Ids.Containables_CharacterSearchContainablesView);
        _Homeworld = findViewById(Ids.Homeworld_PlanetSearchContainablesView);
        _BirthYears = findViewById(Ids.BirthYears_SearchValuesView);
        _EyeColors = findViewById(Ids.EyeColors_SearchValuesView);
        _HairColors = findViewById(Ids.HairColors_SearchValuesView);
        _Heights = findViewById(Ids.Heights_SearchValuesView);
        _Masses = findViewById(Ids.Masses_SearchValuesView);
        _Sexes = findViewById(Ids.Sexes_SearchValuesView);
        _SkinColors = findViewById(Ids.SkinColors_SearchValuesView);
    }

    CharacterSearchContainablesView _Containables;
    PlanetSearchContainablesView _Homeworld;
    SearchValuesView _BirthYears;
    SearchValuesView _EyeColors;
    SearchValuesView _HairColors;
    SearchValuesView _Heights;
    SearchValuesView _Masses;
    SearchValuesView _Sexes;
    SearchValuesView _SkinColors;
    CharacterSearchModel _Search;

    public @NonNull CharacterSearchModel getSearch() {
        if (_Search == null)
            _Search = new CharacterSearchModel();

        _Search._Containables = _Containables.getSearchContainables();
        _Search._Homeworld = _Homeworld.getSearchContainables();

        _Search._BirthYears = _BirthYears.getSearchValues_Double();
        _Search._Heights = _Heights.getSearchValues_Integer();
        _Search._Masses = _Masses.getSearchValues_Double();
        _Search._Sexes = _Sexes.getSearchValues_String();
        _Search._EyeColors = _EyeColors.getSearchValues_Color();
        _Search._HairColors = _HairColors.getSearchValues_Color();
        _Search._SkinColors = _SkinColors.getSearchValues_Color();

        return _Search;
    }
    public void setSearch(@NonNull CharacterSearchModel search) {
        _Search = search;

        _Containables.setSearchContainables(_Search._Containables);
        _Homeworld.setSearchContainables(_Search._Homeworld);

        _BirthYears.setSearchValues_Double(_Search._BirthYears);
        _Heights.setSearchValues_Integer(_Search._Heights);
        _Masses.setSearchValues_Double(_Search._Masses);
        _Sexes.setSearchValues_String(_Search._Sexes);
        _EyeColors.setSearchValues_Color(_Search._EyeColors);
        _HairColors.setSearchValues_Color(_Search._HairColors);
        _SkinColors.setSearchValues_Color(_Search._SkinColors);
    }
}