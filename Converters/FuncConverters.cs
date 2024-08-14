using Avalonia.Data.Converters;
using Avalonia.Media;
using System;

namespace ColorTemplate.Converters
{
    public static class FuncConverters
    {

        public static FuncValueConverter<Color, Brush> BackgroundColorToBrushConverter { get; } = new FuncValueConverter<Color, Brush>(
            color =>
            {
                double brigthnessTreshold = 0.55;
                bool BackgroundIsDark = Math.Sqrt(color.R * color.R * .241 + color.G * color.G * .691 + color.B * color.B * .068) / 255 >= brigthnessTreshold;

                if (BackgroundIsDark)
                {
                    return new SolidColorBrush(new Color(255, 10, 10, 10));
                }
                return new SolidColorBrush(new Color(255, 210, 210, 210));
            }
        );

        public static FuncValueConverter<string?, Brush?> StringToBrushConverter { get; } = new FuncValueConverter<string?, Brush?>(
            s =>
            {
                if (Color.TryParse(s, out Color color) || Color.TryParse($"#{s}", out color))
                {
                    return new SolidColorBrush(color);
                }
                return null;

            }
        );

        public static FuncValueConverter<string?, Color?> StringToColorConverter { get; } = new FuncValueConverter<string?, Color?>(
            s =>
            {
                Color color;
                if (Color.TryParse(s, out color) || Color.TryParse($"#{s}", out color))
                {
                    return color;
                }
                return null;

            }
        );
    }
}
