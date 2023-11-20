using MauiAppTutorial2.Mvvm.ViewModels;

namespace MauiAppTutorial2.Mvvm.Views;

public partial class TimesView : ContentPage
{
	public TimesView()
	{
		InitializeComponent();
		BindingContext = new TimesViewModel();
	}
}