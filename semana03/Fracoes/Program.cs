using System;

class Program
{
    static void Main(string[] args)
    {
        fracao f1 = new fracao();
        fracao f2 = new fracao(6);
        fracao f3 = new fracao(6, 7);

        Console.WriteLine("Frações criadas com sucesso!");
        Console.WriteLine(f1);
        Console.WriteLine(f2);
        Console.WriteLine(f3);

        Console.WriteLine();
        Console.WriteLine("Antes: " + f3.ObterNumerador() + "/" + f3.ObterDenominador());

        f3.DefinirNumerador(10);
        f3.DefinirDenominador(3);

        Console.WriteLine("Depois: " + f3.ObterNumerador() + "/" + f3.ObterDenominador());

        // Métodos para retornar as representações
        fracao F1 = new fracao();
        Console.WriteLine(F1.ObterFracaoEmTexto());
        Console.WriteLine(F1.ObterFracaoEmDecimal());

        fracao F2 = new fracao(5);
        Console.WriteLine(F2.ObterFracaoEmTexto());
        Console.WriteLine(F2.ObterFracaoEmDecimal());

        fracao F3 = new fracao(3, 4);
        Console.WriteLine(F3.ObterFracaoEmTexto());
        Console.WriteLine(F3.ObterFracaoEmDecimal());

        fracao F4 = new fracao(1, 3);
        Console.WriteLine(F4.ObterFracaoEmTexto());
        Console.WriteLine(F4.ObterFracaoEmDecimal());
    }
}