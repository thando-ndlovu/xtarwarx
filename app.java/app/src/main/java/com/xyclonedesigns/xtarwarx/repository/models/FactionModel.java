package com.xyclonedesigns.xtarwarx.repository.models;

import android.content.Context;

import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.utils.JsonUtils;

import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.Collections;

public class FactionModel extends StarWarsModel {
    public FactionModel(int id) {
        super(id);
    }
    public FactionModel(JSONObject json) throws JSONException {
        super(json);

        if (!json.isNull(JsonKeys.AlliedCharacterIds)) _AlliedCharacterIds = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.AlliedCharacterIds), obj -> Integer.parseInt(obj.toString()));
        if (!json.isNull(JsonKeys.AlliedFactionIds)) _AlliedFactionIds = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.AlliedFactionIds), obj -> Integer.parseInt(obj.toString()));
        if (!json.isNull(JsonKeys.Description)) _Description = json.getString(JsonKeys.Description);
        if (!json.isNull(JsonKeys.LeaderIds)) _LeaderIds = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.LeaderIds), obj -> Integer.parseInt(obj.toString()));
        if (!json.isNull(JsonKeys.MemberCharacterIds)) _MemberCharacterIds = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.MemberCharacterIds), obj -> Integer.parseInt(obj.toString()));
        if (!json.isNull(JsonKeys.MemberFactionIds)) _MemberFactionIds = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.MemberFactionIds), obj -> Integer.parseInt(obj.toString()));
        if (!json.isNull(JsonKeys.Name)) _Name = json.getString(JsonKeys.Name);
        if (!json.isNull(JsonKeys.OrganizationTypes)) _OrganizationTypes = JsonUtils.fromJsonArrayList(json.getJSONArray(JsonKeys.OrganizationTypes), Object::toString);
    }

    public @Nullable ArrayList<Integer> _AlliedCharacterIds;
    public @Nullable ArrayList<Integer> _AlliedFactionIds;
    public @Nullable String _Description;
    public @Nullable ArrayList<Integer> _LeaderIds;
    public @Nullable ArrayList<Integer> _MemberCharacterIds;
    public @Nullable ArrayList<Integer> _MemberFactionIds;
    public @Nullable String _Name;
    public @Nullable ArrayList<String> _OrganizationTypes;

    public static class JsonKeys extends StarWarsModel.JsonKeys {
        public static final String AlliedCharacterIds = "alliedCharacterIds";
        public static final String AlliedFactionIds = "alliedFactionIds";
        public static final String Description = "description";
        public static final String LeaderIds = "leaderIds";
        public static final String MemberCharacterIds = "memberCharacterIds";
        public static final String MemberFactionIds = "memberFactionIds";
        public static final String Name = "name";
        public static final String OrganizationTypes = "organizationTypes";
    }
    public static class SortKeys extends StarWarsModel.SortKeys {
        public static final String AlliedCharacterCount = "alliedcharactercount";
        public static final String AlliedFactionCount = "alliedfactioncount";
        public static final String Description = "description";
        public static final String LeaderCount = "leadercount";
        public static final String MemberCharacterCount = "membercharactercount";
        public static final String MemberFactionCount = "memberfactioncount";
        public static final String Name = "name";
        public static final String OrganizationTypes = "organizationtypes";

        public static String[] asArray() {
            ArrayList<String> array = new ArrayList<>();

            Collections.addAll(array, StarWarsModel.SortKeys.asArray());
            Collections.addAll(array,
                    AlliedCharacterCount,
                    AlliedFactionCount,
                    LeaderCount,
                    MemberCharacterCount,
                    MemberFactionCount,
                    Name,
                    OrganizationTypes
            );

            return array.toArray(new String[] { });
        }
        public static CharSequence[] asArrayTitles(Context context) {
            ArrayList<CharSequence> array = new ArrayList<>();

            Collections.addAll(array, StarWarsModel.SortKeys.asArrayTitles(context));
            Collections.addAll(array,
                    context.getResources().getString(R.string.models_faction_sortkeys_titles_alliedcharactercount),
                    context.getResources().getString(R.string.models_faction_sortkeys_titles_alliedfactioncount),
                    context.getResources().getString(R.string.models_faction_sortkeys_titles_leadercount),
                    context.getResources().getString(R.string.models_faction_sortkeys_titles_membercharactercount),
                    context.getResources().getString(R.string.models_faction_sortkeys_titles_memberfactioncount),
                    context.getResources().getString(R.string.models_faction_sortkeys_titles_name),
                    context.getResources().getString(R.string.models_faction_sortkeys_titles_organizationtypes)
            );

            return array.toArray(new CharSequence[] { });
        }
    }
    public static class OrganizationTypeTypes {
        public final String Authoritarian = "Authoritarian";
        public final String BountyHunters = "BountyHunters";
        public final String Confederation = "Confederation";
        public final String Cult = "Cult";
        public final String DemocraticUnion = "DemocraticUnion";
        public final String Empire = "Empire";
        public final String Humanocentrism = "Humanocentrism";
        public final String Hunters = "Hunters";
        public final String Mercenaries = "Mercenaries";
        public final String Millitant = "Millitant";
        public final String MillitaryUnit = "MillitaryUnit";
        public final String Political = "Political";
        public final String QuasiReligion = "QuasiReligion";
        public final String RebelCell = "RebelCell";
        public final String RepublicRebelCell = "RepublicRebelCell";
        public final String Soldiers = "Soldiers";
        public final String SplinterMillitaryGroup = "SplinterMillitaryGroup";
    }
}