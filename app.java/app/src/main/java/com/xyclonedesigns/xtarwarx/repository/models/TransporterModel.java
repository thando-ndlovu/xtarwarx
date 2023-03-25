package com.xyclonedesigns.xtarwarx.repository.models;

import android.content.Context;

import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.utils.JsonUtils;

import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.Collections;

public class TransporterModel extends StarWarsModel {
    public TransporterModel(int id) {
        super(id);
    }
    public TransporterModel(JSONObject json) throws JSONException {
        super(json);

        if (!json.isNull(JsonKeys.CargoCapacity)) _CargoCapacity = json.getLong(JsonKeys.CargoCapacity);
        if (!json.isNull(JsonKeys.Consumables)) _Consumables = new TransporterModelConsumable(json.getJSONObject(JsonKeys.Consumables));
        if (!json.isNull(JsonKeys.CostInCredits)) _CostInCredits = json.getLong(JsonKeys.CostInCredits);
        if (!json.isNull(JsonKeys.Description)) _Description = json.getString(JsonKeys.Description);
        if (!json.isNull(JsonKeys.Length)) _Length = json.getDouble(JsonKeys.Length);
        if (!json.isNull(JsonKeys.ManufacturerIds)) _ManufacturerIds = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.ManufacturerIds), obj -> Integer.parseInt(obj.toString()));
        if (!json.isNull(JsonKeys.MaxAtmospheringSpeed)) _MaxAtmospheringSpeed = json.getInt(JsonKeys.MaxAtmospheringSpeed);
        if (!json.isNull(JsonKeys.MaxCrew)) _MaxCrew = json.getInt(JsonKeys.MaxCrew);
        if (!json.isNull(JsonKeys.MinCrew)) _MinCrew = json.getInt(JsonKeys.MinCrew);
        if (!json.isNull(JsonKeys.Model)) _Model = json.getString(JsonKeys.Model);
        if (!json.isNull(JsonKeys.Name)) _Name = json.getString(JsonKeys.Name);
        if (!json.isNull(JsonKeys.Passengers)) _Passengers = json.getInt(JsonKeys.Passengers);
        if (!json.isNull(JsonKeys.PilotIds)) _PilotIds = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.PilotIds), obj -> Integer.parseInt(obj.toString()));
    }

    public @Nullable Long _CargoCapacity;
    public @Nullable TransporterModelConsumable _Consumables;
    public @Nullable Long _CostInCredits;
    public @Nullable String _Description;
    public @Nullable Double _Length;
    public @Nullable ArrayList<Integer> _ManufacturerIds;
    public @Nullable Integer _MaxAtmospheringSpeed;
    public @Nullable Integer _MaxCrew;
    public @Nullable Integer _MinCrew;
    public @Nullable String _Model;
    public @Nullable String _Name;
    public @Nullable Integer _Passengers;
    public @Nullable ArrayList<Integer> _PilotIds;

    public static class JsonKeys extends StarWarsModel.JsonKeys {
        public static final String CargoCapacity = "cargoCapacity";
        public static final String Consumables = "consumables";
        public static final String CostInCredits = "costInCredits";
        public static final String Description = "description";
        public static final String Length = "length";
        public static final String ManufacturerIds = "manufacturerIds";
        public static final String MaxAtmospheringSpeed = "maxAtmospheringSpeed";
        public static final String MaxCrew = "maxCrew";
        public static final String MinCrew = "minCrew";
        public static final String Model = "model";
        public static final String Name = "name";
        public static final String Passengers = "passengers";
        public static final String PilotIds = "pilotIds";
    }
    public static class SortKeys extends StarWarsModel.SortKeys {
        public static final String CargoCapacity = "cargocapacity";
        public static final String Consumables = "consumables";
        public static final String CostInCredits = "costincredits";
        public static final String Length = "length";
        public static final String ManufacturerCount = "manufacturercount";
        public static final String MaxAtmospheringSpeed = "maxatmospheringspeed";
        public static final String MaxCrew = "maxcrew";
        public static final String MinCrew = "mincrew";
        public static final String Model = "model";
        public static final String Name = "name";
        public static final String Passengers = "passengers";
        public static final String PilotCount = "pilotcount";

        public static String[] asArray() {
            ArrayList<String> array = new ArrayList<>();

            Collections.addAll(array, StarWarsModel.SortKeys.asArray());
            Collections.addAll(array,
                    CargoCapacity,
                    Consumables,
                    CostInCredits,
                    Length,
                    ManufacturerCount,
                    MaxAtmospheringSpeed,
                    MaxCrew,
                    MinCrew,
                    Model,
                    Name,
                    Passengers,
                    PilotCount
            );

            return array.toArray(new String[] { });
        }
        public static CharSequence[] asArrayTitles(Context context) {
            ArrayList<CharSequence> array = new ArrayList<>();

            Collections.addAll(array, StarWarsModel.SortKeys.asArrayTitles(context));
            Collections.addAll(array,
                    context.getResources().getString(R.string.models_transporter_sortkeys_titles_cargocapacity),
                    context.getResources().getString(R.string.models_transporter_sortkeys_titles_consumables),
                    context.getResources().getString(R.string.models_transporter_sortkeys_titles_costincredits),
                    context.getResources().getString(R.string.models_transporter_sortkeys_titles_length),
                    context.getResources().getString(R.string.models_transporter_sortkeys_titles_manufacturercount),
                    context.getResources().getString(R.string.models_transporter_sortkeys_titles_maxatmospheringspeed),
                    context.getResources().getString(R.string.models_transporter_sortkeys_titles_maxcrew),
                    context.getResources().getString(R.string.models_transporter_sortkeys_titles_mincrew),
                    context.getResources().getString(R.string.models_transporter_sortkeys_titles_model),
                    context.getResources().getString(R.string.models_transporter_sortkeys_titles_name),
                    context.getResources().getString(R.string.models_transporter_sortkeys_titles_passengers),
                    context.getResources().getString(R.string.models_transporter_sortkeys_titles_pilotcount)
            );

            return array.toArray(new CharSequence[] { });
        }
    }
}