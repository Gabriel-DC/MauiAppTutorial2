
using System.Text.Json;

namespace MauiAppTutorial2.Pages;

public partial class ResourcesPage : ContentPage
{
    public ResourcesPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await LoadMauiAsset();
    }

    private async Task LoadMauiAsset()
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync("modelo.json");
        using var reader = new StreamReader(stream);

        string contents = await reader.ReadToEndAsync();

        Modelo? modelo = JsonSerializer.Deserialize<Modelo>(contents);

        LblTitle.Text = modelo?.Name;

    }

    public class Modelo
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Class { get; set; }
    }

}