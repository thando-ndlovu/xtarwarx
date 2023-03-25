package com.xyclonedesigns.xtarwarx.repository;

import android.content.Context;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.android.volley.Request;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;
import com.xyclonedesigns.xtarwarx.repository.models.CharacterModel;
import com.xyclonedesigns.xtarwarx.repository.models.FactionModel;
import com.xyclonedesigns.xtarwarx.repository.models.FilmModel;
import com.xyclonedesigns.xtarwarx.repository.models.ManufacturerModel;
import com.xyclonedesigns.xtarwarx.repository.models.PlanetModel;
import com.xyclonedesigns.xtarwarx.repository.models.SpecieModel;
import com.xyclonedesigns.xtarwarx.repository.models.StarshipModel;
import com.xyclonedesigns.xtarwarx.repository.models.VehicleModel;
import com.xyclonedesigns.xtarwarx.repository.models.WeaponModel;
import com.xyclonedesigns.xtarwarx.repository.search.CharacterSearchModel;
import com.xyclonedesigns.xtarwarx.repository.search.FactionSearchModel;
import com.xyclonedesigns.xtarwarx.repository.search.FilmSearchModel;
import com.xyclonedesigns.xtarwarx.repository.search.ManufacturerSearchModel;
import com.xyclonedesigns.xtarwarx.repository.search.PlanetSearchModel;
import com.xyclonedesigns.xtarwarx.repository.search.SearchModel;
import com.xyclonedesigns.xtarwarx.repository.search.SearchValuesModel;
import com.xyclonedesigns.xtarwarx.repository.search.SpecieSearchModel;
import com.xyclonedesigns.xtarwarx.repository.search.StarshipSearchModel;
import com.xyclonedesigns.xtarwarx.repository.search.TransporterSearchModel;
import com.xyclonedesigns.xtarwarx.repository.search.VehicleSearchModel;
import com.xyclonedesigns.xtarwarx.repository.search.WeaponSearchModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.CharacterSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.FactionSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.FilmSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.ManufacturerSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.PlanetSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.SpecieSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.StarshipSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.VehicleSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.WeaponSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.viewmodels.pagination.PaginationViewModel;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.Date;

public class StarWarsRepository_REST extends StarWarsRepository {
    public static class Options extends StarWarsRepository.Options {
        public Options(Context context) {
            _Context = context;
        }

        final Context _Context;

        @Override
        StarWarsRepository create() {
            return new StarWarsRepository_REST(_Context);
        }
    }
    protected static class QueryPaths {
        //static final String Base = "https://*:5001/Api/Rest";
        static final String Base = "https://192.168.0.110:5001/Api/Rest";

        static final String Characters = "/Characters";
        static final String Factions = "/Factions";
        static final String Films = "/Films";
        static final String Manufacturers = "/Manufacturers";
        static final String Planets = "/Planets";
        static final String Search = "/Search";
        static final String Species = "/Species";
        static final String Starships = "/Starships";
        static final String Vehicles = "/Vehicles";
        static final String Weapons = "/Weapons";
        static final String Meta = "/Meta";
    }
    protected static class QueryArguments {
        static final String Ids = "ids";
        static final String IdsToSkip = "idstoskip";
        static final String ItemsPerPage = "itemsperpage";
        static final String OrderBy = "orderby";
        static final String Page = "page";
        static final String Reverse = "reverse";

        QueryArguments(@Nullable PaginationViewModel paginationViewModel, @Nullable int ... ids) {
            if (paginationViewModel != null) {
                _ItemsPerPage = paginationViewModel._ItemsPerPage;
                _Page = paginationViewModel._Page;
                _OrderBy = paginationViewModel._SortKey;
                //_Reverse = paginationViewModel._Reverse;
            }

            if (ids != null)
                _Ids = ids;
        }

        @Nullable int[] _Ids;
        @Nullable int[] _IdsToSkip;
        @Nullable Integer _ItemsPerPage;
        @Nullable String _OrderBy;
        @Nullable Integer _Page;
        @Nullable Boolean _Reverse;

