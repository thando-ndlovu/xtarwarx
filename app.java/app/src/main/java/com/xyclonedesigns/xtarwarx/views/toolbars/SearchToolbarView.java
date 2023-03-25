package com.xyclonedesigns.xtarwarx.views.toolbars;

import android.content.Context;
import android.util.AttributeSet;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ScrollView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.widget.AppCompatCheckBox;
import androidx.appcompat.widget.AppCompatImageButton;
import androidx.appcompat.widget.LinearLayoutCompat;
import androidx.appcompat.widget.SearchView;
import androidx.constraintlayout.widget.ConstraintLayout;
import androidx.core.widget.NestedScrollView;
import androidx.recyclerview.widget.RecyclerView;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.enums.StarWarsTypes;
import com.xyclonedesigns.xtarwarx.repository.search.CharacterSearchModel;
import com.xyclonedesigns.xtarwarx.repository.search.FactionSearchModel;
import com.xyclonedesigns.xtarwarx.repository.search.FilmSearchModel;
import com.xyclonedesigns.xtarwarx.repository.search.ManufacturerSearchModel;
import com.xyclonedesigns.xtarwarx.repository.search.PlanetSearchModel;
import com.xyclonedesigns.xtarwarx.repository.search.SpecieSearchModel;
import com.xyclonedesigns.xtarwarx.repository.search.StarshipSearchModel;
import com.xyclonedesigns.xtarwarx.repository.search.VehicleSearchModel;
import com.xyclonedesigns.xtarwarx.repository.search.WeaponSearchModel;
import com.xyclonedesigns.xtarwarx.views.insets.StatusBarInsetView;
import com.xyclonedesigns.xtarwarx.views.search.BaseSearchView;
import com.xyclonedesigns.xtarwarx.views.search.CharacterSearchView;
import com.xyclonedesigns.xtarwarx.views.search.FactionSearchView;
import com.xyclonedesigns.xtarwarx.views.search.FilmSearchView;
import com.xyclonedesigns.xtarwarx.views.search.ManufacturerSearchView;
import com.xyclonedesigns.xtarwarx.views.search.PlanetSearchView;
import com.xyclonedesigns.xtarwarx.views.search.SpecieSearchView;
import com.xyclonedesigns.xtarwarx.views.search.StarshipSearchView;
import com.xyclonedesigns.xtarwarx.views.search.VehicleSearchView;
import com.xyclonedesigns.xtarwarx.views.search.WeaponSearchView;
import com.xyclonedesigns.xtarwarx.widgets.recyclerview.HorizontalRecyclerView;

import java.util.Objects;

public class SearchToolbarView extends BaseToolbarView {
    public static class Ids {
        public static final int Layout = R.layout.xtarwarx_view_toolbar_search;

        public static final int StatusBarInset = R.id.xtarwarx_view_toolbar_search_statusbarinsetview;
        public static final int Search_SearchView = R.id.xtarwarx_view_toolbar_search_search_searchview;
        public static final int Options_HorizontalRecyclerView = R.id.xtarwarx_view_toolbar_search_options_horizontalrecyclerview;
    }

    public SearchToolbarView(Context context) {
        super(context);
    }
    public SearchToolbarView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public SearchToolbarView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public SearchToolbarView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        inflate(context, Ids.Layout, this);
        super.init(context, attr);

