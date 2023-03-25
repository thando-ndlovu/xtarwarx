package com.xyclonedesigns.xtarwarx.fragments.singles;

import android.content.Context;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.FactionModel;
import com.xyclonedesigns.xtarwarx.repository.models.FilmModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.FactionSingleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.FilmSingleViewModel;
import com.xyclonedesigns.xtarwarx.views.models.FactionModelView;

public class FactionSingleFragment extends BaseSingleFragment<FactionSingleViewModel, FactionModelView> {
    public FactionSingleFragment(@NonNull FactionModel faction, @NonNull Context context, @NonNull StarWarsRepository repository) {
        super(new FactionSingleViewModel(context, repository, faction));

        _ViewModel._AlliedCharacters = characterMultipleViewModel(repository, characters -> {
            if (_ModelView != null) _ModelView.setFactionAlliedCharacters(characters);
        });
        _ViewModel._AlliedFactions = factionMultipleViewModel(repository, factions -> {
            if (_ModelView != null) _ModelView.setFactionAlliedFactions(factions);
        });
        _ViewModel._Leaders = characterMultipleViewModel(repository, characters -> {
            if (_ModelView != null) _ModelView.setFactionLeaders(characters);
        });
        _ViewModel._MemberCharacters = characterMultipleViewModel(repository, characters -> {
            if (_ModelView != null) _ModelView.setFactionMemberCharacters(characters);
        });
        _ViewModel._MemberFactions = factionMultipleViewModel(repository, factions -> {
            if (_ModelView != null) _ModelView.setFactionMemberFactions(factions);
        });
    }

    @Override
    protected FactionModelView onCreateModelView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        _ModelView = new FactionModelView(inflater.getContext());
        _ModelView.setViewModel(_ViewModel);

        return _ModelView;
    }
}