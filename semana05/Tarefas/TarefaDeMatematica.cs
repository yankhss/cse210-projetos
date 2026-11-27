// Tarefa de matemática: herda nome do estudante, tópico e ObterResumo() da classe Tarefa.
public class TarefaDeMatematica : Tarefa
{
    private string _secaoDoLivro;
    private string _problemas;

    // Os dois primeiros parâmetros vão para o construtor da classe base
    public TarefaDeMatematica(string nomeEstudante, string topico, string secaoDoLivro, string problemas)
        : base(nomeEstudante, topico)
    {
        _secaoDoLivro = secaoDoLivro;
        _problemas = problemas;
    }

    public string ObterListaDeTarefas()
    {
        return $"Capítulo {_secaoDoLivro} Problemas {_problemas}";
    }
}
