package com.xyclonedesigns.xtarwarx.fragments.singles;

import android.content.Context;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.WeaponModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.WeaponSingleViewModel;
import com.xyclonedesigns.xtarwarx.views.models.WeaponModelView;

public class WeaponSingleFragment extends BaseSingleFragment<WeaponSingleViewModel, WeaponModelView> {
    public WeaponSingleFragment(@NonNull WeaponModel weaponModel, @NonNull Context context, @NonNull StarWarsRepository repository) {
        super(new WeaponSingleViewModel(context, repository, weaponModel));

        _ViewModel._Manufacturers = manufacturerMultipleViewModel(repository, manufacturers -> {
            if (_ModelView != null) _ModelView.setWeaponManufacturers(manufacturers);
        });
    }

    @Override
    protected WeaponModelView onCreateModelView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        _ModelView = new WeaponModelView(inflater.getContext());
        _ModelView.setViewModel(_ViewModel);

        return _ModelView;
    }
}