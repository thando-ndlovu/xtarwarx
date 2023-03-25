package com.xyclonedesigns.xtarwarx.viewmodels.multiples;

import android.content.Context;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.VehicleModel;

public class VehicleMultipleViewModel extends TransporterMultipleViewModel<VehicleModel> {
    public VehicleMultipleViewModel(@NonNull Context context, @NonNull StarWarsRepository repository) {
        super(context, repository);

        _Pagination._SortKey = VehicleModel.SortKeys.Name;
        _Pagination._SortKeys = VehicleModel.SortKeys.asArray();
        _Pagination._SortKeysTitles = VehicleModel.SortKeys.asArrayTitles(_Context);
    }

    @Override
    public void dataRequest() {
        super.dataRequest();

        _Repository.vehicles().get(this, _Pagination);
    }
}