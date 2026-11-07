using System;
using System.Collections.Generic;

// Responsabilidade: manter o nome da pessoa e a lista de seus empregos.
public class Curriculo
{
    public string _nome = "";
    public List<Emprego> _empregos = new List<Emprego>();

    // Exibe o nome e, em seguida, cada emprego da lista.
    public void Exibir()
    {
        Console.WriteLine($"Nome: {_nome}");
        Console.WriteLine("Empregos:");

        foreach (Emprego emprego in _empregos)
        {
            emprego.Exibir();
        }
    }
}
