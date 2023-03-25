package com.xyclonedesigns.xtarwarx.viewmodels.singles;

import android.content.Context;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.TransporterModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.CharacterMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.ManufacturerMultipleViewModel;

abstract class TransporterSingleViewModel<T extends TransporterModel> extends BaseSingleViewModel<T> {
    TransporterSingleViewModel(@NonNull Context context, @NonNull StarWarsRepository repository) {
        super(context, repository);
    }

    public @Nullable ManufacturerMultipleViewModel _Manufacturers;
    public @Nullable CharacterMultipleViewModel _Pilots;
}