package com.xyclonedesigns.xtarwarx.activities;

import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.WindowManager;
import android.widget.Toolbar;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.AppCompatButton;
import androidx.appcompat.widget.ContentFrameLayout;
import androidx.appcompat.widget.LinearLayoutCompat;
import androidx.fragment.app.Fragment;
import androidx.viewpager2.adapter.FragmentStateAdapter;
import androidx.viewpager2.widget.ViewPager2;

import com.google.android.material.appbar.AppBarLayout;
import com.google.android.material.tabs.TabLayout;
import com.google.android.material.tabs.TabLayoutMediator;
import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.fragments.BaseModelFragment;
import com.xyclonedesigns.xtarwarx.fragments.multiples.BaseMultipleFragment;
import com.xyclonedesigns.xtarwarx.fragments.multiples.CharactersMultipleFragment;
import com.xyclonedesigns.xtarwarx.fragments.multiples.FactionsMultipleFragment;
import com.xyclonedesigns.xtarwarx.fragments.multiples.FilmsMultipleFragment;
import com.xyclonedesigns.xtarwarx.fragments.multiples.ManufacturersMultipleFragment;
import com.xyclonedesigns.xtarwarx.fragments.multiples.PlanetsMultipleFragment;
import com.xyclonedesigns.xtarwarx.fragments.multiples.SearchResultsFragment;
import com.xyclonedesigns.xtarwarx.fragments.multiples.SpeciesMultipleFragment;
import com.xyclonedesigns.xtarwarx.fragments.multiples.StarshipsMultipleFragment;
import com.xyclonedesigns.xtarwarx.fragments.multiples.VehiclesMultipleFragment;
import com.xyclonedesigns.xtarwarx.fragments.multiples.WeaponsMultipleFragment;
import com.xyclonedesigns.xtarwarx.fragments.singles.CharacterSingleFragment;
import com.xyclonedesigns.xtarwarx.fragments.singles.FactionSingleFragment;
import com.xyclonedesigns.xtarwarx.fragments.singles.FilmSingleFragment;
import com.xyclonedesigns.xtarwarx.fragments.singles.ManufacturerSingleFragment;
import com.xyclonedesigns.xtarwarx.fragments.singles.PlanetSingleFragment;
import com.xyclonedesigns.xtarwarx.fragments.singles.SpecieSingleFragment;
import com.xyclonedesigns.xtarwarx.fragments.singles.StarshipSingleFragment;
import com.xyclonedesigns.xtarwarx.fragments.singles.VehicleSingleFragment;
import com.xyclonedesigns.xtarwarx.fragments.singles.WeaponSingleFragment;
import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.CharacterModel;
import com.xyclonedesigns.xtarwarx.repository.models.FactionModel;
import com.xyclonedesigns.xtarwarx.repository.models.FilmModel;
import com.xyclonedesigns.xtarwarx.repository.models.ManufacturerModel;
import com.xyclonedesigns.xtarwarx.repository.models.PlanetModel;
import com.xyclonedesigns.xtarwarx.repository.models.SpecieModel;
import com.xyclonedesigns.xtarwarx.repository.models.StarshipModel;
import com.xyclonedesigns.xtarwarx.repository.models.VehicleModel;
import com.xyclonedesigns.xtarwarx.repository.models.WeaponModel;
import com.xyclonedesigns.xtarwarx.views.pagination.PaginationOptionsView;
import com.xyclonedesigns.xtarwarx.views.toolbars.SearchToolbarView;
import com.xyclonedesigns.xtarwarx.views.toolbars.TabLayoutToolbarView;
import com.xyclonedesigns.xtarwarx.widgets.recyclerview.PageItemsRecyclerView;

public class TabLayoutActivity extends AppCompatActivity {
    private boolean _PaginationOptionsLoaded = false;
    private boolean _IsSearchMode = false;

    protected AppBarLayout _AppBarLayout;
    protected LinearLayoutCompat _AppBarLayoutContainer;
    protected ContentFrameLayout _Contentframelayout;
    protected PaginationOptionsView _PaginationOptionsView;
    protected BaseModelFragment _FragmentCurrent;
    protected ViewPager2 _ViewPager2;
    protected StateAdapter _ViewPager2StateAdapter;
    protected TabLayoutMediator _TabLayoutMediator;
    protected SearchToolbarView _SearchToolbarView;
    protected TabLayoutToolbarView _TabLayoutToolbarView;
    protected TabLayout.OnTabSelectedListener _TabLayoutOnTabSelectedListener;

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        getWindow().addFlags(WindowManager.LayoutParams.FLAG_LAYOUT_NO_LIMITS);
        super.onCreate(savedInstanceState);
        setContentView(R.layout.xtarwarx_activity_layout_tablayout);

