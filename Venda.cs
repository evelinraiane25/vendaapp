using System;
using System.Collections.Generic;
using System.Text;

namespace Venda
{
    public class Venda
    {
        public Venda(Cliente cliente, Produto produto, decimal valorTotal, int quantidadeTotal, DateTime data, Pagamento pagamento)
        {
            Cliente = cliente;
            Produto = produto;
            ValorTotal = valorTotal;
            QuantidadeTotal = quantidadeTotal;
            Data = data;
            Pagamento = pagamento;
        }

        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }
        public decimal ValorTotal { get; set; }
        public int QuantidadeTotal { get; set; }
        public DateTime Data { get; set; }
        public Pagamento Pagamento { get; set; }
    }
}
