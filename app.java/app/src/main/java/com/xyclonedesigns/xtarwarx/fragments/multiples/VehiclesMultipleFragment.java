package com.xyclonedesigns.xtarwarx.fragments.multiples;

import android.content.Context;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.VehicleModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.VehicleMultipleViewModel;
import com.xyclonedesigns.xtarwarx.widgets.recyclerview.PageItemsRecyclerView;

import org.jetbrains.annotations.NotNull;

import java.util.List;

public class VehiclesMultipleFragment extends BaseMultipleFragment<VehicleModel, VehicleMultipleViewModel> {
    public VehiclesMultipleFragment(@NonNull Context context , @NonNull StarWarsRepository repository) {
        super(R.string.tablayout_tab_vehicles, R.drawable.ic_icon_starwars_vehicle);
        _ViewModel = new VehicleMultipleViewModel(context, repository) {
            @NotNull
            @Override
            public List<VehicleModel> getModels() {
                return _PageViewItemsAdapter._Items;
            }
            @Override
            public void dataCallback(StarWarsRepository.Data<VehicleModel> data) {
                super.dataCallback(data);
                onDataCallback(data);
            }
        };
    }

    @Override
    protected void onPageViewItemsBindViewHolder(@NonNull PageItemsRecyclerView.ItemsViewHolder<VehicleModel> holder, int position) {
        super.onPageViewItemsBindViewHolder(holder, position);

        if ((position = _PageViewItemsAdapter.getBindViewHolderPosition(position)) == -1)
            return;

        VehicleModel model = _PageViewItemsAdapter._Items.get(position);

        holder._ViewModel = model;
        if (holder._PageItemView != null)
            holder._PageItemView.setVehicle(model);
    }
}