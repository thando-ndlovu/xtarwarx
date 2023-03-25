package com.xyclonedesigns.xtarwarx.fragments.multiples;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.fragments.BaseModelFragment;
import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.StarWarsModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.BaseMultipleViewModel;
import com.xyclonedesigns.xtarwarx.views.insets.NavigationBarInsetView;
import com.xyclonedesigns.xtarwarx.views.page.ItemsVerticalPageView;
import com.xyclonedesigns.xtarwarx.widgets.recyclerview.PageItemsRecyclerView;

public class BaseMultipleFragment<TModel extends StarWarsModel, TViewModel extends BaseMultipleViewModel<TModel>> extends BaseModelFragment {
    public BaseMultipleFragment(int textRes, int iconRes){
        super();

        _IconRes = iconRes;
        _TextRes = textRes;
        _PageViewItemsAdapter = new ItemsVerticalPageView.ItemsAdapter<TModel>() {
            @Override
            public void onBindViewHolder(@NonNull PageItemsRecyclerView.ItemsViewHolder holder, int position) {
                onPageViewItemsBindViewHolder(holder, position);

                if (position == getItemCount() - 1 && _FooterView == _PageView._PaginationPages)
                    _PageView._PaginationPages.setViewModel(_PageView._PaginationPages.getViewModel());
            }
        };
    }

    public int _IconRes;
    public int _TextRes;
    public @Nullable TViewModel _ViewModel;
    public @Nullable ItemsVerticalPageView _PageView;
    public @NonNull ItemsVerticalPageView.ItemsAdapter<TModel> _PageViewItemsAdapter;

    public @Nullable PageItemsRecyclerView.ItemsViewHolder.OnClickListener<TModel> _PageViewItemsOnClickListener;
    public @Nullable PageItemsRecyclerView.ItemsViewHolder.OnLongClickListener<TModel> _PageViewItemsOnLongClickListener;

    protected void onDataCallback(StarWarsRepository.Data<TModel> data) {
        if (_PageView != null && _ViewModel != null) {
            _PageView._PaginationOptions.setViewModel(_ViewModel._Pagination);
            _PageView._PaginationPages.setViewModel(_ViewModel._Pagination);
            _PageView._Items.smoothScrollToPosition(0);
            _PageView.setModels(data._Items);
        }
    }
    protected void onPageViewItemsBindViewHolder(@NonNull PageItemsRecyclerView.ItemsViewHolder<TModel> holder, int position) {
        holder.setOnClickListener(_PageViewItemsOnClickListener);
        holder.setOnLongClickListener(_PageViewItemsOnLongClickListener);
    }

    @Override
    public void refresh(boolean force) {
        super.refresh(force);

        if (_ViewModel != null)
            _ViewModel.dataRequest();
    }
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        super.onCreateView(inflater, container, savedInstanceState);

        if (_PageView == null)
            _PageView = new ItemsVerticalPageView(getContext());

        _PageView._Items.setPadding(
                _PageView._Items.getPaddingLeft(),
                _PageView._Items.getPaddingTop(),
                _PageView._Items.getPaddingRight(),
                _PageView._Items.getPaddingBottom() + NavigationBarInsetView.getPixelHeight(inflater.getContext())
        );
        _PageView._Items.setItemsAdapter(_PageViewItemsAdapter);
        _PageView._Items._MarginItemDecoration._FooterView =
        _PageViewItemsAdapter._FooterView =
        _PageView._PaginationPages;

        return _PageView;
    }
}