package com.xyclonedesigns.xtarwarx.utils;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.function.Function;

public class ArrayUtils {
    public static @Nullable <T> T search(@Nullable Iterable<T> iterable, @NonNull Function<T, Boolean> func) {
        if (iterable == null)
            return null;

        T t = null;

        for (T value : iterable)
            if (func.apply(t = value))
                break;
            else t = null;

        return t;
    }
    public static <T> int searchIndex(@Nullable Iterable<T> iterable, @NonNull Function<T, Boolean> func) {
        if (iterable == null)
            return -1;

        T t = null;
        int index = 0;

        for (T value : iterable)
            if (func.apply(t = value))
                return index;
            else index++;

        return -1;
    }
    public static @Nullable <T> T[] toArray(@Nullable Iterable<T> iterable, @NonNull T[] array) {
        if (iterable == null)
            return null;

        Iterator<T> iterator = iterable.iterator();
        ArrayList<T> arrayList = new ArrayList<>();

        while (iterator.hasNext())
            arrayList.add(iterator.next());

        return arrayList.toArray(array);
    }
}