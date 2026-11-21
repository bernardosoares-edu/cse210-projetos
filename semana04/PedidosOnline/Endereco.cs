using System;

public class Endereco
{
    private string _rua;
    private string _cidade;
    private string _estado;
    private string _pais;

    public Endereco(string rua, string cidade, string estado, string pais)
    {
        _rua = rua;
        _cidade = cidade;
        _estado = estado;
        _pais = pais;
    }

    public string ObterRua() { return _rua; }
    public void DefinirRua(string rua) { _rua = rua; }

    public string ObterCidade() { return _cidade; }
    public void DefinirCidade(string cidade) { _cidade = cidade; }

    public string ObterEstado() { return _estado; }
    public void DefinirEstado(string estado) { _estado = estado; }

    public string ObterPais() { return _pais; }
    public void DefinirPais(string pais) { _pais = pais; }

    public bool EstaNosEUA()
    {
        return _pais == "USA";
    }

    public string ObterEnderecoCompleto()
    {
        return $"{_rua}\n{_cidade}, {_estado}\n{_pais}";
    }
}