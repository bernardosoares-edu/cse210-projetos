using System;

public class Referencia
{
    private string _livro;
    private int _capitulo;
    private int _versiculo;
    private int _ultimoVersiculo;

    public Referencia(string livro, int capitulo, int versiculo)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculo = versiculo;
        _ultimoVersiculo = 0;
    }

    public Referencia(string livro, int capitulo, int primeiroVersiculo, int ultimoVersiculo)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculo = primeiroVersiculo;
        _ultimoVersiculo = ultimoVersiculo;
    }

    public string ObterTexto()
    {
        if (_ultimoVersiculo == 0 || _ultimoVersiculo == _versiculo)
        {
            return $"{_livro} {_capitulo}:{_versiculo}";
        }
        else
        {
            return $"{_livro} {_capitulo}:{_versiculo}-{_ultimoVersiculo}";
        }
    }
}