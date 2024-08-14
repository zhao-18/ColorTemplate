using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Input.Platform;
using Avalonia.Interactivity;
using Avalonia.LogicalTree;
using Avalonia.Media;
using ColorTemplate.Models;
using ColorTemplate.ViewModels;
using FluentAvalonia.UI.Controls;
using FluentAvalonia.UI.Windowing;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ColorTemplate.Views;

public partial class MainWindow : AppWindow
{
    public MainWindow()
    {
        InitializeComponent();

        TitleBar.ExtendsContentIntoTitleBar = true;
        TitleBar.TitleBarHitTestType = TitleBarHitTestType.Complex;
    }

    private bool AlertDisplaying = false;

    private async void OnPointerPressed(object? sender, PointerPressedEventArgs e)
    {

        if (sender is not Border border) return;

        Control? Child = border.Child;
        if (Child is not SelectableTextBlock TextBox) return;
        if (string.IsNullOrEmpty(TextBox.Text)) return;

        IClipboard? clipboard = TopLevel.GetTopLevel(this)?.Clipboard;

        if (clipboard is null) return;

        DataObject ColorData = new DataObject();

        ColorData.Set(DataFormats.Text, TextBox.Text);
        await clipboard.SetDataObjectAsync(ColorData);

        AlertText.Text = "Copied " + TextBox.Text;

        AlertDisplaying = true;
        CopyAlert.Opacity = 1;
        CopyAlert.IsVisible = true;
        await Task.Delay(500);
        AlertDisplaying = false;

        for (int i = 0; i < 50; i++)
        {
            if (AlertDisplaying) return;

            CopyAlert.Opacity -= 0.02;
            await Task.Delay(20);
        }

        CopyAlert.IsVisible = false;

    }

    public async void ShowAddColorDialogCommand(object sender, RoutedEventArgs e)
    {
        await NewColorDialog.ShowAsync();
    }

    public async void ShowAddPageDialogCommand(object sender, RoutedEventArgs e)
    {
        await NewPageDialog.ShowAsync();
    }

    public void AddColorCommand(TaskDialogButton sender, EventArgs e)
    {
        ColorWrapper[] param = new ColorWrapper[6];

        param[0] = new ColorWrapper(PickerButton0.Color ?? new Color(255, 0, 0, 0));
        param[1] = new ColorWrapper(PickerButton1.Color ?? new Color(255, 0, 0, 0));
        param[2] = new ColorWrapper(PickerButton2.Color ?? new Color(255, 0, 0, 0));
        param[3] = new ColorWrapper(PickerButton3.Color ?? new Color(255, 0, 0, 0));
        param[4] = new ColorWrapper(PickerButton4.Color ?? new Color(255, 0, 0, 0));
        param[5] = new ColorWrapper(PickerButton5.Color ?? new Color(255, 0, 0, 0));

        if (DataContext is not MainWindowViewModel vm) return;

        vm.AddColor(param);
    }

    public void AddPageCommand(TaskDialogButton sender, EventArgs e)
    {
        if (DataContext is not MainWindowViewModel vm) return;

        vm.AddPage(NewPageName.Text ?? string.Empty, NewPageDescription.Text ?? string.Empty);
    }

}
