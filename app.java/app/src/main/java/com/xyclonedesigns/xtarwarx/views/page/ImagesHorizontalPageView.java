package com.xyclonedesigns.xtarwarx.views.page;

import android.content.Context;
import android.content.Intent;
import android.net.Uri;
import android.util.AttributeSet;
import android.view.ContextThemeWrapper;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.widget.AppCompatImageButton;
import androidx.appcompat.widget.AppCompatImageView;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.bumptech.glide.Glide;
import com.bumptech.glide.load.resource.bitmap.DownsampleStrategy;
import com.bumptech.glide.load.resource.bitmap.Downsampler;
import com.bumptech.glide.request.RequestOptions;
import com.xyclonedesigns.xtarwarx.R;
import com.xyclonedesigns.xtarwarx.repository.models.StarWarsModel;
import com.xyclonedesigns.xtarwarx.repository.models.StarWarsModelURI;

import java.net.URI;
import java.util.ArrayList;
import java.util.Iterator;

public class ImagesHorizontalPageView extends ItemsHorizontalPageView {
    public ImagesHorizontalPageView(Context context) {
        super(context);
    }
    public ImagesHorizontalPageView(Context context, AttributeSet attr) {
        super(context, attr);
    }
    public ImagesHorizontalPageView(Context context, AttributeSet attr, int styleResId) {
        super(context, attr, styleResId);
    }
    public ImagesHorizontalPageView(Context context, AttributeSet attr, int styleResId, int defStyleRes) {
        super(context, attr, styleResId, defStyleRes);
    }

    @Override
    protected void init(Context context, AttributeSet attr) {
        super.init(context, attr);

        _Items.setAdapter(_ImagesAdapter = new ImagesAdapter());
        _Title.setText(R.string.images);
        _Title.setVisibility(VISIBLE);
    }

    public ImagesAdapter _ImagesAdapter;

    public void setExternalLinks(@Nullable Iterable<StarWarsModelURI> uris) {
        _ImagesAdapter._Uris.clear();

        if (uris == null) {
            if (_IsExternalLinks  && getVisibility() != GONE)
                setVisibility(GONE);
            return;
        }

        if (_IsExternalLinks && getVisibility() != VISIBLE)
            setVisibility(VISIBLE);

        for (StarWarsModelURI starWarsModelURI : uris)
            if (StarWarsModelURI.Keys.isExternal(starWarsModelURI))
                _ImagesAdapter._Uris.add(starWarsModelURI);

        _ImagesAdapter.notifyDataSetChanged();
    }
    public void setImages(@Nullable Iterable<StarWarsModelURI> uris) {
        _ImagesAdapter._Uris.clear();

        if (uris == null)
            return;

        for (StarWarsModelURI starWarsModelURI : uris)
            if (StarWarsModelURI.Keys.isImage(starWarsModelURI))
                _ImagesAdapter._Uris.add(starWarsModelURI);

        _ImagesAdapter.notifyDataSetChanged();
    }
    public void setUris(@Nullable Iterable<StarWarsModelURI> uris) {
        _ImagesAdapter._Uris.clear();

        if (uris == null)
            return;

        for (StarWarsModelURI starWarsModelURI : uris) _ImagesAdapter._Uris.add(starWarsModelURI);

        _ImagesAdapter.notifyDataSetChanged();
    }

    public static class ImagesAdapter extends RecyclerView.Adapter<ImagesViewHolder> {
        ImagesAdapter() {
            _Uris = new ArrayList<>();
        }

        ArrayList<StarWarsModelURI> _Uris;

        @Override
        public int getItemCount() {
            return _Uris.size();
        }
        @NonNull
        @Override
        public ImagesViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
            return new ImagesViewHolder(parent.getContext());
        }
        @Override
        public void onBindViewHolder(@NonNull ImagesViewHolder holder, int position) {
            holder._StarWarsModelURI = _Uris.get(position);

            if (holder._StarWarsModelURI._Uri == null)
                return;

            if (StarWarsModelURI.Keys.isExternal(holder._StarWarsModelURI)) {
                switch (holder._StarWarsModelURI._Key) {
                    case StarWarsModelURI.Keys.Fandom:
                        holder._AppCompatImageView.setImageResource(R.drawable.ic_logo_fandom);
                        break;
                    case StarWarsModelURI.Keys.IGN:
                        holder._AppCompatImageView.setImageResource(R.drawable.ic_logo_ign);
                        break;
                    case StarWarsModelURI.Keys.IMDB:
                        holder._AppCompatImageView.setImageResource(R.drawable.ic_logo_imdb);
                        break;
                    case StarWarsModelURI.Keys.RottenTomatoes:
                        holder._AppCompatImageView.setImageResource(R.drawable.ic_logo_rottentomatoes);
                        break;
                    case StarWarsModelURI.Keys.Wikipedia:
                        holder._AppCompatImageView.setImageResource(R.drawable.ic_logo_wikipedia);
                        break;
                    default: break;
                }

                holder._AppCompatImageView.setOnClickListener(new OnClickListener() {
                    @Override
                    public void onClick(View view) {
                        Uri uri = Uri.parse(holder._StarWarsModelURI._Uri.toString());
                        Intent intent = new Intent(Intent.ACTION_VIEW, uri);
                        String title = holder._AppCompatImageView.getResources().getString(R.string.select_browser);
                        Intent chooser = Intent.createChooser(intent, title);
                        holder._AppCompatImageView.getContext()
                                .startActivity(chooser);
                    }
                });
            }
            else Glide.with(holder._AppCompatImageView.getContext())
                .load(Uri.parse(holder._StarWarsModelURI._Uri.toString()))
                //.placeholder(R.drawable.icon_application)
                .override(holder._AppCompatImageView.getResources().getDimensionPixelSize(R.dimen.dp256))
                .centerInside()

                .apply(RequestOptions.downsampleOf(DownsampleStrategy.DEFAULT))
                .into(holder._AppCompatImageView);
            //else holder._AppCompatImageView.setImageURI(Uri.parse(holder._StarWarsModelURI._Uri.toString()));
        }
    }
    public static class ImagesViewHolder extends RecyclerView.ViewHolder {
        static AppCompatImageView _default(Context context) {
            return new AppCompatImageView(context, null, R.style.XtarWarx_View_Model_Images_Image);
        }

        ImagesViewHolder(@NonNull Context context){
            this(_default(context));
        }
        ImagesViewHolder(@NonNull AppCompatImageView appcompatimageview) {
            super(appcompatimageview);

            _AppCompatImageView = appcompatimageview;
        }

        public StarWarsModelURI _StarWarsModelURI;
        public AppCompatImageView _AppCompatImageView;
    }
}