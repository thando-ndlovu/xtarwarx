package com.xyclonedesigns.xtarwarx.repository.models;

import android.content.Context;

import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.utils.JsonUtils;

import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.Collections;

public class CharacterModel extends StarWarsModel {
    public CharacterModel(int id) {
        super(id);
    }
    public CharacterModel(JSONObject json) throws JSONException {
        super(json);

        if (!json.isNull(JsonKeys.BirthYear)) _BirthYear = json.getDouble(JsonKeys.BirthYear);
        if (!json.isNull(JsonKeys.Description)) _Description = json.getString(JsonKeys.Description);
        if (!json.isNull(JsonKeys.EyeColors)) _EyeColors = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.EyeColors), Object::toString);
        if (!json.isNull(JsonKeys.HairColors)) _HairColors = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.HairColors), Object::toString);
        if (!json.isNull(JsonKeys.Height)) _Height = json.getInt(JsonKeys.Height);
        if (!json.isNull(JsonKeys.HomeworldId)) _HomeworldId = json.getInt(JsonKeys.HomeworldId);
        if (!json.isNull(JsonKeys.Mass)) _Mass = json.getDouble(JsonKeys.Mass);
        if (!json.isNull(JsonKeys.Name)) _Name = json.getString(JsonKeys.Name);
        if (!json.isNull(JsonKeys.Sex)) _Sex = json.getString(JsonKeys.Sex);
        if (!json.isNull(JsonKeys.SkinColors)) _SkinColors = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.SkinColors), Object::toString);
    }

    public @Nullable Double _BirthYear;
    public @Nullable String _Description;
    public @Nullable Iterable<String> _EyeColors;
    public @Nullable Iterable<String> _HairColors;
    public @Nullable Integer _Height;
    public @Nullable Integer _HomeworldId;
    public @Nullable Double _Mass;
    public @Nullable String _Name;
    public @Nullable String _Sex;
    public @Nullable Iterable<String> _SkinColors;

    public static class JsonKeys extends StarWarsModel.JsonKeys {
        public static final String BirthYear = "birthYear";
        public static final String Description = "description";
        public static final String EyeColors = "eyeColors";
        public static final String HairColors = "hairColors";
        public static final String Height = "height";
        public static final String HomeworldId = "homeworldId";
        public static final String Mass = "mass";
        public static final String Name = "name";
        public static final String Sex = "sex";
        public static final String SkinColors = "skinColors";
    }
    public static class SortKeys extends StarWarsModel.SortKeys {
        public static final String BirthYear = "birthyear";
        public static final String EyeColorsCount = "eyecolorcount";
        public static final String HairColorsCount = "haircolorcount";
        public static final String Height = "height";
        public static final String Mass = "mass";
        public static final String Name = "name";
        public static final String Sex = "sex";
        public static final String SkinColorsCount = "skincolorcount";

        public static String[] asArray() {
            ArrayList<String> array = new ArrayList<>();

            Collections.addAll(array, StarWarsModel.SortKeys.asArray());
            Collections.addAll(array,
                    BirthYear,
                    EyeColorsCount,
                    HairColorsCount,
                    Height,
                    Mass,
                    Name,
                    Sex,
                    SkinColorsCount
            );

            return array.toArray(new String[] { });
        }
        public static CharSequence[] asArrayTitles(Context context) {
            ArrayList<CharSequence> array = new ArrayList<>();

            Collections.addAll(array, StarWarsModel.SortKeys.asArrayTitles(context));
            Collections.addAll(array,
                    context.getResources().getString(R.string.models_character_sortkeys_titles_birthyear),
                    context.getResources().getString(R.string.models_character_sortkeys_titles_eyecolorscount),
                    context.getResources().getString(R.string.models_character_sortkeys_titles_haircolorscount),
                    context.getResources().getString(R.string.models_character_sortkeys_titles_height),
                    context.getResources().getString(R.string.models_character_sortkeys_titles_mass),
                    context.getResources().getString(R.string.models_character_sortkeys_titles_name),
                    context.getResources().getString(R.string.models_character_sortkeys_titles_sex),
                    context.getResources().getString(R.string.models_character_sortkeys_titles_skincolorscount)
            );

            return array.toArray(new CharSequence[] { });
        }
    }
    public static class Sexes {
        public static final String Asexual = "Asexual";
        public static final String Female = "Female";
        public static final String Hermaphrodite = "Hermaphrodite";
        public static final String Male = "Male";
    }
}