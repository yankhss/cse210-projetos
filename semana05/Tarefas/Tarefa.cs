// Classe base: o que toda tarefa de casa tem, seja de matemática ou de redação.
public class Tarefa
{
    private string _nomeEstudante;
    private string _topico;

    public Tarefa(string nomeEstudante, string topico)
    {
        _nomeEstudante = nomeEstudante;
        _topico = topico;
    }

    // As classes derivadas usam este getter, porque _nomeEstudante é privado
    public string ObterNomeEstudante()
    {
        return _nomeEstudante;
    }

    public string ObterResumo()
    {
        return $"{_nomeEstudante} - {_topico}";
    }
}
