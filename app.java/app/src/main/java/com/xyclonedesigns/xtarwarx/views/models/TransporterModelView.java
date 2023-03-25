package com.xyclonedesigns.xtarwarx.views.models;

import android.content.Context;
import android.net.Uri;
import android.util.AttributeSet;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.widget.AppCompatTextView;

import com.bumptech.glide.Glide;
import com.bumptech.glide.load.resource.bitmap.DownsampleStrategy;
import com.bumptech.glide.request.RequestOptions;
import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.models.TransporterModel;
import com.xyclonedesigns.xtarwarx.repository.models.StarWarsModelURI;
import com.xyclonedesigns.xtarwarx.repository.models.TransporterModel;
import com.xyclonedesigns.xtarwarx.utils.ArrayUtils;
import com.xyclonedesigns.xtarwarx.utils.StringUtils;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.CharacterMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.FactionMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.ManufacturerMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.PlanetMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.SpecieMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.StarshipMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.VehicleMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.WeaponMultipleViewModel;
import com.xyclonedesigns.xtarwarx.views.page.ItemsHorizontalPageView;

public class TransporterModelView extends BaseModelView {
    public TransporterModelView(Context context) {
        super(context);
    }
    public TransporterModelView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public TransporterModelView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public TransporterModelView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    protected AppCompatTextView _Name;
    protected AppCompatTextView _Model;
    protected AppCompatTextView _Description;
    protected AppCompatTextView _MaxAtmospheringSpeed;
    protected AppCompatTextView _CostInCredits;
    protected AppCompatTextView _Length;
    protected AppCompatTextView _MinCrew;
    protected AppCompatTextView _MaxCrew;
    protected AppCompatTextView _CargoCapacity;
    protected AppCompatTextView _Passengers;
    protected AppCompatTextView _Consumables;
    protected ItemsHorizontalPageView _Manufacturers;
    protected ItemsHorizontalPageView _Pilots;

    public void setTransporter(@Nullable TransporterModel transporter) {
        if (transporter == null) {
            _Name.setText("");
            _Model.setText("");
            _Description.setText("");
            _MaxAtmospheringSpeed.setText("");
            _CostInCredits.setText("");
            _Length.setText("");
            _MinCrew.setText("");
            _MaxCrew.setText("");
            _CargoCapacity.setText("");
            _Passengers.setText("");
            _Consumables.setText("");

            _Images.setImages(null);
            _ExternalLinks.setExternalLinks(null);

            return;
        }

        String name = transporter._Name == null ? "" : transporter._Name;
        String model = transporter._Model == null ? "" : transporter._Model;
        String description = transporter._Description == null ? "" : transporter._Description;
        String maxatmospheringspeed = String.valueOf(transporter._MaxAtmospheringSpeed);
        String costincredits = String.valueOf(transporter._CostInCredits);
        String length = String.valueOf(transporter._Length);
        String mincrew = String.valueOf(transporter._MinCrew);
        String maxcrew = String.valueOf(transporter._MaxCrew);
        String cargocapacity = String.valueOf(transporter._CargoCapacity);
        String passengers = String.valueOf(transporter._Passengers);
        String consumables = transporter._Consumables == null ? "" : String.format(
                "%s %s",
                transporter._Consumables._Value,
                transporter._Consumables._TimeUnit
        );

        _Name.setText(name);
        _Model.setText(model);
        _Description.setText(description);
        _MaxAtmospheringSpeed.setText(maxatmospheringspeed);
        _CostInCredits.setText(costincredits);
        _Length.setText(length);
        _MinCrew.setText(mincrew);
        _MaxCrew.setText(maxcrew);
        _CargoCapacity.setText(cargocapacity);
        _Passengers.setText(passengers);
        _Consumables.setText(consumables);

        _Images.setImages(transporter._Uris);
        _ExternalLinks.setExternalLinks(transporter._Uris);
    }
    public void setTransporterPilots(@Nullable CharacterMultipleViewModel pilots) {
        setCharacters(pilots, _Pilots);
    }
    public void setTransporterManufacturers(@Nullable ManufacturerMultipleViewModel manufacturers) {
        setManufacturers(manufacturers, _Manufacturers);
    }
}