﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppTutorial2.Entities
{
    public class Aluno
    {        
        public Aluno()
        {
            
        }

        public Aluno(string? nome, double nota)
        {
            Nome = nome;
            Nota = nota;
        }

        public string? Nome { get; set; }
        public double Nota { get; set; }
    }
}
