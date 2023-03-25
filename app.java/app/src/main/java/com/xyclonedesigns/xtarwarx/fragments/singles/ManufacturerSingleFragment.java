package com.xyclonedesigns.xtarwarx.fragments.singles;

import android.content.Context;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.FilmModel;
import com.xyclonedesigns.xtarwarx.repository.models.ManufacturerModel;
import com.xyclonedesigns.xtarwarx.repository.models.PlanetModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.FilmSingleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.ManufacturerSingleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.PlanetSingleViewModel;
import com.xyclonedesigns.xtarwarx.views.models.ManufacturerModelView;

public class ManufacturerSingleFragment extends BaseSingleFragment<ManufacturerSingleViewModel, ManufacturerModelView> {
    public ManufacturerSingleFragment(@NonNull ManufacturerModel manufacturer, @NonNull Context context, @NonNull StarWarsRepository repository) {
        super(new ManufacturerSingleViewModel(context, repository, manufacturer));

        if (manufacturer._HeadquartersPlanetId != null)
            _ViewModel._HeadquartersPlanet = new PlanetSingleViewModel(context, repository, new PlanetModel(manufacturer._HeadquartersPlanetId));

        _ViewModel._Starships = starshipMultipleViewModel(repository, starships -> {
            if (_ModelView != null) _ModelView.setManufacturerStarships(starships);
        });
        _ViewModel._Vehicles = vehicleMultipleViewModel(repository, vehicles -> {
            if (_ModelView != null) _ModelView.setManufacturerVehicles(vehicles);
        });
        _ViewModel._Weapons = weaponMultipleViewModel(repository, weapons -> {
            if (_ModelView != null) _ModelView.setManufacturerWeapons(weapons);
        });
    }

    @Override
    protected ManufacturerModelView onCreateModelView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        _ModelView = new ManufacturerModelView(inflater.getContext());
        _ModelView.setViewModel(_ViewModel);

        return _ModelView;
    }
}