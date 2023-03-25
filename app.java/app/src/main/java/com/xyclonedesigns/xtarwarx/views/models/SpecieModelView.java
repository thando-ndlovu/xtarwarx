package com.xyclonedesigns.xtarwarx.views.models;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.Nullable;
import androidx.appcompat.widget.AppCompatTextView;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.models.SpecieModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.CharacterMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.PlanetSingleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.SpecieSingleViewModel;
import com.xyclonedesigns.xtarwarx.views.page.ItemsHorizontalPageView;

public class SpecieModelView extends BaseModelView {
    public static class Ids {
        public static final int Layout = R.layout.xtarwarx_view_model_specie;

        public static final int Name_AppCompatTextView = R.id.xtarwarx_view_model_specie_name_appcompattextview;
        public static final int Description_AppCompatTextView = R.id.xtarwarx_view_model_specie_description_appcompattextview;
        public static final int Externallinks_ImagesHorizontalPageView = R.id.xtarwarx_view_model_specie_externallinks_imageshorizontalpageview;
        public static final int Images_ImagesHorizontalPageView = R.id.xtarwarx_view_model_specie_images_imageshorizontalpageview;
        public static final int Details_Barrier_End = R.id.xtarwarx_view_model_specie_details_barrier_end;
        public static final int Language_Key_AppCompatTextView = R.id.xtarwarx_view_model_specie_language_key_appcompattextview;
        public static final int Language_Value_AppCompatTextView = R.id.xtarwarx_view_model_specie_language_value_appcompattextview;
        public static final int Language_Barrier_Bottom = R.id.xtarwarx_view_model_specie_language_barrier_bottom;
        public static final int Classification_Key_AppCompatTextView = R.id.xtarwarx_view_model_specie_classification_key_appcompattextview;
        public static final int Classification_Value_AppCompatTextView = R.id.xtarwarx_view_model_specie_classification_value_appcompattextview;
        public static final int Classification_Barrier_Bottom = R.id.xtarwarx_view_model_specie_classification_barrier_bottom;
        public static final int Designation_Key_AppCompatTextView = R.id.xtarwarx_view_model_specie_designation_key_appcompattextview;
        public static final int Designation_Value_AppCompatTextView = R.id.xtarwarx_view_model_specie_designation_value_appcompattextview;
        public static final int Designation_Barrier_Bottom = R.id.xtarwarx_view_model_specie_designation_barrier_bottom;
        public static final int AverageHeight_Key_AppCompatTextView = R.id.xtarwarx_view_model_specie_averageheight_key_appcompattextview;
        public static final int AverageHeight_Value_AppCompatTextView = R.id.xtarwarx_view_model_specie_averageheight_value_appcompattextview;
        public static final int AverageHeight_Barrier_Bottom = R.id.xtarwarx_view_model_specie_averageheight_barrier_bottom;
        public static final int AverageLifespan_Key_AppCompatTextView = R.id.xtarwarx_view_model_specie_averagelifespan_key_appcompattextview;
        public static final int AverageLifespan_Value_AppCompatTextView = R.id.xtarwarx_view_model_specie_averagelifespan_value_appcompattextview;
        public static final int AverageLifespan_Barrier_Bottom = R.id.xtarwarx_view_model_specie_averagelifespan_barrier_bottom;
        public static final int EyeColors_Key_AppCompatTextView = R.id.xtarwarx_view_model_specie_eyecolors_key_appcompattextview;
        public static final int EyeColors_Value_AppCompatTextView = R.id.xtarwarx_view_model_specie_eyecolors_value_appcompattextview;
        public static final int EyeColors_Barrier_Bottom = R.id.xtarwarx_view_model_specie_eyecolors_barrier_bottom;
        public static final int HairColors_Key_AppCompatTextView = R.id.xtarwarx_view_model_specie_haircolors_key_appcompattextview;
        public static final int HairColors_Value_AppCompatTextView = R.id.xtarwarx_view_model_specie_haircolors_value_appcompattextview;
        public static final int HairColors_Barrier_Bottom = R.id.xtarwarx_view_model_specie_haircolors_barrier_bottom;
        public static final int SkinColors_Key_AppCompatTextView = R.id.xtarwarx_view_model_specie_skincolors_key_appcompattextview;
        public static final int SkinColors_Value_AppCompatTextView = R.id.xtarwarx_view_model_specie_skincolors_value_appcompattextview;
        public static final int SkinColors_Barrier_Bottom = R.id.xtarwarx_view_model_specie_skincolors_barrier_bottom;
        public static final int Homeworld_ItemsHorizontalPageView = R.id.xtarwarx_view_model_specie_homeworld_itemshorizontalpageview;
        public static final int Characters_ItemsHorizontalPageView = R.id.xtarwarx_view_model_specie_characters_itemshorizontalpageview;
    }

