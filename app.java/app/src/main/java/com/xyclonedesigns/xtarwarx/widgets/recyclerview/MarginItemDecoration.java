package com.xyclonedesigns.xtarwarx.widgets.recyclerview;

import android.content.res.Configuration;
import android.graphics.Rect;
import android.view.View;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.recyclerview.widget.GridLayoutManager;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

public class MarginItemDecoration extends RecyclerView.ItemDecoration {
    public static MarginItemDecoration create(@Nullable Integer marginResTop, @Nullable Integer marginResLeft, @Nullable Integer marginResRight, @Nullable Integer marginResBottom) {
        MarginItemDecoration marginitemdecoration = new MarginItemDecoration();

        if (marginResTop != null) marginitemdecoration._MarginResTop = marginResTop;
        if (marginResLeft != null) marginitemdecoration._MarginResLeft = marginResLeft;
        if (marginResRight != null) marginitemdecoration._MarginResRight = marginResRight;
        if (marginResBottom != null) marginitemdecoration._MarginResBottom = marginResBottom;

        return marginitemdecoration;
    }

    public View _HeaderView;
    public View _FooterView;

    public void setMargin(int margin) {
        setMarginHorizontal(margin);
        setMarginVertical(margin);
    }
    public void setMarginHorizontal(int margin) {
        _MarginLeft = _MarginRight = margin;
    }
    public void setMarginVertical(int margin) {
        _MarginTop = _MarginBottom = margin;
    }

    public int _MarginTop;
    public int _MarginLeft;
    public int _MarginRight;
    public int _MarginBottom;

    public int _MarginResTop = -1;
    public int _MarginResLeft = -1;
    public int _MarginResRight = -1;
    public int _MarginResBottom = -1;

    public ApplyInsetsInvoker _ApplyInsetsInvoker = new ApplyInsetsInvoker();

    @Override
    public void getItemOffsets(@NonNull Rect outRect, @NonNull View view, @NonNull RecyclerView parent, @NonNull RecyclerView.State state) {
        super.getItemOffsets(outRect, view, parent, state);

        RecyclerView.Adapter<?> adapter = parent.getAdapter();
        RecyclerView.LayoutManager layoutmanager = parent.getLayoutManager();

        LinearLayoutManager linearlayoutmanager = null;
        GridLayoutManager gridlayoutmanager = null;

        if (layoutmanager instanceof GridLayoutManager)
            gridlayoutmanager = ((GridLayoutManager) layoutmanager);

        if (layoutmanager instanceof LinearLayoutManager)
            linearlayoutmanager = ((LinearLayoutManager) layoutmanager);

        int orientation = RecyclerView.VERTICAL, spancount = 1;

        if (view.getVisibility() == View.GONE || adapter == null)
            return;
        else if (gridlayoutmanager != null) {
            orientation = gridlayoutmanager.getOrientation();
            spancount = gridlayoutmanager.getSpanCount();
        }
        else if (linearlayoutmanager != null) {
            orientation = linearlayoutmanager.getOrientation();
            spancount = 1;
        }

        boolean
                row_top = false,
                row_bottom = false,
                column_first = false,
                column_last = false,
                isRtL = parent.getResources().getConfiguration().getLayoutDirection() == Configuration.SCREENLAYOUT_LAYOUTDIR_RTL;

        int position = parent.getChildAdapterPosition(view) + 1;

        switch (orientation)
        {
            case LinearLayoutManager.VERTICAL:
                row_top = position <= spancount;
                row_bottom = position >= adapter.getItemCount() - spancount;
                column_first = position % spancount == 1;
                column_last = position % spancount == 0;
                break;

            case LinearLayoutManager.HORIZONTAL:
                row_top = position % spancount != 0;
                row_bottom = position % spancount == 0;
                column_first = position <= spancount;
                column_last = position >= adapter.getItemCount() - spancount;
                break;

            default: break;
        }

        if (_MarginTop == 0 && _MarginResTop != -1) _MarginTop = view.getResources().getDimensionPixelSize(_MarginResTop);
        if (_MarginLeft == 0 && _MarginResLeft != -1) _MarginLeft = view.getResources().getDimensionPixelSize(_MarginResLeft);
        if (_MarginRight == 0 && _MarginResRight != -1) _MarginRight= view.getResources().getDimensionPixelSize(_MarginResRight);
        if (_MarginBottom == 0 && _MarginResBottom != -1) _MarginBottom = view.getResources().getDimensionPixelSize(_MarginResBottom);

        boolean isnotheader = (_HeaderView == null || _HeaderView != view);
        boolean isnotfooter = (_FooterView == null || _FooterView != view);

        if (_ApplyInsetsInvoker.ApplyTopInset(this) && isnotheader)
            outRect.top = row_top ? _MarginTop : _MarginTop / 2;

        if (_ApplyInsetsInvoker.ApplyLeftInset(this) && isnotheader && isnotfooter)
            outRect.left = spancount == 1 ? _MarginLeft : (column_first && !isRtL) ? _MarginLeft : _MarginLeft / 2;

        if (_ApplyInsetsInvoker.ApplyRightInset(this) && isnotheader && isnotfooter)
            outRect.right = spancount == 1 ? _MarginRight : (column_last && !isRtL) ? _MarginRight : _MarginRight / 2;

        if (_ApplyInsetsInvoker.ApplyBottomInset(this) && isnotfooter)
            outRect.bottom = row_bottom ? _MarginBottom : _MarginBottom / 2;
    }

    public static class ApplyInsetsInvoker {
        public boolean ApplyBottomInset(MarginItemDecoration marginitemdecoration) {
            return true;
        }
        public boolean ApplyLeftInset(MarginItemDecoration marginitemdecoration) {
            return true;
        }
        public boolean ApplyRightInset(MarginItemDecoration marginitemdecoration) {
            return true;
        }
        public boolean ApplyTopInset(MarginItemDecoration marginitemdecoration) {
            return true;
        }
    }
}