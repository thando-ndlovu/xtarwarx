package com.xyclonedesigns.xtarwarx.views.search.searchcontainables;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.Nullable;
import androidx.appcompat.widget.AppCompatCheckBox;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.TransporterSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.views.search.SearchContainablesView;

public class TransporterSearchContainablesView extends SearchContainablesView {
    public TransporterSearchContainablesView(Context context) {
        super(context);
    }
    public TransporterSearchContainablesView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public TransporterSearchContainablesView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public TransporterSearchContainablesView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    AppCompatCheckBox _Name;
    AppCompatCheckBox _Model;
    AppCompatCheckBox _Description;

    void getSearchContainables(@Nullable TransporterSearchContainablesModel searchcontainables) {
        if (searchcontainables == null)
            return;

        searchcontainables._Name = _Name.isChecked();
        searchcontainables._Model = _Model.isChecked();
        searchcontainables._Description = _Description.isChecked();
    }
    void setSearchContainables(@Nullable TransporterSearchContainablesModel searchcontainables) {
        if (searchcontainables == null)
            return;

        _Name.setChecked(searchcontainables._Name);
        _Model.setChecked(searchcontainables._Model);
        _Description.setChecked(searchcontainables._Description);
    }
}