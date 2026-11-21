public class Produto
{
    private string _nome;
    private string _idProduto;
    private double _preco;
    private int _quantidade;

    public Produto(string nome, string idProduto, double preco, int quantidade)
    {
        _nome = nome;
        _idProduto = idProduto;
        _preco = preco;
        _quantidade = quantidade;
    }

    public string ObterNome() { return _nome; }
    public void DefinirNome(string nome) { _nome = nome; }

    public string ObterIdProduto() { return _idProduto; }
    public void DefinirIdProduto(string id) { _idProduto = id; }

    public double ObterPreco() { return _preco; }
    public void DefinirPreco(double preco) { _preco = preco; }

    public int ObterQuantidade() { return _quantidade; }
    public void DefinirQuantidade(int quantidade) { _quantidade = quantidade; }

    public double ObterCustoTotal()
    {
        return _preco * _quantidade;
    }
}