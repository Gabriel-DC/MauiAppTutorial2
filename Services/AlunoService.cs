using MauiAppTutorial2.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppTutorial2.Services
{
    public class AlunoService : IAlunoService
    {
        private ObservableCollection<Aluno> _alunos;

        public ObservableCollection<Aluno> GetAlunos()
        {
            _alunos =
            [
                new("Maria", 9.3d),
                new("Paulo", 7.8d),
                new("Sandra", 5.5d),
                new("Carlos", 5.9d),
                new("Salvia", 8.4d),
                new("Jaime", 7.5d),
                new("Debora", 5.3d),
                new("Elena", 7.4d),                
            ];

            return _alunos;
        }
    }
}
