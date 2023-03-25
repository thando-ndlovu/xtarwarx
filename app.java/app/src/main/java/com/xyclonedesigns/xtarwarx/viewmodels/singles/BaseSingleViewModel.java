package com.xyclonedesigns.xtarwarx.viewmodels.singles;

import android.content.Context;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.StarWarsModel;
import com.xyclonedesigns.xtarwarx.viewmodels.BaseViewModel;

public class BaseSingleViewModel<T extends StarWarsModel> extends BaseViewModel<T> {
    public BaseSingleViewModel(@NonNull Context context, @NonNull StarWarsRepository repository) {
        super(context, repository);
    }
}