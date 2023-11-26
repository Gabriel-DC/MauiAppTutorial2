namespace MauiAppTutorial2.Pages;

public partial class Pagina2 : ContentPage
{
	public Pagina2()
	{
		InitializeComponent();
	}

    private async void BtnParaPaginaFinal_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new PaginaFinal());
    }

    private async void BtnParaPaginaInicial_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}