        _StatusBarInset = findViewById(Ids.StatusBarInset);
        _Search = findViewById(Ids.Search_SearchView);
        _Options = findViewById(Ids.Options_HorizontalRecyclerView);
        _Options.setAdapter(new RecyclerView.Adapter<OptionViewHolder>() {
            @NonNull
            @Override
            public OptionViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
                return new OptionViewHolder(_Options);
            }

            @Override
            public void onBindViewHolder(@NonNull OptionViewHolder holder, int position) {
                switch (position) {
                    case 0:
                        holder._ViewSelect.setText(R.string.tablayout_tab_characters);
                        holder._ViewOptions.setSelected(_SelectedTab == StarWarsTypes.Character);
                        holder.setOptionsClickListener(SearchToolbarView.this::onTabCharacterOptionsClick);
                        break;
                    case 1:
                        holder._ViewSelect.setText(R.string.tablayout_tab_factions);
                        holder._ViewOptions.setSelected(_SelectedTab == StarWarsTypes.Faction);
                        holder.setOptionsClickListener(SearchToolbarView.this::onTabFactionOptionsClick);
                        break;
                    case 2:
                        holder._ViewSelect.setText(R.string.tablayout_tab_films);
                        holder._ViewOptions.setSelected(_SelectedTab == StarWarsTypes.Film);
                        holder.setOptionsClickListener(SearchToolbarView.this::onTabFilmOptionsClick);
                        break;
                    case 3:
                        holder._ViewSelect.setText(R.string.tablayout_tab_manufacturers);
                        holder._ViewOptions.setSelected(_SelectedTab == StarWarsTypes.Manufacturer);
                        holder.setOptionsClickListener(SearchToolbarView.this::onTabManufacturerOptionsClick);
                        break;
                    case 4:
                        holder._ViewSelect.setText(R.string.tablayout_tab_planets);
                        holder._ViewOptions.setSelected(_SelectedTab == StarWarsTypes.Planet);
                        holder.setOptionsClickListener(SearchToolbarView.this::onTabPlanetOptionsClick);
                        break;
                    case 5:
                        holder._ViewSelect.setText(R.string.tablayout_tab_species);
                        holder._ViewOptions.setSelected(_SelectedTab == StarWarsTypes.Specie);
                        holder.setOptionsClickListener(SearchToolbarView.this::onTabSpecieOptionsClick);
                        break;
                    case 6:
                        holder._ViewSelect.setText(R.string.tablayout_tab_starships);
                        holder._ViewOptions.setSelected(_SelectedTab == StarWarsTypes.Starship);
                        holder.setOptionsClickListener(SearchToolbarView.this::onTabStarshipOptionsClick);
                        break;
                    case 7:
                        holder._ViewSelect.setText(R.string.tablayout_tab_vehicles);
                        holder._ViewOptions.setSelected(_SelectedTab == StarWarsTypes.Vehicle);
                        holder.setOptionsClickListener(SearchToolbarView.this::onTabVehicleOptionsClick);
                        break;
                    case 8:
                        holder._ViewSelect.setText(R.string.tablayout_tab_weapons);
                        holder._ViewOptions.setSelected(_SelectedTab == StarWarsTypes.Weapon);
                        holder.setOptionsClickListener(SearchToolbarView.this::onTabWeaponOptionsClick);
                        break;

                    default: break;
                }
            }

            @Override
            public int getItemCount() {
                return 9;
            }
        });
    }
    @Override
    protected void onAttachedToWindow() {
        super.onAttachedToWindow();
    }

    public StatusBarInsetView _StatusBarInset;
    public SearchView _Search;
    public HorizontalRecyclerView _Options;

    public @Nullable StarWarsTypes _SelectedTab;
    public @Nullable OptionsViewListener _OptionsViewListener;
    public @NonNull CharacterSearchModel _SearchCharacter = new CharacterSearchModel();
    public @NonNull FactionSearchModel _SearchFaction = new FactionSearchModel();
    public @NonNull FilmSearchModel _SearchFilm = new FilmSearchModel();
    public @NonNull ManufacturerSearchModel _SearchManufacturer = new ManufacturerSearchModel();
    public @NonNull PlanetSearchModel _SearchPlanet = new PlanetSearchModel();
    public @NonNull SpecieSearchModel _SearchSpecie = new SpecieSearchModel();
    public @NonNull StarshipSearchModel _SearchStarship = new StarshipSearchModel();
    public @NonNull VehicleSearchModel _SearchVehicle = new VehicleSearchModel();
    public @NonNull WeaponSearchModel _SearchWeapon = new WeaponSearchModel();

    protected void onShowView(@Nullable BaseSearchView searchView) {
        if (_OptionsViewListener == null)
            return;

        _OptionsViewListener.onShow(searchView);
    }
    protected void onTabCharacterOptionsClick(OptionViewHolder viewHolder) {
        if (viewHolder._ViewOptions.isSelected()) {
            viewHolder._ViewOptions.setSelected(false);
            _SelectedTab = null;
            onShowView(null);
            return;
        }

        viewHolder._ViewOptions.setSelected(true);

        CharacterSearchView searchView = new CharacterSearchView(getContext());
        searchView.setSearch(_SearchCharacter);
        _SelectedTab = StarWarsTypes.Character;

        onShowView(searchView);
    }
    protected void onTabFactionOptionsClick(OptionViewHolder viewHolder) {
        if (viewHolder._ViewOptions.isSelected()) {
            viewHolder._ViewOptions.setSelected(false);
            _SelectedTab = null;
            onShowView(null);
            return;
        }

        viewHolder._ViewOptions.setSelected(true);

        FactionSearchView searchView = new FactionSearchView(getContext());
        searchView.setSearch(_SearchFaction);
        _SelectedTab = StarWarsTypes.Faction;

        onShowView(searchView);
    }
    protected void onTabFilmOptionsClick(OptionViewHolder viewHolder) {
        if (viewHolder._ViewOptions.isSelected()) {
            viewHolder._ViewOptions.setSelected(false);
            _SelectedTab = null;
            onShowView(null);
            return;
        }

        viewHolder._ViewOptions.setSelected(true);

        FilmSearchView searchView = new FilmSearchView(getContext());
        searchView.setSearch(_SearchFilm);
        _SelectedTab = StarWarsTypes.Film;

        onShowView(searchView);
    }
    protected void onTabManufacturerOptionsClick(OptionViewHolder viewHolder) {
        if (viewHolder._ViewOptions.isSelected()) {
            viewHolder._ViewOptions.setSelected(false);
            _SelectedTab = null;
            onShowView(null);
            return;
        }

        viewHolder._ViewOptions.setSelected(true);

        ManufacturerSearchView searchView = new ManufacturerSearchView(getContext());
        searchView.setSearch(_SearchManufacturer);
        _SelectedTab = StarWarsTypes.Manufacturer;

        onShowView(searchView);
    }
    protected void onTabPlanetOptionsClick(OptionViewHolder viewHolder) {
        if (viewHolder._ViewOptions.isSelected()) {
            viewHolder._ViewOptions.setSelected(false);
            _SelectedTab = null;
            onShowView(null);
            return;
        }

        viewHolder._ViewOptions.setSelected(true);

        PlanetSearchView searchView = new PlanetSearchView(getContext());
        searchView.setSearch(_SearchPlanet);
        _SelectedTab = StarWarsTypes.Planet;

        onShowView(searchView);
    }
    protected void onTabSpecieOptionsClick(OptionViewHolder viewHolder) {
        if (viewHolder._ViewOptions.isSelected()) {
            viewHolder._ViewOptions.setSelected(false);
            _SelectedTab = null;
            onShowView(null);
            return;
        }

        viewHolder._ViewOptions.setSelected(true);

        SpecieSearchView searchView = new SpecieSearchView(getContext());
        searchView.setSearch(_SearchSpecie);
        _SelectedTab = StarWarsTypes.Specie;

        onShowView(searchView);
    }
    protected void onTabStarshipOptionsClick(OptionViewHolder viewHolder) {
        if (viewHolder._ViewOptions.isSelected()) {
            viewHolder._ViewOptions.setSelected(false);
            _SelectedTab = null;
            onShowView(null);
            return;
        }

        viewHolder._ViewOptions.setSelected(true);

        StarshipSearchView searchView = new StarshipSearchView(getContext());
        searchView.setSearch(_SearchStarship);
        _SelectedTab = StarWarsTypes.Starship;

        onShowView(searchView);
    }
    protected void onTabVehicleOptionsClick(OptionViewHolder viewHolder) {
        if (viewHolder._ViewOptions.isSelected()) {
            viewHolder._ViewOptions.setSelected(false);
            _SelectedTab = null;
            onShowView(null);
            return;
        }

        viewHolder._ViewOptions.setSelected(true);

        VehicleSearchView searchView = new VehicleSearchView(getContext());
        searchView.setSearch(_SearchVehicle);
        _SelectedTab = StarWarsTypes.Vehicle;

        onShowView(searchView);
    }
    protected void onTabWeaponOptionsClick(OptionViewHolder viewHolder) {
        if (viewHolder._ViewOptions.isSelected()) {
            viewHolder._ViewOptions.setSelected(false);
            _SelectedTab = null;
            onShowView(null);
            return;
        }

        viewHolder._ViewOptions.setSelected(true);

        WeaponSearchView searchView = new WeaponSearchView(getContext());
        searchView.setSearch(_SearchWeapon);
        _SelectedTab = StarWarsTypes.Weapon;

        onShowView(searchView);
    }

    public interface OptionsViewListener {
        void onShow(BaseSearchView searchView);
    }
    protected static class OptionViewHolder extends RecyclerView.ViewHolder {
        private static View _default(@NonNull RecyclerView parent) {
            return LayoutInflater
                    .from(parent.getContext())
                    .inflate(R.layout.xtarwarx_view_toolbar_search_option, parent, false);
        }

        public OptionViewHolder(@NonNull RecyclerView parent) {
            super(_default(parent));

            _ViewRoot = (ConstraintLayout) itemView;
            _ViewSelect = _ViewRoot.findViewById(R.id.xtarwarx_view_toolbar_search_option_select_appcompatcheckbox);
            _ViewOptions = _ViewRoot.findViewById(R.id.xtarwarx_view_toolbar_search_option_options_appcompatimagebutton);
        }

        public final ConstraintLayout _ViewRoot;
        public final AppCompatCheckBox _ViewSelect;
        public final AppCompatImageButton _ViewOptions;
        private @Nullable OptionsClickListener _OptionsClickListener;

        public void setOptionsClickListener(@Nullable OptionsClickListener optionsClickListener) {
            _OptionsClickListener = optionsClickListener;

            if (_OptionsClickListener == null)
                _ViewOptions.setOnClickListener(null);
            else _ViewOptions.setOnClickListener(view -> {
                if (_OptionsClickListener != null)
                    _OptionsClickListener.onOptionsClick(this);
            });
        }

        public interface OptionsClickListener {
            void onOptionsClick(OptionViewHolder viewHolder);
        }
    }
}