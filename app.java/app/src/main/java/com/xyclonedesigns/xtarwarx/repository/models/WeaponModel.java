package com.xyclonedesigns.xtarwarx.repository.models;

import android.content.Context;

import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.utils.JsonUtils;

import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.Collections;

public class WeaponModel extends StarWarsModel {
    public WeaponModel(int id) {
        super(id);
    }
    public WeaponModel(JSONObject json) throws JSONException {
        super(json);

        if (!json.isNull(JsonKeys.Description)) _Description = json.getString(JsonKeys.Description);
        if (!json.isNull(JsonKeys.ManufacturerIds)) _ManufacturerIds = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.ManufacturerIds), obj -> Integer.parseInt(obj.toString()));
        if (!json.isNull(JsonKeys.Model)) _Model = json.getString(JsonKeys.Model);
        if (!json.isNull(JsonKeys.Name)) _Name = json.getString(JsonKeys.Name);
        if (!json.isNull(JsonKeys.WeaponClass)) _WeaponClass = new WeaponModelClass(json.getJSONObject(JsonKeys.WeaponClass));
    }

    public @Nullable String _Description;
    public @Nullable ArrayList<Integer> _ManufacturerIds;
    public @Nullable String _Model;
    public @Nullable String _Name;
    public @Nullable WeaponModelClass _WeaponClass;

    public static class JsonKeys extends StarWarsModel.JsonKeys {
        public static final String Description = "description";
        public static final String ManufacturerIds = "manufacturerIds";
        public static final String Model = "model";
        public static final String Name = "name";
        public static final String WeaponClass = "weaponClass";
    }
    public static class SortKeys extends StarWarsModel.SortKeys {
        public static final String ManufacturerCount = "manufacturercount";
        public static final String Model = "model";
        public static final String Name = "name";
        public static final String WeaponClass = "weaponclass";
        public static final String WeaponClassFlagsCount = "weaponclassflagscount";

        public static String[] asArray() {
            ArrayList<String> array = new ArrayList<>();

            Collections.addAll(array, StarWarsModel.SortKeys.asArray());
            Collections.addAll(array,
                    ManufacturerCount,
                    Model,
                    Name,
                    WeaponClass,
                    WeaponClassFlagsCount
            );

            return array.toArray(new String[] { });
        }
        public static CharSequence[] asArrayTitles(Context context) {
            ArrayList<CharSequence> array = new ArrayList<>();

            Collections.addAll(array, StarWarsModel.SortKeys.asArrayTitles(context));
            Collections.addAll(array,
                    context.getResources().getString(R.string.models_weapon_sortkeys_titles_manufacturercount),
                    context.getResources().getString(R.string.models_weapon_sortkeys_titles_model),
                    context.getResources().getString(R.string.models_weapon_sortkeys_titles_name),
                    context.getResources().getString(R.string.models_weapon_sortkeys_titles_weaponclass),
                    context.getResources().getString(R.string.models_weapon_sortkeys_titles_weaponclassflagscount)
            );

            return array.toArray(new CharSequence[] { });
        }
    }
}