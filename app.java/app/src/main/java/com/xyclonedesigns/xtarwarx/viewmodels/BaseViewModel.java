package com.xyclonedesigns.xtarwarx.viewmodels;

import android.content.Context;

import androidx.annotation.NonNull;
import androidx.lifecycle.ViewModel;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.StarWarsModel;

public class BaseViewModel<T> extends ViewModel
        implements StarWarsRepository.DataRequest<T>, StarWarsRepository.DataCallback<T> {
    public BaseViewModel(@NonNull Context context, @NonNull StarWarsRepository repository) {
        _Context = context;
        _Repository = repository;
    }

    public @NonNull Context _Context;
    public @NonNull StarWarsRepository _Repository;

    @Override
    public void dataRequest() { }
    @Override
    public void dataCallback(StarWarsRepository.Data<T> data) { }
}