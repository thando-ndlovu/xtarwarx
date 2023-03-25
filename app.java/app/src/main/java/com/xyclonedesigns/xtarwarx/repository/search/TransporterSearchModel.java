package com.xyclonedesigns.xtarwarx.repository.search;

import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.repository.models.TransporterModelConsumable;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.CharacterSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.ManufacturerSearchContainablesModel;

public class TransporterSearchModel extends StarWarsSearchModel {
    public @Nullable ManufacturerSearchContainablesModel _Manufacturers;
    public @Nullable CharacterSearchContainablesModel _Pilots;

    public @Nullable SearchValuesModel<Long> _CargoCapacities;
    public @Nullable SearchValuesModel<TransporterModelConsumable> _Consumables;
    public @Nullable SearchValuesModel<Long> _CostInCredits;
    public @Nullable SearchValuesModel<Double> _Lengths;
    public @Nullable SearchValuesModel<Integer> _MaxAtmospheringSpeeds;
    public @Nullable SearchValuesModel<Integer> _MaxCrews;
    public @Nullable SearchValuesModel<Integer> _MinCrews;
    public @Nullable SearchValuesModel<Integer> _Passengers;
}