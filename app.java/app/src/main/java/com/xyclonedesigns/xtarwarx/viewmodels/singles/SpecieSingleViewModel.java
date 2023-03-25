package com.xyclonedesigns.xtarwarx.viewmodels.singles;

import android.content.Context;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.PlanetModel;
import com.xyclonedesigns.xtarwarx.repository.models.SpecieModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.CharacterMultipleViewModel;

public class SpecieSingleViewModel extends BaseSingleViewModel<SpecieModel> {
    public SpecieSingleViewModel(@NonNull Context context, @NonNull StarWarsRepository repository, @NonNull SpecieModel specie) {
        super(context, repository);

        _Specie = specie;
    }

    public @NonNull SpecieModel _Specie;
    public @Nullable CharacterMultipleViewModel _Characters;
    public @Nullable PlanetSingleViewModel _Homeworld;

    @Override
    public void dataRequest() {
        super.dataRequest();

        _Repository.species().get(this, null, _Specie._Id);
        if (_Homeworld != null) _Repository.planets()
                .get(_Homeworld, null, _Specie._HomeworldId);
        if (_Characters != null) _Repository.characters()
                .get(_Characters, _Characters._Pagination, _Specie._CharacterIds);
    }
    @Override
    public void dataCallback(StarWarsRepository.Data<SpecieModel> data) {
        super.dataCallback(data);

        if (!data._Items.isEmpty())
            _Specie = data._Items.get(0);
    }
}