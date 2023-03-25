package com.xyclonedesigns.xtarwarx.viewmodels.multiples;

import android.content.Context;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.FilmModel;

public class FilmMultipleViewModel extends BaseMultipleViewModel<FilmModel> {
    public FilmMultipleViewModel(@NonNull Context context, @NonNull StarWarsRepository repository) {
        super(context, repository);

        _Pagination._SortKey = FilmModel.SortKeys.Title;
        _Pagination._SortKeys = FilmModel.SortKeys.asArray();
        _Pagination._SortKeysTitles = FilmModel.SortKeys.asArrayTitles(_Context);
    }

    @Override
    public void dataRequest() {
        super.dataRequest();

        _Repository.films().get(this, _Pagination);
    }
}