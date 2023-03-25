package com.xyclonedesigns.xtarwarx.viewmodels.singles;

import android.content.Context;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.ManufacturerModel;
import com.xyclonedesigns.xtarwarx.repository.models.PlanetModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.StarshipMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.VehicleMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.WeaponMultipleViewModel;

public class ManufacturerSingleViewModel extends BaseSingleViewModel<ManufacturerModel> {
    public ManufacturerSingleViewModel(@NonNull Context context, @NonNull StarWarsRepository repository, @NonNull ManufacturerModel manufacturer) {
        super(context, repository);

        _Manufacturer = manufacturer;
    }

    public @NonNull ManufacturerModel _Manufacturer;
    public @Nullable PlanetSingleViewModel _HeadquartersPlanet;
    public @Nullable StarshipMultipleViewModel _Starships;
    public @Nullable VehicleMultipleViewModel _Vehicles;
    public @Nullable WeaponMultipleViewModel _Weapons;

    @Override
    public void dataRequest() {
        super.dataRequest();

        _Repository.manufacturers().get(this, null, _Manufacturer._Id);
        if (_HeadquartersPlanet != null) _Repository.planets()
                .get(_HeadquartersPlanet, null, _Manufacturer._HeadquartersPlanetId);
        if (_Starships != null) _Repository.starships()
                .get(_Starships, _Starships._Pagination, _Manufacturer._StarshipIds);
        if (_Vehicles != null) _Repository.vehicles()
                .get(_Vehicles, _Vehicles._Pagination, _Manufacturer._WeaponIds);
        if (_Weapons != null) _Repository.weapons()
                .get(_Weapons, _Weapons._Pagination, _Manufacturer._WeaponIds);
    }
    @Override
    public void dataCallback(StarWarsRepository.Data<ManufacturerModel> data) {
        super.dataCallback(data);

        if (!data._Items.isEmpty())
            _Manufacturer = data._Items.get(0);
    }
}