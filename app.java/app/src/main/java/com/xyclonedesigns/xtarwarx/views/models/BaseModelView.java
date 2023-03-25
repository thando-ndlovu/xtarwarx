package com.xyclonedesigns.xtarwarx.views.models;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.constraintlayout.widget.ConstraintLayout;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.models.StarWarsModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.BaseMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.CharacterMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.FactionMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.FilmMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.ManufacturerMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.PlanetMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.SpecieMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.StarshipMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.VehicleMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.WeaponMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.CharacterSingleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.FactionSingleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.FilmSingleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.ManufacturerSingleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.PlanetSingleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.SpecieSingleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.StarshipSingleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.VehicleSingleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.WeaponSingleViewModel;
import com.xyclonedesigns.xtarwarx.views.page.ImagesHorizontalPageView;
import com.xyclonedesigns.xtarwarx.views.page.ItemsPageView;

import java.util.Collections;

public class BaseModelView extends ConstraintLayout {
    public BaseModelView(Context context) {
        this(context, null);
    }
    public BaseModelView(Context context, AttributeSet attr) {
        this(context, attr, R.style.XtarWarx_View_Model);
    }
    public BaseModelView(Context context, AttributeSet attr, int styleResId) {
        this(context, attr, styleResId, R.style.XtarWarx_View_Model);
    }
    public BaseModelView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
        init(context, attr);
    }

    protected void init(Context context, AttributeSet attr) {
        if (_ExternalLinks != null)
            _ExternalLinks._Title.setVisibility(GONE);
    }
    protected void setNull(@NonNull ItemsPageView itemspageview) {
        itemspageview.setModels(null);
        itemspageview._PaginationOptions.setViewModel(null);
        itemspageview._PaginationPages.setViewModel(null);
    }
    protected <T extends StarWarsModel> void set(@Nullable BaseMultipleViewModel<T> multiple, @NonNull ItemsPageView itemspageview) {
        if (multiple == null)
            setNull(itemspageview);
        else {
            if (itemspageview._RefreshButton != null)
                itemspageview._RefreshButton.setOnClickListener(view -> multiple.dataRequest());
            itemspageview._Items.scrollToPosition(0);
            itemspageview.setModels(multiple.getModels());
            itemspageview._PaginationOptions.setViewModel(multiple._Pagination);
            itemspageview._PaginationPages.setViewModel(multiple._Pagination);
        }
    }

    protected void setCharacter(@Nullable CharacterSingleViewModel character, @NonNull ItemsPageView itemspageview) {
        if (character == null)
            setNull(itemspageview);
        else {
            if (itemspageview._RefreshButton != null)
                itemspageview._RefreshButton.setOnClickListener(view -> character.dataRequest());
            itemspageview._Items.scrollToPosition(0);
            itemspageview.setModels(Collections.singletonList(character._Character));
        }
    }
    protected void setCharacters(@Nullable CharacterMultipleViewModel characters, @NonNull ItemsPageView itemspageview) {
        set(characters, itemspageview);
    }
    protected void setFaction(@Nullable FactionSingleViewModel faction, @NonNull ItemsPageView itemspageview) {
        if (faction == null)
            setNull(itemspageview);
        else {
            if (itemspageview._RefreshButton != null)
                itemspageview._RefreshButton.setOnClickListener(view -> faction.dataRequest());
            itemspageview._Items.scrollToPosition(0);
            itemspageview.setModels(Collections.singletonList(faction._Faction));
        }
    }
    protected void setFactions(@Nullable FactionMultipleViewModel factions, @NonNull ItemsPageView itemspageview) {
        set(factions, itemspageview);
    }
    protected void setFilm(@Nullable FilmSingleViewModel film, @NonNull ItemsPageView itemspageview) {
        if (film == null)
            setNull(itemspageview);
        else {
            if (itemspageview._RefreshButton != null)
                itemspageview._RefreshButton.setOnClickListener(view -> film.dataRequest());
            itemspageview._Items.scrollToPosition(0);
            itemspageview.setModels(Collections.singletonList(film._Film));
        }
    }
    protected void setFilms(@Nullable FilmMultipleViewModel films, @NonNull ItemsPageView itemspageview) {
        set(films, itemspageview);
    }
    protected void setManufacturer(@Nullable ManufacturerSingleViewModel manufacturer, @NonNull ItemsPageView itemspageview) {
        if (manufacturer == null)
            setNull(itemspageview);
        else {
            if (itemspageview._RefreshButton != null)
                itemspageview._RefreshButton.setOnClickListener(view -> manufacturer.dataRequest());
            itemspageview._Items.scrollToPosition(0);
            itemspageview.setModels(Collections.singletonList(manufacturer._Manufacturer));
        }
    }
    protected void setManufacturers(@Nullable ManufacturerMultipleViewModel manufacturers, @NonNull ItemsPageView itemspageview) {
        set(manufacturers, itemspageview);
    }
    protected void setPlanet(@Nullable PlanetSingleViewModel planet, @NonNull ItemsPageView itemspageview) {
        if (planet == null)
            setNull(itemspageview);
        else {
            if (itemspageview._RefreshButton != null)
                itemspageview._RefreshButton.setOnClickListener(view -> planet.dataRequest());
            itemspageview._Items.scrollToPosition(0);
            itemspageview.setModels(Collections.singletonList(planet._Planet));
        }
    }
    protected void setPlanets(@Nullable PlanetMultipleViewModel planets, @NonNull ItemsPageView itemspageview) {
        set(planets, itemspageview);
    }
    protected void setSpecie(@Nullable SpecieSingleViewModel specie, @NonNull ItemsPageView itemspageview) {
        if (specie == null)
            setNull(itemspageview);
        else {
            if (itemspageview._RefreshButton != null)
                itemspageview._RefreshButton.setOnClickListener(view -> specie.dataRequest());
            itemspageview._Items.scrollToPosition(0);
            itemspageview.setModels(Collections.singletonList(specie._Specie));
        }
    }
    protected void setSpecies(@Nullable SpecieMultipleViewModel species, @NonNull ItemsPageView itemspageview) {
        set(species, itemspageview);
    }
    protected void setStarship(@Nullable StarshipSingleViewModel starship, @NonNull ItemsPageView itemspageview) {
        if (starship == null)
            setNull(itemspageview);
        else {
            if (itemspageview._RefreshButton != null)
                itemspageview._RefreshButton.setOnClickListener(view -> starship.dataRequest());
            itemspageview._Items.scrollToPosition(0);
            itemspageview.setModels(Collections.singletonList(starship._Starship));
        }
    }
    protected void setStarships(@Nullable StarshipMultipleViewModel starships, @NonNull ItemsPageView itemspageview) {
        set(starships, itemspageview);
    }
    protected void setVehicle(@Nullable VehicleSingleViewModel vehicle, @NonNull ItemsPageView itemspageview) {
        if (vehicle == null)
            setNull(itemspageview);
        else {
            if (itemspageview._RefreshButton != null)
                itemspageview._RefreshButton.setOnClickListener(view -> vehicle.dataRequest());
            itemspageview._Items.scrollToPosition(0);
            itemspageview.setModels(Collections.singletonList(vehicle._Vehicle));
        }
    }
    protected void setVehicles(@Nullable VehicleMultipleViewModel vehicles, @NonNull ItemsPageView itemspageview) {
        set(vehicles, itemspageview);
    }
    protected void setWeapon(@Nullable WeaponSingleViewModel weapon, @NonNull ItemsPageView itemspageview) {
        if (weapon == null)
            setNull(itemspageview);
        else {
            if (itemspageview._RefreshButton != null)
                itemspageview._RefreshButton.setOnClickListener(view -> weapon.dataRequest());
            itemspageview._Items.scrollToPosition(0);
            itemspageview.setModels(Collections.singletonList(weapon._Weapon));
        }
    }
    protected void setWeapons(@Nullable WeaponMultipleViewModel weapons, @NonNull ItemsPageView itemspageview) {
        set(weapons, itemspageview);
    }

    protected ImagesHorizontalPageView _Images;
    protected ImagesHorizontalPageView _ExternalLinks;
}