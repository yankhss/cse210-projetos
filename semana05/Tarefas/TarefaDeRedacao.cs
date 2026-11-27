// Tarefa de redação: herda nome do estudante, tópico e ObterResumo() da classe Tarefa.
public class TarefaDeRedacao : Tarefa
{
    private string _titulo;

    public TarefaDeRedacao(string nomeEstudante, string topico, string titulo)
        : base(nomeEstudante, topico)
    {
        _titulo = titulo;
    }

    // _nomeEstudante é privado na classe base, então o nome vem pelo getter
    public string ObterInformacoesDaRedacao()
    {
        return $"{_titulo}, por {ObterNomeEstudante()}";
    }
}
