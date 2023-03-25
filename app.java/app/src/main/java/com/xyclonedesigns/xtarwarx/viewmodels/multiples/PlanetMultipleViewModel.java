package com.xyclonedesigns.xtarwarx.viewmodels.multiples;

import android.content.Context;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.PlanetModel;

public class PlanetMultipleViewModel extends BaseMultipleViewModel<PlanetModel> {
    public PlanetMultipleViewModel(@NonNull Context context, @NonNull StarWarsRepository repository) {
        super(context, repository);

        _Pagination._SortKey = PlanetModel.SortKeys.Name;
        _Pagination._SortKeys = PlanetModel.SortKeys.asArray();
        _Pagination._SortKeysTitles = PlanetModel.SortKeys.asArrayTitles(_Context);
    }

    @Override
    public void dataRequest() {
        super.dataRequest();

        _Repository.planets().get(this, _Pagination);
    }
}