public class Cliente
{
    private string _nome;
    private Endereco _endereco;

    public Cliente(string nome, Endereco endereco)
    {
        _nome = nome;
        _endereco = endereco;
    }

    public string ObterNome() { return _nome; }
    public void DefinirNome(string nome) { _nome = nome; }

    public Endereco ObterEndereco() { return _endereco; }
    public void DefinirEndereco(Endereco endereco) { _endereco = endereco; }

    public bool MoraNosEUA()
    {
        return _endereco.EstaNosEUA();
    }
}