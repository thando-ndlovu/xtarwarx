package com.xyclonedesigns.xtarwarx.views.models;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.Nullable;
import androidx.appcompat.widget.AppCompatTextView;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.models.WeaponModel;
import com.xyclonedesigns.xtarwarx.utils.StringUtils;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.ManufacturerMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.WeaponSingleViewModel;
import com.xyclonedesigns.xtarwarx.views.page.ImagesHorizontalPageView;
import com.xyclonedesigns.xtarwarx.views.page.ItemsHorizontalPageView;

public class WeaponModelView extends BaseModelView {
    public static class Ids {
        public static final int Layout = R .layout.xtarwarx_view_model_weapon;

        public static final int Name_AppCompatTextView = R.id.xtarwarx_view_model_weapon_name_appcompattextview;
        public static final int Model_AppCompatTextView = R.id.xtarwarx_view_model_weapon_model_appcompattextview;
        public static final int Description_AppCompatTextView = R.id.xtarwarx_view_model_weapon_description_appcompattextview;
        public static final int WeaponClass_AppCompatTextView = R.id.xtarwarx_view_model_weapon_weaponclass_appcompattextview;
        public static final int ExternalLinks_ImagesHorizontalPageView = R.id.xtarwarx_view_model_weapon_externallinks_imageshorizontalpageview;
        public static final int Images_ImagesHorizontalPageView = R.id.xtarwarx_view_model_weapon_images_imageshorizontalpageview;
        public static final int Manufacturers_ItemsHorizontalPageView = R.id.xtarwarx_view_model_weapon_manufacturers_itemshorizontalpageview;
    }

    public WeaponModelView(Context context) {
        super(context);
    }
    public WeaponModelView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public WeaponModelView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public WeaponModelView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        inflate(context, Ids.Layout, this);

        _Name = findViewById(Ids.Name_AppCompatTextView);
        _Model = findViewById(Ids.Model_AppCompatTextView);
        _Description = findViewById(Ids.Description_AppCompatTextView);
        _WeaponClass = findViewById(Ids.WeaponClass_AppCompatTextView);
        _ExternalLinks = findViewById(Ids.ExternalLinks_ImagesHorizontalPageView);
        _Images = findViewById(Ids.Images_ImagesHorizontalPageView);
        _Manufacturers = findViewById(Ids.Manufacturers_ItemsHorizontalPageView);

        super.init(context, attr);

        _Manufacturers._Items.setItemsAdapter(ItemsHorizontalPageView.ItemsAdapter.createManufacturersAdapter());
    }

    public @Nullable WeaponSingleViewModel getViewModel() {
        return _ViewModel;
    }
    public void setViewModel(@Nullable WeaponSingleViewModel viewModel) {
        _ViewModel = viewModel;

        if (_ViewModel == null) {
            setWeapon(null);
            setWeaponManufacturers(null);
        }

        setWeapon(_ViewModel._Weapon);
        setWeaponManufacturers(_ViewModel._Manufacturers);
    }
    public void setWeapon(@Nullable WeaponModel weapon) {
        if (_ViewModel != null && weapon != null)
            _ViewModel._Weapon = weapon;

        if (weapon == null) {
            _Name.setText("");
            _Model.setText("");
            _Description.setText("");
            _WeaponClass.setText("");

            _Images.setImages(null);
            _ExternalLinks.setExternalLinks(null);

            setManufacturers(null, _Manufacturers);

            return;
        }

        String name = weapon._Name == null ? "" : weapon._Name;
        String model = weapon._Description == null ? "" : weapon._Description;
        String description = weapon._Description == null ? "" : weapon._Description;
        String weaponclass = weapon._WeaponClass == null ? "" : String.format(
                "%s [%s]",
                weapon._WeaponClass._Class == null ? "" : weapon._WeaponClass._Class,
                weapon._WeaponClass._Flags == null ? "" : StringUtils.join(", ", weapon._WeaponClass._Flags)
        );
        _Name.setText(name);
        _Model.setText(model);
        _Description.setText(description);
        _WeaponClass.setText(weaponclass);

        _Images.setImages(weapon._Uris);
        _ExternalLinks.setExternalLinks(weapon._Uris);
    }
    public void setWeaponManufacturers(@Nullable ManufacturerMultipleViewModel manufacturers) {
        setManufacturers(_ViewModel == null
                ? manufacturers
                : (_ViewModel._Manufacturers = manufacturers), _Manufacturers
        );
    }

    protected @Nullable WeaponSingleViewModel _ViewModel;

    protected AppCompatTextView _Name;
    protected AppCompatTextView _Model;
    protected AppCompatTextView _Description;
    protected AppCompatTextView _WeaponClass;
    protected ImagesHorizontalPageView _Images;
    protected ItemsHorizontalPageView _Manufacturers;
}