        @NonNull
        String toQueryArgumentsString() {
            boolean nopoint =
                    _Ids == null &&
                            _IdsToSkip == null &&
                            _ItemsPerPage == null &&
                            _OrderBy == null &&
                            _Page == null &&
                            _Reverse == null;

            if (nopoint) return "";

            StringBuilder stringbuilder = new StringBuilder();

            if (_Ids != null && _Ids.length > 0)
                for (int _id : _Ids)
                    stringbuilder
                            .append('&').append(Ids).append('=')
                            .append(_id);

            if (_IdsToSkip != null && _IdsToSkip.length > 0)
                for (int _idtoskip : _IdsToSkip)
                    stringbuilder
                            .append('&').append(IdsToSkip).append('=')
                            .append(_idtoskip);

            if (_ItemsPerPage != null) stringbuilder
                    .append('&').append(ItemsPerPage).append('=')
                    .append(_ItemsPerPage.intValue());

            if (_OrderBy != null) stringbuilder
                    .append('&').append(OrderBy).append('=')
                    .append(_OrderBy);

            if (_Page != null) stringbuilder
                    .append('&').append(Page).append('=')
                    .append(_Page);

            if (_Reverse != null) stringbuilder
                    .append('&').append(Reverse).append('=')
                    .append(_Reverse);

            return stringbuilder
                    .replace(0, 1, "?")
                    .toString()
                    .replace(" ", "%20");
        }
    }
    protected static class SearchArguments {
        SearchArguments(@NonNull SearchModel searchModel) {
            _SearchModel = searchModel;
        }

        SearchModel _SearchModel;

        @NonNull
        String toSearchArgumentsString() {
            StringBuilder stringbuilder = new StringBuilder()
                    .append("?searchString=").append(_SearchModel._SearchString);

            argumentsFrom(stringbuilder, "character", _SearchModel._SearchCharacter);
            argumentsFrom(stringbuilder, "faction", _SearchModel._SearchFaction);
            argumentsFrom(stringbuilder, "film", _SearchModel._SearchFilm);
            argumentsFrom(stringbuilder, "manufacturer", _SearchModel._SearchManufacturer);
            argumentsFrom(stringbuilder, "planet", _SearchModel._SearchPlanet);
            argumentsFrom(stringbuilder, "specie", _SearchModel._SearchSpecie);
            argumentsFrom(stringbuilder, "starship", _SearchModel._SearchStarship);
            argumentsFrom(stringbuilder, "vehicle", _SearchModel._SearchVehicle);
            argumentsFrom(stringbuilder, "weapon", _SearchModel._SearchWeapon);

            return stringbuilder
                    .toString()
                    .replace(" ", "%20");
        }

        static <T> void append(@NonNull StringBuilder stringbuilder, @Nullable String arg1, @NonNull String arg2, @Nullable T t) {
            if (t == null)
                return;

            stringbuilder.append('&');

            if (arg1 == null)
                stringbuilder.append(arg1);

            stringbuilder.append(arg2).append('=').append(t);
        }

