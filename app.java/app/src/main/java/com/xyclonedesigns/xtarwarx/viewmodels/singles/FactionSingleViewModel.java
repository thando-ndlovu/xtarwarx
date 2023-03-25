package com.xyclonedesigns.xtarwarx.viewmodels.singles;

import android.content.Context;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.FactionModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.CharacterMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.FactionMultipleViewModel;

public class FactionSingleViewModel extends BaseSingleViewModel<FactionModel> {
    public FactionSingleViewModel(@NonNull Context context, @NonNull StarWarsRepository repository, @NonNull FactionModel faction) {
        super(context, repository);

        _Faction = faction;
    }

    public @NonNull FactionModel _Faction;
    public @Nullable CharacterMultipleViewModel _AlliedCharacters;
    public @Nullable FactionMultipleViewModel _AlliedFactions;
    public @Nullable CharacterMultipleViewModel _Leaders;
    public @Nullable CharacterMultipleViewModel _MemberCharacters;
    public @Nullable FactionMultipleViewModel _MemberFactions;

    @Override
    public void dataRequest() {
        super.dataRequest();

        _Repository.factions().get(this, null, _Faction._Id);
        if (_AlliedCharacters != null) _Repository.characters()
            .get(_AlliedCharacters, _AlliedCharacters._Pagination, _Faction._AlliedCharacterIds);
        if (_AlliedFactions != null) _Repository.factions()
            .get(_AlliedFactions, _AlliedFactions._Pagination, _Faction._AlliedFactionIds);
        if (_Leaders != null) _Repository.characters()
            .get(_Leaders, _Leaders._Pagination, _Faction._LeaderIds);
        if (_AlliedCharacters != null) _Repository.characters()
            .get(_AlliedCharacters, _AlliedCharacters._Pagination, _Faction._AlliedCharacterIds);
        if (_AlliedFactions != null) _Repository.factions()
            .get(_AlliedFactions, _AlliedFactions._Pagination, _Faction._AlliedFactionIds);
    }
    @Override
    public void dataCallback(StarWarsRepository.Data<FactionModel> data) {
        super.dataCallback(data);

        if (!data._Items.isEmpty())
            _Faction = data._Items.get(0);
    }
}