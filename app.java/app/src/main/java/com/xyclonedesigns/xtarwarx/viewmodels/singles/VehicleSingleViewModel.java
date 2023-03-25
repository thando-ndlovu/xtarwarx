package com.xyclonedesigns.xtarwarx.viewmodels.singles;

import android.content.Context;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.VehicleModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.CharacterMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.ManufacturerMultipleViewModel;

public class VehicleSingleViewModel extends TransporterSingleViewModel<VehicleModel> {
    public VehicleSingleViewModel(@NonNull Context context, @NonNull StarWarsRepository repository, @NonNull VehicleModel vehicle) {
        super(context, repository);

        _Vehicle = vehicle;
    }

    public @NonNull VehicleModel _Vehicle;

    @Override
    public void dataRequest() {
        super.dataRequest();

        _Repository.vehicles().get(this, null, _Vehicle._Id);
        if (_Pilots != null) _Repository.characters()
            .get(_Pilots, _Pilots._Pagination, _Vehicle._PilotIds);
        if (_Manufacturers != null) _Repository.manufacturers()
            .get(_Manufacturers, _Manufacturers._Pagination, _Vehicle._ManufacturerIds);
    }
    @Override
    public void dataCallback(StarWarsRepository.Data<VehicleModel> data) {
        super.dataCallback(data);

        if (!data._Items.isEmpty())
            _Vehicle = data._Items.get(0);
    }
}