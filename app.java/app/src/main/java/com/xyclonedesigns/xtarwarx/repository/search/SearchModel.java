package com.xyclonedesigns.xtarwarx.repository.search;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.repository.enums.StarWarsTypes;
import com.xyclonedesigns.xtarwarx.utils.JsonUtils;

import org.json.JSONException;
import org.json.JSONObject;

public class SearchModel {
    public @NonNull String _SearchString = "";

    public @Nullable CharacterSearchModel _SearchCharacter;
    public @Nullable FactionSearchModel _SearchFaction;
    public @Nullable FilmSearchModel _SearchFilm;
    public @Nullable ManufacturerSearchModel _SearchManufacturer;
    public @Nullable PlanetSearchModel _SearchPlanet;
    public @Nullable SpecieSearchModel _SearchSpecie;
    public @Nullable StarshipSearchModel _SearchStarship;
    public @Nullable VehicleSearchModel _SearchVehicle;
    public @Nullable WeaponSearchModel _SearchWeapon;

    public static class Result {
        public static class JsonKeys {
            public static final String Id = "id";
            public static final String MatchCount = "matchCount";
            public static final String StarWarsType = "starWarsType";
        }

        public Result() { }
        public Result(JSONObject json) throws JSONException {
            if (!json.isNull(JsonKeys.Id)) _Id = json.getInt(JsonKeys.Id);
            if (!json.isNull(JsonKeys.MatchCount)) _MatchCount = json.getInt(JsonKeys.MatchCount);
            if (!json.isNull(JsonKeys.StarWarsType)) _StarWarsType = StarWarsTypes.values()[json.getInt(JsonKeys.StarWarsType)];
        }

        public int _Id;
        public int _MatchCount;
        public StarWarsTypes _StarWarsType;
    }
}