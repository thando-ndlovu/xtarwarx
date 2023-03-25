package com.xyclonedesigns.xtarwarx.repository.search;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.repository.searchcontainables.ManufacturerSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.PlanetSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.StarshipSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.VehicleSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.WeaponSearchContainablesModel;

public class ManufacturerSearchModel extends StarWarsSearchModel {
    public @Nullable ManufacturerSearchContainablesModel _Containables;
    public @Nullable PlanetSearchContainablesModel _HeadquartersPlanet;
    public @Nullable StarshipSearchContainablesModel _Starships;
    public @Nullable VehicleSearchContainablesModel _Vehicles;
    public @Nullable WeaponSearchContainablesModel _Weapons;
}