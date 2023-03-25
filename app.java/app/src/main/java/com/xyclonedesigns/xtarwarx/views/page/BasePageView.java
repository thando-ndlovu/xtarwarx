package com.xyclonedesigns.xtarwarx.views.page;

import android.content.Context;
import android.util.AttributeSet;

import androidx.constraintlayout.widget.ConstraintLayout;

import com.xyclonedesigns.xtarwarx.R;

public class BasePageView extends ConstraintLayout {
    public BasePageView(Context context) {
        this(context, null);
    }
    public BasePageView(Context context, AttributeSet attr) {
        this(context, attr, R.style.XtarWarx_View_Page);
    }
    public BasePageView(Context context, AttributeSet attr, int styleResId) {
        this(context, attr, styleResId, R.style.XtarWarx_View_Page);
    }
    public BasePageView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);

        init(context, attr);
    }

    protected void init(Context context, AttributeSet attr) { }
}