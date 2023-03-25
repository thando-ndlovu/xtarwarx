package com.xyclonedesigns.xtarwarx.views.page;

import android.content.Context;
import android.graphics.Rect;
import android.graphics.drawable.Drawable;
import android.net.Uri;
import android.util.AttributeSet;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.view.menu.MenuBuilder;
import androidx.appcompat.widget.ActionMenuView;
import androidx.appcompat.widget.AppCompatButton;
import androidx.appcompat.widget.AppCompatImageButton;
import androidx.appcompat.widget.AppCompatImageView;
import androidx.appcompat.widget.AppCompatTextView;
import androidx.appcompat.widget.PopupMenu;
import androidx.constraintlayout.widget.ConstraintLayout;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.google.android.material.card.MaterialCardView;

import com.bumptech.glide.Glide;
import com.bumptech.glide.load.resource.bitmap.DownsampleStrategy;
import com.bumptech.glide.request.RequestOptions;
import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.enums.StarWarsTypes;
import com.xyclonedesigns.xtarwarx.repository.models.CharacterModel;
import com.xyclonedesigns.xtarwarx.repository.models.FactionModel;
import com.xyclonedesigns.xtarwarx.repository.models.FilmModel;
import com.xyclonedesigns.xtarwarx.repository.models.ManufacturerModel;
import com.xyclonedesigns.xtarwarx.repository.models.PlanetModel;
import com.xyclonedesigns.xtarwarx.repository.models.SpecieModel;
import com.xyclonedesigns.xtarwarx.repository.models.StarWarsModel;
import com.xyclonedesigns.xtarwarx.repository.models.StarWarsModelURI;
import com.xyclonedesigns.xtarwarx.repository.models.StarshipModel;
import com.xyclonedesigns.xtarwarx.repository.models.VehicleModel;
import com.xyclonedesigns.xtarwarx.repository.models.WeaponModel;
import com.xyclonedesigns.xtarwarx.utils.ArrayUtils;
import com.xyclonedesigns.xtarwarx.widgets.recyclerview.MenuItemsRecyclerView;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Comparator;

