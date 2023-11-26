namespace MauiAppTutorial2.Pages;

public partial class PaginaFinal : ContentPage
{
	public PaginaFinal()
	{
		InitializeComponent();
	}

    private async void BtnParaPagina2_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopToRootAsync();
    }    

    private async void BtnParaPaginaInicial_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}