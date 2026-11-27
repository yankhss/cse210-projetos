// Quem fez o pedido: o nome e o endereço de entrega.
public class Cliente
{
    private string _nome;
    private Endereco _endereco;

    public Cliente(string nome, Endereco endereco)
    {
        _nome = nome;
        _endereco = endereco;
    }

    // O cliente não olha o país: pergunta ao próprio endereço
    public bool MoraNosEUA()
    {
        return _endereco.EstaNosEUA();
    }

    public string GetNome()
    {
        return _nome;
    }

    public string ObterEnderecoCompleto()
    {
        return _endereco.ObterEnderecoCompleto();
    }
}
