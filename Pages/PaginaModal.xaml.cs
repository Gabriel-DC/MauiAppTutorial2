namespace MauiAppTutorial2.Pages;

public partial class PaginaModal : ContentPage
{
	public PaginaModal()
	{
		InitializeComponent();
	}

    private async void Btn1_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopModalAsync();
    }
}