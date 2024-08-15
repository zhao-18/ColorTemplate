using FluentAvalonia.UI.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using Avalonia.Media;
using System.Text;
using System.Threading.Tasks;

namespace ColorTemplate.Models
{
    public class ColorSet
    {
        public ColorSet() { }

        public ColorSet(ColorWrapper[] colors, string description = "")
        {
            if (colors.Count() != 6)
            {
                throw new ArgumentOutOfRangeException("Must feed array of size 6 into ColorSet ctor");
            }

            Color_0 = colors[0];
            Color_1 = colors[1];
            Color_2 = colors[2];
            Color_3 = colors[3];
            Color_4 = colors[4];
            Color_5 = colors[5];

            Description = description;
        }

        public string Description { get; set; } = string.Empty;

        public ColorWrapper Color_0 { set; get; } = new ColorWrapper(0, 0, 0);

        public ColorWrapper Color_1 { set; get; } = new ColorWrapper(40, 40, 40);

        public ColorWrapper Color_2 { set; get; } = new ColorWrapper(80, 80, 80);

        public ColorWrapper Color_3 { set; get; } = new ColorWrapper(120, 120, 120);

        public ColorWrapper Color_4 { set; get; } = new ColorWrapper(160, 160, 160);

        public ColorWrapper Color_5 { set; get; } = new ColorWrapper(200, 200, 200);
    }
}