public class PageItemView extends MaterialCardView  {
    public PageItemView(Context context) {
        this(context, null);
    }
    public PageItemView(Context context, AttributeSet attr) {
        this(context, attr, R.style.XtarWarx_View_Page_Item);
    }
    public PageItemView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
        init(context, attr);
    }

    protected void init(Context context, AttributeSet attr) {
        setClickable(true);
        setFocusable(true);
        setLongClickable(true);
        setCardBackgroundColor(context.getResources().getColor(R.color.ColorSurface, context.getTheme()));
        setRadius(context.getResources().getDimension(R.dimen.dp16));
        setRippleColorResource(R.color.ColorSurfaceActive);
    }

    public AppCompatTextView _Title;
    public AppCompatTextView _Subtitle;
    public AppCompatImageView _Image;
    public AppCompatImageView _ImageDefault;
    public MenuItemsRecyclerView _Menu;

    public StarWarsTypes _StarWarsType;

    public void setStarWarsModel(StarWarsModel starWarsModel) {
        if (starWarsModel instanceof CharacterModel)
            setCharacter(((CharacterModel) starWarsModel));
        else if (starWarsModel instanceof FactionModel)
            setFaction(((FactionModel) starWarsModel));
        else if (starWarsModel instanceof FilmModel)
            setFilm(((FilmModel) starWarsModel));
        else if (starWarsModel instanceof ManufacturerModel)
            setManufacturer(((ManufacturerModel) starWarsModel));
        else if (starWarsModel instanceof SpecieModel)
            setSpecie(((SpecieModel) starWarsModel));
        else if (starWarsModel instanceof PlanetModel)
            setPlanet(((PlanetModel) starWarsModel));
        else if (starWarsModel instanceof StarshipModel)
            setStarship(((StarshipModel) starWarsModel));
        else if (starWarsModel instanceof VehicleModel)
            setVehicle(((VehicleModel) starWarsModel));
        else if (starWarsModel instanceof WeaponModel)
            setWeapon(((WeaponModel) starWarsModel));
    }
    public void setCharacter(CharacterModel character) {
        _StarWarsType = StarWarsTypes.Character;
        _Menu.getMenuAdapter().setMenu(R.menu.menu_pageitem_character);
        _ImageDefault.setImageResource(R.drawable.ic_icon_starwars_character);
        _Title.setText(
                character._Name == null
                    ? getResources().getString(R.string.models_character_emptytext_name)
                    : character._Name
        );
        _Subtitle.setText(
                character._Description == null
                    ? getResources().getString(R.string.models_character_emptytext_description)
                    : character._Description
        );

        setImage(character._Uris, StarWarsModelURI.ImagesComparatorDefault());
    }
    public void setFaction(FactionModel faction) {
        _StarWarsType = StarWarsTypes.Faction;
        _Menu.getMenuAdapter().setMenu(R.menu.menu_pageitem_faction);
        _ImageDefault.setImageResource(R.drawable.ic_icon_starwars_faction);
        _Title.setText(
                faction._Name == null
                    ? getResources().getString(R.string.models_faction_emptytext_name)
                    : faction._Name
        );
        _Subtitle.setText(
                faction._Description == null
                    ? getResources().getString(R.string.models_faction_emptytext_description)
                    : faction._Description
        );

        setImage(faction._Uris, StarWarsModelURI.ImagesComparatorFactions());
    }
    public void setFilm(FilmModel film) {
        _StarWarsType = StarWarsTypes.Film;
        _Menu.getMenuAdapter().setMenu(R.menu.menu_pageitem_film);
        _ImageDefault.setImageResource(R.drawable.ic_icon_starwars_film);
        _Title.setText(
                film._Title == null
                    ? getResources().getString(R.string.models_film_emptytext_title)
                    : film._Title
        );
        _Subtitle.setText(
                film._Description == null
                    ? getResources().getString(R.string.models_film_emptytext_description)
                    : film._Description
        );

        setImage(film._Uris, StarWarsModelURI.ImagesComparatorFilms());
    }
    public void setManufacturer(ManufacturerModel manufacturer) {
        _StarWarsType = StarWarsTypes.Manufacturer;
        _Menu.getMenuAdapter().setMenu(R.menu.menu_pageitem_manufacturer);
        _Title.setText(
                manufacturer._Name == null
                    ? getResources().getString(R.string.models_manufacturer_emptytext_name)
                    : manufacturer._Name
        );
        _Subtitle.setText(
                manufacturer._Description == null
                    ? getResources().getString(R.string.models_manufacturer_emptytext_description)
                    : manufacturer._Description
        );

        setImage(manufacturer._Uris, StarWarsModelURI.ImagesComparatorDefault());
    }
    public void setPlanet(PlanetModel planet) {
        _StarWarsType = StarWarsTypes.Planet;
        _Menu.getMenuAdapter().setMenu(R.menu.menu_pageitem_planet);
        _ImageDefault.setImageResource(R.drawable.ic_icon_starwars_planet);
        _Title.setText(
                planet._Name == null
                    ? getResources().getString(R.string.models_planet_emptytext_name)
                    : planet._Name
        );
        _Subtitle.setText(
                planet._Description == null
                    ? getResources().getString(R.string.models_planet_emptytext_description)
                    : planet._Description
        );

        setImage(planet._Uris, StarWarsModelURI.ImagesComparatorDefault());
    }
    public void setSpecie(SpecieModel specie) {
        _StarWarsType = StarWarsTypes.Specie;
        _Menu.getMenuAdapter().setMenu(R.menu.menu_pageitem_specie);
        _ImageDefault.setImageResource(R.drawable.ic_icon_starwars_specie);
        _Title.setText(
                specie._Name == null
                    ? getResources().getString(R.string.models_specie_emptytext_name)
                    : specie._Name
        );
        _Subtitle.setText(
                specie._Description == null
                    ? getResources().getString(R.string.models_specie_emptytext_description)
                    : specie._Description
        );

        setImage(specie._Uris, StarWarsModelURI.ImagesComparatorDefault());
    }
    public void setStarship(StarshipModel starship) {
        _StarWarsType = StarWarsTypes.Starship;
        _Menu.getMenuAdapter().setMenu(R.menu.menu_pageitem_starship);
        _ImageDefault.setImageResource(R.drawable.ic_icon_starwars_starship);
        _Title.setText(
                starship._Name == null
                    ? getResources().getString(R.string.models_starship_emptytext_name)
                    : starship._Name
        );
        _Subtitle.setText(
                starship._Description == null
                    ? getResources().getString(R.string.models_starship_emptytext_description)
                    : starship._Description
        );

        setImage(starship._Uris, StarWarsModelURI.ImagesComparatorDefault());
    }
    public void setVehicle(VehicleModel vehicle) {
        _StarWarsType = StarWarsTypes.Vehicle;
        _Menu.getMenuAdapter().setMenu(R.menu.menu_pageitem_vehicle);
        _ImageDefault.setImageResource(R.drawable.ic_icon_starwars_vehicle);
        _Title.setText(
                vehicle._Name == null
                    ? getResources().getString(R.string.models_vehicle_emptytext_name)
                    : vehicle._Name
        );
        _Subtitle.setText(
                vehicle._Description == null
                    ? getResources().getString(R.string.models_vehicle_emptytext_description)
                    : vehicle._Description
        );

        setImage(vehicle._Uris, StarWarsModelURI.ImagesComparatorDefault());
    }
    public void setWeapon(WeaponModel weapon) {
        _StarWarsType = StarWarsTypes.Weapon;
        _Menu.getMenuAdapter().setMenu(R.menu.menu_pageitem_weapon);
        _ImageDefault.setImageResource(R.drawable.ic_icon_starwars_weapon);
        _Title.setText(
                weapon._Name == null
                    ? getResources().getString(R.string.models_weapon_emptytext_name)
                    : weapon._Name
        );
        _Subtitle.setText(
                weapon._Description == null
                    ? getResources().getString(R.string.models_weapon_emptytext_description)
                    : weapon._Description
        );

        setImage(weapon._Uris, StarWarsModelURI.ImagesComparatorDefault());
    }
    public void setImage(@Nullable Iterable<StarWarsModelURI> uris, @Nullable Comparator<StarWarsModelURI> comparator) {
        Glide.with(getContext()).clear(_Image);
        ((ConstraintLayout.LayoutParams)_Image.getLayoutParams()).dimensionRatio =
        ((ConstraintLayout.LayoutParams)_ImageDefault.getLayoutParams()).dimensionRatio =
                _StarWarsType == StarWarsTypes.Film
                    ? "2:3"
                    : "1:1";

        StarWarsModelURI[] _uris = ArrayUtils.toArray(uris, new StarWarsModelURI[] { });

        if (_uris == null)
            return;

        if (comparator != null)
            Arrays.sort(_uris, comparator);

        for (StarWarsModelURI uri : _uris)
            if (StarWarsModelURI.Keys.isImage(uri) && uri._Uri != null) {
                Glide.with(getContext())
                        .load(Uri.parse(uri._Uri.toString()))
                        .apply(RequestOptions.downsampleOf(DownsampleStrategy.DEFAULT))
                        .into(_Image);
                break;
            }
    }
}