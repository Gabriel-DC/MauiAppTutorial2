using MauiAppTutorial2.Mvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppTutorial2.Mvvm.ViewModels
{
    public class ProdutoViewModel
    {
        public Produto Produto { get; set; }

        public ProdutoViewModel()
        {
            Produto = new Produto
            {
                Nome = "Caderno",
                Preco = 11.99m,
                Estoque = 44,
                Ativo = true,
                DataCompra = DateTime.Now,
                Peso = 117.12d
            };
        }
    }
}
