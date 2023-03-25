package com.xyclonedesigns.xtarwarx.viewmodels.multiples;

import android.content.Context;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.WeaponModel;

public class WeaponMultipleViewModel extends BaseMultipleViewModel<WeaponModel> {
    public WeaponMultipleViewModel(@NonNull Context context, @NonNull StarWarsRepository repository) {
        super(context, repository);

        _Pagination._SortKey = WeaponModel.SortKeys.Name;
        _Pagination._SortKeys = WeaponModel.SortKeys.asArray();
        _Pagination._SortKeysTitles = WeaponModel.SortKeys.asArrayTitles(_Context);
    }

    @Override
    public void dataRequest() {
        super.dataRequest();

        _Repository.weapons().get(this, _Pagination);
    }
}