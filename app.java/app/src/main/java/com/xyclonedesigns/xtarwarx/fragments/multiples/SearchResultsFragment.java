package com.xyclonedesigns.xtarwarx.fragments.multiples;

import android.content.Context;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ScrollView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.widget.LinearLayoutCompat;
import androidx.appcompat.widget.SearchView;
import androidx.constraintlayout.widget.ConstraintLayout;
import androidx.core.widget.NestedScrollView;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.CharacterModel;
import com.xyclonedesigns.xtarwarx.repository.models.FactionModel;
import com.xyclonedesigns.xtarwarx.repository.models.FilmModel;
import com.xyclonedesigns.xtarwarx.repository.models.ManufacturerModel;
import com.xyclonedesigns.xtarwarx.repository.models.PlanetModel;
import com.xyclonedesigns.xtarwarx.repository.models.SpecieModel;
import com.xyclonedesigns.xtarwarx.repository.models.StarWarsModel;
import com.xyclonedesigns.xtarwarx.repository.models.StarshipModel;
import com.xyclonedesigns.xtarwarx.repository.models.VehicleModel;
import com.xyclonedesigns.xtarwarx.repository.models.WeaponModel;
import com.xyclonedesigns.xtarwarx.repository.search.SearchModel;
import com.xyclonedesigns.xtarwarx.utils.ArrayUtils;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.SearchResultsViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.CharacterMultipleViewModel;
import com.xyclonedesigns.xtarwarx.views.page.ItemsVerticalPageView;
import com.xyclonedesigns.xtarwarx.views.search.BaseSearchView;
import com.xyclonedesigns.xtarwarx.views.search.SearchResultsView;
import com.xyclonedesigns.xtarwarx.views.toolbars.SearchToolbarView;
import com.xyclonedesigns.xtarwarx.widgets.recyclerview.PageItemsRecyclerView;

import org.jetbrains.annotations.NotNull;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.function.Function;

public class SearchResultsFragment extends BaseMultipleFragment<StarWarsModel, SearchResultsViewModel> {
    public SearchResultsFragment(@NonNull Context context , @NonNull StarWarsRepository repository) {
        super(-1, -1);
        _ViewModel = new SearchResultsViewModel(context, repository) {
            @NotNull
            @Override
            public List<StarWarsModel> getModels() {
                return _PageViewItemsAdapter._Items;
            }
            <T extends StarWarsModel> void dataCallbackT(StarWarsRepository.Data<T> data) {
                for (T model : data._Items) {
                    int index = ArrayUtils.searchIndex(_PageViewItemsAdapter._Items,
                            item -> item._Id == model._Id && (
                                    (model instanceof CharacterModel && item instanceof CharacterModel) ||
                                    (model instanceof FactionModel && item instanceof FactionModel) ||
                                    (model instanceof FilmModel && item instanceof FilmModel) ||
                                    (model instanceof ManufacturerModel && item instanceof ManufacturerModel) ||
                                    (model instanceof SpecieModel && item instanceof SpecieModel) ||
                                    (model instanceof PlanetModel && item instanceof PlanetModel) ||
                                    (model instanceof StarshipModel && item instanceof StarshipModel) ||
                                    (model instanceof VehicleModel && item instanceof VehicleModel) ||
                                    (model instanceof WeaponModel && item instanceof WeaponModel))
                    );

                    if (index != -1) {
                        _PageViewItemsAdapter._Items.remove(index);
                        _PageViewItemsAdapter._Items.add(index, model);
                        _PageViewItemsAdapter.notifyItemChanged(index);
                    }
                }
            }
            @Override
            public void dataCallbackSearchResults(StarWarsRepository.Data<SearchModel.Result> data) {
                super.dataCallbackSearchResults(data);
                if (_PageView != null && _ViewModel != null) {
                    _PageView._PaginationOptions.setViewModel(_ViewModel._Pagination);
                    _PageView._PaginationPages.setViewModel(_ViewModel._Pagination);
                    _PageView._Items.smoothScrollToPosition(0);
                }

                ArrayList<Integer> _idsCharacter = new ArrayList<>();
                ArrayList<Integer> _idsFaction = new ArrayList<>();
                ArrayList<Integer> _idsFilm = new ArrayList<>();
                ArrayList<Integer> _idsManufacturer = new ArrayList<>();
                ArrayList<Integer> _idsPlanet = new ArrayList<>();
                ArrayList<Integer> _idsSpecie = new ArrayList<>();
                ArrayList<Integer> _idsStarship = new ArrayList<>();
                ArrayList<Integer> _idsVehicle = new ArrayList<>();
                ArrayList<Integer> _idsWeapon = new ArrayList<>();

                _PageViewItemsAdapter._Items.clear();
                for (SearchModel.Result result : data._Items)
                    switch (result._StarWarsType) {
                        case Character:
                            _idsCharacter.add(result._Id);
                            _PageViewItemsAdapter._Items.add(new CharacterModel(result._Id));
                            break;
                        case Faction:
                            _idsFaction.add(result._Id);
                            _PageViewItemsAdapter._Items.add(new FactionModel(result._Id));
                            break;
                        case Film:
                            _idsFilm.add(result._Id);
                            _PageViewItemsAdapter._Items.add(new FilmModel(result._Id));
                            break;
                        case Manufacturer:
                            _idsManufacturer.add(result._Id);
                            _PageViewItemsAdapter._Items.add(new ManufacturerModel(result._Id));
                            break;
                        case Planet:
                            _idsPlanet.add(result._Id);
                            _PageViewItemsAdapter._Items.add(new PlanetModel(result._Id));
                            break;
                        case Specie:
                            _idsSpecie.add(result._Id);
                            _PageViewItemsAdapter._Items.add(new SpecieModel(result._Id));
                            break;
                        case Starship:
                            _idsStarship.add(result._Id);
                            _PageViewItemsAdapter._Items.add(new StarshipModel(result._Id));
                            break;
                        case Vehicle:
                            _idsVehicle.add(result._Id);
                            _PageViewItemsAdapter._Items.add(new VehicleModel(result._Id));
                            break;
                        case Weapon:
                            _idsWeapon.add(result._Id);
                            _PageViewItemsAdapter._Items.add(new WeaponModel(result._Id));
                            break;
                    }

                if (_idsCharacter.size() > 0)  _Repository.characters().get(this::dataCallbackT, null, _idsCharacter);
                if (_idsFaction.size() > 0)  _Repository.factions().get(this::dataCallbackT, null, _idsFaction);
                if (_idsFilm.size() > 0)  _Repository.films().get(this::dataCallbackT, null, _idsFilm);
                if (_idsManufacturer.size() > 0)  _Repository.manufacturers().get(this::dataCallbackT, null, _idsManufacturer);
                if (_idsPlanet.size() > 0)  _Repository.planets().get(this::dataCallbackT, null, _idsPlanet);
                if (_idsSpecie.size() > 0)  _Repository.species().get(this::dataCallbackT, null, _idsSpecie);
                if (_idsStarship.size() > 0)  _Repository.starships().get(this::dataCallbackT, null, _idsStarship);
                if (_idsVehicle.size() > 0)  _Repository.vehicles().get(this::dataCallbackT, null, _idsVehicle);
                if (_idsWeapon.size() > 0)  _Repository.weapons().get(this::dataCallbackT, null, _idsWeapon);
            }
        };
    }

