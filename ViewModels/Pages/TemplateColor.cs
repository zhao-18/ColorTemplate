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
                        new ColorWrapper(1, 1, 1),
                        new ColorWrapper(2, 2, 2),
                        new ColorWrapper(3, 3, 3),
                        new ColorWrapper(4, 4, 4),
                        new ColorWrapper(5, 5, 5),
                        new ColorWrapper(6, 6, 6),
                    ]),

                    new ColorSet([
                        new ColorWrapper(10, 10, 10),
                        new ColorWrapper(20, 20, 20),
                        new ColorWrapper(30, 30, 30),
                        new ColorWrapper(40, 40, 40),
                        new ColorWrapper(50, 50, 50),
                        new ColorWrapper(60, 60, 60)
                    ]),

                    new ColorSet([
                        new ColorWrapper(10, 10, 10),
                        new ColorWrapper(30, 30, 30),
                        new ColorWrapper(50, 50, 50),
                        new ColorWrapper(70, 70, 70),
                        new ColorWrapper(90, 90, 90),
                        new ColorWrapper(110, 110, 110)
                    ]),

                    new ColorSet([
                        new ColorWrapper(10, 10, 10),
                        new ColorWrapper(40, 40, 40),
                        new ColorWrapper(70, 70, 70),
                        new ColorWrapper(100, 100, 100),
                        new ColorWrapper(130, 130, 130),
                        new ColorWrapper(160, 160, 160)
                    ]),

                    new ColorSet([
                        new ColorWrapper(10, 10, 10),
                        new ColorWrapper(50, 50, 50),
                        new ColorWrapper(90, 90, 90),
                        new ColorWrapper(130, 130, 130),
                        new ColorWrapper(170, 170, 170),
                        new ColorWrapper(210, 210, 210)
                    ]),

                    new ColorSet([
                        new ColorWrapper(32, 32, 32),
                        new ColorWrapper(74, 74, 74),
                        new ColorWrapper(51, 51, 51),
                        new ColorWrapper(255, 255, 255),
                        new ColorWrapper(8, 8, 8),
                        new ColorWrapper(210, 210, 210)
                    ]),

                    new ColorSet([
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                    ]),

                    new ColorSet([
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                    ]),

                    new ColorSet([
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                    ]),

                    new ColorSet([
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                    ]),

                    new ColorSet([
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                    ]),

                    new ColorSet([
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                    ]),

                    new ColorSet([
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                    ]),

                    new ColorSet([
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                    ]),

                    new ColorSet([
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                    ]),

                    new ColorSet([
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                    ]),

                    new ColorSet([
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                        new ColorWrapper(255, 0, 220),
                        new ColorWrapper(1, 0, 1),
                    ])
                }
            )
        );
    }
}