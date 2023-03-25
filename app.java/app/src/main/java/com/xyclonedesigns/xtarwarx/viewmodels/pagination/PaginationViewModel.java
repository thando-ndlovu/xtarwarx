package com.xyclonedesigns.xtarwarx.viewmodels.pagination;

import android.content.Context;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.viewmodels.BaseViewModel;

public class PaginationViewModel extends BaseViewModel {
    public PaginationViewModel(@NonNull Context context, @NonNull StarWarsRepository repository) {
        super(context, repository);
    }

    public int _Page;
    public int _Pages;
    public int _ItemsPerPage;
    public int[] _ItemsPerPages;
    public String _SortKey;
    public String[] _SortKeys;
    public boolean _Reverse;

    public CharSequence[] _SortKeysTitles;
}