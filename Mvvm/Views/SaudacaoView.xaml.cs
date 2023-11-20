using MauiAppTutorial2.Mvvm.ViewModels;

namespace MauiAppTutorial2.Mvvm.Views;

public partial class SaudacaoView : ContentPage
{
	public SaudacaoView()
	{
		InitializeComponent();
		BindingContext = new SaudacaoViewModel();
	}
}