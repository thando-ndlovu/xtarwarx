package com.xyclonedesigns.xtarwarx.repository.search;

import android.graphics.Color;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.repository.searchcontainables.CharacterSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.PlanetSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.SpecieSearchContainablesModel;

public class SpecieSearchModel extends StarWarsSearchModel {
    public @Nullable SpecieSearchContainablesModel _Containables;
    public @Nullable CharacterSearchContainablesModel _Characters;
    public @Nullable PlanetSearchContainablesModel _Homeworld;

    public @Nullable SearchValuesModel<Integer> _AverageHeights;
    public @Nullable SearchValuesModel<Integer> _AverageLifespans;
    public @Nullable SearchValuesModel<String> _Classifications;
    public @Nullable SearchValuesModel<String> _Designations;
    public @Nullable SearchValuesModel<Color> _EyeColors;
    public @Nullable SearchValuesModel<Color> _HairColors;
    public @Nullable SearchValuesModel<String> _Languages;
    public @Nullable SearchValuesModel<Color> _SkinColors;
}