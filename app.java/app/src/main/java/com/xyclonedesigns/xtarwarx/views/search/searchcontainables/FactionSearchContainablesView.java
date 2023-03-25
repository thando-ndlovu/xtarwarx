package com.xyclonedesigns.xtarwarx.views.search.searchcontainables;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.widget.AppCompatCheckBox;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.FactionSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.views.search.SearchContainablesView;

public class FactionSearchContainablesView extends SearchContainablesView {
    public FactionSearchContainablesView(Context context) {
        super(context);
    }
    public FactionSearchContainablesView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public FactionSearchContainablesView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public FactionSearchContainablesView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        super.init(context, attr);

        _Name = addContainable(
                R.string.search_factionsearchcontainables_titles_name,
                R.string.search_factionsearchcontainables_descriptions_name
        );
        _Description = addContainable(
                R.string.search_factionsearchcontainables_titles_description,
                R.string.search_factionsearchcontainables_descriptions_description
        );
        _OrganisationTypes = addContainable(
                R.string.search_factionsearchcontainables_titles_organisationtypes,
                R.string.search_factionsearchcontainables_descriptions_organisationtypes
        );
    }

    AppCompatCheckBox _Name;
    AppCompatCheckBox _Description;
    AppCompatCheckBox _OrganisationTypes;
    FactionSearchContainablesModel _SearchContainables;

    public @NonNull FactionSearchContainablesModel getSearchContainables() {
        if (_SearchContainables == null)
            _SearchContainables = new FactionSearchContainablesModel();

        _SearchContainables._Name = _Name.isChecked();
        _SearchContainables._Description = _Description.isChecked();
        _SearchContainables._OrganisationTypes = _OrganisationTypes.isChecked();

        return _SearchContainables;
    }
    public void setSearchContainables(@Nullable FactionSearchContainablesModel searchcontainables) {
        _SearchContainables = searchcontainables == null
                ? new FactionSearchContainablesModel()
                : searchcontainables;

        _Name.setChecked(_SearchContainables._Name);
        _Description.setChecked(_SearchContainables._Description);
        _OrganisationTypes.setChecked(_SearchContainables._OrganisationTypes);
    }
}