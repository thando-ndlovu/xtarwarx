package com.xyclonedesigns.xtarwarx.views.toolbars;

import android.content.Context;
import android.util.AttributeSet;

import androidx.constraintlayout.widget.ConstraintLayout;

import com.xyclonedesigns.xtarwarx.R;

public class BaseToolbarView extends ConstraintLayout {
    public BaseToolbarView(Context context) {
        this(context, null);
    }
    public BaseToolbarView(Context context, AttributeSet attr) {
        this(context, attr, R.style.XtarWarx_View_Toolbar);
    }
    public BaseToolbarView(Context context, AttributeSet attr, int styleResId) {
        this(context, attr, styleResId, R.style.XtarWarx_View_Toolbar);
    }
    public BaseToolbarView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
        init(context, attr);
    }

    protected void init(Context context, AttributeSet attr) { }
}