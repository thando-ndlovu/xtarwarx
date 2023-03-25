package com.xyclonedesigns.xtarwarx.viewmodels.singles;

import android.content.Context;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.FilmModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.CharacterMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.FactionMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.ManufacturerMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.PlanetMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.SpecieMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.StarshipMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.VehicleMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.WeaponMultipleViewModel;

import org.jetbrains.annotations.Nullable;

public class FilmSingleViewModel extends BaseSingleViewModel<FilmModel> {
    public FilmSingleViewModel(@NonNull Context context, @NonNull StarWarsRepository repository, @NonNull FilmModel film) {
        super(context, repository);

        _Film = film;
    }

    public @NonNull FilmModel _Film;
    public @Nullable CharacterMultipleViewModel _Characters;
    public @Nullable FactionMultipleViewModel _Factions;
    public @Nullable ManufacturerMultipleViewModel _Manufacturers;
    public @Nullable PlanetMultipleViewModel _Planets;
    public @Nullable SpecieMultipleViewModel _Species;
    public @Nullable StarshipMultipleViewModel _Starships;
    public @Nullable VehicleMultipleViewModel _Vehicles;
    public @Nullable WeaponMultipleViewModel _Weapons;

    @Override
    public void dataRequest() {
        super.dataRequest();

        _Repository.films().get(this, null, _Film._Id);
        if (_Characters != null) _Repository.characters()
            .get(_Characters, _Characters._Pagination, _Film._CharacterIds);
        if (_Factions != null) _Repository.factions()
            .get(_Factions, _Factions._Pagination, _Film._FactionIds);
        if (_Manufacturers != null) _Repository.manufacturers()
            .get(_Manufacturers, _Manufacturers._Pagination, _Film._ManufacturerIds);
        if (_Planets != null) _Repository.planets()
            .get(_Planets, _Planets._Pagination, _Film._PlanetIds);
        if (_Species != null) _Repository.species()
            .get(_Species, _Species._Pagination, _Film._SpecieIds);
        if (_Starships != null) _Repository.starships()
            .get(_Starships, _Starships._Pagination, _Film._StarshipIds);
        if (_Vehicles != null) _Repository.vehicles()
            .get(_Vehicles, _Vehicles._Pagination, _Film._WeaponIds);
        if (_Weapons != null) _Repository.weapons()
            .get(_Weapons, _Weapons._Pagination, _Film._WeaponIds);
    }
    @Override
    public void dataCallback(StarWarsRepository.Data<FilmModel> data) {
        super.dataCallback(data);

        if (!data._Items.isEmpty())
            _Film = data._Items.get(0);
    }
}