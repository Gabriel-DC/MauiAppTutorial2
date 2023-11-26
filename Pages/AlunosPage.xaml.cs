using MauiAppTutorial2.Mvvm.ViewModels;

namespace MauiAppTutorial2.Pages;

public partial class AlunosPage : ContentPage
{
	public AlunosPage()
	{
		InitializeComponent();
	}

    private async void BtnDetalhes_Clicked(object sender, EventArgs e)
    {
		AlunoViewModel viewModel = new AlunoViewModel
		{
			Name = TxtName.Text,
			Email = TxtEmail.Text,
			Age = Convert.ToInt32(TxtAge.Text?.ToString()),
		};

		await Navigation.PushAsync(new DetalhesPage
		{
			BindingContext = viewModel
		});
    }
}