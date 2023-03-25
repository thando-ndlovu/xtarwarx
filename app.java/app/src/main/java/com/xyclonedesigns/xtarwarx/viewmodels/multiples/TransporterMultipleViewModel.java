package com.xyclonedesigns.xtarwarx.viewmodels.multiples;

import android.content.Context;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.TransporterModel;

public class TransporterMultipleViewModel<T extends TransporterModel> extends BaseMultipleViewModel<T> {
    public TransporterMultipleViewModel(@NonNull Context context, @NonNull StarWarsRepository repository) {
        super(context, repository);
    }
}