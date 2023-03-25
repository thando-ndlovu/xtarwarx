package com.xyclonedesigns.xtarwarx.fragments.singles;

import android.content.Context;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.FilmModel;
import com.xyclonedesigns.xtarwarx.repository.models.StarshipModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.FilmSingleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.StarshipSingleViewModel;
import com.xyclonedesigns.xtarwarx.views.models.StarshipModelView;

public class StarshipSingleFragment extends BaseSingleFragment<StarshipSingleViewModel, StarshipModelView> {
    public StarshipSingleFragment(@NonNull StarshipModel starship, @NonNull Context context, @NonNull StarWarsRepository repository) {
        super(new StarshipSingleViewModel(context, repository, starship));

        _ViewModel._Manufacturers = manufacturerMultipleViewModel(repository, manufacturers -> {
            if (_ModelView != null) _ModelView.setTransporterManufacturers(manufacturers);
        });
        _ViewModel._Pilots = characterMultipleViewModel(repository, characters -> {
            if (_ModelView != null) _ModelView.setTransporterPilots(characters);
        });
    }

    @Override
    protected StarshipModelView onCreateModelView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        _ModelView = new StarshipModelView(inflater.getContext());
        _ModelView.setViewModel(_ViewModel);

        return _ModelView;
    }
}