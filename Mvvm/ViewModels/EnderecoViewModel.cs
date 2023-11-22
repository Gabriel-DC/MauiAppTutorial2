using System.Text;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiAppTutorial2.Mvvm.ViewModels
{
    public class EnderecoViewModel : INotifyPropertyChanged
    {
        public ICommand ImprimirEnderecoCommand { get; private set; }

        public EnderecoViewModel()
        {
            ImprimirEnderecoCommand = new Command<string>(ImprimirEndereco);
        }

        private string _nome;
        public string Nome
        {
            get => _nome;
            set
            {
                if (SetField(ref _nome, value))
                {
                    OnPropertyChanged(nameof(Endereco));
                }
            }
        }

        private string _sobrenome;
        public string Sobrenome
        {
            get => _sobrenome;
            set
            {
                if(SetField(ref  _sobrenome, value))
                {
                    OnPropertyChanged(nameof(Endereco));
                }
            }
        }

        private string _rua;
        public string Rua
        {
            get => _rua;
            set
            {
                if (SetField(ref _rua, value))
                {
                    OnPropertyChanged(nameof(Endereco));
                }
            }
        }

        private string _cep;
        public string Cep
        {
            get => _cep;
            set
            {
                if (SetField(ref _cep, value))
                {
                    OnPropertyChanged(nameof(Endereco));
                }
            }
        }

        private string _cidade;
        public string Cidade
        {
            get => _cidade;
            set
            {
                if (SetField(ref _cidade, value))
                {
                    OnPropertyChanged(nameof(Endereco));
                }
            }
        }

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

        private void ImprimirEndereco(string endereco) 
            => Application.Current.MainPage.DisplayAlert("Endereço", endereco, "Ok");

        public void OnPropertyChanged([CallerMemberName] string? propertyName = null)
         => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public event PropertyChangedEventHandler? PropertyChanged;

        private bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null!)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;

            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
