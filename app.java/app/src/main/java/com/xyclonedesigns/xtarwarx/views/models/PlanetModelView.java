package com.xyclonedesigns.xtarwarx.views.models;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.Nullable;
import androidx.appcompat.widget.AppCompatTextView;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.models.PlanetModel;
import com.xyclonedesigns.xtarwarx.repository.models.PlanetModelClimate;
import com.xyclonedesigns.xtarwarx.repository.models.PlanetModelTerrain;
import com.xyclonedesigns.xtarwarx.utils.StringUtils;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.CharacterMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.PlanetSingleViewModel;
import com.xyclonedesigns.xtarwarx.views.page.ItemsHorizontalPageView;

import java.util.Iterator;

public class PlanetModelView extends BaseModelView {
    public static class Ids {
        public static final int Layout = R.layout.xtarwarx_view_model_planet;

        public static final int Name_AppCompatTextView = R.id.xtarwarx_view_model_planet_name_appcompattextview;
        public static final int Description_AppCompatTextView = R.id.xtarwarx_view_model_planet_description_appcompattextview;
        public static final int Externallinks_ImagesHorizontalPageView = R.id.xtarwarx_view_model_planet_externallinks_imageshorizontalpageview;
        public static final int Images_ImagesHorizontalPageView = R.id.xtarwarx_view_model_planet_images_imageshorizontalpageview;
        public static final int Details_Barrier_End = R.id.xtarwarx_view_model_planet_details_barrier_end;
        public static final int Population_Key_AppCompatTextView = R.id.xtarwarx_view_model_planet_population_key_appcompattextview;
        public static final int Population_Value_AppCompatTextView = R.id.xtarwarx_view_model_planet_population_value_appcompattextview;
        public static final int Population_Barrier_Bottom = R.id.xtarwarx_view_model_planet_population_barrier_bottom;
        public static final int Diameter_Key_AppCompatTextView = R.id.xtarwarx_view_model_planet_diameter_key_appcompattextview;
        public static final int Diameter_Value_AppCompatTextView = R.id.xtarwarx_view_model_planet_diameter_value_appcompattextview;
        public static final int Diameter_Barrier_Bottom = R.id.xtarwarx_view_model_planet_diameter_barrier_bottom;
        public static final int Gravity_Key_AppCompatTextView = R.id.xtarwarx_view_model_planet_gravity_key_appcompattextview;
        public static final int Gravity_Value_AppCompatTextView = R.id.xtarwarx_view_model_planet_gravity_value_appcompattextview;
        public static final int Gravity_Barrier_Bottom = R.id.xtarwarx_view_model_planet_gravity_barrier_bottom;
        public static final int SurfaceWater_Key_AppCompatTextView = R.id.xtarwarx_view_model_planet_surfacewater_key_appcompattextview;
        public static final int SurfaceWater_Value_AppCompatTextView = R.id.xtarwarx_view_model_planet_surfacewater_value_appcompattextview;
        public static final int SurfaceWater_Barrier_Bottom = R.id.xtarwarx_view_model_planet_surfacewater_barrier_bottom;
        public static final int OrbitalPeriod_Key_AppCompatTextView = R.id.xtarwarx_view_model_planet_orbitalperiod_key_appcompattextview;
        public static final int OrbitalPeriod_Value_AppCompatTextView = R.id.xtarwarx_view_model_planet_orbitalperiod_value_appcompattextview;
        public static final int OrbitalPeriod_Barrier_Bottom = R.id.xtarwarx_view_model_planet_orbitalperiod_barrier_bottom;
        public static final int RotationalPeriod_Key_AppCompatTextView = R.id.xtarwarx_view_model_planet_rotationalperiod_key_appcompattextview;
        public static final int RotationalPeriod_Value_AppCompatTextView = R.id.xtarwarx_view_model_planet_rotationalperiod_value_appcompattextview;
        public static final int RotationalPeriod_Barrier_Bottom = R.id.xtarwarx_view_model_planet_rotationalperiod_barrier_bottom;
        public static final int Climates_Key_AppCompatTextView = R.id.xtarwarx_view_model_planet_climates_key_appcompattextview;
        public static final int Climates_Value_AppCompatTextView = R.id.xtarwarx_view_model_planet_climates_value_appcompattextview;
        public static final int Climates_Barrier_Bottom = R.id.xtarwarx_view_model_planet_climates_barrier_bottom;
        public static final int Terrains_Key_AppCompatTextView = R.id.xtarwarx_view_model_planet_terrains_key_appcompattextview;
        public static final int Terrains_Value_AppCompatTextView = R.id.xtarwarx_view_model_planet_terrains_value_appcompattextview;
        public static final int Terrains_Barrier_Bottom = R.id.xtarwarx_view_model_planet_terrains_barrier_bottom;
        public static final int Residents_ItemsHorizontalPageView = R.id.xtarwarx_view_model_planet_residents_itemshorizontalpageview;
    }

    public PlanetModelView(Context context) {
        super(context);
    }
    public PlanetModelView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public PlanetModelView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public PlanetModelView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        inflate(context, Ids.Layout, this);

