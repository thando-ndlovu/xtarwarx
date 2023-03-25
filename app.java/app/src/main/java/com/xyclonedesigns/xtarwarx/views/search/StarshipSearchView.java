package com.xyclonedesigns.xtarwarx.views.search;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.search.StarshipSearchModel;
import com.xyclonedesigns.xtarwarx.repository.search.TransporterSearchModel;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.StarshipSearchContainablesView;

public class StarshipSearchView extends TransporterSearchView {
    public static class Ids {
        public static final int Layout = R.layout.xtarwarx_view_search_starship;

        public static final int Containables_StarshipSearchContainablesView = R.id.xtarwarx_view_search_starship_containables_starshipsearchcontainablesview;
        public static final int Manufacturers_ManufacturerSearchContainablesView = R.id.xtarwarx_view_search_starship_manufacturers_manufacturersearchcontainablesview;
        public static final int Pilots_CharacterSearchContainablesView = R.id.xtarwarx_view_search_starship_pilots_charactersearchcontainablesview;
        public static final int CargoCapacities_SearchValuesView = R.id.xtarwarx_view_search_starship_cargocapacities_searchvaluesview;
        public static final int Consumables_SearchValuesView = R.id.xtarwarx_view_search_starship_consumables_searchvaluesview;
        public static final int CostInCredits_SearchValuesView = R.id.xtarwarx_view_search_starship_costincredits_searchvaluesview;
        public static final int HyperdriveRatings_SearchValuesView = R.id.xtarwarx_view_search_starship_hyperdriveratings_searchvaluesview;
        public static final int Lengths_SearchValuesView = R.id.xtarwarx_view_search_starship_lengths_searchvaluesview;
        public static final int MaxAtmospheringSpeeds_SearchValuesView = R.id.xtarwarx_view_search_starship_maxatmospheringspeeds_searchvaluesview;
        public static final int MGLTs_SearchValuesView = R.id.xtarwarx_view_search_starship_mglts_searchvaluesview;
        public static final int MaxCrews_SearchValuesView = R.id.xtarwarx_view_search_starship_maxcrews_searchvaluesview;
        public static final int MinCrews_SearchValuesView = R.id.xtarwarx_view_search_starship_mincrews_searchvaluesview;
        public static final int Passengers_SearchValuesView = R.id.xtarwarx_view_search_starship_passengers_searchvaluesview;
    }

    public StarshipSearchView(Context context) {
        super(context);
    }
    public StarshipSearchView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public StarshipSearchView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public StarshipSearchView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        inflate(context, Ids.Layout, this);
        super.init(context, attr);

        _Containables = findViewById(Ids.Containables_StarshipSearchContainablesView);
        _Manufacturers = findViewById(Ids.Manufacturers_ManufacturerSearchContainablesView);
        _Pilots = findViewById(Ids.Pilots_CharacterSearchContainablesView);
        _CargoCapacities = findViewById(Ids.CargoCapacities_SearchValuesView);
        _Consumables = findViewById(Ids.Consumables_SearchValuesView);
        _CostInCredits = findViewById(Ids.CostInCredits_SearchValuesView);
        _HyperdriveRatings = findViewById(Ids.HyperdriveRatings_SearchValuesView);
        _Lengths = findViewById(Ids.Lengths_SearchValuesView);
        _MaxAtmospheringSpeeds = findViewById(Ids.MaxAtmospheringSpeeds_SearchValuesView);
        _MaxCrews = findViewById(Ids.MaxCrews_SearchValuesView);
        _MinCrews = findViewById(Ids.MinCrews_SearchValuesView);
        _MGLTs = findViewById(Ids.MGLTs_SearchValuesView);
        _Passengers = findViewById(Ids.Passengers_SearchValuesView);
    }

    StarshipSearchContainablesView _Containables;
    SearchValuesView _HyperdriveRatings;
    SearchValuesView _MGLTs;
    StarshipSearchModel _Search;

    public @NonNull StarshipSearchModel getSearch() {
        if (_Search == null)
            _Search = new StarshipSearchModel();

        _Search._Containables = _Containables.getSearchContainables();

        _Search._HyperdriveRatings = _HyperdriveRatings.getSearchValues_Double();
        _Search._MGLTs = _MGLTs.getSearchValues_Integer();

        getSearch(_Search);


        return _Search;
    }
    public void setSearch(@NonNull StarshipSearchModel search) {
        _Search = search;

        _Containables.setSearchContainables(_Search._Containables);

        _HyperdriveRatings.setSearchValues_Double(_Search._HyperdriveRatings);
        _MGLTs.setSearchValues_Integer(_Search._MGLTs);

        setSearch((TransporterSearchModel) _Search);
    }
}