// Um comentário deixado em um vídeo: quem comentou e o que escreveu.
public class Comentario
{
    private string _nome;
    private string _texto;

    public Comentario(string nome, string texto)
    {
        _nome = nome;
        _texto = texto;
    }

    // Devolve a linha pronta para exibir, no formato "Nome: texto"
    public string ObterTexto()
    {
        return $"{_nome}: {_texto}";
    }
}
