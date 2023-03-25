package com.xyclonedesigns.xtarwarx.viewmodels.multiples;

import android.content.Context;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.StarshipModel;

public class StarshipMultipleViewModel extends TransporterMultipleViewModel<StarshipModel> {
    public StarshipMultipleViewModel(@NonNull Context context, @NonNull StarWarsRepository repository) {
        super(context, repository);

        _Pagination._SortKey = StarshipModel.SortKeys.Name;
        _Pagination._SortKeys = StarshipModel.SortKeys.asArray();
        _Pagination._SortKeysTitles = StarshipModel.SortKeys.asArrayTitles(_Context);
    }

    @Override
    public void dataRequest() {
        super.dataRequest();

        _Repository.starships().get(this, _Pagination);
    }
}