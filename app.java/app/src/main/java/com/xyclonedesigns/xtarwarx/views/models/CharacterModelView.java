package com.xyclonedesigns.xtarwarx.views.models;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.Nullable;
import androidx.appcompat.widget.AppCompatTextView;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.models.CharacterModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.CharacterSingleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.PlanetSingleViewModel;
import com.xyclonedesigns.xtarwarx.views.page.ItemsHorizontalPageView;

public class CharacterModelView extends BaseModelView {
    public static class Ids {
        public static final int Layout = R.layout.xtarwarx_view_model_character;

        public static final int Name_AppCompatTextView = R.id.xtarwarx_view_model_character_name_appcompattextview;
        public static final int Description_AppCompatTextView = R.id.xtarwarx_view_model_character_description_appcompattextview;
        public static final int Externallinks_ImagesHorizontalPageView = R.id.xtarwarx_view_model_character_externallinks_imageshorizontalpageview;
        public static final int Images_ImagesHorizontalPageView = R.id.xtarwarx_view_model_character_images_imageshorizontalpageview;
        public static final int Details_Barrier_End = R.id.xtarwarx_view_model_character_details_barrier_end;
        public static final int BirthYear_Key_AppCompatTextView = R.id.xtarwarx_view_model_character_birthyear_key_appcompattextview;
        public static final int BirthYear_Value_AppCompatTextView = R.id.xtarwarx_view_model_character_birthyear_value_appcompattextview;
        public static final int BirthYear_Barrier_Bottom = R.id.xtarwarx_view_model_character_birthyear_barrier_bottom;
        public static final int Height_Key_AppCompatTextView = R.id.xtarwarx_view_model_character_height_key_appcompattextview;
        public static final int Height_Value_AppCompatTextView = R.id.xtarwarx_view_model_character_height_value_appcompattextview;
        public static final int Height_Barrier_Bottom = R.id.xtarwarx_view_model_character_height_barrier_bottom;
        public static final int Mass_Key_AppCompatTextView = R.id.xtarwarx_view_model_character_mass_key_appcompattextview;
        public static final int Mass_Value_AppCompatTextView = R.id.xtarwarx_view_model_character_mass_value_appcompattextview;
        public static final int Mass_Barrier_Bottom = R.id.xtarwarx_view_model_character_mass_barrier_bottom;
        public static final int Sex_Key_AppCompatTextView = R.id.xtarwarx_view_model_character_sex_key_appcompattextview;
        public static final int Sex_Value_AppCompatTextView = R.id.xtarwarx_view_model_character_sex_value_appcompattextview;
        public static final int Sex_Barrier_Bottom = R.id.xtarwarx_view_model_character_sex_barrier_bottom;
        public static final int EyeColors_Key_AppCompatTextView = R.id.xtarwarx_view_model_character_eyecolors_key_appcompattextview;
        public static final int EyeColors_Value_AppCompatTextView = R.id.xtarwarx_view_model_character_eyecolors_value_appcompattextview;
        public static final int EyeColors_Barrier_Bottom = R.id.xtarwarx_view_model_character_eyecolors_barrier_bottom;
        public static final int HairColors_Key_AppCompatTextView = R.id.xtarwarx_view_model_character_haircolors_key_appcompattextview;
        public static final int HairColors_Value_AppCompatTextView = R.id.xtarwarx_view_model_character_haircolors_value_appcompattextview;
        public static final int HairColors_Barrier_Bottom = R.id.xtarwarx_view_model_character_haircolors_barrier_bottom;
        public static final int SkinColors_Key_AppCompatTextView = R.id.xtarwarx_view_model_character_skincolors_key_appcompattextview;
        public static final int SkinColors_Value_AppCompatTextView = R.id.xtarwarx_view_model_character_skincolors_value_appcompattextview;
        public static final int SkinColors_Barrier_Bottom = R.id.xtarwarx_view_model_character_skincolors_barrier_bottom;
        public static final int Homeworld_ItemsHorizontalPageView = R.id.xtarwarx_view_model_character_homeworld_itemshorizontalpageview;
    }

