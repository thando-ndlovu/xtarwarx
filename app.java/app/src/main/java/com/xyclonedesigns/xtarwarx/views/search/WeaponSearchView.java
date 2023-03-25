package com.xyclonedesigns.xtarwarx.views.search;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.search.WeaponSearchModel;
import com.xyclonedesigns.xtarwarx.views.models.BaseModelView;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.ManufacturerSearchContainablesView;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.WeaponSearchContainablesView;

public class WeaponSearchView extends BaseSearchView {
    public static class Ids {
        public static final int Layout = R .layout.xtarwarx_view_search_weapon;

        public static final int Containables_WeaponSearchContainablesView = R.id.xtarwarx_view_search_weapon_containables_weaponsearchcontainablesview;
        public static final int Manufacturers_ManufacturerSearchContainablesView = R.id.xtarwarx_view_search_weapon_manufacturers_manufacturersearchcontainablesview;
    }

    public WeaponSearchView(Context context) {
        super(context);
    }
    public WeaponSearchView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public WeaponSearchView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public WeaponSearchView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        inflate(context, Ids.Layout, this);
        super.init(context, attr);

        _Containables = findViewById(Ids.Containables_WeaponSearchContainablesView);
        _Manufacturers = findViewById(Ids.Manufacturers_ManufacturerSearchContainablesView);
    }

    WeaponSearchContainablesView _Containables;
    ManufacturerSearchContainablesView _Manufacturers;
    WeaponSearchModel _Search;

    public @NonNull WeaponSearchModel getSearch() {
        if (_Search == null)
            _Search = new WeaponSearchModel();

        _Search._Containables = _Containables.getSearchContainables();
        _Search._Manufacturers = _Manufacturers.getSearchContainables();

        return _Search;
    }
    public void setSearch(@NonNull WeaponSearchModel search) {
        _Search = search;

        _Containables.setSearchContainables(_Search._Containables);
        _Manufacturers.setSearchContainables(_Search._Manufacturers);
    }
}