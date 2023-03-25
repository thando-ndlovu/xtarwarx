package com.xyclonedesigns.xtarwarx.fragments.multiples;

import android.content.Context;

import androidx.annotation.NonNull;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.StarWarsRepository;
import com.xyclonedesigns.xtarwarx.repository.models.FilmModel;
import com.xyclonedesigns.xtarwarx.viewmodels.multiples.FilmMultipleViewModel;
import com.xyclonedesigns.xtarwarx.widgets.recyclerview.PageItemsRecyclerView;

import org.jetbrains.annotations.NotNull;

import java.util.List;

public class FilmsMultipleFragment extends BaseMultipleFragment<FilmModel, FilmMultipleViewModel> {
    public FilmsMultipleFragment(@NonNull Context context , @NonNull StarWarsRepository repository) {
        super(R.string.tablayout_tab_films, R.drawable.ic_icon_starwars_film);
        _ViewModel = new FilmMultipleViewModel(context, repository) {
            @NotNull
            @Override
            public List<FilmModel> getModels() {
                return _PageViewItemsAdapter._Items;
            }
            @Override
            public void dataCallback(StarWarsRepository.Data<FilmModel> data) {
                super.dataCallback(data);
                onDataCallback(data);
            }
        };
    }

    @Override
    protected void onPageViewItemsBindViewHolder(@NonNull PageItemsRecyclerView.ItemsViewHolder<FilmModel> holder, int position) {
        super.onPageViewItemsBindViewHolder(holder, position);

        if ((position = _PageViewItemsAdapter.getBindViewHolderPosition(position)) == -1)
            return;

        FilmModel model = _PageViewItemsAdapter._Items.get(position);

        holder._ViewModel = model;
        if (holder._PageItemView != null)
            holder._PageItemView.setFilm(model);
    }
}