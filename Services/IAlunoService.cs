using MauiAppTutorial2.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppTutorial2.Services
{
    public interface IAlunoService
    {
        ObservableCollection<Aluno> GetAlunos();
    }
}
