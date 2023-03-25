package com.xyclonedesigns.xtarwarx.repository.models;

import android.content.Context;

import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.R;

import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.Collections;

public class VehicleModel extends TransporterModel  {
    public VehicleModel(int id) {
        super(id);
    }
    public VehicleModel(JSONObject json) throws JSONException {
        super(json);
        if (!json.isNull(JsonKeys.VehicleClass)) _VehicleClass = new VehicleModelClass(json.getJSONObject(JsonKeys.VehicleClass));
    }

    public @Nullable VehicleModelClass _VehicleClass;

    public static class JsonKeys extends TransporterModel.JsonKeys {
        public static final String VehicleClass = "vehicleClass";
    }
    public static class SortKeys extends TransporterModel.SortKeys {
        public static final String VehicleClass = "vehicleclass";
        public static final String VehicleClassFlagsCount = "vehicleclassflagscount";

        public static String[] asArray() {
            ArrayList<String> array = new ArrayList<>();

            Collections.addAll(array, TransporterModel.SortKeys.asArray());
            Collections.addAll(array,
                    VehicleClass,
                    VehicleClassFlagsCount
            );

            return array.toArray(new String[] { });
        }
        public static CharSequence[] asArrayTitles(Context context) {
            ArrayList<CharSequence> array = new ArrayList<>();

            Collections.addAll(array, StarWarsModel.SortKeys.asArrayTitles(context));
            Collections.addAll(array,
                    context.getResources().getString(R.string.models_vehicle_sortkeys_titles_vehicleclass),
                    context.getResources().getString(R.string.models_vehicle_sortkeys_titles_vehicleclassflagscount)
            );

            return array.toArray(new CharSequence[] { });
        }
    }
}