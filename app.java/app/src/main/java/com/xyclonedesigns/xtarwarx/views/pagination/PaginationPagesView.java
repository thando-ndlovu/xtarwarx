package com.xyclonedesigns.xtarwarx.views.pagination;

import android.content.Context;
import android.content.res.Configuration;
import android.graphics.Color;
import android.graphics.Rect;
import android.util.AttributeSet;
import android.view.ContextThemeWrapper;
import android.view.Gravity;
import android.view.View;
import android.view.ViewGroup;
import android.widget.RelativeLayout;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.widget.AppCompatButton;
import androidx.appcompat.widget.LinearLayoutCompat;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.viewmodels.pagination.PaginationViewModel;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Objects;
import java.util.function.Consumer;

public class PaginationPagesView extends RelativeLayout {
    public static class Ids {
        public static final int Layout = R.layout.xtarwarx_view_pagination_pages;
        public static final int Pages_RecyclerView = R.id.xtarwarx_view_pagination_pages_recyclerview;
    }

    public PaginationPagesView(Context context) {
        this(context, null);
    }
    public PaginationPagesView(Context context, AttributeSet attr) {
        this(context, attr, R.style.XtarWarx_View_Pagination_Pages);
    }
    public PaginationPagesView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);

        inflate(context, Ids.Layout, this);

        _Pages = findViewById(Ids.Pages_RecyclerView);
        _Pages.setAdapter(new Adapter());
        _Pages.setLayoutManager(new LayoutManager(context));
        _Pages.addItemDecoration(new ItemDecoration());
    }

    public RecyclerView _Pages;

    @NonNull
    public Adapter getPagesAdapter() {
        return (Adapter) Objects.requireNonNull(_Pages.getAdapter());
    }

    public PaginationViewModel getViewModel() {
        return getPagesAdapter().getViewModel();
    }
    public void setViewModel(PaginationViewModel viewModel) {
        getPagesAdapter().setViewModel(viewModel);
    }

    public static class Adapter extends RecyclerView.Adapter<ViewHolder> implements View.OnClickListener {
        PaginationViewModel _ViewModel;
        ViewHolderView _SelectedView;

        public PaginationViewModel getViewModel() {
            return _ViewModel;
        }
        public void setViewModel(PaginationViewModel viewModel) {
            _ViewModel = viewModel;

            notifyDataSetChanged();
        }

        @Override
        public int getItemCount() {
            if (_ViewModel == null)
                return 0;

            return _ViewModel._Pages;
        }
        @Override
        public void onBindViewHolder(@NonNull ViewHolder holder, int position) {
            holder._ViewHolderView._Page = position + 1;

            holder._ViewHolderView.setText(String.valueOf(holder._ViewHolderView._Page));
            holder._ViewHolderView.setSelected(holder._ViewHolderView._Page == _ViewModel._Page);

            if (holder._ViewHolderView.isSelected())
                _SelectedView = holder._ViewHolderView;
        }
        @NonNull
        @Override
        public ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
            ViewHolder viewholder = new ViewHolder(parent.getContext());

            viewholder._ViewHolderView.setOnClickListener(this);

            return viewholder;
        }
        @Override
        public void onClick(View view) {
            ViewHolderView viewholderview = (ViewHolderView)view;

            if (viewholderview._Page == _ViewModel._Page)
                return;

            viewholderview.setSelected(true);
            _SelectedView.setSelected(false);
            _SelectedView = viewholderview;
            _ViewModel._Page = _SelectedView._Page;
            _ViewModel.dataRequest();
        }
    }
    public static class ItemDecoration extends RecyclerView.ItemDecoration {
        @Override
        public void getItemOffsets(@NonNull Rect outRect, @NonNull View view, @NonNull RecyclerView parent, @NonNull RecyclerView.State state) {
            super.getItemOffsets(outRect, view, parent, state);

            int
                    position = parent.getChildAdapterPosition(view) + 1,
                    size = view.getResources().getDimensionPixelSize(R.dimen.dp8);
            boolean
                    isfirst = position == 0,
                    islast = parent.getAdapter() != null && parent.getAdapter().getItemCount() == position,
                    isRtL = parent.getResources().getConfiguration().getLayoutDirection() == Configuration.SCREENLAYOUT_LAYOUTDIR_RTL;

            outRect.top = size;
            outRect.bottom = size;
            outRect.left = isfirst && !isRtL ? size : size / 2;
            outRect.right =  islast && !isRtL ? size : size / 2;
        }
    }
    public static class LayoutManager extends LinearLayoutManager {
        public LayoutManager(Context context) {
            super(context, HORIZONTAL, false);
        }
    }
    public static class ViewHolder extends RecyclerView.ViewHolder {
        public ViewHolder(@NonNull Context context) {
            this(new ViewHolderView(context));
        }
        public ViewHolder(@NonNull ViewHolderView itemView) {
            super(itemView);

            _ViewHolderView = itemView;
        }

        public ViewHolderView _ViewHolderView;
    }
    public static class ViewHolderView extends AppCompatButton {
        public ViewHolderView(@NonNull Context context) {
            this(context, null);
        }
        public ViewHolderView(@NonNull Context context, @Nullable AttributeSet attrs) {
            this(new ContextThemeWrapper(context, R.style.XtarWarx_View_Pagination_Pages_Button), attrs, R.style.XtarWarx_View_Pagination_Pages_Button);
        }
        public ViewHolderView(@NonNull Context context, @Nullable AttributeSet attrs, int defStyleAttr) {
            super(context, attrs, defStyleAttr);
        }

        int _Page;
    }
}