        static <T> void argumentsFrom(@NonNull StringBuilder stringbuilder, @NonNull String arg, @Nullable CharacterSearchModel search) {
            if (search == null)
                return;

            argumentsFrom(stringbuilder, null, search._Containables);
            argumentsFrom(stringbuilder, "homeworld", search._Homeworld);

            argumentsFrom(stringbuilder,"birthYears", search._BirthYears);
            argumentsFrom(stringbuilder,"eyeColors", search._EyeColors);
            argumentsFrom(stringbuilder,"hairColors", search._HairColors);
            argumentsFrom(stringbuilder,"heights", search._Heights);
            argumentsFrom(stringbuilder,"masses", search._Masses);
            argumentsFrom(stringbuilder,"sexes", search._Sexes);
            argumentsFrom(stringbuilder,"skinColors", search._SkinColors);
        }
        static <T> void argumentsFrom(@NonNull StringBuilder stringbuilder, @NonNull String arg, @Nullable FactionSearchModel search) {
            if (search == null)
                return;

            argumentsFrom(stringbuilder, null, search._Containables);
            argumentsFrom(stringbuilder, "alliedcharacters", search._AlliedCharacters);
            argumentsFrom(stringbuilder, "alliedfactions", search._AlliedFactions);
            argumentsFrom(stringbuilder, "alliedcharacters", search._AlliedCharacters);
            argumentsFrom(stringbuilder, "alliedcharacters", search._AlliedCharacters);
            argumentsFrom(stringbuilder, "alliedfactions", search._AlliedFactions);
        }
        static <T> void argumentsFrom(@NonNull StringBuilder stringbuilder, @NonNull String arg, @Nullable FilmSearchModel search) {
            if (search == null)
                return;

            argumentsFrom(stringbuilder, null, search._Containables);
            argumentsFrom(stringbuilder, "characters", search._Characters);
            argumentsFrom(stringbuilder, "factions", search._Factions);
            argumentsFrom(stringbuilder, "manufacturers", search._Manufacturers);
            argumentsFrom(stringbuilder, "planets", search._Planets);
            argumentsFrom(stringbuilder, "species", search._Species);
            argumentsFrom(stringbuilder, "starships", search._Starships);
            argumentsFrom(stringbuilder, "vehicles", search._Vehicles);
            argumentsFrom(stringbuilder, "weapons", search._Weapons);

            argumentsFrom(stringbuilder, "durations", search._Durations);
            argumentsFrom(stringbuilder, "episodeIds", search._EpisodeIds);
            argumentsFrom(stringbuilder, "releaseDates", search._ReleaseDates);
        }
        static <T> void argumentsFrom(@NonNull StringBuilder stringbuilder, @NonNull String arg, @Nullable ManufacturerSearchModel search) {
            if (search == null)
                return;

            argumentsFrom(stringbuilder, null, search._Containables);
            argumentsFrom(stringbuilder, "headquartersPlanet", search._HeadquartersPlanet);
            argumentsFrom(stringbuilder, "starships", search._Starships);
            argumentsFrom(stringbuilder, "vehicles", search._Vehicles);
            argumentsFrom(stringbuilder, "weapons", search._Weapons);
        }
        static <T> void argumentsFrom(@NonNull StringBuilder stringbuilder, @NonNull String arg, @Nullable PlanetSearchModel search) {
            if (search == null)
                return;

            argumentsFrom(stringbuilder, null, search._Containables);
            argumentsFrom(stringbuilder, "residents", search._Residents);

            argumentsFrom(stringbuilder, "climateFlags", search._ClimateFlags);
            argumentsFrom(stringbuilder, "climateTypes", search._ClimateTypes);
            argumentsFrom(stringbuilder, "diameters", search._Diameters);
            argumentsFrom(stringbuilder, "gravities", search._Gravities);
            argumentsFrom(stringbuilder, "orbitalPeriods", search._OrbitalPeriods);
            argumentsFrom(stringbuilder, "populations", search._Populations);
            argumentsFrom(stringbuilder, "rotationalPeriods", search._RotationalPeriods);
            argumentsFrom(stringbuilder, "surfaceWaters", search._SurfaceWaters);
            argumentsFrom(stringbuilder, "terrainFlags", search._TerrainFlags);
            argumentsFrom(stringbuilder, "terrainTypes", search._TerrainTypes);
        }
        static <T> void argumentsFrom(@NonNull StringBuilder stringbuilder, @NonNull String arg, @Nullable SpecieSearchModel search) {
            if (search == null)
                return;

            argumentsFrom(stringbuilder, null, search._Containables);
            argumentsFrom(stringbuilder, "characters", search._Characters);
            argumentsFrom(stringbuilder, "homeworld", search._Homeworld);

            argumentsFrom(stringbuilder,"averageHeights", search._AverageHeights);
            argumentsFrom(stringbuilder,"averageLifespans", search._AverageLifespans);
            argumentsFrom(stringbuilder,"classifications", search._Classifications);
            argumentsFrom(stringbuilder,"designations", search._Designations);
            argumentsFrom(stringbuilder,"eyeColors", search._EyeColors);
            argumentsFrom(stringbuilder,"hairColors", search._HairColors);
            argumentsFrom(stringbuilder,"languages", search._Languages);
            argumentsFrom(stringbuilder,"skinColors", search._SkinColors);
        }
        static <T> void argumentsFrom(@NonNull StringBuilder stringbuilder, @NonNull String arg, @Nullable TransporterSearchModel search) {
            if (search == null)
                return;

            argumentsFrom(stringbuilder, "manufacturers", search._Manufacturers);
            argumentsFrom(stringbuilder, "pilots", search._Pilots);

            argumentsFrom(stringbuilder, "cargoCapacities", search._CargoCapacities);
            argumentsFrom(stringbuilder, "consumables", search._Consumables);
            argumentsFrom(stringbuilder, "costInCredits", search._CostInCredits);
            argumentsFrom(stringbuilder, "lengths", search._Lengths);
            argumentsFrom(stringbuilder, "maxAtmospheringSpeeds", search._MaxAtmospheringSpeeds);
            argumentsFrom(stringbuilder, "maxCrews", search._MaxCrews);
            argumentsFrom(stringbuilder, "minCrews", search._MinCrews);
            argumentsFrom(stringbuilder, "passengers", search._Passengers);
        }
        static <T> void argumentsFrom(@NonNull StringBuilder stringbuilder, @NonNull String arg, @Nullable StarshipSearchModel search) {
            if (search == null)
                return;

            argumentsFrom(stringbuilder, arg, (TransporterSearchModel) search);

            argumentsFrom(stringbuilder, null, search._Containables);

            argumentsFrom(stringbuilder, "hyperdriveRatings", search._HyperdriveRatings);
            argumentsFrom(stringbuilder, "mglts", search._MGLTs);
        }
        static <T> void argumentsFrom(@NonNull StringBuilder stringbuilder, @NonNull String arg, @Nullable VehicleSearchModel search) {
            if (search == null)
                return;

            argumentsFrom(stringbuilder, arg, (TransporterSearchModel) search);

            argumentsFrom(stringbuilder, null, search._Containables);
        }
        static <T> void argumentsFrom(@NonNull StringBuilder stringbuilder, @NonNull String arg, @Nullable WeaponSearchModel search) {
            if (search == null)
                return;

            argumentsFrom(stringbuilder, null, search._Containables);
            argumentsFrom(stringbuilder, "manufacturers", search._Manufacturers);
        }
        static <T> void argumentsFrom(@NonNull StringBuilder stringbuilder, @Nullable String arg, @Nullable CharacterSearchContainablesModel searchContainables) {
            if (searchContainables == null)
                return;

            append(stringbuilder, arg, "Description", searchContainables._Description);
            append(stringbuilder, arg, "Name", searchContainables._Name);
        }
        static <T> void argumentsFrom(@NonNull StringBuilder stringbuilder, @Nullable String arg, @Nullable FactionSearchContainablesModel searchContainables) {
            if (searchContainables == null)
                return;

            append(stringbuilder, arg, "Description", searchContainables._Description);
            append(stringbuilder, arg, "OrganisationTypes", searchContainables._OrganisationTypes);
            append(stringbuilder, arg, "Name", searchContainables._Name);
        }
        static <T> void argumentsFrom(@NonNull StringBuilder stringbuilder, @Nullable String arg, @Nullable FilmSearchContainablesModel searchContainables) {
            if (searchContainables == null)
                return;

            append(stringbuilder, arg, "CastMembers", searchContainables._CastMembers);
            append(stringbuilder, arg, "Description", searchContainables._Description);
            append(stringbuilder, arg, "Director", searchContainables._Director);
            append(stringbuilder, arg, "OpeningCrawl", searchContainables._OpeningCrawl);
            append(stringbuilder, arg, "Producers", searchContainables._Producers);
            append(stringbuilder, arg, "Title", searchContainables._Title);
        }
        static <T> void argumentsFrom(@NonNull StringBuilder stringbuilder, @Nullable String arg, @Nullable ManufacturerSearchContainablesModel searchContainables) {
            if (searchContainables == null)
                return;

            append(stringbuilder, arg, "Description", searchContainables._Description );
            append(stringbuilder, arg, "Name", searchContainables._Name);
        }
        static <T> void argumentsFrom(@NonNull StringBuilder stringbuilder, @Nullable String arg, @Nullable PlanetSearchContainablesModel searchContainables) {
            if (searchContainables == null)
                return;

            append(stringbuilder, arg, "Description", searchContainables._Description);
            append(stringbuilder, arg, "Name", searchContainables._Name);
        }
        static <T> void argumentsFrom(@NonNull StringBuilder stringbuilder, @Nullable String arg, @Nullable SpecieSearchContainablesModel searchContainables) {
            if (searchContainables == null)
                return;

            append(stringbuilder, arg, "Description", searchContainables._Description);
            append(stringbuilder, arg, "Name", searchContainables._Name);
        }
        static <T> void argumentsFrom(@NonNull StringBuilder stringbuilder, @Nullable String arg, @Nullable StarshipSearchContainablesModel searchContainables) {
            if (searchContainables == null)
                return;

            append(stringbuilder, arg, "Description", searchContainables._Description);
            append(stringbuilder, arg, "Model", searchContainables._Model);
            append(stringbuilder, arg, "Name", searchContainables._Name);
            append(stringbuilder, arg, "StarshipClass", searchContainables._StarshipClass);
            append(stringbuilder, arg, "StarshipClassFlags", searchContainables._StarshipClassFlags);
        }
        static <T> void argumentsFrom(@NonNull StringBuilder stringbuilder, @Nullable String arg, @Nullable VehicleSearchContainablesModel searchContainables) {
            if (searchContainables == null)
                return;

            append(stringbuilder, arg, "Description", searchContainables._Description);
            append(stringbuilder, arg, "Model", searchContainables._Model);
            append(stringbuilder, arg, "Name", searchContainables._Name);
            append(stringbuilder, arg, "VehicleClass", searchContainables._VehicleClass);
            append(stringbuilder, arg, "VehicleClassFlags", searchContainables._VehicleClassFlags);
        }
        static <T> void argumentsFrom(@NonNull StringBuilder stringbuilder, @Nullable String arg, @Nullable WeaponSearchContainablesModel searchContainables) {
            if (searchContainables == null)
                return;

            append(stringbuilder, arg, "Description", searchContainables._Description);
            append(stringbuilder, arg, "Model", searchContainables._Model);
            append(stringbuilder, arg, "Name", searchContainables._Name);
            append(stringbuilder, arg, "WeaponClass", searchContainables._WeaponClass);
            append(stringbuilder, arg, "WeaponClassFlags", searchContainables._WeaponClassFlags);
        }
        static <T> void argumentsFrom(@NonNull StringBuilder stringbuilder, @Nullable String arg, @Nullable SearchValuesModel<T> searchValuesModel) {
            if (searchValuesModel == null)
                return;

            if (searchValuesModel._Values != null && searchValuesModel._Values.size() > 0)
                for (T value : searchValuesModel._Values)
                    append(stringbuilder, arg, "s", value);

            append(stringbuilder, arg, "RangeLower", searchValuesModel._Lower);
            append(stringbuilder, arg, "RangeUpper", searchValuesModel._Upper);
        }
    }
    protected static class MetaArguments {
        static final String AdditionsSince = "additionsSince";
        static final String EditsSince = "editsSince";

