package com.xyclonedesigns.xtarwarx.widgets.recyclerview;

import android.content.res.Configuration;
import android.graphics.Canvas;
import android.graphics.Rect;
import android.view.View;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.recyclerview.widget.GridLayoutManager;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

public class StickyFooterItemDecoration extends RecyclerView.ItemDecoration {
    @Override
    public void onDrawOver(Canvas c, RecyclerView parent, RecyclerView.State state) {
        int childCount = parent.getAdapter().getItemCount();
        int lastVisibleItemPosition =
                ((LinearLayoutManager) parent.getLayoutManager()).findLastVisibleItemPosition();
        int firstVisiblePosition =
                ((LinearLayoutManager) parent.getLayoutManager())
                        .findFirstCompletelyVisibleItemPosition();
        if ((firstVisiblePosition == 0) && (lastVisibleItemPosition == (childCount - 1))) {
            View summaryView = parent.getChildAt(parent.getChildCount() - 1);
            int topOffset = parent.getHeight() - summaryView.getHeight();
            int leftOffset =
                    ((RecyclerView.LayoutParams) summaryView.getLayoutParams()).leftMargin;
            c.save();
            c.translate(leftOffset, topOffset);
            summaryView.draw(c);
            c.restore();
            summaryView.setVisibility(View.GONE);
        }
    }

}