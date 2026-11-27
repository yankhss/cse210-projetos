using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Garante que acentos apareçam certos no terminal
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Pedido 1: cliente nos EUA (frete de US$ 5)
        Endereco endereco1 = new Endereco("123 Palm St", "Orlando", "FL", "EUA");
        Cliente cliente1 = new Cliente("John Smith", endereco1);
        Pedido pedido1 = new Pedido(cliente1);
        pedido1.AdicionarProduto(new Produto("Caderno", "P101", 4.50, 3));
        pedido1.AdicionarProduto(new Produto("Caneta", "P205", 1.20, 10));

        // Pedido 2: cliente fora dos EUA (frete de US$ 35)
        Endereco endereco2 = new Endereco("Rua Balduíno Taques, 445", "Ponta Grossa", "PR", "Brasil");
        Cliente cliente2 = new Cliente("Mariana Souza", endereco2);
        Pedido pedido2 = new Pedido(cliente2);
        pedido2.AdicionarProduto(new Produto("Mochila", "P310", 39.90, 1));
        pedido2.AdicionarProduto(new Produto("Garrafa térmica", "P412", 12.00, 2));

        List<Pedido> pedidos = new List<Pedido> { pedido1, pedido2 };
        CultureInfo formatoBrasil = new CultureInfo("pt-BR");
        int numero = 1;

        foreach (Pedido pedido in pedidos)
        {
            Console.WriteLine($"========== PEDIDO {numero} ==========");
            Console.WriteLine(pedido.ObterEtiquetaEmbalagem());
            Console.WriteLine(pedido.ObterEtiquetaEnvio());
            Console.WriteLine($"Total: US$ {pedido.CalcularCustoTotal().ToString("N2", formatoBrasil)}");
            Console.WriteLine();
            numero++;
        }
    }
}
