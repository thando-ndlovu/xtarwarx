package com.xyclonedesigns.xtarwarx.views.page;

import android.content.Context;
import android.util.AttributeSet;

import androidx.constraintlayout.widget.ConstraintLayout;

import com.xyclonedesigns.xtarwarx.R;

public class PageItemHorizontalView extends PageItemView {
    public static class Ids {
        public static final int Layout = R.layout.xtarwarx_view_page_item_horizontal;

        public static final int Title_AppCompatTextView = R.id.xtarwarx_view_page_item_horizontal_title_appcompattextview;
        public static final int Subtitle_AppCompatTextView = R.id.xtarwarx_view_page_item_horizontal_subtitle_appcompattextview;
        public static final int Image_AppCompatImageView = R.id.xtarwarx_view_page_item_horizontal_image_appcompatimageview;
        public static final int ImageDefault_AppCompatImageView = R.id.xtarwarx_view_page_item_horizontal_imagedefault_appcompatimageview;
        public static final int Menu_MenuItemsRecyclerView = R.id.xtarwarx_view_page_item_horizontal_menu_menuitemsrecyclerview;
    }

    public PageItemHorizontalView(Context context) {
        super(context);
    }
    public PageItemHorizontalView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public PageItemHorizontalView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        inflate(context, Ids.Layout, this);
        super.init(context, attr);

        _Title = findViewById(Ids.Title_AppCompatTextView);
        _Subtitle = findViewById(Ids.Subtitle_AppCompatTextView);
        _Image = findViewById(Ids.Image_AppCompatImageView);
        _ImageDefault = findViewById(Ids.ImageDefault_AppCompatImageView);
        _Menu = findViewById(Ids.Menu_MenuItemsRecyclerView);
    }
}