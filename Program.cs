using System;

namespace Venda
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente("Evelin", "Rua:Guanabara, 3256, 15600-000, Centro - Fernandópolis/SP", "378.131.808-79", 32);

            var produto = new Produto("Bandeja de Canudos", 20, 1, "Doce de Leite");

            var quantidadeTotal = produto.Quantidade;
            var valorTotal = produto.Valor * quantidadeTotal;
            var data = new DateTime(2022, 3, 27, 11, 30, 0);
            var pagamento = Pagamento.CartaoCredito;

            var venda = new Venda(cliente, produto, valorTotal, quantidadeTotal, data, pagamento);

            Console.WriteLine("Sua venda foi realizada com sucesso!");
            Console.WriteLine($"");
            Console.WriteLine($"");
            Console.WriteLine($"-----------------------------------");
            Console.WriteLine($"Nome: {cliente.Nome}");
            Console.WriteLine($"-----------------------------------");
            Console.WriteLine($"Produto: {produto.Nome}");
            Console.WriteLine($"Preço: {produto.Valor:F2}");
            Console.WriteLine($"Qtde: {produto.Quantidade}");
            Console.WriteLine($"-----------------------------------");
            Console.WriteLine($"Total da Venda: {venda.ValorTotal:F2}");
            Console.WriteLine($"Qtde total: {venda.QuantidadeTotal}");
            Console.WriteLine($"-----------------------------------");
        }
    }
}