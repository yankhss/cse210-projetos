public class Palavra
{
    private string _texto;
    private bool _estaOculta;

    public Palavra(string texto)
    {
        _texto = texto;
        _estaOculta = false;
    }

    public void Ocultar()
    {
    }

    public void Mostrar()
    {
    }

    public bool EstaOculta()
    {
        return false;
    }

    public string ObterTexto()
    {
        return "";
    }
}
