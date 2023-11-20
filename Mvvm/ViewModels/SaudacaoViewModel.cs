using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiAppTutorial2.Mvvm.ViewModels
{
    public class SaudacaoViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string? propertyMember = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyMember));

        public string Nome { get; set; }


        private string _mensagem;
        public string Mensagem
        { 
            get => _mensagem; 
            set
            {
                _mensagem = value;
                OnPropertyChanged();
            } 
        }

        public ICommand SaudacaoCommand { get; set; }

        public SaudacaoViewModel()
        {
            SaudacaoCommand = new Command(SaudacaoCmd);
        }

        private void SaudacaoCmd()
            => Mensagem = $"Bem-Vindo {Nome}";
    }
}
