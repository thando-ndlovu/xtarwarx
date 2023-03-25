package com.xyclonedesigns.xtarwarx.views.search;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.search.FilmSearchModel;
import com.xyclonedesigns.xtarwarx.views.models.BaseModelView;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.CharacterSearchContainablesView;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.FactionSearchContainablesView;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.FilmSearchContainablesView;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.ManufacturerSearchContainablesView;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.PlanetSearchContainablesView;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.SpecieSearchContainablesView;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.StarshipSearchContainablesView;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.VehicleSearchContainablesView;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.WeaponSearchContainablesView;

public class FilmSearchView extends BaseSearchView {
    public static class Ids {
        public static final int Layout = R.layout.xtarwarx_view_search_film;

        public static final int Containables_FilmSearchContainablesView = R.id.xtarwarx_view_search_film_containables_filmsearchcontainablesview;
        public static final int Characters_CharacterSearchContainablesView = R.id.xtarwarx_view_search_film_characters_charactersearchcontainablesview;
        public static final int Factions_FactionSearchContainablesView = R.id.xtarwarx_view_search_film_factions_factionsearchcontainablesview;
        public static final int Manufacturers_ManufacturerSearchContainablesView = R.id.xtarwarx_view_search_film_manufacturers_manufacturersearchcontainablesview;
        public static final int Planets_PlanetSearchContainablesView = R.id.xtarwarx_view_search_film_planets_planetsearchcontainablesview;
        public static final int Species_SpecieSearchContainablesView = R.id.xtarwarx_view_search_film_species_speciesearchcontainablesview;
        public static final int Starships_StarshipSearchContainablesView = R.id.xtarwarx_view_search_film_starships_starshipsearchcontainablesview;
        public static final int Vehicles_VehicleSearchContainablesView = R.id.xtarwarx_view_search_film_vehicles_vehiclesearchcontainablesview;
        public static final int Weapons_WeaponSearchContainablesView = R.id.xtarwarx_view_search_film_weapons_weaponsearchcontainablesview;
        public static final int Durations_SearchValuesView = R.id.xtarwarx_view_search_film_durations_searchvaluesview;
        public static final int EpisodeIds_SearchValuesView = R.id.xtarwarx_view_search_film_episodeids_searchvaluesview;
        public static final int ReleaseDates_SearchValuesView = R.id.xtarwarx_view_search_film_releasedates_searchvaluesview;
    }

    public FilmSearchView(Context context) {
        super(context);
    }
    public FilmSearchView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public FilmSearchView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public FilmSearchView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        inflate(context, Ids.Layout, this);
        super.init(context, attr);

        _Containables = findViewById(Ids.Containables_FilmSearchContainablesView);
        _Characters = findViewById(Ids.Characters_CharacterSearchContainablesView);
        _Factions = findViewById(Ids.Factions_FactionSearchContainablesView);
        _Manufacturers = findViewById(Ids.Manufacturers_ManufacturerSearchContainablesView);
        _Planets = findViewById(Ids.Planets_PlanetSearchContainablesView);
        _Species = findViewById(Ids.Species_SpecieSearchContainablesView);
        _Starships = findViewById(Ids.Starships_StarshipSearchContainablesView);
        _Vehicles = findViewById(Ids.Vehicles_VehicleSearchContainablesView);
        _Weapons = findViewById(Ids.Weapons_WeaponSearchContainablesView);
        _Durations = findViewById(Ids.Durations_SearchValuesView);
        _EpisodeIds = findViewById(Ids.EpisodeIds_SearchValuesView);
        _ReleaseDates = findViewById(Ids.ReleaseDates_SearchValuesView);
    }

    FilmSearchContainablesView _Containables;
    CharacterSearchContainablesView _Characters;
    FactionSearchContainablesView _Factions;
    ManufacturerSearchContainablesView _Manufacturers;
    PlanetSearchContainablesView _Planets;
    SpecieSearchContainablesView _Species;
    StarshipSearchContainablesView _Starships;
    VehicleSearchContainablesView _Vehicles;
    WeaponSearchContainablesView _Weapons;
    SearchValuesView _Durations;
    SearchValuesView _EpisodeIds;
    SearchValuesView _ReleaseDates;
    FilmSearchModel _Search;

    public @NonNull FilmSearchModel getSearch() {
        if (_Search == null)
            _Search = new FilmSearchModel();

        _Search._Containables = _Containables.getSearchContainables();
        _Search._Characters = _Characters.getSearchContainables();
        _Search._Factions = _Factions.getSearchContainables();
        _Search._Manufacturers = _Manufacturers.getSearchContainables();
        _Search._Planets = _Planets.getSearchContainables();
        _Search._Species = _Species.getSearchContainables();
        _Search._Starships = _Starships.getSearchContainables();
        _Search._Vehicles = _Vehicles.getSearchContainables();
        _Search._Weapons = _Weapons.getSearchContainables();

        _Search._Durations = _Durations.getSearchValues_Integer();
        _Search._EpisodeIds = _EpisodeIds.getSearchValues_Integer();
        _Search._ReleaseDates = _ReleaseDates.getSearchValues_Date();

        return _Search;
    }
    public void setSearch(@NonNull FilmSearchModel search) {
        _Search = search;

        _Containables.setSearchContainables(_Search._Containables);
        _Characters.setSearchContainables(_Search._Characters);
        _Factions.setSearchContainables(_Search._Factions);
        _Manufacturers.setSearchContainables(_Search._Manufacturers);
        _Planets.setSearchContainables(_Search._Planets);
        _Species.setSearchContainables(_Search._Species);
        _Starships.setSearchContainables(_Search._Starships);
        _Vehicles.setSearchContainables(_Search._Vehicles);
        _Weapons.setSearchContainables(_Search._Weapons);
        _Durations.setSearchValues_Integer(_Search._Durations);
        _EpisodeIds.setSearchValues_Integer(_Search._EpisodeIds);
        _ReleaseDates.setSearchValues_Date(_Search._ReleaseDates);
    }
}