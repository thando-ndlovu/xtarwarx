package com.xyclonedesigns.xtarwarx.repository.models;

import android.content.Context;

import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.utils.JsonUtils;

import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.Collections;

public class ManufacturerModel extends StarWarsModel {
    public ManufacturerModel(int id) {
        super(id);
    }
    public ManufacturerModel(JSONObject json) throws JSONException {
        super(json);

        if (!json.isNull(JsonKeys.Description)) _Description = json.getString(JsonKeys.Description);
        if (!json.isNull(JsonKeys.HeadquartersPlanetId)) _HeadquartersPlanetId = json.getInt(JsonKeys.HeadquartersPlanetId);
        if (!json.isNull(JsonKeys.Name)) _Name = json.getString(JsonKeys.Name);
        if (!json.isNull(JsonKeys.StarshipIds)) _StarshipIds = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.StarshipIds), obj -> Integer.parseInt(obj.toString()));
        if (!json.isNull(JsonKeys.VehicleIds)) _VehicleIds = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.VehicleIds), obj -> Integer.parseInt(obj.toString()));
        if (!json.isNull(JsonKeys.WeaponIds)) _WeaponIds = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.WeaponIds), obj -> Integer.parseInt(obj.toString()));
    }

    public @Nullable String _Description;
    public @Nullable Integer _HeadquartersPlanetId;
    public @Nullable String _Name;
    public @Nullable ArrayList<Integer> _StarshipIds;
    public @Nullable ArrayList<Integer> _VehicleIds;
    public @Nullable ArrayList<Integer> _WeaponIds;

    public static class JsonKeys extends StarWarsModel.JsonKeys {
        public static final String Description = "description";
        public static final String HeadquartersPlanetId = "headquartersPlanetId";
        public static final String Name = "name";
        public static final String StarshipIds = "starshipIds";
        public static final String VehicleIds = "vehicleIds";
        public static final String WeaponIds = "weaponIds";
    }
    public static class SortKeys extends StarWarsModel.SortKeys {
        public static final String Name = "name";
        public static final String StarshipCount = "starshipcount";
        public static final String VehicleCount = "vehiclecount";
        public static final String WeaponCount = "weaponcount";

        public static String[] asArray() {
            ArrayList<String> array = new ArrayList<>();

            Collections.addAll(array, StarWarsModel.SortKeys.asArray());
            Collections.addAll(array,
                    Name,
                    StarshipCount,
                    VehicleCount,
                    WeaponCount
            );

            return array.toArray(new String[] { });
        }
        public static CharSequence[] asArrayTitles(Context context) {
            ArrayList<CharSequence> array = new ArrayList<>();

            Collections.addAll(array, StarWarsModel.SortKeys.asArrayTitles(context));
            Collections.addAll(array,
                    context.getResources().getString(R.string.models_manufacturer_sortkeys_titles_name),
                    context.getResources().getString(R.string.models_manufacturer_sortkeys_titles_starshipscount),
                    context.getResources().getString(R.string.models_manufacturer_sortkeys_titles_vehiclescount),
                    context.getResources().getString(R.string.models_manufacturer_sortkeys_titles_weaponscount)
            );

            return array.toArray(new CharSequence[] { });
        }
    }
}