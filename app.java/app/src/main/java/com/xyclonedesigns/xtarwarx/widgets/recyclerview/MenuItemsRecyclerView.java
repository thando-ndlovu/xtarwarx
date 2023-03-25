package com.xyclonedesigns.xtarwarx.widgets.recyclerview;

import android.content.Context;
import android.content.res.Configuration;
import android.graphics.Rect;
import android.util.AttributeSet;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.view.ViewGroup;

import androidx.annotation.MenuRes;
import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.view.menu.MenuBuilder;
import androidx.appcompat.widget.AppCompatButton;
import androidx.appcompat.widget.PopupMenu;
import androidx.core.view.MenuCompat;
import androidx.core.widget.PopupMenuCompat;
import androidx.recyclerview.widget.GridLayoutManager;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.models.StarWarsModel;
import com.xyclonedesigns.xtarwarx.views.page.PageItemView;

import java.util.ArrayList;
import java.util.List;

public class MenuItemsRecyclerView extends HorizontalRecyclerView {
    public MenuItemsRecyclerView(@NonNull Context context) {
        this(context, null);
    }
    public MenuItemsRecyclerView(@NonNull Context context, @Nullable AttributeSet attrs) {
        this(context, attrs, R.style.XtarWarx_Widget_RecyclerView_MenuItems);
    }
    public MenuItemsRecyclerView(@NonNull Context context, @Nullable AttributeSet attrs, int defStyleAttr) {
        super(context, attrs, defStyleAttr);

        setAdapter(new MenuAdapter(this));
        setLayoutManager(new MenuLayoutManager(context));
        removeItemDecorationAt(0);
        addItemDecoration(_MarginItemDecoration = MarginItemDecoration.create(
                R.dimen.dp0,
                R.dimen.dp4,
                R.dimen.dp4,
                R.dimen.dp0
        ));
    }

    public final MarginItemDecoration _MarginItemDecoration;

    private MenuAdapter _MenuAdapter;
    public MenuAdapter getMenuAdapter() {
        return (MenuAdapter) getAdapter();
    }
    public void setMenuAdapter(MenuAdapter menuAdapter) {
        setAdapter(menuAdapter);
    }

    private MenuLayoutManager _MenuLayoutManager;
    public MenuLayoutManager getMenuLayoutManager() {
        return (MenuLayoutManager) getLayoutManager();
    }
    public void setMenuLayoutManager(MenuLayoutManager menuLayoutManager) {
        setLayoutManager(menuLayoutManager);
    }

    public static class MenuAdapter extends RecyclerView.Adapter<MenuViewHolder> {
        public MenuAdapter(RecyclerView parent) {
            _Parent = parent;
        }
        public void setMenu(@MenuRes int menuid) {
            PopupMenu popupmenu = new PopupMenu(_Parent.getContext(), _Parent);
            popupmenu.inflate(menuid);
            _Menu = popupmenu.getMenu();
        }
        public void setMenu(@NonNull Menu menu) {
            _Menu = menu;
            notifyDataSetChanged();
        }

        RecyclerView _Parent;
        Menu _Menu;
        MenuItem.OnMenuItemClickListener _OnMenuItemClickListener;

        @NonNull
        @Override
        public MenuViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {;
            return new MenuViewHolder(
                    (AppCompatButton) LayoutInflater
                            .from(parent.getContext())
                            .inflate(R.layout.xtarwarx_view_page_item_menuitem, parent, false)
            );
        }
        @Override
        public void onBindViewHolder(@NonNull MenuViewHolder holder, int position) {
            holder._MenuItem = _Menu.getItem(position);
            holder._ItemView.setText(holder._MenuItem.getTitle());
            holder._ItemView.setCompoundDrawablesRelativeWithIntrinsicBounds(holder._MenuItem.getIcon(), null, null, null);
            holder._ItemView.setOnClickListener(view -> _Menu.performIdentifierAction(holder._MenuItem.getItemId(), 0));
        }
        @Override
        public int getItemCount() {
            return _Menu == null ? 0 : _Menu.size();
        }
    }
    public static class MenuLayoutManager extends HorizontalLayoutManager {
        public MenuLayoutManager(Context context) {
            this(context, HORIZONTAL, false);
        }
        public MenuLayoutManager(Context context, int orientation, boolean reverseLayout) {
            super(context, orientation, reverseLayout);
        }
        public MenuLayoutManager(Context context, AttributeSet attrs, int defStyleAttr, int defStyleRes) {
            super(context, attrs, defStyleAttr, defStyleRes);
        }
    }
    public static class MenuViewHolder extends RecyclerView.ViewHolder {
        public MenuViewHolder(@NonNull AppCompatButton itemView) {
            super(itemView);
            _ItemView = itemView;
        }

        public @Nullable MenuItem _MenuItem;
        public @NonNull AppCompatButton _ItemView;
    }
}