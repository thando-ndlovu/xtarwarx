package com.xyclonedesigns.xtarwarx.repository.models;

import android.content.Context;

import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.R;

import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.Collections;

public class StarshipModel extends TransporterModel  {
    public StarshipModel(int id) {
        super(id);
    }
    public StarshipModel(JSONObject json) throws JSONException {
        super(json);

        if (!json.isNull(JsonKeys.HyperdriveRating)) _HyperdriveRating = json.getDouble(JsonKeys.HyperdriveRating);
        if (!json.isNull(JsonKeys.MGLT)) _MGLT = json.getInt(JsonKeys.MGLT);
        if (!json.isNull(JsonKeys.StarshipClass)) _StarshipClass = new StarshipModelClass(json.getJSONObject(JsonKeys.StarshipClass));
    }

    public @Nullable Double _HyperdriveRating;
    public @Nullable Integer _MGLT;
    public @Nullable StarshipModelClass _StarshipClass;

    public static class JsonKeys extends TransporterModel.JsonKeys {
        public static final String HyperdriveRating = "hyperdriveRating";
        public static final String MGLT = "mglt";
        public static final String StarshipClass = "starshipClass";
    }
    public static class SortKeys extends TransporterModel.SortKeys {
        public static final String HyperdriveRating = "hyperdriverating";
        public static final String MGLT = "mglt";
        public static final String StarshipClass = "starshipclass";
        public static final String StarshipClassFlagsCount = "starshipclassflagscount";

        public static String[] asArray() {
            ArrayList<String> array = new ArrayList<>();

            Collections.addAll(array, StarWarsModel.SortKeys.asArray());
            Collections.addAll(array,
                    HyperdriveRating,
                    MGLT,
                    StarshipClass,
                    StarshipClassFlagsCount
            );

            return array.toArray(new String[] { });
        }
        public static CharSequence[] asArrayTitles(Context context) {
            ArrayList<CharSequence> array = new ArrayList<>();

            Collections.addAll(array, StarWarsModel.SortKeys.asArrayTitles(context));
            Collections.addAll(array,
                    context.getResources().getString(R.string.models_starship_sortkeys_titles_hyperdriverating),
                    context.getResources().getString(R.string.models_starship_sortkeys_titles_mglt),
                    context.getResources().getString(R.string.models_starship_sortkeys_titles_starshipclass),
                    context.getResources().getString(R.string.models_starship_sortkeys_titles_starshipclassflagscount)
            );

            return array.toArray(new CharSequence[] { });
        }
    }
}