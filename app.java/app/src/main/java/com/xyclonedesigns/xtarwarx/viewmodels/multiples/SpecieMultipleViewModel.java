package com.xyclonedesigns.xtarwarx.viewmodels.multiples;

import android.content.Context;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.SpecieModel;

public class SpecieMultipleViewModel extends BaseMultipleViewModel<SpecieModel> {
    public SpecieMultipleViewModel(@NonNull Context context, @NonNull StarWarsRepository repository) {
        super(context, repository);

        _Pagination._SortKey = SpecieModel.SortKeys.Name;
        _Pagination._SortKeys = SpecieModel.SortKeys.asArray();
        _Pagination._SortKeysTitles = SpecieModel.SortKeys.asArrayTitles(_Context);
    }

    @Override
    public void dataRequest() {
        super.dataRequest();

        _Repository.species().get(this, _Pagination);
    }
}