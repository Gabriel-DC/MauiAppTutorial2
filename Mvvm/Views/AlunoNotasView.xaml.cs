using MauiAppTutorial2.Services;

namespace MauiAppTutorial2.Mvvm.Views;

public partial class AlunoNotasView : ContentPage
{
	private readonly IAlunoService _alunoService;

	public AlunoNotasView(IAlunoService alunoService)
	{
		InitializeComponent();
		_alunoService = alunoService;
		ListViewAlunos.ItemsSource = _alunoService.GetAlunos();
	}
}