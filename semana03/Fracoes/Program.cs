using System;

class Program
{
    static void Main(string[] args)
    {
        // Os três construtores
        Fracao f1 = new Fracao();
        Console.WriteLine(f1.ObterFracaoEmTexto());
        Console.WriteLine(f1.ObterFracaoEmDecimal());

        Fracao f2 = new Fracao(5);
        Console.WriteLine(f2.ObterFracaoEmTexto());
        Console.WriteLine(f2.ObterFracaoEmDecimal());

        Fracao f3 = new Fracao(3, 4);
        Console.WriteLine(f3.ObterFracaoEmTexto());
        Console.WriteLine(f3.ObterFracaoEmDecimal());

        Fracao f4 = new Fracao(1, 3);
        Console.WriteLine(f4.ObterFracaoEmTexto());
        Console.WriteLine(f4.ObterFracaoEmDecimal());

        // Testando os setters e getters
        Fracao f5 = new Fracao();
        f5.DefinirNumerador(6);
        f5.DefinirDenominador(7);
        Console.WriteLine($"Numerador: {f5.ObterNumerador()}");
        Console.WriteLine($"Denominador: {f5.ObterDenominador()}");
    }
}