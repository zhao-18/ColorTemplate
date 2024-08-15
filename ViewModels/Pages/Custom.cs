using ReactiveUI;
using FluentAvalonia.UI.Media;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Collections.ObjectModel;
using System;

using ColorTemplate.Models;

namespace ColorTemplate.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    internal void AddCustom()
    {

        Items.Add(
            new PageEntry(
                "Custom",
                "Custom defined set of color to check if things are working or not",
                new ObservableCollection<ColorSet>
                {
                    new ColorSet([
                        new ColorWrapper(10, 10, 10),
                        new ColorWrapper(40, 40, 40),
                        new ColorWrapper(70, 70, 70),
                        new ColorWrapper(100, 100, 100),
                        new ColorWrapper(130, 130, 130),
                        new ColorWrapper(160, 160, 160)
                    ], "Gradetion 1"),

                    new ColorSet([
                        new ColorWrapper(10, 10, 10),
                        new ColorWrapper(50, 50, 50),
                        new ColorWrapper(90, 90, 90),
                        new ColorWrapper(130, 130, 130),
                        new ColorWrapper(170, 170, 170),
                        new ColorWrapper(210, 210, 210)
                    ], "Gradetion 2"),

                    new ColorSet([
                        new ColorWrapper(8, 8, 8)
                        new ColorWrapper(32, 32, 32),
                        new ColorWrapper(51, 51, 51),
                        new ColorWrapper(74, 74, 74),
                        new ColorWrapper(210, 210, 210),
                        new ColorWrapper(255, 255, 255),
                    ], "Fluent UI Dark theme colors"),

                    new ColorSet([
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                        new ColorWrapper(1, 0, 1),
                        new ColorWrapper(1, 0, 1)
                    ], "Texture not found color")
                }
            )
        );
    }
}