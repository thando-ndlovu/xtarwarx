package com.xyclonedesigns.xtarwarx.fragments.multiples;

import android.content.Context;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.CharacterModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.CharacterMultipleViewModel;
import com.xyclonedesigns.xtarwarx.widgets.recyclerview.PageItemsRecyclerView;

import org.jetbrains.annotations.NotNull;

import java.util.List;

public class CharactersMultipleFragment extends BaseMultipleFragment<CharacterModel, CharacterMultipleViewModel> {
    public CharactersMultipleFragment(@NonNull Context context ,@NonNull StarWarsRepository repository) {
        super(R.string.tablayout_tab_characters, R.drawable.ic_icon_starwars_character);
        _ViewModel = new CharacterMultipleViewModel(context, repository) {
            @NotNull
            @Override
            public List<CharacterModel> getModels() {
                return _PageViewItemsAdapter._Items;
            }
            @Override
            public void dataCallback(StarWarsRepository.Data<CharacterModel> data) {
                super.dataCallback(data);
                onDataCallback(data);
            }
        };
    }

    @Override
    protected void onPageViewItemsBindViewHolder(@NonNull PageItemsRecyclerView.ItemsViewHolder<CharacterModel> holder, int position) {
        super.onPageViewItemsBindViewHolder(holder, position);

        if ((position = _PageViewItemsAdapter.getBindViewHolderPosition(position)) == -1)
            return;

        CharacterModel model = _PageViewItemsAdapter._Items.get(position);

        holder._ViewModel = model;
        if (holder._PageItemView != null)
            holder._PageItemView.setCharacter(model);
    }
}