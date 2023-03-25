package com.xyclonedesigns.xtarwarx.views.search;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.repository.search.TransporterSearchModel;
import com.xyclonedesigns.xtarwarx.views.models.BaseModelView;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.CharacterSearchContainablesView;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.ManufacturerSearchContainablesView;

import java.util.function.Consumer;

public class TransporterSearchView extends BaseSearchView {
    public TransporterSearchView(Context context) {
        super(context);
    }
    public TransporterSearchView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public TransporterSearchView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public TransporterSearchView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    ManufacturerSearchContainablesView _Manufacturers;
    CharacterSearchContainablesView _Pilots;
    SearchValuesView _CargoCapacities;
    SearchValuesView _Consumables;
    SearchValuesView _CostInCredits;
    SearchValuesView _Lengths;
    SearchValuesView _MaxAtmospheringSpeeds;
    SearchValuesView _MaxCrews;
    SearchValuesView _MinCrews;
    SearchValuesView _Passengers;

    void getSearch(@NonNull TransporterSearchModel search) {
        search._Manufacturers = _Manufacturers.getSearchContainables();
        search._Pilots = _Pilots.getSearchContainables();

        search._CargoCapacities = _CargoCapacities.getSearchValues_Long();
        search._Consumables = _Consumables.getSearchValues(new Consumer<SearchValuesView.SearchValuesConsumer>() {
            @Override
            public void accept(SearchValuesView.SearchValuesConsumer searchValuesConsumer) {

            }
        });
        search._CostInCredits = _CostInCredits.getSearchValues_Long();
        search._Lengths = _Lengths.getSearchValues_Double();
        search._MaxAtmospheringSpeeds = _MaxAtmospheringSpeeds.getSearchValues_Integer();
        search._MaxCrews = _MaxCrews.getSearchValues_Integer();
        search._MinCrews = _MinCrews.getSearchValues_Integer();
        search._Passengers = _Passengers.getSearchValues_Integer();
    }
    void setSearch(@NonNull TransporterSearchModel search) {
        _Manufacturers.setSearchContainables(search._Manufacturers);
        _Pilots.setSearchContainables(search._Pilots);

        _CargoCapacities.setSearchValues_Long(search._CargoCapacities);
        _Consumables.setSearchValues(search._Consumables);
        _CostInCredits.setSearchValues_Long(search._CostInCredits);
        _Lengths.setSearchValues_Double(search._Lengths);
        _MaxAtmospheringSpeeds.setSearchValues_Integer(search._MaxAtmospheringSpeeds);
        _MaxCrews.setSearchValues_Integer(search._MaxCrews);
        _MinCrews.setSearchValues_Integer(search._MinCrews);
        _Passengers.setSearchValues_Integer(search._Passengers);
    }
}