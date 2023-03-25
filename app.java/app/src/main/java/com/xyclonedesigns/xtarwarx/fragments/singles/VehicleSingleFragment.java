package com.xyclonedesigns.xtarwarx.fragments.singles;

import android.content.Context;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.VehicleModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.VehicleSingleViewModel;
import com.xyclonedesigns.xtarwarx.views.models.VehicleModelView;

public class VehicleSingleFragment extends BaseSingleFragment<VehicleSingleViewModel, VehicleModelView> {
    public VehicleSingleFragment(@NonNull VehicleModel vehicle, @NonNull Context context, @NonNull StarWarsRepository repository) {
        super(new VehicleSingleViewModel(context, repository, vehicle));

        _ViewModel._Manufacturers = manufacturerMultipleViewModel(repository, manufacturers -> {
            if (_ModelView != null) _ModelView.setTransporterManufacturers(manufacturers);
        });
        _ViewModel._Pilots = characterMultipleViewModel(repository, characters -> {
            if (_ModelView != null) _ModelView.setTransporterPilots(characters);
        });
    }

    @Override
    protected VehicleModelView onCreateModelView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        _ModelView = new VehicleModelView(inflater.getContext());
        _ModelView.setViewModel(_ViewModel);

        return _ModelView;
    }
}