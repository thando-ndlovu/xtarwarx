package com.xyclonedesigns.xtarwarx.repository.models;

import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.utils.JsonUtils;

import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;

public class PlanetModelClimate {
    public static class JsonKeys {
        public static final String Type = "type";
        public static final String Flags = "flags";
    }
    public static class Types {
        public static final String Arid = "Arid";
        public static final String Artic = "Artic";
        public static final String Frigid = "Frigid";
        public static final String Frozen = "Frozen";
        public static final String Hot = "Hot";
        public static final String Humid = "Humid";
        public static final String Moist = "Moist";
        public static final String Murky = "Murky";
        public static final String Polluted = "Polluted";
        public static final String Rocky = "Rocky";
        public static final String Temperate = "Temperate";
        public static final String Tropical = "Tropical";
        public static final String Windy = "Windy";
    }
    public static class TypeFlags {
        public static final String Artificial = "Artificial";
        public static final String Sub = "Sub";
        public static final String Super = "Super";
    }

    public PlanetModelClimate() { }
    public PlanetModelClimate(JSONObject json) throws JSONException {
        if (!json.isNull(JsonKeys.Type)) _Type = json.getString(JsonKeys.Type);
        if (!json.isNull(JsonKeys.Flags)) _Flags = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.Flags), Object::toString);
    }

    public @Nullable String _Type;
    public @Nullable ArrayList<String> _Flags;
}