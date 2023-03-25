package com.xyclonedesigns.xtarwarx.views.models;

import android.content.Context;
import android.net.Uri;
import android.util.AttributeSet;

import androidx.annotation.Nullable;
import androidx.appcompat.widget.AppCompatImageView;
import androidx.appcompat.widget.AppCompatTextView;

import com.bumptech.glide.Glide;
import com.bumptech.glide.load.resource.bitmap.DownsampleStrategy;
import com.bumptech.glide.request.RequestOptions;
import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.models.FilmModel;
import com.xyclonedesigns.xtarwarx.repository.models.StarWarsModelURI;
import com.xyclonedesigns.xtarwarx.utils.ArrayUtils;
import com.xyclonedesigns.xtarwarx.utils.StringUtils;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.CharacterMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.FactionMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.ManufacturerMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.PlanetMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.SpecieMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.StarshipMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.VehicleMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.WeaponMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.FilmSingleViewModel;
import com.xyclonedesigns.xtarwarx.views.page.ItemsHorizontalPageView;

public class FilmModelView extends BaseModelView {
    public static class Ids {
        public static int Layout = R.layout.xtarwarx_view_model_film;

        public static int Header_View = R.id.xtarwarx_view_model_film_header_view;
        public static int Title_AppCompatTextView = R.id.xtarwarx_view_model_film_title_appcompattextview;
        public static int Episodeid_AppCompatTextView = R.id.xtarwarx_view_model_film_episodeid_appcompattextview;
        public static int Poster_AppCompatImageView = R.id.xtarwarx_view_model_film_poster_appcompatimageview;
        public static int Openingcrawl_AppCompatTextView = R.id.xtarwarx_view_model_film_openingcrawl_appcompattextview;
        public static int Externallinks_ImagesHorizontalPageView = R.id.xtarwarx_view_model_film_externallinks_imageshorizontalpageview;
        public static int Description_AppCompatTextView = R.id.xtarwarx_view_model_film_description_appcompattextview;
        public static int Images_ImagesHorizontalPageView = R.id.xtarwarx_view_model_film_images_imageshorizontalpageview;
        public static int Details_Barrier_End = R.id.xtarwarx_view_model_film_details_barrier_end;
        public static int Releasedate_Key_AppCompatTextView = R.id.xtarwarx_view_model_film_releasedate_key_appcompattextview;
        public static int Releasedate_Value_AppCompatTextView = R.id.xtarwarx_view_model_film_releasedate_value_appcompattextview;
        public static int Releasedate_Barrier_Bottom = R.id.xtarwarx_view_model_film_releasedate_barrier_bottom;
        public static int Director_Key_AppCompatTextView = R.id.xtarwarx_view_model_film_director_key_appcompattextview;
        public static int Director_Value_AppCompatTextView = R.id.xtarwarx_view_model_film_director_value_appcompattextview;
        public static int Director_Barrier_Bottom = R.id.xtarwarx_view_model_film_director_barrier_bottom;
        public static int Duration_Key_AppCompatTextView = R.id.xtarwarx_view_model_film_duration_key_appcompattextview;
        public static int Duration_Value_AppCompatTextView = R.id.xtarwarx_view_model_film_duration_value_appcompattextview;
        public static int Duration_Barrier_Bottom = R.id.xtarwarx_view_model_film_duration_barrier_bottom;
        public static int Castmembers_Key_AppCompatTextView = R.id.xtarwarx_view_model_film_castmembers_key_appcompattextview;
        public static int Castmembers_Value_AppCompatTextView = R.id.xtarwarx_view_model_film_castmembers_value_appcompattextview;
        public static int Castmembers_Barrier_Bottom = R.id.xtarwarx_view_model_film_castmembers_barrier_bottom;
        public static int Producers_Key_AppCompatTextView = R.id.xtarwarx_view_model_film_producers_key_appcompattextview;
        public static int Producers_Value_AppCompatTextView = R.id.xtarwarx_view_model_film_producers_value_appcompattextview;
        public static int Producers_Barrier_Bottom = R.id.xtarwarx_view_model_film_producers_barrier_bottom;
        public static int Films_ItemsHorizontalPageView = R.id.xtarwarx_view_model_film_characters_itemshorizontalpageview;
        public static int Factions_ItemsHorizontalPageView = R.id.xtarwarx_view_model_film_factions_itemshorizontalpageview;
        public static int Manufacturers_ItemsHorizontalPageView = R.id.xtarwarx_view_model_film_manufacturers_itemshorizontalpageview;
        public static int Planets_ItemsHorizontalPageView = R.id.xtarwarx_view_model_film_planets_itemshorizontalpageview;
        public static int Species_ItemsHorizontalPageView = R.id.xtarwarx_view_model_film_species_itemshorizontalpageview;
        public static int Starships_ItemsHorizontalPageView = R.id.xtarwarx_view_model_film_starships_itemshorizontalpageview;
        public static int Vehicles_ItemsHorizontalPageView = R.id.xtarwarx_view_model_film_vehicles_itemshorizontalpageview;
        public static int Weapons_ItemsHorizontalPageView = R.id.xtarwarx_view_model_film_weapons_itemshorizontalpageview;
    }

