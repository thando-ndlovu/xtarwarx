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
import com.xyclonedesigns.xtarwarx.repository.models.SpecieModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.FilmSingleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.PlanetSingleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.SpecieSingleViewModel;
import com.xyclonedesigns.xtarwarx.views.models.SpecieModelView;

public class SpecieSingleFragment extends BaseSingleFragment<SpecieSingleViewModel, SpecieModelView> {
    public SpecieSingleFragment(@NonNull SpecieModel specie, @NonNull Context context, @NonNull StarWarsRepository repository) {
        super(new SpecieSingleViewModel(context, repository, specie));

        _ViewModel._Characters = characterMultipleViewModel(repository, characters -> {
            if (_ModelView != null) _ModelView.setSpecieCharacters(characters);
        });

        if (specie._HomeworldId != null)
            _ViewModel._Homeworld = new PlanetSingleViewModel(context, repository, new PlanetModel(specie._HomeworldId));
    }

    @Override
    protected SpecieModelView onCreateModelView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        _ModelView = new SpecieModelView(inflater.getContext());
        _ModelView.setViewModel(_ViewModel);

        return _ModelView;
    }
}