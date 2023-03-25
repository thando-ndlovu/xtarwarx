package com.xyclonedesigns.xtarwarx.viewmodels.multiples;

import android.content.Context;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.StarWarsModel;
import com.xyclonedesigns.xtarwarx.viewmodels.BaseViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.pagination.PaginationViewModel;

import java.util.ArrayList;
import java.util.List;

public class BaseMultipleViewModel<T extends StarWarsModel> extends BaseViewModel<T> {
    public BaseMultipleViewModel(@NonNull Context context, @NonNull StarWarsRepository repository) {
        super(context, repository);

        _Pagination = new PaginationViewModel(context, repository) {
            @Override
            public void dataRequest() {
                super.dataRequest();
                BaseMultipleViewModel.this.dataRequest();
            }
        };
        _Pagination._ItemsPerPage = 10;
        _Pagination._ItemsPerPages = new int[] { 5, 10, 20, 50 };
        _Pagination._Page = 1;
        _Pagination._Reverse = false;
    }

    protected @NonNull List<T> _Models = new ArrayList<>();

    public @NonNull PaginationViewModel _Pagination;
    public @NonNull List<T> getModels() { return _Models; }

    @Override
    public void dataCallback(StarWarsRepository.Data<T> data) {
        super.dataCallback(data);

        _Pagination._Page = data._Page;
        _Pagination._Pages = data._Pages;
    }
}