    public CharacterModelView(Context context) {
        super(context);
    }
    public CharacterModelView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public CharacterModelView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public CharacterModelView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        inflate(context, Ids.Layout, this);

        _Name = findViewById(Ids.Name_AppCompatTextView);
        _Description = findViewById(Ids.Description_AppCompatTextView);
        _Images = findViewById(Ids.Images_ImagesHorizontalPageView);
        _ExternalLinks = findViewById(Ids.Externallinks_ImagesHorizontalPageView);
        _BirthYear = findViewById(Ids.BirthYear_Value_AppCompatTextView);
        _Height = findViewById(Ids.Height_Value_AppCompatTextView);
        _Mass = findViewById(Ids.Mass_Value_AppCompatTextView);
        _Sex = findViewById(Ids.Sex_Value_AppCompatTextView);
        _EyeColors = findViewById(Ids.EyeColors_Value_AppCompatTextView);
        _HairColors = findViewById(Ids.HairColors_Value_AppCompatTextView);
        _SkinColors = findViewById(Ids.SkinColors_Value_AppCompatTextView);
        _Homeworld = findViewById(Ids.Homeworld_ItemsHorizontalPageView);

        super.init(context, attr);

        _Homeworld._Items.setItemsAdapter(ItemsHorizontalPageView.ItemsAdapter.createPlanetsAdapter());
    }

    protected @Nullable CharacterSingleViewModel _ViewModel;

    protected AppCompatTextView _Name;
    protected AppCompatTextView _Description;
    protected AppCompatTextView _BirthYear;
    protected AppCompatTextView _Height;
    protected AppCompatTextView _Mass;
    protected AppCompatTextView _Sex;
    protected AppCompatTextView _EyeColors;
    protected AppCompatTextView _HairColors;
    protected AppCompatTextView _SkinColors;
    protected ItemsHorizontalPageView _Homeworld;

    public @Nullable CharacterSingleViewModel getViewModel() {
        return _ViewModel;
    }
    public void setViewModel(@Nullable CharacterSingleViewModel viewModel) {
        _ViewModel = viewModel;

        if (_ViewModel == null) {
            setCharacter(null);
            setCharacterHomeworld(null);

            return;
        }

        setCharacter(_ViewModel._Character);
        setCharacterHomeworld(_ViewModel._Homeworld);
    }
    public void setCharacter(@Nullable CharacterModel character) {
        if (_ViewModel != null && character != null)
            _ViewModel._Character = character;

        if (character == null) {
            _Name.setText("");
            _Description.setText("");
            _BirthYear.setText("");
            _Height.setText("");
            _Mass.setText("");
            _Sex.setText("");
            _EyeColors.setText("");
            _HairColors.setText("");
            _SkinColors.setText("");

            _Images.setImages(null);
            _ExternalLinks.setExternalLinks(null);

            return;
        }


        String name = character._Name == null ? "" : character._Name;
        String description = character._Description == null ? "" : character._Description;
        String birthyear = character._BirthYear == null ? "" : String.valueOf(character._BirthYear);
        String height = character._Height == null ? "" : String.valueOf(character._Height);
        String mass = character._Mass == null ? "" :  String.valueOf(character._Mass);
        String sex = character._Sex == null ? "" : character._Sex;

        _Name.setText(name);
        _Description.setText(description);
        _BirthYear.setText(birthyear);
        _Height.setText(height);
        _Mass.setText(mass);
        _Sex.setText(sex);

        _Images.setImages(character._Uris);
        _ExternalLinks.setExternalLinks(character._Uris);
    }
    public void setCharacterHomeworld(@Nullable PlanetSingleViewModel homeworld) {
        setPlanet(_ViewModel == null
                ? homeworld
                : (_ViewModel._Homeworld = homeworld), _Homeworld
        );
    }
}