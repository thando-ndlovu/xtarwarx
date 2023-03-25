package com.xyclonedesigns.xtarwarx.utils;

import androidx.annotation.Nullable;

import org.json.JSONArray;
import org.json.JSONException;

import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;

public class JsonUtils {
    @FunctionalInterface
    public interface Function<T, R> {
        R apply(T t) throws JSONException;
    }

    public static @Nullable Date fromStringDate(String str) throws JSONException {
        Date date = null;

        switch (str.length()) {
            case 10:
                String year = str.substring(6, 10);
                String month = str.substring(3, 5);
                String day =  str.substring(0, 2);

                Calendar calendar = Calendar.getInstance();
                calendar.set(Integer.parseInt(year), Integer.parseInt(month), Integer.parseInt(day));

                date = calendar.getTime();
                break;

            default: break;
        }

        return date;
    }
    public static <T> ArrayList<T> fromJsonArrayList(JSONArray array, Function<Object, T> cast) throws JSONException {
        ArrayList<T> arrayList = new ArrayList<>();

        for (int index = 0; index < array.length(); index++)
            arrayList.add(cast.apply(array.get(index)));

        return arrayList;
    }
}