package com.xyclonedesigns.xtarwarx.fragments.singles;

import android.content.Context;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.CharacterModel;
import com.xyclonedesigns.xtarwarx.repository.models.PlanetModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.CharacterSingleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.PlanetSingleViewModel;
import com.xyclonedesigns.xtarwarx.views.models.CharacterModelView;

public class CharacterSingleFragment extends BaseSingleFragment<CharacterSingleViewModel, CharacterModelView> {
    public CharacterSingleFragment(@NonNull CharacterModel character, @NonNull Context context, @NonNull StarWarsRepository repository) {
        super(new CharacterSingleViewModel(context, repository, character));

        if (character._HomeworldId != null)
            _ViewModel._Homeworld = new PlanetSingleViewModel(context, repository, new PlanetModel(character._HomeworldId));
    }

    @Override
    protected CharacterModelView onCreateModelView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        _ModelView = new CharacterModelView(inflater.getContext());
        _ModelView.setViewModel(_ViewModel);

        return _ModelView;
    }
}