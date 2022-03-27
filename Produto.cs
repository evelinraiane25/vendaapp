using System;
using System.Collections.Generic;
using System.Text;

namespace Venda
{
    public class Produto
    {
        public Produto(string nome, decimal valor, int quantidade, string sabor)
        {
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
            Sabor = sabor;
        }

        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public string Sabor { get; set; }


    }
}