    public SpecieModelView(Context context) {
        super(context);
    }
    public SpecieModelView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public SpecieModelView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public SpecieModelView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        inflate(context, Ids.Layout, this);

        _Name = findViewById(Ids.Name_AppCompatTextView);
        _Description = findViewById(Ids.Description_AppCompatTextView);
        _ExternalLinks = findViewById(Ids.Externallinks_ImagesHorizontalPageView);
        _Images = findViewById(Ids.Images_ImagesHorizontalPageView);
        _Language = findViewById(Ids.Language_Value_AppCompatTextView);
        _Classification = findViewById(Ids.Classification_Value_AppCompatTextView);
        _Designation = findViewById(Ids.Designation_Value_AppCompatTextView);
        _AverageHeight = findViewById(Ids.AverageHeight_Value_AppCompatTextView);
        _AverageLifespan = findViewById(Ids.AverageLifespan_Value_AppCompatTextView);
        _EyeColors = findViewById(Ids.EyeColors_Value_AppCompatTextView);
        _HairColors = findViewById(Ids.HairColors_Value_AppCompatTextView);
        _SkinColors = findViewById(Ids.SkinColors_Value_AppCompatTextView);
        _Homeworld = findViewById(Ids.Homeworld_ItemsHorizontalPageView);
        _Characters = findViewById(Ids.Characters_ItemsHorizontalPageView);

        super.init(context, attr);

        _Homeworld._Items.setItemsAdapter(ItemsHorizontalPageView.ItemsAdapter.createPlanetsAdapter());
        _Characters._Items.setItemsAdapter(ItemsHorizontalPageView.ItemsAdapter.createStarshipsAdapter());
    }

    public @Nullable SpecieSingleViewModel getViewModel() {
        return _ViewModel;
    }
    public void setViewModel(@Nullable SpecieSingleViewModel viewModel) {
        _ViewModel = viewModel;

        if (_ViewModel == null) {
            setSpecie(null);
            setSpecieCharacters(null);
            setSpecieHomeworld(null);

            return;
        }

        setSpecie(_ViewModel._Specie);
        setSpecieCharacters(_ViewModel._Characters);
        setSpecieHomeworld(_ViewModel._Homeworld);
    }
    public void setSpecie(@Nullable SpecieModel specie) {
        if (_ViewModel != null && specie != null)
            _ViewModel._Specie = specie;

        if (specie == null) {
            _Name.setText("");
            _Description.setText("");
            _Classification.setText("");
            _Designation.setText("");
            _AverageHeight.setText("");
            _AverageLifespan.setText("");
            _EyeColors.setText("");
            _HairColors.setText("");
            _SkinColors.setText("");

            _Images.setImages(null);
            _ExternalLinks.setExternalLinks(null);

            return;
        }

        String name = specie._Name == null ? "" : specie._Name;
        String description = specie._Description == null ? "" : specie._Description;
        String classification = specie._Classification == null ? "" : specie._Classification;
        String designation = specie._Designation == null ? "" : specie._Designation;
        String language = specie._Language == null ? "" : specie._Language;
        String averageheight = specie._AverageHeight == null ? "" : String.valueOf(specie._AverageHeight);
        String averagelifespan = specie._AverageLifespan == null ? "" : String.valueOf(specie._AverageLifespan);

        _Name.setText(name);
        _Description.setText(description);
        _Classification.setText(classification);
        _Designation.setText(designation);
        _AverageHeight.setText(averageheight);
        _AverageLifespan.setText(averagelifespan);

        _Images.setImages(_ViewModel._Specie._Uris);
        _ExternalLinks.setExternalLinks(_ViewModel._Specie._Uris);
    }
    public void setSpecieCharacters(@Nullable CharacterMultipleViewModel characters) {
        setCharacters(_ViewModel == null
                ? characters
                : (_ViewModel._Characters = characters), _Characters
        );
    }
    public void setSpecieHomeworld(@Nullable PlanetSingleViewModel homeworld) {
        setPlanet(_ViewModel == null
                ? homeworld
                : (_ViewModel._Homeworld = homeworld), _Homeworld
        );
    }

    protected @Nullable SpecieSingleViewModel _ViewModel;
    protected AppCompatTextView _Name;
    protected AppCompatTextView _Description;
    protected AppCompatTextView _Language;
    protected AppCompatTextView _Classification;
    protected AppCompatTextView _Designation;
    protected AppCompatTextView _AverageHeight;
    protected AppCompatTextView _AverageLifespan;
    protected AppCompatTextView _EyeColors;
    protected AppCompatTextView _HairColors;
    protected AppCompatTextView _SkinColors;
    protected ItemsHorizontalPageView _Homeworld;
    protected ItemsHorizontalPageView _Characters;
}