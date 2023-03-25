package com.xyclonedesigns.xtarwarx.views.search;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.search.ManufacturerSearchModel;
import com.xyclonedesigns.xtarwarx.views.models.BaseModelView;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.ManufacturerSearchContainablesView;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.PlanetSearchContainablesView;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.StarshipSearchContainablesView;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.VehicleSearchContainablesView;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.WeaponSearchContainablesView;

public class ManufacturerSearchView extends BaseSearchView {
    public static class Ids {
        public static final int Layout = R.layout.xtarwarx_view_search_manufacturer;

        public static final int Containables_ManufacturerSearchContainablesView = R.id.xtarwarx_view_search_manufacturer_containables_manufacturersearchcontainablesview;
        public static final int HeadquartersPlanet_PlanetSearchContainablesView = R.id.xtarwarx_view_search_manufacturer_headquartersplanet_planetsearchcontainablesview;
        public static final int Starships_StarshipSearchContainablesView = R.id.xtarwarx_view_search_manufacturer_starships_starshipsearchcontainablesview;
        public static final int Vehicles_VehicleSearchContainablesView = R.id.xtarwarx_view_search_manufacturer_vehicles_vehiclesearchcontainablesview;
        public static final int Weapons_WeaponSearchContainablesView = R.id.xtarwarx_view_search_manufacturer_weapons_weaponsearchcontainablesview;
    }

    public ManufacturerSearchView(Context context) {
        super(context);
    }
    public ManufacturerSearchView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public ManufacturerSearchView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public ManufacturerSearchView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        inflate(context, Ids.Layout, this);
        super.init(context, attr);

        _Containables = findViewById(Ids.Containables_ManufacturerSearchContainablesView);
        _HeadquartersPlanet = findViewById(Ids.HeadquartersPlanet_PlanetSearchContainablesView);
        _Starships = findViewById(Ids.Starships_StarshipSearchContainablesView);
        _Vehicles = findViewById(Ids.Vehicles_VehicleSearchContainablesView);
        _Weapons = findViewById(Ids.Weapons_WeaponSearchContainablesView);
    }

    ManufacturerSearchContainablesView _Containables;
    PlanetSearchContainablesView _HeadquartersPlanet;
    StarshipSearchContainablesView _Starships;
    VehicleSearchContainablesView _Vehicles;
    WeaponSearchContainablesView _Weapons;
    ManufacturerSearchModel _Search;

    public @NonNull ManufacturerSearchModel getSearch() {
        if (_Search == null)
            _Search = new ManufacturerSearchModel();

        _Search._Containables = _Containables.getSearchContainables();
        _Search._HeadquartersPlanet = _HeadquartersPlanet.getSearchContainables();
        _Search._Starships = _Starships.getSearchContainables();
        _Search._Vehicles = _Vehicles.getSearchContainables();
        _Search._Weapons = _Weapons.getSearchContainables();

        return _Search;
    }
    public void setSearch(@NonNull ManufacturerSearchModel search) {
        _Search = search;

        _Containables.setSearchContainables(_Search._Containables);
        _HeadquartersPlanet.setSearchContainables(_Search._HeadquartersPlanet);
        _Starships.setSearchContainables(_Search._Starships);
        _Vehicles.setSearchContainables(_Search._Vehicles);
        _Weapons.setSearchContainables(_Search._Weapons);
    }
}