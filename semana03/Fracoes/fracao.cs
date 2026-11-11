using System;

public class fracao
{
    private int _numerador;
    private int _denominador;

    // 1. Construtor sem parâmetros - inicializa como 1/1
    public fracao()
    {
        _numerador = 1;
        _denominador = 1;
    }

    // 2. Construtor com 1 parâmetro - numerador informado, denominador = 1
    // Ex: new fracao(5) -> 5/1
    public fracao(int numerador)
    {
        _numerador = numerador;
        _denominador = 1;
    }

    // 3. Construtor com 2 parâmetros - numerador e denominador
    // Ex: new fracao(3, 4) -> 3/4
    public fracao(int numerador, int denominador)
    {
        _numerador = numerador;
        _denominador = denominador;
    }

    // GETTERS e SETTERS
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

    // 6º PASSO métodos para retornar as representações

    public string ObterFracaoEmTexto()
    {
        return $"{_numerador}/{_denominador}";
    }

    public double ObterFracaoEmDecimal()
    {
        return (double)_numerador / _denominador;
    }

    public override string ToString()
    {
        return $"{_numerador}/{_denominador}";
    }
}