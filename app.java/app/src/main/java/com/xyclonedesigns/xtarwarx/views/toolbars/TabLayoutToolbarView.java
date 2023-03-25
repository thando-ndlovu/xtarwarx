package com.xyclonedesigns.xtarwarx.views.toolbars;

import android.content.Context;
import android.util.AttributeSet;

import androidx.appcompat.widget.Toolbar;

import com.google.android.material.tabs.TabLayout;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.views.insets.StatusBarInsetView;

public class TabLayoutToolbarView extends BaseToolbarView {
    public static class Ids {
        public static final int Layout = R.layout.xtarwarx_view_toolbar_tablayout;

        public static final int StatusBarInset = R.id.xtarwarx_view_toolbar_tablayout_statusbarinsetview;
        public static final int Toolbar = R.id.xtarwarx_view_toolbar_tablayout_toolbar;
        public static final int TabLayout = R.id.xtarwarx_view_toolbar_tablayout_tablayout;
    }

    public TabLayoutToolbarView(Context context) {
        super(context);
    }
    public TabLayoutToolbarView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public TabLayoutToolbarView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public TabLayoutToolbarView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        inflate(context, Ids.Layout, this);
        super.init(context, attr);

        _StatusBarInset = findViewById(Ids.StatusBarInset);
        _Toolbar = findViewById(Ids.Toolbar);
        _TabLayout = findViewById(Ids.TabLayout);
    }

    StatusBarInsetView _StatusBarInset;
    Toolbar _Toolbar;
    TabLayout _TabLayout;

    public Toolbar getToolbar() {
        return _Toolbar;
    }
    public TabLayout getTabLayout() {
        return _TabLayout;
    }
}