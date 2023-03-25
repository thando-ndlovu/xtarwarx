package com.xyclonedesigns.xtarwarx.fragments.multiples;

import android.content.Context;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.FactionModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.FactionMultipleViewModel;
import com.xyclonedesigns.xtarwarx.widgets.recyclerview.PageItemsRecyclerView;

import org.jetbrains.annotations.NotNull;

import java.util.List;

public class FactionsMultipleFragment extends BaseMultipleFragment<FactionModel, FactionMultipleViewModel> {
    public FactionsMultipleFragment(@NonNull Context context , @NonNull StarWarsRepository repository) {
        super(R.string.tablayout_tab_factions, R.drawable.ic_icon_starwars_faction);
        _ViewModel = new FactionMultipleViewModel(context, repository){
            @NotNull
            @Override
            public List<FactionModel> getModels() {
                return _PageViewItemsAdapter._Items;
            }
            @Override
            public void dataCallback(StarWarsRepository.Data<FactionModel> data) {
                super.dataCallback(data);
                onDataCallback(data);
            }
        };
    }

    @Override
    protected void onPageViewItemsBindViewHolder(@NonNull PageItemsRecyclerView.ItemsViewHolder<FactionModel> holder, int position) {
        super.onPageViewItemsBindViewHolder(holder, position);

        if ((position = _PageViewItemsAdapter.getBindViewHolderPosition(position)) == -1)
            return;

        FactionModel model = _PageViewItemsAdapter._Items.get(position);

        holder._ViewModel = model;
        if (holder._PageItemView != null)
            holder._PageItemView.setFaction(model);
    }
}