package com.xyclonedesigns.xtarwarx.utils;

import android.os.Build;

import java.time.Period;
import java.util.Iterator;

public class StringUtils  {
    public static String join(CharSequence delim, Iterable<? extends CharSequence> items) {
        if (items == null)
            return "";

        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O)
            return String.join(delim, items);

        StringBuilder stringbuilder = new StringBuilder();
        Iterator<? extends CharSequence> iterator = items.iterator();

        if (iterator.hasNext())
            while (true) {
                stringbuilder.append(iterator.next());

                if (iterator.hasNext())
                    stringbuilder.append(delim);
                else break;
            }

        return stringbuilder.toString();
    }
    public static String microwaveTime(int hours, int minutes, int seconds, int milliseconds) {
        seconds += Math.floorDiv(milliseconds, 1000);
        milliseconds = milliseconds % 1000;
        minutes += Math.floorDiv(seconds, 60);
        seconds = seconds % 60;
        hours += Math.floorDiv(minutes, 60);
        minutes = minutes % 60;

        StringBuilder stringbuilder = new StringBuilder();
// TODO
        return stringbuilder.toString();
    }
    public static String romanNumeral(int value) {
        switch (value) {
            case 1: return "I";
            case 2: return "II";
            case 3: return "III";
            case 4: return "IV";
            case 5: return "V";
            case 6: return "VI";
            case 7: return "VII";
            case 8: return "VIII";
            case 9: return "IX";
            case 10: return "X";
            default: return String.valueOf(value);
        }
    }
}