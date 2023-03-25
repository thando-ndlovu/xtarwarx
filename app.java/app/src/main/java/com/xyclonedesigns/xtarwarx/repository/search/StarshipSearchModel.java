package com.xyclonedesigns.xtarwarx.repository.search;

import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.repository.searchcontainables.StarshipSearchContainablesModel;

public class StarshipSearchModel extends TransporterSearchModel {
    public @Nullable StarshipSearchContainablesModel _Containables;

    public @Nullable SearchValuesModel<Integer> _MGLTs;
    public @Nullable SearchValuesModel<Double> _HyperdriveRatings;
}