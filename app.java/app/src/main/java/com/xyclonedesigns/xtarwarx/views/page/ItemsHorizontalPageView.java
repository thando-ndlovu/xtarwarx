package com.xyclonedesigns.xtarwarx.views.page;

import android.content.Context;
import android.content.res.TypedArray;
import android.util.AttributeSet;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.models.CharacterModel;
import com.xyclonedesigns.xtarwarx.repository.models.FactionModel;
import com.xyclonedesigns.xtarwarx.repository.models.ManufacturerModel;
import com.xyclonedesigns.xtarwarx.repository.models.PlanetModel;
import com.xyclonedesigns.xtarwarx.repository.models.SpecieModel;
import com.xyclonedesigns.xtarwarx.repository.models.StarWarsModel;
import com.xyclonedesigns.xtarwarx.repository.models.StarshipModel;
import com.xyclonedesigns.xtarwarx.repository.models.VehicleModel;
import com.xyclonedesigns.xtarwarx.repository.models.WeaponModel;
import com.xyclonedesigns.xtarwarx.widgets.recyclerview.PageItemsRecyclerView;

import java.util.ArrayList;

public class ItemsHorizontalPageView extends ItemsPageView {
    public static class Ids {
        public static final int Layout = R.layout.xtarwarx_view_page_itemshorizontal;

        public static final int Title_AppCompatTextView = R.id.xtarwarx_view_page_itemshorizontal_title_appcompattextview;
        public static final int Subtitle_AppCompatTextView = R.id.xtarwarx_view_page_itemshorizontal_subtitle_appcompattextview;
        public static final int Empty_AppCompatTextView = R.id.xtarwarx_view_page_itemshorizontal_empty_appcompattextview;
        public static final int PaginationOptions_AppCompatImageButton = R.id.xtarwarx_view_page_itemshorizontal_paginationoptions_appcompatimagebutton;
        public static final int Refresh_AppCompatImageButton = R.id.xtarwarx_view_page_itemshorizontal_refresh_appcompatimagebutton;
        public static final int PaginationOptions_PaginationOptionsView = R.id.xtarwarx_view_page_itemshorizontal_paginationoptions_paginationoptionsview;
        public static final int Items_PageItemsRecyclerView = R.id.xtarwarx_view_page_itemshorizontal_items_pageitemsrecyclerview;
        public static final int PaginationPages_PaginationPagesView = R.id.xtarwarx_view_page_itemshorizontal_paginationpages_paginationpagesview;
    }

    public ItemsHorizontalPageView(Context context) {
        super(context);
    }
    public ItemsHorizontalPageView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public ItemsHorizontalPageView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public ItemsHorizontalPageView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        inflate(context, Ids.Layout, this);

        _Title = findViewById(Ids.Title_AppCompatTextView);
        _Subtitle = findViewById(Ids.Subtitle_AppCompatTextView);
        _Empty = findViewById(Ids.Empty_AppCompatTextView);
        _PaginationOptionsButton = findViewById(Ids.PaginationOptions_AppCompatImageButton);
        _RefreshButton = findViewById(Ids.Refresh_AppCompatImageButton);
        _PaginationOptions = findViewById(Ids.PaginationOptions_PaginationOptionsView);
        _Items = findViewById(Ids.Items_PageItemsRecyclerView);
        _PaginationPages = findViewById(Ids.PaginationPages_PaginationPagesView);

        super.init(context, attr);

        TypedArray a = getContext().obtainStyledAttributes(attr, Attrs.Attr);

        _RefreshButton.setVisibility(
                a.getBoolean(Attrs.WithRefresh, true)
                    ? VISIBLE
                    : GONE
        );

        a.recycle();

