package com.xyclonedesigns.xtarwarx.views.models;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.Nullable;
import androidx.appcompat.widget.AppCompatTextView;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.models.VehicleModel;
import com.xyclonedesigns.xtarwarx.utils.StringUtils;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.VehicleSingleViewModel;
import com.xyclonedesigns.xtarwarx.views.page.ItemsHorizontalPageView;

public class VehicleModelView extends TransporterModelView {
    public static class Ids {
        public static final int Layout = R.layout.xtarwarx_view_model_vehicle;

        public static final int Name_AppCompatTextView = R.id.xtarwarx_view_model_vehicle_name_appcompattextview;
        public static final int Model_AppCompatTextView = R.id.xtarwarx_view_model_vehicle_model_appcompattextview;
        public static final int Description_AppCompatTextView = R.id.xtarwarx_view_model_vehicle_description_appcompattextview;
        public static final int VehicleClass_AppCompatTextView = R.id.xtarwarx_view_model_vehicle_vehicleclass_appcompattextview;
        public static final int Externallinks_ImagesHorizontalPageView = R.id.xtarwarx_view_model_vehicle_externallinks_imageshorizontalpageview;
        public static final int Images_ImagesHorizontalPageView = R.id.xtarwarx_view_model_vehicle_images_imageshorizontalpageview;
        public static final int Details_Barrier_End = R.id.xtarwarx_view_model_vehicle_details_barrier_end;
        public static final int MaxAtmospheringSpeed_Key_AppCompatTextView = R.id.xtarwarx_view_model_vehicle_maxatmospheringspeed_key_appcompattextview;
        public static final int MaxAtmospheringSpeed_Value_AppCompatTextView = R.id.xtarwarx_view_model_vehicle_maxatmospheringspeed_value_appcompattextview;
        public static final int MaxAtmospheringSpeed_Barrier_Bottom = R.id.xtarwarx_view_model_vehicle_maxatmospheringspeed_barrier_bottom;
        public static final int CostInCredits_Key_AppCompatTextView = R.id.xtarwarx_view_model_vehicle_costincredits_key_appcompattextview;
        public static final int CostInCredits_Value_AppCompatTextView = R.id.xtarwarx_view_model_vehicle_costincredits_value_appcompattextview;
        public static final int CostInCredits_Barrier_Bottom = R.id.xtarwarx_view_model_vehicle_costincredits_barrier_bottom;
        public static final int Length_Key_AppCompatTextView = R.id.xtarwarx_view_model_vehicle_length_key_appcompattextview;
        public static final int Length_Value_AppCompatTextView = R.id.xtarwarx_view_model_vehicle_length_value_appcompattextview;
        public static final int Length_Barrier_Bottom = R.id.xtarwarx_view_model_vehicle_length_barrier_bottom;
        public static final int MinCrew_Key_AppCompatTextView = R.id.xtarwarx_view_model_vehicle_mincrew_key_appcompattextview;
        public static final int MinCrew_Value_AppCompatTextView = R.id.xtarwarx_view_model_vehicle_mincrew_value_appcompattextview;
        public static final int MinCrew_Barrier_Bottom = R.id.xtarwarx_view_model_vehicle_mincrew_barrier_bottom;
        public static final int MaxCrew_Key_AppCompatTextView = R.id.xtarwarx_view_model_vehicle_maxcrew_key_appcompattextview;
        public static final int MaxCrew_Value_AppCompatTextView = R.id.xtarwarx_view_model_vehicle_maxcrew_value_appcompattextview;
        public static final int MaxCrew_Barrier_Bottom = R.id.xtarwarx_view_model_vehicle_maxcrew_barrier_bottom;
        public static final int CargoCapacity_Key_AppCompatTextView = R.id.xtarwarx_view_model_vehicle_cargocapacity_key_appcompattextview;
        public static final int CargoCapacity_Value_AppCompatTextView = R.id.xtarwarx_view_model_vehicle_cargocapacity_value_appcompattextview;
        public static final int CargoCapacity_Barrier_Bottom = R.id.xtarwarx_view_model_vehicle_cargocapacity_barrier_bottom;
        public static final int Passengers_Key_AppCompatTextView = R.id.xtarwarx_view_model_vehicle_passengers_key_appcompattextview;
        public static final int Passengers_Value_AppCompatTextView = R.id.xtarwarx_view_model_vehicle_passengers_value_appcompattextview;
        public static final int Passengers_Barrier_Bottom = R.id.xtarwarx_view_model_vehicle_passengers_barrier_bottom;
        public static final int Consumables_Key_AppCompatTextView = R.id.xtarwarx_view_model_vehicle_consumables_key_appcompattextview;
        public static final int Consumables_Value_AppCompatTextView = R.id.xtarwarx_view_model_vehicle_consumables_value_appcompattextview;
        public static final int Consumables_Barrier_Bottom = R.id.xtarwarx_view_model_vehicle_consumables_barrier_bottom;
        public static final int Manufacturers_ItemsHorizontalPageView = R.id.xtarwarx_view_model_vehicle_manufacturers_itemshorizontalpageview;
        public static final int Pilots_ItemsHorizontalPageView = R.id.xtarwarx_view_model_vehicle_pilots_itemshorizontalpageview;
    }

