package com.xyclonedesigns.xtarwarx.views.search;

import android.content.Context;
import android.util.AttributeSet;
import android.view.View;
import android.widget.ScrollView;

import androidx.annotation.Nullable;
import androidx.constraintlayout.widget.ConstraintLayout;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.views.page.ItemsVerticalPageView;

public class SearchResultsView extends BaseSearchView {
    public static class Ids {
        public static final int Layout = R.layout.xtarwarx_view_search_searchresults;

        public static final int SearchOptions_ScrollView = R.id.xtarwarx_view_search_searchresults_searchoptions_scrollview;
        public static final int SearchOptionsBottomFade_View = R.id.xtarwarx_view_search_searchresults_searchoptions_scrollview_bottomfade;
        public static final int SearchOptionsTopFade_View = R.id.xtarwarx_view_search_searchresults_searchoptions_scrollview_topfade;
        public static final int SearchResults_ItemsVerticalPageView = R.id.xtarwarx_view_search_searchresults_searchresults_itemsverticalpageview;
    }

    public SearchResultsView(Context context) {
        super(context);
    }
    public SearchResultsView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public SearchResultsView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public SearchResultsView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        inflate(context, Ids.Layout, this);
        super.init(context, attr);

        _SearchOptions = findViewById(Ids.SearchOptions_ScrollView);
        _SearchOptionsBottomFade = findViewById(Ids.SearchOptionsBottomFade_View);
        _SearchOptionsTopFade = findViewById(Ids.SearchOptionsTopFade_View);
        _SearchResults = findViewById(Ids.SearchResults_ItemsVerticalPageView);

        setSearchOptionsView(null);
    }

    public ScrollView _SearchOptions;
    public View _SearchOptionsBottomFade;
    public View _SearchOptionsTopFade;
    public ItemsVerticalPageView _SearchResults;

    public void setSearchOptionsView(@Nullable View view) {
        _SearchOptions.removeAllViews();

        if (view == null) {
            _SearchOptions.setVisibility(GONE);
            _SearchOptionsBottomFade.setVisibility(GONE);
            _SearchOptionsTopFade.setVisibility(GONE);
        } else {
            _SearchOptions.setVisibility(VISIBLE);
            _SearchOptionsBottomFade.setVisibility(VISIBLE);
            _SearchOptionsTopFade.setVisibility(VISIBLE);
            _SearchOptions.addView(view);
        }
    }
}