        MetaArguments(@Nullable Date additionsSince, @Nullable Date editsSince) {
            _AdditionsSince = additionsSince;
            _EditsSince = editsSince;
        }

        @Nullable Date _AdditionsSince;
        @Nullable Date _EditsSince;

        @NonNull
        String toQueryArgumentsString() {
            StringBuilder stringbuilder = new StringBuilder();

            if (_AdditionsSince != null) stringbuilder
                    .append('&').append(AdditionsSince).append('=')
                    .append(_AdditionsSince);

            if (_EditsSince != null) stringbuilder
                    .append('&').append(EditsSince).append('=')
                    .append(_EditsSince);

            return stringbuilder
                    .replace(0, 1, "?")
                    .toString()
                    .replace(" ", "%20");
        }
    }

    private StarWarsRepository_REST(Context context) {
        super();

        _Characters = new RepositoryCharactersREST(context);
        _Factions = new RepositoryFactionsREST(context);
        _Films = new RepositoryFilmsREST(context);
        _Manufacturers = new RepositoryManufacturersREST(context);
        _Planets = new RepositoryPlanetsREST(context);
        _Species = new RepositorySpeciesREST(context);
        _Starships = new RepositoryStarshipsREST(context);
        _Vehicles = new RepositoryVehiclesREST(context);
        _Weapons = new RepositoryWeaponsREST(context);
        _Search = new RepositorySearchREST(context);
    }

