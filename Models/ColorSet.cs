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

        public ColorSet(ColorWrapper[] colors)
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
        }

        public ColorWrapper Color_0 { set; get; } = new ColorWrapper(255, 0, 0, 0);
        public string Color_0_Text
        {
            get
            {
                return $"#{Color_0.R:X2}{Color_0.G:X2}{Color_0.B:X2}";
            }
        }

        public ColorWrapper Color_1 { set; get; } = new ColorWrapper(40, 40, 40);
        public string Color_1_Text
        {
            get
            {
                return $"#{Color_1.R:X2}{Color_1.G:X2}{Color_1.B:X2}";
            }
        }

        public ColorWrapper Color_2 { set; get; } = new ColorWrapper(80, 80, 80);
        public string Color_2_Text
        {
            get
            {
                return $"#{Color_2.R:X2}{Color_2.G:X2}{Color_2.B:X2}";
            }
        }


        public ColorWrapper Color_3 { set; get; } = new ColorWrapper(120, 120, 120);
        public string Color_3_Text
        {
            get
            {
                return $"#{Color_3.R:X2}{Color_3.G:X2}{Color_3.B:X2}";
            }
        }


        public ColorWrapper Color_4 { set; get; } = new ColorWrapper(160, 160, 160);
        public string Color_4_Text
        {
            get
            {
                return $"#{Color_4.R:X2}{Color_4.G:X2}{Color_4.B:X2}";
            }
        }


        public ColorWrapper Color_5 { set; get; } = new ColorWrapper(200, 200, 200);
        public string Color_5_Text
        {
            get
            {
                return $"#{Color_5.R:X2}{Color_5.G:X2}{Color_5.B:X2}";
            }
        }
    }
}
