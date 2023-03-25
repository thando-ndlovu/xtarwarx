package com.xyclonedesigns.xtarwarx.widgets.recyclerview;

import android.content.Context;
import android.util.AttributeSet;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuItem;
import android.view.ViewGroup;

import androidx.annotation.MenuRes;
import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.widget.AppCompatButton;
import androidx.appcompat.widget.PopupMenu;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.xyclonedesigns.xtarwarx.R;

public class HorizontalRecyclerView extends RecyclerView {
    public HorizontalRecyclerView(@NonNull Context context) {
        this(context, null);
    }
    public HorizontalRecyclerView(@NonNull Context context, @Nullable AttributeSet attrs) {
        this(context, attrs, R.style.XtarWarx_Widget_RecyclerView_Horizontal);
    }
    public HorizontalRecyclerView(@NonNull Context context, @Nullable AttributeSet attrs, int defStyleAttr) {
        super(context, attrs, defStyleAttr);

        setLayoutManager(new HorizontalLayoutManager(context));
        addItemDecoration(MarginItemDecoration.create(
                R.dimen.dp0,
                R.dimen.dp8,
                R.dimen.dp8,
                R.dimen.dp0
        ));
    }

    public static class HorizontalLayoutManager extends LinearLayoutManager {
        public HorizontalLayoutManager(Context context) {
            this(context, HORIZONTAL, false);
        }
        public HorizontalLayoutManager(Context context, int orientation, boolean reverseLayout) {
            super(context, orientation, reverseLayout);
        }
        public HorizontalLayoutManager(Context context, AttributeSet attrs, int defStyleAttr, int defStyleRes) {
            super(context, attrs, defStyleAttr, defStyleRes);
        }
    }
}