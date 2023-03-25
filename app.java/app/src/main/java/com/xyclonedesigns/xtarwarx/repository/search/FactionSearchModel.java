package com.xyclonedesigns.xtarwarx.repository.search;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.repository.searchcontainables.CharacterSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.FactionSearchContainablesModel;

public class FactionSearchModel extends StarWarsSearchModel {
    public @Nullable FactionSearchContainablesModel _Containables;
    public @Nullable CharacterSearchContainablesModel _AlliedCharacters;
    public @Nullable FactionSearchContainablesModel _AlliedFactions;
    public @Nullable CharacterSearchContainablesModel _Leaders;
    public @Nullable CharacterSearchContainablesModel _MemberCharacters;
    public @Nullable FactionSearchContainablesModel _MemberFactions;
}