    static abstract class RepositoryREST<T> implements Repository<T> {
        @Override
        public abstract void get(@NonNull DataCallback<T> callback, @Nullable PaginationViewModel paginationviewmodel, @Nullable int... ids);
        @Override
        public void get(@NonNull DataCallback<T> callback, @Nullable PaginationViewModel paginationviewmodel, @Nullable ArrayList<Integer> ids) {
            if (ids == null) {
                get(callback, paginationviewmodel);

                return;
            }

            int[] idsarray = new int[ids.size()];

            for (int index = 0; index < ids.size(); index++)
                idsarray[index] = ids.get(index);

            get(callback, paginationviewmodel, idsarray);
        }

        RepositoryREST(Context context) {
            _Context = context;
        }

        final Context _Context;
    }

    public static class RepositoryCharactersREST extends RepositoryREST<CharacterModel> implements StarWarsRepository.RepositoryCharacters {
        static final String _Path = QueryPaths.Base + QueryPaths.Characters;

        RepositoryCharactersREST(Context context) {
            super(context);
        }

        @Override
        public void get(@NonNull DataCallback<CharacterModel> callback, @Nullable PaginationViewModel paginationViewModel, @Nullable int ... ids) {
            QueryArguments queryarguments = new QueryArguments(paginationViewModel, ids);
            String url = _Path + queryarguments.toQueryArgumentsString();

            Volley.newRequestQueue(_Context)
                    .add(new StringRequest(Request.Method.GET, url, response -> {

                        try {
                            callback.dataCallback(new Data<CharacterModel>(response) {
                                @Override
                                protected ArrayList<CharacterModel> onItems(JSONArray items) {
                                    ArrayList<CharacterModel> models = new ArrayList<>();

                                    for (int index = 0; index < items.length(); index++)
                                        try {
                                            JSONObject itemobj = items.getJSONObject(index);
                                            CharacterModel model = new CharacterModel(itemobj);
                                            models.add(model);
                                        } catch (JSONException e) {
                                            e.printStackTrace();
                                        }

                                    return models;
                                }
                            });
                        } catch (JSONException e) {
                            e.printStackTrace();
                        }

                    }, error -> { }));
        }
    }
    public static class RepositoryFactionsREST extends RepositoryREST<FactionModel> implements StarWarsRepository.RepositoryFactions {
        static final String _Path = QueryPaths.Base + QueryPaths.Factions;