        _Items.setLayoutManager(new ItemsLayoutManager(getContext()));
    }

    public abstract static class ItemsAdapter<T extends StarWarsModel> extends PageItemsRecyclerView.ItemsAdapter<T> {
        public ItemsAdapter() {
            super();
        }
        public ItemsAdapter(ArrayList<T> items) {
            super(items);
        }

        @NonNull
        @Override
        public PageItemsRecyclerView.ItemsViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
            return new PageItemsRecyclerView.ItemsViewHolder(new PageItemHorizontalView(parent.getContext()));
        }
        @Override
        public abstract void onBindViewHolder(@NonNull PageItemsRecyclerView.ItemsViewHolder holder, int position);

        public static ItemsHorizontalPageView.ItemsAdapter<CharacterModel> createCharactersAdapter(){
            return new ItemsHorizontalPageView.ItemsAdapter<CharacterModel>() {
                @Override
                public void onBindViewHolder(@NonNull PageItemsRecyclerView.ItemsViewHolder holder, int position) {
                    if (holder._PageItemView != null)
                        holder._PageItemView.setCharacter(_Items.get(position));
                }
            };
        }
        public static ItemsHorizontalPageView.ItemsAdapter<FactionModel> createFactionsAdapter(){
            return new ItemsHorizontalPageView.ItemsAdapter<FactionModel>() {
                @Override
                public void onBindViewHolder(@NonNull PageItemsRecyclerView.ItemsViewHolder holder, int position) {
                    if (holder._PageItemView != null)
                        holder._PageItemView.setFaction(_Items.get(position));
                }
            };
        }
        public static ItemsHorizontalPageView.ItemsAdapter<ManufacturerModel> createManufacturersAdapter(){
            return new ItemsHorizontalPageView.ItemsAdapter<ManufacturerModel>() {
                @Override
                public void onBindViewHolder(@NonNull PageItemsRecyclerView.ItemsViewHolder holder, int position) {
                    if (holder._PageItemView != null)
                        holder._PageItemView.setManufacturer(_Items.get(position));
                }
            };
        }
        public static ItemsHorizontalPageView.ItemsAdapter<PlanetModel> createPlanetsAdapter(){
            return new ItemsHorizontalPageView.ItemsAdapter<PlanetModel>() {
                @Override
                public void onBindViewHolder(@NonNull PageItemsRecyclerView.ItemsViewHolder holder, int position) {
                    if (holder._PageItemView != null)
                        holder._PageItemView.setPlanet(_Items.get(position));
                }
            };
        }
        public static ItemsHorizontalPageView.ItemsAdapter<SpecieModel> createSpeciesAdapter(){
            return new ItemsHorizontalPageView.ItemsAdapter<SpecieModel>() {
                @Override
                public void onBindViewHolder(@NonNull PageItemsRecyclerView.ItemsViewHolder holder, int position) {
                    if (holder._PageItemView != null)
                        holder._PageItemView.setSpecie(_Items.get(position));
                }
            };
        }
        public static ItemsHorizontalPageView.ItemsAdapter<StarshipModel> createStarshipsAdapter(){
            return new ItemsHorizontalPageView.ItemsAdapter<StarshipModel>() {
                @Override
                public void onBindViewHolder(@NonNull PageItemsRecyclerView.ItemsViewHolder holder, int position) {
                    if (holder._PageItemView != null)
                        holder._PageItemView.setStarship(_Items.get(position));
                }
            };
        }
        public static ItemsHorizontalPageView.ItemsAdapter<VehicleModel> createVehiclesAdapter(){
            return new ItemsHorizontalPageView.ItemsAdapter<VehicleModel>() {
                @Override
                public void onBindViewHolder(@NonNull PageItemsRecyclerView.ItemsViewHolder holder, int position) {
                    if (holder._PageItemView != null)
                        holder._PageItemView.setVehicle(_Items.get(position));
                }
            };
        }
        public static ItemsHorizontalPageView.ItemsAdapter<WeaponModel> createWeaponsAdapter(){
            return new ItemsHorizontalPageView.ItemsAdapter<WeaponModel>() {
                @Override
                public void onBindViewHolder(@NonNull PageItemsRecyclerView.ItemsViewHolder holder, int position) {
                    if (holder._PageItemView != null)
                        holder._PageItemView.setWeapon(_Items.get(position));
                }
            };
        }
    }
    public static class ItemsLayoutManager extends LinearLayoutManager {
        public ItemsLayoutManager(Context context) {
            this(context, LinearLayoutManager.HORIZONTAL, false);
        }
        public ItemsLayoutManager(Context context, int orientation, boolean reverseLayout) {
            super(context, orientation, reverseLayout);
        }
        public ItemsLayoutManager(Context context, AttributeSet attrs, int defStyleAttr, int defStyleRes) {
            super(context, attrs, defStyleAttr, defStyleRes);
        }

        @Override
        public void onLayoutChildren(RecyclerView.Recycler recycler, RecyclerView.State state) {
            try { super.onLayoutChildren(recycler, state); }
            catch (IndexOutOfBoundsException x)
            {
                // IndexOutOfBoundsException Exception on sucessive list refreshes
                // https://stackoverflow.com/questions/31759171/recyclerview-and-java-lang-indexoutofboundsexception-inconsistency-detected-in
            }
        }
    }
}