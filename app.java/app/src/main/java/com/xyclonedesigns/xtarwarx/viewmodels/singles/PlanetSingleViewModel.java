package com.xyclonedesigns.xtarwarx.viewmodels.singles;

import android.content.Context;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.PlanetModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.CharacterMultipleViewModel;

public class PlanetSingleViewModel extends BaseSingleViewModel<PlanetModel> {
    public PlanetSingleViewModel(@NonNull Context context, @NonNull StarWarsRepository repository, @NonNull PlanetModel planet) {
        super(context, repository);

        _Planet = planet;
    }

    public @NonNull PlanetModel _Planet;
    public @Nullable CharacterMultipleViewModel _Residents;

    @Override
    public void dataRequest() {
        super.dataRequest();

        _Repository.planets().get(this, null, _Planet._Id);
        if (_Residents != null) _Repository.characters()
                .get(_Residents, _Residents._Pagination, _Planet._ResidentIds);
    }
    @Override
    public void dataCallback(StarWarsRepository.Data<PlanetModel> data) {
        super.dataCallback(data);

        if (!data._Items.isEmpty())
            _Planet = data._Items.get(0);
    }
}