package com.xyclonedesigns.xtarwarx.views.insets;

import android.content.Context;
import android.util.AttributeSet;

import com.xyclonedesigns.xtarwarx.R;

public class NavigationBarInsetView extends BaseInsetView {
    public NavigationBarInsetView(Context context) {
        this(context, null);
    }
    public NavigationBarInsetView(Context context, AttributeSet attr) {
        this(context, attr, R.style.XtarWarx_View_Inset_NavigationBar);
    }
    public NavigationBarInsetView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);

        setBackgroundResource(R.drawable.background_insetview_fadebottomup);
    }

    @Override
    protected void onAttachedToWindow() {
        super.onAttachedToWindow();

        addInset(NavigationBarHeight, getPixelHeight(getContext()));
    }

    public static int getPixelHeight(Context context) {
        int navigationbarheightid = context
                .getResources()
                .getIdentifier(NavigationBarHeight, defType, defPackage);

        return context
                .getResources()
                .getDimensionPixelSize(navigationbarheightid);
    }
}