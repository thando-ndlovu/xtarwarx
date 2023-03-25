package com.xyclonedesigns.xtarwarx.views.insets;

import android.content.Context;
import android.util.AttributeSet;

import com.xyclonedesigns.xtarwarx.R;

public class StatusBarInsetView extends BaseInsetView {
    public StatusBarInsetView(Context context) {
        this(context, null);
    }
    public StatusBarInsetView(Context context, AttributeSet attr) {
        this(context, attr, R.style.XtarWarx_View_Inset_StatusBar);
    }
    public StatusBarInsetView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);

        setBackgroundResource(R.drawable.background_insetview_fadetopdown);
    }

    @Override
    protected void onAttachedToWindow() {
        super.onAttachedToWindow();

        int statusbarheightid = getContext()
                .getResources()
                .getIdentifier(StatusBarHeight, defType, defPackage);

        int statusbarheight = getContext()
                .getResources()
                .getDimensionPixelSize(statusbarheightid);

        addInset(StatusBarHeight, statusbarheight);
    }
}