        RepositoryFactionsREST(Context context) {
            super(context);
        }

        @Override
        public void get(@NonNull DataCallback<FactionModel> callback, @Nullable PaginationViewModel paginationViewModel, @Nullable int ... ids) {
            QueryArguments queryarguments = new QueryArguments(paginationViewModel, ids);
            String url = _Path + queryarguments.toQueryArgumentsString();

            Volley.newRequestQueue(_Context)
                    .add(new StringRequest(Request.Method.GET, url, response -> {

                        try {
                            callback.dataCallback(new Data<FactionModel>(response) {
                                @Override
                                protected ArrayList<FactionModel> onItems(JSONArray items) {
                                    ArrayList<FactionModel> models = new ArrayList<>();

                                    for (int index = 0; index < items.length(); index++)
                                        try {
                                            JSONObject itemobj = items.getJSONObject(index);
                                            FactionModel model = new FactionModel(itemobj);
                                            models.add(model);
                                        } catch (JSONException e) {
                                            e.printStackTrace();
                                        }

                                    return models;
                                }
                            });
                        } catch (JSONException e) {
                            e.printStackTrace();
                        }

                    }, error -> { }));
        }
    }
    public static class RepositoryFilmsREST extends RepositoryREST<FilmModel> implements StarWarsRepository.RepositoryFilms {
        static final String _Path = QueryPaths.Base + QueryPaths.Films;

        RepositoryFilmsREST(Context context) {
            super(context);
        }

        @Override
        public void get(@NonNull DataCallback<FilmModel> callback, @Nullable PaginationViewModel paginationViewModel, @Nullable int ... ids) {
            QueryArguments queryarguments = new QueryArguments(paginationViewModel, ids);
            String url = _Path + queryarguments.toQueryArgumentsString();

            Volley.newRequestQueue(_Context)
                    .add(new StringRequest(Request.Method.GET, url, response -> {

                        try {
                            callback.dataCallback(new Data<FilmModel>(response) {
                                @Override
                                protected ArrayList<FilmModel> onItems(JSONArray items) {
                                    ArrayList<FilmModel> models = new ArrayList<>();

                                    for (int index = 0; index < items.length(); index++)
                                        try {
                                            JSONObject itemobj = items.getJSONObject(index);
                                            FilmModel model = new FilmModel(itemobj);
                                            models.add(model);
                                        } catch (JSONException e) {
                                            e.printStackTrace();
                                        }

                                    return models;
                                }
                            });
                        } catch (JSONException e) {
                            e.printStackTrace();
                        }

                    }, error -> { }));
        }
    }
    public static class RepositoryManufacturersREST extends RepositoryREST<ManufacturerModel> implements StarWarsRepository.RepositoryManufacturers {
        static final String _Path = QueryPaths.Base + QueryPaths.Manufacturers;

        RepositoryManufacturersREST(Context context) {
            super(context);
        }

        @Override
        public void get(@NonNull DataCallback<ManufacturerModel> callback, @Nullable PaginationViewModel paginationViewModel, @Nullable int ... ids) {
            QueryArguments queryarguments = new QueryArguments(paginationViewModel, ids);
            String url = _Path + queryarguments.toQueryArgumentsString();

            Volley.newRequestQueue(_Context)
                    .add(new StringRequest(Request.Method.GET, url, response -> {

                        try {
                            callback.dataCallback(new Data<ManufacturerModel>(response) {
                                @Override
                                protected ArrayList<ManufacturerModel> onItems(JSONArray items) {
                                    ArrayList<ManufacturerModel> models = new ArrayList<>();

                                    for (int index = 0; index < items.length(); index++)
                                        try {
                                            JSONObject itemobj = items.getJSONObject(index);
                                            ManufacturerModel model = new ManufacturerModel(itemobj);
                                            models.add(model);
                                        } catch (JSONException e) {
                                            e.printStackTrace();
                                        }

                                    return models;
                                }
                            });
                        } catch (JSONException e) {
                            e.printStackTrace();
                        }

                    }, error -> { }));
        }
    }
    public static class RepositoryMetaREST implements StarWarsRepository.RepositorySearch {
        static final String _Path = QueryPaths.Base + QueryPaths.Meta;

        RepositoryMetaREST(Context context) {
            _Context = context;
        }

        final Context _Context;

