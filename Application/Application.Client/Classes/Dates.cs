using System;
using System.Globalization;

namespace Application.Client.Classes;

public class Dates
{
    static CultureInfo CurrentCulture = CultureInfo.CurrentCulture;

    static DayOfWeek FirstDayOfWeek
        => CurrentCulture.DateTimeFormat.FirstDayOfWeek;

    public static int GetAdjustedDayOfWeek(int dayOfWeek) => FirstDayOfWeek switch
    {
        DayOfWeek.Monday when dayOfWeek == 0 => 6,
        DayOfWeek.Monday => dayOfWeek - 1,
        _ => dayOfWeek
    };

    public static string GetDayOfWeekName(int dayOfWeek)
        => CurrentCulture.DateTimeFormat.AbbreviatedDayNames[GetDayNameIndex(dayOfWeek)];

    static int GetDayNameIndex(int dayOfWeek) => FirstDayOfWeek switch
    {
        DayOfWeek.Monday when dayOfWeek == 6 => 0,
        DayOfWeek.Monday => dayOfWeek + 1,
        _ => dayOfWeek
    };
}
