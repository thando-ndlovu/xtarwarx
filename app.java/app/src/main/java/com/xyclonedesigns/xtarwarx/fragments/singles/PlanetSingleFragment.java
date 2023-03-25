package com.xyclonedesigns.xtarwarx.fragments.singles;

import android.content.Context;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.FilmModel;
import com.xyclonedesigns.xtarwarx.repository.models.PlanetModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.FilmSingleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.PlanetSingleViewModel;
import com.xyclonedesigns.xtarwarx.views.models.PlanetModelView;

public class PlanetSingleFragment extends BaseSingleFragment<PlanetSingleViewModel, PlanetModelView> {
    public PlanetSingleFragment(@NonNull PlanetModel planet, @NonNull Context context, @NonNull StarWarsRepository repository) {
        super(new PlanetSingleViewModel(context, repository, planet));

        _ViewModel._Residents = characterMultipleViewModel(repository, characters -> {
            if (_ModelView != null) _ModelView.setPlanetsResidents(characters);
        });
    }

    @Override
    protected PlanetModelView onCreateModelView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        _ModelView = new PlanetModelView(inflater.getContext());
        _ModelView.setViewModel(_ViewModel);

        return _ModelView;
    }
}