        _Contentframelayout = findViewById(R.id.xtarwarx_activity_layout_tablayout_contentframelayout);
        _PaginationOptionsView = findViewById(R.id.xtarwarx_activity_layout_tablayout_paginationoptionsview);
        _SearchToolbarView = findViewById(R.id.xtarwarx_activity_layout_tablayout_searchtoolbarview);
        _TabLayoutToolbarView = findViewById(R.id.xtarwarx_activity_layout_tablayout_toolbartablayoutview);
        _AppBarLayoutContainer = findViewById(R.id.xtarwarx_activity_layout_tablayout_linearlayoutcompat);
        _ViewPager2 = findViewById(R.id.xtarwarx_activity_layout_tablayout_viewpager2);
        _AppBarLayout = findViewById(R.id.xtarwarx_activity_layout_tablayout_appbarlayout);

        setSupportActionBar(_TabLayoutToolbarView.getToolbar());

        _ViewPager2.setAdapter(_ViewPager2StateAdapter = new StateAdapter(this));
        _ViewPager2.setOffscreenPageLimit(1);
        _ViewPager2.setUserInputEnabled(false);

        _TabLayoutToolbarView.getTabLayout().addOnTabSelectedListener(_TabLayoutOnTabSelectedListener = new TabLayout.OnTabSelectedListener() {
            @Override
            public void onTabSelected(TabLayout.Tab tab) {
                BaseMultipleFragment fragment = (BaseMultipleFragment)
                        (_FragmentCurrent = _ViewPager2StateAdapter._Fragments[tab.getPosition()]);

                if (fragment._PageView != null) {
                    fragment._PageView._PaginationOptions = _PaginationOptionsView;
                    _PaginationOptionsLoaded = true;
                }

                fragment.refresh(false);
            }
            @Override
            public void onTabUnselected(TabLayout.Tab tab) {
                _PaginationOptionsView.setVisibility(View.GONE);
            }
            @Override
            public void onTabReselected(TabLayout.Tab tab) {
                if (_PaginationOptionsView.getVisibility() == View.VISIBLE)
                    _PaginationOptionsView.setVisibility(View.GONE);
                else {
                    if (!_PaginationOptionsLoaded) {
                        BaseMultipleFragment fragment = _ViewPager2StateAdapter._Fragments[tab.getPosition()];
                        if (fragment._PageView != null && fragment._ViewModel != null) {
                            fragment._PageView._PaginationOptions = _PaginationOptionsView;
                            fragment._PageView._PaginationOptions.setViewModel(fragment._ViewModel._Pagination);

                            _PaginationOptionsLoaded = true;
                        }
                    }

                    _PaginationOptionsView.setVisibility(View.VISIBLE);
                }
            }
        });

        _TabLayoutMediator = new TabLayoutMediator(_TabLayoutToolbarView.getTabLayout(), _ViewPager2, true, (tab, position) -> {
            tab.setCustomView(R.layout.xtarwarx_view_toolbar_tablayout_tab);

            if (!(tab.getCustomView() instanceof AppCompatButton))
                return;

            ((AppCompatButton)tab.getCustomView()).setText(_ViewPager2StateAdapter._Fragments[position]._TextRes);
            ((AppCompatButton)tab.getCustomView()).setCompoundDrawablesRelativeWithIntrinsicBounds(_ViewPager2StateAdapter._Fragments[position]._IconRes, 0, 0, 0);

            tab.getCustomView().setOnClickListener(view -> _TabLayoutToolbarView.getTabLayout().selectTab(tab));
        });
        _TabLayoutMediator.attach();

