package com.xyclonedesigns.xtarwarx.views.models;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.Nullable;
import androidx.appcompat.widget.AppCompatTextView;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.models.StarshipModel;
import com.xyclonedesigns.xtarwarx.utils.StringUtils;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.StarshipSingleViewModel;
import com.xyclonedesigns.xtarwarx.views.page.ItemsHorizontalPageView;

public class StarshipModelView extends TransporterModelView {
    public static class Ids {
        public static final int Layout = R.layout.xtarwarx_view_model_starship;

        public static final int Name_AppCompatTextView = R.id.xtarwarx_view_model_starship_name_appcompattextview;
        public static final int Model_AppCompatTextView = R.id.xtarwarx_view_model_starship_model_appcompattextview;
        public static final int Description_AppCompatTextView = R.id.xtarwarx_view_model_starship_description_appcompattextview;
        public static final int StarshipClass_AppCompatTextView = R.id.xtarwarx_view_model_starship_starshipclass_appcompattextview;
        public static final int Externallinks_ImagesHorizontalPageView = R.id.xtarwarx_view_model_starship_externallinks_imageshorizontalpageview;
        public static final int Images_ImagesHorizontalPageView = R.id.xtarwarx_view_model_starship_images_imageshorizontalpageview;
        public static final int Details_Barrier_End = R.id.xtarwarx_view_model_starship_details_barrier_end;
        public static final int MaxAtmospheringSpeed_Key_AppCompatTextView = R.id.xtarwarx_view_model_starship_maxatmospheringspeed_key_appcompattextview;
        public static final int MaxAtmospheringSpeed_Value_AppCompatTextView = R.id.xtarwarx_view_model_starship_maxatmospheringspeed_value_appcompattextview;
        public static final int MaxAtmospheringSpeed_Barrier_Bottom = R.id.xtarwarx_view_model_starship_maxatmospheringspeed_barrier_bottom;
        public static final int HyperdriveRating_Key_AppCompatTextView = R.id.xtarwarx_view_model_starship_hyperdriverating_key_appcompattextview;
        public static final int HyperdriveRating_Value_AppCompatTextView = R.id.xtarwarx_view_model_starship_hyperdriverating_value_appcompattextview;
        public static final int HyperdriveRating_Barrier_Bottom = R.id.xtarwarx_view_model_starship_hyperdriverating_barrier_bottom;
        public static final int CostInCredits_Key_AppCompatTextView = R.id.xtarwarx_view_model_starship_costincredits_key_appcompattextview;
        public static final int CostInCredits_Value_AppCompatTextView = R.id.xtarwarx_view_model_starship_costincredits_value_appcompattextview;
        public static final int CostInCredits_Barrier_Bottom = R.id.xtarwarx_view_model_starship_costincredits_barrier_bottom;
        public static final int MGLT_Key_AppCompatTextView = R.id.xtarwarx_view_model_starship_mglt_key_appcompattextview;
        public static final int MGLT_Value_AppCompatTextView = R.id.xtarwarx_view_model_starship_mglt_value_appcompattextview;
        public static final int MGLT_Barrier_Bottom = R.id.xtarwarx_view_model_starship_mglt_barrier_bottom;
        public static final int Length_Key_AppCompatTextView = R.id.xtarwarx_view_model_starship_length_key_appcompattextview;
        public static final int Length_Value_AppCompatTextView = R.id.xtarwarx_view_model_starship_length_value_appcompattextview;
        public static final int Length_Barrier_Bottom = R.id.xtarwarx_view_model_starship_length_barrier_bottom;
        public static final int MinCrew_Key_AppCompatTextView = R.id.xtarwarx_view_model_starship_mincrew_key_appcompattextview;
        public static final int MinCrew_Value_AppCompatTextView = R.id.xtarwarx_view_model_starship_mincrew_value_appcompattextview;
        public static final int MinCrew_Barrier_Bottom = R.id.xtarwarx_view_model_starship_mincrew_barrier_bottom;
        public static final int MaxCrew_Key_AppCompatTextView = R.id.xtarwarx_view_model_starship_maxcrew_key_appcompattextview;
        public static final int MaxCrew_Value_AppCompatTextView = R.id.xtarwarx_view_model_starship_maxcrew_value_appcompattextview;
        public static final int MaxCrew_Barrier_Bottom = R.id.xtarwarx_view_model_starship_maxcrew_barrier_bottom;
        public static final int CargoCapacity_Key_AppCompatTextView = R.id.xtarwarx_view_model_starship_cargocapacity_key_appcompattextview;
        public static final int CargoCapacity_Value_AppCompatTextView = R.id.xtarwarx_view_model_starship_cargocapacity_value_appcompattextview;
        public static final int CargoCapacity_Barrier_Bottom = R.id.xtarwarx_view_model_starship_cargocapacity_barrier_bottom;
        public static final int Passengers_Key_AppCompatTextView = R.id.xtarwarx_view_model_starship_passengers_key_appcompattextview;
        public static final int Passengers_Value_AppCompatTextView = R.id.xtarwarx_view_model_starship_passengers_value_appcompattextview;
        public static final int Passengers_Barrier_Bottom = R.id.xtarwarx_view_model_starship_passengers_barrier_bottom;
        public static final int Consumables_Key_AppCompatTextView = R.id.xtarwarx_view_model_starship_consumables_key_appcompattextview;
        public static final int Consumables_Value_AppCompatTextView = R.id.xtarwarx_view_model_starship_consumables_value_appcompattextview;
        public static final int Consumables_Barrier_Bottom = R.id.xtarwarx_view_model_starship_consumables_barrier_bottom;
        public static final int Manufacturers_ItemsHorizontalPageView = R.id.xtarwarx_view_model_starship_manufacturers_itemshorizontalpageview;
        public static final int Pilots_ItemsHorizontalPageView = R.id.xtarwarx_view_model_starship_pilots_itemshorizontalpageview;
    }

