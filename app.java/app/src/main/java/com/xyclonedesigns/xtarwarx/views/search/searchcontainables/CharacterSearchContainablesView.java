package com.xyclonedesigns.xtarwarx.views.search.searchcontainables;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.widget.AppCompatCheckBox;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.CharacterSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.views.search.SearchContainablesView;

public class CharacterSearchContainablesView extends SearchContainablesView {
    public CharacterSearchContainablesView(Context context) {
        super(context);
    }
    public CharacterSearchContainablesView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public CharacterSearchContainablesView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public CharacterSearchContainablesView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        super.init(context, attr);

        _Name = addContainable(
                R.string.search_charactersearchcontainables_titles_name,
                R.string.search_charactersearchcontainables_descriptions_name
        );
        _Description = addContainable(
                R.string.search_charactersearchcontainables_titles_description,
                R.string.search_charactersearchcontainables_descriptions_description
        );
    }

    AppCompatCheckBox _Name;
    AppCompatCheckBox _Description;
    CharacterSearchContainablesModel _SearchContainables;

    public @NonNull CharacterSearchContainablesModel getSearchContainables() {
        if (_SearchContainables == null)
            return _SearchContainables = new CharacterSearchContainablesModel();

        _SearchContainables._Name = _Name.isChecked();
        _SearchContainables._Description = _Description.isChecked();

        return _SearchContainables;
    }
    public void setSearchContainables(@Nullable CharacterSearchContainablesModel searchcontainables) {
        _SearchContainables = searchcontainables == null
                ? new CharacterSearchContainablesModel()
                : searchcontainables;

        _Name.setChecked(_SearchContainables._Name);
        _Description.setChecked(_SearchContainables._Description);
    }
}