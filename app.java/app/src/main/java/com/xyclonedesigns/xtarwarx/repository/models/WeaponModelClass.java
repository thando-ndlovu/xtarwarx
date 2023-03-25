package com.xyclonedesigns.xtarwarx.repository.models;

import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.utils.JsonUtils;

import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;

public class WeaponModelClass {
    public static class JsonKeys {
        public static final String Class = "class";
        public static final String Flags = "flags";
    }
    public static class Classes {
    }
    public static class ClassFlags {
    }

    public WeaponModelClass() { }
    public WeaponModelClass(JSONObject json) throws JSONException {
        if (!json.isNull(JsonKeys.Class)) _Class = json.getString(JsonKeys.Class);
        if (!json.isNull(JsonKeys.Flags)) _Flags = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.Flags), Object::toString);
    }

    public @Nullable String _Class;
    public @Nullable ArrayList<String> _Flags;
}