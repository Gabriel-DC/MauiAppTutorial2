using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppTutorial2.Mvvm.Models
{
    public class Time
    {
        public string Nome { get; set; }
        public string Escudo { get; set; }

        public Time()
        {
            
        }

        public Time(string nome, string escudo)
        {
            Nome = nome;
            Escudo = escudo;
        }
    }
}
