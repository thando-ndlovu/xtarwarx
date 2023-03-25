package com.xyclonedesigns.xtarwarx.repository.models;

import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.utils.JsonUtils;

import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;

public class VehicleModelClass {
    public static class JsonKeys {
        public static final String Class = "class";
        public static final String Flags = "flags";
    }
    public static class Classes {
        public final String Barge = "Barge";
        public final String Bomber = "Bomber";
        public final String Craft = "Craft";
        public final String Fighter = "Fighter";
        public final String Gunship = "Gunship";
        public final String Ship = "Ship";
        public final String Speeder = "Speeder";
        public final String Submarine = "Submarine";
        public final String Tank = "Tank";
        public final String Transporter = "Transporter";
        public final String Walker = "Walker";
    }
    public static class ClassFlags {
        public final String Air = "Air";
        public final String Assault = "Assault";
        public final String CargoSkiff = "CargoSkiff";
        public final String Droid = "Droid";
        public final String FireSuppression = "FireSuppression";
        public final String Landing = "Landing";
        public final String Planetary = "Planetary";
        public final String Repulsor = "Repulsor";
        public final String Sail = "Sail";
        public final String Star = "Star";
        public final String Wheeled = "Wheeled";
    }

    public VehicleModelClass() { }
    public VehicleModelClass(JSONObject json) throws JSONException {
        if (!json.isNull(JsonKeys.Class)) _Class = json.getString(JsonKeys.Class);
        if (!json.isNull(JsonKeys.Flags)) _Flags = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.Flags), Object::toString);
    }

    public @Nullable String _Class;
    public @Nullable ArrayList<String> _Flags;
}