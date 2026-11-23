using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Garante que acentos apareçam certos no terminal
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Video video1 = new Video("Como trocar o óleo do carro em casa", "Oficina do Zé", 754);
        video1.AdicionarComentario(new Comentario("Ana", "Consegui fazer sozinha, valeu!"));
        video1.AdicionarComentario(new Comentario("Marcos", "Qual óleo você usou?"));
        video1.AdicionarComentario(new Comentario("Juliana", "Ótima explicação do filtro."));

        Video video2 = new Video("Teste do fone Sonora X2 depois de 6 meses", "Canal Tech na Mão", 512);
        video2.AdicionarComentario(new Comentario("Pedro", "Comprei semana passada e o grave é bom mesmo."));
        video2.AdicionarComentario(new Comentario("Larissa", "A bateria dura quanto em uso real?"));
        video2.AdicionarComentario(new Comentario("Rafael", "Vale mais que o modelo anterior?"));
        video2.AdicionarComentario(new Comentario("Camila", "Review honesto, obrigada!"));

        Video video3 = new Video("Pão caseiro na airfryer", "Cozinha da Rose", 431);
        video3.AdicionarComentario(new Comentario("Beatriz", "Fiz hoje e ficou ótimo."));
        video3.AdicionarComentario(new Comentario("Lucas", "Qual a marca da sua airfryer?"));
        video3.AdicionarComentario(new Comentario("Fernanda", "Dá para usar farinha integral?"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            video.ExibirInformacoes();
            Console.WriteLine();
        }
    }
}
