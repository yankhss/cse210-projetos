// Endereço de entrega. Só esta classe sabe em que país o endereço fica.
public class Endereco
{
    private string _rua;
    private string _cidade;
    private string _estado;
    private string _pais;

    public Endereco(string rua, string cidade, string estado, string pais)
    {
        _rua = rua;
        _cidade = cidade;
        _estado = estado;
        _pais = pais;
    }

    // Aceita "EUA" ou "USA", em maiúsculas ou minúsculas
    public bool EstaNosEUA()
    {
        string pais = _pais.Trim().ToUpper();
        return pais == "EUA" || pais == "USA";
    }

    // Todos os campos juntos, com quebra de linha onde faz sentido
    public string ObterEnderecoCompleto()
    {
        return $"{_rua}\n{_cidade}, {_estado}\n{_pais}";
    }
}
