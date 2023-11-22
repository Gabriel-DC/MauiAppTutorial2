using MauiAppTutorial2.Mvvm.ViewModels;

namespace MauiAppTutorial2.Mvvm.Views;

public partial class EnderecoView : ContentPage
{
	public EnderecoView()
	{
		InitializeComponent();
		BindingContext = new EnderecoViewModel();
	}
}