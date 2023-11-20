using MauiAppTutorial2.Mvvm.ViewModels;

namespace MauiAppTutorial2.Mvvm.Views;

public partial class CommandsView : ContentPage
{
	public CommandsView()
	{
		InitializeComponent();
		BindingContext = new CommandsViewModel();
	}
}