    public FilmModelView(Context context) {
        super(context);
    }
    public FilmModelView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public FilmModelView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public FilmModelView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        inflate(context, Ids.Layout, this);

        _Title = findViewById(Ids.Title_AppCompatTextView);
        _EpisodeId = findViewById(Ids.Episodeid_AppCompatTextView);
        _Poster = findViewById(Ids.Poster_AppCompatImageView);
        _OpeningCrawl = findViewById(Ids.Openingcrawl_AppCompatTextView);
        _ExternalLinks = findViewById(Ids.Externallinks_ImagesHorizontalPageView);
        _Description = findViewById(Ids.Description_AppCompatTextView);
        _Images = findViewById(Ids.Images_ImagesHorizontalPageView);
        _Director = findViewById(Ids.Director_Value_AppCompatTextView);
        _Duration = findViewById(Ids.Duration_Value_AppCompatTextView);
        _CastMembers = findViewById(Ids.Castmembers_Value_AppCompatTextView);
        _Producers = findViewById(Ids.Producers_Value_AppCompatTextView);
        _Characters = findViewById(Ids.Films_ItemsHorizontalPageView);
        _Factions = findViewById(Ids.Factions_ItemsHorizontalPageView);
        _Manufacturers = findViewById(Ids.Manufacturers_ItemsHorizontalPageView);
        _Planets = findViewById(Ids.Planets_ItemsHorizontalPageView);
        _Species = findViewById(Ids.Species_ItemsHorizontalPageView);
        _Starships = findViewById(Ids.Starships_ItemsHorizontalPageView);
        _Vehicles = findViewById(Ids.Vehicles_ItemsHorizontalPageView);
        _Weapons = findViewById(Ids.Weapons_ItemsHorizontalPageView);

        super.init(context, attr);

