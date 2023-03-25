package com.xyclonedesigns.xtarwarx.views.search.searchcontainables;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.widget.AppCompatCheckBox;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.WeaponSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.views.search.SearchContainablesView;

public class WeaponSearchContainablesView extends SearchContainablesView {
    public WeaponSearchContainablesView(Context context) {
        super(context);
    }
    public WeaponSearchContainablesView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public WeaponSearchContainablesView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public WeaponSearchContainablesView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        super.init(context, attr);

        _Name = addContainable(
                R.string.search_weaponsearchcontainables_titles_name,
                R.string.search_weaponsearchcontainables_descriptions_name
        );
        _Model = addContainable(
                R.string.search_weaponsearchcontainables_titles_model,
                R.string.search_weaponsearchcontainables_descriptions_model
        );
        _Description = addContainable(
                R.string.search_weaponsearchcontainables_titles_description,
                R.string.search_weaponsearchcontainables_descriptions_description
        );
        _WeaponClass = addContainable(
                R.string.search_weaponsearchcontainables_titles_weaponclass,
                R.string.search_weaponsearchcontainables_descriptions_weaponclass
        );
        _WeaponClassFlags = addContainable(
                R.string.search_weaponsearchcontainables_titles_weaponclassflags,
                R.string.search_weaponsearchcontainables_descriptions_weaponclassflags
        );
    }

    AppCompatCheckBox _Name;
    AppCompatCheckBox _Model;
    AppCompatCheckBox _Description;
    AppCompatCheckBox _WeaponClass;
    AppCompatCheckBox _WeaponClassFlags;
    WeaponSearchContainablesModel _SearchContainables;

    public @NonNull WeaponSearchContainablesModel getSearchContainables() {
        if (_SearchContainables == null)
            _SearchContainables = new WeaponSearchContainablesModel();

        _SearchContainables._Name = _Name.isChecked();
        _SearchContainables._Model = _Model.isChecked();
        _SearchContainables._Description = _Description.isChecked();
        _SearchContainables._WeaponClass = _WeaponClass.isChecked();
        _SearchContainables._WeaponClassFlags = _WeaponClassFlags.isChecked();

        return _SearchContainables;
    }
    public void setSearchContainables(@Nullable WeaponSearchContainablesModel searchcontainables) {
        _SearchContainables = searchcontainables == null
                ? new WeaponSearchContainablesModel()
                : searchcontainables;

        _Name.setChecked(_SearchContainables._Name);
        _Model.setChecked(_SearchContainables._Model);
        _Description.setChecked(_SearchContainables._Description);
        _WeaponClass.setChecked(_SearchContainables._WeaponClass);
        _WeaponClassFlags.setChecked(_SearchContainables._WeaponClassFlags);
    }
}