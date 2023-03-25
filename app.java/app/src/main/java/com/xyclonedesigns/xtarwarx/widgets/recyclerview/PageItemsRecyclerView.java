package com.xyclonedesigns.xtarwarx.widgets.recyclerview;

import android.content.Context;
import android.content.res.Configuration;
import android.graphics.Rect;
import android.util.AttributeSet;
import android.view.View;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.recyclerview.widget.GridLayoutManager;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.models.StarWarsModel;
import com.xyclonedesigns.xtarwarx.views.page.PageItemView;

import java.util.ArrayList;
import java.util.List;

public class PageItemsRecyclerView extends RecyclerView {
    public PageItemsRecyclerView(@NonNull Context context) {
        this(context, null);
    }
    public PageItemsRecyclerView(@NonNull Context context, @Nullable AttributeSet attrs) {
        this(context, attrs, R.style.XtarWarx_Widget_RecyclerView_PageItems);
    }
    public PageItemsRecyclerView(@NonNull Context context, @Nullable AttributeSet attrs, int defStyleAttr) {
        super(context, attrs, defStyleAttr);

        addItemDecoration(_MarginItemDecoration = MarginItemDecoration.create(R.dimen.dp16, R.dimen.dp16, R.dimen.dp16, R.dimen.dp16));
        addItemDecoration(new StickyFooterItemDecoration());
    }

    public final MarginItemDecoration _MarginItemDecoration;

    private ItemsAdapter _ItemsAdapter;
    public ItemsAdapter getItemsAdapter() {
        return (ItemsAdapter) getAdapter();
    }
    public void setItemsAdapter(ItemsAdapter itemsAdapter) {
        setAdapter(itemsAdapter);
    }

    public static abstract class ItemsAdapter<T extends StarWarsModel>
            extends RecyclerView.Adapter<ItemsViewHolder> {
        public static final int ItemViewType_Normal = 0;
        public static final int ItemViewType_Header = 1;
        public static final int ItemViewType_Footer = 2;

        public ItemsAdapter() { }
        public ItemsAdapter(@NonNull ArrayList<T> items) {
            _Items = items;
        }
        public ItemsAdapter(@Nullable ArrayList<T> items, @Nullable View headerView, @Nullable View footerView) {
            if (items != null)
                _Items = items;

            _HeaderView = headerView;
            _FooterView = footerView;
        }

        @NonNull
        @Override
        public abstract ItemsViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType);
        @Override
        public abstract void onBindViewHolder(@NonNull ItemsViewHolder holder, int position);

        @Override
        public int getItemCount() {
            int itemcount = _Items.size();

            if (itemcount == 0)
                return itemcount;

            if (_HeaderView != null)
                itemcount += 1;

            if (_FooterView != null)
                itemcount += 1;

            return itemcount;
        }
        @Override
        public int getItemViewType(int position) {
            int itemcount = getItemCount();

            if (itemcount == 0)
                return ItemViewType_Normal;

            if (_HeaderView != null && position == 0)
                return ItemViewType_Header;

            if (_FooterView != null && position == itemcount - 1)
                return ItemViewType_Footer;

            return super.getItemViewType(position);
        }
        public int getBindViewHolderPosition(int position) {
            boolean no =
                    (_HeaderView != null && position == 0) ||
                    (_FooterView != null && position == getItemCount() - 1);

            if (no) return -1;
            if (_HeaderView != null) return position - 1;
            return position;
        }

        public @Nullable View _HeaderView;
        public @Nullable View _FooterView;
        public @NonNull List<T> _Items = new ArrayList<>();
    }
    public static class ItemsViewHolder<T extends StarWarsModel> extends RecyclerView.ViewHolder {
        public ItemsViewHolder(@NonNull View itemView) {
            super(itemView);
        }
        public ItemsViewHolder(@NonNull PageItemView itemView) {
            super(itemView);

            _PageItemView = itemView;
            _PageItemView.setOnClickListener(this::onClick);
            _PageItemView.setOnLongClickListener(this::onLongClick);
        }

        public @Nullable T _ViewModel;
        public @Nullable PageItemView _PageItemView;

        private void onClick(View view) {
            if (_OnClickListener != null)
                _OnClickListener.onClick(this);
        }
        private boolean onLongClick(View view) {
            if (_OnLongClickListener != null)
                _OnLongClickListener.onLongClick(this);

            if (_PageItemView != null)
                _PageItemView._Menu.setVisibility(
                        _PageItemView._Menu.getVisibility() == GONE
                            ? VISIBLE
                            : GONE
                );

            return true;
        }

        private @Nullable OnClickListener<T> _OnClickListener;
        private @Nullable OnLongClickListener<T> _OnLongClickListener;

        public void setOnClickListener(@Nullable OnClickListener<T> listener) {
            _OnClickListener = listener;
        }
        public void setOnLongClickListener(@Nullable OnLongClickListener<T> listener) {
            _OnLongClickListener = listener;
        }

        public interface OnClickListener<T extends StarWarsModel> {
            void onClick(ItemsViewHolder<T> viewHolder);
        }
        public interface OnLongClickListener<T extends StarWarsModel> {
            boolean onLongClick(ItemsViewHolder<T> viewHolder);
        }
    }
}