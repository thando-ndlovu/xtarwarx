package com.xyclonedesigns.xtarwarx.views.search.searchcontainables;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.widget.AppCompatCheckBox;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.PlanetSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.views.search.SearchContainablesView;

public class PlanetSearchContainablesView extends SearchContainablesView {
    public PlanetSearchContainablesView(Context context) {
        super(context);
    }
    public PlanetSearchContainablesView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public PlanetSearchContainablesView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public PlanetSearchContainablesView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        super.init(context, attr);

        _Name = addContainable(
                R.string.search_planetsearchcontainables_titles_name,
                R.string.search_planetsearchcontainables_descriptions_name
        );
        _Description = addContainable(
                R.string.search_planetsearchcontainables_titles_description,
                R.string.search_planetsearchcontainables_descriptions_description
        );
    }

    AppCompatCheckBox _Name;
    AppCompatCheckBox _Description;
    PlanetSearchContainablesModel _SearchContainables;

    public @NonNull  PlanetSearchContainablesModel getSearchContainables() {
        if (_SearchContainables == null)
            _SearchContainables = new PlanetSearchContainablesModel();

        _SearchContainables._Name = _Name.isChecked();
        _SearchContainables._Description = _Description.isChecked();

        return _SearchContainables;
    }
    public void setSearchContainables(@Nullable PlanetSearchContainablesModel searchcontainables) {
        _SearchContainables = searchcontainables == null
                ? new PlanetSearchContainablesModel()
                : searchcontainables;

        _Name.setChecked(_SearchContainables._Name);
        _Description.setChecked(_SearchContainables._Description);
    }
}