﻿using Avalonia.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ColorTemplate.Models
{
    public class ColorWrapper
    {

        public ColorWrapper(byte a, byte r, byte g, byte b)
        {
            A = a;
            R = r;
            G = g;
            B = b;
        }

        public ColorWrapper() : this(255, 0, 0, 0) { }

        public ColorWrapper(byte r, byte g, byte b) : this(255, r, g, b) { }

        public ColorWrapper(Color color) : this(color.A, color.R, color.G, color.B) { }

        public byte A { get; set; }
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }

        [JsonIgnore]
        public Color color
        {
            get => Color.FromArgb(A, R, G, B);
        }

        public override string ToString()
        {
            return $"#{R:X2}{G:X2}{B:X2}";
        }
    }
}
