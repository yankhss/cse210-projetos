using System;

// Responsabilidade: manter o registro de um emprego
// (empresa, cargo, ano de início e ano de término).
public class Emprego
{
    public string _empresa = "";
    public string _cargo = "";
    public int _anoInicio;
    public int _anoFim;

    // Exibe no formato: Cargo (Empresa) AnoInicio-AnoFim
    public void Exibir()
    {
        Console.WriteLine($"{_cargo} ({_empresa}) {_anoInicio}-{_anoFim}");
    }
}
