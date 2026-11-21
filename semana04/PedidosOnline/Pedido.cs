using System.Collections.Generic;
using System.Text;

public class Pedido
{
    private List<Produto> _produtos;
    private Cliente _cliente;

    public Pedido(Cliente cliente)
    {
        _cliente = cliente;
        _produtos = new List<Produto>();
    }

    public Cliente ObterCliente() { return _cliente; }
    public void DefinirCliente(Cliente cliente) { _cliente = cliente; }

    public void AdicionarProduto(Produto produto)
    {
        _produtos.Add(produto);
    }

    public double ObterPrecoTotal()
    {
        double total = 0;
        foreach (Produto produto in _produtos)
        {
            total += produto.ObterCustoTotal();
        }

        double frete = 35;
        if (_cliente.MoraNosEUA())
        {
            frete = 5;
        }
        return total + frete;
    }

    public string ObterEtiquetaEmbalagem()
    {
        StringBuilder etiqueta = new StringBuilder();
        foreach (Produto produto in _produtos)
        {
            etiqueta.AppendLine($"{produto.ObterNome()} - ID: {produto.ObterIdProduto()}");
        }
        return etiqueta.ToString();
    }

    public string ObterEtiquetaEnvio()
    {
        return $"{_cliente.ObterNome()}\n{_cliente.ObterEndereco().ObterEnderecoCompleto()}";
    }
}