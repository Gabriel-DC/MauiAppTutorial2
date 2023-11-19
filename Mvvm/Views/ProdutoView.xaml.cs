using MauiAppTutorial2.Mvvm.Models;
using MauiAppTutorial2.Mvvm.ViewModels;

namespace MauiAppTutorial2.Mvvm.Views;

public partial class ProdutoView : ContentPage
{
	public ProdutoView()
	{
		InitializeComponent();
		BindingContext = new ProdutoViewModel();
	}
}