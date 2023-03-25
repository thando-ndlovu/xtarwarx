package com.xyclonedesigns.xtarwarx.views.search.searchcontainables;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.widget.AppCompatCheckBox;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.SpecieSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.views.search.SearchContainablesView;

public class SpecieSearchContainablesView extends SearchContainablesView {
    public SpecieSearchContainablesView(Context context) {
        super(context);
    }
    public SpecieSearchContainablesView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public SpecieSearchContainablesView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public SpecieSearchContainablesView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        super.init(context, attr);

        _Name = addContainable(
                R.string.search_speciesearchcontainables_titles_name,
                R.string.search_speciesearchcontainables_descriptions_name
        );
        _Description = addContainable(
                R.string.search_speciesearchcontainables_titles_description,
                R.string.search_speciesearchcontainables_descriptions_description
        );
    }

    AppCompatCheckBox _Name;
    AppCompatCheckBox _Description;
    SpecieSearchContainablesModel _SearchContainables;

    public @NonNull SpecieSearchContainablesModel getSearchContainables() {
        if (_SearchContainables == null)
            _SearchContainables = new SpecieSearchContainablesModel();

        _SearchContainables._Name = _Name.isChecked();
        _SearchContainables._Description = _Description.isChecked();

        return _SearchContainables;
    }
    public void setSearchContainables(@Nullable SpecieSearchContainablesModel searchcontainables) {
        _SearchContainables = searchcontainables == null
                ? new SpecieSearchContainablesModel()
                : searchcontainables;

        _Name.setChecked(_SearchContainables._Name);
        _Description.setChecked(_SearchContainables._Description);
    }
}