    public VehicleModelView(Context context) {
        super(context);
    }
    public VehicleModelView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public VehicleModelView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public VehicleModelView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        inflate(context, Ids.Layout, this);

        _Name = findViewById(Ids.Name_AppCompatTextView);
        _Model = findViewById(Ids.Model_AppCompatTextView);
        _Description = findViewById(Ids.Description_AppCompatTextView);
        _VehicleClass = findViewById(Ids.VehicleClass_AppCompatTextView);
        _ExternalLinks = findViewById(Ids.Externallinks_ImagesHorizontalPageView);
        _Images = findViewById(Ids.Images_ImagesHorizontalPageView);
        _MaxAtmospheringSpeed = findViewById(Ids.MaxAtmospheringSpeed_Value_AppCompatTextView);
        _CostInCredits = findViewById(Ids.CostInCredits_Value_AppCompatTextView);
        _Length = findViewById(Ids.Length_Value_AppCompatTextView);
        _MinCrew = findViewById(Ids.MinCrew_Value_AppCompatTextView);
        _MaxCrew = findViewById(Ids.MaxCrew_Value_AppCompatTextView);
        _CargoCapacity = findViewById(Ids.CargoCapacity_Value_AppCompatTextView);
        _Passengers = findViewById(Ids.Passengers_Value_AppCompatTextView);
        _Consumables = findViewById(Ids.Consumables_Value_AppCompatTextView);
        _Manufacturers = findViewById(Ids.Manufacturers_ItemsHorizontalPageView);
        _Pilots = findViewById(Ids.Pilots_ItemsHorizontalPageView);

        super.init(context, attr);

        _Manufacturers._Items.setItemsAdapter(ItemsHorizontalPageView.ItemsAdapter.createManufacturersAdapter());
        _Pilots._Items.setItemsAdapter(ItemsHorizontalPageView.ItemsAdapter.createCharactersAdapter());
    }

    public @Nullable VehicleSingleViewModel getViewModel() {
        return _ViewModel;
    }
    public void setViewModel(VehicleSingleViewModel viewModel) {
        _ViewModel = viewModel;

        if (_ViewModel == null) {
            setVehicle(null);
            setTransporterPilots(null);
            setTransporterManufacturers(null);

            return;
        }

        setVehicle(_ViewModel._Vehicle);
        setTransporterPilots(_ViewModel._Pilots);
        setTransporterManufacturers(_ViewModel._Manufacturers);
    }
    public void setVehicle(@Nullable VehicleModel vehicle) {
        if (_ViewModel != null && vehicle != null)
            _ViewModel._Vehicle = vehicle;

        if (vehicle == null) {
            setTransporter(null);

            _VehicleClass.setText("");

            return;
        }

        setTransporter(vehicle);

        String vehicleclass = vehicle._VehicleClass == null ? "" : String.format(
                "%s [%s]",
                vehicle._VehicleClass._Class == null ? "" : vehicle._VehicleClass._Class,
                vehicle._VehicleClass._Flags == null ? "" : StringUtils.join(", ", vehicle._VehicleClass._Flags)
        );

        _VehicleClass.setText(vehicleclass);
    }

    protected @Nullable VehicleSingleViewModel _ViewModel;
    protected AppCompatTextView _VehicleClass;
}