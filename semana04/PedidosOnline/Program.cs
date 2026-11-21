using System;

class Program
{
    static void Main(string[] args)
    {
        // Pedido 1 - EUA - Frete $5
        Endereco endereco1 = new Endereco("123 Main St", "Rexburg", "ID", "USA");
        Cliente cliente1 = new Cliente("John Smith", endereco1);
        Pedido pedido1 = new Pedido(cliente1);
        pedido1.AdicionarProduto(new Produto("Laptop", "A101", 999.99, 1));
        pedido1.AdicionarProduto(new Produto("Mouse", "A102", 25.50, 2));
        pedido1.AdicionarProduto(new Produto("Teclado", "A103", 49.99, 1));

        Console.WriteLine("PEDIDO 1");
        Console.WriteLine("Etiqueta de Embalagem:");
        Console.WriteLine(pedido1.ObterEtiquetaEmbalagem());
        Console.WriteLine("Etiqueta de Envio:");
        Console.WriteLine(pedido1.ObterEtiquetaEnvio());
        Console.WriteLine($"Preco Total: ${pedido1.ObterPrecoTotal():F2}");
        Console.WriteLine();

        // Pedido 2 - Brasil - Frete $35
        Endereco endereco2 = new Endereco("Rua das Flores 456", "Sao Jose dos Campos", "SP", "Brasil");
        Cliente cliente2 = new Cliente("Maria Silva", endereco2);
        Pedido pedido2 = new Pedido(cliente2);
        pedido2.AdicionarProduto(new Produto("Livro", "B201", 15.00, 3));
        pedido2.AdicionarProduto(new Produto("Caneca", "B202", 12.50, 2));

        Console.WriteLine("PEDIDO 2");
        Console.WriteLine("Etiqueta de Embalagem:");
        Console.WriteLine(pedido2.ObterEtiquetaEmbalagem());
        Console.WriteLine("Etiqueta de Envio:");
        Console.WriteLine(pedido2.ObterEtiquetaEnvio());
        Console.WriteLine($"Preco Total: ${pedido2.ObterPrecoTotal():F2}");
    }
}