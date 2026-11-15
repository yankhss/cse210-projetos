public class Referencia
{
    private string _livro;
    private int _capitulo;
    private int _versiculoInicial;
    private int _versiculoFinal;

    // Um versículo só. Ex.: João 3:16
    public Referencia(string livro, int capitulo, int versiculo)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculoInicial = versiculo;
        _versiculoFinal = versiculo;
    }

    // Vários versículos. Ex.: Provérbios 3:5-6
    public Referencia(string livro, int capitulo, int versiculoInicial, int versiculoFinal)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculoInicial = versiculoInicial;
        _versiculoFinal = versiculoFinal;
    }

    public string ObterTexto()
    {
        return "";
    }
}
