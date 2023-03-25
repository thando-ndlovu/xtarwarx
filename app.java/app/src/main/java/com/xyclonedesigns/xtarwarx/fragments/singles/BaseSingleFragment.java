package com.xyclonedesigns.xtarwarx.fragments.singles;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ScrollView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.widget.LinearLayoutCompat;
import androidx.swiperefreshlayout.widget.SwipeRefreshLayout;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.fragments.BaseModelFragment;
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
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.CharacterMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.FactionMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.FilmMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.ManufacturerMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.PlanetMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.SpecieMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.StarshipMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.VehicleMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.WeaponMultipleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.BaseSingleViewModel;
import com.xyclonedesigns.xtarwarx.viewmodels.singles.PlanetSingleViewModel;
import com.xyclonedesigns.xtarwarx.views.insets.NavigationBarInsetView;
import com.xyclonedesigns.xtarwarx.views.insets.StatusBarInsetView;
import com.xyclonedesigns.xtarwarx.views.models.BaseModelView;

import java.util.function.Consumer;

public abstract class BaseSingleFragment<TViewModel extends BaseSingleViewModel, TModelView extends BaseModelView> extends BaseModelFragment {
    public BaseSingleFragment(@NonNull TViewModel viewModel) {
        super();

        _ViewModel = viewModel;
    }

    protected @Nullable TModelView _ModelView;
    protected @NonNull TViewModel _ViewModel;

    protected abstract TModelView onCreateModelView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState);
    protected CharacterMultipleViewModel characterMultipleViewModel(@NonNull StarWarsRepository repository, @NonNull Consumer<CharacterMultipleViewModel> cons) {
        return new CharacterMultipleViewModel(_ViewModel._Context, repository) {
            @Override
            public void dataCallback(StarWarsRepository.Data<CharacterModel> data) {
                super.dataCallback(data);
                _Models = data._Items;
                cons.accept(this);
            }
        };
    }
    protected FactionMultipleViewModel factionMultipleViewModel(@NonNull StarWarsRepository repository, @NonNull Consumer<FactionMultipleViewModel> cons) {
        return new FactionMultipleViewModel(_ViewModel._Context, repository) {
            @Override
            public void dataCallback(StarWarsRepository.Data<FactionModel> data) {
                super.dataCallback(data);
                _Models = data._Items;
                cons.accept(this);
            }
        };
    }
    protected ManufacturerMultipleViewModel manufacturerMultipleViewModel(@NonNull StarWarsRepository repository, @NonNull Consumer<ManufacturerMultipleViewModel> cons) {
        return new ManufacturerMultipleViewModel(_ViewModel._Context, repository) {
            @Override
            public void dataCallback(StarWarsRepository.Data<ManufacturerModel> data) {
                super.dataCallback(data);
                _Models = data._Items;
                cons.accept(this);
            }
        };
    }
    protected PlanetMultipleViewModel planetMultipleViewModel(@NonNull StarWarsRepository repository, @NonNull Consumer<PlanetMultipleViewModel> cons) {
        return new PlanetMultipleViewModel(_ViewModel._Context, repository) {
            @Override
            public void dataCallback(StarWarsRepository.Data<PlanetModel> data) {
                super.dataCallback(data);
                _Models = data._Items;
                cons.accept(this);
            }
        };
    }
    protected SpecieMultipleViewModel specieMultipleViewModel(@NonNull StarWarsRepository repository, @NonNull Consumer<SpecieMultipleViewModel> cons) {
        return new SpecieMultipleViewModel(_ViewModel._Context, repository) {
            @Override
            public void dataCallback(StarWarsRepository.Data<SpecieModel> data) {
                super.dataCallback(data);
                _Models = data._Items;
                cons.accept(this);
            }
        };
    }
    protected StarshipMultipleViewModel starshipMultipleViewModel(@NonNull StarWarsRepository repository, @NonNull Consumer<StarshipMultipleViewModel> cons) {
        return new StarshipMultipleViewModel(_ViewModel._Context, repository) {
            @Override
            public void dataCallback(StarWarsRepository.Data<StarshipModel> data) {
                super.dataCallback(data);
                _Models = data._Items;
                cons.accept(this);
            }
        };
    }
    protected VehicleMultipleViewModel vehicleMultipleViewModel(@NonNull StarWarsRepository repository, @NonNull Consumer<VehicleMultipleViewModel> cons) {
        return new VehicleMultipleViewModel(_ViewModel._Context, repository) {
            @Override
            public void dataCallback(StarWarsRepository.Data<VehicleModel> data) {
                super.dataCallback(data);
                _Models = data._Items;
                cons.accept(this);
            }
        };
    }
    protected WeaponMultipleViewModel weaponMultipleViewModel(@NonNull StarWarsRepository repository, @NonNull Consumer<WeaponMultipleViewModel> cons) {
        return new WeaponMultipleViewModel(_ViewModel._Context, repository) {
            @Override
            public void dataCallback(StarWarsRepository.Data<WeaponModel> data) {
                super.dataCallback(data);
                _Models = data._Items;
                cons.accept(this);
            }
        };
    }

    @Override
    public void refresh(boolean force) {
        super.refresh(force);

        _ViewModel.dataRequest();
    }

    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        super.onCreateView(inflater, container, savedInstanceState);

        LinearLayoutCompat linearlayoutcompat = new LinearLayoutCompat(inflater.getContext());
        linearlayoutcompat.setBackgroundResource(R.color.ColorBackground);
        linearlayoutcompat.setOrientation(LinearLayoutCompat.VERTICAL);
        linearlayoutcompat.addView(new StatusBarInsetView(inflater.getContext()));
        linearlayoutcompat.addView(_ModelView = onCreateModelView(inflater, container, savedInstanceState));
        linearlayoutcompat.addView(new NavigationBarInsetView(inflater.getContext()));

        ScrollView scrollview = new ScrollView(inflater.getContext());
        scrollview.addView(linearlayoutcompat);

        SwipeRefreshLayout swiperefreshlayout = new SwipeRefreshLayout(inflater.getContext());
        swiperefreshlayout.addView(scrollview);
        swiperefreshlayout.setOnRefreshListener(() -> _ViewModel.dataRequest());

        return swiperefreshlayout;
    }
}