package com.xyclonedesigns.xtarwarx.viewmodels.multiples;

import android.content.Context;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.ManufacturerModel;

public class ManufacturerMultipleViewModel extends BaseMultipleViewModel<ManufacturerModel> {
    public ManufacturerMultipleViewModel(@NonNull Context context, @NonNull StarWarsRepository repository) {
        super(context, repository);

        _Pagination._SortKey = ManufacturerModel.SortKeys.Name;
        _Pagination._SortKeys = ManufacturerModel.SortKeys.asArray();
        _Pagination._SortKeysTitles = ManufacturerModel.SortKeys.asArrayTitles(_Context);
    }

    @Override
    public void dataRequest() {
        super.dataRequest();

        _Repository.manufacturers().get(this, _Pagination);
    }
}