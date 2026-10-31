using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();

        Console.WriteLine("Insira uma lista de números e digite 0 quando terminar.");

        int numero = -1;

        while (numero != 0)
        {
            Console.Write("Insira o número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero != 0)
            {
                numeros.Add(numero);
            }
        }

        // --- CÁLCULOS BÁSICOS ---
        int soma = 0;
        int maior = int.MinValue;

        foreach (int n in numeros)
        {
            soma += n;
            if (n > maior)
            {
                maior = n;
            }
        }

        float media = (float)soma / numeros.Count;

        // --- DESAFIO 1: Menor positivo ---
        int menorPositivo = int.MaxValue;
        foreach (int n in numeros)
        {
            if (n > 0 && n < menorPositivo)
            {
                menorPositivo = n;
            }
        }

        // --- RESULTADOS ---
        Console.WriteLine($"A soma é: {soma}");
        Console.WriteLine($"A média é: {media}");
        Console.WriteLine($"O maior número é: {maior}");

        if (menorPositivo != int.MaxValue)
        {
            Console.WriteLine($"O menor número positivo é: {menorPositivo}");
        }

        // --- DESAFIO 2: Ordenar ---
        numeros.Sort();

        Console.WriteLine("A lista reordenada é:");
        foreach (int n in numeros)
        {
            Console.WriteLine(n);
        }
    }
}