        @Override
        public void get(@NonNull DataCallback<SearchModel.Result> callback, @NonNull SearchModel searchModel) {
            SearchArguments searcharguments = new SearchArguments(searchModel);
            String url = _Path + searcharguments.toSearchArgumentsString();

            Volley.newRequestQueue(_Context)
                    .add(new StringRequest(Request.Method.GET, url, response -> {

                        try {
                            callback.dataCallback(new Data<SearchModel.Result>(response) {
                                @Override
                                protected ArrayList<SearchModel.Result> onItems(JSONArray items) {
                                    ArrayList<SearchModel.Result> models = new ArrayList<>();

                                    for (int index = 0; index < items.length(); index++)
                                        try {
                                            JSONObject itemobj = items.getJSONObject(index);
                                            SearchModel.Result model = new SearchModel.Result(itemobj);
                                            models.add(model);
                                        } catch (JSONException e) {
                                            e.printStackTrace();
                                        }

                                    return models;
                                }
                            });
                        } catch (JSONException e) {
                            e.printStackTrace();
                        }

                    }, error -> { }));
        }
    }
    public static class RepositoryPlanetsREST extends RepositoryREST<PlanetModel> implements StarWarsRepository.RepositoryPlanets {
        static final String _Path = QueryPaths.Base + QueryPaths.Planets;

        RepositoryPlanetsREST(Context context) {
            super(context);
        }

        @Override
        public void get(@NonNull DataCallback<PlanetModel> callback, @Nullable PaginationViewModel paginationViewModel, @Nullable int ... ids) {
            QueryArguments queryarguments = new QueryArguments(paginationViewModel, ids);
            String url = _Path + queryarguments.toQueryArgumentsString();

            Volley.newRequestQueue(_Context)
                    .add(new StringRequest(Request.Method.GET, url, response -> {

                        try {
                            callback.dataCallback(new Data<PlanetModel>(response) {
                                @Override
                                protected ArrayList<PlanetModel> onItems(JSONArray items) {
                                    ArrayList<PlanetModel> models = new ArrayList<>();

                                    for (int index = 0; index < items.length(); index++)
                                        try {
                                            JSONObject itemobj = items.getJSONObject(index);
                                            PlanetModel model = new PlanetModel(itemobj);
                                            models.add(model);
                                        } catch (JSONException e) {
                                            e.printStackTrace();
                                        }

                                    return models;
                                }
                            });
                        } catch (JSONException e) {
                            e.printStackTrace();
                        }

                    }, error -> { }));
        }
    }
    public static class RepositorySearchREST implements StarWarsRepository.RepositorySearch {
        static final String _Path = QueryPaths.Base + QueryPaths.Search;

        RepositorySearchREST(Context context) {
            _Context = context;
        }

        final Context _Context;

        @Override
        public void get(@NonNull DataCallback<SearchModel.Result> callback, @NonNull SearchModel searchModel) {
            SearchArguments searcharguments = new SearchArguments(searchModel);
            String url = _Path + searcharguments.toSearchArgumentsString();

            Volley.newRequestQueue(_Context)
                    .add(new StringRequest(Request.Method.GET, url, response -> {

                        try {
                            callback.dataCallback(new Data<SearchModel.Result>(response) {
                                @Override
                                protected ArrayList<SearchModel.Result> onItems(JSONArray items) {
                                    ArrayList<SearchModel.Result> models = new ArrayList<>();

                                    for (int index = 0; index < items.length(); index++)
                                        try {
                                            JSONObject itemobj = items.getJSONObject(index);
                                            SearchModel.Result model = new SearchModel.Result(itemobj);
                                            models.add(model);
                                        } catch (JSONException e) {
                                            e.printStackTrace();
                                        }

                                    return models;
                                }
                            });
                        } catch (JSONException e) {
                            e.printStackTrace();
                        }

                    }, error -> { }));
        }
    }
    public static class RepositorySpeciesREST extends RepositoryREST<SpecieModel> implements StarWarsRepository.RepositorySpecies {
        static final String _Path = QueryPaths.Base + QueryPaths.Species;

        RepositorySpeciesREST(Context context) {
            super(context);
        }

        @Override
        public void get(@NonNull DataCallback<SpecieModel> callback, @Nullable PaginationViewModel paginationViewModel, @Nullable int ... ids) {
            QueryArguments queryarguments = new QueryArguments(paginationViewModel, ids);
            String url = _Path + queryarguments.toQueryArgumentsString();

            Volley.newRequestQueue(_Context)
                    .add(new StringRequest(Request.Method.GET, url, response -> {

                        try {
                            callback.dataCallback(new Data<SpecieModel>(response) {
                                @Override
                                protected ArrayList<SpecieModel> onItems(JSONArray items) {
                                    ArrayList<SpecieModel> models = new ArrayList<>();

                                    for (int index = 0; index < items.length(); index++)
                                        try {
                                            JSONObject itemobj = items.getJSONObject(index);
                                            SpecieModel model = new SpecieModel(itemobj);
                                            models.add(model);
                                        } catch (JSONException e) {
                                            e.printStackTrace();
                                        }

                                    return models;
                                }
                            });
                        } catch (JSONException e) {
                            e.printStackTrace();
                        }

                    }, error -> { }));
        }
    }
    public static class RepositoryStarshipsREST extends RepositoryREST<StarshipModel> implements StarWarsRepository.RepositoryStarships {
        static final String _Path = QueryPaths.Base + QueryPaths.Starships;

