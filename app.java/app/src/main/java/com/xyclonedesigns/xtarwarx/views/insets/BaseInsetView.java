package com.xyclonedesigns.xtarwarx.views.insets;

import android.content.Context;
import android.util.AttributeSet;
import android.view.View;
import android.view.ViewGroup;

import com.xyclonedesigns.xtarwarx.R;

import java.util.Dictionary;
import java.util.Enumeration;
import java.util.Hashtable;
import java.util.Map;

public class BaseInsetView extends View {
    public BaseInsetView(Context context) {
        this(context, null);
    }
    public BaseInsetView(Context context, AttributeSet attr) {
        this(context, attr, R.style.XtarWarx_View_Inset);
    }
    public BaseInsetView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }

    public static final String NavigationBarHeight = "navigation_bar_height";
    public static final String StatusBarHeight = "status_bar_height";
    public static final String defType = "dimen";
    public static final String defPackage = "android";

    Dictionary<String, Integer> _Insets;

    public void addInset(String key, int inset) {
        if (_Insets == null)
            _Insets = new Hashtable<>();

        _Insets.put(key, inset);

        if (inset > getLayoutParams().height)
            setHeight(inset);
    }
    public void removeInset(String key) {
        if (_Insets == null)
            return;

        int height = getLayoutParams().height;
        int removed = _Insets.remove(key);

        if (height > removed)
            return;

        int insethighest = 0;
        Enumeration insetkeys = _Insets.keys();

        while (insetkeys.hasMoreElements()) {
            int inset = ((int) insetkeys.nextElement());
            if (inset > insethighest)
                insethighest = inset;
        }

        setHeight(insethighest);
    }
    public void setHeight(int height) {
        ViewGroup.LayoutParams params = getLayoutParams();
        params.height = height;
        setLayoutParams(params);
    }
}