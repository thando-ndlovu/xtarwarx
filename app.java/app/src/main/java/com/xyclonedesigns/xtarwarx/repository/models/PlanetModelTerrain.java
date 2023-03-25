package com.xyclonedesigns.xtarwarx.repository.models;

import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.utils.JsonUtils;

import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;

public class PlanetModelTerrain {
    public static class JsonKeys {
        public static final String Type = "type";
        public static final String Flags = "flags";
    }
    public static class Types {
        public static final String Arches = "Arches";
        public static final String Ash = "Ash";
        public static final String Asteroid = "Asteroid";
        public static final String Barren = "Barren";
        public static final String Bogs = "Bogs";
        public static final String Canyons = "Canyons";
        public static final String Caves = "Caves";
        public static final String Cityscapes = "Cityscapes";
        public static final String Cliffs = "Cliffs";
        public static final String Clouds = "Clouds";
        public static final String Cloudsea = "Cloudsea";
        public static final String Deserts = "Deserts";
        public static final String Fields = "Fields";
        public static final String Forests = "Forests";
        public static final String Frozen = "Frozen";
        public static final String Fungus = "Fungus";
        public static final String Glaciers = "Glaciers";
        public static final String Grasslands = "Grasslands";
        public static final String Hills = "Hills";
        public static final String Ice = "Ice";
        public static final String Islands = "Islands";
        public static final String Jungles = "Jungles";
        public static final String Lakes = "Lakes";
        public static final String Mesas = "Mesas";
        public static final String Mountains = "Mountains";
        public static final String Oceans = "Oceans";
        public static final String Plains = "Plains";
        public static final String Plateaus = "Plateaus";
        public static final String Pools = "Pools";
        public static final String Rainforests = "Rainforests";
        public static final String Reefs = "Reefs";
        public static final String Rivers = "Rivers";
        public static final String Rocky = "Rocky";
        public static final String Savannas = "Savannas";
        public static final String SaltPans = "SaltPans";
        public static final String Scrublands = "Scrublands";
        public static final String Seas = "Seas";
        public static final String Sinkholes = "Sinkholes";
        public static final String Swamps = "Swamps";
        public static final String Tundra = "Tundra";
        public static final String Urban = "Urban";
        public static final String Valleys = "Valleys";
        public static final String Verdant = "Verdant";
        public static final String Vines = "Vines";
        public static final String Volcanoes = "Volcanoes";
    }
    public static class TypeFlags {
        public static final String Acidic = "Acidic";
        public static final String Airless = "Airless";
        public static final String Barren = "Barren";
        public static final String Boggy = "Boggy";
        public static final String Gaseous = "Gaseous";
        public static final String Grassy = "Grassy";
        public static final String Icy = "Icy";
        public static final String Molten = "Molten";
        public static final String Rocky = "Rocky";
        public static final String Toxic = "Toxic";
        public static final String Tropical = "Tropical";
    }

    public PlanetModelTerrain() { }
    public PlanetModelTerrain(JSONObject json) throws JSONException {
        if (!json.isNull(JsonKeys.Type)) _Type = json.getString(JsonKeys.Type);
        if (!json.isNull(JsonKeys.Flags)) _Flags = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.Flags), Object::toString);
    }

    public @Nullable String _Type;
    public @Nullable ArrayList<String> _Flags;
}