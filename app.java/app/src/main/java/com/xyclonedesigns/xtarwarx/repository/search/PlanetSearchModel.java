package com.xyclonedesigns.xtarwarx.repository.search;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.repository.searchcontainables.CharacterSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.PlanetSearchContainablesModel;

import java.time.Period;

public class PlanetSearchModel extends StarWarsSearchModel {
    public @Nullable PlanetSearchContainablesModel _Containables;
    public @Nullable CharacterSearchContainablesModel _Residents;

    public @Nullable SearchValuesModel<String> _ClimateTypes;
    public @Nullable SearchValuesModel<String> _ClimateFlags;
    public @Nullable SearchValuesModel<Integer> _Diameters;
    public @Nullable SearchValuesModel<Double> _Gravities;
    public @Nullable SearchValuesModel<Integer> _OrbitalPeriods;
    public @Nullable SearchValuesModel<Long> _Populations;
    public @Nullable SearchValuesModel<Integer> _RotationalPeriods;
    public @Nullable SearchValuesModel<Double> _SurfaceWaters;
    public @Nullable SearchValuesModel<String> _TerrainTypes;
    public @Nullable SearchValuesModel<String> _TerrainFlags;
}