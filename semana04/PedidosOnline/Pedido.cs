using System.Collections.Generic;

// Um pedido: a lista de produtos e o cliente que vai receber.
public class Pedido
{
    private List<Produto> _produtos;
    private Cliente _cliente;

    public Pedido(Cliente cliente)
    {
        _cliente = cliente;
        _produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        _produtos.Add(produto);
    }

    // Soma o custo de cada produto e acrescenta o frete uma única vez
    public double CalcularCustoTotal()
    {
        double total = 0;

        foreach (Produto produto in _produtos)
        {
            total += produto.CalcularCustoTotal();
        }

        return total + CalcularFrete();
    }

    // Nome e ID de cada produto, um por linha
    public string ObterEtiquetaEmbalagem()
    {
        string etiqueta = "ETIQUETA DE EMBALAGEM\n";

        foreach (Produto produto in _produtos)
        {
            etiqueta += $"{produto.GetNome()} ({produto.GetId()})\n";
        }

        return etiqueta;
    }

    // Nome do cliente seguido do endereço completo
    public string ObterEtiquetaEnvio()
    {
        return $"ETIQUETA DE ENVIO\n{_cliente.GetNome()}\n{_cliente.ObterEnderecoCompleto()}\n";
    }

    // A empresa fica nos EUA: US$ 5 dentro do país, US$ 35 para fora
    private double CalcularFrete()
    {
        if (_cliente.MoraNosEUA())
        {
            return 5;
        }

        return 35;
    }
}
