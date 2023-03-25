package com.xyclonedesigns.xtarwarx.views.search;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.search.FactionSearchModel;
import com.xyclonedesigns.xtarwarx.views.models.BaseModelView;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.CharacterSearchContainablesView;
import com.xyclonedesigns.xtarwarx.views.search.searchcontainables.FactionSearchContainablesView;

public class FactionSearchView extends BaseSearchView {
    public static class Ids {
        public static final int Layout = R.layout.xtarwarx_view_search_faction;

        public static final int Containables_FactionSearchContainablesView = R.id.xtarwarx_view_search_faction_containables_factionsearchcontainablesview;
        public static final int AlliedCharacters_CharacterSearchContainablesView = R.id.xtarwarx_view_search_faction_alliedcharacters_charactersearchcontainablesview;
        public static final int AlliedFactions_FactionSearchContainablesView = R.id.xtarwarx_view_search_faction_alliedfactions_factionsearchcontainablesview;
        public static final int Leaders_CharacterSearchContainablesView = R.id.xtarwarx_view_search_faction_leaders_charactersearchcontainablesview;
        public static final int MemberCharacters_CharacterSearchContainablesView = R.id.xtarwarx_view_search_faction_membercharacters_charactersearchcontainablesview;
        public static final int MemberFactions_FactionSearchContainablesView = R.id.xtarwarx_view_search_faction_memberfactions_factionsearchcontainablesview;
    }

    public FactionSearchView(Context context) {
        super(context);
    }
    public FactionSearchView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public FactionSearchView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public FactionSearchView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        inflate(context, Ids.Layout, this);
        super.init(context, attr);

        _Containables = findViewById(Ids.Containables_FactionSearchContainablesView);
        _AlliedCharacters = findViewById(Ids.AlliedCharacters_CharacterSearchContainablesView);
        _AlliedFactions = findViewById(Ids.AlliedFactions_FactionSearchContainablesView);
        _Leaders = findViewById(Ids.Leaders_CharacterSearchContainablesView);
        _MemberCharacters = findViewById(Ids.MemberCharacters_CharacterSearchContainablesView);
        _MemberFactions = findViewById(Ids.MemberFactions_FactionSearchContainablesView);
    }

    FactionSearchContainablesView _Containables;
    CharacterSearchContainablesView _AlliedCharacters;
    FactionSearchContainablesView _AlliedFactions;
    CharacterSearchContainablesView _Leaders;
    CharacterSearchContainablesView _MemberCharacters;
    FactionSearchContainablesView _MemberFactions;
    FactionSearchModel _Search;

    public @NonNull FactionSearchModel getSearch() {
        if (_Search == null)
            _Search = new FactionSearchModel();

        _Search._Containables = _Containables.getSearchContainables();
        _Search._AlliedCharacters = _AlliedCharacters.getSearchContainables();
        _Search._AlliedFactions = _AlliedFactions.getSearchContainables();
        _Search._Leaders = _Leaders.getSearchContainables();
        _Search._MemberCharacters = _MemberCharacters.getSearchContainables();
        _Search._MemberFactions = _MemberFactions.getSearchContainables();

        return _Search;
    }
    public void setSearch(@NonNull FactionSearchModel search) {
        _Search = search;

        _Containables.setSearchContainables(_Search._Containables);
        if (_Search._AlliedCharacters != null)
            _AlliedCharacters.setSearchContainables(_Search._AlliedCharacters);
        if (_Search._AlliedFactions != null)
            _AlliedFactions.setSearchContainables(_Search._AlliedFactions);
        if (_Search._Leaders != null)
            _Leaders.setSearchContainables(_Search._Leaders);
        if (_Search._MemberCharacters != null)
            _MemberCharacters.setSearchContainables(_Search._MemberCharacters);
        if (_Search._MemberFactions != null)
            _MemberFactions.setSearchContainables(_Search._MemberFactions);
    }
}