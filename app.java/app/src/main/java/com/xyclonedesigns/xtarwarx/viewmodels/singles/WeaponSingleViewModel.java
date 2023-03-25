package com.xyclonedesigns.xtarwarx.viewmodels.singles;

import android.content.Context;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.WeaponModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.ManufacturerMultipleViewModel;

public class WeaponSingleViewModel extends BaseSingleViewModel<WeaponModel> {
    public WeaponSingleViewModel(@NonNull Context context, @NonNull StarWarsRepository repository, @NonNull WeaponModel weapon) {
        super(context, repository);

        _Weapon = weapon;
    }

    public @NonNull WeaponModel _Weapon;
    public @Nullable ManufacturerMultipleViewModel _Manufacturers;

    @Override
    public void dataRequest() {
        super.dataRequest();

        _Repository.weapons().get(this, null, _Weapon._Id);
        if (_Manufacturers != null) _Repository.manufacturers()
                .get(_Manufacturers, _Manufacturers._Pagination, _Weapon._ManufacturerIds);
    }
    @Override
    public void dataCallback(StarWarsRepository.Data<WeaponModel> data) {
        super.dataCallback(data);

        if (!data._Items.isEmpty())
            _Weapon = data._Items.get(0);
    }
}