package com.xyclonedesigns.xtarwarx.views.models;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.Nullable;
import androidx.appcompat.widget.AppCompatTextView;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.models.ManufacturerModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.StarshipMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.VehicleMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.WeaponMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.ManufacturerSingleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.PlanetSingleViewModel;
import com.xyclonedesigns.xtarwarx.views.page.ItemsHorizontalPageView;

public class ManufacturerModelView extends BaseModelView {
    public static class Ids {
        public static final int Layout = R.layout.xtarwarx_view_model_manufacturer;

        public static final int Name_AppCompatTextView = R.id.xtarwarx_view_model_manufacturer_name_appcompattextview;
        public static final int Description_AppCompatTextView = R.id.xtarwarx_view_model_manufacturer_description_appcompattextview;
        public static final int Externallinks_ImagesHorizontalPageView = R.id.xtarwarx_view_model_manufacturer_externallinks_imageshorizontalpageview;
        public static final int Images_ImagesHorizontalPageView = R.id.xtarwarx_view_model_manufacturer_images_imageshorizontalpageview;
        public static final int HeadquartersPlanet_ItemsHorizontalPageView = R.id.xtarwarx_view_model_manufacturer_headquartersplanet_itemshorizontalpageview;
        public static final int Starships_ItemsHorizontalPageView = R.id.xtarwarx_view_model_manufacturer_starships_itemshorizontalpageview;
        public static final int Vehicles_ItemsHorizontalPageView = R.id.xtarwarx_view_model_manufacturer_vehicles_itemshorizontalpageview;
        public static final int Weapons_ItemsHorizontalPageView = R.id.xtarwarx_view_model_manufacturer_weapons_itemshorizontalpageview;
    }

    public ManufacturerModelView(Context context) {
        super(context);
    }
    public ManufacturerModelView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public ManufacturerModelView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public ManufacturerModelView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        inflate(context, Ids.Layout, this);

        _Name = findViewById(Ids.Name_AppCompatTextView);
        _Description = findViewById(Ids.Description_AppCompatTextView);
        _Images = findViewById(Ids.Images_ImagesHorizontalPageView);
        _ExternalLinks = findViewById(Ids.Externallinks_ImagesHorizontalPageView);
        _HeadquartersPlanet = findViewById(Ids.HeadquartersPlanet_ItemsHorizontalPageView);
        _Starships = findViewById(Ids.Starships_ItemsHorizontalPageView);
        _Vehicles = findViewById(Ids.Vehicles_ItemsHorizontalPageView);
        _Weapons = findViewById(Ids.Weapons_ItemsHorizontalPageView);

        super.init(context, attr);

        _HeadquartersPlanet._Items.setItemsAdapter(ItemsHorizontalPageView.ItemsAdapter.createPlanetsAdapter());
        _Starships._Items.setItemsAdapter(ItemsHorizontalPageView.ItemsAdapter.createStarshipsAdapter());
        _Vehicles._Items.setItemsAdapter(ItemsHorizontalPageView.ItemsAdapter.createVehiclesAdapter());
        _Weapons._Items.setItemsAdapter(ItemsHorizontalPageView.ItemsAdapter.createWeaponsAdapter());
    }

    public @Nullable ManufacturerSingleViewModel getViewModel() {
        return _ViewModel;
    }
    public void setViewModel(@Nullable ManufacturerSingleViewModel viewModel) {
        _ViewModel = viewModel;

        if (_ViewModel == null) {
            setManufacturer(null);
            setManufacturerHeadquartersPlanet(null);
            setManufacturerStarships(null);
            setManufacturerVehicles(null);
            setManufacturerWeapons(null);

            return;
        }

        setManufacturer(_ViewModel._Manufacturer);
        setManufacturerHeadquartersPlanet(_ViewModel._HeadquartersPlanet);
        setManufacturerStarships(_ViewModel._Starships);
        setManufacturerVehicles(_ViewModel._Vehicles);
        setManufacturerWeapons(_ViewModel._Weapons);
    }
    public void setManufacturer(@Nullable ManufacturerModel manufacturer) {
        if (_ViewModel != null && manufacturer != null)
            _ViewModel._Manufacturer = manufacturer;

        if (manufacturer == null) {
            _Name.setText("");
            _Description.setText("");

            _Images.setImages(null);
            _ExternalLinks.setExternalLinks(null);

            setPlanet(null, _HeadquartersPlanet);
            setStarships(null, _Starships);
            setVehicles(null, _Vehicles);
            setWeapons(null, _Weapons);

            return;
        }

        String name = manufacturer._Name == null ? "" : manufacturer._Name;
        String description = manufacturer._Description == null ? "" : manufacturer._Description;

        _Name.setText(name);
        _Description.setText(description);

        _Images.setImages(_ViewModel._Manufacturer._Uris);
        _ExternalLinks.setExternalLinks(_ViewModel._Manufacturer._Uris);
    }
    public void setManufacturerHeadquartersPlanet(@Nullable PlanetSingleViewModel headquartersplanet) {
        setPlanet(_ViewModel == null
                ? headquartersplanet
                : (_ViewModel._HeadquartersPlanet = headquartersplanet), _HeadquartersPlanet
        );
    }
    public void setManufacturerStarships(@Nullable StarshipMultipleViewModel starships) {
        setStarships(_ViewModel == null
                ? starships
                : (_ViewModel._Starships = starships), _Starships
        );
    }
    public void setManufacturerVehicles(@Nullable VehicleMultipleViewModel vehicles) {
        setVehicles(_ViewModel == null
                ? vehicles
                : (_ViewModel._Vehicles = vehicles), _Vehicles
        );
    }
    public void setManufacturerWeapons(@Nullable WeaponMultipleViewModel weapons) {
        setWeapons(_ViewModel == null
                ? weapons
                : (_ViewModel._Weapons = weapons), _Weapons
        );
    }

    protected @Nullable ManufacturerSingleViewModel _ViewModel;

    protected AppCompatTextView _Name;
    protected AppCompatTextView _Description;
    protected ItemsHorizontalPageView _HeadquartersPlanet;
    protected ItemsHorizontalPageView _Starships;
    protected ItemsHorizontalPageView _Vehicles;
    protected ItemsHorizontalPageView _Weapons;
}