package com.xyclonedesigns.xtarwarx.views.search;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.search.PlanetSearchModel;
import com.xyclonedesigns.xtarwarx.views.models.BaseModelView;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.CharacterSearchContainablesView;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.PlanetSearchContainablesView;

public class PlanetSearchView extends BaseSearchView {
    public static class Ids {
        public static final int Layout = R.layout.xtarwarx_view_search_planet;

        public static final int Containables_PlanetSearchContainablesView = R.id.xtarwarx_view_search_planet_containables_planetsearchcontainablesview;
        public static final int Residents_CharacterSearchContainablesView = R.id.xtarwarx_view_search_planet_residents_charactersearchcontainablesview;
        public static final int ClimateTypes_SearchValuesView = R.id.xtarwarx_view_search_planet_climatetypes_searchvaluesview;
        public static final int ClimateFlags_SearchValuesView = R.id.xtarwarx_view_search_planet_climateflags_searchvaluesview;
        public static final int Diameters_SearchValuesView = R.id.xtarwarx_view_search_planet_diameters_searchvaluesview;
        public static final int Gravities_SearchValuesView = R.id.xtarwarx_view_search_planet_gravities_searchvaluesview;
        public static final int OrbitalPeriods_SearchValuesView = R.id.xtarwarx_view_search_planet_orbitalperiods_searchvaluesview;
        public static final int Populations_SearchValuesView = R.id.xtarwarx_view_search_planet_populations_searchvaluesview;
        public static final int RotationalPeriods_SearchValuesView = R.id.xtarwarx_view_search_planet_rotationalperiods_searchvaluesview;
        public static final int SurfaceWaters_SearchValuesView = R.id.xtarwarx_view_search_planet_surfacewaters_searchvaluesview;
        public static final int TerrainTypes_SearchValuesView = R.id.xtarwarx_view_search_planet_terraintypes_searchvaluesview;
        public static final int TerrainFlags_SearchValuesView = R.id.xtarwarx_view_search_planet_terrainflags_searchvaluesview;
    }

    public PlanetSearchView(Context context) {
        super(context);
    }
    public PlanetSearchView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public PlanetSearchView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public PlanetSearchView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        inflate(context, Ids.Layout, this);
        super.init(context, attr);

        _Containables = findViewById(Ids.Containables_PlanetSearchContainablesView);
        _Residents = findViewById(Ids.Residents_CharacterSearchContainablesView);
        _ClimateTypes = findViewById(Ids.ClimateTypes_SearchValuesView);
        _ClimateFlags = findViewById(Ids.ClimateFlags_SearchValuesView);
        _Diameters = findViewById(Ids.Diameters_SearchValuesView);
        _Gravities = findViewById(Ids.Gravities_SearchValuesView);
        _OrbitalPeriods = findViewById(Ids.OrbitalPeriods_SearchValuesView);
        _Populations = findViewById(Ids.Populations_SearchValuesView);
        _RotationalPeriods = findViewById(Ids.RotationalPeriods_SearchValuesView);
        _SurfaceWaters = findViewById(Ids.SurfaceWaters_SearchValuesView);
        _TerrainTypes = findViewById(Ids.TerrainTypes_SearchValuesView);
        _TerrainFlags = findViewById(Ids.TerrainFlags_SearchValuesView);
    }

    PlanetSearchContainablesView _Containables;
    CharacterSearchContainablesView _Residents;
    SearchValuesView _ClimateTypes;
    SearchValuesView _ClimateFlags;
    SearchValuesView _Diameters;
    SearchValuesView _Gravities;
    SearchValuesView _OrbitalPeriods;
    SearchValuesView _Populations;
    SearchValuesView _RotationalPeriods;
    SearchValuesView _SurfaceWaters;
    SearchValuesView _TerrainTypes;
    SearchValuesView _TerrainFlags;
    PlanetSearchModel _Search;

    public @NonNull PlanetSearchModel getSearch() {
        if (_Search == null)
            _Search = new PlanetSearchModel();

        _Search._Containables = _Containables.getSearchContainables();
        _Search._Residents = _Residents.getSearchContainables();

        _Search._ClimateFlags = _ClimateFlags.getSearchValues_String();
        _Search._ClimateTypes = _ClimateTypes.getSearchValues_String();
        _Search._Diameters = _Diameters.getSearchValues_Integer();
        _Search._Gravities = _Gravities.getSearchValues_Double();
        _Search._OrbitalPeriods = _Diameters.getSearchValues_Integer();
        _Search._Populations = _Populations.getSearchValues_Long();
        _Search._RotationalPeriods = _RotationalPeriods.getSearchValues_Integer();
        _Search._SurfaceWaters = _SurfaceWaters.getSearchValues_Double();
        _Search._TerrainFlags = _TerrainFlags.getSearchValues_String();
        _Search._TerrainTypes = _TerrainTypes.getSearchValues_String();

        return _Search;
    }
    public void setSearch(@NonNull PlanetSearchModel search) {
        _Search = search;

        _Containables.setSearchContainables(_Search._Containables);
        _Residents.setSearchContainables(_Search._Residents);

        _ClimateFlags.setSearchValues_String(_Search._ClimateFlags);
        _ClimateTypes.setSearchValues_String(_Search._ClimateTypes);
        _Diameters.setSearchValues_Integer(_Search._Diameters);
        _Gravities.setSearchValues_Double(_Search._Gravities);
        _Diameters.setSearchValues_Integer(_Search._Diameters);
        _Populations.setSearchValues_Long(_Search._Populations);
        _RotationalPeriods.setSearchValues_Integer(_Search._RotationalPeriods);
        _SurfaceWaters.setSearchValues_Double(_Search._SurfaceWaters);
        _TerrainFlags.setSearchValues_String(_Search._TerrainFlags);
        _TerrainTypes.setSearchValues_String(_Search._TerrainTypes);
    }
}