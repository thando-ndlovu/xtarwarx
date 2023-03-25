package com.xyclonedesigns.xtarwarx.repository.models;

import android.content.Context;

import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.utils.JsonUtils;

import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.Collections;

public class PlanetModel extends StarWarsModel {
    public PlanetModel(int id) {
        super(id);
    }
    public PlanetModel(JSONObject json) throws JSONException {
        super(json);

        if (!json.isNull(JsonKeys.Climates)) _Climates = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.Climates), obj -> new PlanetModelClimate((JSONObject)obj));
        if (!json.isNull(JsonKeys.Description)) _Description = json.getString(JsonKeys.Description);
        if (!json.isNull(JsonKeys.Diameter)) _Diameter = json.getInt(JsonKeys.Diameter);
        if (!json.isNull(JsonKeys.Gravity)) _Gravity = json.getDouble(JsonKeys.Gravity);
        if (!json.isNull(JsonKeys.Name)) _Name = json.getString(JsonKeys.Name);
        if (!json.isNull(JsonKeys.OrbitalPeriod)) _OrbitalPeriod = json.getInt(JsonKeys.OrbitalPeriod);
        if (!json.isNull(JsonKeys.Population)) _Population = json.getLong(JsonKeys.Population);
        if (!json.isNull(JsonKeys.ResidentIds)) _ResidentIds = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.ResidentIds), obj -> Integer.parseInt(obj.toString()));
        if (!json.isNull(JsonKeys.RotationalPeriod)) _RotationalPeriod = json.getInt(JsonKeys.RotationalPeriod);
        if (!json.isNull(JsonKeys.SurfaceWater)) _SurfaceWater = json.getDouble(JsonKeys.SurfaceWater);
        if (!json.isNull(JsonKeys.Terrains)) _Terrains = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.Terrains), obj -> new PlanetModelTerrain((JSONObject)obj));
    }

    public @Nullable ArrayList<PlanetModelClimate> _Climates;
    public @Nullable String _Description;
    public @Nullable Integer _Diameter;
    public @Nullable Double _Gravity;
    public @Nullable String _Name;
    public @Nullable Integer _OrbitalPeriod;
    public @Nullable Long _Population;
    public @Nullable ArrayList<Integer> _ResidentIds;
    public @Nullable Integer _RotationalPeriod;
    public @Nullable Double _SurfaceWater;
    public @Nullable ArrayList<PlanetModelTerrain> _Terrains;

    public static class JsonKeys extends StarWarsModel.JsonKeys {
        public static final String Climates = "climates";
        public static final String Description = "description";
        public static final String Diameter = "diameter";
        public static final String Gravity = "gravity";
        public static final String Name = "name";
        public static final String OrbitalPeriod = "orbitalPeriod";
        public static final String Population = "population";
        public static final String ResidentIds = "residentIds";
        public static final String RotationalPeriod = "rotationalPeriod";
        public static final String SurfaceWater = "surfaceWater";
        public static final String Terrains = "terrains";
    }
    public static class SortKeys extends StarWarsModel.SortKeys {
        public static final String ClimateCount = "climatecount";
        public static final String Diameter = "diameter";
        public static final String Gravity = "gravity";
        public static final String Name = "name";
        public static final String OrbitalPeriod = "orbitalperiod";
        public static final String Population = "population";
        public static final String ResidentCount = "residentcount";
        public static final String RotationalPeriod = "rotationalperiod";
        public static final String SurfaceWater = "surfacewater";
        public static final String TerrainCount = "terraincount";

        public static String[] asArray() {
            ArrayList<String> array = new ArrayList<>();

            Collections.addAll(array, StarWarsModel.SortKeys.asArray());
            Collections.addAll(array,
                    ClimateCount,
                    Diameter,
                    Gravity,
                    Name,
                    OrbitalPeriod,
                    Population,
                    ResidentCount,
                    RotationalPeriod,
                    SurfaceWater,
                    TerrainCount
            );

            return array.toArray(new String[] { });
        }
        public static CharSequence[] asArrayTitles(Context context) {
            ArrayList<CharSequence> array = new ArrayList<>();

            Collections.addAll(array, StarWarsModel.SortKeys.asArrayTitles(context));
            Collections.addAll(array,
                    context.getResources().getString(R.string.models_planet_sortkeys_titles_climatescount),
                    context.getResources().getString(R.string.models_planet_sortkeys_titles_diameter),
                    context.getResources().getString(R.string.models_planet_sortkeys_titles_gravity),
                    context.getResources().getString(R.string.models_planet_sortkeys_titles_name),
                    context.getResources().getString(R.string.models_planet_sortkeys_titles_orbitalperiod),
                    context.getResources().getString(R.string.models_planet_sortkeys_titles_population),
                    context.getResources().getString(R.string.models_planet_sortkeys_titles_residentscount),
                    context.getResources().getString(R.string.models_planet_sortkeys_titles_rotationalperiod),
                    context.getResources().getString(R.string.models_planet_sortkeys_titles_surfacewater),
                    context.getResources().getString(R.string.models_planet_sortkeys_titles_terrainscount)
            );

            return array.toArray(new CharSequence[] { });
        }
    }
}