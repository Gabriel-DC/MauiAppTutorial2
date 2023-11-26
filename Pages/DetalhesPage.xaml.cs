namespace MauiAppTutorial2.Pages;

public partial class DetalhesPage : ContentPage
{
	public DetalhesPage()
	{
		InitializeComponent();
	}

    public DetalhesPage(string name)
    {
        InitializeComponent();
        EntryNome.Text = name;
    }
}