package com.xyclonedesigns.xtarwarx.views.search.searchcontainables;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.widget.AppCompatCheckBox;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.ManufacturerSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.views.search.SearchContainablesView;

public class ManufacturerSearchContainablesView extends SearchContainablesView {
    public ManufacturerSearchContainablesView(Context context) {
        super(context);
    }
    public ManufacturerSearchContainablesView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public ManufacturerSearchContainablesView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public ManufacturerSearchContainablesView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        super.init(context, attr);

        _Name = addContainable(
                R.string.search_manufacturersearchcontainables_titles_name,
                R.string.search_manufacturersearchcontainables_descriptions_name
        );
        _Description = addContainable(
                R.string.search_manufacturersearchcontainables_titles_description,
                R.string.search_manufacturersearchcontainables_descriptions_description
        );
    }

    AppCompatCheckBox _Name;
    AppCompatCheckBox _Description;
    ManufacturerSearchContainablesModel _SearchContainables;

    public @NonNull ManufacturerSearchContainablesModel getSearchContainables() {
        if (_SearchContainables == null)
            _SearchContainables = new ManufacturerSearchContainablesModel();

        _SearchContainables._Name = _Name.isChecked();
        _SearchContainables._Description = _Description.isChecked();

        return _SearchContainables;
    }
    public void setSearchContainables(@Nullable ManufacturerSearchContainablesModel searchcontainables) {
        _SearchContainables = searchcontainables == null
                ? new ManufacturerSearchContainablesModel()
                : searchcontainables;

        _Name.setChecked(_SearchContainables._Name);
        _Description.setChecked(_SearchContainables._Description);
    }
}