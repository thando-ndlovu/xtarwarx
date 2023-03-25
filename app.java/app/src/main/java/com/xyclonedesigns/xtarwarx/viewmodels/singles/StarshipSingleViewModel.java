package com.xyclonedesigns.xtarwarx.viewmodels.singles;

import android.content.Context;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.StarshipModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.CharacterMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.ManufacturerMultipleViewModel;

public class StarshipSingleViewModel extends TransporterSingleViewModel<StarshipModel> {
    public StarshipSingleViewModel(@NonNull Context context, @NonNull StarWarsRepository repository, @NonNull StarshipModel starship) {
        super(context, repository);

        _Starship = starship;
    }

    public @NonNull StarshipModel _Starship;

    @Override
    public void dataRequest() {
        super.dataRequest();

        _Repository.starships().get(this, null, _Starship._Id);
        if (_Pilots != null) _Repository.characters()
            .get(_Pilots, _Pilots._Pagination, _Starship._PilotIds);
        if (_Manufacturers != null) _Repository.manufacturers()
            .get(_Manufacturers, _Manufacturers._Pagination, _Starship._ManufacturerIds);
    }
    @Override
    public void dataCallback(StarWarsRepository.Data<StarshipModel> data) {
        super.dataCallback(data);

        if (!data._Items.isEmpty())
            _Starship = data._Items.get(0);
    }
}