        _Characters._Items.setItemsAdapter(ItemsHorizontalPageView.ItemsAdapter.createCharactersAdapter());
        _Factions._Items.setItemsAdapter(ItemsHorizontalPageView.ItemsAdapter.createFactionsAdapter());
        _Manufacturers._Items.setItemsAdapter(ItemsHorizontalPageView.ItemsAdapter.createManufacturersAdapter());
        _Planets._Items.setItemsAdapter(ItemsHorizontalPageView.ItemsAdapter.createPlanetsAdapter());
        _Species._Items.setItemsAdapter(ItemsHorizontalPageView.ItemsAdapter.createSpeciesAdapter());
        _Starships._Items.setItemsAdapter(ItemsHorizontalPageView.ItemsAdapter.createStarshipsAdapter());
        _Vehicles._Items.setItemsAdapter(ItemsHorizontalPageView.ItemsAdapter.createVehiclesAdapter());
        _Weapons._Items.setItemsAdapter(ItemsHorizontalPageView.ItemsAdapter.createWeaponsAdapter());
    }

    public FilmSingleViewModel getViewModel() {
        return _ViewModel;
    }
    public void setViewModel(FilmSingleViewModel viewModel) {
        _ViewModel = viewModel;

        if (_ViewModel == null) {
            setFilm(null);
            setFilmCharacters(null);
            setFilmFactions(null);
            setFilmManufacturers(null);
            setFilmPlanets(null);
            setFilmSpecies(null);
            setFilmStarships(null);
            setFilmVehicles(null);
            setFilmWeapons(null);

            return;
        }

         setFilm(_ViewModel._Film);
         setFilmCharacters(_ViewModel._Characters);
         setFilmFactions(_ViewModel._Factions);
         setFilmManufacturers(_ViewModel._Manufacturers);
         setFilmPlanets(_ViewModel._Planets);
         setFilmSpecies(_ViewModel._Species);
         setFilmStarships(_ViewModel._Starships);
         setFilmVehicles(_ViewModel._Vehicles);
         setFilmWeapons(_ViewModel._Weapons);
    }
    public void setFilm(@Nullable FilmModel film) {
        if (_ViewModel != null && film != null)
            _ViewModel._Film = film;

        if (film == null) {
            _Title.setText("");
            _EpisodeId.setText("");
            _OpeningCrawl.setText("");
            _Description.setText("");
            _Director.setText("");
            _Duration.setText("");
            _CastMembers.setText("");
            _Producers.setText("");

            _Images.setImages(null);
            _ExternalLinks.setExternalLinks(null);

            return;
        }

        String title = film._Title == null ? "" : film._Title;
        String openingcrawl = film._OpeningCrawl == null ? "" : film._OpeningCrawl;
        String description = film._Description == null ? "" : film._Description;
        String director = film._Director == null ? "" : film._Director;
        String episodeid = film._EpisodeId == null || film._EpisodeId == -1 ? "" : StringUtils.romanNumeral(film._EpisodeId);
        String duration = film._Duration == null ? "" : StringUtils.microwaveTime(0, film._Duration, 0, 0);
        String castmembers = StringUtils.join(", ", film._CastMembers);
        String producers = StringUtils.join(", ", film._Producers);

        _Title.setText(title);
        _EpisodeId.setText(episodeid);
        _OpeningCrawl.setText(openingcrawl);
        _Description.setText(description);
        _Director.setText(director);
        _Duration.setText(duration);
        _CastMembers.setText(castmembers);
        _Producers.setText(producers);

        StarWarsModelURI poster = ArrayUtils.search(film._Uris, uri ->
                StarWarsModelURI.Keys.MainPoster.equals(uri._Key) ||
                        StarWarsModelURI.Keys.AdditionalPoster.equals(uri._Key)
        );

        if (poster == null || poster._Uri == null)
            Glide.with(getContext()).clear(_Poster);
        else Glide.with(getContext())
                .load(Uri.parse(poster._Uri.toString()))
                .override(getResources().getDimensionPixelSize(R.dimen.dp256))
                .centerInside()
                .apply(RequestOptions.downsampleOf(DownsampleStrategy.DEFAULT))
                .into(_Poster);

        _Images.setImages(film._Uris);
        _ExternalLinks.setExternalLinks(film._Uris);
    }
    public void setFilmCharacters(@Nullable CharacterMultipleViewModel characters) {
        setCharacters(_ViewModel == null
                ? characters
                : (_ViewModel._Characters = characters), _Characters
        );
    }
    public void setFilmFactions(@Nullable FactionMultipleViewModel factions) {
        setFactions(_ViewModel == null
                ? factions
                : (_ViewModel._Factions = factions), _Factions
        );
    }
    public void setFilmManufacturers(@Nullable ManufacturerMultipleViewModel manufacturers) {
        setManufacturers(_ViewModel == null
                ? manufacturers
                : (_ViewModel._Manufacturers = manufacturers), _Manufacturers
        );
    }
    public void setFilmPlanets(@Nullable PlanetMultipleViewModel planets) {
        setPlanets(_ViewModel == null
                ? planets
                : (_ViewModel._Planets = planets), _Planets
        );
    }
    public void setFilmSpecies(@Nullable SpecieMultipleViewModel species) {
        setSpecies(_ViewModel == null
                ? species
                : (_ViewModel._Species = species), _Species
        );
    }
    public void setFilmStarships(@Nullable StarshipMultipleViewModel starships) {
        setStarships(_ViewModel == null
                ? starships
                : (_ViewModel._Starships = starships), _Starships
        );
    }
    public void setFilmVehicles(@Nullable VehicleMultipleViewModel vehicles) {
        setVehicles(_ViewModel == null
                ? vehicles
                : (_ViewModel._Vehicles = vehicles), _Vehicles
        );
    }
    public void setFilmWeapons(@Nullable WeaponMultipleViewModel weapons) {
        setWeapons(_ViewModel == null
                ? weapons
                : (_ViewModel._Weapons = weapons), _Weapons
        );
    }

    protected @Nullable FilmSingleViewModel _ViewModel;

    protected AppCompatTextView _Title;
    protected AppCompatTextView _EpisodeId;
    protected AppCompatImageView _Poster;
    protected AppCompatTextView _OpeningCrawl;
    protected AppCompatTextView _Description;
    protected AppCompatTextView _Director;
    protected AppCompatTextView _Duration;
    protected AppCompatTextView _CastMembers;
    protected AppCompatTextView _Producers;
    protected ItemsHorizontalPageView _Characters;
    protected ItemsHorizontalPageView _Factions;
    protected ItemsHorizontalPageView _Manufacturers;
    protected ItemsHorizontalPageView _Planets;
    protected ItemsHorizontalPageView _Species;
    protected ItemsHorizontalPageView _Starships;
    protected ItemsHorizontalPageView _Vehicles;
    protected ItemsHorizontalPageView _Weapons;
}