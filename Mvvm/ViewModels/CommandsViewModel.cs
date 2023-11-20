using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiAppTutorial2.Mvvm.ViewModels
{
    public class CommandsViewModel
    {
        public ICommand ButtonClickCommand
            => new Command(async () => await Alerta("Button Click"));

        public ICommand SearchCommand
            => new Command(async (searchText) => await Alerta(searchText?.ToString()));

        private async Task Alerta(string mensagem)
            => await App.Current?.MainPage?.DisplayAlert("Alerta", mensagem, "Ok");


    }
}
