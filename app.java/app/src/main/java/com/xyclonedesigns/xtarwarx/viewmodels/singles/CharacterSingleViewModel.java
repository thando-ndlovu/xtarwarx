package com.xyclonedesigns.xtarwarx.viewmodels.singles;

import android.content.Context;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.CharacterModel;
import com.xyclonedesigns.xtarwarx.repository.models.PlanetModel;

public class CharacterSingleViewModel extends BaseSingleViewModel<CharacterModel> {
    public CharacterSingleViewModel(@NonNull Context context, @NonNull StarWarsRepository repository, @NonNull CharacterModel character) {
        super(context, repository);

        _Character = character;
    }

    public @NonNull CharacterModel _Character;
    public @Nullable PlanetSingleViewModel _Homeworld;

    @Override
    public void dataRequest() {
        super.dataRequest();

        _Repository.characters().get(this, null, _Character._Id);

        if (_Homeworld != null && _Character._HomeworldId != null) _Repository.planets()
                .get(_Homeworld, null, _Character._HomeworldId);
    }
    @Override
    public void dataCallback(StarWarsRepository.Data<CharacterModel> data) {
        super.dataCallback(data);

        if (!data._Items.isEmpty())
            _Character = data._Items.get(0);
    }
}