        _Name = findViewById(Ids.Name_AppCompatTextView);
        _Description = findViewById(Ids.Description_AppCompatTextView);
        _ExternalLinks = findViewById(Ids.Externallinks_ImagesHorizontalPageView);
        _Images = findViewById(Ids.Images_ImagesHorizontalPageView);
        _Population = findViewById(Ids.Population_Value_AppCompatTextView);
        _Diameter = findViewById(Ids.Diameter_Value_AppCompatTextView);
        _Gravity = findViewById(Ids.Gravity_Value_AppCompatTextView);
        _SurfaceWater = findViewById(Ids.SurfaceWater_Value_AppCompatTextView);
        _OrbitalPeriod = findViewById(Ids.OrbitalPeriod_Value_AppCompatTextView);
        _RotationalPeriod = findViewById(Ids.RotationalPeriod_Value_AppCompatTextView);
        _Climates = findViewById(Ids.Climates_Value_AppCompatTextView);
        _Terrains = findViewById(Ids.Terrains_Value_AppCompatTextView);
        _Residents = findViewById(Ids.Residents_ItemsHorizontalPageView);

        super.init(context, attr);

        _Residents._Items.setItemsAdapter(ItemsHorizontalPageView.ItemsAdapter.createCharactersAdapter());
    }

    public @Nullable PlanetSingleViewModel getViewModel() {
        return _ViewModel;
    }
    public void setViewModel(@Nullable PlanetSingleViewModel viewModel) {
        _ViewModel = viewModel;

        if (_ViewModel == null) {
            setPlanet(null);
            setPlanetsResidents(null);

            return;
        }

        setPlanet(_ViewModel._Planet);
        setPlanetsResidents(_ViewModel._Residents);
    }
    public void setPlanet(@Nullable PlanetModel planet) {
        if (_ViewModel != null && planet != null)
            _ViewModel._Planet = planet;

        if (planet == null) {

            _Name.setText("");
            _Description.setText("");
            _Population.setText("");
            _Diameter.setText("");
            _Gravity.setText("");
            _SurfaceWater.setText("");
            _OrbitalPeriod.setText("");
            _RotationalPeriod.setText("");
            _Climates.setText("");
            _Terrains.setText("");

            _Images.setImages(null);
            _ExternalLinks.setExternalLinks(null);

            return;
        }

        String name = planet._Name == null ? "" : planet._Name;
        String description = planet._Description == null ? "" : planet._Description;
        String population = planet._Population == null ? "" : String.valueOf(planet._Population);
        String diameter = planet._Diameter == null ? "" : String.valueOf(planet._Diameter);
        String gravity = planet._Gravity == null ? "" : String.valueOf(planet._Gravity);
        String surfacewater = planet._SurfaceWater == null ? "" : String.valueOf(planet._SurfaceWater);
        String orbitalperiod = planet._OrbitalPeriod == null ? "" : String.format(
                "%s days/s",
                planet._OrbitalPeriod
        );
        String rotationalperiod = planet._RotationalPeriod == null ? "" :String.format(
                "%s hours/s",
                planet._RotationalPeriod
        );

        StringBuilder climatesstringbuilder = new StringBuilder();
        StringBuilder terrainsstringbuilder = new StringBuilder();

        Iterator<PlanetModelClimate> climatesiterator =
                planet._Climates == null ? null : planet._Climates.iterator();
        Iterator<PlanetModelTerrain> terrainsiterator =
                planet._Terrains == null ? null : planet._Terrains.iterator();

        if (climatesiterator != null)
            while (climatesiterator.hasNext()) {
                PlanetModelClimate planetmodelclimate = climatesiterator.next();
                climatesstringbuilder.append(String.format(
                        "%s [%s]",
                        planetmodelclimate._Type == null ? "" : planetmodelclimate._Type,
                        planetmodelclimate._Flags == null ? "" : StringUtils.join(", ", planetmodelclimate._Flags)
                ));
            }

        if (terrainsiterator != null)
            while (terrainsiterator.hasNext()) {
                PlanetModelTerrain planetmodelterrain = terrainsiterator.next();
                terrainsstringbuilder.append(String.format(
                        "%s [%s]",
                        planetmodelterrain._Type == null ? "" : planetmodelterrain._Type,
                        planetmodelterrain._Flags == null ? "" : StringUtils.join(", ", planetmodelterrain._Flags)
                ));
            }

        _Name.setText(name);
        _Description.setText(description);
        _Population.setText(population);
        _Diameter.setText(diameter);
        _Gravity.setText(gravity);
        _SurfaceWater.setText(surfacewater);
        _OrbitalPeriod.setText(orbitalperiod);
        _RotationalPeriod.setText(rotationalperiod);
        _Climates.setText(climatesstringbuilder.toString());
        _Terrains.setText(terrainsstringbuilder.toString());

        _Images.setImages(_ViewModel._Planet._Uris);
        _ExternalLinks.setExternalLinks(_ViewModel._Planet._Uris);
    }
    public void setPlanetsResidents(@Nullable CharacterMultipleViewModel residents) {
        setCharacters(_ViewModel == null
                ? residents
                : (_ViewModel._Residents = residents), _Residents
        );
    }

    protected @Nullable PlanetSingleViewModel _ViewModel;

    protected AppCompatTextView _Name;
    protected AppCompatTextView _Description;
    protected AppCompatTextView _Population;
    protected AppCompatTextView _Diameter;
    protected AppCompatTextView _Gravity;
    protected AppCompatTextView _SurfaceWater;
    protected AppCompatTextView _OrbitalPeriod;
    protected AppCompatTextView _RotationalPeriod;
    protected AppCompatTextView _Climates;
    protected AppCompatTextView _Terrains;
    protected ItemsHorizontalPageView _Residents;
}