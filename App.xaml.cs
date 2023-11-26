using MauiAppTutorial2.Mvvm.Views;
using MauiAppTutorial2.Pages;
using MauiAppTutorial2.Services;

namespace MauiAppTutorial2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //ServiceCollection services = new();            
            //services.AddTransient<IAlunoService, AlunoService>();

            //ServiceProvider serviceProvider = services.BuildServiceProvider();
            //IAlunoService alunoService = serviceProvider.GetService<IAlunoService>();

            //MainPage = new NavigationPage(new AlunoNotasView(alunoService));
            MainPage = new NavigationPage(new AlunosPage());
        }
    }
}