    protected SearchResultsView _SearchResultsView;
    protected SearchToolbarView _SearchToolbarView;

    public void setSearchToolbarView(@NonNull SearchToolbarView searchToolbarView) {
        _SearchToolbarView = searchToolbarView;
        _SearchToolbarView._OptionsViewListener = searchView -> _SearchResultsView.setSearchOptionsView(searchView);
        _SearchToolbarView._Search.setOnQueryTextListener(new SearchView.OnQueryTextListener() {
            @Override
            public boolean onQueryTextSubmit(String query) {
                if (_ViewModel == null)
                    return false;

                _ViewModel._Search._SearchString = query;
                _ViewModel._Search._SearchCharacter = _SearchToolbarView._SearchCharacter;
                _ViewModel._Search._SearchFaction = _SearchToolbarView._SearchFaction;
                _ViewModel._Search._SearchFilm = _SearchToolbarView._SearchFilm;
                _ViewModel._Search._SearchManufacturer = _SearchToolbarView._SearchManufacturer;
                _ViewModel._Search._SearchPlanet = _SearchToolbarView._SearchPlanet;
                _ViewModel._Search._SearchSpecie = _SearchToolbarView._SearchSpecie;
                _ViewModel._Search._SearchStarship = _SearchToolbarView._SearchStarship;
                _ViewModel._Search._SearchVehicle = _SearchToolbarView._SearchVehicle;
                _ViewModel._Search._SearchWeapon = _SearchToolbarView._SearchWeapon;

                _ViewModel.dataRequest();

                return true;
            }
            @Override
            public boolean onQueryTextChange(String newText) {
                return false;
            }
        });
    }

    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        _SearchResultsView = new SearchResultsView(inflater.getContext());
        _PageView = _SearchResultsView._SearchResults;

        super.onCreateView(inflater, container, savedInstanceState);

        return _SearchResultsView;
    }

    @Override
    protected void onPageViewItemsBindViewHolder(@NonNull PageItemsRecyclerView.ItemsViewHolder<StarWarsModel> holder, int position) {
        super.onPageViewItemsBindViewHolder(holder, position);

        if ((position = _PageViewItemsAdapter.getBindViewHolderPosition(position)) == -1)
            return;

        StarWarsModel model = _PageViewItemsAdapter._Items.get(position);

        holder._ViewModel = model;
        if (holder._PageItemView != null)
            holder._PageItemView.setStarWarsModel(model);
    }
}