    public StarshipModelView(Context context) {
        super(context);
    }
    public StarshipModelView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public StarshipModelView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public StarshipModelView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        inflate(context, Ids.Layout, this);

        _Name = findViewById(Ids.Name_AppCompatTextView);
        _Model = findViewById(Ids.Model_AppCompatTextView);
        _Description = findViewById(Ids.Description_AppCompatTextView);
        _StarshipClass = findViewById(Ids.StarshipClass_AppCompatTextView);
        _ExternalLinks = findViewById(Ids.Externallinks_ImagesHorizontalPageView);
        _Images = findViewById(Ids.Images_ImagesHorizontalPageView);
        _MaxAtmospheringSpeed = findViewById(Ids.MaxAtmospheringSpeed_Value_AppCompatTextView);
        _HyperdriveRating = findViewById(Ids.HyperdriveRating_Value_AppCompatTextView);
        _CostInCredits = findViewById(Ids.CostInCredits_Value_AppCompatTextView);
        _MGLT = findViewById(Ids.MGLT_Value_AppCompatTextView);
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

    public StarshipSingleViewModel getViewModel() {
        return _ViewModel;
    }
    public void setViewModel(StarshipSingleViewModel viewModel) {
        _ViewModel = viewModel;

        if (_ViewModel == null) {
            setStarship(null);
            setTransporterPilots(null);
            setTransporterManufacturers(null);

            return;
        }

        setStarship(_ViewModel._Starship);
        setTransporterPilots(_ViewModel._Pilots);
        setTransporterManufacturers(_ViewModel._Manufacturers);
    }
    public void setStarship(@Nullable StarshipModel starship) {
        if (_ViewModel != null && starship != null)
            _ViewModel._Starship = starship;

        if (starship == null) {
            setTransporter(null);

            _StarshipClass.setText("");
            _HyperdriveRating.setText("");
            _MGLT.setText("");

            return;
        }

        setTransporter(starship);

        String starshipclass = starship._StarshipClass == null ? "" : String.format(
                "%s [%s]",
                starship._StarshipClass._Class == null ? "" : starship._StarshipClass._Class,
                starship._StarshipClass._Flags == null ? "" : StringUtils.join(", ", starship._StarshipClass._Flags)
        );
        String hyperdriverating = String.valueOf(starship._HyperdriveRating);
        String mglt = String.valueOf(starship._MGLT);

        _StarshipClass.setText(starshipclass);
        _HyperdriveRating.setText(hyperdriverating);
        _MGLT.setText(mglt);
    }

    protected @Nullable StarshipSingleViewModel _ViewModel;
    protected AppCompatTextView _StarshipClass;
    protected AppCompatTextView _HyperdriveRating;
    protected AppCompatTextView _MGLT;
}