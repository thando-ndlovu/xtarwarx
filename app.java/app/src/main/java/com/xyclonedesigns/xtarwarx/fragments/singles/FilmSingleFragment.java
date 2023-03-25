package com.xyclonedesigns.xtarwarx.fragments.singles;

import android.content.Context;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.CharacterModel;
import com.xyclonedesigns.xtarwarx.repository.models.FilmModel;
import com.xyclonedesigns.xtarwarx.repository.models.PlanetModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.CharacterMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.PlanetMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.FilmSingleViewModel;
import com.xyclonedesigns.xtarwarx.views.models.FilmModelView;

import java.util.ArrayList;
import java.util.List;

public class FilmSingleFragment extends BaseSingleFragment<FilmSingleViewModel, FilmModelView> {
    public FilmSingleFragment(@NonNull FilmModel film, @NonNull Context context, @NonNull StarWarsRepository repository) {
        super(new FilmSingleViewModel(context, repository, film));

        _ViewModel._Characters = characterMultipleViewModel(repository, characters -> {
            if (_ModelView != null) _ModelView.setFilmCharacters(characters);
        });
        _ViewModel._Factions = factionMultipleViewModel(repository, factions -> {
            if (_ModelView != null) _ModelView.setFilmFactions(factions);
        });
        _ViewModel._Manufacturers = manufacturerMultipleViewModel(repository, manufacturers -> {
            if (_ModelView != null) _ModelView.setFilmManufacturers(manufacturers);
        });
        _ViewModel._Planets = planetMultipleViewModel(repository, planets -> {
            if (_ModelView != null) _ModelView.setFilmPlanets(planets);
        });
        _ViewModel._Species = specieMultipleViewModel(repository, species -> {
            if (_ModelView != null) _ModelView.setFilmSpecies(species);
        });
        _ViewModel._Starships = starshipMultipleViewModel(repository, starships -> {
            if (_ModelView != null) _ModelView.setFilmStarships(starships);
        });
        _ViewModel._Vehicles = vehicleMultipleViewModel(repository, vehicles -> {
            if (_ModelView != null) _ModelView.setFilmVehicles(vehicles);
        });
        _ViewModel._Weapons = weaponMultipleViewModel(repository, weapons -> {
            if (_ModelView != null) _ModelView.setFilmWeapons(weapons);
        });
    }
    @Override
    protected FilmModelView onCreateModelView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        _ModelView = new FilmModelView(inflater.getContext());
        _ModelView.setViewModel(_ViewModel);

        return _ModelView;
    }
}