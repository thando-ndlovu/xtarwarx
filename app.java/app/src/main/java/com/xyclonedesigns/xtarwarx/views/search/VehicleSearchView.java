package com.xyclonedesigns.xtarwarx.views.search;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.search.TransporterSearchModel;
import com.xyclonedesigns.xtarwarx.repository.search.VehicleSearchModel;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.VehicleSearchContainablesView;

public class VehicleSearchView extends TransporterSearchView {
    public static class Ids {
        public static final int Layout = R.layout.xtarwarx_view_search_vehicle;

        public static final int Containables_VehicleSearchContainablesView = R.id.xtarwarx_view_search_vehicle_containables_vehiclesearchcontainablesview;
        public static final int Manufacturers_ManufacturerSearchContainablesView = R.id.xtarwarx_view_search_vehicle_manufacturers_manufacturersearchcontainablesview;
        public static final int Pilots_CharacterSearchContainablesView = R.id.xtarwarx_view_search_vehicle_pilots_charactersearchcontainablesview;
        public static final int CargoCapacities_SearchValuesView = R.id.xtarwarx_view_search_vehicle_cargocapacities_searchvaluesview;
        public static final int Consumables_SearchValuesView = R.id.xtarwarx_view_search_vehicle_consumables_searchvaluesview;
        public static final int CostInCredits_SearchValuesView = R.id.xtarwarx_view_search_vehicle_costincredits_searchvaluesview;
        public static final int Lengths_SearchValuesView = R.id.xtarwarx_view_search_vehicle_lengths_searchvaluesview;
        public static final int MaxAtmospheringSpeeds_SearchValuesView = R.id.xtarwarx_view_search_vehicle_maxatmospheringspeeds_searchvaluesview;
        public static final int MaxCrews_SearchValuesView = R.id.xtarwarx_view_search_vehicle_maxcrews_searchvaluesview;
        public static final int MinCrews_SearchValuesView = R.id.xtarwarx_view_search_vehicle_mincrews_searchvaluesview;
        public static final int Passengers_SearchValuesView = R.id.xtarwarx_view_search_vehicle_passengers_searchvaluesview;
    }

    public VehicleSearchView(Context context) {
        super(context);
    }
    public VehicleSearchView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public VehicleSearchView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public VehicleSearchView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        inflate(context, Ids.Layout, this);
        super.init(context, attr);

        _Containables = findViewById(Ids.Containables_VehicleSearchContainablesView);
        _Manufacturers = findViewById(Ids.Manufacturers_ManufacturerSearchContainablesView);
        _Pilots = findViewById(Ids.Pilots_CharacterSearchContainablesView);
        _CargoCapacities = findViewById(Ids.CargoCapacities_SearchValuesView);
        _Consumables = findViewById(Ids.Consumables_SearchValuesView);
        _CostInCredits = findViewById(Ids.CostInCredits_SearchValuesView);
        _Lengths = findViewById(Ids.Lengths_SearchValuesView);
        _MaxAtmospheringSpeeds = findViewById(Ids.MaxAtmospheringSpeeds_SearchValuesView);
        _MaxCrews = findViewById(Ids.MaxCrews_SearchValuesView);
        _MinCrews = findViewById(Ids.MinCrews_SearchValuesView);
        _Passengers = findViewById(Ids.Passengers_SearchValuesView);
    }

    VehicleSearchContainablesView _Containables;
    VehicleSearchModel _Search;

    public @NonNull VehicleSearchModel getSearch() {
        if (_Search == null)
            _Search = new VehicleSearchModel();

        _Search._Containables = _Containables.getSearchContainables();

        getSearch(_Search);

        return _Search;
    }
    public void setSearch(@NonNull VehicleSearchModel search) {
        _Search = search;

        _Containables.setSearchContainables(_Search._Containables);

        setSearch((TransporterSearchModel) _Search);
    }
}