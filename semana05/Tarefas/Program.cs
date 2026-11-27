using System;

class Program
{
    static void Main(string[] args)
    {
        // Garante que acentos apareçam certos no terminal
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Classe base
        Tarefa tarefa = new Tarefa("Samuel Silva", "Multiplicação");
        Console.WriteLine(tarefa.ObterResumo());
        Console.WriteLine();

        // Classe derivada de matemática
        TarefaDeMatematica matematica = new TarefaDeMatematica("Roberto Rodriguez", "Frações", "7.3", "8-19");
        Console.WriteLine(matematica.ObterResumo());
        Console.WriteLine(matematica.ObterListaDeTarefas());
        Console.WriteLine();

        // Classe derivada de redação
        TarefaDeRedacao redacao = new TarefaDeRedacao("Maria Antunes", "História da Europa", "As Causas da Segunda Guerra Mundial");
        Console.WriteLine(redacao.ObterResumo());
        Console.WriteLine(redacao.ObterInformacoesDaRedacao());
    }
}
