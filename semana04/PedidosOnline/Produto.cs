// Um item do pedido: nome, código, preço por unidade e quantidade comprada.
public class Produto
{
    private string _nome;
    private string _id;
    private double _precoUnitario;
    private int _quantidade;

    public Produto(string nome, string id, double precoUnitario, int quantidade)
    {
        _nome = nome;
        _id = id;
        _precoUnitario = precoUnitario;
        _quantidade = quantidade;
    }

    // Preço por unidade vezes a quantidade (US$ 3 x 5 unidades = US$ 15)
    public double CalcularCustoTotal()
    {
        return _precoUnitario * _quantidade;
    }

    public string GetNome()
    {
        return _nome;
    }

    public string GetId()
    {
        return _id;
    }
}
