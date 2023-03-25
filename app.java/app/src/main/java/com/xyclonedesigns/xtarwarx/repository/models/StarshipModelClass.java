package com.xyclonedesigns.xtarwarx.repository.models;

import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.utils.JsonUtils;

import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;

public class StarshipModelClass {
    public static class JsonKeys {
        public static final String Class = "class";
        public static final String Flags = "flags";
    }
    public static class Classes {
        public final String Barge = "Barge";
        public final String Battlestation = "Battlestation";
        public final String Corvette = "Corvette";
        public final String Craft = "Craft";
        public final String Cruiser = "Cruiser";
        public final String Destroyer = "Destroyer";
        public final String Dreadnought = "Dreadnought";
        public final String Fighter = "Fighter";
        public final String Freighter = "Freighter";
        public final String Ship = "Ship";
        public final String Transporter = "Transporter";
        public final String Yacht = "Yacht";
    }
    public static class ClassFlags {
        public final String Armed = "Armed";
        public final String Assault = "Assault";
        public final String Capital = "Capital";
        public final String DeepSpace = "DeepSpace";
        public final String Diplomatic = "Diplomatic";
        public final String DroidControl = "DroidControl";
        public final String Escort = "Escort";
        public final String Landing = "Landing";
        public final String Light = "Light";
        public final String Mobile = "Mobile";
        public final String Patrol = "Patrol";
        public final String Planetary = "Planetary";
        public final String Star = "Star";
        public final String Space = "Space";
    }

    public StarshipModelClass() { }
    public StarshipModelClass(JSONObject json) throws JSONException {
        if (!json.isNull(JsonKeys.Class)) _Class = json.getString(JsonKeys.Class);
        if (!json.isNull(JsonKeys.Flags)) _Flags = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.Flags), Object::toString);
    }

    public @Nullable String _Class;
    public @Nullable ArrayList<String> _Flags;
}