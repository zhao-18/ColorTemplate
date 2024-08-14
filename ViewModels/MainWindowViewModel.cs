using ReactiveUI;
using FluentAvalonia.UI.Media;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Collections.ObjectModel;
using System.Reactive.Concurrency;

using ColorTemplate.Models;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Windows.Input;
using FluentAvalonia.UI.Controls;
using System;
using Avalonia.Media;

namespace ColorTemplate.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        //AddCustom();
        RxApp.MainThreadScheduler.Schedule(LoadPagesAsync);
        selectedItem = new PageEntry();
    }

    public PageEntry selectedItem;

    public PageEntry SelectedItem { 
        get { return selectedItem; }
        set
        {
            this.RaiseAndSetIfChanged(ref selectedItem, value);
        }
    }

    public ObservableCollection<PageEntry> Items { get; } = new ObservableCollection<PageEntry>();



    public async Task SavePageEntryAsync(PageEntry PageToSave)
    {

        string cachePath = Path.Combine("./Cache", PageToSave.DisplayName + ".json");

        using (FileStream fs = File.OpenWrite(cachePath))
        {
            await JsonSerializer.SerializeAsync(fs, PageToSave);
        }
    }

    public void AddColor(ColorWrapper[] Param)
    {
        SelectedItem.ColorSet.Add(new ColorSet(Param));
        Task.Run(async () => await SavePageEntryAsync(SelectedItem));
    }

    public void AddPage(string name, string description)
    {
        PageEntry newPage = new PageEntry(name, description);
        Items.Add(newPage);
        SelectedItem = newPage;

        Task.Run(async () => await SavePageEntryAsync(SelectedItem));
    }

    public async void LoadPagesAsync()
    {
        if (!Directory.Exists("./Cache"))
        {
            Directory.CreateDirectory("./Cache");
            // Load Items
            AddCustom();

            foreach(PageEntry page in Items)
            {
                await SavePageEntryAsync(page);
            }
        }
        else
        {
            foreach (string file in Directory.EnumerateFiles("./Cache"))
            {
                if (new DirectoryInfo(file).Extension != ".json") continue;

                await using FileStream fs = File.OpenRead(file);

                PageEntry? Item = await JsonSerializer.DeserializeAsync<PageEntry>(fs);
                if (Item == null) continue;

                Items.Add(Item);
            }
        }

        SelectedItem = Items[0];
    }

}

public class PageEntry
{
    public PageEntry() : this("", "")
    {
    }

    public PageEntry(string name, string description)
    {
        DisplayName = name;
        Description = description;
    }

    public PageEntry(string name, string description, ObservableCollection<ColorSet> colorSet) : this(name, description)
    {
        ColorSet = colorSet;
    }
    public string DisplayName { get; set; }

    public string Description { get; set; }

    public ObservableCollection<ColorSet> ColorSet { get; set; } = new ObservableCollection<ColorSet> { };
}

