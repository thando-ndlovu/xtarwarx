package com.xyclonedesigns.xtarwarx.repository.models;

import androidx.annotation.Nullable;

import com.xyclonedesigns.xtarwarx.views.page.ImagesHorizontalPageView;

import org.json.JSONException;
import org.json.JSONObject;

import java.net.URI;
import java.util.Arrays;
import java.util.Comparator;

public class StarWarsModelURI {
    public static class JsonKeys {
        public static final String Key = "key";
        public static final String Uri = "uri";
    }
    public static class Keys {
        public static final String AdditionalImage = "AdditionalImage";
        public static final String AdditionalPoster = "AdditionalPoster";
        public static final String Fandom = "Fandom";
        public static final String IGN = "IGN";
        public static final String IMDB = "IMDB";
        public static final String Insignia = "Insignia";
        public static final String MainImage = "MainImage";
        public static final String MainPoster = "MainPoster";
        public static final String RottenTomatoes = "RottenTomatoes";
        public static final String ThumbnailSmall = "ThumbnailSmall";
        public static final String ThumbnailMedium = "ThumbnailMedium";
        public static final String ThumbnailLarge = "ThumbnailLarge";
        public static final String Wikipedia = "Wikipedia";


        public static boolean isExternal(StarWarsModelURI key) {
            if (key._Key == null)
                return false;

            return
                    Fandom.equalsIgnoreCase(key._Key) ||
                    IGN.equalsIgnoreCase(key._Key) ||
                    IMDB.equalsIgnoreCase(key._Key) ||
                    RottenTomatoes.equalsIgnoreCase(key._Key) ||
                    Wikipedia.equalsIgnoreCase(key._Key);
        }
        public static boolean isImage(StarWarsModelURI key) {
            if (key._Key == null)
                return false;

            return
                    AdditionalImage.equalsIgnoreCase(key._Key) ||
                    AdditionalPoster.equalsIgnoreCase(key._Key) ||
                    Insignia.equalsIgnoreCase(key._Key) ||
                    MainImage.equalsIgnoreCase(key._Key) ||
                    MainPoster.equalsIgnoreCase(key._Key) ||
                    ThumbnailSmall.equalsIgnoreCase(key._Key) ||
                    ThumbnailMedium.equalsIgnoreCase(key._Key) ||
                    ThumbnailLarge.equalsIgnoreCase(key._Key);
        }
    }

    public StarWarsModelURI(JSONObject json) throws JSONException {
        if (!json.isNull(JsonKeys.Key)) _Key = json.getString(JsonKeys.Key);
        if (!json.isNull(JsonKeys.Uri)) _Uri = URI.create(json.getString(JsonKeys.Uri));
    }
    public StarWarsModelURI(@Nullable String key, @Nullable URI uri) {
        _Key = key;
        _Uri = uri;
    }

    public @Nullable String _Key;
    public @Nullable URI _Uri;

    public static class ImagesComparator implements Comparator<StarWarsModelURI> {
        public ImagesComparator() {
            this(TYPE_DEFAULT);
        }
        public ImagesComparator(String type) {
            _Type = type;
        }

        public static final String TYPE_DEFAULT = "TYPE_DEFAULT";
        public static final String TYPE_FACTION = "TYPE_FACTION";
        public static final String TYPE_FILM = "TYPE_FILM";

        static final String[] TYPE_DEFAULT_KEYS = new String[] {
                Keys.MainImage,
                Keys.MainPoster,
                Keys.AdditionalImage,
                Keys.AdditionalPoster,
                Keys.ThumbnailSmall,
                Keys.ThumbnailMedium,
                Keys.ThumbnailLarge,
                Keys.Insignia,
        };
        static final String[] TYPE_FACTION_KEYS = new String[] {
                Keys.Insignia,
                Keys.MainImage,
                Keys.MainPoster,
                Keys.AdditionalImage,
                Keys.AdditionalPoster,
                Keys.ThumbnailSmall,
                Keys.ThumbnailMedium,
                Keys.ThumbnailLarge,
        };
        static final String[] TYPE_FILM_KEYS = new String[] {
                Keys.MainPoster,
                Keys.MainImage,
                Keys.AdditionalImage,
                Keys.AdditionalPoster,
                Keys.ThumbnailSmall,
                Keys.ThumbnailMedium,
                Keys.ThumbnailLarge,
                Keys.Insignia,
        };

        private final String _Type;

        @Override
        public int compare(StarWarsModelURI uri1, StarWarsModelURI uri2) {
            if (uri1._Key == null && uri2._Key == null)
                return 0;
            else if (uri1._Key != null && uri2._Key == null)
                return 1;
            else if (uri1._Key == null)
                return -1;
            else switch (_Type) {
                case TYPE_DEFAULT:
                    return Arrays.binarySearch(TYPE_DEFAULT_KEYS, uri1._Key) - Arrays.binarySearch(TYPE_DEFAULT_KEYS, uri2._Key);
                case TYPE_FACTION:
                    return Arrays.binarySearch(TYPE_FACTION_KEYS, uri1._Key) - Arrays.binarySearch(TYPE_FACTION_KEYS, uri2._Key);
                case TYPE_FILM:
                    return Arrays.binarySearch(TYPE_FILM_KEYS, uri1._Key) - Arrays.binarySearch(TYPE_FILM_KEYS, uri2._Key);

                default: return 0;
            }
        }
    }
    public static ImagesComparator ImagesComparatorDefault() {
        return new ImagesComparator(ImagesComparator.TYPE_DEFAULT);
    }
    public static ImagesComparator ImagesComparatorFactions() {
        return new ImagesComparator(ImagesComparator.TYPE_FACTION);
    }
    public static ImagesComparator ImagesComparatorFilms() {
        return new ImagesComparator(ImagesComparator.TYPE_FILM);
    }
}