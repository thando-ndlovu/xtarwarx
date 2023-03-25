package com.xyclonedesigns.xtarwarx.views.search;

import android.content.Context;
import android.content.res.TypedArray;
import android.util.AttributeSet;
import android.view.View;
import android.widget.CompoundButton;

import androidx.annotation.Nullable;
import androidx.annotation.StringRes;
import androidx.appcompat.view.ContextThemeWrapper;
import androidx.appcompat.widget.AppCompatCheckBox;
import androidx.appcompat.widget.AppCompatImageButton;
import androidx.appcompat.widget.AppCompatTextView;
import androidx.constraintlayout.widget.ConstraintLayout;

import com.xyclonedesigns.xtarwarx.R;

import java.util.ArrayList;

public class SearchContainablesView extends BaseSearchView {
    public static class Attrs {
        public static final int[] Attr = R.styleable.SearchContainablesView;

        public static final int Title = R.styleable.SearchContainablesView_title;
        public static final int Subtitle = R.styleable.SearchContainablesView_subtitle;
        public static final int Collapsible = R.styleable.SearchContainablesView_collapsible;
        public static final int Collapsed = R.styleable.SearchContainablesView_collapsed;
    }
    public static class Ids {
        public static final int Layout = R.layout.xtarwarx_view_search_searchcontainables;

        public static final int Title_AppCompatTextView = R.id.xtarwarx_view_search_searchcontainables_title_appcompattextview;
        public static final int Subtitle_AppCompatTextView = R.id.xtarwarx_view_search_searchcontainables_subtitle_appcompattextview;
        public static final int Toggle_AppCompatImageButton = R.id.xtarwarx_view_search_searchcontainables_toggle_appcompatimagebutton;
    }

    public SearchContainablesView(Context context) {
        this(context, null);
    }
    public SearchContainablesView(Context context, AttributeSet attr) {
        this(context, attr, R.style.XtarWarx_View_SearchContainables);
    }
    public SearchContainablesView(Context context, AttributeSet attr, int styleResId) {
        this(context, attr, styleResId, R.style.XtarWarx_View_SearchContainables);
    }
    public SearchContainablesView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    protected void init(Context context, AttributeSet attr) {
        inflate(context, Ids.Layout, this);

        _Title = findViewById(Ids.Title_AppCompatTextView);
        _Subtitle = findViewById(Ids.Subtitle_AppCompatTextView);
        _Toggle = findViewById(Ids.Toggle_AppCompatImageButton);
        _Toggle.setOnClickListener(view -> toggle(null));
        _Containables = new ArrayList<>();

        TypedArray attributes = getContext().obtainStyledAttributes(attr, Attrs.Attr);
        String title = attributes.getString(Attrs.Title);
        String subtitle = attributes.getString(Attrs.Subtitle);

        if (title == null)
            _Title.setVisibility(GONE);
        else _Title.setText(title);
        if (subtitle == null)
            _Subtitle.setVisibility(GONE);
        else _Subtitle.setText(subtitle);
        if (attributes.getBoolean(Attrs.Collapsible, true))
            toggle(attributes.getBoolean(Attrs.Collapsed, true));
        else {
            toggle(false);
            _Toggle.setVisibility(GONE);
        }

        attributes.recycle();
    }

    protected boolean _collapsed;
    protected AppCompatTextView _Title;
    protected AppCompatTextView _Subtitle;
    protected AppCompatImageButton _Toggle;
    protected ArrayList<AppCompatCheckBox> _Containables;

    public void toggle(@Nullable Boolean collapse) {
        int visibility = (_collapsed = collapse == null ? !_collapsed : collapse)
                ? GONE
                : VISIBLE;

        _Toggle.setSelected(!_collapsed);

        if (_Subtitle.getText() != null)
            _Subtitle.setVisibility(visibility);

        if (_Containables != null)
            for (AppCompatCheckBox containable : _Containables)
                containable.setVisibility(visibility);

    }
    public AppCompatCheckBox addContainable(@StringRes int title, @StringRes int hint) {
        LayoutParams layoutParams = new LayoutParams(
                LayoutParams.MATCH_PARENT,
                LayoutParams.WRAP_CONTENT
        );
        layoutParams.endToEnd = LayoutParams.PARENT_ID;
        layoutParams.startToStart = LayoutParams.PARENT_ID;
        layoutParams.topToBottom = _Containables.isEmpty()
            ? _Subtitle.getId()
            : _Containables.get(_Containables.size() - 1).getId();

        AppCompatCheckBox appCompatCheckBox = new AppCompatCheckBox(
                new ContextThemeWrapper(getContext(), R.style.XtarWarx_View_SearchContainables_CheckBox),
                null,
                R.style.XtarWarx_View_SearchContainables_CheckBox
        );

        appCompatCheckBox.setButtonDrawable(androidx.appcompat.R.drawable.abc_btn_check_material_anim);
        appCompatCheckBox.setClickable(true);
        appCompatCheckBox.setId(0 + title);
        appCompatCheckBox.setHint(hint);
        appCompatCheckBox.setLayoutParams(new LayoutParams(
                R.dimen.dp0,
                R.dimen.dp0
        ));
        appCompatCheckBox.setText(title);
        appCompatCheckBox.setVisibility(_collapsed ? GONE : VISIBLE);

        addView(appCompatCheckBox, layoutParams);

        _Containables.add(appCompatCheckBox);

        return appCompatCheckBox;
    }
}