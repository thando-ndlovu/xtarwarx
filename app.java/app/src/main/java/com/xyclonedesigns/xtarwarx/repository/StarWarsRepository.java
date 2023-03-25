package com.xyclonedesigns.xtarwarx.repository;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

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
import com.xyclonedesigns.xtarwarx.viewmodels.pagination.PaginationViewModel;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;

public abstract class StarWarsRepository {
    private static StarWarsRepository _Instance;

    public static abstract class Options {
        abstract StarWarsRepository create();
    }
    public static abstract class Data<T> {
        static final String JsonKey_Page = "page";
        static final String JsonKey_Pages = "pages";
        static final String JsonKey_Items = "items";
        public Data(Object callbackdata) throws JSONException {
            JSONObject jsonobject = new JSONObject(callbackdata.toString());

            _Page = jsonobject.isNull(JsonKey_Page) ? 1 : jsonobject.getInt(JsonKey_Page);
            _Pages = jsonobject.isNull(JsonKey_Pages) ? 1 : jsonobject.getInt(JsonKey_Pages);
            _Items = onItems(jsonobject.getJSONArray(JsonKey_Items));
        }

        public final int _Page;
        public final int _Pages;
        public final ArrayList<T> _Items;

        protected abstract ArrayList<T> onItems(JSONArray items);
    }

    public static void init(Options options) {
        _Instance = options.create();
    }
    public static StarWarsRepository instance() {
        return _Instance;
    }

    protected StarWarsRepository() { }
    protected RepositoryCharacters _Characters;
    protected RepositoryFactions _Factions;
    protected RepositoryFilms _Films;
    protected RepositoryManufacturers _Manufacturers;
    protected RepositoryPlanets _Planets;
    protected RepositorySpecies _Species;
    protected RepositoryStarships _Starships;
    protected RepositoryVehicles _Vehicles;
    protected RepositoryWeapons _Weapons;
    protected RepositorySearch _Search;

    public RepositoryCharacters characters() {
        return _Characters;
    }
    public RepositoryFactions factions() {
        return _Factions;
    }
    public RepositoryFilms films() {
        return _Films;
    }
    public RepositoryManufacturers manufacturers() {
        return _Manufacturers;
    }
    public RepositoryPlanets planets() {
        return _Planets;
    }
    public RepositorySpecies species() {
        return _Species;
    }
    public RepositoryStarships starships() {
        return _Starships;
    }
    public RepositoryVehicles vehicles() {
        return _Vehicles;
    }
    public RepositoryWeapons weapons() {
        return _Weapons;
    }
    public RepositorySearch search() {
        return _Search;
    }

    public interface DataRequest<T> {
        void dataRequest();
    }
    public interface DataCallback<T> {
        void dataCallback(Data<T> data);
    }

    public interface Repository<T> {
        void get(
                @NonNull DataCallback<T> callback,
                @Nullable PaginationViewModel paginationviewmodel,
                @Nullable int ... ids);
        void get(
                @NonNull DataCallback<T> callback,
                @Nullable PaginationViewModel paginationviewmodel,
                @Nullable ArrayList<Integer> ids);
    }
    public interface RepositoryCharacters extends Repository<CharacterModel> { }
    public interface RepositoryFactions extends Repository<FactionModel> { }
    public interface RepositoryFilms extends Repository<FilmModel> { }
    public interface RepositoryManufacturers extends Repository<ManufacturerModel> { }
    public interface RepositoryPlanets extends Repository<PlanetModel> { }
    public interface RepositorySpecies extends Repository<SpecieModel> { }
    public interface RepositoryStarships extends Repository<StarshipModel> { }
    public interface RepositoryVehicles extends Repository<VehicleModel> { }
    public interface RepositoryWeapons extends Repository<WeaponModel> { }
    public interface RepositorySearch {
        void get(
                @NonNull DataCallback<SearchModel.Result> callback,
                @NonNull SearchModel searchModel);
    }
}