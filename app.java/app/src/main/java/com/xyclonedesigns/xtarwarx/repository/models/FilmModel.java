package com.xyclonedesigns.xtarwarx.repository.models;

import android.content.Context;

import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.utils.JsonUtils;

import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Date;

public class FilmModel extends StarWarsModel {
    public FilmModel(int id) {
        super(id);
    }
    public FilmModel(JSONObject json) throws JSONException {
        super(json);

        if (!json.isNull(JsonKeys.CastMembers)) _CastMembers = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.CastMembers), Object::toString);
        if (!json.isNull(JsonKeys.CharacterIds)) _CharacterIds = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.CharacterIds), obj -> Integer.parseInt(obj.toString()));
        if (!json.isNull(JsonKeys.Description)) _Description = json.getString(JsonKeys.Description);
        if (!json.isNull(JsonKeys.Director)) _Director = json.getString(JsonKeys.Director);
        if (!json.isNull(JsonKeys.Duration)) _Duration = json.getInt(JsonKeys.Duration);
        if (!json.isNull(JsonKeys.EpisodeId)) _EpisodeId = json.getInt(JsonKeys.EpisodeId);
        if (!json.isNull(JsonKeys.FactionIds)) _FactionIds = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.FactionIds), obj -> Integer.parseInt(obj.toString()));
        if (!json.isNull(JsonKeys.ManufacturerIds)) _ManufacturerIds = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.ManufacturerIds), obj -> Integer.parseInt(obj.toString()));
        if (!json.isNull(JsonKeys.OpeningCrawl)) _OpeningCrawl = json.getString(JsonKeys.OpeningCrawl);
        if (!json.isNull(JsonKeys.PlanetIds)) _PlanetIds = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.PlanetIds), obj -> Integer.parseInt(obj.toString()));
        if (!json.isNull(JsonKeys.Producers)) _Producers = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.Producers), Object::toString);
        if (!json.isNull(JsonKeys.ReleaseDate)) _ReleaseDate = JsonUtils.fromStringDate(json.getString(JsonKeys.ReleaseDate));
        if (!json.isNull(JsonKeys.SpecieIds)) _SpecieIds = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.SpecieIds), obj -> Integer.parseInt(obj.toString()));
        if (!json.isNull(JsonKeys.StarshipIds)) _StarshipIds = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.StarshipIds), obj -> Integer.parseInt(obj.toString()));
        if (!json.isNull(JsonKeys.Title)) _Title = json.getString(JsonKeys.Title);
        if (!json.isNull(JsonKeys.VehicleIds)) _VehicleIds = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.VehicleIds), obj -> Integer.parseInt(obj.toString()));
        if (!json.isNull(JsonKeys.WeaponIds)) _WeaponIds = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.WeaponIds), obj -> Integer.parseInt(obj.toString()));
    }

    public @Nullable ArrayList<String> _CastMembers;
    public @Nullable ArrayList<Integer> _CharacterIds;
    public @Nullable String _Description;
    public @Nullable String _Director;
    public @Nullable Integer _Duration;
    public @Nullable Integer _EpisodeId;
    public @Nullable ArrayList<Integer> _FactionIds;
    public @Nullable ArrayList<Integer> _ManufacturerIds;
    public @Nullable String _OpeningCrawl;
    public @Nullable ArrayList<Integer> _PlanetIds;
    public @Nullable ArrayList<String> _Producers;
    public @Nullable Date _ReleaseDate;
    public @Nullable ArrayList<Integer> _SpecieIds;
    public @Nullable ArrayList<Integer> _StarshipIds;
    public @Nullable String _Title;
    public @Nullable ArrayList<Integer> _VehicleIds;
    public @Nullable ArrayList<Integer> _WeaponIds;

    public static class JsonKeys extends StarWarsModel.JsonKeys {
        public static final String CastMembers = "castMembers";
        public static final String CharacterIds = "characterIds";
        public static final String Description = "description";
        public static final String Director = "director";
        public static final String Duration = "duration";
        public static final String EpisodeId = "episodeId";
        public static final String FactionIds = "factionIds";
        public static final String ManufacturerIds = "manufacturerIds";
        public static final String OpeningCrawl = "openingCrawl";
        public static final String PlanetIds = "planetIds";
        public static final String Producers = "producers";
        public static final String ReleaseDate = "releaseDate";
        public static final String SpecieIds = "specieIds";
        public static final String StarshipIds = "starshipIds";
        public static final String Title = "title";
        public static final String VehicleIds = "vehicleIds";
        public static final String WeaponIds = "weaponIds";
    }
    public static class SortKeys extends StarWarsModel.SortKeys {
        public static final String CastMemberCount = "castmembercount";
        public static final String CharacterCount = "charactercount";
        public static final String Director = "director";
        public static final String Duration = "duration";
        public static final String EpisodeId = "episodeid";
        public static final String FactionCount = "factioncount";
        public static final String ManufacturerCount = "manufacturercount";
        public static final String PlanetCount = "planetcount";
        public static final String ProducersCount = "producerscount";
        public static final String ReleaseDate = "releasedate";
        public static final String SpecieCount = "speciecount";
        public static final String StarshipCount = "starshipcount";
        public static final String Title = "title";
        public static final String VehicleCount = "vehiclecount";
        public static final String WeaponCount = "weaponcount";

        public static String[] asArray() {
            ArrayList<String> array = new ArrayList<>();

            Collections.addAll(array, StarWarsModel.SortKeys.asArray());
            Collections.addAll(array,
                    CastMemberCount,
                    CharacterCount,
                    Director,
                    Duration,
                    EpisodeId,
                    FactionCount,
                    ManufacturerCount,
                    PlanetCount,
                    ProducersCount,
                    ReleaseDate,
                    SpecieCount,
                    StarshipCount,
                    Title,
                    VehicleCount,
                    WeaponCount
            );

            return array.toArray(new String[] { });
        }
        public static CharSequence[] asArrayTitles(Context context) {
            ArrayList<CharSequence> array = new ArrayList<>();

            Collections.addAll(array, StarWarsModel.SortKeys.asArrayTitles(context));
            Collections.addAll(array,
                    context.getResources().getString(R.string.models_film_sortkeys_titles_castmemberscount),
                    context.getResources().getString(R.string.models_film_sortkeys_titles_characterscount),
                    context.getResources().getString(R.string.models_film_sortkeys_titles_director),
                    context.getResources().getString(R.string.models_film_sortkeys_titles_duration),
                    context.getResources().getString(R.string.models_film_sortkeys_titles_episodeid),
                    context.getResources().getString(R.string.models_film_sortkeys_titles_factionscount),
                    context.getResources().getString(R.string.models_film_sortkeys_titles_manufacturerscount),
                    context.getResources().getString(R.string.models_film_sortkeys_titles_planetscount),
                    context.getResources().getString(R.string.models_film_sortkeys_titles_producerscount),
                    context.getResources().getString(R.string.models_film_sortkeys_titles_releasedate),
                    context.getResources().getString(R.string.models_film_sortkeys_titles_speciescount),
                    context.getResources().getString(R.string.models_film_sortkeys_titles_starshipscount),
                    context.getResources().getString(R.string.models_film_sortkeys_titles_title),
                    context.getResources().getString(R.string.models_film_sortkeys_titles_vehiclescount),
                    context.getResources().getString(R.string.models_film_sortkeys_titles_weaponscount)
            );

            return array.toArray(new CharSequence[] { });
        }
    }
}