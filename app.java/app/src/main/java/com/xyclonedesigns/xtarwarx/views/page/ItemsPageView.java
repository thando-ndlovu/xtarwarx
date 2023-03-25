package com.xyclonedesigns.xtarwarx.views.page;

import android.content.Context;
import android.content.res.TypedArray;
import android.util.AttributeSet;
import android.view.View;

import androidx.annotation.Nullable;
import androidx.appcompat.widget.AppCompatImageButton;
import androidx.appcompat.widget.AppCompatTextView;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.models.StarWarsModel;
import com.xyclonedesigns.xtarwarx.views.pagination.PaginationOptionsView;
import com.xyclonedesigns.xtarwarx.views.pagination.PaginationPagesView;
import com.xyclonedesigns.xtarwarx.widgets.recyclerview.PageItemsRecyclerView;

import java.util.List;

public class ItemsPageView extends BasePageView implements View.OnClickListener {
    public static class Attrs {
        public static final int[] Attr = R.styleable.ItemsPageView;

        public static final int Title = R.styleable.ItemsPageView_title;
        public static final int Subtitle = R.styleable.ItemsPageView_subtitle;
        public static final int EmptyText = R.styleable.ItemsPageView_emptyText;
        public static final int IsExternalLinks = R.styleable.ItemsPageView_isExternalLinks;
        public static final int WithOption = R.styleable.ItemsPageView_withOption;
        public static final int WithRefresh = R.styleable.ItemsPageView_withRefresh;
        public static final int WithPagination = R.styleable.ItemsPageView_withPagination;
    }

    public ItemsPageView(Context context) {
        super(context);
    }
    public ItemsPageView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public ItemsPageView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public ItemsPageView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        super.init(context, attr);

        TypedArray a = getContext().obtainStyledAttributes(attr, Attrs.Attr);

        String title = a.getString(Attrs.Title);
        String subtitle = a.getString(Attrs.Subtitle);
        String emptytext = a.getString(Attrs.EmptyText);

        if (title == null)
            _Title.setVisibility(GONE);
        else _Title.setText(title);
        if (subtitle == null) {
            _Title.setPadding(0, getResources().getDimensionPixelSize(R.dimen.dp8), 0, 0);
            _Subtitle.setVisibility(GONE);
        } else _Subtitle.setText(subtitle);
        if (emptytext != null)
            _Empty.setText(emptytext);

        setModels(null);

        _IsExternalLinks = a.getBoolean(Attrs.IsExternalLinks, false);

        if (a.getBoolean(Attrs.WithPagination, true)) {
            _PaginationOptions.setVisibility(GONE);
            _PaginationOptionsButton.setVisibility(VISIBLE);
            _PaginationPages.setVisibility(VISIBLE);
        } else {
            if (_PaginationOptions != null) {
                _PaginationOptions.setVisibility(GONE);
                _PaginationOptionsButton.setVisibility(GONE);
            }
            if (_PaginationPages != null)
                _PaginationPages.setVisibility(GONE);
        }

        a.recycle();
    }
    @Override
    protected void onAttachedToWindow() {
        super.onAttachedToWindow();

        _PaginationOptionsButton.setOnClickListener(this);
    }
    @Override
    protected void onDetachedFromWindow() {
        super.onDetachedFromWindow();

        _PaginationOptionsButton.setOnClickListener(null);
    }

    @Override
    public void onClick(View view) {
        if (view == _PaginationOptionsButton)
            if (_PaginationOptions.getVisibility() == GONE) {
                _PaginationOptions.setVisibility(VISIBLE);
                _PaginationOptionsButton.setSelected(true);
            }
            else {
                _PaginationOptions.setVisibility(GONE);
                _PaginationOptionsButton.setSelected(false);
            }
    }
    public <T extends StarWarsModel> void setModels(@Nullable List<T> models) {
        if (_Items.getItemsAdapter() == null)
            return;

        if (models == null) {
            if (_Empty.getText().length() > 0)
                _Empty.setVisibility(VISIBLE);
            _Items.getItemsAdapter()._Items.clear();
        } else {
            _Empty.setVisibility(GONE);
            _Items.getItemsAdapter()._Items = models;
        }

        _Items.getItemsAdapter().notifyDataSetChanged();
    }

    public boolean _IsExternalLinks;

    public AppCompatTextView _Title;
    public AppCompatTextView _Subtitle;
    public AppCompatTextView _Empty;
    public PageItemsRecyclerView _Items;
    public PaginationOptionsView _PaginationOptions;
    public AppCompatImageButton _RefreshButton;
    public AppCompatImageButton _PaginationOptionsButton;
    public PaginationPagesView _PaginationPages;
}