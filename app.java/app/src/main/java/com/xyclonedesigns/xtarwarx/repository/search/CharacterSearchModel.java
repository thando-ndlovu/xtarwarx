package com.xyclonedesigns.xtarwarx.repository.search;

import android.graphics.Color;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.repository.searchcontainables.CharacterSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.PlanetSearchContainablesModel;

public class CharacterSearchModel extends StarWarsSearchModel {
    public @Nullable CharacterSearchContainablesModel _Containables;
    public @Nullable PlanetSearchContainablesModel _Homeworld;
    public @Nullable SearchValuesModel<Double> _BirthYears;
    public @Nullable SearchValuesModel<Color> _EyeColors;
    public @Nullable SearchValuesModel<Color> _HairColors;
    public @Nullable SearchValuesModel<Integer> _Heights;
    public @Nullable SearchValuesModel<Double> _Masses;
    public @Nullable SearchValuesModel<String> _Sexes;
    public @Nullable SearchValuesModel<Color> _SkinColors;
}