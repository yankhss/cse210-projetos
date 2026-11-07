using System;
using System.Collections.Generic;

// Responsabilidade: guardar a lista de comandos (perguntas) e sortear um.
// As perguntas não se repetem até que todas tenham sido usadas.
public class GeradorDeComando
{
    public List<string> _comandos = new List<string>
    {
        "Quem foi a pessoa mais interessante com quem interagi hoje?",
        "Qual foi a melhor parte do meu dia?",
        "Como vi a mão do Senhor em minha vida hoje?",
        "Qual foi a emoção mais forte que senti hoje?",
        "Se eu pudesse fazer uma coisa hoje, o que seria?",
        "Pelo que sou grato hoje?",
        "O que aprendi hoje que não sabia ontem?",
        "Qual escritura ou pensamento me tocou hoje?"
    };

    public List<string> _restantes = new List<string>();
    public Random _aleatorio = new Random();

    public string ObterComandoAleatorio()
    {
        // Quando todas as perguntas já saíram, recomeça a lista
        if (_restantes.Count == 0)
        {
            _restantes = new List<string>(_comandos);
        }

        int indice = _aleatorio.Next(_restantes.Count);
        string comando = _restantes[indice];
        _restantes.RemoveAt(indice);
        return comando;
    }
}
