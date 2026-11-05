using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual é a sua nota em porcentagem? ");
        string entrada = Console.ReadLine();
        int nota = int.Parse(entrada);

        string letra;

        if (nota >= 90)
        {
            letra = "A";
        }
        else if (nota >= 80)
        {
            letra = "B";
        }
        else if (nota >= 70)
        {
            letra = "C";
        }
        else if (nota >= 60)
        {
            letra = "D";
        }
        else
        {
            letra = "F";
        }

        Console.WriteLine($"Sua nota conceitual é: {letra}");

        if (nota >= 70)
        {
            Console.WriteLine("Parabéns, você foi aprovado(a) no curso!");
        }
        else
        {
            Console.WriteLine("Não desanime! Continue estudando e você vai conseguir na próxima vez.");
        }
    }
}