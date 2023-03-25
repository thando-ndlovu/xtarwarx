package com.xyclonedesigns.xtarwarx.repository.search;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.repository.searchcontainables.CharacterSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.FactionSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.FilmSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.ManufacturerSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.PlanetSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.SpecieSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.StarshipSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.VehicleSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.WeaponSearchContainablesModel;

import java.util.Date;

public class FilmSearchModel extends StarWarsSearchModel {
    public @Nullable FilmSearchContainablesModel _Containables;
    public @Nullable CharacterSearchContainablesModel _Characters;
    public @Nullable FactionSearchContainablesModel _Factions;
    public @Nullable ManufacturerSearchContainablesModel _Manufacturers;
    public @Nullable PlanetSearchContainablesModel _Planets;
    public @Nullable SpecieSearchContainablesModel _Species;
    public @Nullable StarshipSearchContainablesModel _Starships;
    public @Nullable VehicleSearchContainablesModel _Vehicles;
    public @Nullable WeaponSearchContainablesModel _Weapons;

    public @Nullable SearchValuesModel<Integer> _Durations;
    public @Nullable SearchValuesModel<Integer> _EpisodeIds;
    public @Nullable SearchValuesModel<Date> _ReleaseDates;
}