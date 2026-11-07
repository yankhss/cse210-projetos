using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

// Responsabilidade: guardar a lista de entradas e salvar/carregar em arquivo.
public class Diario
{
    public List<Entrada> _entradas = new List<Entrada>();

    public void AdicionarEntrada(Entrada novaEntrada)
    {
        _entradas.Add(novaEntrada);
    }

    public void ExibirTodas()
    {
        if (_entradas.Count == 0)
        {
            Console.WriteLine("O diário ainda está vazio.");
            return;
        }

        foreach (Entrada entrada in _entradas)
        {
            entrada.Exibir();
        }
    }

    // Salva em CSV que abre direto no Excel:
    // - "sep=," avisa o Excel (inclusive em português) que o separador é vírgula
    // - UTF-8 com BOM para os acentos aparecerem certos
    public void SalvarEmArquivo(string arquivo)
    {
        using (StreamWriter saida = new StreamWriter(arquivo, false, new UTF8Encoding(true)))
        {
            saida.WriteLine("sep=,");
            saida.WriteLine("Data,Pergunta,Resposta");

            foreach (Entrada entrada in _entradas)
            {
                saida.WriteLine(entrada.ConverterParaCsv());
            }
        }

        Console.WriteLine($"Diário salvo em {arquivo} ({_entradas.Count} entradas).");
    }

    // Carrega o arquivo e substitui as entradas atuais.
    // Retorna false se o arquivo não existir.
    public bool CarregarDeArquivo(string arquivo)
    {
        if (!File.Exists(arquivo))
        {
            Console.WriteLine($"Arquivo {arquivo} não encontrado.");
            return false;
        }

        _entradas.Clear();
        string[] linhas = File.ReadAllLines(arquivo);

        foreach (string linha in linhas)
        {
            // Pula linhas vazias, a linha "sep=," e o cabeçalho
            if (linha.Trim() == "" || linha.StartsWith("sep=") || linha == "Data,Pergunta,Resposta")
            {
                continue;
            }

            List<string> campos = SepararCampos(linha);
            if (campos.Count < 3)
            {
                continue;
            }

            Entrada entrada = new Entrada();
            entrada._data = campos[0];
            entrada._textoComando = campos[1];
            entrada._textoEntrada = campos[2];
            _entradas.Add(entrada);
        }

        Console.WriteLine($"Diário carregado de {arquivo} ({_entradas.Count} entradas).");
        return true;
    }

    // Separa uma linha CSV em campos, respeitando vírgulas e aspas
    // que estejam dentro de um campo entre aspas.
    private List<string> SepararCampos(string linha)
    {
        List<string> campos = new List<string>();
        string atual = "";
        bool dentroDeAspas = false;

        for (int i = 0; i < linha.Length; i++)
        {
            char c = linha[i];

            if (dentroDeAspas)
            {
                if (c == '"')
                {
                    // "" dentro de aspas significa uma aspa no texto
                    if (i + 1 < linha.Length && linha[i + 1] == '"')
                    {
                        atual += '"';
                        i++;
                    }
                    else
                    {
                        dentroDeAspas = false;
                    }
                }
                else
                {
                    atual += c;
                }
            }
            else
            {
                if (c == '"')
                {
                    dentroDeAspas = true;
                }
                else if (c == ',')
                {
                    campos.Add(atual);
                    atual = "";
                }
                else
                {
                    atual += c;
                }
            }
        }

        campos.Add(atual);
        return campos;
    }
}
