using System;
using System.Collections.Generic;

// Um vídeo do YouTube com título, autor, duração e a lista dos seus comentários.
public class Video
{
    private string _titulo;
    private string _autor;
    private int _duracaoSegundos;
    private List<Comentario> _comentarios;

    public Video(string titulo, string autor, int duracaoSegundos)
    {
        _titulo = titulo;
        _autor = autor;
        _duracaoSegundos = duracaoSegundos;
        _comentarios = new List<Comentario>();
    }

    public void AdicionarComentario(Comentario comentario)
    {
        _comentarios.Add(comentario);
    }

    public int ObterQuantidadeComentarios()
    {
        return _comentarios.Count;
    }

    // Mostra os dados do vídeo e, em seguida, todos os comentários
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Título: {_titulo}");
        Console.WriteLine($"Autor: {_autor}");
        Console.WriteLine($"Duração: {FormatarDuracao()} ({_duracaoSegundos} segundos)");
        Console.WriteLine($"Comentários ({ObterQuantidadeComentarios()}):");

        foreach (Comentario comentario in _comentarios)
        {
            Console.WriteLine($"  {comentario.ObterTexto()}");
        }
    }

    // Só o próprio vídeo usa: transforma 754 segundos em "12:34"
    private string FormatarDuracao()
    {
        int minutos = _duracaoSegundos / 60;
        int segundos = _duracaoSegundos % 60;
        return $"{minutos}:{segundos:D2}";
    }
}
