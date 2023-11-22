using System.Text;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiAppTutorial2.Mvvm.ViewModels
{
    //[INotifyPropertyChanged]
    public partial class EnderecoViewModel : ObservableObject
    {                
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Endereco))]
        private string? _nome;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Endereco))]
        private string? _sobrenome;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Endereco))]
        private string? _rua;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Endereco))]
        private string? _cep;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Endereco))]
        private string? _cidade;

        public string Endereco {
            get
            {
                StringBuilder stringBuilder = new();

                stringBuilder
                    .AppendLine($"{Nome} {Sobrenome}")
                    .AppendLine(Rua)
                    .AppendLine($"{Cep} - {Cidade}");

                return stringBuilder.ToString();
            }
        }

        [RelayCommand]
        private void ImprimirEndereco(string endereco) 
            => Application.Current.MainPage.DisplayAlert("Endereço", endereco, "Ok");                
    }
}
