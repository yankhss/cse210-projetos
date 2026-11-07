using System;

// Responsabilidade: guardar uma entrada do diário (data, comando e resposta)
// e saber se exibir e se converter para uma linha de arquivo CSV.
public class Entrada
{
    public string _data = "";
    public string _textoComando = "";
    public string _textoEntrada = "";

    // Exibe a entrada na tela.
    public void Exibir()
    {
        Console.WriteLine($"Data: {_data} - Pergunta: {_textoComando}");
        Console.WriteLine(_textoEntrada);
        Console.WriteLine();
    }

    // Converte a entrada em uma linha CSV, com cada campo entre aspas.
    // Aspas dentro do texto são duplicadas (padrão do CSV), assim vírgulas
    // e aspas na resposta não quebram o arquivo.
    public string ConverterParaCsv()
    {
        return $"{Proteger(_data)},{Proteger(_textoComando)},{Proteger(_textoEntrada)}";
    }

    private string Proteger(string texto)
    {
        return "\"" + texto.Replace("\"", "\"\"") + "\"";
    }
}
