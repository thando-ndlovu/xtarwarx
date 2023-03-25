package com.xyclonedesigns.xtarwarx.views.page;

import android.content.Context;
import android.util.AttributeSet;
import android.view.View;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.models.StarWarsModel;
import com.xyclonedesigns.xtarwarx.views.pagination.PaginationPagesView;
import com.xyclonedesigns.xtarwarx.widgets.recyclerview.PageItemsRecyclerView;

import java.util.ArrayList;

public class ItemsVerticalPageView extends ItemsPageView {
    public static class Ids {
        public static final int Layout = R.layout.xtarwarx_view_page_itemsvertical;

        public static final int Title_AppCompatTextView = R.id.xtarwarx_view_page_itemsvertical_title_appcompattextview;
        public static final int Subtitle_AppCompatTextView = R.id.xtarwarx_view_page_itemsvertical_subtitle_appcompattextview;
        public static final int Empty_AppCompatTextView = R.id.xtarwarx_view_page_itemsvertical_empty_appcompattextview;
        public static final int PaginationOptions_AppCompatImageButton = R.id.xtarwarx_view_page_itemsvertical_paginationoptions_appcompatimagebutton;
        public static final int PaginationOptions_PaginationOptionsView = R.id.xtarwarx_view_page_itemsvertical_paginationoptions_paginationoptionsview;
        public static final int Items_PageItemsRecyclerView = R.id.xtarwarx_view_page_itemsvertical_items_pageitemsrecyclerview;
    }

    public ItemsVerticalPageView(Context context) {
        super(context);
    }
    public ItemsVerticalPageView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public ItemsVerticalPageView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public ItemsVerticalPageView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        inflate(context, Ids.Layout, this);

        _Title = findViewById(Ids.Title_AppCompatTextView);
        _Subtitle = findViewById(Ids.Subtitle_AppCompatTextView);
        _Empty = findViewById(Ids.Empty_AppCompatTextView);
        _PaginationOptionsButton = findViewById(Ids.PaginationOptions_AppCompatImageButton);
        _PaginationOptions = findViewById(Ids.PaginationOptions_PaginationOptionsView);
        _Items = findViewById(Ids.Items_PageItemsRecyclerView);
        _PaginationPages = new PaginationPagesView(context, null, R.style.XtarWarx_View_Page_Items_PaginationPages);
        _PaginationPages.setLayoutParams(new ItemsPageView.LayoutParams(ViewGroup.LayoutParams.MATCH_PARENT, ViewGroup.LayoutParams.WRAP_CONTENT));

        super.init(context, attr);

        _Items.setLayoutManager(new ItemsLayoutManager(context));
    }

    public abstract static class ItemsAdapter<T extends StarWarsModel> extends PageItemsRecyclerView.ItemsAdapter<T> {
        public ItemsAdapter() {
            super();
        }
        public ItemsAdapter(ArrayList<T> items) {
            super(items);
        }
        public ItemsAdapter(@Nullable ArrayList<T> items, @Nullable View headerView, @Nullable View footerView) {
            super(items, headerView, footerView);
        }

        @NonNull
        @Override
        public PageItemsRecyclerView.ItemsViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
            if (viewType == ItemViewType_Header && _HeaderView != null)
                return new PageItemsRecyclerView.ItemsViewHolder(_HeaderView);

            if (viewType == ItemViewType_Footer && _FooterView != null)
                return new PageItemsRecyclerView.ItemsViewHolder(_FooterView);

            PageItemVerticalView view = new PageItemVerticalView(parent.getContext());
            view.setLayoutParams(new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MATCH_PARENT, ViewGroup.LayoutParams.WRAP_CONTENT));

            return new PageItemsRecyclerView.ItemsViewHolder(view);
        }
        @Override
        public abstract void onBindViewHolder(@NonNull PageItemsRecyclerView.ItemsViewHolder holder, int position);
    }
    public static class ItemsLayoutManager extends LinearLayoutManager {
        public ItemsLayoutManager(Context context) {
            this(context, LinearLayoutManager.VERTICAL, false);
        }
        public ItemsLayoutManager(Context context, int orientation, boolean reverseLayout) {
            super(context, orientation, reverseLayout);
        }
        public ItemsLayoutManager(Context context, AttributeSet attrs, int defStyleAttr, int defStyleRes) {
            super(context, attrs, defStyleAttr, defStyleRes);
        }

        @Override
        public void onLayoutChildren(RecyclerView.Recycler recycler, RecyclerView.State state) {
            try { super.onLayoutChildren(recycler, state); }
            catch (IndexOutOfBoundsException x)
            {
                // IndexOutOfBoundsException Exception on sucessive list refreshes
                // https://stackoverflow.com/questions/31759171/recyclerview-and-java-lang-indexoutofboundsexception-inconsistency-detected-in
            }
        }
    }
}