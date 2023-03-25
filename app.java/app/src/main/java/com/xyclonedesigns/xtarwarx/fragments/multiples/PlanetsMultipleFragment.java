package com.xyclonedesigns.xtarwarx.fragments.multiples;

import android.content.Context;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.PlanetModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.PlanetMultipleViewModel;
import com.xyclonedesigns.xtarwarx.widgets.recyclerview.PageItemsRecyclerView;

import org.jetbrains.annotations.NotNull;

import java.util.List;

public class PlanetsMultipleFragment extends BaseMultipleFragment<PlanetModel, PlanetMultipleViewModel> {
    public PlanetsMultipleFragment(@NonNull Context context , @NonNull StarWarsRepository repository) {
        super(R.string.tablayout_tab_planets, R.drawable.ic_icon_starwars_planet);
        _ViewModel = new PlanetMultipleViewModel(context, repository) {
            @NotNull
            @Override
            public List<PlanetModel> getModels() {
                return _PageViewItemsAdapter._Items;
            }
            @Override
            public void dataCallback(StarWarsRepository.Data<PlanetModel> data) {
                super.dataCallback(data);
                onDataCallback(data);
            }
        };
    }

    @Override
    protected void onPageViewItemsBindViewHolder(@NonNull PageItemsRecyclerView.ItemsViewHolder<PlanetModel> holder, int position) {
        super.onPageViewItemsBindViewHolder(holder, position);

        if ((position = _PageViewItemsAdapter.getBindViewHolderPosition(position)) == -1)
            return;

        PlanetModel model = _PageViewItemsAdapter._Items.get(position);

        holder._ViewModel = model;
        if (holder._PageItemView != null)
            holder._PageItemView.setPlanet(model);
    }
}