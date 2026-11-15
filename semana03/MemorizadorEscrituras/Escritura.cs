using System.Collections.Generic;

public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras;

    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;
        _palavras = new List<Palavra>();
        // Aqui o texto será dividido (Split(' ')) e cada pedaço vira um objeto Palavra.
    }

    public void OcultarPalavrasAleatorias(int quantidade)
    {
    }

    public string ObterTexto()
    {
        return "";
    }

    public bool EstaCompletamenteOculta()
    {
        return false;
    }
}
