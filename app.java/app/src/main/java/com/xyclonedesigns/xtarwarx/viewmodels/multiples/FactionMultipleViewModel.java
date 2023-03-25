package com.xyclonedesigns.xtarwarx.viewmodels.multiples;

import android.content.Context;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.FactionModel;

public class FactionMultipleViewModel extends BaseMultipleViewModel<FactionModel> {
    public FactionMultipleViewModel(@NonNull Context context, @NonNull StarWarsRepository repository) {
        super(context, repository);

        _Pagination._SortKey = FactionModel.SortKeys.Name;
        _Pagination._SortKeys = FactionModel.SortKeys.asArray();
        _Pagination._SortKeysTitles = FactionModel.SortKeys.asArrayTitles(_Context);
    }

    @Override
    public void dataRequest() {
        super.dataRequest();

        _Repository.factions().get(this, _Pagination);
    }
}