package com.xyclonedesigns.xtarwarx.views.pagination;

import android.content.Context;
import android.util.AttributeSet;
import android.widget.HorizontalScrollView;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.viewmodels.pagination.PaginationViewModel;

public class BasePaginationView extends HorizontalScrollView {
    public BasePaginationView(Context context) {
        this(context, null);
    }
    public BasePaginationView(Context context, AttributeSet attr) {
        this(context, attr, R.style.XtarWarx_View_Pagination);
    }
    public BasePaginationView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
        init(context, attr);
    }

    protected void init(Context context, AttributeSet attr) { }

    protected PaginationViewModel _ViewModel;
    public PaginationViewModel getViewModel() {
        return _ViewModel;
    }
    public void setViewModel(PaginationViewModel viewModel) {
        _ViewModel = viewModel;
    }
}