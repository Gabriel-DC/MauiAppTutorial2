namespace MauiAppTutorial2.Pages;

public partial class PaginaInicial : ContentPage
{
	public PaginaInicial()
	{
		InitializeComponent();
	}

    private async void BtnPaginaInicial_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Pagina2());
    }

    private async void BtnPaginaModal_Clicked(object sender, EventArgs e)
    {
        BtnPaginaModal.IsEnabled = false;
        await Navigation.PushModalAsync(new PaginaModal());
        BtnPaginaModal.IsEnabled = true;
    }

    protected override bool OnBackButtonPressed()
    {
        return true;
    }
}