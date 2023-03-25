package com.xyclonedesigns.xtarwarx.viewmodels.multiples;

import android.content.Context;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.CharacterModel;
import com.xyclonedesigns.xtarwarx.repository.models.StarWarsModel;
import com.xyclonedesigns.xtarwarx.repository.search.SearchModel;
import com.xyclonedesigns.xtarwarx.viewmodels.BaseViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.BaseMultipleViewModel;

import java.util.ArrayList;

public class SearchResultsViewModel extends BaseMultipleViewModel<StarWarsModel> {
    public SearchResultsViewModel(@NonNull Context context, @NonNull StarWarsRepository repository) {
        super(context, repository);

        _Search = new SearchModel();
    }

    public @NonNull SearchModel _Search;

    @Override
    public void dataRequest() {
        super.dataRequest();

        _Repository.search().get(this::dataCallbackSearchResults, _Search);
    }
    @Override
    public void dataCallback(StarWarsRepository.Data<StarWarsModel> data) { }
    public void dataCallbackSearchResults(StarWarsRepository.Data<SearchModel.Result> data) {
        _Pagination._Page = data._Page;
        _Pagination._Pages = data._Pages;
    }
}