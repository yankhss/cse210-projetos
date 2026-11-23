using System;

public class Fracao
{
    // Atributos privados: só a própria classe acessa
    private int _numerador;
    private int _denominador;

    // Construtor sem parâmetros: 1/1
    public Fracao()
    {
        _numerador = 1;
        _denominador = 1;
    }

    // Construtor com o numerador: o denominador fica 1 (ex.: 5/1)
    public Fracao(int numerador)
    {
        _numerador = numerador;
        _denominador = 1;
    }

    // Construtor com numerador e denominador
    public Fracao(int numerador, int denominador)
    {
        _numerador = numerador;
        _denominador = denominador;
    }

    // Getters e setters
    public int ObterNumerador()
    {
        return _numerador;
    }

    public void DefinirNumerador(int numerador)
    {
        _numerador = numerador;
    }

    public int ObterDenominador()
    {
        return _denominador;
    }

    public void DefinirDenominador(int denominador)
    {
        _denominador = denominador;
    }

    // Representações da fração
    public string ObterFracaoEmTexto()
    {
        return $"{_numerador}/{_denominador}";
    }

    public double ObterFracaoEmDecimal()
    {
        return (double)_numerador / _denominador;
    }
}