package com.xyclonedesigns.xtarwarx.repository.models;

import android.content.Context;

import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.utils.JsonUtils;

import org.json.JSONException;
import org.json.JSONObject;

import java.net.IDN;
import java.util.ArrayList;
import java.util.Date;

public class StarWarsModel {
    public StarWarsModel(int id) {
        _Id = id;
    }
    public StarWarsModel(JSONObject json) throws JSONException {
        this(json.getInt(JsonKeys.Id));

        if (!json.isNull(JsonKeys.Created)) _Created = JsonUtils.fromStringDate(json.getString(JsonKeys.Created));
        if (!json.isNull(JsonKeys.Edited)) _Edited = JsonUtils.fromStringDate(json.getString(JsonKeys.Edited));
        if (!json.isNull(JsonKeys.Uris)) _Uris = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.Uris), obj -> new StarWarsModelURI((JSONObject) obj));
    }

    public final int _Id;
    public @Nullable ArrayList<StarWarsModelURI> _Uris;
    public @Nullable Date _Created;
    public @Nullable Date _Edited;

    public static class JsonKeys {
        public static final String Id = "id";
        public static final String Uris = "uris";
        public static final String Created = "created";
        public static final String Edited = "edited";
    }
    public static class SortKeys {
        public static final String Id = "id";
        public static final String Created = "created";
        public static final String LastEdited = "lastedited";

        public static String[] asArray() {
            return new String[] {
                    Id,
                    Created,
                    LastEdited
            };
        }
        public static CharSequence[] asArrayTitles(Context context) {
            return new CharSequence[] {
                    context.getResources().getString(R.string.models_starwarsmodel_sortkeys_titles_id),
                    context.getResources().getString(R.string.models_starwarsmodel_sortkeys_titles_created),
                    context.getResources().getString(R.string.models_starwarsmodel_sortkeys_titles_lastedited)
            };
        }
    }
}