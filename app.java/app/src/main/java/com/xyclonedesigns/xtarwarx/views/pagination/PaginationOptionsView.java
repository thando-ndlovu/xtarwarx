package com.xyclonedesigns.xtarwarx.views.pagination;

import android.app.AlertDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.text.Html;
import android.text.Spanned;
import android.util.AttributeSet;
import android.view.ContextThemeWrapper;
import android.view.View;
import android.widget.CompoundButton;

import androidx.appcompat.widget.AppCompatButton;
import androidx.appcompat.widget.AppCompatCheckBox;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.viewmodels.pagination.PaginationViewModel;

import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;

public class PaginationOptionsView extends BasePaginationView implements View.OnClickListener, CompoundButton.OnCheckedChangeListener {
    public static class Ids {
        public static final int Layout = R.layout.xtarwarx_view_pagination_options;

        public static final int Reverse_AppCompatCheckBox = R.id.xtarwarx_view_pagination_options_reverse_appcompatcheckbox;
        public static final int SortBy_AppCompatButton = R.id.xtarwarx_view_pagination_options_sortby_appcompatbutton;
        public static final int ItemsPerPage_AppCompatButton = R.id.xtarwarx_view_pagination_options_itemsperpage_appcompatbutton;
    }

    public PaginationOptionsView(Context context) {
        super(context);
    }
    public PaginationOptionsView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public PaginationOptionsView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        inflate(context, Ids.Layout, this);
        super.init(context, attr);

        _Reverse = findViewById(Ids.Reverse_AppCompatCheckBox);
        _SortBy = findViewById(Ids.SortBy_AppCompatButton);
        _ItemsPerPage = findViewById(Ids.ItemsPerPage_AppCompatButton);
    }

    AppCompatCheckBox _Reverse;
    AppCompatButton _SortBy;
    AppCompatButton _ItemsPerPage;

    @Override
    protected void onAttachedToWindow() {
        super.onAttachedToWindow();

        _Reverse.setOnCheckedChangeListener(this);
        _SortBy.setOnClickListener(this);
        _ItemsPerPage.setOnClickListener(this);
    }
    @Override
    protected void onDetachedFromWindow() {
        super.onDetachedFromWindow();

        _Reverse.setOnCheckedChangeListener(null);
        _SortBy.setOnClickListener(null);
        _ItemsPerPage.setOnClickListener(null);
    }

    @Override
    public void onClick(View view) {
        if (_ViewModel == null)
            return;

        if (view == _SortBy && _ViewModel._SortKeys != null)
            new AlertDialog.Builder(new ContextThemeWrapper(getContext(), R.style.XtarWarx_AlertDialog))
                    .setTitle(R.string.sortby)
                    .setItems(_ViewModel._SortKeysTitles, new DialogInterface.OnClickListener() {
                        @Override
                        public void onClick(DialogInterface dialogInterface, int i) {
                            _ViewModel._SortKey = _ViewModel._SortKeys[i];
                            _ViewModel.dataRequest();
                        }

                    }).create().show();
        else if (view == _ItemsPerPage && _ViewModel._ItemsPerPages != null) {
            ArrayList<String> itemsperpages = new ArrayList<>();

            for (int itemperpage : _ViewModel._ItemsPerPages)
                itemsperpages.add(String.valueOf(itemperpage));

            new AlertDialog.Builder(new ContextThemeWrapper(getContext(), R.style.XtarWarx_AlertDialog))
                    .setTitle(R.string.itemsperpage)
                    .setItems(itemsperpages.toArray(new CharSequence[] { }), new DialogInterface.OnClickListener() {
                        @Override
                        public void onClick(DialogInterface dialogInterface, int i) {
                            _ViewModel._ItemsPerPage = _ViewModel._ItemsPerPages[i];
                            _ViewModel.dataRequest();
                        }

                    }).create().show();
        }

    }
    @Override
    public void onCheckedChanged(CompoundButton compoundButton, boolean b) {
        if (_ViewModel == null)
            return;

        _ViewModel._Reverse = _Reverse.isChecked();
        _ViewModel.dataRequest();
    }
    @Override
    public PaginationViewModel getViewModel() {
        return super.getViewModel();
    }
    @Override
    public void setViewModel(PaginationViewModel viewModel) {
        super.setViewModel(viewModel);

        if (_ViewModel == null)
            return;

        _Reverse.setChecked(_ViewModel._Reverse);
        _SortBy.setText(getColorString(getResources().getString(R.string.sortby), _ViewModel._SortKey));
        _ItemsPerPage.setText(getColorString(getResources().getString(R.string.itemsperpage), _ViewModel._ItemsPerPage));
    }

    private Spanned getColorString(Object key, Object value) {
        return Html.fromHtml(
                String.format(
                        "%s: <font color='%s'>%s</font>",
                        key,
                        getResources().getColor(R.color.ColorPrimary, getContext().getTheme()),
                        value
                ),
                Html.FROM_HTML_OPTION_USE_CSS_COLORS
        );
    }
}