        reconfigure();
    }

    @Override
    public void onBackPressed() {
        if (_IsSearchMode) {
            _IsSearchMode = false;
            reconfigure();
            return;
        }
        if (_FragmentCurrent != null) {
            _FragmentCurrent = null;
            getSupportFragmentManager().popBackStack();
            reconfigure();
            return;
        }

        super.onBackPressed();
    }
    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        super.onCreateOptionsMenu(menu);
        getMenuInflater().inflate(R.menu.menu_layout_tablayout, menu);
        return true;
    }
    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        boolean result = super.onOptionsItemSelected(item);

        switch (item.getItemId()) {
            case R.id.menu_layout_tablayout_search:
                _IsSearchMode = true;
                _FragmentCurrent = new SearchResultsFragment(this, StarWarsRepository.instance());
                ((SearchResultsFragment)_FragmentCurrent).setSearchToolbarView(_SearchToolbarView);
                navigateTo(_FragmentCurrent);
                reconfigure();
                break;
            case R.id.menu_layout_tablayout_themes:
                break;

            default: break;
        }

        return result;
    }

    protected void reconfigure() {
        if (_FragmentCurrent == null && _ViewPager2StateAdapter != null)
            _FragmentCurrent = _ViewPager2StateAdapter._Fragments[
                    _TabLayoutToolbarView.getTabLayout().getSelectedTabPosition()
            ];

        _TabLayoutToolbarView.setVisibility(
                !_IsSearchMode && _FragmentCurrent instanceof BaseMultipleFragment
                        ? View.VISIBLE
                        : View.GONE
        );
        _SearchToolbarView.setVisibility(_IsSearchMode ? View.VISIBLE : View.GONE);
        _Contentframelayout.setVisibility(
                !_IsSearchMode && _FragmentCurrent instanceof BaseMultipleFragment
                        ? View.GONE
                        : View.VISIBLE
        );

        ((AppBarLayout.LayoutParams)_AppBarLayoutContainer.getLayoutParams())
                .setScrollFlags(
                        _IsSearchMode
                                ?
                                AppBarLayout.LayoutParams.SCROLL_FLAG_ENTER_ALWAYS |
                                AppBarLayout.LayoutParams.SCROLL_FLAG_NO_SCROLL
                                :
                                AppBarLayout.LayoutParams.SCROLL_FLAG_ENTER_ALWAYS |
                                AppBarLayout.LayoutParams.SCROLL_FLAG_EXIT_UNTIL_COLLAPSED |
                                AppBarLayout.LayoutParams.SCROLL_FLAG_SNAP_MARGINS |
                                AppBarLayout.LayoutParams.SCROLL_FLAG_SCROLL
                );
    }
    protected void navigateTo(BaseModelFragment basemodelfragment) {
        getSupportFragmentManager()
                .beginTransaction()
                .replace(_Contentframelayout.getId(), _FragmentCurrent = basemodelfragment)
                .runOnCommit(() -> {
                    reconfigure();
                    basemodelfragment.refresh(true);

                }).commit();
    }

    protected static class StateAdapter extends FragmentStateAdapter {
        StateAdapter(@NonNull TabLayoutActivity layoutTabLayoutActivity) {
            super(layoutTabLayoutActivity.getSupportFragmentManager(), layoutTabLayoutActivity.getLifecycle());

            _LayoutTabLayoutActivity = layoutTabLayoutActivity;
            _Fragments = new BaseMultipleFragment[] {
                    new FilmsMultipleFragment(_LayoutTabLayoutActivity, StarWarsRepository.instance()),
                    new CharactersMultipleFragment(_LayoutTabLayoutActivity, StarWarsRepository.instance()),
                    new FactionsMultipleFragment(_LayoutTabLayoutActivity, StarWarsRepository.instance()),
                    new ManufacturersMultipleFragment(_LayoutTabLayoutActivity, StarWarsRepository.instance()),
                    new PlanetsMultipleFragment(_LayoutTabLayoutActivity, StarWarsRepository.instance()),
                    new SpeciesMultipleFragment(_LayoutTabLayoutActivity, StarWarsRepository.instance()),
                    new StarshipsMultipleFragment(_LayoutTabLayoutActivity, StarWarsRepository.instance()),
                    new VehiclesMultipleFragment(_LayoutTabLayoutActivity, StarWarsRepository.instance()),
                    new WeaponsMultipleFragment(_LayoutTabLayoutActivity, StarWarsRepository.instance()),
            };

            _Fragments[0]._PageViewItemsOnClickListener = (PageItemsRecyclerView.ItemsViewHolder.OnClickListener<FilmModel>)
                        viewHolder -> {
                            if (viewHolder._ViewModel != null)
                                _LayoutTabLayoutActivity.navigateTo(
                                        new FilmSingleFragment(viewHolder._ViewModel, _LayoutTabLayoutActivity, StarWarsRepository.instance())
                                );
                        };
            _Fragments[1]._PageViewItemsOnClickListener = (PageItemsRecyclerView.ItemsViewHolder.OnClickListener<CharacterModel>)
                        viewHolder -> {
                            if (viewHolder._ViewModel != null)
                                _LayoutTabLayoutActivity.navigateTo(
                                        new CharacterSingleFragment(viewHolder._ViewModel, _LayoutTabLayoutActivity, StarWarsRepository.instance())
                                );
                        };
            _Fragments[2]._PageViewItemsOnClickListener = (PageItemsRecyclerView.ItemsViewHolder.OnClickListener<FactionModel>)
                        viewHolder -> {
                            if (viewHolder._ViewModel != null)
                                _LayoutTabLayoutActivity.navigateTo(
                                        new FactionSingleFragment(viewHolder._ViewModel, _LayoutTabLayoutActivity, StarWarsRepository.instance())
                                );
                        };
            _Fragments[3]._PageViewItemsOnClickListener = (PageItemsRecyclerView.ItemsViewHolder.OnClickListener<ManufacturerModel>)
                        viewHolder -> {
                            if (viewHolder._ViewModel != null)
                                _LayoutTabLayoutActivity.navigateTo(
                                        new ManufacturerSingleFragment(viewHolder._ViewModel, _LayoutTabLayoutActivity, StarWarsRepository.instance())
                                );
                        };
            _Fragments[4]._PageViewItemsOnClickListener = (PageItemsRecyclerView.ItemsViewHolder.OnClickListener<PlanetModel>)
                        viewHolder -> {
                            if (viewHolder._ViewModel != null)
                                _LayoutTabLayoutActivity.navigateTo(
                                        new PlanetSingleFragment(viewHolder._ViewModel, _LayoutTabLayoutActivity, StarWarsRepository.instance())
                                );
                        };
            _Fragments[5]._PageViewItemsOnClickListener = (PageItemsRecyclerView.ItemsViewHolder.OnClickListener<SpecieModel>)
                        viewHolder -> {
                            if (viewHolder._ViewModel != null)
                                _LayoutTabLayoutActivity.navigateTo(
                                        new SpecieSingleFragment(viewHolder._ViewModel, _LayoutTabLayoutActivity, StarWarsRepository.instance())
                                );
                        };
            _Fragments[6]._PageViewItemsOnClickListener = (PageItemsRecyclerView.ItemsViewHolder.OnClickListener<StarshipModel>)
                        viewHolder -> {
                            if (viewHolder._ViewModel != null)
                                _LayoutTabLayoutActivity.navigateTo(
                                        new StarshipSingleFragment(viewHolder._ViewModel, _LayoutTabLayoutActivity, StarWarsRepository.instance())
                                );
                        };
            _Fragments[7]._PageViewItemsOnClickListener = (PageItemsRecyclerView.ItemsViewHolder.OnClickListener<VehicleModel>)
                        viewHolder -> {
                            if (viewHolder._ViewModel != null)
                                _LayoutTabLayoutActivity.navigateTo(
                                        new VehicleSingleFragment(viewHolder._ViewModel, _LayoutTabLayoutActivity, StarWarsRepository.instance())
                                );
                        };
            _Fragments[8]._PageViewItemsOnClickListener = (PageItemsRecyclerView.ItemsViewHolder.OnClickListener<WeaponModel>)
                        viewHolder -> {
                            if (viewHolder._ViewModel != null)
                                _LayoutTabLayoutActivity.navigateTo(
                                        new WeaponSingleFragment(viewHolder._ViewModel, _LayoutTabLayoutActivity, StarWarsRepository.instance())
                                );
                        };
        }

        TabLayoutActivity _LayoutTabLayoutActivity;
        BaseMultipleFragment[] _Fragments;

        @Override
        public int getItemCount() {
            return _Fragments.length;
        }
        @NonNull
        @Override
        public Fragment createFragment(int position) {
            return _Fragments[position];
        }
    }
}