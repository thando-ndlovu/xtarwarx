package com.xyclonedesigns.xtarwarx.repository.models;

import androidx.annotation.Nullable;

import org.json.JSONException;
import org.json.JSONObject;

public class TransporterModelConsumable {
    public static class JsonKeys {
        public static final String TimeUnit = "timeUnit";
        public static final String Value = "value";
    }
    public static class TimeUnits {
        public final String Hour = "Hour";
        public final String Day = "Day";
        public final String Week = "Week";
        public final String Month = "Month";
        public final String Year = "Year";
    }

    public TransporterModelConsumable(JSONObject json) throws JSONException {
        if (!json.isNull(JsonKeys.TimeUnit)) _TimeUnit = json.getString(JsonKeys.TimeUnit);
        if (!json.isNull(JsonKeys.Value)) _Value = json.getInt(JsonKeys.Value);
    }

    public @Nullable String _TimeUnit;
    public @Nullable Integer _Value;
}