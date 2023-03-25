package com.xyclonedesigns.xtarwarx.views.models;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.Nullable;
import androidx.appcompat.widget.AppCompatTextView;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.models.FactionModel;
import com.xyclonedesigns.xtarwarx.utils.StringUtils;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.CharacterMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.FactionMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.FactionSingleViewModel;
import com.xyclonedesigns.xtarwarx.views.page.ItemsHorizontalPageView;

public class FactionModelView extends BaseModelView {
    public static class Ids {
        public static final int Layout = R.layout.xtarwarx_view_model_faction;

        public static final int Name_AppCompatTextView = R.id.xtarwarx_view_model_faction_name_appcompattextview;
        public static final int OrganisationTypes_AppCompatTextView = R.id.xtarwarx_view_model_faction_organisationtypes_appcompattextview;
        public static final int Description_AppCompatTextView = R.id.xtarwarx_view_model_faction_description_appcompattextview;
        public static final int Externallinks_ImagesHorizontalPageView = R.id.xtarwarx_view_model_faction_externallinks_imageshorizontalpageview;
        public static final int Images_ImagesHorizontalPageView = R.id.xtarwarx_view_model_faction_images_imageshorizontalpageview;
        public static final int AlliedCharacters_ItemsHorizontalPageView = R.id.xtarwarx_view_model_faction_alliedcharacters_itemshorizontalpageview;
        public static final int AlliedFactions_ItemsHorizontalPageView = R.id.xtarwarx_view_model_faction_alliedfactions_itemshorizontalpageview;
        public static final int Leaders_ItemsHorizontalPageView = R.id.xtarwarx_view_model_faction_leaders_itemshorizontalpageview;
        public static final int MemberCharacters_ItemsHorizontalPageView = R.id.xtarwarx_view_model_faction_membercharacters_itemshorizontalpageview;
        public static final int MemberFactions_ItemsHorizontalPageView = R.id.xtarwarx_view_model_faction_memberfactions_itemshorizontalpageview;
    }

    public FactionModelView(Context context) {
        super(context);
    }
    public FactionModelView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public FactionModelView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public FactionModelView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        inflate(context, Ids.Layout, this);

        _Name = findViewById(Ids.Name_AppCompatTextView);
        _OrganisationTypes = findViewById(Ids.OrganisationTypes_AppCompatTextView);
        _Description = findViewById(Ids.Description_AppCompatTextView);
        _Images = findViewById(Ids.Images_ImagesHorizontalPageView);
        _ExternalLinks = findViewById(Ids.Externallinks_ImagesHorizontalPageView);
        _AlliedCharacters = findViewById(Ids.AlliedCharacters_ItemsHorizontalPageView);
        _AlliedFactions = findViewById(Ids.AlliedFactions_ItemsHorizontalPageView);
        _Leaders = findViewById(Ids.Leaders_ItemsHorizontalPageView);
        _MemberCharacters = findViewById(Ids.MemberCharacters_ItemsHorizontalPageView);
        _MemberFactions = findViewById(Ids.MemberFactions_ItemsHorizontalPageView);

        super.init(context, attr);

        _AlliedCharacters._Items.setItemsAdapter(ItemsHorizontalPageView.ItemsAdapter.createCharactersAdapter());
        _AlliedFactions._Items.setItemsAdapter(ItemsHorizontalPageView.ItemsAdapter.createFactionsAdapter());
        _Leaders._Items.setItemsAdapter(ItemsHorizontalPageView.ItemsAdapter.createCharactersAdapter());
        _MemberCharacters._Items.setItemsAdapter(ItemsHorizontalPageView.ItemsAdapter.createCharactersAdapter());
        _MemberFactions._Items.setItemsAdapter(ItemsHorizontalPageView.ItemsAdapter.createFactionsAdapter());
    }

    public @Nullable FactionSingleViewModel getViewModel() {
        return _ViewModel;
    }
    public void setViewModel(@Nullable FactionSingleViewModel viewModel) {
        _ViewModel = viewModel;

        if (_ViewModel == null) {
            setFaction(null);
            setFactionAlliedCharacters(null);
            setFactionAlliedFactions(null);
            setFactionLeaders(null);
            setFactionMemberCharacters(null);
            setFactionMemberFactions(null);

            return;
        }

        setFaction(_ViewModel._Faction);
        setFactionAlliedCharacters(_ViewModel._AlliedCharacters);
        setFactionAlliedFactions(_ViewModel._AlliedFactions);
        setFactionLeaders(_ViewModel._Leaders);
        setFactionMemberCharacters(_ViewModel._MemberCharacters);
        setFactionMemberFactions(_ViewModel._MemberFactions);
    }
    public void setFaction(@Nullable FactionModel faction) {
        if (_ViewModel != null && faction != null)
            _ViewModel._Faction = faction;

        if (faction == null) {
            _Name.setText("");
            _Description.setText("");
            _OrganisationTypes.setText("");

            _Images.setImages(null);
            _ExternalLinks.setExternalLinks(null);

            return;
        }

        String name = faction._Name == null ? "" : faction._Name;
        String description = faction._Description == null ? "" : faction._Description;
        String organisationtypes = faction._OrganizationTypes == null ? "" : StringUtils.join(", ", faction._OrganizationTypes);

        _Name.setText(name);
        _Description.setText(description);
        _OrganisationTypes.setText(organisationtypes);

        _Images.setImages(_ViewModel._Faction._Uris);
        _ExternalLinks.setExternalLinks(_ViewModel._Faction._Uris);
    }
    public void setFactionAlliedCharacters(@Nullable CharacterMultipleViewModel alliedcharacters) {
        setCharacters(_ViewModel == null
                ? alliedcharacters
                : (_ViewModel._AlliedCharacters = alliedcharacters), _AlliedCharacters
        );
    }
    public void setFactionAlliedFactions(@Nullable FactionMultipleViewModel alliedfactions) {
        setFactions(_ViewModel == null
                ? alliedfactions
                : (_ViewModel._AlliedFactions = alliedfactions), _AlliedFactions
        );
    }
    public void setFactionLeaders(@Nullable CharacterMultipleViewModel leaders) {
        setCharacters(_ViewModel == null
                ? leaders
                : (_ViewModel._Leaders = leaders), _Leaders
        );
    }
    public void setFactionMemberCharacters(@Nullable CharacterMultipleViewModel membercharacters) {
        setCharacters(_ViewModel == null
                ? membercharacters
                : (_ViewModel._MemberCharacters = membercharacters), _MemberCharacters
        );
    }
    public void setFactionMemberFactions(@Nullable FactionMultipleViewModel memberfactions) {
        setFactions(_ViewModel == null
                ? memberfactions
                : (_ViewModel._MemberFactions = memberfactions), _MemberFactions
        );
    }

    protected @Nullable FactionSingleViewModel _ViewModel;

    protected AppCompatTextView _Name;
    protected AppCompatTextView _OrganisationTypes;
    protected AppCompatTextView _Description;
    protected ItemsHorizontalPageView _AlliedCharacters;
    protected ItemsHorizontalPageView _AlliedFactions;
    protected ItemsHorizontalPageView _Leaders;
    protected ItemsHorizontalPageView _MemberCharacters;
    protected ItemsHorizontalPageView _MemberFactions;
}