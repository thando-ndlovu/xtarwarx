package com.xyclonedesigns.xtarwarx.repository.models;

import android.content.Context;

import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.utils.JsonUtils;

import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.Collections;

public class SpecieModel extends StarWarsModel {
    public SpecieModel(int id) {
        super(id);
    }
    public SpecieModel(JSONObject json) throws JSONException {
        super(json);

        if (!json.isNull(JsonKeys.AverageHeight)) _AverageHeight = json.getInt(JsonKeys.AverageHeight);
        if (!json.isNull(JsonKeys.AverageLifespan)) _AverageLifespan = json.getInt(JsonKeys.AverageLifespan);
        if (!json.isNull(JsonKeys.CharacterIds)) _CharacterIds = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.CharacterIds), obj -> Integer.parseInt(obj.toString()));
        if (!json.isNull(JsonKeys.Classification)) _Classification = json.getString(JsonKeys.Classification);
        if (!json.isNull(JsonKeys.Description)) _Description = json.getString(JsonKeys.Description);
        if (!json.isNull(JsonKeys.Designation)) _Designation = json.getString(JsonKeys.Designation);
        if (!json.isNull(JsonKeys.EyeColors)) _EyeColors = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.EyeColors), Object::toString);
        if (!json.isNull(JsonKeys.HairColors)) _HairColors = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.HairColors), Object::toString);
        if (!json.isNull(JsonKeys.HomeworldId)) _HomeworldId = json.getInt(JsonKeys.HomeworldId);
        if (!json.isNull(JsonKeys.Language)) _Language = json.getString(JsonKeys.Language);
        if (!json.isNull(JsonKeys.Name)) _Name = json.getString(JsonKeys.Name);
        if (!json.isNull(JsonKeys.SkinColors)) _SkinColors = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.SkinColors), Object::toString);
    }

    public @Nullable Integer _AverageHeight;
    public @Nullable Integer _AverageLifespan;
    public @Nullable ArrayList<Integer> _CharacterIds;
    public @Nullable String _Classification;
    public @Nullable String _Description;
    public @Nullable String _Designation;
    public @Nullable ArrayList<String> _EyeColors;
    public @Nullable ArrayList<String> _HairColors;
    public @Nullable Integer _HomeworldId;
    public @Nullable String _Language;
    public @Nullable String _Name;
    public @Nullable ArrayList<String> _SkinColors;

    public static class JsonKeys extends StarWarsModel.JsonKeys {
        public static final String AverageHeight = "averageHeight";
        public static final String AverageLifespan = "averageLifespan";
        public static final String CharacterIds = "characterIds";
        public static final String Classification = "classification";
        public static final String Description = "description";
        public static final String Designation = "designation";
        public static final String EyeColors = "eyeColors";
        public static final String HairColors = "hairColors";
        public static final String HomeworldId = "homeworldId";
        public static final String Language = "language";
        public static final String Name = "name";
        public static final String SkinColors = "skinColors";
    }
    public static class SortKeys extends StarWarsModel.SortKeys {
        public static final String AverageHeight = "averageheight";
        public static final String AverageLifespan = "averagelifespan";
        public static final String CharacterCount = "charactercount";
        public static final String Classification = "classification";
        public static final String Description = "description";
        public static final String Designation = "designation";
        public static final String EyeColors = "eyecolors";
        public static final String HairColors = "haircolors";
        public static final String Language = "language";
        public static final String Name = "name";
        public static final String SkinColors = "skincolors";

        public static String[] asArray() {
            ArrayList<String> array = new ArrayList<>();

            Collections.addAll(array, StarWarsModel.SortKeys.asArray());
            Collections.addAll(array,
                    AverageHeight,
                    AverageLifespan,
                    CharacterCount,
                    Classification,
                    Designation,
                    EyeColors,
                    HairColors,
                    Language,
                    Name,
                    SkinColors
            );

            return array.toArray(new String[] { });
        }
        public static CharSequence[] asArrayTitles(Context context) {
            ArrayList<CharSequence> array = new ArrayList<>();

            Collections.addAll(array, StarWarsModel.SortKeys.asArrayTitles(context));
            Collections.addAll(array,
                    context.getResources().getString(R.string.models_specie_sortkeys_titles_averageheight),
                    context.getResources().getString(R.string.models_specie_sortkeys_titles_averagelifespan),
                    context.getResources().getString(R.string.models_specie_sortkeys_titles_charactercount),
                    context.getResources().getString(R.string.models_specie_sortkeys_titles_classification),
                    context.getResources().getString(R.string.models_specie_sortkeys_titles_designation),
                    context.getResources().getString(R.string.models_specie_sortkeys_titles_eyecolorscount),
                    context.getResources().getString(R.string.models_specie_sortkeys_titles_haircolorscount),
                    context.getResources().getString(R.string.models_specie_sortkeys_titles_language),
                    context.getResources().getString(R.string.models_specie_sortkeys_titles_name),
                    context.getResources().getString(R.string.models_specie_sortkeys_titles_skincolorscount)
            );

            return array.toArray(new CharSequence[] { });
        }
    }
    public static class Classifications {
        public final String Amphibian = "Amphibian";
        public final String Artificial = "Artificial";
        public final String Insectoid = "Insectoid";
        public final String Gastropod = "Gastropod";
        public final String Mammal = "Mammal";
        public final String Reptile = "Reptile";
    }
    public static class Designations {
        public final String Sentient = "Sentient";
    }
    public static class Languages {
        public final String Aleena = "Aleena";
        public final String Besalisk = "Besalisk";
        public final String Clawdite = "Clawdite";
        public final String Chagria = "Chagria";
        public final String Cerean = "Cerean";
        public final String Dosh = "Dosh";
        public final String Dugese = "Dugese";
        public final String Ewokese = "Ewokese";
        public final String GalacticBasic = "GalacticBasic";
        public final String Geonosian = "Geonosian";
        public final String GunganBasic = "GunganBasic";
        public final String Huttese = "Huttese";
        public final String Iktotchese = "Iktotchese";
        public final String Kaleesh = "Kaleesh";
        public final String Kaminoan = "Kaminoan";
        public final String KelDor = "KelDor";
        public final String Mirialan = "Mirialan";
        public final String MonCalamarian = "MonCalamarian";
        public final String Muun = "Muun";
        public final String Nautila = "Nautila";
        public final String Neimodia = "Neimodia";
        public final String Quermian = "Quermian";
        public final String Shyriiwook = "Shyriiwook";
        public final String Skakoan = "Skakoan";
        public final String Sullutese = "Sullutese";
        public final String Togruti = "Togruti";
        public final String Toydarian = "Toydarian";
        public final String Tundan = "Tundan";
        public final String Twileki = "Twi'leki";
        public final String Utapese = "Utapese";
        public final String Vulpterish = "Vulpterish";
        public final String Xextese = "Xextese";
        public final String Zabraki = "Zabraki";
    }
}