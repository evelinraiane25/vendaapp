using System;
using System.Collections.Generic;
using System.Text;

namespace Venda
{
   public class Cliente
    {
        public Cliente(string nome, string endereço, string docomento, int idade) //para criar automatico> ctrl+ponto
        {
            Nome = nome;
            Endereço = endereço;
            Docomento = docomento;
            Idade = idade;
        }

        public string Nome { get; set; }
        public string Endereço { get; set; }
        public string Docomento { get; set; }
        public int Idade { get; set; }




    }
}
