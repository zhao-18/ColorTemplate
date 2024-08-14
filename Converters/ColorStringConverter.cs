using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorTemplate.Converters
{
    internal class ColorStringConverter : IValueConverter
    {
        public static readonly ColorStringConverter Instance = new ColorStringConverter();

        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is string s )
            {
                if (targetType.IsAssignableTo(typeof(Color?)))
                {
                    Color color;
                    if (Color.TryParse(s, out color) || Color.TryParse($"#{s}", out color))
                    {
                        return color;
                    }
                }
            }
            return null;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is Color color && targetType.IsAssignableTo(typeof(string)))
            {
                return $"#{color.A:X2}{color.R:X2}{color.G:X2}{color.B:X2}";
            }
            return null;
        }
    }
}