        RepositoryStarshipsREST(Context context) {
            super(context);
        }

        @Override
        public void get(@NonNull DataCallback<StarshipModel> callback, @Nullable PaginationViewModel paginationViewModel, @Nullable int ... ids) {
            QueryArguments queryarguments = new QueryArguments(paginationViewModel, ids);
            String url = _Path + queryarguments.toQueryArgumentsString();

            Volley.newRequestQueue(_Context)
                    .add(new StringRequest(Request.Method.GET, url, response -> {

                        try {
                            callback.dataCallback(new Data<StarshipModel>(response) {
                                @Override
                                protected ArrayList<StarshipModel> onItems(JSONArray items) {
                                    ArrayList<StarshipModel> models = new ArrayList<>();

                                    for (int index = 0; index < items.length(); index++)
                                        try {
                                            JSONObject itemobj = items.getJSONObject(index);
                                            StarshipModel model = new StarshipModel(itemobj);
                                            models.add(model);
                                        } catch (JSONException e) {
                                            e.printStackTrace();
                                        }

                                    return models;
                                }
                            });
                        } catch (JSONException e) {
                            e.printStackTrace();
                        }

                    }, error -> { }));
        }
    }
    public static class RepositoryVehiclesREST extends RepositoryREST<VehicleModel> implements StarWarsRepository.RepositoryVehicles {
        static final String _Path = QueryPaths.Base + QueryPaths.Vehicles;

        RepositoryVehiclesREST(Context context) {
            super(context);
        }

        @Override
        public void get(@NonNull DataCallback<VehicleModel> callback, @Nullable PaginationViewModel paginationViewModel, @Nullable int ... ids){
            QueryArguments queryarguments = new QueryArguments(paginationViewModel, ids);
            String url = _Path + queryarguments.toQueryArgumentsString();

            Volley.newRequestQueue(_Context)
                    .add(new StringRequest(Request.Method.GET, url, response -> {

                        try {
                            callback.dataCallback(new Data<VehicleModel>(response) {
                                @Override
                                protected ArrayList<VehicleModel> onItems(JSONArray items) {
                                    ArrayList<VehicleModel> models = new ArrayList<>();

                                    for (int index = 0; index < items.length(); index++)
                                        try {
                                            JSONObject itemobj = items.getJSONObject(index);
                                            VehicleModel model = new VehicleModel(itemobj);
                                            models.add(model);
                                        } catch (JSONException e) {
                                            e.printStackTrace();
                                        }

                                    return models;
                                }
                            });
                        } catch (JSONException e) {
                            e.printStackTrace();
                        }

                    }, error -> { }));
        }
    }
    public static class RepositoryWeaponsREST extends RepositoryREST<WeaponModel> implements StarWarsRepository.RepositoryWeapons {
        static final String _Path = QueryPaths.Base + QueryPaths.Weapons;

        RepositoryWeaponsREST(Context context) {
            super(context);
        }

        @Override
        public void get(@NonNull DataCallback<WeaponModel> callback, @Nullable PaginationViewModel paginationViewModel, @Nullable int ... ids) {
            QueryArguments queryarguments = new QueryArguments(paginationViewModel, ids);
            String url = _Path + queryarguments.toQueryArgumentsString();

            Volley.newRequestQueue(_Context)
                    .add(new StringRequest(Request.Method.GET, url, response -> {

                        try {
                            callback.dataCallback(new Data<WeaponModel>(response) {
                                @Override
                                protected ArrayList<WeaponModel> onItems(JSONArray items) {
                                    ArrayList<WeaponModel> models = new ArrayList<>();

                                    for (int index = 0; index < items.length(); index++)
                                        try {
                                            JSONObject itemobj = items.getJSONObject(index);
                                            WeaponModel model = new WeaponModel(itemobj);
                                            models.add(model);
                                        } catch (JSONException e) {
                                            e.printStackTrace();
                                        }

                                    return models;
                                }
                            });
                        } catch (JSONException e) {
                            e.printStackTrace();
                        }

                    }, error -> { }));
        }
    }
}