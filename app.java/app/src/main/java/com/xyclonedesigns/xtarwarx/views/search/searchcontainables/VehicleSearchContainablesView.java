package com.xyclonedesigns.xtarwarx.views.search.searchcontainables;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.widget.AppCompatCheckBox;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.TransporterSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.VehicleSearchContainablesModel;

public class VehicleSearchContainablesView extends TransporterSearchContainablesView {
    public VehicleSearchContainablesView(Context context) {
        super(context);
    }
    public VehicleSearchContainablesView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public VehicleSearchContainablesView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public VehicleSearchContainablesView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        super.init(context, attr);

        _Name = addContainable(
                R.string.search_vehiclesearchcontainables_titles_name,
                R.string.search_vehiclesearchcontainables_descriptions_name
        );
        _Model = addContainable(
                R.string.search_vehiclesearchcontainables_titles_model,
                R.string.search_vehiclesearchcontainables_descriptions_model
        );
        _Description = addContainable(
                R.string.search_vehiclesearchcontainables_titles_description,
                R.string.search_vehiclesearchcontainables_descriptions_description
        );
        _VehicleClass = addContainable(
                R.string.search_vehiclesearchcontainables_titles_vehicleclass,
                R.string.search_vehiclesearchcontainables_descriptions_vehicleclass
        );
        _VehicleClassFlags = addContainable(
                R.string.search_vehiclesearchcontainables_titles_vehicleclassflags,
                R.string.search_vehiclesearchcontainables_descriptions_vehicleclassflags
        );
    }

    AppCompatCheckBox _VehicleClass;
    AppCompatCheckBox _VehicleClassFlags;
    VehicleSearchContainablesModel _SearchContainables;

    public @NonNull VehicleSearchContainablesModel getSearchContainables() {
        if (_SearchContainables == null)
            _SearchContainables = new VehicleSearchContainablesModel();

        _SearchContainables._VehicleClass = _VehicleClass.isChecked();
        _SearchContainables._VehicleClassFlags = _VehicleClassFlags.isChecked();

        getSearchContainables(_SearchContainables);

        return _SearchContainables;
    }
    public void setSearchContainables(@Nullable VehicleSearchContainablesModel searchcontainables) {
        _SearchContainables = searchcontainables == null
                ? new VehicleSearchContainablesModel()
                : searchcontainables;

        _VehicleClass.setChecked(_SearchContainables._VehicleClass);
        _VehicleClassFlags.setChecked(_SearchContainables._VehicleClassFlags);

        setSearchContainables((TransporterSearchContainablesModel) _SearchContainables);
    }
}