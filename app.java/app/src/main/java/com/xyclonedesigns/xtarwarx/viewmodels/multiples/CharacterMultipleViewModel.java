package com.xyclonedesigns.xtarwarx.viewmodels.multiples;

import android.content.Context;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.CharacterModel;

public class CharacterMultipleViewModel extends BaseMultipleViewModel<CharacterModel> {
    public CharacterMultipleViewModel(@NonNull Context context, @NonNull StarWarsRepository repository) {
        super(context, repository);

        _Pagination._SortKey = CharacterModel.SortKeys.Name;
        _Pagination._SortKeys = CharacterModel.SortKeys.asArray();
        _Pagination._SortKeysTitles = CharacterModel.SortKeys.asArrayTitles(_Context);
    }

    @Override
    public void dataRequest() {
        super.dataRequest();

        _Repository.characters().get(this, _Pagination);
    }
}