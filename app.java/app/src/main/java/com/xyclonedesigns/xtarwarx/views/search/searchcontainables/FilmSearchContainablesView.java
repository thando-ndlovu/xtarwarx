package com.xyclonedesigns.xtarwarx.views.search.searchcontainables;

import android.content.Context;
import android.util.AttributeSet;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.widget.AppCompatCheckBox;

import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.searchcontainables.FilmSearchContainablesModel;
import com.xyclonedesigns.xtarwarx.views.search.SearchContainablesView;

public class FilmSearchContainablesView extends SearchContainablesView {
    public FilmSearchContainablesView(Context context) {
        super(context);
    }
    public FilmSearchContainablesView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public FilmSearchContainablesView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public FilmSearchContainablesView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        super.init(context, attr);

        _FilmTitle = addContainable(
                R.string.search_filmsearchcontainables_titles_title,
                R.string.search_filmsearchcontainables_descriptions_title
        );
        _OpeningCrawl = addContainable(
                R.string.search_filmsearchcontainables_titles_openingcrawl,
                R.string.search_filmsearchcontainables_descriptions_openingcrawl
        );
        _Description = addContainable(
                R.string.search_filmsearchcontainables_titles_description,
                R.string.search_filmsearchcontainables_descriptions_description
        );
        _Director = addContainable(
                R.string.search_filmsearchcontainables_titles_director,
                R.string.search_filmsearchcontainables_descriptions_director
        );
        _Producers = addContainable(
                R.string.search_filmsearchcontainables_titles_producers,
                R.string.search_filmsearchcontainables_descriptions_producers
        );
        _CastMembers = addContainable(
                R.string.search_filmsearchcontainables_titles_castmembers,
                R.string.search_filmsearchcontainables_descriptions_castmembers
        );
    }

    AppCompatCheckBox _FilmTitle;
    AppCompatCheckBox _Description;
    AppCompatCheckBox _OpeningCrawl;
    AppCompatCheckBox _Director;
    AppCompatCheckBox _CastMembers;
    AppCompatCheckBox _Producers;
    FilmSearchContainablesModel _SearchContainables;

    public @NonNull FilmSearchContainablesModel getSearchContainables() {
        if (_SearchContainables == null)
            _SearchContainables = new FilmSearchContainablesModel();

        _SearchContainables._Title = _FilmTitle.isChecked();
        _SearchContainables._Description = _Description.isChecked();
        _SearchContainables._OpeningCrawl = _OpeningCrawl.isChecked();
        _SearchContainables._Director = _Director.isChecked();
        _SearchContainables._CastMembers = _CastMembers.isChecked();
        _SearchContainables._Producers = _Producers.isChecked();

        return _SearchContainables;
    }
    public void setSearchContainables(@Nullable FilmSearchContainablesModel searchcontainables) {
        _SearchContainables = searchcontainables == null
                ? new FilmSearchContainablesModel()
                : searchcontainables;

        _FilmTitle.setChecked(_SearchContainables._Title);
        _Description.setChecked(_SearchContainables._Description);
        _OpeningCrawl.setChecked(_SearchContainables._OpeningCrawl);
        _Director.setChecked(_SearchContainables._Director);
        _CastMembers.setChecked(_SearchContainables._CastMembers);
        _Producers.setChecked(_SearchContainables._Producers);
    }
}