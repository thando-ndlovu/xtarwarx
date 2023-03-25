package com.xyclonedesigns.xtarwarx.views.search;

import android.content.Context;
import android.content.res.TypedArray;
import android.graphics.Color;
import android.util.AttributeSet;

import androidx.annotation.Nullable;
import androidx.appcompat.widget.ActionMenuView;
import androidx.appcompat.widget.AppCompatButton;
import androidx.appcompat.widget.AppCompatEditText;
import androidx.appcompat.widget.AppCompatImageButton;
import androidx.appcompat.widget.AppCompatTextView;
import androidx.recyclerview.widget.RecyclerView;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.search.SearchValuesModel;

import java.util.Date;
import java.util.function.Consumer;

public class SearchValuesView extends BaseSearchView {
    public static class Attrs {
        public static final int[] Attr = R.styleable.SearchValuesView;

        public static final int Title = R.styleable.SearchValuesView_title;
        public static final int Subtitle = R.styleable.SearchValuesView_subtitle;
        public static final int WithRange = R.styleable.SearchValuesView_withRange;
        public static final int RangeInfo = R.styleable.SearchValuesView_rangeInfo;
        public static final int RangeTitle = R.styleable.SearchValuesView_rangeTitle;
        public static final int WithValues = R.styleable.SearchValuesView_withValues;
        public static final int ValueInfo = R.styleable.SearchValuesView_valueInfo;
        public static final int ValueTitle = R.styleable.SearchValuesView_valueTitle;
    }
    public static class Ids {
        public static final int Layout = R.layout.xtarwarx_view_search_searchvalues;

        public static final int Title_AppCompatTextView = R.id.xtarwarx_view_search_searchvalues_title_appcompattextview;
        public static final int Subtitle_AppCompatTextView = R.id.xtarwarx_view_search_searchvalues_subtitle_appcompattextview;
        public static final int Toggle_AppCompatImageButton = R.id.xtarwarx_view_search_searchvalues_toggle_appcompatimagebutton;
        public static final int Range_Title_AppCompatTextView = R.id.xtarwarx_view_search_searchvalues_range_title_appcompattextview;
        public static final int Range_Info_AppCompatTextView = R.id.xtarwarx_view_search_searchvalues_range_info_appcompattextview;
        public static final int Range_Lower_AppCompatEditText = R.id.xtarwarx_view_search_searchvalues_range_lower_appcompatedittext;
        public static final int Range_Text_AppCompatTextView = R.id.xtarwarx_view_search_searchvalues_range_text_appcompattextview;
        public static final int Range_Upper_AppCompatEditText = R.id.xtarwarx_view_search_searchvalues_range_upper_appcompatedittext;
        public static final int Values_Title_AppCompatTextView = R.id.xtarwarx_view_search_searchvalues_values_title_appcompattextview;
        public static final int Values_Info_AppCompatTextView = R.id.xtarwarx_view_search_searchvalues_values_info_appcompattextview;
        public static final int Value_AppCompatEditText = R.id.xtarwarx_view_search_searchvalues_value_appcompatedittext;
        public static final int ValueAdd_AppCompatImageButton = R.id.xtarwarx_view_search_searchvalues_valueadd_appcompatimagebutton;
        public static final int Values_RecyclerView = R.id.xtarwarx_view_search_searchvalues_values_recyclerview;
    }

    public SearchValuesView(Context context) {
        super(context);
    }
    public SearchValuesView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public SearchValuesView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public SearchValuesView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        inflate(context, Ids.Layout, this);
        super.init(context, attr);

        _Title = findViewById(Ids.Title_AppCompatTextView);
        _Subtitle = findViewById(Ids.Subtitle_AppCompatTextView);
        _Toggle = findViewById(Ids.Toggle_AppCompatImageButton);
        _RangeTitle = findViewById(Ids.Range_Title_AppCompatTextView);
        _RangeInfo = findViewById(Ids.Range_Info_AppCompatTextView);
        _RangeLower = findViewById(Ids.Range_Lower_AppCompatEditText);
        _RangeText = findViewById(Ids.Range_Text_AppCompatTextView);
        _RangeUpper = findViewById(Ids.Range_Upper_AppCompatEditText);
        _ValuesTitle = findViewById(Ids.Values_Title_AppCompatTextView);
        _ValuesInfo = findViewById(Ids.Values_Info_AppCompatTextView);
        _ValueText = findViewById(Ids.Value_AppCompatEditText);
        _ValueAdd = findViewById(Ids.ValueAdd_AppCompatImageButton);
        _Values = findViewById(Ids.Values_RecyclerView);

        _RangeText.setText("-");
        _Toggle.setOnClickListener(view -> toggle(null));

        TypedArray typedArray = getContext().obtainStyledAttributes(attr, Attrs.Attr);

        String title = typedArray.getString(Attrs.Title);
        String subtitle = typedArray.getString(Attrs.Subtitle);
        String rangeInfo = typedArray.getString(Attrs.RangeInfo);
        String rangeTitle = typedArray.getString(Attrs.RangeTitle);
        String valuesInfo = typedArray.getString(Attrs.ValueInfo);
        String valuesTitle = typedArray.getString(Attrs.ValueTitle);

