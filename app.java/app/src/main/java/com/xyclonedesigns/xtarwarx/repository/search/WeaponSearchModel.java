package com.xyclonedesigns.xtarwarx.repository.search;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.repository.searchcontainables.ManufacturerSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.WeaponSearchContainablesModel;

public class WeaponSearchModel extends StarWarsSearchModel {
    public @Nullable WeaponSearchContainablesModel _Containables;
    public @Nullable ManufacturerSearchContainablesModel _Manufacturers;
}