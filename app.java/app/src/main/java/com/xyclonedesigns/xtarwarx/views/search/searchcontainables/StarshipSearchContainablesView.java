package com.xyclonedesigns.xtarwarx.views.search.searchcontainables;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.widget.AppCompatCheckBox;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.StarshipSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.TransporterSearchContainablesModel;

public class StarshipSearchContainablesView extends TransporterSearchContainablesView {
    public StarshipSearchContainablesView(Context context) {
        super(context);
    }
    public StarshipSearchContainablesView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public StarshipSearchContainablesView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public StarshipSearchContainablesView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        super.init(context, attr);

        _Name = addContainable(
                R.string.search_starshipsearchcontainables_titles_name,
                R.string.search_starshipsearchcontainables_descriptions_name
        );
        _Model = addContainable(
                R.string.search_starshipsearchcontainables_titles_model,
                R.string.search_starshipsearchcontainables_descriptions_model
        );
        _Description = addContainable(
                R.string.search_starshipsearchcontainables_titles_description,
                R.string.search_starshipsearchcontainables_descriptions_description
        );
        _StarshipClass = addContainable(
                R.string.search_starshipsearchcontainables_titles_starshipclass,
                R.string.search_starshipsearchcontainables_descriptions_starshipclass
        );
        _StarshipClassFlags = addContainable(
                R.string.search_starshipsearchcontainables_titles_starshipclassflags,
                R.string.search_starshipsearchcontainables_descriptions_starshipclassflags
        );
    }

    AppCompatCheckBox _StarshipClass;
    AppCompatCheckBox _StarshipClassFlags;
    StarshipSearchContainablesModel _SearchContainables;

    public @NonNull StarshipSearchContainablesModel getSearchContainables() {
        if (_SearchContainables == null)
            _SearchContainables = new StarshipSearchContainablesModel();

        _SearchContainables._StarshipClass = _StarshipClass.isChecked();
        _SearchContainables._StarshipClassFlags = _StarshipClassFlags.isChecked();

        getSearchContainables(_SearchContainables);

        return _SearchContainables;
    }
    public void setSearchContainables(@Nullable StarshipSearchContainablesModel searchcontainables) {
        _SearchContainables = searchcontainables == null
                ? new StarshipSearchContainablesModel()
                : searchcontainables;

        _StarshipClass.setChecked(_SearchContainables._StarshipClass);
        _StarshipClassFlags.setChecked(_SearchContainables._StarshipClassFlags);

        setSearchContainables((TransporterSearchContainablesModel) _SearchContainables);
    }
}