        _withRange = typedArray.getBoolean(Attrs.WithRange, true);
        _withValues = typedArray.getBoolean(Attrs.WithValues, true);

        typedArray.recycle();

        if (title != null) _Title.setText(title);
        if (subtitle != null) _Subtitle.setText(subtitle);
        if (rangeInfo != null) _RangeInfo.setText(rangeInfo);
        if (rangeTitle != null) _RangeTitle.setText(rangeTitle);
        if (valuesInfo != null) _ValuesInfo.setText(valuesInfo);
        if (valuesTitle != null) _ValuesTitle.setText(valuesTitle);

        toggle(true);
    }

    boolean _collapsed;
    boolean _withRange;
    boolean _withValues;

    AppCompatTextView _Title;
    AppCompatTextView _Subtitle;
    AppCompatImageButton _Toggle;
    AppCompatTextView _RangeTitle;
    AppCompatTextView _RangeInfo;
    AppCompatEditText _RangeLower;
    AppCompatTextView _RangeText;
    AppCompatEditText _RangeUpper;
    AppCompatTextView _ValuesTitle;
    AppCompatEditText _ValueText;
    AppCompatTextView _ValuesInfo;
    AppCompatImageButton _ValueAdd;
    RecyclerView _Values;

    SearchValuesModel<?> _SearchValues;
    SearchValuesModel<Color> _SearchValues_Color;
    SearchValuesModel<Date> _SearchValues_Date;
    SearchValuesModel<Double> _SearchValues_Double;
    SearchValuesModel<Float> _SearchValues_Float;
    SearchValuesModel<Integer> _SearchValues_Integer;
    SearchValuesModel<Long> _SearchValues_Long;
    SearchValuesModel<String> _SearchValues_String;

    public void toggle(@Nullable Boolean collapse) {
        int visibility = (_collapsed = collapse == null ? !_collapsed : collapse)
                ? GONE
                : VISIBLE;

        int visibilityRange = !_withRange ? GONE : visibility;
        int visibilityValues = !_withValues ? GONE : visibility;

        _Toggle.setSelected(!_collapsed);
        _Subtitle.setVisibility(visibilityRange);
        _RangeTitle.setVisibility(visibilityRange);
        _RangeInfo.setVisibility(visibilityRange);
        _RangeLower.setVisibility(visibilityRange);
        _RangeText.setVisibility(visibilityRange);
        _RangeUpper.setVisibility(visibilityRange);
        _ValuesTitle.setVisibility(visibilityValues);
        _ValueText.setVisibility(visibilityValues);
        _ValuesInfo.setVisibility(visibilityValues);
        _ValueAdd.setVisibility(visibilityValues);
        _Values.setVisibility(visibilityValues);
    }

    public @Nullable <T> SearchValuesModel<T> getSearchValues(Consumer<SearchValuesConsumer> onget) {
        SearchValuesModel<T> searchvaluescast = (SearchValuesModel<T>)_SearchValues;

        onget.accept(new SearchValuesConsumer(searchvaluescast, this));


        return searchvaluescast;
    }
    public @Nullable SearchValuesModel<Color> getSearchValues_Color() {
        if (_SearchValues_Color != null) {

        }

        return _SearchValues_Color;
    }
    public @Nullable SearchValuesModel<Date> getSearchValues_Date() {
        if (_SearchValues_Date != null) {

        }

        return _SearchValues_Date;
    }
    public @Nullable SearchValuesModel<Double> getSearchValues_Double() {
        if (_SearchValues_Double != null) {

        }

        return _SearchValues_Double;
    }
    public @Nullable SearchValuesModel<Float> getSearchValues_Float() {
        if (_SearchValues_Float != null) {

        }

        return _SearchValues_Float;
    }
    public @Nullable SearchValuesModel<Integer> getSearchValues_Integer() {
        if (_SearchValues_Integer != null) {

        }

        return _SearchValues_Integer;
    }
    public @Nullable SearchValuesModel<Long> getSearchValues_Long() {
        if (_SearchValues_Long != null) {

        }

        return _SearchValues_Long;
    }
    public @Nullable SearchValuesModel<String> getSearchValues_String() {
        if (_SearchValues_String != null) {

        }

        return _SearchValues_String;
    }

    public <T> void setSearchValues(@Nullable SearchValuesModel<T> searchvalues) {

    }
    public void setSearchValues_Color(@Nullable SearchValuesModel<Color> searchvalues) {

    }
    public void setSearchValues_Date(@Nullable SearchValuesModel<Date> searchvalues) {

    }
    public void setSearchValues_Double(@Nullable SearchValuesModel<Double> searchvalues) {

    }
    public void setSearchValues_Float(@Nullable SearchValuesModel<Float> searchvalues) {

    }
    public void setSearchValues_Integer(@Nullable SearchValuesModel<Integer> searchvalues) {

    }
    public void setSearchValues_Long(@Nullable SearchValuesModel<Long> searchvalues) {

    }
    public void setSearchValues_String(@Nullable SearchValuesModel<String> searchvalues) {

    }

    public static class SearchValuesConsumer<T> {
        public SearchValuesConsumer(SearchValuesModel<T> model, SearchValuesView view) {
            _Model = model;
            _View = view;
        }

        public SearchValuesModel<T> _Model;
        public SearchValuesView _View;
    }
}