using Avalonia.Data.Converters;
using System;
using System.Globalization;

namespace wetherio.Converters;

public class SpellColorConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is string light)
        {
            return light.ToLower() switch
            {
                "blue" => "#5E81AC",
                "red" => "#BF616A",
                "green" => "#A3BE8C",
                "purple" => "#B48EAD",
                "white" => "#ECEFF4",
                "yellow" => "#EBCB8B",
                _ => "#4C566A"
            };
        }
        return "#4C566A";
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
